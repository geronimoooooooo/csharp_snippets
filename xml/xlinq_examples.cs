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
