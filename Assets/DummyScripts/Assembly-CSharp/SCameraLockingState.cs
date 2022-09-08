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

public sealed class SCameraLockingState : SCameraBaseState // TypeDefIndex: 32087
{
	// Fields
	private SCameraLockingStateRunner _lockingRunner; // 0x130
	private CameraStateBlenderConfig _blenderCfg; // 0x138

	// Properties
	public SCameraLockingStateRunner LockingRunner { /* [XID] */ /* 0x0000000189889B20-0x0000000189889B40 */ get => default; } // 0x0000000182F67A90-0x0000000182F67B40 
	public override CameraStateBlenderConfig BlendCfg { /* [XID] */ /* 0x0000000189898700-0x0000000189898720 */ get => default; } // 0x0000000182F67E50-0x0000000182F67F70 

	// Constructors
	public SCameraLockingState() {} // 0x0000000182F67DB0-0x0000000182F67E50

	// Methods
	// [XID] // 0x0000000189891120-0x0000000189891140
	public override void RegisterRunner(ICameraStateRunner runner) {} // 0x0000000182F67C00-0x0000000182F67CE0
	// [XID] // 0x000000018989F920-0x000000018989F940
	public void RefreshCombatSetting(double deltaTime) {} // 0x0000000182F67B40-0x0000000182F67C00
	// [XID] // 0x00000001898A7300-0x00000001898A7320
	public override void UpdateByBlendSrc(ICameraState state) {} // 0x0000000182F67CE0-0x0000000182F67DB0
}

