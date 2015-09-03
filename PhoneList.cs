// A Class Which is used for PhoneList
// as long as it implements IPhoneNumber.
class PhoneList<T> where T : IPhoneNumber
{
	T[] phList;
	int end;

	public PhoneList()
	{
		phList = new T[10];
		end = 0;
	}

	public bool Add(T newEntry)
	{
		if(end == 10) return false;
		phList[end++] = newEntry;
		return true;
	}

	// Given a name, find and return the phone info
	public T FindByName(string name)
	{
		// Name can be used becaus it is a member of 
		// IPhoneNumber, which is the interface constraint

		for(int i=0; i<end;i++)
		{
			if(phList[i].Name == name)
				return phList[i];
		}

	}

}