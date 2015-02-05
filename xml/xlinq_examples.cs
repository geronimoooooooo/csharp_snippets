var FieldsInDataRecord = mem.List_ofReturnedFields.Element(ns + "field");
or
var FieldsInDataRecord = from fields in mem.List_ofReturnedFields.Elements(ns + "field")
                         select fields;

----------------------------------
XElement cStudent = testXML.Descendants("Student").
Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();

var userResults = from u in myDB.Users
                         where u.Username == userName
                         && u.Password == passWord
                         select u;

List<Tutorial> tutorials =
  (from tutorial in xmlDoc.Descendants("Tutorial")
   where tutorial.Element("Author").Value == "The Tallest"
   select new Tutorial
   {
     Author = tutorial.Element("Author").Value,
     Title = tutorial.Element("Title").Value,
     Date = DateTime.Parse(tutorial.Element("Date").Value),
   }).ToList<Tutorial>();

//get a single record
public User GetUser(string userName)
{    DBNameDataContext myDB = new DBNameDataContext();
     User user = myDB.Users.Single(u, u.UserName=>userName);
     return user;
}

XElement cStudent = testXML.Descendants("Student").Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();
----
Person[] people = new Person[]();
//create xml document from already constructed Person objects
from person in people
                  select new XElement("Person", new XAttribute("ID", person.ID), 
                         new XElement("Name", person.Name), 
                         new XElement("Age", person.Age), 
                         new XElement("Job", person.Job))
              )
----
//list of names of the people below 60 years of age

     var names = (from person in Xdocument.Load("People.xml").Descendants("Person")
                 where int.Parse(person.Element("Age").Value) < 60
                 select person.Element("Name").Value).ToList();
----
//Adding a new Element to a .xml document
//adding an element

            //load document
            XDocument document = Xdocument.Load("People.xml");

            document.Element("People").Add(

                 new XElement("Person", new XAttribute("id", 5),
                        new XElement("Name", "Carl"),
                        new XElement("Age", 24),
                        new XElement("Job", "Banker")
                        )

                 );
----
//removing an element
XDocument document = Xdocument.Load("People.xml");
document.Root.Elements().Where(e => e.Attribute("id").Value.Equals("5")).Select(e => e).Single().Remove();

We get a collection of all the immediate child elements of the Person elements by calling the Elements() 
method on the root element on the ‘document’ variable. That’s the difference between Descendants() and Elements(). 
Descendants() recursively finds all children; Elements() returns only immediate children. Click here for more details

The root element in this document is ‘People’. 

We then select the element where the value of the current Person element’s id is 5. We then call Single() 
on the resulting collection to get the single XElement object back. We then call Remove() 
on that element, and save the changes. 
----
//updating an xml document
   // Update Lisa's job to florist
   root.Elements("Person").Where(e => e.Element("Name").Value.Equals("Lisa")).
   Select(e => e.Element("Job")).Single().SetValue("Florist");
----
var fourOrMoreCharacters = listOne.Count(item => item.Length > 3);
Console.WriteLine("{0}\n{1}", result,fourOrMoreCharacters);
----
