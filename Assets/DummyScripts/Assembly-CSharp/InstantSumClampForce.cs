/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InstantSumClampForce : MoveVelocityForce // TypeDefIndex: 14690
{
	// Fields
	private float _maxV; // 0x48
	private Vector3 _lastFrameSumForce; // 0x4C
	private Vector3 _frameSumForce; // 0x58

	// Constructors
	public InstantSumClampForce() {} // 0x0000000183773270-0x00000001837732D0

	// Methods
	// [XID] // 0x00000001896F8EC0-0x00000001896F8EE0
	public override void Init(VelocityForceType forceType, int priority) {} // 0x0000000183772A30-0x0000000183772B60
	// [XID] // 0x0000000189700910-0x0000000189700930
	public override void OnMove(float inDeltaTime, float ownerTimeScale) {} // 0x0000000183772D20-0x0000000183772F30
	// [XID] // 0x0000000189707F80-0x0000000189707FA0
	public override void SetForce(Vector3 dir, float attenuation) {} // 0x0000000183772B60-0x0000000183772CC0
	// [XID] // 0x000000018970FA70-0x000000018970FA90
	public override bool IsInForce() => default; // 0x0000000183773030-0x00000001837731D0
	// [XID] // 0x0000000189716C30-0x0000000189716C50
	public override void Stop() {} // 0x00000001837728B0-0x00000001837729B0
}

