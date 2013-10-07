#1 Problem of dictionary name beeing the field name in a json
{
	"type": "FeatureCollection",
	"features": [{
		"jsonMap2": {
			"type": "Feature"
		}
	}],
	
	Dieses jsonMap2 soll aber nicht da stehen!! Problem wird erzeugt indem jsonMap2 dict sich als dict in einer anderen
	Klasse als das basis jsonObjekt befindet.
	
	Lösung: Alles muss in einer Klasse sein, dann verschwindet auch "jsonMap2"
	
	---------------------------------------
