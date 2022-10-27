using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AuthResponseModel
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public bool IsAuthenticated { get; set; }
        public List<string> Roles { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
