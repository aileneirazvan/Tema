using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Ailenei","Razvan","ED",7);
			string f1 = s1.info();
			Console.WriteLine(f1);
			Student s2 = new Student("Mara","Sabin","ASC",9);
			string f2 = s2.info();
			Console.WriteLine(f2);

			Console.ReadKey();
		}
	}
}
