// A Class of phone numbers for suppliers
class Supplier(string n, string num)
{
	public Supplier(string n, string num)
	{
		Name = n;
		Number = num;
	}

	// implements IPhoneNumber
	public string Number{get;set;}
	public string Name{get;set;}

	//..
}

