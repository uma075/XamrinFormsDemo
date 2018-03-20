using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamrinFormsDemo.ViewModels
{
    class LoginViewModel: BaseViewModel
    {
        public Action DisplayValidLoginPrompt;
        public Action DisplayInvalidLoginPrompt;


        string userName = string.Empty;
        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }

        string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        string loginMessage = string.Empty;
        public string LoginMessage
        {
            get { return loginMessage; }
            set { SetProperty(ref loginMessage, value); }
        }

        public Command LoginCommand { get; protected set; }
        public LoginViewModel()
        {
            Title = "Login";
            LoginCommand = new Command(ExecuteLoginCommand);

        }
        private void ExecuteLoginCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                // Call API to login method
                if(userName=="uma" && password == "uma")
                {
                    DisplayValidLoginPrompt();                  
                }
                else
                {
                    DisplayInvalidLoginPrompt();
                }
                loginMessage = "Loggged In Successfully.....:)";
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
