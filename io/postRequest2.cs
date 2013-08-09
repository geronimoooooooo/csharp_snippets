http://msdn.microsoft.com/en-us/library/debx8sh9.aspx
http://stackoverflow.com/questions/4015324/http-request-with-post
---------------------------------------------------------------------------------
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Examples.System.Net
{
    public class WebRequestPostExample
    {
        public static void Main ()
        {
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create ("http://www.contoso.com/PostAccepter.aspx ");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "This is a test that posts this string to a Web server.";
            byte[] byteArray = Encoding.UTF8.GetBytes (postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream ();
            // Write the data to the request stream.
            dataStream.Write (byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close ();
            // Get the response.
            WebResponse response = request.GetResponse ();
            // Display the status.
            Console.WriteLine (((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream ();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader (dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd ();
            // Display the content.
            Console.WriteLine (responseFromServer);
            // Clean up the streams.
            reader.Close ();
            dataStream.Close ();
            response.Close ();
        }
    }
}
HttpWebRequest httpWReq =
    (HttpWebRequest)WebRequest.Create("http://domain.com/page.aspx");

ASCIIEncoding encoding = new ASCIIEncoding();
string postData = "username=user";
postData += "&password=pass";
byte[] data = encoding.GetBytes(postData);

httpWReq.Method = "POST";
httpWReq.ContentType = "application/x-www-form-urlencoded";
httpWReq.ContentLength = data.Length;

using (Stream stream = httpWReq.GetRequestStream())
{
    stream.Write(data,0,data.Length);
}
//To get the response:
HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
-----------------------------------------------------------------
Simple GET request

using (var wb = new WebClient())
{
    var response = wb.DownloadString(url);
}
Simple POST request

using (var wb = new WebClient())
{
    var data = new NameValueCollection();
    data["username"] = "myUser";
    data["password"] = "myPassword";

    var response = wb.UploadValues(url, "POST", data);
}
