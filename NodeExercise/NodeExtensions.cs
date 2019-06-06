namespace NodeExercise
{
    public static class NodeExtensions
    {
        public static Node GetReversedRecursive(this Node current, Node previous = default)
        {
            if (current.Next == default)
            {
                current.Next = previous;
                return current;
            }

            var next = current.Next;
            current.Next = previous;

            return GetReversedRecursive(next, current);
        }

        public static Node GetReversedIterative(this Node current, Node previous = default)
        {
            while (current.Next != default)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            current.Next = previous;
            return current;
        }
    }
}
