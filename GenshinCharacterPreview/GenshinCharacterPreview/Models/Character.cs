using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinCharacterPreview.Models
{
    public class Character
    {      
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string ProtraitUrl { get; set; }
        public string NameUrl { get; set; }
        public string ElementUrl { get; set; }
        public string DialogueUrl { get; set; }

        public Character()
        {

        }
    }
}
