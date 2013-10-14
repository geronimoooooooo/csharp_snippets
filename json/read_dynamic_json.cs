                String json = Newtonsoft.Json.JsonConvert.SerializeObject(toSerialize,Newtonsoft.Json.Formatting.Indented);
                String jsonFileName = "IOJSON_"+ procedure_id +"_"+ Guid.NewGuid().ToString() + ".json";
                //Stream streamWriterJson = new FileStream(@"..\..\resources\is\" + jsonFileName, FileMode.Create);

                using (TextWriter writerJson = File.CreateText(@"..\..\resources\iojson\" + jsonFileName ))
                {
                    writerJson.WriteLine(json);
                }

                // Read the file as one string.
                 System.IO.StreamReader myFile = new System.IO.StreamReader(@"C:\IOJSON_TL_Vehicle_3_3Phenomena.json");
                 json         = myFile.ReadToEnd();

                 myFile.Close();
            
                dynamic dynObj = JsonConvert.DeserializeObject(json);
                foreach (var item in dynObj.Body.InsertObservation.observation)
                {
                    String om_observation = item.ToString();
                    
                    String type = item.OM_Observation.type.ToString();
                    String observedProperty = item.OM_Observation.observedProperty.href.ToString();
                    System.Diagnostics.Debug.WriteLine(observedProperty);
                }

#Json with 3 Phenomena
{
  "Body": {
    "InsertObservation": {
      "offering": "http://ispace.researchstudio.at/senser/tl/procedure#tl3",
      "observation": [
        {
          "OM_Observation": {
            "type": {
              "href": "http://www.opengis.net/def/observationType/OGC-OM/2.0/OM_CategoryObservation"
            },
            "phenomenonTime": {
              "TimeInstant": {
                "timePosition": "2013-10-14T17:09:47.7516305+02:00",
                "id": "phenomenonTime"
              },
              "href": null
            },
            "resultTime": {
              "href": "#phenomenonTime"
            },
            "procedure": {
              "href": "http://ispace.researchstudio.at/senser/tl/procedure#tl3",
              "title": "Traffic Light 3 FH Salzburg"
            },
            "observedProperty": {
              "href": "http://ispace.researchstudio.at/senser/phenomenon/OGC/TL3green[Bool]"
            },
            "featureOfInterest": {
              "SF_SpatialSamplingFeature": {
                "identifier": {
                  "codeSpace": "",
                  "Value": "http://ispace.researchstudio.at/senser/spatiotemporalLocation/tl3"
                },
                "name": "Traffic Light 3 FH Salzburg",
                "type": {
                  "href": "http://www.opengis.net/def/samplingFeatureType/OGC-OM/2.0/SF_SamplingPoint"
                },
                "sampledFeature": {
                  "href": "http://ispace.researchstudio.at/senser/tl3/featureOfInterest#TL3",
                  "title": "Machine 34 Conditions"
                },
                "shape": {
                  "Point": {
                    "pos": {
                      "srsName": "http://www.opengis.net/def/crs/EPSG/0/4326",
                      "Value": "13.06 47.57",
                      "srsDimension": "2",
                      "uomLabels": "deg"
                    },
                    "id": "sampGeomID_tl3"
                  }
                },
                "id": "spatioTemporalLocationIDtl3"
              },
              "href": null
            },
            "resultQuality": {
              "href": "http://ispace.researchstudio.at/senser/tl/procedure#tl3"
            },
            "result": {
              "uom": "Bol",
              "type": "gml:MeasureType",
              "Value": "0"
            },
            "id": "ID9954c4ff-bfed-4ba9-909a-9eb089da92c8"
          }
        },
        {
          "OM_Observation": {
            "type": {
              "href": "http://www.opengis.net/def/observationType/OGC-OM/2.0/OM_Measurement"
            },
            "phenomenonTime": {
              "TimeInstant": null,
              "href": "#phenomenonTime"
            },
            "resultTime": {
              "href": "#phenomenonTime"
            },
            "procedure": {
              "href": "http://ispace.researchstudio.at/senser/tl/procedure#tl3",
              "title": "Traffic Light 3 FH Salzburg"
            },
            "observedProperty": {
              "href": "http://ispace.researchstudio.at/senser/phenomenon/OGC/TL3yellow[Bool]"
            },
            "featureOfInterest": {
              "SF_SpatialSamplingFeature": null,
              "href": "#sampGeomID_tl3"
            },
            "resultQuality": {
              "href": "http://ispace.researchstudio.at/senser/tl/procedure#tl3"
            },
            "result": {
              "uom": "Bol",
              "type": "gml:MeasureType",
              "Value": "0"
            },
            "id": "IDd8f4dbdd-a97a-48d9-8114-35b0f3edeb8c"
          }
        },
        {
          "OM_Observation": {
            "type": {
              "href": "http://www.opengis.net/def/observationType/OGC-OM/2.0/OM_Measurement"
            },
            "phenomenonTime": {
              "TimeInstant": null,
              "href": "#phenomenonTime"
            },
            "resultTime": {
              "href": "#phenomenonTime"
            },
            "procedure": {
              "href": "http://ispace.researchstudio.at/senser/tl/procedure#tl3",
              "title": "Traffic Light 3 FH Salzburg"
            },
            "observedProperty": {
              "href": "http://ispace.researchstudio.at/senser/phenomenon/OGC/TL3red[Bool]"
            },
            "featureOfInterest": {
              "SF_SpatialSamplingFeature": null,
              "href": "#sampGeomID_tl3"
            },
            "resultQuality": {
              "href": "http://ispace.researchstudio.at/senser/tl/procedure#tl3"
            },
            "result": {
              "uom": "Bol",
              "type": "gml:MeasureType",
              "Value": "0"
            },
            "id": "ID18f3f066-8472-40d0-9bf0-d682cf671c00"
          }
        }
      ],
      "service": "SOS",
      "version": "2.0.0"
    }
  }
}
