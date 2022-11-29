using System;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace NSubstituteDemo
{
    public class Tests
    {
        private readonly IMediator _mediator;
        private readonly MyClass _target;

        public Tests()
        {
            _mediator = Substitute.For<IMediator>();
            _target = new MyClass(_mediator);
        }

        [Fact]
        public void Invoking_Throw()
        {
            _target.Invoking(r => r.ImageNotUploaded())
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("未上傳圖片");
        }

        [Fact]
        public void Do()
        {
            var demo = new Demo();

            // 參數只有一個
            _mediator.MediatorMethod2(Arg.Do<Demo>(r => demo = r));
            _target.MyClassMethod();
            demo.Age.Should().Be(12);
            demo.Name.Should().Be("DemoName");
        }

        [Fact]
        public void WhenDo()
        {
            var first = string.Empty;
            var count = 0;
            var boolean = false;

            _mediator.When(r => r.MediatorMethod(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<bool>()))
                .Do(w =>
                {
                    first = w[0].As<string>();
                    count = w[1].As<int>();
                    boolean = w[2].As<bool>();
                });

            var demo = new Demo();

            _mediator.When(r => r.MediatorMethod2(Arg.Any<Demo>()))
                .Do(r => demo = r[0].As<Demo>());

            _target.MyClassMethod();

            first.Should().Be("ABC");
            count.Should().Be(123);
            boolean.Should().BeTrue();

            demo.Age.Should().Be(12);
            demo.Name.Should().Be("DemoName");
        }

        [Fact]
        public void Received()
        {
            _target.MyClassMethod();

            _mediator.Received().MediatorMethod(
                Arg.Is<string>(s => s.Contains("ABC")),
                Arg.Is<int>(r => r == 123),
                Arg.Is<bool>(b => b == true)
            );

            _mediator.Received().MediatorMethod2(Arg.Is<Demo>(r =>
                r.Age == 12 &&
                r.Name == "DemoName"));
        }
    }

    public interface IMediator
    {
        void MediatorMethod(string any1, int any2, bool any3);

        void MediatorMethod2(Demo demo);
    }

    public class Demo
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class MyClass
    {
        private readonly IMediator _mediator;

        public MyClass(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void ImageNotUploaded()
        {
            throw new InvalidOperationException("未上傳圖片");
        }

        public void MyClassMethod()
        {
            _mediator.MediatorMethod("ABC", 123, true);

            _mediator.MediatorMethod2(new Demo()
            {
                Name = "DemoName",
                Age = 12
            });
        }
    }
}