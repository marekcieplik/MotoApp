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
    }
}