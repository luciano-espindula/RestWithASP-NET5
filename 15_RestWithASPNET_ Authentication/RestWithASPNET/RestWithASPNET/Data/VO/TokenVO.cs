namespace RestWithASPNET.Data.VO
{
    public class TokenVO
    {
        public TokenVO(bool authentication, string created, string expiration, string accessToken, string refreshToken)
        {
            Authentication = authentication;
            Created = created;
            Expiration = expiration;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public bool Authentication { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
