using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DemoMvvm.ViewModels
{
    class SampleViewModel : VMBase
    {
        private string sampleText;

        public SampleViewModel()
        {
            SampleText = "Texto sin cambiar";
        }

        public string SampleText 
        {
            get { return sampleText;}
            set 
            { 
                sampleText = value;
                RaisePropertyChanged("SampleText");
            }
        }
    }

}
