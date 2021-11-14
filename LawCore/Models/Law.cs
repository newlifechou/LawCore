using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawCore.Models
{
    public class Law
    {
        public int Id { get; set; }
        public string LawName { get; set; }
        public string LawFullName { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}
