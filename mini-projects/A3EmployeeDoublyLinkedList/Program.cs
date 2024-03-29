﻿using A3EmployeeDoublyLinkedList.DLL;
using A3EmployeeDoublyLinkedList.Entities;

DoublyLinkedList doublyLinkedList = new();

ForegroundColor = ConsoleColor.Cyan;
List<Employee> employees = new()
{
    new Employee {Id=999, Name="racecar"},
    new Employee {Id=25, Name="mack"},
    new Employee {Id=1999, Name="pop"},
    new Employee {Id=125, Name="jack"},
    new Employee {Id=1259, Name="nick"},
};

WriteLine("Adding Employees to Doubly Linked List");
employees.ForEach(employee =>
{
    WriteLine($"Id: {employee.Id} | Name: {employee.Name}");
    doublyLinkedList.AddLast(employee);
});

ForegroundColor = ConsoleColor.Blue;
WriteLine("\nNumber of Elements inside Doubly Linked List: " + doublyLinkedList.Length());

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nDisplaying Employees from Doubly Linked List");
doublyLinkedList.Display();

ResetColor();
WriteLine("\nPress any key ...");
ReadKey();
