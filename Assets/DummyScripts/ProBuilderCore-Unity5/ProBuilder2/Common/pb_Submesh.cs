/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_Submesh // TypeDefIndex: 3448
	{
		// Fields
		public int[] indices; // 0x10
		public MeshTopology topology; // 0x18
		public UnityEngine.Material material; // 0x20
	
		// Constructors
		public pb_Submesh() {} // Dummy constructor
		public pb_Submesh(UnityEngine.Material material, MeshTopology topology, int[] indices) {} // 0x00000001894CEA40-0x00000001894CEAD0
		public pb_Submesh(Mesh mesh, int subMeshIndex, UnityEngine.Material material) {} // 0x00000001894CEAD0-0x00000001894CEB90
	
		// Methods
		public override string ToString() => default; // 0x00000001894CE8A0-0x00000001894CEA40
	}
}
