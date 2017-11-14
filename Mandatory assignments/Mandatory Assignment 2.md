# Mandatory Assignment 2

I want you to create an application using .NET (Core or Framework), i want you to create a github repository, where I can clone and review your attempt. The link for the GitHub repository will be submitted in a txt-file on Blackboard.

You are to create an application, either web or gui based, where I can enter a draw for a prize. It is only possible to enter the draw, if you have a valid serial number. A serial number must be unique and can only be submitted once!

You need to persist the data, which includes valid serial numbers and submissions. You are not allowed to use any kind of database, but instead you should use some kind of file persistence.

You are allowed to use any external libraries, but you are required to use NuGet for .NET dependencies and NPM/Bower for Javascript dependencies.

## Instructions

- Create projects
  - Create a project for the presentation
  - Create a class library project
- Define file-format for data-persistence
- Create/Generate 100 valid serial numbers
- Create a submission form in your presentation
  - The form should include:
    - First name
    - Sur name
    - Email address
    - Phone number
    - Date of Birth
    - Serial Number
  - You need to validate the form data, before persisting it
- Create a view, where it is possible to see submissions
  - Bonus: Paginate the view, to show 10 submissions at a time
  - Bonus: Require authenticated access to view this page
- Write a readme.md file (markdown) at the root of your project
  - This readme will detail how to get your project up-and-running once it is cloned
- Bonus tasks:
  - Use Inversion of Control / Dependency Injection
  - Write Unit tests for Presentation and Class library code

It is up to each of you to prioritise the different tasks. It is not important to finish all bullet points, instead it is of interest to see how you code in a somewhat larger project. Furthermore, Christian and I will asses each assignment based on its on merits.

Remember, write clean code and make it understandable for anyone :)

## Deadline

December 12th, 19.59

I will dedicate some time during all TA lessons, to allow you to ask questions.