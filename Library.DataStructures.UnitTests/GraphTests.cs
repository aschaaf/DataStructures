using System.Diagnostics;
using Library.DataStructures.Graphs;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class GraphTests
    {
        [Theory]
        [InlineData(true, "Tom", "Mike")]
        [InlineData(false, "Tom", "Taylor Swift")]
        public void TestBFS(bool found, string source, string destination)
        {
            var graph = GenerateGraph();
            var result = graph.BreadthFirstSearch(source, destination);
            Assert.Equal(found, result);
        }

        [Theory]
        [InlineData(true, "Tom", "Mike")]
        [InlineData(false, "Tom", "Taylor Swift")]
        public void TestDFS(bool found, string source, string destination)
        {
            var graph = GenerateGraph();
            var result = graph.DepthFirstSearch(source, destination);
            Assert.Equal(found, result);
        }

        [Theory]
        [InlineData(30, "Seminole", "Tampa")]
        [InlineData(153, "Seminole", "Naples")]
        [InlineData(268, "Seminole", "Miami")]
        [InlineData(108, "Seminole", "Orlando")]
        [InlineData(223, "Seminole", "Jacksonville")]
        [InlineData(149, "Seminole", "Gainesville")]
        [InlineData(289, "Seminole", "Tallahassee")]
        public void TestDijkstra(int expected, string source, string destination)
        {
            var graph = GenerateWeightedGraph();
            var distance = graph.GetShortestPath(source, destination);
            Trace.WriteLine("test debug");
            Assert.Equal(expected, distance.Item1);
        }
        
        private Graph<string> GenerateWeightedGraph()
        {
            var graph = new Graph<string>();
            graph.AddNode("Seminole");
            graph.AddNode("Tampa");
            graph.AddNode("Naples");
            graph.AddNode("Miami");
            graph.AddNode("Orlando");
            graph.AddNode("Jacksonville");
            graph.AddNode("Gainesville");
            graph.AddNode("Tallahassee");
            graph.AddEdgeUndirected("Seminole", "Tampa", 30, "Seminole to Tampa");
            graph.AddEdgeUndirected("Seminole", "Naples", 153, "Seminole to Naples");
            graph.AddEdgeUndirected("Tampa", "Naples", 149, "Tampa to Naples");
            graph.AddEdgeUndirected("Tampa", "Orlando", 78, "Tampa to Orlando");
            graph.AddEdgeUndirected("Tampa", "Gainesville", 119, "Tampa to Gainesville");
            graph.AddEdgeUndirected("Naples", "Miami", 115, "Naples to Miami");
            graph.AddEdgeUndirected("Miami", "Orlando", 210, "Miami to Orlando");
            graph.AddEdgeUndirected("Orlando", "Jacksonville", 128, "Orlando to Jacksonville");
            graph.AddEdgeUndirected("Orlando", "Gainesville", 104, "Orlando to Gainesville");
            graph.AddEdgeUndirected("Gainesville", "Jacksonville", 74, "Gainesville to Jacksonville");
            graph.AddEdgeUndirected("Gainesville", "Tallahassee", 140, "Gainesville to Tallahassee");
            graph.AddEdgeUndirected("Jacksonville", "Tallahassee", 150, "Jacksonville to Tallahassee");

            return graph;
        }

        private Graph<string> GenerateGraph()
        {
            var graph = new Graph<string>();
            graph.AddNode("Andy");
            graph.AddNode("Danielle");
            graph.AddNode("Tom");
            graph.AddNode("Molly");
            graph.AddNode("Kim");
            graph.AddNode("Mike");
            graph.AddNode("Taylor Swift");
            graph.AddNode("Kanye West");
            graph.AddEdgeUndirected("Andy", "Molly");
            graph.AddEdgeUndirected("Andy", "Tom");
            graph.AddEdgeUndirected("Andy", "Danielle");
            graph.AddEdgeUndirected("Danielle", "Kim");
            graph.AddEdgeUndirected("Danielle", "Mike");
            graph.AddEdgeUndirected("Taylor Swift", "Kanye West");

            return graph;
        }
    }
}
