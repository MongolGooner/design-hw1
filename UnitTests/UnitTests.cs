using Xunit;
using design_hw1;
using Xunit.Sdk;
using System.Numerics;
using Moq;
using Vector = design_hw1.Vector;

namespace UnitTests
{

    public class UnitTests
    {
        #region hw-1
        [Fact]
        public void NoSolutionTest()
        {
            //arrange
            var a = 1;
            var b = 0;
            var c = 1;
            //act
            var result = Square.Solve(a, b, c);
            //assert
            Assert.Empty(result);
        }

        [Fact]
        public void TwoSolutionsTest()
        {
            //arrange
            var a = 1;
            var b = 0;
            var c = -1;
            //act
            var result = Square.Solve(a, b, c);
            //assert
            Assert.Equal(2, result.Length);
        }

        [Fact]
        public void OneSolutionTest()
        {
            //arrange
            var a = 1;
            var b = 2;
            var c = 1;
            //act
            var result = Square.Solve(a, b, c);
            //assert
            Assert.Single(result);
        }

        [Fact]
        public void SmallATest()
        {
            //arrange
            var a = 0;
            var b = 2;
            var c = 1;
            //act

            //assert
            Assert.Throws<Exception>(() => Square.Solve(a, b, c));
        }

        [Fact]
        public void NanInfinityTest()
        {
            //arrange

            //act

            //assert
            Assert.Throws<Exception>(() => Square.Solve(double.NaN, 1, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, double.NaN, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, 1, double.NaN));

            Assert.Throws<Exception>(() => Square.Solve(double.PositiveInfinity, 1, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, double.PositiveInfinity, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, 1, double.PositiveInfinity));


            Assert.Throws<Exception>(() => Square.Solve(double.NegativeInfinity, 1, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, double.NegativeInfinity, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, 1, double.NegativeInfinity));

        }

        #endregion
        #region hw-2
        //[Fact]
        //public void MoveTest()
        //{
        //    //arrange
        //    Mock<IMovable> mockMovable = new Mock<IMovable>();

        //    mockMovable.SetupGet<Vector>(x => x.Position).Returns(new Vector(12, 5)).Verifiable();
        //    mockMovable.SetupGet<Vector>(x => x.Velocity).Returns(new Vector(-7, 3)).Verifiable();


        //    //act
        //    new Move(mockMovable.Object).Execute();
        //    //assert

        //    mockMovable.VerifySet(x => x.Position = new Vector(5, 8));
        //    mockMovable.Verify();
        //}

        //[Fact]
        //public void PositionNotReadableTest()
        //{
        //    //arrange
        //    Mock<IMovable> mockMovable = new Mock<IMovable>();

        //    mockMovable.SetupGet<Vector>(x => x.Position).Throws<Exception>().Verifiable();
        //    mockMovable.SetupGet<Vector>(x => x.Velocity).Returns(new Vector(-7, 3)).Verifiable();
        //    //act
        //    //assert
        //    Assert.Throws<Exception>(() => new Move(mockMovable.Object).Execute());
        //}

        //[Fact]
        //public void VelocityNotReadableTest()
        //{
        //    //arrange
        //    Mock<IMovable> mockMovable = new Mock<IMovable>();

        //    mockMovable.SetupGet<Vector>(x => x.Velocity).Throws<Exception>().Verifiable();
        //    mockMovable.SetupGet<Vector>(x => x.Position).Returns(new Vector(-7, 3)).Verifiable();
        //    //act
        //    //assert
        //    Assert.Throws<Exception>(() => new Move(mockMovable.Object).Execute());
        //}
        //[Fact]
        //public void PositionNotWriteableTest()
        //{
        //    //arrange
        //    Mock<IMovable> mockMovable = new Mock<IMovable>();

        //    mockMovable.SetupGet(x => x.Position).Returns(new Vector(12, 5)).Verifiable();
        //    mockMovable.SetupGet(x => x.Velocity).Returns(new Vector(-7, 3)).Verifiable();
        //    mockMovable.SetupSet(x => x.Position = It.IsAny<Vector>()).Throws<Exception>().Verifiable();

        //    //act
        //    //new Move(mockMovable.Object).Execute();
        //    //assert

        //    Assert.Throws<Exception>(() => new Move(mockMovable.Object).Execute());
        //}

        //[Fact]
        //public void RotationTest()
        //{
        //    //arrange
        //    Mock<IRotable> mock = new Mock<IRotable>();

        //    mock.SetupGet(x => x.Direction).Returns(5).Verifiable();
        //    mock.SetupGet(x => x.DirectionsNumber).Returns(8).Verifiable();

        //    //act
        //    new Rotate(mock.Object).Execute(4);

        //    //assert
        //    mock.VerifySet(x => x.Direction = 1);
        //}

        //[Fact]
        //public void RotationDirectionErrorTest()
        //{
        //    //arrange
        //    Mock<IRotable> mock = new Mock<IRotable>();

        //    mock.SetupGet(x => x.Direction).Throws<Exception>().Verifiable();
        //    mock.SetupGet(x => x.DirectionsNumber).Returns(8).Verifiable();

        //    //act
        //    //assert
        //    Assert.Throws<Exception>(() => new Rotate(mock.Object).Execute(4));
        //}

        //[Fact]
        //public void RotationDirectionsNumberErrorTest()
        //{
        //    //arrange
        //    Mock<IRotable> mock = new Mock<IRotable>();

        //    mock.SetupGet(x => x.Direction).Returns(5).Verifiable();
        //    mock.SetupGet(x => x.DirectionsNumber).Throws<Exception>().Verifiable();

        //    //act
        //    //assert
        //    Assert.Throws<Exception>(() => new Rotate(mock.Object).Execute(4));
        //}

        //[Fact]
        //public void RotationDirectionSetErrorTest()
        //{
        //    //arrange
        //    Mock<IRotable> mock = new Mock<IRotable>();

        //    mock.SetupGet(x => x.Direction).Returns(5).Verifiable();
        //    mock.SetupGet(x => x.DirectionsNumber).Returns(8).Verifiable();
        //    mock.SetupSet(x => x.Direction = It.IsAny<int>()).Throws<Exception>().Verifiable();
        //    //act
        //    //assert
        //    Assert.Throws<Exception>(() => new Rotate(mock.Object).Execute(4));
        //}

        #endregion

        #region hw-3
        [Fact]
        public void TestLog()
        {
            //arrange
            var mockMove = new Mock<ICommand>();
            mockMove.Setup(x => x.Execute()).Throws(new Exception());
            var queueCalls = new Dictionary<int, string>();
            var count = 1;
            var queue = new Queue<ICommand>();
            ExceptionHandler.Setup(typeof(Move).ToString(), (cmd, ex) => queue.Enqueue(new Log(cmd, ex)));
            queue.Enqueue(new Move());
            //act
            while (queue.Count > 0)
            {
                var command = queue.Dequeue();
                queueCalls.Add(count++, command.GetType().ToString());
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    ExceptionHandler.Handle(command, ex);
                }
            }
            //assert
            Assert.Equal(queueCalls[1], typeof(Move).ToString());
            Assert.Equal(queueCalls[2], typeof(Log).ToString());
        }
        [Fact]
        public void TestRepeat()
        {
            //arrange
            var mockMove = new Mock<ICommand>();
            mockMove.Setup(x => x.Execute()).Throws(new Exception());
            var queueCalls = new Dictionary<int, string>();
            var count = 1;
            var queue = new Queue<ICommand>();
            ExceptionHandler.Setup(typeof(Move).ToString(), (cmd, ex) => queue.Enqueue(new RepeatCommand(cmd)));
            ExceptionHandler.Setup(typeof(RepeatCommand).ToString(), (cmd, ex) => queue.Enqueue(new Log(cmd, ex)));

            queue.Enqueue(new Move());
            //act
            while (queue.Count > 0)
            {
                var command = queue.Dequeue();
                queueCalls.Add(count++, command.GetType().ToString());
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    ExceptionHandler.Handle(command, ex);
                }
            }
            //assert
            Assert.Equal(queueCalls[1], typeof(Move).ToString());
            Assert.Equal(queueCalls[2], typeof(RepeatCommand).ToString());
            Assert.Equal(queueCalls[3], typeof(Log).ToString());
        }

        [Fact]
        public void TestRepeatTwice()
        {
            //arrange
            var mockMove = new Mock<ICommand>();
            mockMove.Setup(x => x.Execute()).Throws(new Exception());
            var queueCalls = new Dictionary<int, string>();
            var count = 1;
            var queue = new Queue<ICommand>();
            ExceptionHandler.Setup(typeof(Move).ToString(), (cmd, ex) => queue.Enqueue(new RepeatTwiceCommand(cmd)));
            ExceptionHandler.Setup(typeof(RepeatTwiceCommand).ToString(), (cmd, ex) => queue.Enqueue(new RepeatCommand(cmd)));
            ExceptionHandler.Setup(typeof(RepeatCommand).ToString(), (cmd, ex) => queue.Enqueue(new Log(cmd, ex)));
            queue.Enqueue(new Move());
            //act
            while (queue.Count > 0)
            {
                var command = queue.Dequeue();
                queueCalls.Add(count++, command.GetType().ToString());
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    ExceptionHandler.Handle(command, ex);
                }
            }
            //assert
            Assert.Equal(queueCalls[1], typeof(Move).ToString());
            Assert.Equal(queueCalls[2], typeof(RepeatTwiceCommand).ToString());
            Assert.Equal(queueCalls[3], typeof(RepeatCommand).ToString());
            Assert.Equal(queueCalls[4], typeof(Log).ToString());
        }



        #endregion
    }

}