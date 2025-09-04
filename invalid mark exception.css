using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalid_mark_exception
using System;

class InvalidMarksException : Exception {
    public InvalidMarksException(string message) : base(message)

{
}

}

class GradingSystem {
    public static void CheckMarks(int marks)

{
    if (marks < 0 || marks > 100) throw new InvalidMarksException("Marks must be between 0 and 100.");
    if (marks >= 90) Console.WriteLine("Grade: A");
    else if (marks >= 75) Console.WriteLine("Grade: B");
    else if (marks >= 50) Console.WriteLine("Grade: C");
    else Console.WriteLine("Grade: Fail");
}
}
