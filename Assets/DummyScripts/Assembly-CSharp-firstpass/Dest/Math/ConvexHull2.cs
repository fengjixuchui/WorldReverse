/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	internal class ConvexHull2 // TypeDefIndex: 8050
	{
		// Nested types
		private class Edge // TypeDefIndex: 8051
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public Edge E0; // 0x18
			public Edge E1; // 0x20
			public int Sign; // 0x28
			public int Time; // 0x2C
	
			// Constructors
			public Edge() {} // Dummy constructor
			public Edge(int v0, int v1) {} // 0x0000000187E584D0-0x0000000187E58560
	
			// Methods
			// [XID] // 0x0000000189B7C3D0-0x0000000189B7C3F0
			public int GetSign(int i, Query2 query) => default; // 0x0000000187E582E0-0x0000000187E583E0
			// [XID] // 0x0000000189607840-0x0000000189607860
			public void Insert(Edge adj0, Edge adj1) {} // 0x0000000187E583E0-0x0000000187E584D0
			// [XID] // 0x000000018969C790-0x000000018969C7B0
			public void DeleteSelf() {} // 0x0000000187E580C0-0x0000000187E58170
			// [XID] // 0x0000000189BD12B0-0x0000000189BD12D0
			public void GetIndices(out int[] indices) {
				indices = default;
			} // 0x0000000187E58170-0x0000000187E582E0
		}
	
		// Constructors
		public ConvexHull2() {} // 0x0000000187E428C0-0x0000000187E42920
	
		// Methods
		// [XID] // 0x0000000189BABA50-0x0000000189BABA70
		public static bool Create(IList<Vector2> vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
			return default;
		} // 0x0000000187E41FF0-0x0000000187E42640
		// [XID] // 0x0000000189BB30A0-0x0000000189BB30C0
		private static bool Update(ref Edge hull, int i, Query2 query) => default; // 0x0000000187E42640-0x0000000187E428C0
	}
}
