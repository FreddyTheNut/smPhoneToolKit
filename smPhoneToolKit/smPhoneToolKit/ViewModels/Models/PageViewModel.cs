using smPhoneToolKit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.ViewModels.Models
{
    public class PageViewModel
    {
        private readonly Page page;

        public PageViewModel(string bezeichnung, string source)
        {
            this.page = new Page(bezeichnung, source);
        }

        public string Bezeichnung
        {
            get { return this.page.Bezeichnung; }
            set { this.page.Bezeichnung = value; }
        }
        public string Source
        {
            get { return this.page.Source; }
            set { this.page.Source = value; }
        }
    }
}
