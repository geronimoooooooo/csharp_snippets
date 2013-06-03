 public void serializeObjectToXml(CT_Envelope toSerialize )
       {
           XmlSerializer serializer = new XmlSerializer(toSerialize.GetType());
           StringWriter stringWriter = new StringWriter();
           System.IO.FileStream fs = new FileStream(@"..\..\resources\insert.xml", FileMode.Create);
           TextWriter writer = new StreamWriter(fs, new UTF8Encoding());
                       
           XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
           ns.Add("wsa","http://www.w3.org/2005/08/addressing");
           ns.Add("soap12", "http://www.w3.org/2003/05/soap-envelope");
           ns.Add("sos", "http://www.opengis.net/sos/2.0");
           ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
           ns.Add("swe", "http://www.opengis.net/swe/2.0");
           ns.Add("swes", "http://www.opengis.net/swes/2.0");
           ns.Add("fes","http://www.opengis.net/fes/2.0");
           ns.Add("gml","http://www.opengis.net/gml/3.2");
           ns.Add("ogc","http://www.opengis.net/ogc");
           ns.Add("om","http://www.opengis.net/om/2.0");
           ns.Add("xlink","http://www.w3.org/1999/xlink");
   
           serializer.Serialize(writer, toSerialize, ns);
           writer.Close();
   
           serializer.Serialize(stringWriter, toSerialize);
           String url = "";
           postRequest(stringWriter.ToString(), url);
        }
