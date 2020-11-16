using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        public string Token { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
