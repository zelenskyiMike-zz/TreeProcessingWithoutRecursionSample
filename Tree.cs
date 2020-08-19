using System;
using System.Collections.Generic;

namespace TreeProcessingWithoutRecursionSample
{
    public class Tree
    {
        private Node _node;
       
        public Tree(Node node)
        {
            this._node = node;
        }

        public Node SearchElement(string information)
        {
            if (_node.NodeInfo.Equals(information))
            {
                return _node;
            }

            var childs = this._node.Childs;
            childs.Reverse();

            var stack = new Stack<Node>(childs);

            while (stack.Count > 0)
            {
                Node element = stack.Pop();

                if (CheckNode(element, information, stack))
                {
                    return element;
                }

                var currentNodeChilds = element.Childs;
                currentNodeChilds.Reverse();

                foreach (var child in currentNodeChilds)
                {
                    stack.Push(child);
                }
            }
            throw new KeyNotFoundException();
        }

        public bool CheckNode(Node child, string information, Stack<Node> stack)
        {
            if (!child.NodeInfo.Equals(information))
            {
                return false;
            }
            return true;
        }
    }
}
