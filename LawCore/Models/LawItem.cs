using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawCore.Models
{
    public class LawItem
    {
        public int Id { get; set; }
        /// <summary>
        /// article, section, subsection, paragraph, subparagraph, item. clause,rule,regulation,stipulation
        /// </summary>
        public string Category { get; set; }
        public string Content { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}
