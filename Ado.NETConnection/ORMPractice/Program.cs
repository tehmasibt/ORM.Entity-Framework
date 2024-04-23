// See https://aka.ms/new-console-template for more information
using ORMPractice.DAL;
using ORMPractice.Services;

Console.WriteLine("Hello, World!");


using DataContext dataContext = new DataContext();
//var groups = dataContext.Groups.ToList();
//foreach (var item in groups)
//{
//    Console.WriteLine(item);
//}


//Insert
//dataContext.Groups.Add(new() { Name = "PB310" });// insert query-si yaradir.
//dataContext.SaveChanges();


//Colxu data gondermek
//dataContext.Groups.AddRange(new() { Name = "PB308" }, new() { Name = "PB330" });
//dataContext.SaveChanges();


GroupService groupService = new GroupService();
//groupService.Update(5, "Taleh");
groupService.Delete(3);



































