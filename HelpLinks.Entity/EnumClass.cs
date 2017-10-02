using System.Collections.Generic;

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
