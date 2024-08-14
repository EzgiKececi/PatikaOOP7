using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaAbstraction
{
    public abstract class Person // Ortak özelliklerin olduğu abstract sınıf oluşturuldu
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }

        public abstract void Position();
        
        public virtual void PersonInfo() 
        {
            Console.WriteLine($"{Name} {Surname} {Department} ");
        }
    }

    public class Employee : Person
    {
        public Employee(string name, string surname, string department,string job) 
        {
            Name = name;
            Surname = surname;
            Department = department;
            Job = job;

        }
        public override void PersonInfo()
        {
            base.PersonInfo();
        }

        public override void Position()
        {
            Console.WriteLine($"{Job} olarak çalışmakta.");
        }
    } }
