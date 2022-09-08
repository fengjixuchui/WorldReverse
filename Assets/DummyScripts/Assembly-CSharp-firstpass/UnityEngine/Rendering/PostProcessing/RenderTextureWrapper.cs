/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public struct RenderTextureWrapper // TypeDefIndex: 9615
	{
		// Fields
		public bool isOwnResource; // 0x68
		public static RenderTextureWrapper NULL; // 0x00
	
		// Properties
		public Type type { /* [XID] */ /* 0x00000001899DC800-0x00000001899DC840 */ get; /* [XID] */ /* 0x00000001899E7310-0x00000001899E7350 */ private set; } // 0x0000000185E102A0-0x0000000185E10300 0x0000000185E11A10-0x0000000185E11AD0
		private RenderTargetIdentifier id { /* [XID] */ /* 0x00000001899F16E0-0x00000001899F1720 */ get; /* [XID] */ /* 0x00000001899FC240-0x00000001899FC280 */ set; } // 0x0000000185E0FFC0-0x0000000185E10060 0x0000000185E11740-0x0000000185E11830
		private BuiltinRenderTextureType builtinID { /* [XID] */ /* 0x0000000189A068D0-0x0000000189A06910 */ get; /* [XID] */ /* 0x0000000189A10B50-0x0000000189A10B90 */ set; } // 0x0000000185E0FC60-0x0000000185E0FD20 0x0000000185E113E0-0x0000000185E114A0
		private RenderTexture renderTexture { /* [XID] */ /* 0x0000000189A1AFF0-0x0000000189A1B030 */ get; /* [XID] */ /* 0x0000000189A254B0-0x0000000189A254F0 */ set; } // 0x0000000185E101E0-0x0000000185E102A0 0x0000000185E119B0-0x0000000185E11A10
		public int width { /* [XID] */ /* 0x0000000189A2FB00-0x0000000189A2FB40 */ get; /* [XID] */ /* 0x0000000189A3A2B0-0x0000000189A3A2F0 */ private set; } // 0x0000000185E10300-0x0000000185E10360 0x0000000185E11AD0-0x0000000185E11B50
		public int height { /* [XID] */ /* 0x0000000189A44A00-0x0000000189A44A40 */ get; /* [XID] */ /* 0x0000000189A4F130-0x0000000189A4F170 */ private set; } // 0x0000000185E0FF60-0x0000000185E0FFC0 0x0000000185E116E0-0x0000000185E11740
		public int depthBuffer { /* [XID] */ /* 0x0000000189A59930-0x0000000189A59970 */ get; /* [XID] */ /* 0x0000000189A643D0-0x0000000189A64410 */ private set; } // 0x0000000185E0FD20-0x0000000185E0FDE0 0x0000000185E114A0-0x0000000185E11560
		public FilterMode filterMode { /* [XID] */ /* 0x0000000189A6EBA0-0x0000000189A6EBE0 */ get; /* [XID] */ /* 0x0000000189A794B0-0x0000000189A794F0 */ private set; } // 0x0000000185E0FDE0-0x0000000185E0FEA0 0x0000000185E11560-0x0000000185E11620
		public RenderTextureFormat format { /* [XID] */ /* 0x0000000189A83DE0-0x0000000189A83E20 */ get; /* [XID] */ /* 0x0000000189A8E7B0-0x0000000189A8E7F0 */ private set; } // 0x0000000185E0FEA0-0x0000000185E0FF60 0x0000000185E11620-0x0000000185E116E0
		public RenderTextureReadWrite readWrite { /* [XID] */ /* 0x0000000189A99240-0x0000000189A99280 */ get; /* [XID] */ /* 0x0000000189AA32C0-0x0000000189AA3300 */ private set; } // 0x0000000185E10120-0x0000000185E101E0 0x0000000185E118F0-0x0000000185E119B0
		public ulong lifeTime { get; /* [XID] */ /* 0x0000000189AB5210-0x0000000189AB5250 */ private set; } // 0x0000000185E10060-0x0000000185E10120 0x0000000185E11830-0x0000000185E118F0
	
		// Nested types
		public enum Type // TypeDefIndex: 9616
		{
			RenderTargetIdentify = 0,
			BuiltinRenderTextureType = 1,
			RenderTexture = 2,
			Null = 3
		}
	
		// Constructors
		public RenderTextureWrapper(RenderTexture renderTexture) : this() {
			isOwnResource = default;
		} // 0x0000000185E0F890-0x0000000185E0FC50
		public RenderTextureWrapper(RenderTargetIdentifier inID) : this() {
			isOwnResource = default;
		} // 0x0000000185E0F320-0x0000000185E0F890
		public RenderTextureWrapper(BuiltinRenderTextureType builtinID, int overrideFormat = -1 /* Metadata: 0x00AE5C7D */, int overrideFilterMode = -1 /* Metadata: 0x00AE5C81 */) : this() {
			isOwnResource = default;
		} // 0x0000000185E0FC50-0x0000000185E0FC60
		static RenderTextureWrapper() {
			NULL = default;
		} // 0x0000000185E0EE70-0x0000000185E0F320
	
		// Methods
		// [XID] // 0x0000000189ABFD10-0x0000000189ABFD30
		public bool IsValid() => default; // 0x0000000185E0EAC0-0x0000000185E0EC70
		// [XID] // 0x0000000189AC7820-0x0000000189AC7840
		public bool IsRenderTexture() => default; // 0x0000000185E0E890-0x0000000185E0EAC0
		// [XID] // 0x0000000189BC7D60-0x0000000189BC7D80
		public bool IsMatch(int width, int height, int depthBuffer, FilterMode filterMode, RenderTextureFormat format, RenderTextureReadWrite readWrite) => default; // 0x0000000185E0E770-0x0000000185E0E890
		// [XID] // 0x0000000189AD6CB0-0x0000000189AD6CD0
		public void Create(string name, int width, int height, int depthBuffer, FilterMode filterMode, RenderTextureFormat format, RenderTextureReadWrite readWrite, ulong lifeTime = 0 /* Metadata: 0x00AE5C85 */, bool useDynamicScaling = false /* Metadata: 0x00AE5C8D */) {} // 0x0000000185E0E1B0-0x0000000185E0E410
		// [XID] // 0x0000000189ADE610-0x0000000189ADE630
		public void Release() {} // 0x0000000185E0EC70-0x0000000185E0ED70
		// [IDTag] // 0x0000000189AE6020-0x0000000189AE6060
		// [XID] // 0x0000000189AE6020-0x0000000189AE6060
		public static implicit operator RenderTargetIdentifier(RenderTextureWrapper wrapper) => default; // 0x0000000185E10930-0x0000000185E10B60
		// [IDTag] // 0x0000000189AF0A00-0x0000000189AF0A40
		// [XID] // 0x0000000189AF0A00-0x0000000189AF0A40
		public static implicit operator BuiltinRenderTextureType(RenderTextureWrapper wrapper) => default; // 0x0000000185E10780-0x0000000185E10930
		// [IDTag] // 0x0000000189AFB140-0x0000000189AFB180
		// [XID] // 0x0000000189AFB140-0x0000000189AFB180
		public static implicit operator RenderTexture(RenderTextureWrapper wrapper) => default; // 0x0000000185E105D0-0x0000000185E10780
		// [IDTag] // 0x0000000189B054F0-0x0000000189B05530
		// [XID] // 0x0000000189B054F0-0x0000000189B05530
		public static implicit operator RenderTextureWrapper(RenderTargetIdentifier inID) => default; // 0x0000000185E10D30-0x0000000185E10F00
		// [IDTag] // 0x0000000189B0FD40-0x0000000189B0FD80
		// [XID] // 0x0000000189B0FD40-0x0000000189B0FD80
		public static implicit operator RenderTextureWrapper(RenderTexture renderTexture) => default; // 0x0000000185E10B60-0x0000000185E10D30
		// [IDTag] // 0x0000000189B1A070-0x0000000189B1A0B0
		// [XID] // 0x0000000189B1A070-0x0000000189B1A0B0
		public static implicit operator RenderTextureWrapper(BuiltinRenderTextureType builtinID) => default; // 0x0000000185E10F00-0x0000000185E110E0
		// [XID] // 0x0000000189B24750-0x0000000189B24770
		public static bool operator ==(RenderTextureWrapper lhs, RenderTextureWrapper rhs) => default; // 0x0000000185E10360-0x0000000185E105D0
		// [XID] // 0x0000000189B2BBA0-0x0000000189B2BBC0
		public static bool operator !=(RenderTextureWrapper lhs, RenderTextureWrapper rhs) => default; // 0x0000000185E110E0-0x0000000185E113E0
		// [XID] // 0x0000000189B603F0-0x0000000189B60410
		public override bool Equals(object obj) => default; // 0x0000000185E0E410-0x0000000185E0E580
		// [XID] // 0x0000000189B3AC10-0x0000000189B3AC30
		public override int GetHashCode() => default; // 0x0000000185E0E580-0x0000000185E0E770
	}
}
