using DesignKata_CodeWars_Maximum_Time;
using NUnit.Framework;

namespace MaxTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That(MaxHourMinute.Max(new[] {1,5,3,9,7}), Is.EqualTo("19:59"));
    }
    [Test]
    public void Test2()
    {
        Assert.That(MaxHourMinute.Max(new[] {1,0,0,0,7}), Is.EqualTo("17:17"));
    }
  
    [Test]
    public void Test3()
    {
        Assert.That(MaxHourMinute.Max(new[] {0,0,0,0,0}), Is.EqualTo("00:00"));
    }
    [Test]
    public void Test4()
    {
        Assert.That(MaxHourMinute.Max(new[] {0,0,0,0,1}), Is.EqualTo("10:10"));
    }
    [Test]
    public void Test5()
    {
        Assert.That(MaxHourMinute.Max(new[]{0,1,1}), Is.EqualTo("11:11"));
    }
    
    [Test]
    public void Test6()
    {
        Assert.That(MaxHourMinute.Max(new[]{0,1,9,1,8,4,2}), Is.EqualTo("21:49"));
    }
    [Test]
    public void Test7()
    {
        Assert.That(MaxHourMinute.Max(new[]{1}), Is.EqualTo("-1"));
    }
    [Test]
    public void Test8()
    {
        Assert.That(MaxHourMinute.Max(new[]{5,5,5}), Is.EqualTo("-1"));
        
    }

    [Test]
    public void Test9()
    {
        Assert.That(
            MaxHourMinute.Max(new[]
            {
                6, 8, 2, 7, 6, 4, 0, 3, 4, 3, 5, 6, 6, 1, 1, 5, 6, 1, 0, 3, 5, 7, 6, 4, 0, 4, 6, 2, 5, 4, 3, 2, 2, 7, 5,
                7, 5, 2, 4, 2, 8, 2, 5, 8, 8, 8, 8, 5, 4, 0, 2, 2, 7, 1, 8, 1, 0, 5, 2, 8, 1, 7, 5, 4, 3, 7, 8, 3, 4, 7
            }), Is.EqualTo("23:58"));
    }
    [Test]
    public void Test10()
    {
        Assert.That(MaxHourMinute.Max(new[]{5,8,2}), Is.EqualTo("-1"));
    }
    [Test]
    public void Test11()
    {
        Assert.That(MaxHourMinute.Max(new[]{8,5,8}), Is.EqualTo("-1"));
    }

    [Test]
    public void RandomTest()
    {
        var Min = 0;
        var Max = 9;
        var counter = 0;
        while (counter < 100)
        {
            var rand = new Random();
            var randomArray = Enumerable.Repeat(0, rand.Next(0,15)).Select(_ => rand.Next(Min, Max)).ToArray();
            var expected = MyMax(randomArray);
            var actual = MaxHourMinute.Max(randomArray);
            Assert.That(actual, Is.EqualTo(expected));
            counter++;
        }
        static string MyMax(int[] inputArray)
        {
            if (inputArray.Length>=2 & inputArray.All(v => v == 0)) return "00:00";
            var hour=0;
            var minute=0;
            string temp;
            for (var i = 0; i < inputArray.Length; i++)
            {
                for (var j = 0; j < inputArray.Length; j++)
                {
                    if(i==j) continue;
                    temp = inputArray[i] + inputArray[j].ToString();
                    if (24 > Convert.ToInt32(temp) & Convert.ToInt32(temp) > hour) 
                        hour = Convert.ToInt32(temp);
                }
            }
            if(hour==0) return "-1";
            for (var i = 0; i < inputArray.Length; i++)
            {
                for (var j = 0; j < inputArray.Length; j++)
                {
                    if(i==j) continue;
                    temp = inputArray[i] + inputArray[j].ToString();
                    if (60 > Convert.ToInt32(temp) & Convert.ToInt32(temp) > minute) 
                        minute = Convert.ToInt32(temp);
                }
            }
            return minute==0 ? "-1" : $"{hour:D2}:{minute:D2}";
        }
    }
}