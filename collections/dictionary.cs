How to replace keys in a dictionary
            for (int i = 0; i < sensorvalues.Count; i++)
            {
                var k = sensorvalues.Keys.ElementAt(i);
                sensorvalues[k] = sensorvalues.ElementAt(i).Value.ToLower().Replace("true", "1");
                sensorvalues[k] = sensorvalues.ElementAt(i).Value.ToLower().Replace("false", "0");
            }
--------------------------------------------------------------------------------------------------------
 Collection was modified; enumeration operation may not execute.
                foreach (var item in sensorvalues)
                {
                    //Das wird nicht gehen, da man item= item.replace( hernehmen müsste. Aber man kann das nicht, da es eine for each schleife ist
                    item.Value.Replace("True", "1");
                    //String truee= item.Value.ToLower().Replace("true", "1");
                    //geht auch nicht, da item.Value nur read only ist
                    //item.Value = truee;

                    sensorvalues[item.Key]= item.Value.ToLower().Replace("true","1");
                    sensorvalues[item.Key]= item.Value.ToLower().Replace("false","0");
                }
------------------------------------------------------------------------------------------------------
