using System;

namespace InheritanceDemo
{
    internal class AirPlane:Fly
    {
        public string name;
        public string type;

        public AirPlane()
        {
            Console.WriteLine("AirPlane類別初始化");
        }
        public void Info()
        {
            Console.WriteLine("飛機型號" + type + "飛機名稱" + name);
        }
    }
}