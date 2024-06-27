namespace MotoApp.Tests
{
    public class Tests
    {
        [Test]
        public void When_PushOneItem_Should_CountIsOne()
        {
            // arrange
            var testos = new BasicStack();
            // act
            testos.Push(4);
            // asert
            Assert.AreEqual(1, testos.Count);
            Assert.That(testos.Count, Is.EqualTo(1));
        }

        [Test]
        public void When_PushItems_Pop_CountSum()
        {
            var testos = new BasicStack();
            testos.Push(4.5);
            testos.Push(43);
            testos.Push(333.6);
            // act
            double sum = 0.0;
            while (testos.Count > 0)
            {
                sum += testos.Pop();
            }
            // assert
            Assert.That(sum, Is.EqualTo(381.1));

        }
    }
}