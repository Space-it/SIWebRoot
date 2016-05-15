using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIWebSite.WebCore.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
