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
	public class CameraStatePostProcesser // TypeDefIndex: 8957
	{
		// Fields
		protected CameraStateData _retData; // 0x10
		protected ICameraState _activeState; // 0xE8
		protected CameraStateBlender _activeBlender; // 0xF0
		protected List<CameraStatePostModule> _modules; // 0xF8
	
		// Properties
		public CameraStateData Data { /* [XID] */ /* 0x0000000189955420-0x0000000189955440 */ get => default; } // 0x000000018731CC60-0x000000018731CEB0 
		public bool IsValid { /* [XID] */ /* 0x000000018996BB80-0x000000018996BBA0 */ get => default; } // 0x000000018731CEB0-0x000000018731D0C0 
	
		// Constructors
		public CameraStatePostProcesser() {} // 0x000000018731CB10-0x000000018731CC60
	
		// Methods
		public static PostProcesserType Create<PostProcesserType>()
			where PostProcesserType : CameraStatePostProcesser, new() => default;
		// [XID] // 0x000000018995CC00-0x000000018995CC20
		public virtual void RefreshState(ICameraState activeState) {} // 0x000000018731C830-0x000000018731C8E0
		// [XID] // 0x0000000189B831E0-0x0000000189B83200
		public void RefreshBlender(CameraStateBlender blender) {} // 0x000000018731C780-0x000000018731C830
		public virtual PostModuleType AddModule<PostModuleType>()
			where PostModuleType : CameraStatePostModule, new() => default;
		// [XID] // 0x00000001899736B0-0x00000001899736D0
		public void Init() {} // 0x000000018731C6E0-0x000000018731C780
		// [XID] // 0x0000000189AC98E0-0x0000000189AC9900
		public virtual void Collect(float deltaTime) {} // 0x000000018731C500-0x000000018731C630
		// [XID] // 0x00000001898D1AD0-0x00000001898D1AF0
		public virtual void Tick(float deltaTime) {} // 0x000000018731C8E0-0x000000018731CB10
		// [XID] // 0x000000018998A010-0x000000018998A030
		public virtual void Flush(float deltaTime) {} // 0x000000018731C630-0x000000018731C6E0
	}
}
