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
	[Serializable]
	public struct pb_Edge : IEquatable<ProBuilder2.Common.pb_Edge> // TypeDefIndex: 3371
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public static readonly pb_Edge Empty; // 0x00
	
		// Constructors
		public pb_Edge(int x, int y) {
			this.x = default;
			this.y = default;
		} // 0x000000018772AC30-0x000000018772ACA0
		public pb_Edge(pb_Edge edge) {
			x = default;
			y = default;
		} // 0x000000018772AB50-0x000000018772AC30
		static pb_Edge() {
			Empty = default;
		} // 0x000000018772AAA0-0x000000018772AB50
	
		// Methods
		public bool IsValid() => default; // 0x0000000187729D30-0x0000000187729E70
		public override string ToString() => default; // 0x000000018772A100-0x000000018772A110
		public bool Equals(pb_Edge edge) => default; // 0x0000000187729430-0x00000001877294D0
		public override bool Equals(object b) => default; // 0x0000000187729280-0x0000000187729380
		public override int GetHashCode() => default; // 0x00000001877294D0-0x00000001877294E0
		public static pb_Edge operator +(pb_Edge a, pb_Edge b) => default; // 0x000000018772AD70-0x000000018772AE50
		public static pb_Edge operator -(pb_Edge a, pb_Edge b) => default; // 0x000000018772AFE0-0x000000018772B0B0
		public static pb_Edge operator +(pb_Edge a, int b) => default; // 0x000000018772ACA0-0x000000018772AD70
		public static pb_Edge operator -(pb_Edge a, int b) => default; // 0x000000018772B0B0-0x000000018772B180
		public static bool operator ==(pb_Edge a, pb_Edge b) => default; // 0x000000018772AE50-0x000000018772AF30
		public static bool operator !=(pb_Edge a, pb_Edge b) => default; // 0x000000018772AF30-0x000000018772AFE0
		public int[] ToArray() => default; // 0x0000000187729E70-0x000000018772A100
		public bool Equals(pb_Edge b, Dictionary<int, int> lookup) => default; // 0x0000000187729380-0x0000000187729430
		public bool Contains(int a) => default; // 0x0000000187729020-0x00000001877291B0
		public bool Contains(pb_Edge b) => default; // 0x0000000187728F90-0x0000000187729020
		public bool Contains(int a, pb_IntArray[] sharedIndices) => default; // 0x00000001877291B0-0x0000000187729280
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, Dictionary<int, int> sharedIndicesLookup) => default; // 0x0000000187729A50-0x0000000187729C10
		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, pb_IntArray[] sharedIndices) => default; // 0x0000000187729C10-0x0000000187729D30
		public static pb_Edge GetLocalEdgeFast(pb_Edge edge, pb_IntArray[] sharedIndices) => default; // 0x00000001877294E0-0x0000000187729610
		public static bool ValidateEdge(pb_Object pb, pb_Edge edge, out pb_Tuple<pb_Face, pb_Edge> validEdge) {
			validEdge = default;
			return default;
		} // 0x000000018772A110-0x000000018772A540
		public static List<pb_Edge> ValidateEdges(pb_Object pb, pb_Edge[] edges) => default; // 0x000000018772A540-0x000000018772A8D0
		public static pb_Edge[] GetLocalEdges_Fast(pb_Edge[] edges, pb_IntArray[] sharedIndices) => default; // 0x0000000187729610-0x0000000187729810
		public static pb_Edge[] AllEdges(pb_Face[] faces) => default; // 0x0000000187728C40-0x0000000187728DC0
		public static bool ContainsDuplicateFast(pb_Edge[] edges, pb_Edge edge) => default; // 0x0000000187728DC0-0x0000000187728F90
		public static Vector3[] VerticesWithEdges(pb_Edge[] edges, Vector3[] vertices) => default; // 0x000000018772A8D0-0x000000018772AAA0
		public static pb_Edge[] GetPerimeterEdges(pb_Edge[] edges) => default; // 0x0000000187729810-0x0000000187729A50
	}
}
