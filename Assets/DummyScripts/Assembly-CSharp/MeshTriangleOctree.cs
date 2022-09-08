/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MeshTriangleOctree // TypeDefIndex: 14703
{
	// Fields
	private const int DEFAULT_LEAF_CAPACITY = 1536; // Metadata: 0x00AEBDD8
	private const int DEFAULT_MAX_DEPTH = 16; // Metadata: 0x00AEBDDC
	private const float DEFAULT_MIN_VOLUME = 5f; // Metadata: 0x00AEBDE0
	private const float DEFAULT_MIN_DIMENSION = 1f; // Metadata: 0x00AEBDE4
	private Node _rootNode; // 0x10

	// Properties
	public static bool debugDrawBounds { get; set; } // 0x00000001839BB060-0x00000001839BB0C0 0x00000001839BB0C0-0x00000001839BB120

	// Nested types
	private abstract class Node // TypeDefIndex: 14704
	{
		// Properties
		public Bounds bounds { /* [XID] */ /* 0x0000000189935A00-0x0000000189935A40 */ get; private set; } // 0x00000001839A5830-0x00000001839A58A0 0x00000001839A5900-0x00000001839A5970
		public virtual int depth { /* [XID] */ /* 0x00000001899479F0-0x0000000189947A30 */ get; /* [XID] */ /* 0x0000000189952350-0x0000000189952390 */ set; } // 0x00000001839A57D0-0x00000001839A5830 0x00000001839A58A0-0x00000001839A5900
		public List<Vector3> vertices { /* [XID] */ /* 0x000000018995C820-0x000000018995C860 */ get; private set; } // 0x00000001839A59D0-0x00000001839A5A30 0x00000001839A5970-0x00000001839A59D0
		protected Bounds boundsAgainsAvatar { /* [XID] */ /* 0x000000018996E520-0x000000018996E560 */ get; private set; } // 0x00000001839A5A30-0x00000001839A5AA0 0x00000001839A5AA0-0x00000001839A5B10
		protected float _volume { /* [XID] */ /* 0x0000000189980720-0x0000000189980740 */ get; } // 0x00000001839A5670-0x00000001839A57D0 

		// Constructors
		protected Node() {} // Dummy constructor
		public Node(Bounds bounds) {} // 0x00000001839A5B10-0x00000001839A5D50

		// Methods
		public abstract Node AddTriangle(Vector3 v1, Vector3 v2, Vector3 v3);
		public abstract void CollectTriangles(List<Vector3> vertices, Bounds enclosingCube);
	}

	private class OctantBranchNode : Node // TypeDefIndex: 14705
	{
		// Fields
		private float _xSplitter; // 0x50
		private float _ySplitter; // 0x54
		private float _zSplitter; // 0x58
		private Node _nXpYpZ; // 0x60
		private Node _pXpYpZ; // 0x68
		private Node _nXpYnZ; // 0x70
		private Node _pXpYnZ; // 0x78
		private Node _nXnYpZ; // 0x80
		private Node _pXnYpZ; // 0x88
		private Node _nXnYnZ; // 0x90
		private Node _pXnYnZ; // 0x98

		// Properties
		public override int depth { /* [XID] */ /* 0x00000001899880D0-0x00000001899880F0 */ get => default; /* [XID] */ /* 0x000000018998FB20-0x000000018998FB40 */ set {} } // 0x00000001839A5EC0-0x00000001839A5FA0 0x00000001839A60F0-0x00000001839A6310

		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		private enum OctantSplits // TypeDefIndex: 14706
		{
			None = 0,
			Left = 1,
			Right = 2,
			LeftAndRight = 3,
			Bottom = 4,
			Top = 8,
			BottomAndTop = 12,
			Near = 32,
			BottomLeftNear = 37,
			BottomRightNear = 38,
			TopLeftNear = 41,
			TopRightNear = 42,
			Rear = 64,
			BottomLeftRear = 69,
			BottomRightRear = 70,
			TopLeftRear = 73,
			TopRightRear = 74,
			NearAndRear = 96
		}

		// Constructors
		public OctantBranchNode() {} // Dummy constructor
		public OctantBranchNode(LeafNode leaf) {} // 0x00000001839A6DA0-0x00000001839A73A0

		// Methods
		// [XID] // 0x00000001899974F0-0x0000000189997510
		public override Node AddTriangle(Vector3 v1, Vector3 v2, Vector3 v3) => default; // 0x00000001839A65A0-0x00000001839A6950
		// [XID] // 0x000000018999F090-0x000000018999F0B0
		public override void CollectTriangles(List<Vector3> vertices, Bounds enclosingCube) {} // 0x00000001839A6950-0x00000001839A6D00
		// [XID] // 0x00000001899A69B0-0x00000001899A69D0
		private OctantSplits MarkVector(float x, float y, float z) => default; // 0x00000001839A6470-0x00000001839A65A0
		// [XID] // 0x00000001899AE280-0x00000001899AE2A0
		private bool CheckMark(OctantSplits value, OctantSplits against) => default; // 0x00000001839A5DF0-0x00000001839A5EC0
		// [XID] // 0x00000001899B5940-0x00000001899B5960
		private Node LocateChild(OctantSplits marker) => default; // 0x00000001839A5FA0-0x00000001839A60F0
		// [XID] // 0x00000001899BD1E0-0x00000001899BD200
		private void ReplaceChild(OctantSplits marker, Node child) {} // 0x00000001839A6310-0x00000001839A6470
	}

	private abstract class QuatantBranchNode : Node // TypeDefIndex: 14707
	{
		// Properties
		public override int depth { /* [XID] */ /* 0x0000000189A0A8F0-0x0000000189A0A910 */ get; /* [XID] */ /* 0x0000000189A12140-0x0000000189A12160 */ set; } // 0x00000001839A2C60-0x00000001839A2D40 0x00000001839A3150-0x00000001839A33C0
		protected float _firstDimensionSplitter { /* [XID] */ /* 0x0000000189A19550-0x0000000189A19590 */ get; set; } // 0x00000001839A2B20-0x00000001839A2B90 0x00000001839A4130-0x00000001839A41A0
		protected float _secondDimensionSplitter { /* [XID] */ /* 0x0000000189A2AF60-0x0000000189A2AFA0 */ get; set; } // 0x00000001839A3560-0x00000001839A35D0 0x00000001839A2D40-0x00000001839A2DB0
		protected Node _nn { /* [XID] */ /* 0x0000000189A3CE10-0x0000000189A3CE50 */ get; /* [XID] */ /* 0x0000000189A47640-0x0000000189A47680 */ set; } // 0x00000001839A2EC0-0x00000001839A2F20 0x00000001839A3500-0x00000001839A3560
		protected Node _np { /* [XID] */ /* 0x0000000189A51DA0-0x0000000189A51DE0 */ get; /* [XID] */ /* 0x0000000189A5C700-0x0000000189A5C740 */ set; } // 0x00000001839A3BD0-0x00000001839A3C30 0x00000001839A40D0-0x00000001839A4130
		protected Node _pn { /* [XID] */ /* 0x0000000189A67110-0x0000000189A67150 */ get; /* [XID] */ /* 0x0000000189A71690-0x0000000189A716D0 */ set; } // 0x00000001839A3FD0-0x00000001839A4030 0x00000001839A2A60-0x00000001839A2AC0
		protected Node _pp { /* [XID] */ /* 0x0000000189A7C1A0-0x0000000189A7C1E0 */ get; /* [XID] */ /* 0x0000000189A86880-0x0000000189A868C0 */ set; } // 0x00000001839A2A00-0x00000001839A2A60 0x00000001839A2AC0-0x00000001839A2B20

		// Nested types
		private enum QuatantSplitter // TypeDefIndex: 14708
		{
			None = 0,
			Left = 1,
			Right = 2,
			LeftAndRight = 3,
			Bottom = 4,
			BottomLeft = 5,
			BottomRight = 6,
			Top = 8,
			TopLeft = 9,
			TopRight = 10,
			BottomAndTop = 12
		}

		// Constructors
		protected QuatantBranchNode() {} // Dummy constructor
		public QuatantBranchNode(Bounds bounds) {} // 0x00000001839A41A0-0x00000001839A4230

		// Methods
		// [XID] // 0x0000000189A91280-0x0000000189A912A0
		public override Node AddTriangle(Vector3 v1, Vector3 v2, Vector3 v3) => default; // 0x00000001839A3750-0x00000001839A3BD0
		// [XID] // 0x0000000189A98E10-0x0000000189A98E30
		public override void CollectTriangles(List<Vector3> vertices, Bounds enclosingCube) {} // 0x00000001839A3C30-0x00000001839A3FD0
		protected abstract float FirstDimensionValue(Vector3 v);
		protected abstract float SecondDimensionValue(Vector3 v);
		// [XID] // 0x0000000189A9FFA0-0x0000000189A9FFC0
		protected void TakeOver(LeafNode leaf) {} // 0x00000001839A2F20-0x00000001839A3150
		// [XID] // 0x0000000189AA7790-0x0000000189AA77B0
		private QuatantSplitter MarkVector(float a, float b) => default; // 0x00000001839A35D0-0x00000001839A3750
		// [XID] // 0x0000000189AAEF90-0x0000000189AAEFB0
		private bool CheckMark(QuatantSplitter value, QuatantSplitter against) => default; // 0x00000001839A2B90-0x00000001839A2C60
		// [XID] // 0x0000000189AB6870-0x0000000189AB6890
		private Node LocateChild(QuatantSplitter marker) => default; // 0x00000001839A2DB0-0x00000001839A2EC0
		// [XID] // 0x0000000189ABE360-0x0000000189ABE380
		private void ReplaceChild(QuatantSplitter marker, Node child) {} // 0x00000001839A33C0-0x00000001839A3500
	}

	private class XZQuatantBranchNode : QuatantBranchNode // TypeDefIndex: 14709
	{
		// Constructors
		public XZQuatantBranchNode() {} // Dummy constructor
		public XZQuatantBranchNode(LeafNode leaf) {} // 0x00000001839A5160-0x00000001839A5670

		// Methods
		// [XID] // 0x0000000189AC5EB0-0x0000000189AC5ED0
		protected override float FirstDimensionValue(Vector3 v) => default; // 0x00000001839A4FC0-0x00000001839A5090
		// [XID] // 0x0000000189ACD380-0x0000000189ACD3A0
		protected override float SecondDimensionValue(Vector3 v) => default; // 0x00000001839A5090-0x00000001839A5160
	}

	private class XYQuatantBranchNode : QuatantBranchNode // TypeDefIndex: 14710
	{
		// Constructors
		public XYQuatantBranchNode() {} // Dummy constructor
		public XYQuatantBranchNode(LeafNode leaf) {} // 0x00000001839A1360-0x00000001839A1870

		// Methods
		// [XID] // 0x0000000189AD51A0-0x0000000189AD51C0
		protected override float FirstDimensionValue(Vector3 v) => default; // 0x00000001839A11C0-0x00000001839A1290
		// [XID] // 0x0000000189ADCB50-0x0000000189ADCB70
		protected override float SecondDimensionValue(Vector3 v) => default; // 0x00000001839A1290-0x00000001839A1360
	}

	private class YZQuatantBranchNode : QuatantBranchNode // TypeDefIndex: 14711
	{
		// Constructors
		public YZQuatantBranchNode() {} // Dummy constructor
		public YZQuatantBranchNode(LeafNode leaf) {} // 0x00000001839A1A10-0x00000001839A1F20

		// Methods
		// [XID] // 0x0000000189AE43A0-0x0000000189AE43C0
		protected override float FirstDimensionValue(Vector3 v) => default; // 0x00000001839A1870-0x00000001839A1940
		// [XID] // 0x0000000189AEBB90-0x0000000189AEBBB0
		protected override float SecondDimensionValue(Vector3 v) => default; // 0x00000001839A1940-0x00000001839A1A10
	}

	private class LeafNode : Node // TypeDefIndex: 14712
	{
		// Fields
		private static VectorComponent[] _sortVectorComponents; // 0x00

		// Nested types
		private struct VectorComponent // TypeDefIndex: 14713
		{
			// Properties
			public int Marker { /* [XID] */ /* 0x0000000189B25C60-0x0000000189B25CA0 */ get; /* [XID] */ /* 0x0000000189B2FE90-0x0000000189B2FED0 */ set; } // 0x00000001839A2430-0x00000001839A2500 0x00000001839A2570-0x00000001839A2640
			public float Value { /* [XID] */ /* 0x0000000189B3A7A0-0x0000000189B3A7E0 */ get; /* [XID] */ /* 0x0000000189B45200-0x0000000189B45240 */ set; } // 0x00000001839A2500-0x00000001839A2570 0x00000001839A2640-0x00000001839A26B0
		}

		private class VectorComponentComparer : IComparer<VectorComponent> // TypeDefIndex: 14714
		{
			// Properties
			public static VectorComponentComparer Instance { /* [XID] */ /* 0x0000000189B5A0A0-0x0000000189B5A0E0 */ get; private set; } // 0x00000001839A2190-0x00000001839A2220 0x00000001839A2220-0x00000001839A22B0

			// Constructors
			static VectorComponentComparer() {} // 0x00000001839A22B0-0x00000001839A2370
			public VectorComponentComparer() {} // 0x00000001839A2370-0x00000001839A2430

			// Methods
			// [XID] // 0x0000000189B6BCC0-0x0000000189B6BCE0
			public int Compare(VectorComponent x, VectorComponent y) => default; // 0x00000001839A2010-0x00000001839A2190
		}

		// Constructors
		public LeafNode() {} // Dummy constructor
		static LeafNode() {} // 0x00000001839A4EB0-0x00000001839A4F30
		public LeafNode(Bounds bounds) {} // 0x00000001839A4F30-0x00000001839A4FC0

		// Methods
		// [XID] // 0x0000000189AF3580-0x0000000189AF35A0
		public static LeafNode New(float xMin, float yMin, float zMin, float xMax, float yMax, float zMax) => default; // 0x00000001839A4C90-0x00000001839A4EB0
		// [XID] // 0x0000000189AFAE00-0x0000000189AFAE20
		public override Node AddTriangle(Vector3 v1, Vector3 v2, Vector3 v3) => default; // 0x00000001839A4230-0x00000001839A49C0
		// [XID] // 0x0000000189B023C0-0x0000000189B023E0
		public override void CollectTriangles(List<Vector3> vertices, Bounds enclosingCube) {} // 0x00000001839A4AC0-0x00000001839A4C90
		// [XID] // 0x0000000189B09940-0x0000000189B09960
		private static void SortVectorComponents() {} // 0x00000001839A49C0-0x00000001839A4AC0
	}

	// Constructors
	public MeshTriangleOctree() {} // Dummy constructor
	private MeshTriangleOctree(Mesh mesh, Transform transform) {} // 0x00000001839BB230-0x00000001839BB6D0

	// Methods
	// [XID] // 0x00000001898FCB40-0x00000001898FCB60
	public static MeshTriangleOctree Build(MeshCollider collider) => default; // 0x00000001839BAF30-0x00000001839BB060
	// [XID] // 0x0000000189904540-0x0000000189904560
	public void CollectTriangles(List<Vector3> vertices, Bounds enclosingCube) {} // 0x00000001839BB120-0x00000001839BB230
}

