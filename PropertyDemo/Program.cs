using System;
using System.Runtime.InteropServices;

namespace PropertyDemo
{
    internal class Program
    {
        //屬性的作用就是保護字段，對字段的賦值與取值進行限定
        //屬性的本質就是兩個方法，get(),set()
        public static void Main(string[] args)
        {
            //需用debug模式觀看，程式碼如何運行
            var person = new Person();
            var pageInfo = new PageInfo(1,10);
            var skip = pageInfo.Skip;
            person.Age = -12;
            person.CHCSS();
          
        }
    }

    internal class PageInfo
    {
        private int _page;

        public int Size { get; private set; }

        public void SetSize(int value)
        {
            if (value<0)
            {
                throw new Exception();
            }
            _page = 1;
            Size = value;
        }
        public PageInfo(int page, int size)
        {
            _page = page;
            Size = size;
        }

        public int Skip => _page * Size;
    }
}