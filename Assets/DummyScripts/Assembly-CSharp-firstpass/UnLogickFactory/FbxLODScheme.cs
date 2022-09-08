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

namespace UnLogickFactory
{
	[Serializable]
	public class FbxLODScheme // TypeDefIndex: 10129
	{
		// Fields
		public LODScheme Scheme; // 0x10
		private Camera[] _lodCameras; // 0x18
	
		// Properties
		public LODSchemeEnumMaskFlags SchemeMask { /* [XID] */ /* 0x00000001896A3DD0-0x00000001896A3DF0 */ get => default; /* [XID] */ /* 0x0000000189BD1010-0x0000000189BD1030 */ set {} } // 0x00000001862AB1E0-0x00000001862AB280 0x00000001862AB280-0x00000001862AB330
	
		// Nested types
		public enum LODScheme // TypeDefIndex: 10130
		{
			IgnoreLOD = 0,
			MainCamera = 1,
			OtherCameras = 2,
			AllCameras = 3,
			PerformCulling = 4,
			CullMainCamera = 5,
			CullOtherCameras = 6,
			CullAllCameras = 8
		}
	
		public enum LODSchemeEnumMaskFlags // TypeDefIndex: 10131
		{
			MainCamera = 1,
			OtherCameras = 2,
			PerformCulling = 4
		}
	
		// Constructors
		public FbxLODScheme() {} // 0x00000001862AB180-0x00000001862AB1E0
	
		// Methods
		// [XID] // 0x00000001896B2390-0x00000001896B23B0
		public virtual void Prepare(int logLevel) {} // 0x00000001862AA880-0x00000001862AA930
		// [XID] // 0x0000000189A62600-0x0000000189A62620
		public virtual void GetRenderers(LODGroup lodGroup, FbxExportCollection result, FbxExportSettings settings) {} // 0x00000001862AA080-0x00000001862AA170
		// [XID] // 0x00000001896C1080-0x00000001896C10A0
		private void _Prepare() {} // 0x00000001862AAF10-0x00000001862AB180
		// [XID] // 0x00000001896C85E0-0x00000001896C8600
		private void _GetRenderers(LODGroup lodGroup, FbxExportCollection result, FbxExportSettings settings) {} // 0x00000001862AA930-0x00000001862AAF10
		// [XID] // 0x0000000189A71810-0x0000000189A71830
		private bool IsCulled(Renderer renderer) => default; // 0x00000001862AA170-0x00000001862AA880
		// [XID] // 0x000000018980A5C0-0x000000018980A5E0
		private int DetermineLODGroup(LODGroup lodGroup) => default; // 0x00000001862A98C0-0x00000001862A9A30
		// [XID] // 0x0000000189A6A400-0x0000000189A6A420
		private static int DetermineLOD(LODGroup lodGroup, Camera camera) => default; // 0x00000001862A9A30-0x00000001862AA080
	}
}
