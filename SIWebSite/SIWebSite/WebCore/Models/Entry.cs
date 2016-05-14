using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIWebSite.WebCore.Models
{
    public class Entry
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreateDate { get; set; }
        public  string Image { get; set; }
    }
}
