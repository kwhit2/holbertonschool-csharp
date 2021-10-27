# 0x0C. C# - Delegates, Events
- [Project Page](https://intranet.hbtn.io/projects/486)

## Learning Objectives
- What are delegates and how to use them
- What are anonymous methods and how to use them
- What is multicasting
- What is the difference between delegates and interfaces
- What is a callback
- What are events and how to use them
- What is asynchronous programming

## Requirements
- Allowed editors: Visual Studio Code
- All files will be compiled on Ubuntu 14.04 LTS using dotnet
- A README.md file, at the root of the folder of the project, is mandatory
- You can organize and name your files as you like for this project, just ensure you do not push a file containing a Main method, it may conflict with our testing files.
- Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
- You do not need to push your obj/ or bin/ folders
- In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
- All your public classes and their members should have XML documentation tags
- All your private classes and members should be documented but without XML documentation tags

# Task Descriptions
- 0-universal_health/, 0-universal_health/0-universal_health.csproj : Create a public class called Player
- 1-damage_delegation/, 1-damage_delegation/1-damage_delegation.csproj : Based on 0-universal_health, create a delegate CalculateHealth that takes a float amount.
- 2-validation/, 2-validation/2-validation.csproj : Based on 1-damage_delegation, inside the TakeDamage() and HealDamage() methods, calculate the new value of the Player’s hp.
- 3-modified_behavior/, 3-modified_behavior/3-modified_behavior.csproj : Based on 2-validation, outside of the Player class, create an enum Modifier with the values Weak, Base, Strong.
- 4-check_yourself/, 4-check_yourself/4-check_yourself.csproj : Based on 3-modified_behavior, outside of the Player class, create a new class CurrentHPArgs that inherits from EventArgs.
- 5-eventful/, 5-eventful/5-eventful.csproj : Based on 4-check_yourself, create a new method HPValueWarning inside the Player class.
