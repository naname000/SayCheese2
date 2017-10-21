namespace SayCheese2
{
    public class Resolver
    {
        public INode Tree
        {
            get;
            private set;
        }

        public Resolver(Question question)
        {
            this.Tree = new Node(question.Snapshot, null);
        }

        private void Resolve()
        {

        }
    }

}
