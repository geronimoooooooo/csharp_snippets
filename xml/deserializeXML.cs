 public void deserializeISXML(String pathToFile)
  {
    Envelope env = null;
    XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
    StreamReader reader = new StreamReader(pathToFile);
    env = (Envelope)serializer.Deserialize(reader);
    reader.Close();
  }
