// See https://aka.ms/new-console-template for more information
using Mapster;
using MapsterDemo;

Console.WriteLine("Hello, World!");
var student = new StudentEntity
{
    Entities = new List<SchoolEntity> {
        new SchoolEntity
        {
            Name="学生1"
        }
    }
};
var a = student.Adapt<StudentEntity, StudentEntityDTO>();

var error = a.Entities;

Console.ReadLine();
