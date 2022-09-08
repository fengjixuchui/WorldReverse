/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_FaceRebuildData // TypeDefIndex: 3443
	{
		// Fields
		public pb_Face face; // 0x10
		public List<pb_Vertex> vertices; // 0x18
		public List<int> sharedIndices; // 0x20
		public List<int> sharedIndicesUV; // 0x28
		private int _appliedOffset; // 0x30
	
		// Constructors
		public pb_FaceRebuildData() {} // 0x000000018772E320-0x000000018772E380
	
		// Methods
		public int Offset() => default; // 0x000000018772E1E0-0x000000018772E240
		public override string ToString() => default; // 0x000000018772E240-0x000000018772E320
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, pb_Object pb, List<pb_Vertex> vertices = null, List<pb_Face> faces = null, Dictionary<int, int> lookup = null, Dictionary<int, int> lookupUV = null) {} // 0x000000018772DE60-0x000000018772E1E0
		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, List<pb_Vertex> vertices, List<pb_Face> faces, Dictionary<int, int> sharedIndices, Dictionary<int, int> sharedIndicesUV = null) {} // 0x000000018772DA90-0x000000018772DE60
	}
}
