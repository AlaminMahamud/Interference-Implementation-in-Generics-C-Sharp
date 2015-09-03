 // Exception class

 using System;
 namespace n1
 {
 	// A Custom Exception that is thrown if a name or number is not found
 	class NotFoundException:Exception
 	{
 		/*
 		Implement all of the Excetpion Constructors 
 		*/

 		// the constructor simply execute the base class constructor
 		// Because NotFoundException add nothing to Exception
 		// there is no need for any further actions

		public NotFoundException() : base (){}
		public NotFoundException(string message) : base(message){} 
		public NotFoundException(string message, Exception innerException) : base(message, innerException){}
		protected NotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context){}
	}

 }