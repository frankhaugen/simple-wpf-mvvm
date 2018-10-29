using MinimalMVVM.ViewModels;
using simple_wpf_mvvm.Models;
using System.Windows.Input;

namespace simple_wpf_mvvm.ViewModels
{
	public class Presenter : ObservableObject
	{
		public string _JsonText { get; set; }

		public string JsonText
		{
			get { return _JsonText; }
			set
			{
				_JsonText = value;
				RaisePropertyChangedEvent("JsonText");
			}
		}

		public ICommand CollectJsonData
		{
			get { return new DelegateCommand(Test); }

		}

		private void Test()
		{
			JsonText = Data.CollectJson();
		}
	}
}
