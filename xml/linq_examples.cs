##############################
string[] numbers = { "0042", "010", "9", "27" };
int[] nums = numbers.Select(s => Int32.Parse(s)).ToArray();
int[] nums = numbers.Select(s => Int32.Parse(s)).OrderBy(s => s).ToArray();
##############################
var query = people
 .Where (p => p.ID == 1)
 .Select( p => new { p.FirstName, p.LastName } )
 .ToArray(); 
