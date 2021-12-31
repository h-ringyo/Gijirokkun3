using System.Data;

namespace Gijirokkun3
{
    /// <summary>
    /// データテーブルのためのユーティリティ他
    /// Util methods for DataTable.
    /// </summary>
    class DataTableUil
    {
        /// <summary>
        /// データテーブルを指定のフィールドでソートするメソッド
        /// Sort the datatable by a specified field.
        /// </summary>
        /// <param name="dt">Target datatable</param>
        /// <param name="field">Name of target field</param>
        /// <param name="orderby">昇順ならasc 降順ならdese</param>
        public static void Sort(ref DataTable dt,string field,string orderby)
        {
            // dtでDataViewをインスタンス化
            DataView dv = new DataView(dt);
            dv.Sort = field + " " + orderby; // ソートする対象と昇順降順の指定
            dt = dv.ToTable();      // 元のdtに上書き
        }
    }

    /// <summary>
    /// コンポーネントを制御するための列挙体
    /// Enumerator for controlling components.
    /// </summary>
    public enum FileModes : int
    {
        FileClosed = 0,
        FileSelected =1
    }
}
