XElement cStudent = testXML.Descendants("Student").
Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();


var userResults = from u in myDB.Users
                         where u.Username == userName
                         && u.Password == passWord
                         select u;
