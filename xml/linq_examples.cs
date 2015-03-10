var query = people
 .Where (p => p.ID == 1)
 .Select( p => new { p.FirstName, p.LastName } )
 .ToArray(); 
