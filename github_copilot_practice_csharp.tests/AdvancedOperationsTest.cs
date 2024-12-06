
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
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void TestReverseString() {
        string result = advOps.ReverseString("hello");
        Assert.That(result, Is.EqualTo("olleh"));
    }

    [Test]
    public void TestFormatDate() {
        DateTime date = new DateTime(2023, 1, 1);
        string result = advOps.FormatDate(date);
        Assert.That(result, Is.EqualTo("2023-01-01"));
    }

    [Test]
    public void TestFactorial() {
        int result = advOps.Factorial(5);
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void TestCalculateStatistics() {
        var result = advOps.CalculateStatistics(new int[]{1, 2, 3, 4, 5});
        Assert.That(result["sum"], Is.EqualTo(15));
        Assert.That(result["average"], Is.EqualTo(3.0));
        Assert.That(result["min"], Is.EqualTo(1));
        Assert.That(result["max"], Is.EqualTo(5));
    }

    [Test]
    public void TestCalculateStatisticsEmptyArray() {
        var result = advOps.CalculateStatistics(new int[]{});
        Assert.That(result["sum"], Is.EqualTo(0));
        Assert.That(result["average"], Is.EqualTo(double.NaN));
        Assert.That(result["min"], Is.Null);
        Assert.That(result["max"], Is.Null);
    }

    [Test]
    public void TestCalculateStatisticsSingleElement() {
        var result = advOps.CalculateStatistics(new int[]{42});
        Assert.That(result["sum"], Is.EqualTo(42));
        Assert.That(result["average"], Is.EqualTo(42.0));
        Assert.That(result["min"], Is.EqualTo(42));
        Assert.That(result["max"], Is.EqualTo(42));
    }

    [Test]
    public void TestCalculateStatisticsNegativeNumbers() {
        var result = advOps.CalculateStatistics(new int[]{-1, -2, -3, -4, -5});
        Assert.That(result["sum"], Is.EqualTo(-15));
        Assert.That(result["average"], Is.EqualTo(-3.0));
        Assert.That(result["min"], Is.EqualTo(-5));
        Assert.That(result["max"], Is.EqualTo(-1));
    }
}