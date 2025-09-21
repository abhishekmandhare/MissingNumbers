using FakeItEasy;
using MissingNumberApp;
using MissingNumberApp.Infrastructure;

namespace MissingNumberApp.Tests
{
    public class MissingNumberAppTest
    {

        [TestCase(new int[] {3,0,1}, 2)]
        [TestCase(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void Test1(int[] testInput, int testOutput)
        {
            // Arrange
            var fakeInput = A.Fake<IInputProvider>();
            var fakeOutput = A.Fake<IOutputProvider>();

            A.CallTo(() => fakeInput.GetInput()).Returns(testInput);
            var finder = new MissingNumberFinder(fakeInput, fakeOutput);
            finder.FindMissingNumbers();
            A.CallTo(() => fakeOutput.ShowResult(testOutput)).MustHaveHappenedOnceExactly();
        }
    }
}