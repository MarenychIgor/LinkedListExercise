namespace NodeExercise
{
    public class Node
    {
        public int Index { get; }
        public Node Next { get; set; }

        public Node(int childCount)
        {
            Index = 1;
            Next = GetWithChildren(childCount);
        }

        private Node(int index, Node next)
          => (Next, Index) = (next, index);

        private Node GetWithChildren(int childCount)
        {
            var node = new Node(childCount, default);

            while (--childCount > 1)
            {
                var previous = new Node(childCount, node);
                node = previous;
            }

            return node;
        }
    }
}
