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

namespace UnityEngine.Rendering.PostProcessing
{
	internal static class MeshUtilities // TypeDefIndex: 9609
	{
		// Fields
		private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x00
		private static Dictionary<System.Type, PrimitiveType> s_ColliderPrimitives; // 0x08
	
		// Constructors
		static MeshUtilities() {} // 0x0000000186068C30-0x0000000186068DA0
	
		// Methods
		// [XID] // 0x00000001898BD730-0x00000001898BD750
		internal static Mesh GetColliderMesh(Collider collider) => default; // 0x00000001860688E0-0x0000000186068AD0
		// [XID] // 0x00000001899D9CA0-0x00000001899D9CC0
		internal static Mesh GetPrimitive(PrimitiveType primitiveType) => default; // 0x0000000186068AD0-0x0000000186068C30
		// [XID] // 0x00000001898CC4A0-0x00000001898CC4C0
		private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) => default; // 0x00000001860687F0-0x00000001860688E0
	}
}
