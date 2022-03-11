# Magic Year Kata

## Introduction
This is my first attempt at TDD. Just setting up the file structure properly and connecting the Tests project with the Code project was a learning experience in itself.

## Installation
In order to run the program, you will need to have the .NET SDK installed on your computer.
You can install the .NET SDK using homebrew on the command line: `brew install --cask dotnet-sdk`
Alternatively, you can download the .NET SDK [here](https://dotnet.microsoft.com/en-us/)

To run the program, use the command `dotnet run` from the CLI when at the root directory of the project

## Kata Instructions

We have the following rules:  

* Magic Year = work start year + 65
* Monthly salary = annual salary / 12 (rounded up)
* All calculation results should be rounded to the whole dollar. If >= 50 cents round up to the next dollar increment, otherwise round down.   

For example, the following calculations would result with an annual salary of $60,050 starting work in the year 1980:

* Monthly salary = 60,050 / 12 = 5,004.16666667 (round down) = 5,004  
* Magic year = 1980 + 65 = 2045

### Your Task

Generate a magic year calculator. You should be able to enter a single persons details, the application will generate a result. Everything will be done via the console.

An example run through of of how this console would be...

~~~
Welcome to the magic year calculator!

Please input your name: John  
Please input your surname: Doe  
Please enter your annual salary: 60050
Please enter your work start year : 1980

Your magic age details are:

Name: John Doe  
Monthly Salary: 5004
Magic Year: 2045
~~~

## Solution

## Improvements