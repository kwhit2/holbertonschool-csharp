# 0x00 C# - Hello, World

## Resources
- [Install Visual Studio Code and .NET Core SDK](https://intranet.hbtn.io/rltoken/tWsXKwIHV0JWDAyuLOvRGA)
- [Introduction to the C# Language and the .NET Framework](hhttps://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)
- [Get started with C# and Visual Studio Code](https://intranet.hbtn.io/rltoken/uTW4-oIGZqXIcpaZYcRieQ)
- [C# Tutorial for Beginners (1:20 - 5:18)](https://intranet.hbtn.io/rltoken/lOzBhjrf1YJVhd8bM2Wwww)
- [Strings (C# Programming Guide)](https://intranet.hbtn.io/rltoken/n13jddnjeKFB7EKCaxDlSw)
- [C# Language Reference](https://intranet.hbtn.io/rltoken/f3kXAFX3BOio669NbSuviw)
- [C# Coding Conventions](https://intranet.hbtn.io/rltoken/XQ4f0yILy_H7WKMT4xMy6A)
- [Console.WriteLine Method](https://intranet.hbtn.io/rltoken/V8-17QNHe2JpVtNLQsKJbQ)

## Quiz
- Question #0
- What is the meaning behind the name C#?
    - [x] C++++
    - [ ] C Hash
    - [x] Inspired from musical notation where a sharp indicates that the written note should be made a half-step higher in pitch

- Question #1
- Who is the lead architect of the development team of C#?
    - [ ]Bill Gates
    - [x]Anders Hejlseberg
    - [ ]James Gosling

- Question #2
- What is .NET framework?
    - [ ] a web development tool
    - [ ] a generic top-level domain used in DNS
    - [x] a software framework developed by Microsoft

- Question #3
- What is CLR?
    - [x] Common Language Runtime
    - [ ] C# Language Reader
    - [ ] Clear

- Question #4
- What is Intermediate Language (IL) code?
    - [x] a language used by .NET Framework to generate machine-independent code
    - [ ] a language that is more difficult to learn
    - [x] a language with a purpose similar to Java bytecode

- Question #5
- What method is used for writing text to standard output with a new line?
    - [ ] Console.Write()
    - [ ] Console.Print()
    - [x] Console.WriteLine()

- Question #6
- What method is used for writing text to standard output without a new line?
    - [x] Console.Write()
    - [ ] Console.Print()
    - [ ] Console.WriteLine()

- Question #7
- What does the following code display?
```
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 1;
        int number2 = 2;
        int number3 = 3;
        Console.WriteLine("{0} {1} {2}", number1, number2, number3);
    }
}
```
- [ ] 0 1 2
- [x] 1 2 3
- [ ] number1 number2 number3

- Question #8
- What does the following code display?
```
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 1;
        int number2 = 2;
        int number3 = 3;
        Console.WriteLine("{2} {0} {1}", number1, number2, number3);
    }
}
```
- [x] 3 1 2
- [ ] number2, number1, number2
- [ ] 2 0 1
- [ ] 1 2 3

## Learning Objectives
- What is the meaning behind the name C#?
- Who is the lead architect of the development team of C#?
- What is .NET?
- What is the difference between C# and .NET?
- How to use VSCode and the integrated terminal to initialize, build, and run C# projects
- How to print text and variables using Console.Write

## Task Descriptions
- 0-initialize_new_project.sh : a Bash script that initializes a new C# project inside a folder titled 0-new_project.
- 1-build_new_project.sh : a Bash script that initializes and builds a new C# project inside a folder titled 1-new_project
- 2-run_new_project.sh : a Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project.
- 3-writeline/, 3-writeline/3-writeline.csproj, 3-writeline/3-writeline.cs : a C# script that prints exactly "Programming is like building a multilingual puzzle followed by a new line.
- 4-print_integer/, 4-print_integer/4-print_integer.csproj, 4-print_integer/4-print_integer.cs : Complete this source code in order to print the integer stored in the variable number, followed by Mission Street followed by a new line.
- 5-print_float/, 5-print_float/5-print_float.csproj, 5-print_float/5-print_float.cs : Complete this source code in order to print the float stored in the variable number with a precision of 2 digits.
- 6-print_string/, 6-print_string/6-print_string.csproj, 6-print_string/6-print_string.cs : Complete this source code in order to print a string stored in the variable str 3 times, followed by its first 9 characters.
- 7-concat/, 7-concat/7-concat.csproj, 7-concat/7-concat.cs : Complete this source code to print Welcome to Holberton School!
- 8-print_variables/, 8-print_variables/8-print_variables.csproj, 8-print_variables/8-print_variables.cs : Complete this source code in order to print the given variables as 972 Mission Street.
- 9-print_specifiers/, 9-print_specifiers/9-print_specifiers.csproj, 9-print_specifiers/9-print_specifiers.cs : Complete this source code in order to print the given variables as in the result shown.
- 10-copy_cut_paste/, 10-copy_cut_paste/10-copy_cut_paste.csproj, 10-copy_cut_paste/10-copy_cut_paste.cs : Complete this source code.
- 11-concat_edges/, 11-concat_edges/11-concat_edges.csproj, 11-concat_edges/11-concat_edges.cs : Complete this source code to print object-oriented programming in C# followed by a new line.
- 100-hello_error/, 100-hello_error/100-hello_error.csproj, 100-hello_error/100-hello_error.cs : a C# script that prints exactly and that piece of art is useful - Dora Korpar, 2015-10-19 followed by a new line.
