using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace UnionDemo
{
    public class Tests
    {
        [Fact]
        public void valueType()
        {
            var lefts = new List<int>()
            {
                1, 2, 3
            };

            var rights = new List<int>()
            {
                3, 4, 5
            };
            var myClasses = lefts.Union(rights).ToList();

            myClasses.Should().BeEquivalentTo(new List<int>()
            {
                1, 2, 3, 4, 5
            });
        }
        [Fact]
        public void 全要()
        {
            var lefts = new List<MyClass>()
            {
                new MyClass() {Id = 1, Value = "leftA1"},
                new MyClass() {Id = 2, Value = "leftA2"}
            };

            var rights = new List<MyClass>()
            {
                new MyClass() {Id = 2, Value = "rightB1"},
                new MyClass() {Id = 3, Value = "rightB2"}
            };
            var myClasses = lefts.Union(rights).ToList();

            myClasses.Should().BeEquivalentTo(new List<MyClass>()
            {
                new MyClass() {Id = 1, Value = "leftA1"},
                new MyClass() {Id = 2, Value = "leftA2"},
                new MyClass() {Id = 2, Value = "rightB1"},
                new MyClass() {Id = 3, Value = "rightB2"}
            });
        }

       

        [Fact]
        public void 去除重複值以左邊為主體()
        {
            var a = new MyClass() {Id = 2, Value = "leftA2"}.Equals( new MyClass() {Id = 2, Value = "leftA2"});
            var lefts = new List<MyClass>()
            {
                new MyClass() {Id = 1, Value = "leftA1"},
                new MyClass() {Id = 2, Value = "leftA2"}
            };

            var rights = new List<MyClass>()
            {
                new MyClass() {Id = 3, Value = "rightB3"},
                new MyClass() {Id = 2, Value = "leftA2"},
                new MyClass() {Id = 4, Value = "rightB4"},
            };
            var myClasses = lefts.Union(rights).ToList();//看union裡面的實作
            // myClasses.Should().BeEquivalentTo(new List<MyClass>()
            // {
            //     new MyClass() {Id = 1, Value = "leftA1"},
            //     new MyClass() {Id = 2, Value = "leftA2"},
            //     new MyClass() {Id = 3, Value = "rightB3"},
            //     new MyClass() {Id = 4, Value = "rightB4"},
            // });
        }

        [Fact]
        public void IEqualityComparer演化一()
        {
            var lefts = new List<MyClass2>()
            {
                new MyClass2() {Id = 1, Value = "leftA1"},
                new MyClass2() {Id = 2, Value = "leftA2"}
            };

            var rights = new List<MyClass2>()
            {
                new MyClass2() {Id = 3, Value = "rightB3"},
                new MyClass2() {Id = 2, Value = "leftA2"},
                new MyClass2() {Id = 4, Value = "rightB4"},
            };
            var myClasses = lefts.Union(rights, new Comparer()).ToList();
            myClasses.Should().BeEquivalentTo(new List<MyClass2>()
            {
                new MyClass2() {Id = 1, Value = "leftA1"},
                new MyClass2() {Id = 2, Value = "leftA2"},
                new MyClass2() {Id = 3, Value = "rightB3"},
                new MyClass2() {Id = 4, Value = "rightB4"},
            });
        }
        
        //TODO: use record
        
        //TODO : use 匿名
        [Fact]
        public void IEqualityComparer演化一52345()
        {
            var lefts = new List<object>()
            {
                new {Id = 1, Value = "leftA1"},
                new  {Id = 2, Value = "leftA2"}
            };

            var rights = new List<object>()
            {
                new MyClass2() {Id = 3, Value = "rightB3"},
                new MyClass2() {Id = 2, Value = "leftA2"},
                new MyClass2() {Id = 4, Value = "rightB4"},
            };
            var myClasses = lefts.Union(rights).ToList();
            myClasses.Should().BeEquivalentTo(new List<object>()
            {
                new MyClass2() {Id = 1, Value = "leftA1"},
                new MyClass2() {Id = 2, Value = "leftA2"},
                new MyClass2() {Id = 3, Value = "rightB3"},
                new MyClass2() {Id = 4, Value = "rightB4"},
            });
        }

        [Fact]
        public void IEqualityComparer演化二()
        {
            var lefts = new List<MyClass2>()
            {
                new MyClass2() {Id = 1, Value = "leftA1"},
                new MyClass2() {Id = 2, Value = "leftA2"}
            };

            var rights = new List<MyClass2>()
            {
                new MyClass2() {Id = 3, Value = "rightB3"},
                new MyClass2() {Id = 2, Value = "leftA2"},
                new MyClass2() {Id = 4, Value = "rightB4"},
            };
            Func<int, string, string> three = (i, s) => i.ToString() + s;
            var equalityComparer = new Comparer2<MyClass2>(
                (x, y) => x.Id == y.Id && x.Value == y.Value,
                o => o.Id,
                three);
           
            var myClasses = lefts.Union(rights, equalityComparer
            ).ToList();
            myClasses.Should().BeEquivalentTo(new List<MyClass2>()
            {
                new MyClass2() {Id = 1, Value = "leftA1"},
                new MyClass2() {Id = 2, Value = "leftA2"},
                new MyClass2() {Id = 3, Value = "rightB3"},
                new MyClass2() {Id = 4, Value = "rightB4"},
            });
        }
    }

    public class Comparer2<T> : IEqualityComparer<T>
    {
        private readonly Func<T, T, bool> _predicate;
        private readonly Func<T, int> _keySelector;
        private readonly Func<int, string, string> _three;

        public Comparer2(Func<T, T, bool> predicate, Func<T, int> keySelector, Func<int, string, string> three)
        {
            _predicate = predicate;
            _keySelector = keySelector;
            _three = three;
        }

        public bool Equals(T x, T y)
        {
            return _predicate(x, y);
        }
        
        public int GetHashCode(T obj)
        {
            return _keySelector(obj);
        }
        
        
    }

    public class Comparer : IEqualityComparer<MyClass2>
    {
        public bool Equals(MyClass2 x, MyClass2 y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null) || x.GetType() != y.GetType())
            {
                return false;
            }
            return x.Id == y.Id && x.Value == y.Value;
        }

        public int GetHashCode(MyClass2 obj)
        {
            unchecked
            {
                return (obj.Id * 397) ^ (obj.Value != null ? obj.Value.GetHashCode() : 0);
            }
        }
//建議
        // public bool Equals(MyClass2 x, MyClass2 y)
        // {
        //     return x.Id == y.Id && x.Value == y.Value;
        // }
        //
        // public int GetHashCode(MyClass2 obj)
        // {
        //     return obj.Id.GetHashCode();
        // }
    }

    public class MyClass2
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }

    public class MyClass
    {
        public int Id { get; set; }

        public string Value { get; set; }

        /// <summary>
        /// 預設的Equals方法比較的是物件的參考，而不是物件的內容
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is MyClass other))
            {
                return false;
            }
            return this.Id == other.Id && this.Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}