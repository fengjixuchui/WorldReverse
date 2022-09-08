/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtForceQuitStoryCamera : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20116
{
	// Fields
	private float _duration; // 0x30
	private float _lerpRatio; // 0x34
	private StoryCameraLerpPattern _lerpPattern; // 0x38

	// Properties
	public float duration { /* [XID] */ /* 0x0000000189A82EE0-0x0000000189A82F00 */ get => default; } // 0x00000001832BDD00-0x00000001832BDDB0 
	public float lerpRatio { /* [XID] */ /* 0x0000000189A8A7E0-0x0000000189A8A800 */ get => default; } // 0x00000001832BDF70-0x00000001832BE020 
	public StoryCameraLerpPattern lerpPattern { /* [XID] */ /* 0x0000000189A920E0-0x0000000189A92100 */ get => default; } // 0x00000001832BDDB0-0x00000001832BDE50 

	// Constructors
	public EvtForceQuitStoryCamera() {} // 0x00000001832BE260-0x00000001832BE2E0

	// Methods
	[BlackList] // 0x0000000189A634F0-0x0000000189A63530
	// [XID] // 0x0000000189A634F0-0x0000000189A63530
	public override void AutoAllocTypeFields() {} // 0x00000001832BDBA0-0x00000001832BDC40
	[BlackList] // 0x0000000189A6DC60-0x0000000189A6DCA0
	// [XID] // 0x0000000189A6DC60-0x0000000189A6DCA0
	public override void AutoRecycleTypeFields() {} // 0x00000001832BDC40-0x00000001832BDD00
	[BlackList] // 0x0000000189A786C0-0x0000000189A78700
	// [XID] // 0x0000000189A786C0-0x0000000189A78700
	public override void ReturnToObjectPool() {} // 0x00000001832BE1C0-0x00000001832BE260
	// [XID] // 0x0000000189A99A80-0x0000000189A99AA0
	public new void Init(uint targetID) {} // 0x00000001832BDEB0-0x00000001832BDF70
	// [XID] // 0x0000000189AA0AA0-0x0000000189AA0AC0
	public void InitParam(float duration, float lerpRatio, StoryCameraLerpPattern lerpPattern) {} // 0x00000001832BE080-0x00000001832BE160
}

