//suche jenes phenomenonobjekt wo der urn=visibility. Setze dort dann den Wert der im ob: an index 3 zu finden ist; (9999)
 CT_Phenomenon ph = list_phenomenon.Where(p=> p.urn.Equals("visibility")).ElementAt(0);
 ph.value = parts[1].Trim().Split(' ')[3].Trim();
