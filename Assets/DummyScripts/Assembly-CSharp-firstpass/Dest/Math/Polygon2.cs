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
	public class Polygon2 // TypeDefIndex: 8148
	{
		// Fields
		private Vector2[] _vertices; // 0x10
		private Edge2[] _edges; // 0x18
	
		// Properties
		public Vector2[] Vertices { /* [XID] */ /* 0x000000018990A550-0x000000018990A570 */ get => default; } // 0x0000000188D389B0-0x0000000188D38A50 
		public Edge2[] Edges { /* [XID] */ /* 0x0000000189A123A0-0x0000000189A123C0 */ get => default; } // 0x0000000188D38770-0x0000000188D38810 
		public int VertexCount { /* [XID] */ /* 0x0000000189AD3890-0x0000000189AD38B0 */ get => default; } // 0x0000000188D38900-0x0000000188D389B0 
		public Vector2 this[int vertexIndex] { /* [XID] */ /* 0x000000018992B8C0-0x000000018992B8E0 */ get => default; /* [XID] */ /* 0x0000000189911EF0-0x0000000189911F10 */ set {} } // 0x0000000188D38810-0x0000000188D38900 0x0000000188D38A50-0x0000000188D38B40
	
		// Constructors
		private Polygon2() {} // 0x0000000188D38650-0x0000000188D386B0
		public Polygon2(Vector2[] vertices) {} // 0x0000000188D38560-0x0000000188D38650
		public Polygon2(int vertexCount) {} // 0x0000000188D386B0-0x0000000188D38770
	
		// Methods
		// [XID] // 0x00000001898635A0-0x00000001898635C0
		public static Polygon2 CreateProjected(Polygon3 polygon, ProjectionPlanes projectionPlane) => default; // 0x0000000188D36820-0x0000000188D36B60
		// [XID] // 0x0000000189919A00-0x0000000189919A20
		public Edge2 GetEdge(int edgeIndex) => default; // 0x0000000188D36B60-0x0000000188D36CB0
		// [XID] // 0x0000000189AF9A50-0x0000000189AF9A70
		public void UpdateEdges() {} // 0x0000000188D38240-0x0000000188D38560
		// [XID] // 0x0000000189B00E00-0x0000000189B00E20
		public void UpdateEdge(int edgeIndex) {} // 0x0000000188D37F70-0x0000000188D38240
		// [XID] // 0x0000000189928930-0x0000000189928950
		public Vector2 CalcCenter() => default; // 0x0000000188D35310-0x0000000188D354C0
		// [XID] // 0x000000018992FDB0-0x000000018992FDD0
		public float CalcPerimeter() => default; // 0x0000000188D354C0-0x0000000188D355C0
		// [XID] // 0x0000000189982670-0x0000000189982690
		public float CalcArea() => default; // 0x0000000188D34F50-0x0000000188D35310
		// [IDTag] // 0x0000000189B1E700-0x0000000189B1E740
		// [XID] // 0x0000000189B1E700-0x0000000189B1E740
		public bool IsConvex(out Orientations orientation, float threshold = 1E-05f /* Metadata: 0x00ADF629 */) {
			orientation = default;
			return default;
		} // 0x0000000188D36F40-0x0000000188D371D0
		// [IDTag] // 0x0000000189B28D90-0x0000000189B28DD0
		// [XID] // 0x0000000189B28D90-0x0000000189B28DD0
		public bool IsConvex(float threshold = 1E-05f /* Metadata: 0x00ADF62D */) => default; // 0x0000000188D36E70-0x0000000188D36F40
		// [XID] // 0x0000000189B33180-0x0000000189B331A0
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x00ADF631 */) => default; // 0x0000000188D36CB0-0x0000000188D36E70
		// [XID] // 0x00000001899551A0-0x00000001899551C0
		public void ReverseVertices() {} // 0x0000000188D371D0-0x0000000188D37360
		// [IDTag] // 0x0000000189B42430-0x0000000189B42470
		// [XID] // 0x0000000189B42430-0x0000000189B42470
		public bool ContainsConvexQuadCCW(ref Vector2 point) => default; // 0x0000000188D358E0-0x0000000188D35E70
		// [IDTag] // 0x0000000189B4CC30-0x0000000189B4CC70
		// [XID] // 0x0000000189B4CC30-0x0000000189B4CC70
		public bool ContainsConvexQuadCCW(Vector2 point) => default; // 0x0000000188D35E70-0x0000000188D35F30
		// [IDTag] // 0x0000000189B57360-0x0000000189B573A0
		// [XID] // 0x0000000189B57360-0x0000000189B573A0
		public bool ContainsConvexQuadCW(ref Vector2 point) => default; // 0x0000000188D35F30-0x0000000188D364C0
		// [IDTag] // 0x0000000189B619A0-0x0000000189B619E0
		// [XID] // 0x0000000189B619A0-0x0000000189B619E0
		public bool ContainsConvexQuadCW(Vector2 point) => default; // 0x0000000188D364C0-0x0000000188D36580
		// [IDTag] // 0x0000000189B6C1B0-0x0000000189B6C1F0
		// [XID] // 0x0000000189B6C1B0-0x0000000189B6C1F0
		public bool ContainsConvexCCW(ref Vector2 point) => default; // 0x0000000188D35680-0x0000000188D35750
		// [IDTag] // 0x0000000189B767C0-0x0000000189B76800
		// [XID] // 0x0000000189B767C0-0x0000000189B76800
		public bool ContainsConvexCCW(Vector2 point) => default; // 0x0000000188D355C0-0x0000000188D35680
		// [XID] // 0x000000018995C9C0-0x000000018995C9E0
		private bool SubContainsPointCCW(ref Vector2 p, int i0, int i1) => default; // 0x0000000188D37360-0x0000000188D376F0
		// [IDTag] // 0x0000000189B887A0-0x0000000189B887E0
		// [XID] // 0x0000000189B887A0-0x0000000189B887E0
		public bool ContainsConvexCW(ref Vector2 point) => default; // 0x0000000188D35810-0x0000000188D358E0
		// [IDTag] // 0x0000000189B92840-0x0000000189B92880
		// [XID] // 0x0000000189B92840-0x0000000189B92880
		public bool ContainsConvexCW(Vector2 point) => default; // 0x0000000188D35750-0x0000000188D35810
		// [XID] // 0x0000000189B9CD40-0x0000000189B9CD60
		private bool SubContainsPointCW(ref Vector2 p, int i0, int i1) => default; // 0x0000000188D376F0-0x0000000188D37A80
		// [IDTag] // 0x0000000189BA4570-0x0000000189BA45B0
		// [XID] // 0x0000000189BA4570-0x0000000189BA45B0
		public bool ContainsSimple(ref Vector2 point) => default; // 0x0000000188D36580-0x0000000188D36760
		// [IDTag] // 0x0000000189BAE750-0x0000000189BAE790
		// [XID] // 0x0000000189BAE750-0x0000000189BAE790
		public bool ContainsSimple(Vector2 point) => default; // 0x0000000188D36760-0x0000000188D36820
		// [XID] // 0x0000000189BB8C20-0x0000000189BB8C40
		public Segment2[] ToSegmentArray() => default; // 0x0000000188D37A80-0x0000000188D37C70
		// [XID] // 0x00000001899AFCD0-0x00000001899AFCF0
		public override string ToString() => default; // 0x0000000188D37C70-0x0000000188D37F00
	}
}
