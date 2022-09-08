/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ProCore.Decals
{
	public class qd_Mesh // TypeDefIndex: 9724
	{
		// Fields
		private static int[] BILLBOARD_TRIANGLES; // 0x00
		private static Vector3[] BILLBOARD_VERTICES; // 0x08
		private static Vector3[] BILLBOARD_NORMALS; // 0x10
		private static Vector4[] BILLBOARD_TANGENTS; // 0x18
	
		// Constructors
		public qd_Mesh() {} // 0x00000001860305B0-0x0000000186030610
		static qd_Mesh() {} // 0x00000001860300C0-0x00000001860305B0
	
		// Methods
		// [XID] // 0x000000018984D600-0x000000018984D620
		public static GameObject CreateDecal(UnityEngine.Material mat, Texture2D originalTexture, Rect uv, Rect normalUV, float scale, DecalType type, qd_Resources resources) => default; // 0x000000018602EF30-0x000000018602F990
		// [XID] // 0x0000000189A34690-0x0000000189A346B0
		public static Mesh DecalMesh(string name, UnityEngine.Material mat, Rect uv, Rect normalUV, Vector3 aspectScale, float scale, DecalType type, qd_Resources resources) => default; // 0x000000018602F990-0x00000001860300C0
	}
}
