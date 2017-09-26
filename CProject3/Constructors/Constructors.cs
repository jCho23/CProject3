////Constructor = A Method that is called when an instance of a class is created
////Why do we need a Constructor? = To put an object in an early state


////Demo 1
////This is how to Declare a Constructor
////The Constructor is the same name as the class (*REQUIREMENT*)
//public class Constructors
//{
////This is the Constructor
////Constuctors, unlike other Methods, does not have a return type
////If you need to initialize an Object upon creation, use a constuctor 
//    public Constructors()
//    {
//    }
//}


////Demo 2
//public class Customer
//{
////This Name is set below
//    public string Name;

////Here, "string name" is a Parameter
////So we get the name of the customer and set the string up above
//    public Customer(string name)
//    {
//        //"this" = References the current Object and ties it to the "Name" up above
//        this.Name = name;
//    }
//}


////Demo 3
////Constructor Overloading = Having Methods that are the same Name but differnt signatures
////Signature= Something that uniquely identifies that method (return type, name, types and numbers of its parameters)
////Why do we need to overload constructors? ==>
////==Because we may not have all the parameters when creating an Instance of this class

//public class Customer
//{
//    public Customer () {...}

//    public Customer (string name) {...}

//    public Customer (int id, string name) {...}
//}

