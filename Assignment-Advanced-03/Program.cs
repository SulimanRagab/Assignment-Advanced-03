
#region Exercise 1: Student Grade Manager
//List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
//foreach (var grade in grades)
//{
//    Console.WriteLine(grade);
//}

//Console.WriteLine($"Grades: {grades.Count}");
//Console.WriteLine($" firsr Grades: {grades.First()}");
//Console.WriteLine($" last Grades: {grades.Last()}");

//Sort the grades ascending, then print
//grades.Sort();
//foreach (var grade in grades)
//{
//    Console.WriteLine(grade);
//}
////Get the first grade above 90
//Console.WriteLine(grades.Find(g => g > 90));

//Get all grades below 75 (failing grades)
//List<int> failingGrades = grades.FindAll(g => g < 75);
//foreach (var grade in failingGrades)
//{
//    Console.WriteLine(grade);
//}
////Remove all failing grades (below 75)
//int failingGrades1 = grades.RemoveAll(g => g <75);
//Console.WriteLine(failingGrades1); // 2 removed grades

//Console.WriteLine(grades.Contains(100)); // true
//List<string> Gradestring = new List<string> {"Grade: 85","Grade: 92","Grade: 78","Grade: 95","Grade: 88","Grade: 70","Grade: 100","Grade: 65"};
//Gradestring.Sort();
//foreach (var grade in Gradestring)
//{
//    Console.WriteLine(grade);
//} 
#endregion

#region Exercise 2: Leaderboard
//SortedDictionary<int, string> scorePlayers = new SortedDictionary<int, string>();

//scorePlayers.Add(500,"Ahmed");
//scorePlayers.Add(200, "Sara");
//scorePlayers.Add(800, "Ali");
//scorePlayers.Add(350, "Mona");

//foreach (var student in scorePlayers)
//{
//    Console.WriteLine($"score: {student.Key}, Name: {student.Value}");
//}
//Console.WriteLine($"first plyer: {scorePlayers.First()}");

//Console.WriteLine(scorePlayers.ContainsKey(500));

//if(scorePlayers.TryGetValue(999, out var value))
//{
//    Console.WriteLine(value);
//}
//else
//{
//    Console.WriteLine("Noo key 999");
//}
//scorePlayers.Remove(200);
//Console.WriteLine("ThelowerRanked player was eliminated");
//foreach (var scorePlayersed in scorePlayers)
//{
//    Console.WriteLine(scorePlayersed);
//} 
#endregion

#region Exercise 3: Phone Book
////1-Create a Collection  with 4 contacts (name → phone number)
//Dictionary<string, long> PhoneBook = new Dictionary<string, long>
//{
//    {"Ahmed", 01534567890},
//    {"Sara", 010876543210},
//    {"Ali", 0125555555},
//    {"Mona", 011416134511}
//};
////2-Add a new contact using [] syntax (add or update)
//PhoneBook["suliman"] = 01555427709;
//PhoneBook["Ali"] = 01012333333;
////3-Try adding a duplicate using .Add() — catch the exception and print the error
//try
//{
// PhoneBook.Add("Ahmed", 01534567890);
//}
//catch (ArgumentException ex)
//{
//  Console.WriteLine(ex.Message);
//}
////4-Try adding a duplicate using .TryAdd() — print whether it succeeded
//bool readd = PhoneBook.TryAdd("Ahmed", 01534567890);
//if (readd)
//{
//    Console.WriteLine("Ahmedadd");
//}
//else
//{
//    Console.WriteLine("Ahmed alreadyExists");
//}
////Print
//foreach (var contact in PhoneBook)
//{
//    Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
//}
////5-Search for a contact that doesn’t exist
//Console.WriteLine(PhoneBook.ContainsKey("Ali"));
//Console.WriteLine(PhoneBook.ContainsKey("hossam"));
////6-Search for a contact that doesn’t exist
//if (PhoneBook.TryGetValue("hossam", out var phoneNumber))
//{
//    Console.WriteLine($"hossam phone number is:{phoneNumber}");
//}
//else
//{
//    Console.WriteLine("Not Found");
//}
////7-Print all Keys on one line, then all Values on another line
//int entityNumber = 1;
//foreach (var contact in PhoneBook)
//{
//    Console.WriteLine($"Entity Number:{entityNumber++}\nName: {contact.Key} \nPhone: {contact.Value}");
//} 
#endregion

#region Exercise 4: Unique Email Validator
//1-Create a HashSet<string> with a case-insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
//2-Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
//HashSet<string> emaels = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
//{
//    {"ahmed@test.com"},
//    {"AHMED@test.com"},
//    {"sara@test.com"},
//    {"Sara@Test.Com"}
//};
//3-Print Count — how many are actually stored? Explain why.
//foreach (var emael in emaels)
//{
//    Console.WriteLine(emael);
//}
//عدد النسخ المخزنه فعليا {"ahmed@test.com"} و {"sara@test.com"} بس  لأن StringComparer.OrdinalIgnoreCase فحصت ولقت ان فيه نسخ بنفس الاسم مع حروف Uppercase

//4-Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
//HashSet<int> setA =[ 1, 2, 3, 4, 5 ];
//HashSet<int> setB =[ 4, 5, 6, 7, 8];
//5-Print the result of: UnionWith, IntersectWith, ExceptWith
//HashSet<int> SetA = new HashSet<int>(setA);
//دمج المجموعتين setA و setB
//SetA.UnionWith(setB);
//Console.WriteLine("SetA.UnionWith(setB)");
//foreach (var item in SetA)
//{
//    Console.WriteLine(item);
//}
//العناصر المشتركة بين المجموعتين setA و setB هي 4 و 5
//SetA.IntersectWith(setB);
//Console.WriteLine("SetA.IntersectWith(setB)");
//foreach (var item in SetA)
//{
//    Console.WriteLine(item);
//}
//العناصر الموجودة في setA وليست موجودة في setB هي 1 و 2 و 3
//SetA.ExceptWith(setB);
//Console.WriteLine("SetA.Except(setB)");
//foreach (var item in SetA)
//{
//    Console.WriteLine(item);
//}

//Use IsSubsetOf to check if {1,2} is a subset of Set A
//HashSet<int> setC = [1,2];
//Console.WriteLine(setC.IsProperSubsetOf(setA)); // true 
#endregion