using _03_ObjectClassConstructorInheritanceThisvsBase.Models;

Student student= new Student("450E","Computer Science",88.5);
Student student1= new Student("650F","Information Technology",92.0);
Student student2= new Student("544D","Information Security",68.5);
student.FirstName = "Cavad";
student.LastName = "Sukurlu";

student.ShowStudentInfo();
student.CalculateScholarship();
student1.ShowStudentInfo();
student1.CalculateScholarship();
student2.ShowStudentInfo();
student2.CalculateScholarship();
Console.WriteLine("---------------------------------------------------------------");
Teacher teacher = new Teacher("Computer Science","Programming",2000,15);
Teacher teacher1 = new Teacher("Information Technology", "Networking", 2500, 8);
teacher.ShowTeacherInfo();
teacher.CalculateSalary();
teacher1.ShowTeacherInfo();
teacher1.CalculateSalary();
Console.WriteLine("-----------------------------------------------------------------");
Administrator administrator = new Administrator("Dekan");
administrator.ShowAdminInfo();
administrator.GrantAccess(student);
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Umumi teqaud xerci:");
int umumiTeqaud = student.CalculateScholarship() + student1.CalculateScholarship() + student2.CalculateScholarship();
Console.WriteLine(umumiTeqaud);
Console.WriteLine("Umumi maas xerci:");
decimal umumiMaas = teacher.CalculateSalary() + teacher1.CalculateSalary();
Console.WriteLine(umumiMaas);

