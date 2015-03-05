XElement xml = XElement.Load(@"..\..\People.xml");

 XElement role = xml.Descendants("role").First();
 Console.WriteLine("-=-=ORIGINAL-=-=");
 Console.WriteLine(role);

 role.SetElementValue("roledescription", "Actor");
 Console.WriteLine(string.Empty);
 Console.WriteLine("-=-=UPDATED-=-=");
 Console.WriteLine(role); 
 
 
 XElement xml = XElement.Load(@"..\..\People.xml");

 XElement role = xml.Descendants("idperson").First();
 Console.WriteLine("-=-=ORIGINAL-=-=");
 Console.WriteLine(role);

 role.SetAttributeValue("year", "2006");
 Console.WriteLine(string.Empty);
 Console.WriteLine("-=-=UPDATED-=-=");
 Console.WriteLine(role);
As you can see from the output in 
