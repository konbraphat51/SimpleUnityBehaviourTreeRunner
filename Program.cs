using BehaviorTree;
using BehaviorTree.Nodes;

namespace SimpleUnityBehaviourTreeRunner;

class Program
{
    // Sample sensory data
    public struct SensorData
    {
        public int Value { get; set; }
    }

    // Sample action
    public struct ActionData
    {
        public string Action { get; set; }
    }

    // Sample agent
    public class Agent
    {
        public string Name { get; set; } = "TestAgent";
    }

    // Concrete action implementation
    public class TestAction : BehaviorTree.Nodes.Action<Agent, SensorData, ActionData>
    {
        public TestAction() : base("TestAction") { }

        protected override ActionData TakeAction(SensorData input)
        {
            return new ActionData { Action = $"Processed sensor value: {input.Value}" };
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("SimpleUnityBehaviourTreeRunner - .NET 10.0");
        Console.WriteLine("SimpleUnityBehaviourTree submodule loaded successfully!");
        
        // Create a simple behavior tree
        var agent = new Agent();
        var actionNode = new TestAction();
        
        var tree = new BehaviorTree<Agent, SensorData, ActionData>(
            "TestTree",
            actionNode,
            agent
        );

        Console.WriteLine($"Behavior tree '{tree.name}' created successfully");
        
        // Execute the tree
        var sensorData = new SensorData { Value = 42 };
        var result = tree.Tick(sensorData);
        
        Console.WriteLine($"Tree executed: {result.Action}");
        Console.WriteLine("Test completed successfully!");
    }
}
