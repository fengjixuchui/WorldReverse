/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AStarSearch<Node> // TypeDefIndex: 31372
	where Node : AStarNode
{
	// Fields
	private static int MAX_SEARCH_ITERATION;
	private AStarRequest _request;
	private List<Node> _openList;
	private List<Node> _closeList;
	private Dictionary<Node, Node> _cameFrom;

	// Nested types
	public class AStarRequest // TypeDefIndex: 31373
	{
		// Fields
		public Node start;
		public Node goal;
		public AStarStatus status;
		public List<Node> result;

		// Constructors
		public AStarRequest() {}
	}

	public abstract class EdgeValidator // TypeDefIndex: 31374
	{
		// Constructors
		protected EdgeValidator() {}

		// Methods
		public abstract bool Check(Node node1, Node node2);
	}

	// Constructors
	public AStarSearch() {}
	static AStarSearch() {}

	// Methods
	public AStarStatus Search(Node start, Node goal, EdgeValidator edgeCond, List<Node> resultPath) => default;
	private void InsertToOpen(Node node) {}
	private void SetResult(AStarStatus resultStatus, Node finishNode, List<Node> resultPath) {}
	private void CleanSearch() {}
}

