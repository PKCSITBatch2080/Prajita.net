// Single Inheritance
using System.Reflection.Metadata.Ecma335;

class CSstudent : Student, IGradeable   // Multiple Inheritance
{
    public CSstudent(string name, byte rn, string pTitle) 
        : base(name, rn)
    {
        ProjectTitle = pTitle;
    }

    public string ProjectTitle { get; set; }
    public string InternWork { get; set; }

    public double GetGrade() => 3.6;
}