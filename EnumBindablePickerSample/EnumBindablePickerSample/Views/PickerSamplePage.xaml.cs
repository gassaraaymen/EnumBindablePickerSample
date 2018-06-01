using EnumBindablePickerSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnumBindablePickerSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerSamplePage : ContentPage
	{
		public PickerSamplePage ()
		{
			InitializeComponent ();
            BindingContext = new PickerSamplePageViewModel();
        }
	}
}