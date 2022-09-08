/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_EdgeLookup : IEquatable<ProBuilder2.Common.pb_EdgeLookup> // TypeDefIndex: 3441
	{
		// Fields
		public pb_Edge local; // 0x10
		public pb_Edge common; // 0x18
	
		// Constructors
		public pb_EdgeLookup() {} // Dummy constructor
		public pb_EdgeLookup(pb_Edge common, pb_Edge local) {} // 0x0000000187728BC0-0x0000000187728C40
		public pb_EdgeLookup(int cx, int cy, int x, int y) {} // 0x0000000187728A90-0x0000000187728BC0
	
		// Methods
		public bool Equals(pb_EdgeLookup b) => default; // 0x0000000187728670-0x0000000187728740
		public override bool Equals(object b) => default; // 0x0000000187728740-0x0000000187728810
		public override int GetHashCode() => default; // 0x0000000187728940-0x00000001877289B0
		public override string ToString() => default; // 0x00000001877289B0-0x0000000187728A90
		public static IEnumerable<pb_EdgeLookup> GetEdgeLookup(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup) => default; // 0x0000000187728810-0x0000000187728940
	}
}
