/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_VertexConnection : IEquatable<ProBuilder2.Common.pb_VertexConnection> // TypeDefIndex: 3457
	{
		// Fields
		public pb_Face face; // 0x10
		public List<int> indices; // 0x18
	
		// Properties
		public bool isValid { get => default; } // 0x00000001894D0DA0-0x00000001894D0E20 
	
		// Constructors
		public pb_VertexConnection() {} // Dummy constructor
		public pb_VertexConnection(pb_Face face, List<int> indices) {} // 0x00000001894D0D10-0x00000001894D0DA0
	
		// Methods
		public pb_VertexConnection Distinct(pb_IntArray[] sharedIndices) => default; // 0x00000001894D09A0-0x00000001894D0A60
		public override bool Equals(object b) => default; // 0x00000001894D0A60-0x00000001894D0B40
		public bool Equals(pb_VertexConnection vc) => default; // 0x00000001894D0B40-0x00000001894D0BC0
		public static implicit operator pb_Face(pb_VertexConnection vc) => default; // 0x00000001894D0E20-0x00000001894D0E90
		public override int GetHashCode() => default; // 0x00000001894D0BC0-0x00000001894D0C30
		public override string ToString() => default; // 0x00000001894D0C30-0x00000001894D0D10
		public static List<int> AllTriangles(List<pb_VertexConnection> vcs) => default; // 0x00000001894D08A0-0x00000001894D09A0
	}
}
