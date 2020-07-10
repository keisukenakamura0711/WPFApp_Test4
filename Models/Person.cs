namespace WPFApp_Test4.Models
{
    internal enum Gender
    {
        Male,
        Female,
        Unknown,
    }

    class Person
    {
        /// <summary>
        /// 苗字を取得または設定します。
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// 名前を取得または設定します。
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 氏名を取得または設定します。
        /// </summary>
        public string FullName { get { return this.FamilyName + this.FirstName; } }

        /// <summary>
        /// 性別を取得または設定します。
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// 年齢を取得または設定します。
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 認証済みかどうかを取得または設定します。
        /// </summary>
        public bool IsAuthenticated { get; set; }
    }
}
