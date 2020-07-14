namespace Infrastructure
{
    public static class ConstInfo
    {
        #region Secret
        public const string JWT_Secret = "旺财是条狗";
        /// <summary>
        /// jwt 有效期 单位小时
        /// </summary>
        public const double JWT_EffectiveInterval = 2;
        #endregion
        #region ERR Message

        public const string ERR_NotFound = "未找到";
        public const string ERR_NotFound_User = "未找到用户";
        public const string ERR_NotFound_Role = "未找到角色";

        public const string ERR_Add = "新增失败";
        public const string ERR_Add_Role = "新增角色失败";

        public const string ERR_AlreadyHave = "已存在";
        public const string ERR_AlreadyHave_Role = "角色已存在";
        public const string ERR_AlreadyHave_Phone = "手机号已被占用";
        public const string ERR_AlreadyHave_Right = "标题重复";

        public const string ERR_Null = "数据为空";

        public const string ERR_Login = "用户名或密码错误";
        #endregion
    }
}