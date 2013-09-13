 
 http://stackoverflow.com/questions/114983/in-c-given-a-datetime-object-how-do-i-get-a-iso-8601-date-in-string-format
 Z... für UtcNow
 zzz. für Now
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fZ"));
            2013-06-03T17:26:52.7Z
            
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fzzz"));
            2013-06-03T19:26:52.7+02:00
            
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString());
            2013-06-03 17:14:48
            
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());
            2013-06-03 19:11:51
            
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("s"));
            2013-06-03T19:11:51
            
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("o"));
            2013-06-03T19:11:51.7233344+02:00
            
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            2013-06-03T17:11:51Z
            
http://stackoverflow.com/questions/18790875/how-to-parse-a-datetime-string-to-date-object
datetime = DateTime.Parse("2013-02-01T12:30:00.001+01:00");
   //datetime object shows 2013-02-01 12:30:00 but the ms are still stored. 
   //just use "o"

   WriteLine(datetime.ToString());
   //2013-02-01 12:30:00

   WriteLine(datetime.ToString("o"));
   //2013-02-01T12:30:00.0010000+01:00

   WriteLine(datetime.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"));
   //2013-02-01T12:30:00.001+01:00


   String str = datetime.ToString("o");
   WriteLine("my: "+str);
   //my: 2013-02-01T12:30:00.0010000+01:00
