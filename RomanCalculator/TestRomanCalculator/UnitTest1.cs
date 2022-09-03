namespace TestRomanCalculator
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, new RomanCalculator.Calculate().getNumber("I"));
           // Assert.That(Is.EqualTo(new RomanCalculator.Calculate().getNumber("I"),1));           
        }
        public void Test2()
        {
            Assert.AreEqual(2, new RomanCalculator.Calculate().getNumber("II"));
        }

        public void Test3()
        {
            Assert.AreEqual(3, new RomanCalculator.Calculate().getNumber("III"));
        }

        // and so on, not writing the rest as I've seen the warning that I should consider
        // using the constraint model (warning NUnit2005)
    }
}