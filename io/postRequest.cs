        /// <summary>
        /// Sends a POSTrequest to the SOS web service without using Proxy. Gzip, deflate are active. XmlReader is created with datastream. 
        /// And finally XDocument.Load(xmlReader); is created and returned. If timeout is exceeded an exception is thrown.
        /// </summary>
        public void postRequest(string _sFilter, string url)
        {

            /*HttpWebRequest httpWReq =
                (HttpWebRequest)WebRequest.Create("http:\\domain.com\page.asp");

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "username=user";
            postData += "&password=pass";
            byte[] data = encoding.GetBytes(postData);

            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded";
            httpWReq.ContentLength = data.Length;

            using (Stream newStream = httpWReq.GetRequestStream())
            {
                newStream.Write(data,0,data.Length);
            }
             */
            String _POSTelementName = "data_post";
            try
            {
                int timeout = 10000; //10.000ms = 10sek
                string Poststring = "";
                Poststring += _POSTelementName + "=" + System.Web.HttpUtility.UrlEncode(_sFilter);
                //   Poststring = "data_post=%3C%3Fxml+version%3D%221.0%22+encoding%3D%22UTF-8%22%3F%3E%0A%3C!--%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%0AExample+Request+for+InsertObservation+operation+which+contains+the+identifier+of+the+observation+for+which+the+observation+shall+be+inserted+as+well+as+the+observation+which+shall+be+inserted.+The+response+contains+the+assigned+observation+ID.%0A%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D--%3E%0A%0A%3C!--%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%0AExample+Request+for+InsertObservation+operation+which+contains+the+identifier+of+the+observation+for+which+the+observation+shall+be+inserted+as+well+as+the+observation+which+shall+be+inserted.+The+response+contains+the+assigned+observation+ID.%0A%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D%3D--%3E%0A%3Csoap12%3AEnvelope+xmlns%3Asoap12%3D%22http%3A%2F%2Fwww.w3.org%2F2003%2F05%2Fsoap-envelope%22+ns_xsi%3AschemaLocation%3D%22http%3A%2F%2Fwww.w3.org%2F2003%2F05%2Fsoap-envelope+http%3A%2F%2Fwww.w3.org%2F2003%2F05%2Fsoap-envelope%2Fsoap-envelope.xsd%0Ahttp%3A%2F%2Fwww.opengis.net%2Fsos%2F2.0+http%3A%2F%2Fschemas.opengis.net%2Fsos%2F2.0%2Fsos.xsd%22+xmlns%3Asos%3D%22http%3A%2F%2Fwww.opengis.net%2Fsos%2F2.0%22+xmlns%3Awsa%3D%22http%3A%2F%2Fwww.w3.org%2F2005%2F08%2Faddressing%22+xmlns%3Axsi%3D%22http%3A%2F%2Fwww.w3.org%2F2001%2FXMLSchema-instance%22+xmlns%3Aswe%3D%22http%3A%2F%2Fwww.opengis.net%2Fswe%2F2.0%22+xmlns%3Aswes%3D%22http%3A%2F%2Fwww.opengis.net%2Fswes%2F2.0%22+xmlns%3Afes%3D%22http%3A%2F%2Fwww.opengis.net%2Ffes%2F2.0%22+xmlns%3Agml%3D%22http%3A%2F%2Fwww.opengis.net%2Fgml%2F3.2%22+xmlns%3Aogc%3D%22http%3A%2F%2Fwww.opengis.net%2Fogc%22+xmlns%3Aom%3D%22http%3A%2F%2Fwww.opengis.net%2Fom%2F2.0%22+xmlns%3Axlink%3D%22http%3A%2F%2Fwww.w3.org%2F1999%2Fxlink%22%3E%0A++%3Csoap12%3AHeader%3E%0A++++%3Cwsa%3ATo%3Ehttp%3A%2F%2Fwww.ogc.org%2FSOS%3C%2Fwsa%3ATo%3E%0A++++%3Cwsa%3AAction%3Ehttp%3A%2F%2Fwww.opengis.net%2Fdef%2FserviceOperation%2Fsos%2FobsInsertion%2F2.0%2FInsertObservation%3C%2Fwsa%3AAction%3E%0A++++%3Cwsa%3AReplyTo%3E%0A++++++%3Cwsa%3AAddress%3Ehttp%3A%2F%2Fwww.w3.org%2F2005%2F08%2Faddressing%2Fanonymous%3C%2Fwsa%3AAddress%3E%0A++++%3C%2Fwsa%3AReplyTo%3E%0A++++%3Cwsa%3AMessageID%3Ehttp%3A%2F%2Fmy.client.com%2Fuid%2Fmsg-0010%3C%2Fwsa%3AMessageID%3E%0A++%3C%2Fsoap12%3AHeader%3E%0A%0A++%3Csoap12%3ABody%3E%0A%0A%0A++++%3C!--+%3Csos%3AInsertObservation+service%3D%22SOS%22+version%3D%222.0.0%22+xmlns%3Asos%3D%22http%3A%2F%2Fwww.opengis.net%2Fsos%2F2.0%22+xmlns%3Awsa%3D%22http%3A%2F%2Fwww.w3.org%2F2005%2F08%2Faddressing%22+xmlns%3Axsi%3D%22http%3A%2F%2Fwww.w3.org%2F2001%2FXMLSchema-instance%22+xmlns%3Aswe%3D%22http%3A%2F%2Fwww.opengis.net%2Fswe%2F2.0%22+xmlns%3Aswes%3D%22http%3A%2F%2Fwww.opengis.net%2Fswes%2F2.0%22+xmlns%3Afes%3D%22http%3A%2F%2Fwww.opengis.net%2Ffes%2F2.0%22+xmlns%3Agml%3D%22http%3A%2F%2Fwww.opengis.net%2Fgml%2F3.2%22+xmlns%3Aogc%3D%22http%3A%2F%2Fwww.opengis.net%2Fogc%22+xmlns%3Aom%3D%22http%3A%2F%2Fwww.opengis.net%2Fom%2F2.0%22+xmlns%3Axlink%3D%22http%3A%2F%2Fwww.w3.org%2F1999%2Fxlink%22%3E%0A--%3E%0A++++%3C!--identifier+of+offering+for+which+the+observation+shall+be+inserted--%3E%0A++++%3Csos%3AInsertObservation+service%3D%22SOS%22+version%3D%222.0.0%22%3E%0A%0A++++++%3Csos%3Aoffering%3EScada_offering6%3C%2Fsos%3Aoffering%3E%0A++++++%3C!--+Equals+user+in+Form+--%3E%0A%0A%0A++++++%3C!--observation+which+shall+be+inserted--%3E%0A++++++%3Csos%3Aobservation%3E%0A++++++++%3Com%3AOM_Observation+gml%3Aid%3D%22gml_Id_Scada6%22%3E%0A++++++++++%3Com%3Atype%0A++++++++xlink%3Ahref%3D%22http%3A%2F%2Fwww.opengis.net%2Fdef%2FobservationType%2FOGC-OM%2F2.0%2FOM_Measurement%22+xlink%3Atitle%3D%22procedure+Description%22%2F%3E%0A++++++++++%3Com%3AphenomenonTime%3E%0A++++++++++++%3Cgml%3ATimeInstant+gml%3Aid%3D%22phenomenonTime%22%3E%0A++++++++++++++%3Cgml%3AtimePosition%3E2013-01-30T15%3A30%3A00Z%3C%2Fgml%3AtimePosition%3E%0A++++++++++++%3C%2Fgml%3ATimeInstant%3E%0A++++++++++%3C%2Fom%3AphenomenonTime%3E%0A++++++++++%3Com%3AresultTime+xlink%3Ahref%3D%22%23phenomenonTime%22%2F%3E%0A++++++++++%3C!--+link+to+DescribeSensor+operation+of+SOS+which+is+providing+the+sensor+description+--%3E%0A++++++++++%3Com%3Aprocedure+xlink%3Atitle%3D%22Scada_DeviceName6%22+xlink%3Ahref%3D%22Scada_procedure_ID6%22%2F%3E%0A++++++++++%3C!--+Equals+UUID+in+in+Form+--%3E%0A++++++++++%3C!--+parameter+containing+samplingPoint+as+defined+in+SOS+2.0+Extension+-+Data+Encoding+Restriction--%3E%0A%0A++++++++++%3C!--+the+following+is+new+--%3E%0A%0A++++++++++%3C!--+a+notional+WFS+call+identifying+the+object+regarding+which+the+observation+was+made+--%3E%0A++++++++++%3Com%3AfeatureOfInterest+xlink%3Atitle%3D%22My+Context%22+xlink%3Ahref%3D%22Link+to+my+FOI%22+%2F%3E%0A++++++++++%3Com%3Aresult%3E%0A++++++++++++%3Cswe%3ASimpleDataRecord%3E%0A++++++++++++++%3Cswe%3Afield+nameWithinOffering%3D%22latitude%22%3E%0A++++++++++++++++%3Cswe%3AQuantity+definition%3D%22urn%3Aogc%3Adef%3Aproperty%3AOGC%3ALatitude%3Awgs84%22%3E%0A++++++++++++++++++%3Cswe%3Auom+code%3D%22deg%22%2F%3E%0A++++++++++++++++++%3Cswe%3Avalue%3E50.8912%3C%2Fswe%3Avalue%3E%0A++++++++++++++++%3C%2Fswe%3AQuantity%3E%0A++++++++++++++%3C%2Fswe%3Afield%3E%0A++++++++++++++%3Cswe%3Afield+nameWithinOffering%3D%22longitude%22%3E%0A++++++++++++++++%3Cswe%3AQuantity+definition%3D%22urn%3Aogc%3Adef%3Aproperty%3AOGC%3ALongitude%3Awgs84%22%3E%0A++++++++++++++++++%3Cswe%3Auom+code%3D%22deg%22%2F%3E%0A++++++++++++++++++%3Cswe%3Avalue%3E10.8912%3C%2Fswe%3Avalue%3E%0A++++++++++++++++%3C%2Fswe%3AQuantity%3E%0A++++++++++++++%3C%2Fswe%3Afield%3E%0A++++++++++++++%3Cswe%3Afield+nameWithinOffering%3D%22altitude%22%3E%0A++++++++++++++++%3Cswe%3AQuantity+definition%3D%22urn%3Aogc%3Adef%3Aproperty%3AOGC%3AAltitude%3Awgs84%22%3E%0A++++++++++++++++++%3Cswe%3Auom+code%3D%22m%22%2F%3E%0A++++++++++++++++++%3Cswe%3Avalue%3E5000.00%3C%2Fswe%3Avalue%3E%0A++++++++++++++++%3C%2Fswe%3AQuantity%3E%0A++++++++++++++%3C%2Fswe%3Afield%3E%0A++++++++++++++%3Cswe%3Afield+nameWithinOffering%3D%22Radiation+Dose%22+xlink%3Atitle%3D%22My+description+of+Radiation+Dose%22+xlink%3Ahref%3D%22http%3A%2F%2Fsweet.jpl.nasa.gov%2Fontology%2Fproperty.owl%23Radiation_Dose%22%3E%0A++++++++++++++++%3Cswe%3AQuantity+definition%3D%22http%3A%2F%2Fsweet.jpl.nasa.gov%2Fontology%2Fproperty.owl%23Radiation_Dose%22%3E%0A++++++++++++++++++%3Cswe%3Auom+code%3D%22MicroSievert+per+hour%22+%2F%3E%0A++++++++++++++++++%3Cswe%3Avalue%3E1337.17%3C%2Fswe%3Avalue%3E%0A++++++++++++++++%3C%2Fswe%3AQuantity%3E%0A++++++++++++++%3C%2Fswe%3Afield%3E%0A++++++++++++++%3Cswe%3Afield+nameWithinOffering%3D%22Heart+Rate%22+xlink%3Atitle%3D%22My+Description+of+heartrate%22+xlink%3Ahref%3D%22urn%3Aispace%3Aheartrate%22%3E%0A++++++++++++++++%3Cswe%3AQuantity+definition%3D%22urn%3Aispace%3Aheartrate%22%3E%0A++++++++++++++++++%3Cswe%3Auom+code%3D%22Beats+per+minute%22+%2F%3E%0A++++++++++++++++++%3Cswe%3Avalue%3E1337%3C%2Fswe%3Avalue%3E%0A++++++++++++++++%3C%2Fswe%3AQuantity%3E%0A++++++++++++++%3C%2Fswe%3Afield%3E%0A++++++++++++%3C%2Fswe%3ASimpleDataRecord%3E%0A++++++++++%3C%2Fom%3Aresult%3E%0A++++++++%3C%2Fom%3AOM_Observation%3E%0A++++++%3C%2Fsos%3Aobservation%3E%0A++++%3C%2Fsos%3AInsertObservation%3E%0A%0A++%3C%2Fsoap12%3ABody%3E%0A%3C%2Fsoap12%3AEnvelope%3E";
                Uri MyUri = new Uri(url);
                Stopwatch s = new Stopwatch();

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(MyUri);

                req.Method = "POST";
                req.MediaType = "HTTP/1.1";
                req.ContentType = "text/xml";
                req.UserAgent = "Example Client";

                req.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                //req.Method = "POST";

                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = Poststring.Length;
                /*
                 * http://stackoverflow.com/questions/1491841/httpwebrequesterror-the-server-committed-a-protocol-violation-section-response
                req.ServicePoint.Expect100Continue = false;
                 */
                req.Timeout = timeout;
                s.Start();
                StreamWriter swriter = new StreamWriter(req.GetRequestStream());
                swriter.Write(Poststring);
                swriter.Close();
                //    Get the response.
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                //  Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                //Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);

                //Read the content.
                string responseFromServerOld = reader.ReadToEnd();
                string responseFromServer = responseFromServerOld.Replace("<br/>","\n");
                responseFromServer = responseFromServer.Replace("&nbsp;", " ");
                System.Diagnostics.Debug.WriteLine("responseFromServer: "+responseFromServer);
                //Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();



                // Get the response.
                // HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                s.Stop(); Debug.WriteLine("\n\n******************************Talking to Web-Service: " + s.ElapsedMilliseconds);

                s.Reset();
                // Get the stream containing content returned by the server.
                //  Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                //StreamReader reader = new StreamReader(dataStream);

                // Read the content.
                //string responseFromServer = reader.ReadToEnd();

                //XmlReaderSettings settings = new XmlReaderSettings();
                //settings.ProhibitDtd = false;
                //settings.ValidationType = ValidationType.None;
                //settings.ConformanceLevel = ConformanceLevel.Document;
                //XmlReader xmlReader = XmlReader.Create(dataStream, settings);
                //  xdocument = XDocument.Load(xmlReader);


                // Cleanup the streams and the response.
                //reader.Close();
                //    dataStream.Close();
                //     response.Close();
                s.Stop();

            }
            catch (WebException wex)
            {
                Debug.WriteLine("---###---Timeout für die Anfrage?---");
                Debug.WriteLine(wex.Message);
                Debug.WriteLine(wex.StackTrace);
                System.Diagnostics.Debug.WriteLine("");

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("POSTRequest.postRequest() : Der ResponseServer liefert keine response? " + ex);
                //  Console.WriteLine("System_rtga_POST: " + ex);

            }
        }
        
        
        
        
        ----------------------------------------------------------------------
                        Uri MyUri = new Uri(url);
                Stopwatch s = new Stopwatch();
                
                //disable check for certificate
                ServicePointManager.ServerCertificateValidationCallback += (o, c, ch, er) => true;
               //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
               // ServicePointManager.Expect100Continue = false;
                
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(MyUri);
                req.Method = "POST";
                req.MediaType = "HTTP/1.1";
                req.ContentType = "application/json";
                req.UserAgent = "Example Client";

                req.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

               // req.ClientCertificates.Add(new System.Security.Cryptography.X509Certificates.X509Certificate());
                //req.Method = "POST";

               // req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = Poststring.Length;
                /*
                 * http://stackoverflow.com/questions/1491841/httpwebrequesterror-the-server-committed-a-protocol-violation-section-response
                req.ServicePoint.Expect100Continue = false;
                 */
                req.Timeout = timeout;
                s.Start();
                StreamWriter swriter = new StreamWriter(req.GetRequestStream());
                swriter.Write(Poststring);
                swriter.Close();
