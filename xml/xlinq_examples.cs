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

