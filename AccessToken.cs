
namespace Infrastructure
{
    public class AccessToken
    {
        public string UserId { get; set; }
        public string NickName { get; set; }
        public string RoleName { get; set; }
        public string Token { get; set; }
        public long ExpireTime { get; set; }
    }
}