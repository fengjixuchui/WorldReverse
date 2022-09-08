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
	internal class ConcaveHull2 // TypeDefIndex: 8044
	{
		// Nested types
		private struct Edge // TypeDefIndex: 8045
		{
			// Fields
			public int V0; // 0x00
			public int V1; // 0x04
	
			// Constructors
			public Edge(int v0, int v1) {
				V0 = default;
				V1 = default;
			} // 0x0000000187E58560-0x0000000187E585D0
		}
	
		private struct InnerPoint // TypeDefIndex: 8046
		{
			// Fields
			public float AverageDistance; // 0x00
			public float Distance0; // 0x04
			public float Distance1; // 0x08
			public int Index; // 0x0C
		}
	
		// Constructors
		public ConcaveHull2() {} // 0x0000000187E416D0-0x0000000187E41730
	
		// Methods
		// [XID] // 0x0000000189B67E30-0x0000000189B67E50
		private static void Quicksort(InnerPoint[] x, int first, int last) {} // 0x0000000187E413F0-0x0000000187E416D0
		// [XID] // 0x0000000189B6F140-0x0000000189B6F160
		private static float CalcDistanceFromPointToEdge(ref Vector2 pointA, ref Vector2 v0, ref Vector2 v1) => default; // 0x0000000187E40360-0x0000000187E40590
		// [XID] // 0x0000000189B76800-0x0000000189B76820
		public static bool Create(Vector2[] points, out int[] concaveHull, int[] convexHull, float N, float epsilon = 1E-05f /* Metadata: 0x00ADF49B */) {
			concaveHull = default;
			return default;
		} // 0x0000000187E40590-0x0000000187E413F0
	}
}
