/*
 * Title: Person Class
 * Description: Describes a person who will participate in a tournament. Contains
 *              information necessary to sort person into a seed, and display 
 *              necessary information about person.
 *              
 * Author: Ben Casey
 * Date: 10/25/12
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
	class Person
	{
		//========================================================
		//
		//  MEMBER VARIABLES:
		//
		//  ~  _name -> Holds person's name. String. 
		//  ~~ Name -> Public modifier variable for _name.
		//
		//  ~  _age -> Holds person's age. Integer.
		//  ~~ Age -> Public modifier variable for _age.
		//
		//  ~  _division -> Holds person's division. Integer.
		//  ~~ Division ->Public modifier variable for _division
		//
		//========================================================

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		private int _division;

		public int Division
		{
			get { return _division; }
			set { _division = value; }
		}

		//========================================================
		//
		//  CONSTRUCTORS:
		//  
		//  ~  Person(string, integer ,integer)
		//     -> Initializes name, age, division, respectively.
		//
		//========================================================

		public Person (string name, int age, int division)
		{
			Name = name;
			Age = age;
			Division = division;
		}

		public override string ToString()
		{
			return Name;
		}

	}
}
