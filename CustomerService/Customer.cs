using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
	//public class Customer
	//{
	//	private long id;
	//	private string name;

	//	public Customer(long id, string name)
	//	{
	//		this.id = id;
	//		this.name = name;
	//	}

		
	//}

	public readonly record struct Customer(long Id, string Name);
}
