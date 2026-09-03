
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