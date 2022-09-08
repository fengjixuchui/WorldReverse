/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_Bounds2D // TypeDefIndex: 3437
	{
		// Fields
		public Vector2 center; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _size; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _extents; // 0x20
	
		// Properties
		public Vector2 size { get => default; set {} } // 0x000000018770F7F0-0x000000018770F860 0x000000018770F860-0x000000018770F8F0
		public Vector2 extents { get => default; } // 0x000000018770F780-0x000000018770F7F0 
		public Vector2[] corners { get => default; } // 0x000000018770F390-0x000000018770F780 
	
		// Constructors
		public pb_Bounds2D() {} // 0x000000018770EE40-0x000000018770EEF0
		public pb_Bounds2D(Vector2 center, Vector2 size) {} // 0x000000018770ED70-0x000000018770EE40
		public pb_Bounds2D(Vector2[] points) {} // 0x000000018770F200-0x000000018770F2C0
		public pb_Bounds2D(Vector2[] points, int[] indices) {} // 0x000000018770F2C0-0x000000018770F390
		public pb_Bounds2D(Vector2[] points, pb_Edge[] edges) {} // 0x000000018770E880-0x000000018770ED70
		public pb_Bounds2D(Vector2[] points, int length) {} // 0x000000018770EEF0-0x000000018770F200
	
		// Methods
		public bool ContainsPoint(Vector2 point) => default; // 0x000000018770D730-0x000000018770D8C0
		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) => default; // 0x000000018770D8C0-0x000000018770DAF0
		public bool Intersects(pb_Bounds2D bounds) => default; // 0x000000018770DCB0-0x000000018770DEA0
		public bool Intersects(Rect rect) => default; // 0x000000018770DAF0-0x000000018770DCB0
		public void SetWithPoints(IList<Vector2> points) {} // 0x000000018770E2D0-0x000000018770E5B0
		public void SetWithPoints(IList<Vector2> points, IList<int> indices) {} // 0x000000018770DEA0-0x000000018770E2D0
		public static Vector2 Center(Vector2[] points, int length = -1 /* Metadata: 0x00AC3D8A */) => default; // 0x000000018770D5E0-0x000000018770D730
		public static Vector2 Center(Vector2[] points, int[] indices) => default; // 0x000000018770D410-0x000000018770D5E0
		public override string ToString() => default; // 0x000000018770E5B0-0x000000018770E880
	}
}
