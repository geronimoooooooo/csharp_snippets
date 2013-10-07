Wenn man seinen Json String schon formatieren möchte mit breaklines, dann:

String jsonstring = JsonConvert.SerializeObject(this.jsonMap, Formatting.Indented);
