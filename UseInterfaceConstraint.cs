// Demonstrate interface constraint
class UseInterfaceConstraint
{
	static void Main()
	{
		// The Following code is Ok because Friend
		// implements IPhoneNumber
		PhoneList<Friend> pList = new PhoneList<Friend>();
		pList.Add(new Friend("Tom", "555-1234", true));
		pList.Add(new Friend("Gary", "123-1234", true));
		pList.Add(new Friend("Dick", "333-1234", true));
		pList.Add(new Friend("Harry", "666-1234", true));
		
		try
		{
			// Find the number of a friend given a name
			Friend frnd = pList.FindByName("Tom");
			Console.Write(frnd.Name + ":" + frnd.Number);
			if(friend.IsWorkNumber)
				Console.WriteLine(" (work)");
			else
				Console.WriteLine();
		}catch(NotFoundException)
		{	
			Console.WriteLine("Not Found");
		}

		Console.WriteLine();

		// The Following code is also Ok beacause Supplier implements IPhoneNumber
		PhoneList<Supplier> pList2 = new PhoneList<Supplier>();
		pList2.Add(new Supplier("Mr. A", "111-1111"));
		pList2.Add(new Supplier("Mr. B", "111-4444"));
		pList2.Add(new Supplier("Mr. C", "111-3333"));
		pList2.Add(new Supplier("Mr. D", "111-2222"));

		try
		{
			// Find the Name of the Supplier given a number
			Supplier sp = pList2.FindByNumber();
			Console.WriteLine(sp.Name + ":" + sp.Number);
		}
		catch(NotFoundException)
		{
			Console.WriteLine(Not Found);			
		}

		// The Following Declaration is invalid because EmailFriend Does not 
		// Implement IPhoneNumber
		// PhoneList<EmailFriend> pList3 = new PhoneList<EmailFriend>(); // Error
	}
}

















