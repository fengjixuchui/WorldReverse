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

namespace Cinemachine
{
	[Serializable]
	// [DocumentationSorting] // 0x000000018972F010-0x000000018972F030
	public struct LensSettings // TypeDefIndex: 6854
	{
		// Fields
		public static LensSettings Default; // 0x00
		// [Range] // 0x00000001897367B0-0x0000000189736810
		// [Tooltip] // 0x00000001897367B0-0x0000000189736810
		public float FieldOfView; // 0x00
		// [Tooltip] // 0x0000000189742600-0x0000000189742630
		public float OrthographicSize; // 0x04
		// [Tooltip] // 0x000000018974BC70-0x000000018974BCA0
		public float NearClipPlane; // 0x08
		// [Tooltip] // 0x0000000189754A10-0x0000000189754A40
		public float FarClipPlane; // 0x0C
		// [Range] // 0x000000018975D3C0-0x000000018975D420
		// [Tooltip] // 0x000000018975D3C0-0x000000018975D420
		public float Dutch; // 0x10
	
		// Properties
		internal bool Orthographic { /* [XID] */ /* 0x000000018977E0E0-0x000000018977E120 */ get; /* [XID] */ /* 0x0000000189788A70-0x0000000189788AB0 */ set; } // 0x00000001866A6160-0x00000001866A6230 0x00000001866A6300-0x00000001866A63C0
		internal float Aspect { /* [XID] */ /* 0x0000000189792F70-0x0000000189792FB0 */ get; /* [XID] */ /* 0x000000018979E2B0-0x000000018979E2F0 */ set; } // 0x00000001866A6090-0x00000001866A6160 0x00000001866A6230-0x00000001866A6300
	
		// Constructors
		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch, bool ortho, float aspect) : this() {
			FieldOfView = default;
			OrthographicSize = default;
			NearClipPlane = default;
			FarClipPlane = default;
			Dutch = default;
		} // 0x00000001866A6000-0x00000001866A6090
		static LensSettings() {
			Default = default;
		} // 0x00000001866A5DC0-0x00000001866A6000
	
		// Methods
		// [XID] // 0x00000001897A84F0-0x00000001897A8510
		public static LensSettings FromCamera(Camera fromCamera) => default; // 0x00000001866A5680-0x00000001866A58F0
		// [XID] // 0x00000001897AFE50-0x00000001897AFE70
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) => default; // 0x00000001866A58F0-0x00000001866A5DB0
		// [XID] // 0x000000018972D550-0x000000018972D570
		public void Validate() {} // 0x00000001866A5DB0-0x00000001866A5DC0
	}
}
