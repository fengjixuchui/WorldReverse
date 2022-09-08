/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class SECTR_Graph // TypeDefIndex: 31943
{
	// Nested types
	public class Node : IComparable<Node> // TypeDefIndex: 31944
	{
		// Fields
		public float CostPlusEstimate; // 0x10
		public float Cost; // 0x14
		public int Depth; // 0x18
		public bool ForwardTraversal; // 0x1C
		public Node Parent; // 0x20

		// Constructors
		public Node() {} // 0x0000000182A7A460-0x0000000182A7A4D0

		// Methods
		// [XID] // 0x00000001897440D0-0x00000001897440F0
		public int CompareTo(Node other) => default; // 0x0000000182A7A2A0-0x0000000182A7A380
		// [XID] // 0x000000018974BDD0-0x000000018974BDF0
		public static void ReconstructPath(List<Node> path, Node currentNode) {} // 0x0000000182A7A380-0x0000000182A7A460
	}

	// Methods
	// [XID] // 0x000000018973CB30-0x000000018973CB50
	public static string GetGraphAsDot(string graphName) => default; // 0x0000000182A6EE00-0x0000000182A6F140
}

