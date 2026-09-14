using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them
    // Expected Result: ["E", "D", "C", "B", "A"]
    // Defect(s) Found: The test case was not implemented yet.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
        priorityQueue.Enqueue("D", 4);
        priorityQueue.Enqueue("E", 5);
        List<string> expectedResult = ["E", "D", "C", "B", "A"];

        for (int i = 0; i < expectedResult.Count; i++)
        {
            if (priorityQueue.Count > 0)
            {
                var actualResult = priorityQueue.Dequeue();
                Assert.AreEqual(expectedResult[i], actualResult);
            }
        }
    }

    [TestMethod]
    // Scenario: Enqueue multiple items where two items have the same priority.
    // Expected Result: The item that was added first is dequeued first when priorities are equal.
    // Defect(s) Found: The test case was not implemented yet.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("D", 8);
        priorityQueue.Enqueue("E", 3);
        List<string> expectedResult = ["D", "E", "B", "C", "A"];

        for (int i = 0; i < expectedResult.Count; i++)
        {
            var actualResult = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], actualResult);
        }
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty priority queue.
    // Expected Result: InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}