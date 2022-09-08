/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	[Obsolete] // 0x0000000189AC49A0-0x0000000189AC49D0
	public class pb_EdgeConnection : IEquatable<ProBuilder2.Common.pb_EdgeConnection> // TypeDefIndex: 3440
	{
		// Fields
		public pb_Face face; // 0x10
		public List<pb_Edge> edges; // 0x18
	
		// Properties
		public bool isValid { get => default; } // 0x0000000187728580-0x0000000187728600 
	
		// Constructors
		public pb_EdgeConnection() {} // Dummy constructor
		public pb_EdgeConnection(pb_Face face, List<pb_Edge> edges) {} // 0x00000001877284F0-0x0000000187728580
	
		// Methods
		public override bool Equals(object b) => default; // 0x00000001877282C0-0x00000001877283A0
		public bool Equals(pb_EdgeConnection fc) => default; // 0x0000000187728240-0x00000001877282C0
		public static explicit operator pb_Face(pb_EdgeConnection fc) => default; // 0x0000000187728600-0x0000000187728670
		public override int GetHashCode() => default; // 0x00000001877283A0-0x0000000187728410
		public override string ToString() => default; // 0x0000000187728410-0x00000001877284F0
		public static List<int> AllTriangles(List<pb_EdgeConnection> ec) => default; // 0x00000001877280A0-0x0000000187728240
	}
}
