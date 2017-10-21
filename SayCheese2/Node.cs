using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SayCheese2
{
    public class Node : INode
    {
        private readonly BoardSnapshot snapshot;
        private readonly INode parentNode;
        private IList<INode> children = new List<INode>();

        public override bool Equals(object obj)
        {
            return snapshot.Equals(obj);
        }

        public override int GetHashCode()
        {
            return snapshot.GetHashCode();
        }

        public Node(BoardSnapshot snapshot, Node parent = null)
        {
            this.snapshot = snapshot;
            this.parentNode = parent;
        }

        public BoardSnapshot GetSnapshot()
        {
            return this.snapshot;
        }

        public INode GetParent()
        {
            return this.parentNode;
        }

        public IList<INode> GetChildren()
        {
            return this.children;
        }

        public void AddChild(INode child)
        {
            this.children.Add(child);
        }
    }

}
