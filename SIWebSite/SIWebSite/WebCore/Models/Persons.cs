using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIWebSite.WebCore.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
