using NestedObjects;

Advisor compSciAdvisor = new()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "1234567890",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

// $ interperlated sign
Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");