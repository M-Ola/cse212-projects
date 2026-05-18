using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add a single item with priority 5, then dequeue.
    // Expected Result: Dequeue returns the same value ("A").
    // Defect(s) Found: Original code returned the wrong item because it did not search
    // for the highest priority; it simply removed from the front.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
    pq.Enqueue("A", 5);

    var result = pq.Dequeue();

    Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Add items with priorities 1, 5, and 10.
    // Expected Result: Dequeue returns the value with highest priority ("High").
    // Defect(s) Found: Dequeue did not correctly identify the highest priority item.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
    pq.Enqueue("Low", 1);
    pq.Enqueue("Medium", 5);
    pq.Enqueue("High", 10);

    var result = pq.Dequeue();

    Assert.AreEqual("High", result);


    }

    // Add more test cases as needed below.
}