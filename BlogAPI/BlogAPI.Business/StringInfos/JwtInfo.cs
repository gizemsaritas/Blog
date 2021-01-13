using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:61056";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "gissagissagissa1234";
        public const double Expires = 40;
    }
}
