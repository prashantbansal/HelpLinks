using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLinks.Entity
{
    public class EnumClass
    {
        public string EnumName { get; set; }
        public IList<EnumField> EnumFields { get; set; }

        public EnumClass()
        {
            this.EnumFields= new List<EnumField>();
        }
    }
}
