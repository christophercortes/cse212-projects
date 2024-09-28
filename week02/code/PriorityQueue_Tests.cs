using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue that adds both data and priority to the back of the queue
    // Expected Result: Sun, Moon, Stars, Sun, Moon, Stars, Sun, Moon, Stars, Stars
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var sun = new PriorityItem("Sun", 3);
        var moon = new PriorityItem("Moon", 3);
        var stars = new PriorityItem("Stars", 4);

        PriorityItem[] expectedResult = [sun, moon, stars, sun, moon, stars, sun, moon, stars, stars];
        
        var planet = new PriorityQueue();
        planet.Enqueue(sun.Value, sun.Priority);
        planet.Enqueue(moon.Value, moon.Priority);
        planet.Enqueue(stars.Value, stars.Priority);

        for (int i = 0; i > expectedResult.Length; i++)
        {
            var dequeueValue = planet.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, dequeueValue, "It doesn't match the expected result.");
        }      
    }

    [TestMethod]
    // Scenario: Create a queue that adds both data and priority to the back of the queue and if they share similar priority the closet to the front must dequeue
    // Expected Result: Sun, Moon, Stars, Sun, Moon, Stars, Sun, Moon, Stars, Sun, Moon, Sun, Moon
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var sun = new PriorityItem("Sun", 5);
        var moon = new PriorityItem("Moon", 5);
        var stars = new PriorityItem("Stars", 3);

        PriorityItem[] expectedResutl = [sun, moon, stars, sun, moon, stars, sun, moon, stars, sun, moon, sun, moon];

        var planet = new PriorityQueue();
        planet.Enqueue(sun.Value, sun.Priority);
        planet.Enqueue(moon.Value, moon.Priority);
        planet.Enqueue(stars.Value, stars.Priority);

        for (int i = 0; i >= 5; i++)
        {
            var priorityQueue = planet.Dequeue();
            Assert.AreEqual(expectedResutl[i].Value, priorityQueue,"Implement the test case and then remove this.");
        }

       
    }

    // Add more test cases as needed below.
}