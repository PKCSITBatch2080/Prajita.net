//LINQ - Language Integrated Query
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class LINQLearner{
    void learn()
    {
        int[] numbers = [3, 4, 5, 67, 12, 34, 56, 78 ,89 ,98 , 123];
        List<string> names =["prajita" , "sona", "anupa", "prakriti"];

       var s1 = new Student( "bishnu" , 12 , new DateTime (1998 , 12 ,12));
       var s2 = new Student( "ram" , 12 , new DateTime (1999 , 12 ,12));
       var s3 = new Student( "prajita" , 12 , new DateTime (2000 , 12 ,12));
       var s4 = new Student( "anupa" , 12 , new DateTime (2003 , 12 ,12));
       var s5 = new Student( "anmol" , 12 , new DateTime (1999, 12 ,12));
       List <Student> 


        //order names in ascending order
        var namesOredred = names.OrderBy( x => x);

        //Get odd nuberws from "numbers"
        var oddNumbers = numbers.Where(numbers => numbers % 2 == 1);  //Lambda Expression

        // Get squares of all items in "numbers"
        var squares = numbers.Select(x => x * x);

        //Get squares of even numbers only
        // method syntax
        var evenSquares = numbers.Where(x => x % 2 == 0).Select(y => y* y); 

        //Query Syntax
        evenSquares = from x in numbers
                        where x % 2 == 0
                        select x * x;

    }
    //get name initials
     var initials = names.Select(name => name[0]);  //  ['p' , 's' , 'a' , 'p']


     //find students with name starting with "B"
     var bStudents = Student.Where(Student => Student.name.ToLower().StartsWith('b'));

     //group student by birth  month
     vardobGroups = studentsGroupBy(Student => Student => Student.Dob.Month);

     //get youngest student 
     varyoungest = bStudents.OrderByDescending(X500DistinguishedName => X500DistinguishedName.Dob.First())
}