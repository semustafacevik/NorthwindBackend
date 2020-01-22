using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.Utilities.Security.Tokens
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
