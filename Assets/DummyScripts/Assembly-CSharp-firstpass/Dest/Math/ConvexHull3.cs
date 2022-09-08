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
	internal class ConvexHull3 // TypeDefIndex: 8052
	{
		// Nested types
		private class Triangle // TypeDefIndex: 8053
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int V2; // 0x18
			public Triangle Adj0; // 0x20
			public Triangle Adj1; // 0x28
			public Triangle Adj2; // 0x30
			public int Sign; // 0x38
			public int Time; // 0x3C
			public bool OnStack; // 0x40
	
			// Constructors
			public Triangle() {} // Dummy constructor
			public Triangle(int v0, int v1, int v2) {} // 0x0000000187E58C40-0x0000000187E58D80
	
			// Methods
			// [XID] // 0x0000000189B8AF60-0x0000000189B8AF80
			public Triangle GetAdj(int index) => default; // 0x0000000187E588D0-0x0000000187E589A0
			// [XID] // 0x00000001895FBDD0-0x00000001895FBDF0
			public void SetAdj(int index, Triangle value) {} // 0x0000000187E58B60-0x0000000187E58C40
			// [XID] // 0x0000000189BAFC20-0x0000000189BAFC40
			public int GetV(int index) => default; // 0x0000000187E58AA0-0x0000000187E58B60
			// [XID] // 0x000000018960B080-0x000000018960B0A0
			public int GetSign(int i, Query3 query) => default; // 0x0000000187E589A0-0x0000000187E58AA0
			// [XID] // 0x000000018986B460-0x000000018986B480
			public void AttachTo(Triangle adj0, Triangle adj1, Triangle adj2) {} // 0x0000000187E586D0-0x0000000187E587B0
			// [XID] // 0x0000000189619DD0-0x0000000189619DF0
			public int DetachFrom(int adjIndex, Triangle adj) => default; // 0x0000000187E587B0-0x0000000187E588D0
		}
	
		private class TerminatorData // TypeDefIndex: 8054
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int NullIndex; // 0x18
			public Triangle T; // 0x20
	
			// Constructors
			public TerminatorData() {} // Dummy constructor
			public TerminatorData(int v0 = -1 /* Metadata: 0x00ADF4A7 */, int v1 = -1 /* Metadata: 0x00ADF4AB */, int nullIndex = -1 /* Metadata: 0x00ADF4AF */, Triangle tri = null) {} // 0x0000000187E58630-0x0000000187E586D0
		}
	
		// Constructors
		public ConvexHull3() {} // 0x0000000187E43E90-0x0000000187E43EF0
	
		// Methods
		// [XID] // 0x0000000189BD89C0-0x0000000189BD89E0
		public static bool Create(IList<Vector3> vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
			return default;
		} // 0x0000000187E42920-0x0000000187E43410
		// [XID] // 0x0000000189854FB0-0x0000000189854FD0
		private static bool Update(HashSet<Triangle> hull, int i, Query3 query) => default; // 0x0000000187E436B0-0x0000000187E43E90
		// [XID] // 0x0000000189BBE9B0-0x0000000189BBE9D0
		private static void ExtractIndices(HashSet<Triangle> hull, out int[] indices) {
			indices = default;
		} // 0x0000000187E43410-0x0000000187E436B0
	}
}
