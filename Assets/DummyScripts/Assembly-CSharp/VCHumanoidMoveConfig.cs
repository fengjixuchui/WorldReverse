/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCHumanoidMoveConfig // TypeDefIndex: 32185
{
	// Fields
	public bool enableRocketJump; // 0x10
	private const int ROCKET_JUMP_TYPE = 3; // Metadata: 0x00B14255
	private RocketJumpExt[] _rocketJumpExts; // 0x18
	private bool[] _rocketJumpBoolStack; // 0x20
	public float rocketJumpSettingXZMultiplierImp; // 0x28
	public float rocketJumpSettingYMultiplierImp; // 0x2C
	private float rocketJumpSettingXZMultiplierDefault; // 0x30
	private float rocketJumpSettingYMultiplierDefault; // 0x34
	public int[] configValues; // 0x38
	public bool[] configMethod; // 0x40

	// Properties
	public bool enableClimb { /* [XID] */ /* 0x0000000189B12D00-0x0000000189B12D20 */ get => default; } // 0x00000001848DED70-0x00000001848DEE40 
	public bool flyGroundDistCheck { /* [XID] */ /* 0x0000000189B1A390-0x0000000189B1A3B0 */ get => default; } // 0x00000001848DF740-0x00000001848DF810 
	public bool enableLand { /* [XID] */ /* 0x0000000189B21830-0x0000000189B21850 */ get => default; } // 0x00000001848DF670-0x00000001848DF740 
	public bool frozen { /* [XID] */ /* 0x0000000189692680-0x00000001896926A0 */ get => default; } // 0x00000001848DEE40-0x00000001848DEF10 
	public bool enableFly { /* [XID] */ /* 0x0000000189B30400-0x0000000189B30420 */ get => default; } // 0x00000001848DECA0-0x00000001848DED70 

	// Nested types
	public enum MovConfigs // TypeDefIndex: 32186
	{
		Climb = 0,
		FlyGroundDistCheck = 1,
		EnableLand = 2,
		Frozen = 3,
		EnableFly = 4
	}

	// Constructors
	public VCHumanoidMoveConfig() {} // 0x00000001848DF810-0x00000001848DFA40

	// Methods
	// [XID] // 0x0000000189B37D10-0x0000000189B37D30
	public void Reset() {} // 0x00000001848DEBB0-0x00000001848DECA0
	// [XID] // 0x0000000189B3F620-0x0000000189B3F640
	public void SetMoveConfig(MovConfigs config, bool enable) {} // 0x00000001848DEF10-0x00000001848DF0F0
	// [XID] // 0x0000000189AD0540-0x0000000189AD0560
	public void ResetRocketJump() {} // 0x00000001848DE930-0x00000001848DEAB0
	// [XID] // 0x00000001896616A0-0x00000001896616C0
	public void SetDefaultRocketJump(RocketJumpExt extension) {} // 0x00000001848DEAB0-0x00000001848DEBB0
	// [IDTag] // 0x0000000189B55E50-0x0000000189B55E90
	// [XID] // 0x0000000189B55E50-0x0000000189B55E90
	public void EnableRocketJump(bool enable, RocketJumpType type) {} // 0x00000001848DF4F0-0x00000001848DF670
	// [IDTag] // 0x0000000189B60840-0x0000000189B60880
	// [XID] // 0x0000000189B60840-0x0000000189B60880
	public void EnableRocketJump(bool enable, RocketJumpType type, RocketJumpExt extension) {} // 0x00000001848DF310-0x00000001848DF4F0
	// [XID] // 0x00000001895F8EA0-0x00000001895F8EC0
	private void CalRocketJumpImp() {} // 0x00000001848DF0F0-0x00000001848DF310
}

