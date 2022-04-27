// See https://aka.ms/new-console-template for more information
using RobotsManagement;

Console.WriteLine("Hello, World!");

var fileReader = new FileReader();

var robot = fileReader.ConvertJsonToRobot("robot.txt");
Console.ReadLine();
