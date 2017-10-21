using System.Collections.Generic;

namespace SayCheese2
{
    public interface INode
    {
        BoardSnapshot GetSnapshot();
        INode GetParent();
        IList<INode> GetChildren();
        void AddChild(INode node);
    }

}
