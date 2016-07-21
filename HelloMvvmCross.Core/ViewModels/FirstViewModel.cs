using MvvmCross.Core.ViewModels;

namespace HelloMvvmCross.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		private string _firstName;
		private string _lastName;
		public string FirstName
		{
			get { return _firstName; }
			set { SetProperty(ref _firstName, value); RaisePropertyChanged(() => FirstName); RaisePropertyChanged(() => FullName); }
		}
		public string LastName
		{
			get { return _lastName; }
			set { SetProperty(ref _lastName, value); RaisePropertyChanged(() => LastName); RaisePropertyChanged(() => FullName); }
		}

		public string FullName
		{
			get { return $"{_firstName} {_lastName}"; }
		}

	}
}
