 
 http://stackoverflow.com/questions/114983/in-c-given-a-datetime-object-how-do-i-get-a-iso-8601-date-in-string-format
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("s"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("o"));
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));



            2013-06-03 19:11:51
            2013-06-03T19:11:51
            2013-06-03T19:11:51.7233344+02:00
            2013-06-03T17:11:51Z
