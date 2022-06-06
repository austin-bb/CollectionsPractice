int[] numArray = {0,1,2,3,4,5,6,7,8,9};

// foreach (int num in numArray)
// {
//   Console.WriteLine(num);
// }

string[] namesArray = {"Tim", "Martin", "Nikki", "Sara"};

// foreach (string name in namesArray)
// {
//   Console.WriteLine(name);
// }

bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};

// foreach (bool value in boolArray)
// {
//   Console.WriteLine(value);
// }

List<string> flavors = new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Strawberry");
flavors.Add("Pistachio");
flavors.Add("Neopolitan");

// Console.WriteLine(flavors.Count);
// Console.WriteLine(flavors[2]);
// flavors.RemoveAt(2);
// Console.WriteLine("The new count of flavors is" + " " + flavors.Count);

Dictionary<string, string> user = new Dictionary<string, string>();
var random = new Random();
// Console.WriteLine(flavors[index]);
foreach (string name in namesArray)
{
  user.Add(name, flavors[random.Next(flavors.Count)]);
}

foreach (KeyValuePair<string, string> entry in user)
{
  Console.WriteLine(entry.Key + " " + entry.Value);
}