/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public class Polygon3 // TypeDefIndex: 8159
	{
		// Fields
		private Vector3[] _vertices; // 0x10
		private Edge3[] _edges; // 0x18
		private Plane3 _plane; // 0x20
	
		// Properties
		public Vector3[] Vertices { /* [XID] */ /* 0x000000018986DC00-0x000000018986DC20 */ get => default; } // 0x0000000188D3A9C0-0x0000000188D3AA60 
		public Edge3[] Edges { /* [XID] */ /* 0x0000000189A44B00-0x0000000189A44B20 */ get => default; } // 0x0000000188D3A680-0x0000000188D3A720 
		public int VertexCount { /* [XID] */ /* 0x0000000189A4C220-0x0000000189A4C240 */ get => default; } // 0x0000000188D3A910-0x0000000188D3A9C0 
		public Vector3 this[int vertexIndex] { /* [XID] */ /* 0x0000000189A53A10-0x0000000189A53A30 */ get => default; /* [XID] */ /* 0x00000001898C0B70-0x00000001898C0B90 */ set {} } // 0x0000000188D3A720-0x0000000188D3A840 0x0000000188D3AA60-0x0000000188D3AB70
		public Plane3 Plane { /* [XID] */ /* 0x0000000189A62940-0x0000000189A62960 */ get => default; /* [XID] */ /* 0x0000000189A6A6C0-0x0000000189A6A6E0 */ set {} } // 0x0000000188D3A840-0x0000000188D3A910 0x0000000188D3AB70-0x0000000188D3AC30
	
		// Constructors
		private Polygon3() {} // 0x0000000188D3A460-0x0000000188D3A4C0
		public Polygon3(Vector3[] vertices, Plane3 plane) {} // 0x0000000188D3A4C0-0x0000000188D3A5C0
		public Polygon3(int vertexCount, Plane3 plane) {} // 0x0000000188D3A5C0-0x0000000188D3A680
	
		// Methods
		// [XID] // 0x0000000189A71B50-0x0000000189A71B70
		public void SetVertexProjected(int vertexIndex, Vector3 vertex) {} // 0x0000000188D39610-0x0000000188D39830
		// [XID] // 0x0000000189A79570-0x0000000189A79590
		public void ProjectVertices() {} // 0x0000000188D391E0-0x0000000188D39440
		// [XID] // 0x0000000189A80D70-0x0000000189A80D90
		public Edge3 GetEdge(int edgeIndex) => default; // 0x0000000188D38E60-0x0000000188D38FD0
		// [XID] // 0x0000000189A88660-0x0000000189A88680
		public void UpdateEdges() {} // 0x0000000188D3A0B0-0x0000000188D3A460
		// [XID] // 0x0000000189955540-0x0000000189955560
		public void UpdateEdge(int edgeIndex) {} // 0x0000000188D39D70-0x0000000188D3A0B0
		// [XID] // 0x000000018995CFC0-0x000000018995CFE0
		public Vector3 CalcCenter() => default; // 0x0000000188D38B40-0x0000000188D38D60
		// [XID] // 0x0000000189988AC0-0x0000000189988AE0
		public float CalcPerimeter() => default; // 0x0000000188D38D60-0x0000000188D38E60
		// [XID] // 0x0000000189AA6580-0x0000000189AA65A0
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x00ADF674 */) => default; // 0x0000000188D38FD0-0x0000000188D391E0
		// [XID] // 0x0000000189AADB50-0x0000000189AADB70
		public void ReverseVertices() {} // 0x0000000188D39440-0x0000000188D39610
		// [XID] // 0x0000000189AFF960-0x0000000189AFF980
		public Segment3[] ToSegmentArray() => default; // 0x0000000188D39830-0x0000000188D39A50
		// [XID] // 0x0000000189ABCF10-0x0000000189ABCF30
		public override string ToString() => default; // 0x0000000188D39A50-0x0000000188D39D00
	}
}
