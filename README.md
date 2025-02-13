# Uninitialized Property Access in C# 

This repository demonstrates a common error in C#: accessing a property before it's been assigned a value. Uninitialized properties can lead to unexpected results or exceptions.

## The Bug

The `bug.cs` file contains a class with an uninitialized property `MyProperty`.  The `MyMethod` attempts to access this property before it is given a value. The output may vary depending on the context but generally will either print 0 (or null for reference types) or it could potentially throw an exception if the property is part of some initialization check. 

## The Solution

The `bugSolution.cs` file shows how to initialize the property either in the class's declaration or in the constructor.

## How to reproduce

1. Clone this repository.
2. Open the `bug.cs` file and run it. Note the output.
3. Compare the output with the `bugSolution.cs` file.