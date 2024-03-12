#nullable enable
namespace BinaryTreeNamespace;

using Xunit;

public class BinaryTreeTests
{
	[Theory]
	[InlineData(new[] { 5, 3, 7, 1, 4, 6, 8 }, 4, true)]
	[InlineData(new[] { 10, 5, 15, 3, 7, 12, 20 }, 9, false)]
	[InlineData(new[] { 1, 2, 3, 4, 5 }, 3, true)]
	public void FindValue_ShouldReturnCorrectResult(int[] array, int valueToFind, bool expectedResult)
	{
		// Arrange
		var binaryTree = new BinaryTree(array);

		// Act
		var actualResult = binaryTree.FindValue(valueToFind);

		// Assert
		Assert.Equal(expectedResult, actualResult);
	}

	[Fact]
	public void CreateBinaryTree_ShouldCreateCorrectTree()
	{
		// Arrange
		int[] array = [5, 3, 7, 1, 4, 6, 8];
		var expectedTree = new Node(5)
		{
			Left = new Node(3)
			{
				Left = new Node(1),
				Right = new Node(4)
			},
			Right = new Node(7)
			{
				Left = new Node(6),
				Right = new Node(8)
			}
		};

		// Act
		var binaryTree = new BinaryTree(array);

		// Assert
		Assert.Equal(ExpectedTreeToString(expectedTree), ActualTreeToString(binaryTree.root));
	}

	private string ExpectedTreeToString(Node? root)
	{
		if (root == null)
			return "null";

		return $"{root.Data} ({ExpectedTreeToString(root.Left)} {ExpectedTreeToString(root.Right)})";
	}

	private string ActualTreeToString(Node? root)
	{
		if (root == null)
			return "null";

		return $"{root.Data} ({ActualTreeToString(root.Left)} {ActualTreeToString(root.Right)})";
	}
}