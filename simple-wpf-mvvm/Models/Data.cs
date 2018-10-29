using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_wpf_mvvm.Models
{
	public static partial class Data
	{
		public static string CollectJson()
		{
			return File.ReadAllText("Assets/Data/demo.json");
		}


	}
}
