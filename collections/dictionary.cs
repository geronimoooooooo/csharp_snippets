How to replace keys in a dictionary
            for (int i = 0; i < sensorvalues.Count; i++)
            {
                var k = sensorvalues.Keys.ElementAt(i);
                sensorvalues[k] = sensorvalues.ElementAt(i).Value.ToLower().Replace("true", "1");
                sensorvalues[k] = sensorvalues.ElementAt(i).Value.ToLower().Replace("false", "0");
            }
--------------------------------------------------------------------------------------------------------
