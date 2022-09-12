//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();

//class IntroToLINQ
//{
//    static void Main()
//    {
//        // The Three Parts of a LINQ Query:
//        // 1. Data source.
//        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

//        // 2. Query creation.
//        // numQuery is an IEnumerable<int>
//        var numQuery =
//            from num in numbers
//            where (num % 2) == 0
//            select num;

//        // 3. Query execution.
//        foreach (int num in numQuery)
//        {
//            Console.Write("{0,2} ", num);
//        }
//    }
//}

//class Student
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int ID { get; set; }
//    public GradeLevel? Year { get; set; }
//    public List<int> ExamScores { get; set; }

//    public Student(string FirstName, string LastName, int ID, GradeLevel Year, List<int> ExamScores)
//    {
//        this.FirstName = FirstName;
//        this.LastName = LastName;
//        this.ID = ID;
//        this.Year = Year;
//        this.ExamScores = ExamScores;
//    }

//    public Student(string FirstName, string LastName, int StudentID, List<int>? ExamScores = null)
//    {
//        this.FirstName = FirstName;
//        this.LastName = LastName;
//        ID = StudentID;
//        this.ExamScores = ExamScores ?? Enumerable.Empty<int>().ToList();
//    }

//    public static List<Student> students = new()
//    {
//        new(
//            FirstName: "Terry", LastName: "Adams", ID: 120,
//            Year: GradeLevel.SecondYear,
//            ExamScores: new() { 99, 82, 81, 79 }
//        ),
//        new(
//            "Fadi", "Fakhouri", 116,
//            GradeLevel.ThirdYear,
//            new() { 99, 86, 90, 94 }
//        ),
//        new(
//            "Hanying", "Feng", 117,
//            GradeLevel.FirstYear,
//            new() { 93, 92, 80, 87 }
//        ),
//        new(
//            "Cesar", "Garcia", 114,
//            GradeLevel.FourthYear,
//            new() { 97, 89, 85, 82 }
//        ),
//        new(
//            "Debra", "Garcia", 115,
//            GradeLevel.ThirdYear,
//            new() { 35, 72, 91, 70 }
//        ),
//        new(
//            "Hugo", "Garcia", 118,
//            GradeLevel.SecondYear,
//            new() { 92, 90, 83, 78 }
//        ),
//        new(
//            "Sven", "Mortensen", 113,
//            GradeLevel.FirstYear,
//            new() { 88, 94, 65, 91 }
//        ),
//        new(
//            "Claire", "O'Donnell", 112,
//            GradeLevel.FourthYear,
//            new() { 75, 84, 91, 39 }
//        ),
//        new(
//            "Svetlana", "Omelchenko", 111,
//            GradeLevel.SecondYear,
//            new() { 97, 92, 81, 60 }
//        ),
//        new(
//            "Lance", "Tucker", 119,
//            GradeLevel.ThirdYear,
//            new() { 68, 79, 88, 92 }
//        ),
//        new(
//            "Michael", "Tucker", 122,
//            GradeLevel.FirstYear,
//            new() { 94, 92, 91, 91 }
//        ),
//        new(
//            "Eugene", "Zabokritski", 121,
//            GradeLevel.FourthYear,
//            new() { 96, 85, 91, 60 }
//        )
//    };

//    static void Main()
//    {
//        void QueryHighScores(int exam, int score)
//        {
//            var highScores =
//                from student in students
//                where student.ExamScores[exam] > score
//                select new
//                {
//                    Name = student.FirstName,
//                    Score = student.ExamScores[exam]
//                };

//            foreach (var item in highScores)
//            {
//                Console.WriteLine($"{item.Name,-15}{item.Score}");
//            }
//        }

//        QueryHighScores(1, 90);
//    }


//}

//enum GradeLevel
//{
//    FirstYear = 1,
//    SecondYear,
//    ThirdYear,
//    FourthYear
//};


class Student
{
    record Person(string FirstName, string LastName);
    record Pet(string Name, Person Owner);
    record Employee(string FirstName, string LastName, int EmployeeID);
    record Cat(string Name, Person Owner) : Pet(Name, Owner);
    record Dog(string Name, Person Owner) : Pet(Name, Owner);
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ID { get; set; }
    public GradeLevel? Year { get; set; }
    public List<int> ExamScores { get; set; }

    public Student(string FirstName, string LastName, int ID, GradeLevel Year, List<int> ExamScores)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.ID = ID;
        this.Year = Year;
        this.ExamScores = ExamScores;
    }

    public Student(string FirstName, string LastName, int StudentID, List<int>? ExamScores = null)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        ID = StudentID;
        this.ExamScores = ExamScores ?? Enumerable.Empty<int>().ToList();
    }

    public static List<Student> students = new()
    {
        new(
            FirstName: "Terry", LastName: "Adams", ID: 120,
            Year: GradeLevel.SecondYear,
            ExamScores: new() { 99, 82, 81, 79 }
        ),
        new(
            "Fadi", "Fakhouri", 116,
            GradeLevel.ThirdYear,
            new() { 99, 86, 90, 94 }
        ),
        new(
            "Hanying", "Feng", 117,
            GradeLevel.FirstYear,
            new() { 93, 92, 80, 87 }
        ),
        new(
            "Cesar", "Garcia", 114,
            GradeLevel.FourthYear,
            new() { 97, 89, 85, 82 }
        ),
        new(
            "Debra", "Garcia", 115,
            GradeLevel.ThirdYear,
            new() { 35, 72, 91, 70 }
        ),
        new(
            "Hugo", "Garcia", 118,
            GradeLevel.SecondYear,
            new() { 92, 90, 83, 78 }
        ),
        new(
            "Sven", "Mortensen", 113,
            GradeLevel.FirstYear,
            new() { 88, 94, 65, 91 }
        ),
        new(
            "Claire", "O'Donnell", 112,
            GradeLevel.FourthYear,
            new() { 75, 84, 91, 39 }
        ),
        new(
            "Svetlana", "Omelchenko", 111,
            GradeLevel.SecondYear,
            new() { 97, 92, 81, 60 }
        ),
        new(
            "Lance", "Tucker", 119,
            GradeLevel.ThirdYear,
            new() { 68, 79, 88, 92 }
        ),
        new(
            "Michael", "Tucker", 122,
            GradeLevel.FirstYear,
            new() { 94, 92, 91, 91 }
        ),
        new(
            "Eugene", "Zabokritski", 121,
            GradeLevel.FourthYear,
            new() { 96, 85, 91, 60 }
        )
    };
     
    static void Main()
    {
        Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
        Person terry = new("Terry", "Adams");
        Person charlotte = new("Charlotte", "Weiss");
        Person arlene = new("Arlene", "Huff");
        Person rui = new("Rui", "Raposo");

        List<Person> people = new() { magnus, terry, charlotte, arlene, rui };

        List<Pet> pets = new()
{
    new(Name: "Barley", Owner: terry),
    new("Boots", terry),
    new("Whiskers", charlotte),
    new("Blue Moon", rui),
    new("Daisy", magnus),
};

        // Create a collection of person-pet pairs. Each element in the collection
        // is an anonymous type containing both the person's name and their pet's name.
        var query =
            from person in people
            join pet in pets on person equals pet.Owner
            select new
            {
                OwnerName = person.FirstName,
                PetName = pet.Name
            };

        foreach (var ownerAndPet in query)
        {
            Console.WriteLine($"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}");
        }

        /* Output:
             "Daisy" is owned by Magnus
             "Barley" is owned by Terry
             "Boots" is owned by Terry
             "Whiskers" is owned by Charlotte
             "Blue Moon" is owned by Rui
        */
    }

}

enum GradeLevel
{
    FirstYear = 1,
    SecondYear,
    ThirdYear,
    FourthYear
};
