namespace BinaryTreeNamespace;

using System;

class Node
{
	public int Data { get; set; }
	public Node? Left { get; set; }
	public Node? Right { get; set; }

	public Node(int data)
	{
		Data = data;
		Left = null;
		Right = null;
	}
}

class BinaryTree
{
	// private коли prod
	public Node? root;

	public BinaryTree(int[] array)
	{
		root = null;
		CreateBinaryTree(array);
	}

	private void CreateBinaryTree(int[] array)
	{
		foreach (int value in array)
		{
			InsertNode(value);
		}
	}

	private void InsertNode(int value)
	{
		root = InsertNodeRecursive(root, value);
	}

	private static Node InsertNodeRecursive(Node? currentNode, int value)
	{
		if (currentNode is null)
		{
			return new Node(value);
		}

		if (value < currentNode.Data)
		{
			currentNode.Left = InsertNodeRecursive(currentNode.Left, value);
		}
		else if (value > currentNode.Data)
		{
			currentNode.Right = InsertNodeRecursive(currentNode.Right, value);
		}

		return currentNode;
	}

	public void InOrderTraversal()
	{
		InOrderTraversalRecursive(root);
	}

	private static void InOrderTraversalRecursive(Node? currentNode)
	{
		if (currentNode is not null)
		{
			InOrderTraversalRecursive(currentNode.Left);
			Console.Write(currentNode.Data + " ");
			InOrderTraversalRecursive(currentNode.Right);
		}
	}

	public bool FindValue(int value)
	{
		return FindValueRecursive(root, value);
	}

	private static bool FindValueRecursive(Node? currentNode, int value)
	{
		if (currentNode is null)
		{
			return false;
		}

		if (currentNode.Data == value)
		{
			return true;
		}

		return FindValueRecursive(currentNode.Left, value) || FindValueRecursive(currentNode.Right, value);
	}
}