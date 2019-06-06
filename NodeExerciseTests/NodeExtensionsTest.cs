using NodeExercise;
using Xunit;

namespace NodeExerciseTests
{
    public class NodeExtensionsTest
    {
        [Fact]
        public void GetReversedRecursive_NotEmptyInput_ReturnsCorrectSequence()
        {
            var sut = new Node(2);

            var actual = sut.GetReversedRecursive();

            Assert.Equal(2, actual.Index);
            Assert.NotNull(actual.Next);

            Assert.Equal(1, actual.Next.Index);
            Assert.Null(actual.Next.Next);
        }

        [Fact]
        public void GetReversedIterative_NotEmptyInput_ReturnsCorrectSequence()
        {
            var sut = new Node(2);

            var actual = sut.GetReversedIterative();

            Assert.Equal(2, actual.Index);
            Assert.NotNull(actual.Next);

            Assert.Equal(1, actual.Next.Index);
            Assert.Null(actual.Next.Next);
        }
    }
}
