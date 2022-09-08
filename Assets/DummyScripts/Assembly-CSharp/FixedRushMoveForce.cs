/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FixedRushMoveForce : MoveVelocityForce // TypeDefIndex: 14694
{
	// Fields
	private Vector3 _targetPos; // 0x48
	private Vector3 _lastFramsPos; // 0x54
	private float _stuckedTime; // 0x60
	private const float _maxStuckedTime = 2f; // Metadata: 0x00AEBD8F
	private bool _enableForce; // 0x64
	private float _estimatedTime; // 0x68
	private float _estimatedDist; // 0x6C
	private float _forceDuration; // 0x70
	private bool _disableForceByAnimFirstFrame; // 0x74
	private float _coeff_k; // 0x78
	private bool _delayStop; // 0x7C
	private bool _isInFinishing; // 0x7D
	private SpeedChangeType _speedChangeType; // 0x80
	private HashSet<int> _animatorStringHash; // 0x88
	private Vector3 _originDir; // 0x90
	private float _finishingSpeed; // 0x9C
	private int _remoteCheckAnimatorStateDelay; // 0xA0
	private int _remoteCheckAnimatorStateCounter; // 0xA4
	private bool _checkAnimatorStateOnExitOnly; // 0xA8
	private bool _alreadyBeenInAnimatorStates; // 0xA9

	// Constructors
	public FixedRushMoveForce() {} // 0x0000000182470710-0x0000000182470840

	// Methods
	// [XID] // 0x0000000189759E60-0x0000000189759E80
	public override void SetForce(Vector3 dir, float attenuation, Vector3 tPos, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool disableForceByAnimFirstFrame, bool checkAnimatorStateOnExitOnly) {} // 0x000000018246EAF0-0x000000018246F010
	// [XID] // 0x0000000189761B80-0x0000000189761BA0
	public override void OnMove(float inDeltaTime, float ownerTimeScale) {} // 0x000000018246F1D0-0x0000000182470300
	// [XID] // 0x0000000189768ED0-0x0000000189768EF0
	private void StopForce() {} // 0x000000018246F120-0x000000018246F1D0
	// [XID] // 0x0000000189770630-0x0000000189770650
	public override bool IsInForce() => default; // 0x0000000182470550-0x0000000182470610
	// [XID] // 0x0000000189777D70-0x0000000189777D90
	public override void Stop() {} // 0x000000018246E9A0-0x000000018246EA40
	// [XID] // 0x000000018977F3C0-0x000000018977F3E0
	public override void Clear() {} // 0x000000018246F010-0x000000018246F0C0
	// [XID] // 0x0000000189786D80-0x0000000189786DA0
	public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000182470300-0x00000001824703F0
}

