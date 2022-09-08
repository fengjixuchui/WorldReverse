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
	[Serializable]
	public class Decal // TypeDefIndex: 9716
	{
		// Fields
		private static Vector3 DefaultRotation; // 0x00
		private static Vector3 DefaultScale; // 0x0C
		public string name; // 0x10
		public string id; // 0x18
		public string normalId; // 0x20
		public bool isPacked; // 0x28
		public string materialId; // 0x30
		public string deferredMaterialId; // 0x38
		public Vector3 rotation; // 0x40
		public Vector3 scale; // 0x4C
		public Rect atlasRect; // 0x58
		public int orgGroup; // 0x68
		public int orgIndex; // 0x6C
		public int atlasGroup; // 0x70
		public int atlasIndex; // 0x74
		public Placement rotationPlacement; // 0x78
		public Placement scalePlacement; // 0x7C
		public Texture2D texture; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D _normalTexture; // 0x88
		public UnityEngine.Material _material; // 0x90
		public UnityEngine.Material _deferredMaterial; // 0x98
		public Rect normalAtlasRect; // 0xA0
	
		// Properties
		public Texture2D normalTexture { /* [XID] */ /* 0x0000000189784290-0x00000001897842B0 */ get => default; /* [XID] */ /* 0x000000018978B9D0-0x000000018978B9F0 */ set {} } // 0x000000018600DB90-0x000000018600DC40 0x000000018600DDA0-0x000000018600DE50
		public UnityEngine.Material material { /* [XID] */ /* 0x0000000189792D40-0x0000000189792D60 */ get => default; /* [XID] */ /* 0x000000018979A4F0-0x000000018979A510 */ set {} } // 0x000000018600DAE0-0x000000018600DB90 0x000000018600DCF0-0x000000018600DDA0
		public UnityEngine.Material deferredMaterial { /* [XID] */ /* 0x0000000189A69290-0x0000000189A692B0 */ get => default; /* [XID] */ /* 0x00000001897A9AC0-0x00000001897A9AE0 */ set {} } // 0x000000018600DA30-0x000000018600DAE0 0x000000018600DC40-0x000000018600DCF0
	
		// Constructors
		public Decal() {} // 0x000000018600D800-0x000000018600D870
		public Decal(Texture2D img) {} // 0x000000018600D870-0x000000018600DA30
		static Decal() {} // 0x000000018600D700-0x000000018600D800
	
		// Methods
		// [XID] // 0x0000000189A2CD00-0x0000000189A2CD20
		public override string ToString() => default; // 0x000000018600CCC0-0x000000018600D080
		// [XID] // 0x00000001897B8EA0-0x00000001897B8EC0
		public static bool Deserialize(string txt, out Decal decal) {
			decal = default;
			return default;
		} // 0x000000018600B210-0x000000018600BC10
		// [XID] // 0x00000001897C0FF0-0x00000001897C1010
		public string Serialize() => default; // 0x000000018600BC10-0x000000018600CCC0
		// [XID] // 0x00000001897C88F0-0x00000001897C8910
		private static bool Vec3WithString(string str, ref Vector3 vec3) => default; // 0x000000018600D0F0-0x000000018600D340
		// [XID] // 0x00000001897CFF50-0x00000001897CFF70
		private static bool Vec4WithString(string str, ref Vector4 vec4) => default; // 0x000000018600D460-0x000000018600D700
		// [XID] // 0x00000001897D7820-0x00000001897D7840
		private static Rect Vec4ToRect(Vector4 v) => default; // 0x000000018600D340-0x000000018600D460
	}
}
