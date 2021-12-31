using System;
using NAudio.Wave;

namespace Gijirokkun3.SoundTouch
{
    class VariSpSampleProvider : ISampleProvider, IDisposable
    {
        private readonly ISampleProvider sourceProvider;
        private readonly SoundTouchWrapper soundTouch;
        private readonly float[] sourceReadBuffer;
        private readonly float[] soundTouchReadBuffer;
        private readonly int channelCount;
        private float playbackRate = 1.0f;
        private SoundTouchProfile currentSoundTouchProfile;
        private bool repositionRequested;
        public WaveFormat WaveFormat => sourceProvider.WaveFormat;

        // コンストラクタ
        public VariSpSampleProvider(ISampleProvider sourceProvider, int readDurationMilliseconds, SoundTouchProfile soundTouchProfile)
        {
            soundTouch = new SoundTouchWrapper();
            SetSoundTouchProfile(soundTouchProfile);
            this.sourceProvider = sourceProvider;
            soundTouch.SetSampleRate(WaveFormat.SampleRate);    // サンプルレートの設定
            channelCount = WaveFormat.Channels;         // waveファイルからチャンネル数を取得
            soundTouch.SetChannels(channelCount);       // チャンネル数の設定
            sourceReadBuffer = new float[(WaveFormat.SampleRate * channelCount * (long)readDurationMilliseconds) / 1000];
            soundTouchReadBuffer = new float[sourceReadBuffer.Length * 10]; // soureceReadBufferの10倍の量をsoundTouchReadBufferに確保
        }

        #region プロパティ
        public float PlaybackRate
        {
            get
            {
                return playbackRate;
            }
            set
            {
                if (playbackRate != value)
                {
                    UpdatePlaybackRate(value);
                    playbackRate = value;
                }
            }
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 再生率の更新
        /// </summary>
        /// <param name="value">再生率</param>
        private void UpdatePlaybackRate(float value)
        {
            if (value != 0)
            {
                if (currentSoundTouchProfile.UseTempo)
                {
                    soundTouch.SetTempo(value);
                }
                else
                {
                    soundTouch.SetRate(value);
                }
            }
        }

        public int Read(float[] buffer, int offset, int count)
        {
            if (playbackRate == 0) // 再生率0の場合
            {
                for (int n = 0; n < count; n++)
                {
                    buffer[offset++] = 0;   // bufferの中身を0にする
                }
                return count;
            }
            if (repositionRequested)    // reposition要求があったらクリア
            {
                soundTouch.Clear();
                repositionRequested = false;
            }

            int samplesRead = 0;
            bool reachedEndOfSource = false;
            while (samplesRead < count)
            {
                if (soundTouch.NumberOfSamplesAvailable == 0)
                {
                    var readFromSource = sourceProvider.Read(sourceReadBuffer, 0, sourceReadBuffer.Length);
                    if (readFromSource > 0)
                    {
                        soundTouch.PutSamples(sourceReadBuffer, readFromSource / channelCount);
                    }
                    else
                    {
                        // 終わりに達したときの処理
                        reachedEndOfSource = true;
                        soundTouch.Flush();
                    }
                }
                var desiredSampleFrames = (count - samplesRead) / channelCount;

                var received = soundTouch.ReceiveSamples(soundTouchReadBuffer, desiredSampleFrames) * channelCount;
                // bufferのoffset値の後からsoundTouchReadBufferを受け取った分だけコピーしていく
                for (int n = 0; n < received; n++)
                {
                    buffer[offset + samplesRead++] = soundTouchReadBuffer[n];
                }
                if (received == 0 && reachedEndOfSource) break;
            }
            return samplesRead;
        }

        public void SetSoundTouchProfile(SoundTouchProfile soundTouchProfile)
        {
            if (currentSoundTouchProfile != null &&
                playbackRate != 1.0f &&
                soundTouchProfile.UseTempo != currentSoundTouchProfile.UseTempo)
            {
                if (soundTouchProfile.UseTempo)
                {
                    // 変調をする場合
                    soundTouch.SetRate(1.0f);
                    soundTouch.SetPitchOctaves(0f);
                    soundTouch.SetTempo(playbackRate);
                }
                else
                {
                    // 変調をしない場合
                    soundTouch.SetTempo(1.0f);
                    soundTouch.SetRate(playbackRate);
                }
            }
            this.currentSoundTouchProfile = soundTouchProfile;
            soundTouch.SetUseAntiAliasing(soundTouchProfile.UseAntiAliasing);
            soundTouch.SetUseQuickSeek(soundTouchProfile.UseQuickSeek);
        }

        public void Reposition()
        {
            repositionRequested = true;
        }

        public void Dispose()
        {
            soundTouch.Dispose();
        }

        #endregion

    }




}
