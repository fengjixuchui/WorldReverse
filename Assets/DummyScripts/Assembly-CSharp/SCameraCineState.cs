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

public sealed class SCameraCineState : SCameraBaseState // TypeDefIndex: 32057
{
	// Fields
	public SCineType cineType; // 0x130
	private SCameraCineStateRunner _cineRunner; // 0x138

	// Properties
	public SCameraCineStateRunner CineRunner { /* [XID] */ /* 0x0000000189BC03C0-0x0000000189BC03E0 */ get => default; } // 0x0000000182B7D950-0x0000000182B7DA00 
	public override CameraStateBlenderConfig BlendCfg { /* [XID] */ /* 0x00000001898CB360-0x00000001898CB380 */ get => default; } // 0x0000000182B7E060-0x0000000182B7E120 

	// Constructors
	public SCameraCineState() {} // 0x0000000182B7DFE0-0x0000000182B7E060

	// Methods
	// [XID] // 0x00000001898C3AE0-0x00000001898C3B00
	public override void RegisterRunner(ICameraStateRunner runner) {} // 0x0000000182B7DE40-0x0000000182B7DF20
	// [XID] // 0x00000001898D2A60-0x00000001898D2A80
	public override void OnBlendFromStart() {} // 0x0000000182B7DC00-0x0000000182B7DCC0
	// [XID] // 0x00000001898DA420-0x00000001898DA440
	public override void OnBlendFromFinished() {} // 0x0000000182B7DB20-0x0000000182B7DC00
	// [XID] // 0x00000001898E20F0-0x00000001898E2110
	public override void OnBlendToStart() {} // 0x0000000182B7DD80-0x0000000182B7DE40
	// [XID] // 0x00000001898E9C90-0x00000001898E9CB0
	public override void OnBlendToFinished() {} // 0x0000000182B7DCC0-0x0000000182B7DD80
	// [XID] // 0x00000001898F13F0-0x00000001898F1410
	public override void UpdateByBlendSrc(ICameraState state) {} // 0x0000000182B7DF20-0x0000000182B7DFE0
}

