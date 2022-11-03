using System;
using FluentAssertions;
using Xunit;

namespace FluentAssertionsDemo
{
    public class Tests
    {
        private readonly Subject _subject;

        public Tests()
        {
            _subject = new Subject();
        }

        [Fact]
        public void Invoking_Throw()
        {
            void Action(Subject y)
            {
                y.Foo("Hello");
            }

            var invoking = _subject.Invoking(Action);
            invoking
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Hello is not allowed at this moment");
        }
    }

    public class Subject
    {
        public void Foo(string name)
        {
            throw new InvalidOperationException("Hello is not allowed at this moment");
        }
    }
}