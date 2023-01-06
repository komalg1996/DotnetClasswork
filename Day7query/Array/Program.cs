using Training;

List<Student> dac = new List<Student>();
dac.Add(new Student { StudentID = 1, Name = "Manish", Age = 20 });
dac.Add(new Student { StudentID = 2, Name = "Komal", Age = 25 });
dac.Add(new Student { StudentID = 3, Name = "Ashwini", Age = 26 });
dac.Add(new Student { StudentID = 4, Name = "Bhavesh", Age = 30 });
dac.Add(new Student { StudentID = 5, Name = "Meena", Age = 28 });
dac.Add(new Student { StudentID = 6 , Name = "Reena", Age = 27 });


var std= from stud in dac 
            where Name like  "^M"
            select stud;

foreach(Student s in std){
    Console.WriteLine(s.Name);
}

//  int[] factorsOf300 = { 2, 2, 3, 5, 5 };
//  int factorsCount=factorsOf300.Distinct().Count();
//  Console.WriteLine( "Total numbers ="+ factorsCount);

//  string [] names={"Ravi", "Sameer", "Rahul", "Manoj","Ravi", "Sarang", "Sameer"};
//  int namesCount=names.Distinct().Count();
//  Console.WriteLine( "Total names ="+ namesCount);





//     int[] marks = { 56, 54, 34, 76, 87, 98, 56, 89 };

//     var firstFourNumbers = marks.Skip(4);
//     foreach( int number in firstFourNumbers)
//     {
//         Console.WriteLine(number);
//     }

//     string[] students = { "Raj", "Simran", "Amit", "Seeta", "Amarjeet", "Rojer", "Smith" };
//     var selectedStudents= from student in students where student.Contains('a')  select student;

//     foreach ( string student in selectedStudents)
//     {
//         Console.WriteLine(student);
//     }

