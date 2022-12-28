using System;
using System.Reflection;
using ReflectionClassDemo;

namespace ReflectionDemo
{
    /// <summary>
    /// 反射:就是操作dll文件的一個類
    /// 怎麼使用: 1.查找DLL文件 2. 通過 System.Reflection反射類庫的各種方法來操作dll文件
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1.加載 DLL文件
            // #region 方式一 添加引用ReflectionClassDemo
            //
            // var assembly = Assembly.Load("ReflectionClassDemo");
            //
            // #endregion

            // #region 方式二 完整路徑
            //
            // var assembly = Assembly.LoadFile(@"C:\Users\s9740\Desktop\Practice\2022\NET\ReflectionClassDemo\bin\Debug\ReflectionClassDemo.dll");
            //
            // #endregion
            // #region 方式三 完整路徑
            //
            // var assembly = Assembly.LoadFrom(@"C:\Users\s9740\Desktop\Practice\2022\NET\ReflectionClassDemo\bin\Debug\ReflectionClassDemo.dll");
            //
            // #endregion

            #region 方式四 完整名稱

            var assembly = Assembly.LoadFrom(@"ReflectionClassDemo.dll");

            #endregion

            //2.獲取指定類型
            var type = assembly.GetType("ReflectionClassDemo.ReflectionTest");

            //實例化
            // ReflectionTest reflectionTest = new ReflectionTest(); //靜態
            
            #region 呼叫public 的 ctor
            
            // object instance = Activator.CreateInstance(type);                       //動態
            object instance = Activator.CreateInstance(type, new object[] {"反射"}); //動態
            #endregion
            
            var type2 = assembly.GetType("ReflectionClassDemo.ReflectionTest2"); 
            object instance2 = Activator.CreateInstance(type2,true);                       //動態
        }
    }
}