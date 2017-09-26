﻿////Inheritance = A kind of relationship between two classes that allows one to inherit code from the other
////*Benefits
//// 1) Code Re-USe = Encapsulates one classs and use that later for another classs
//// 2) Polymorphic behavior = 

////Syntax Inheritance Demo
//public class PresentationObject
//{
////Common Shared Code    
//}

//public class Text:PresentationObject
//{
////Code Specific to Text 
//}

using System;
namespace CProject3.AssociationWithClasses
{
    ////Here, we are creating a Class called PresentationObject, which is the Parent Class
    public class PresentationObject
	{
		////Defining Properties
		public int Width { get; set; }
		public int Height { get; set; }

		public void Copy()
		{
			Console.WriteLine("Object copied to Clipboard.");
		}

		public void Duplicate()
		{
			Console.WriteLine("Object was Duplicated.");
		}
	}

	////Notice that we are Inheriting from PresentationObject
	public class Text : PresentationObject
	{
		public int FontSize
		{
			get;
			set;
		}

		public string FontName
		{
			get;
			set;
		}

		////Method to Add HyperLink
		public void AddHyperLink(string url)
		{
			Console.WriteLine("We added a Link to " + url);
		}
	}

	class Inheritances
	{
		//static void Main(string[] args)
		//{
		////Adding Object of Type Text
		//var text = new Text();
		////Notice that "text." is Inherting the Properties of the Parent Class, PresentationObject
		//text.Width = 100;
		//text.Copy();
		//}
	}
}
