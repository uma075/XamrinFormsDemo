using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamrinFormsDemo.ViewModels;

namespace XamrinFormsDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        LoginViewModel lvm;
		public LoginPage ()
		{
            lvm = new LoginViewModel();
            BindingContext = lvm;
            lvm.DisplayValidLoginPrompt += () => DisplayAlert("Success", "Sucessfully Loggedin", "OK");
            lvm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent ();

            UserName.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                lvm.LoginCommand.Execute(null);
            };

        }
	}
}