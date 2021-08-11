using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VideoUploader.Models
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class UserModel : INotifyPropertyChanged
	{
		private string _login;
		private string _password;

		/// <summary>
		/// Логин
		/// </summary>
		public string Login
		{
			get { return _login; }
			set
			{
				_login = value;
				OnPropertyChanged("Login");
			}
		}

		/// <summary>
		/// Пароль
		/// </summary>
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged("Password");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
