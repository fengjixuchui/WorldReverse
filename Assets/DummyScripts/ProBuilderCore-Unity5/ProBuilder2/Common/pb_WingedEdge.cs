/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_WingedEdge : IEquatable<ProBuilder2.Common.pb_WingedEdge>, IEnumerable // TypeDefIndex: 3458
	{
		// Fields
		public pb_EdgeLookup edge; // 0x10
		public pb_Face face; // 0x18
		public pb_WingedEdge next; // 0x20
		public pb_WingedEdge previous; // 0x28
		public pb_WingedEdge opposite; // 0x30
	
		// Constructors
		public pb_WingedEdge() {} // 0x00000001894D6CE0-0x00000001894D6D40
	
		// Methods
		public bool Equals(pb_WingedEdge b) => default; // 0x00000001894D4FD0-0x00000001894D5080
		public override bool Equals(object b) => default; // 0x00000001894D5080-0x00000001894D51A0
		public override int GetHashCode() => default; // 0x00000001894D5300-0x00000001894D5380
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001894D6910-0x00000001894D6980
		public pb_WingedEdgeEnumerator GetEnumerator() => default; // 0x00000001894D5280-0x00000001894D5300
		public int Count() => default; // 0x00000001894D4F40-0x00000001894D4FD0
		public override string ToString() => default; // 0x00000001894D6980-0x00000001894D6C00
		public static int[] MakeQuad(pb_WingedEdge left, pb_WingedEdge right) => default; // 0x00000001894D5B80-0x00000001894D6450
		public pb_WingedEdge GetAdjacentEdgeWithCommonIndex(int common) => default; // 0x00000001894D51A0-0x00000001894D5280
		public static List<pb_Edge> SortEdgesByAdjacency(pb_Face face) => default; // 0x00000001894D6860-0x00000001894D6910
		public static List<pb_Edge> SortEdgesByAdjacency(List<pb_Edge> edges) => default; // 0x00000001894D66E0-0x00000001894D6860
		public static Dictionary<int, List<pb_WingedEdge>> GetSpokes(List<pb_WingedEdge> wings) => default; // 0x00000001894D5380-0x00000001894D5690
		public static List<int> SortCommonIndicesByAdjacency(List<pb_WingedEdge> wings, HashSet<int> common) => default; // 0x00000001894D6450-0x00000001894D66E0
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, bool oneWingPerFace = false /* Metadata: 0x00AC3D97 */) => default; // 0x00000001894D5AE0-0x00000001894D5B80
		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, IEnumerable<pb_Face> faces, bool oneWingPerFace = false /* Metadata: 0x00AC3D98 */, Dictionary<int, int> sharedIndexLookup = null) => default; // 0x00000001894D5690-0x00000001894D5AE0
	}
}
