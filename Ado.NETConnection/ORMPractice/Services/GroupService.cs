using ORMPractice.DAL;
using ORMPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMPractice.Services
{
    internal class GroupService
    {
        public List<Group> Get()
        {
            var dataContext = new DataContext();
            return dataContext.Groups.ToList();
        }
        public Group GetById(int id)
        {
            if (id == null)
                Console.WriteLine("Id null ola bilmez");
            return null;
            var dataContext = new DataContext();
            return dataContext.Groups.Find(id);
        }
        public void Create(Group group)
        {
            var dataContext = new DataContext();
            var existGroup=dataContext.Groups.FirstOrDefault(g => g.Name == group.Name);
            if(existGroup != null)
            {
                Console.WriteLine($"{group.Name} artiq movcuddur...");
                return;
            }
            dataContext.Groups.Add(group);
        }
        public void Update(int id,string name)
        {
            if (id == null)
            {
                Console.WriteLine("Id null ola bilmez...");
                return;
            }
            var dataContext = new DataContext();
            var existGroup = dataContext.Groups.Find(id);
            if(existGroup == null )
            {
                Console.WriteLine($"{id} li group movcud deyil");
                return;
            }
            existGroup.Name = name;
            dataContext.SaveChanges();
        }
        public void Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Id null ola bilmez");
                return;
            }
            var dataContext=new DataContext();
            var exisGroup = dataContext.Groups.Find(id);
            if (exisGroup == null)
            {
                Console.WriteLine($"{id} li group yoxdur.");
                return;
            }
            dataContext.Groups.Remove(exisGroup);
            dataContext.SaveChanges();
        }
    }
}
