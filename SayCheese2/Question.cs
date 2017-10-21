namespace SayCheese2
{
    public class Question
    {
        public BoardSnapshot Snapshot { get; private set; }
        public int MaxLength { get; private set; }

        public Question(BoardSnapshot snapshot, int maxLength)
        {
            this.Snapshot = snapshot;
            this.MaxLength = maxLength;
        }


    }
}
