using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.StringInfos
{
    public class JwtInfo
    {
        public  string Issuer { get; set;}
        public  string Audience { get; set; }
        public  string SecurityKey { get; set; }
        public  double Expires { get; set; }
    }
}
