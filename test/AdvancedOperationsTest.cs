
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class AdvancedOperationsTest {
    private AdvancedOperations advOps;

    [SetUp]
    public void SetUp() {
        advOps = new AdvancedOperations();
    }

    [Test]
    public void TestFindMax() {
        int result = advOps.FindMax(new int[]{1, 2, 3, 4, 5});
        Assert.AreEqual(5, result);
    }

    [Test]
    public void TestReverseString() {
        string result = advOps.ReverseString("hello");
        Assert.AreEqual("olleh", result);
    }

    [Test]
    public void TestFormatDate() {
        DateTime date = new DateTime(2023, 1, 1);
        string result = advOps.FormatDate(date);
        Assert.AreEqual("2023-01-01", result);
    }

    [Test]
    public void TestFactorial() {
        int result = advOps.Factorial(5);
        Assert.AreEqual(120, result);
    }

    [Test]
    public void TestCalculateStatistics() {
        var result = advOps.CalculateStatistics(new int[]{1, 2, 3, 4, 5});
        Assert.AreEqual(15, result["sum"]);
        Assert.AreEqual(3.0, result["average"]);
        Assert.AreEqual(1, result["min"]);
        Assert.AreEqual(5, result["max"]);
    }

    [Test]
    public void TestCalculateStatisticsEmptyArray() {
        var result = advOps.CalculateStatistics(new int[]{});
        Assert.AreEqual(0, result["sum"]);
        Assert.AreEqual(double.NaN, result["average"]);
        Assert.IsNull(result["min"]);
        Assert.IsNull(result["max"]);
    }

    [Test]
    public void TestCalculateStatisticsSingleElement() {
        var result = advOps.CalculateStatistics(new int[]{42});
        Assert.AreEqual(42, result["sum"]);
        Assert.AreEqual(42.0, result["average"]);
        Assert.AreEqual(42, result["min"]);
        Assert.AreEqual(42, result["max"]);
    }

    [Test]
    public void TestCalculateStatisticsNegativeNumbers() {
        var result = advOps.CalculateStatistics(new int[]{-1, -2, -3, -4, -5});
        Assert.AreEqual(-15, result["sum"]);
        Assert.AreEqual(-3.0, result["average"]);
        Assert.AreEqual(-5, result["min"]);
        Assert.AreEqual(-1, result["max"]);
    }
}