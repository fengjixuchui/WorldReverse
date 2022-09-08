/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraPhotographState : SCameraBaseState // TypeDefIndex: 32105
{
	// Fields
	private SCameraPhotographRunner _photographRunner; // 0x130
	private CameraStateBlenderConfig _blenderCfg; // 0x138

	// Properties
	public SCameraPhotographRunner PhotographRunner { /* [XID] */ /* 0x0000000189916EB0-0x0000000189916ED0 */ get => default; } // 0x00000001840B8380-0x00000001840B8430 
	public override CameraStateBlenderConfig BlendCfg { /* [XID] */ /* 0x0000000189925DD0-0x0000000189925DF0 */ get => default; } // 0x00000001840B8680-0x00000001840B87A0 

	// Constructors
	public SCameraPhotographState() {} // 0x00000001840B85E0-0x00000001840B8680

	// Methods
	// [XID] // 0x000000018991E5D0-0x000000018991E5F0
	public override void RegisterRunner(ICameraStateRunner runner) {} // 0x00000001840B8430-0x00000001840B8510
	// [XID] // 0x000000018992D360-0x000000018992D380
	public override void UpdateByBlendSrc(ICameraState state) {} // 0x00000001840B8510-0x00000001840B85E0
}

