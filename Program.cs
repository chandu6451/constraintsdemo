using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoonstraintsDemo
{
    public class MyGenClass<T> where T : class
    { }

    public struct Student
    {
        public int RollNo { get; set; }
        public string StudName { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGenClass<int> objint = new MyGenClass<int>();
            MyGenClass<Student> objStud = new MyGenClass<Student>();
            MyGenClass<char> objChar = new MyGenClass<char>();
            MyGenClass<byte> objByte = new MyGenClass<byte>();

            MyGenClass<object> obj = new MyGenClass<object>();
            MyGenClass<string> objstr = new MyGenClass<string>();
            MyGenClass<Employee> objemp = new MyGenClass<Employee>();
        }
    }
}
