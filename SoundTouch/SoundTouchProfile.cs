
namespace Gijirokkun3.SoundTouch
{
    class SoundTouchProfile
    {
        public bool UseTempo { get; set; }     
        public bool UseAntiAliasing { get; set; }  
        public bool UseQuickSeek { get; set; } 

        public SoundTouchProfile(bool useTempo, bool useAntiAliansing)
        {
            UseTempo = useTempo;
            UseAntiAliasing = useAntiAliansing;
        }
    }
}
