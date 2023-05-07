using System;

namespace PolymorphismDemo3
{
    internal class Program
    {
        //用多態來實現 將U盤或者MP3插入電腦，都可以進行讀寫操作
        public static void Main(string[] args)
        {
            var mp3 = new Mp3();
            var computer = new Computer
            {
                Ms = mp3
            };
            computer.ReadData();
            computer.WriteData();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class Mp3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3 Read");
        }

        public override void Write()
        {
            Console.WriteLine("MP3 Write");
        }
    }

    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MobileDisk Read");
        }

        public override void Write()
        {
            Console.WriteLine("MobileDisk Write");
        }
    }

    public class Computer
    {
        public MobileStorage Ms { get; set; }

        public void ReadData()
        {
            Ms.Read();
        }

        public void WriteData()
        {
            Ms.Write();
        }
    }
}