namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Audince { get; set; }
        public string SecurityKey { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
    }
}
