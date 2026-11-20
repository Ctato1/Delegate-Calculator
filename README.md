# Delegate Calculator

A simple C# Console Application that demonstrates the use of Delegates for performing mathematical operations dynamically.

## Description

This project was created to practice and understand the Delegate concept in C#.

The application allows the user to:

- Enter two numbers
- Select a mathematical operation
- Execute the selected operation using a Delegate
- Handle exceptions such as division by zero

## Features

- Addition
- Subtraction
- Multiplication
- Division
- Exception Handling
- Delegate-Based Method Invocation

## Technologies Used

- C#
- .NET
- Visual Studio 2022

## Delegate Concept

The project uses a custom delegate:

```csharp
public delegate double MathOperation(double x, double y);
```

The delegate stores a reference to a method and allows the program to dynamically choose which operation to perform at runtime.

Supported methods:

- Add
- Subtract
- Multiply
- Divide

## Example

Input:

```text
Enter the first number:
10

Enter the second number:
5

Choose an operation:
1: Add
2: Subtract
3: Multiply
4: Divide

1
```

Output:

```text
Result: 15
```

## Learning Objectives

Through this project the following concepts were practiced:

- Delegates
- Methods
- Switch Statements
- Exception Handling
- User Input Processing

## Author

Created as a learning project for practicing C# Delegates.
