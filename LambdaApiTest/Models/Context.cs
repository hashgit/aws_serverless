namespace LambdaApiTest.Models
{
    public class RequestContext
    {
        public Authorizer authorizer { get; set; }
    }

    public class Authorizer
    {
        public Claims claims { get; set; }
    }

    public class Claims
    {
        public string email { get; set; }
        public string sub { get; set; }
    }
}