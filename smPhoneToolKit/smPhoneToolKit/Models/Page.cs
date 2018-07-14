using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Models
{
    public class Page
    {
        public string Bezeichnung { get; set; }
        public string Source { get; set; }

        public Page(string bezeichnung, string source)
        {
            this.Bezeichnung = bezeichnung;
            this.Source = source;
        }
    }
}
