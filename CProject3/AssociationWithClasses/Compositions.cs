////Composition= Relationship between Two Classes that allows one to contain the other
////*Benefits
////1) Code Re-USe
////2) Flexibilty
////3) A means to Loose-Coupling Apps

////Composition Syntax
//public class Installer
//{
////Notice that this is Private Field for Composition
//private Logger _logger;

////Here, the Contructor of the Installer Class returns a logger Object, which we use to Intialize the Private field above
//public Installer(Logger logger)
//{
//    _logger = logger;
//}
//}

using System;
namespace CProject3.AssociationWithClasses

{
    ////Let's start by creating a Logger Class where we have the common functionality
    public class Logger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}

	////This Method is responsible to Migrate the Data
	public class DBMigrator
	{
		////Here, we created a Constructor and used Composition
		private readonly Logger _logger;

		public DBMigrator(Logger logger)
		{
			_logger = logger;
		}

		public void Migrate()
		{
			_logger.Log("We are Migrating...");
		}
	}

	////Installer
	public class Installer
	{
		private readonly Logger _logger;

		public Installer(Logger logger)
		{
			_logger = logger;
		}

		public void Install()
		{
			_logger.Log("We are Installing the Application.");
		}
	}

	public class Compositions
	{
		//static void Main(string[] args)
		//{
		////Here we need to pass the Logger Object
		////*This is one way to do it 
		//var dbMigrator = new DBMigrator(new Logger());

		////This is the second way to pass the Logger Object
		//var logger = new Logger();
		//var installer = new Installer(logger);

		//dbMigrator.Migrate();

		//installer.Install();
		//}
	}
}