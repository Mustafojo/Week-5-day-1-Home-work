var person = new Person();
System.Console.Write("Nomta navis ");
person.FirstName = Console.ReadLine();
System.Console.Write("Familiata navis ");
person.LastName = Console.ReadLine();
System.Console.Write("Chand solai ");
person.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(person.GetInfo());