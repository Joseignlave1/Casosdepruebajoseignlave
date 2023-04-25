
using TestDateFormat;
using NUnit.Framework;

namespace TestDateFormat;



public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        

        String actual = DateFormatter.Correct("12/21/22");
        String expected = "";

        Assert.That(actual, Is.EqualTo(expected));
        
    

    }
    [Test]
    public void Fechacorrecta()
    {
        string actual=DateFormatter.Correct("12-21-22");
        string expected="";
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]

    public void FechaIncorrecta()
    {
        string actual=DateFormatter.Correct("12-21-22");
        string expected="";
        Assert.That(actual, Is.EqualTo(expected));
    }
    
       
        
}