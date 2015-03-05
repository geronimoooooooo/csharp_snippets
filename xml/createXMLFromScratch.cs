//create xml document from scratch

            XDocument document = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Jason's xml"),
                new XElement("People",

                    new XElement("Person", new XAttribute("id", 1),
                        new XElement("Name", "Joe"),
                        new XElement("Age", 35),
                        new XElement("Job", "Manager")
                        ),
                     new XElement("Person", new XAttribute("id", 2),
                        new XElement("Name", "Jason"),
                        new XElement("Age", 18),
                        new XElement("Job", "Software Engineer")
                        ),
                     new XElement("Person", new XAttribute("id", 3),
                        new XElement("Name", "Lisa"),
                        new XElement("Age", 53),
                        new XElement("Job", "Bakery Owner")
                        ),
                     new XElement("Person", new XAttribute("id", 4),
                        new XElement("Name", "Mary"),
                        new XElement("Age", 90),
                        new XElement("Job", "Nurse")
                        )
                )
            );

            //save constructed document
            document.Save("People.xml");


            XNamespace w =
             "http://schemas.microsoft.com/office/word/2003/wordml";
            
            XDocument word = new XDocument(
             new XDeclaration("1.0","utf-8", "yes"),
             new XProcessingInstruction("mso-application",
             "progid=\"Word.Document\""),
             new XElement(w + "wordDocument",
             new XAttribute(XNamespace.Xmlns + "w",
             w. NamespaceName)));
            
            System.IO.StringWriter sw = new System.IO.StringWriter();
            word.Save(sw);
            
            Console.WriteLine(sw); 
            
<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<?mso-application progid="Word.Document"?>
<w:wordDocument xmlns:w="http://schemas.microsoft.com/office/word/2003/wordml" /> 
