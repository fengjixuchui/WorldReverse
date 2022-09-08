/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public class CameraStateBlenderConfig // TypeDefIndex: 8940
	{
		// Fields
		public int fromId; // 0x10
		public int toId; // 0x14
		public BlendType blendType; // 0x18
		public EasingFunction.Ease easeType; // 0x1C
		public PoleType poleType; // 0x20
		public ZoomType zoomType; // 0x24
		public float duration; // 0x28
	
		// Nested types
		[Serializable]
		public class BlenderConfigParam // TypeDefIndex: 8941
		{
			// Fields
			public BlendType blendType; // 0x10
			public EasingFunction.Ease easeType; // 0x14
			public PoleType poleType; // 0x18
			public float duration; // 0x1C
	
			// Constructors
			public BlenderConfigParam() {} // 0x0000000185A70B40-0x0000000185A70BC0
		}
	
		public enum BlendType // TypeDefIndex: 8942
		{
			SPH = 0,
			POS = 1
		}
	
		public enum PoleType // TypeDefIndex: 8943
		{
			TARGET_BACK = 0,
			KEEP_X = 1,
			KEEP_XY = 2,
			NONE = 3
		}
	
		public enum ZoomType // TypeDefIndex: 8944
		{
			KEEP_Z = 0,
			NONE = 1
		}
	
		// Constructors
		public CameraStateBlenderConfig() {} // 0x0000000185A72BD0-0x0000000185A72C50
	
		// Methods
		// [XID] // 0x00000001899F9440-0x00000001899F9460
		public static CameraStateBlenderConfig CreateBlenderCfg(int fromId, int toId, BlendType blendType, EasingFunction.Ease easeType, float duration) => default; // 0x0000000185A72970-0x0000000185A72AA0
		// [XID] // 0x0000000189626EB0-0x0000000189626ED0
		public static void AddCameraStateBlenderConfig(Dictionary<int, Dictionary<int, CameraStateBlenderConfig>> dic, CameraStateBlenderConfig cfg) {} // 0x0000000185A72730-0x0000000185A72880
		// [XID] // 0x00000001896AB2B0-0x00000001896AB2D0
		public static CameraStateBlenderConfig GetCameraStateBlenderConfig(Dictionary<int, Dictionary<int, CameraStateBlenderConfig>> dic, int fromId, int toId) => default; // 0x0000000185A72AA0-0x0000000185A72BD0
		// [XID] // 0x00000001896B2470-0x00000001896B2490
		public static CameraStateBlenderConfig CreateBlenderCfgByParam(BlenderConfigParam param) => default; // 0x0000000185A72880-0x0000000185A72970
	}
}
