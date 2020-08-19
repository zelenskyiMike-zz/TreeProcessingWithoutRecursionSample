using System;
using System.Collections.Generic;

namespace TreeProcessingWithoutRecursionSample
{
    public class Node
    {
        public List<Node> Childs;
        public string NodeInfo;

        public void AddChild(Node child)
        {
            Childs.Add(child);
        }
    }
}
