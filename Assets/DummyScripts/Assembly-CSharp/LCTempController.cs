/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCTempController : LCBase // TypeDefIndex: 11773
{
	// Fields
	private VCBaseInputController _inputController; // 0x130
	private VCBaseMove _moveComponent; // 0x138
	private bool _inPlayerControl; // 0x140
	private Action _controlFinishCB; // 0x148
	private Action<float> _controlUpdateCB; // 0x150
	private Vector3 _targetDir; // 0x158
	private float _stopTime; // 0x164
	private float _runDistance; // 0x168
	private Vector3 _startPos; // 0x16C
	private VCMoveData.MotionFlag _moveFlag; // 0x178
	private float _controlTime; // 0x17C
	private NormalTimer _overTimer; // 0x180
	private NormalTimer _waitTimer; // 0x188
	private float _lastMoveDistance; // 0x190
	private float _moveDeltaTime; // 0x194

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A26AF0-0x0000000189A26B10 */ get => default; } // 0x0000000181EE0D00-0x0000000181EE0DA0 

	// Constructors
	public LCTempController() {} // 0x0000000181EE0C50-0x0000000181EE0D00

	// Methods
	// [XID] // 0x0000000189A2E080-0x0000000189A2E0A0
	public override void PreInit() {} // 0x0000000181EE0A90-0x0000000181EE0B60
	// [XID] // 0x0000000189A359E0-0x0000000189A35A00
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181EE0B60-0x0000000181EE0C50
	// [XID] // 0x0000000189A3CF90-0x0000000189A3CFB0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181EDF4F0-0x0000000181EDF5C0
	// [XID] // 0x00000001897C9DA0-0x00000001897C9DC0
	public override void Destroy() {} // 0x0000000181EDFCC0-0x0000000181EDFD80
	// [XID] // 0x00000001898D9FD0-0x00000001898D9FF0
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181EE0780-0x0000000181EE0890
	// [XID] // 0x0000000189A53670-0x0000000189A53690
	private void ClearComponent() {} // 0x0000000181EE02B0-0x0000000181EE0410
	// [XID] // 0x0000000189A5ADC0-0x0000000189A5ADE0
	private void StopControl() {} // 0x0000000181EE0410-0x0000000181EE06C0
	// [XID] // 0x0000000189A62620-0x0000000189A62640
	public void GotoPoint(Vector3 pos, Action callback, Action<float> updateCB) {} // 0x0000000181EDFD80-0x0000000181EE02B0
	// [XID] // 0x0000000189A6A420-0x0000000189A6A440
	public void MoveDirect(Vector3 targetPos, float len, bool changeState, bool isWalk) {} // 0x0000000181EE0900-0x0000000181EE0A20
	// [XID] // 0x0000000189A71830-0x0000000189A71850
	private void UpdateMove(float inDeltaTime) {} // 0x0000000181EDF640-0x0000000181EDFCC0
}

