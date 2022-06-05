using Draft.WPF.Commands;
using Draft.WPF.States.Authenticators;
using Draft.WPF.States.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Draft.WPF.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
		private string _username = "Judori101";
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
				OnPropertyChanged(nameof(CanLogin));
			}
		}

		private string _password;
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
				OnPropertyChanged(nameof(CanLogin));
			}
		}

		public bool CanLogin => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);

		public MessageViewModel ErrorMessageViewModel { get; }

		public string ErrorMessage
		{
			set => ErrorMessageViewModel.Message = value;
		}

		public ICommand LoginCommand { get; }
		public ICommand ViewRegisterCommand { get; }

		public LoginViewModel(IAuthenticator authenticator, IRenavigator loginRenavigator, IRenavigator registerRenavigator)
		{
			ErrorMessageViewModel = new MessageViewModel();

			LoginCommand = new LoginCommand(this, authenticator, loginRenavigator);
			ViewRegisterCommand = new RenavigateCommand(registerRenavigator);
		}

		public override void Dispose()
		{
			ErrorMessageViewModel.Dispose();

			base.Dispose();
		}
	}
}
