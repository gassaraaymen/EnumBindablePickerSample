using EnumBindablePickerSample.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnumBindablePickerSample.ViewModels
{
    public class PickerSamplePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PickerSamplePageViewModel()
        {
            //set default value
            SelectedEnum = SampleEnum.Three;
        }

        private SampleEnum selectedEnum;
        public SampleEnum SelectedEnum
        {
            get { return selectedEnum; }
            set
            {
                selectedEnum = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedEnum"));
            }
        }
    }
}
