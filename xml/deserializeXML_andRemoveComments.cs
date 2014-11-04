public void deserializeISXML(String pathToFile)
  {
      pathToFile = @"C:\csharp_workspace\Test_GetObservation_52north\Test_GetObservation_52north\resources\is_vorlage\52_insertSensor_matching_141022.xml";
      Envelope env = null;
      XmlSerializer serializer = new XmlSerializer(typeof(Envelope));


      // load document
      XmlDocument doc = new XmlDocument();
      doc.Load(pathToFile);

      // remove all comments
      XmlNodeList l = doc.SelectNodes("//comment()");
      foreach (XmlNode node in l) node.ParentNode.RemoveChild(node);

      // store to memory stream and rewind
      MemoryStream ms = new MemoryStream();
      doc.Save(ms);
      ms.Seek(0, SeekOrigin.Begin);

      // deserialize using clean xml
      env = (Envelope)serializer.Deserialize(XmlReader.Create(ms));


    /*  StreamReader reader = new StreamReader(pathToFile);
      env = (Envelope)serializer.Deserialize(reader);
      reader.Close();*/

      serializeObjectToXml(env, "copyPaste", "");
  }
