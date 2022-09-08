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

public sealed class LCAutoOpenDoor : LCBase // TypeDefIndex: 11694
{
	// Fields
	private bool _active; // 0x130
	private int _curState; // 0x134
	private float _checkTime; // 0x138
	private float _checkInterval; // 0x13C
	private float _sqrDistance; // 0x140
	private Animator _animator; // 0x148
	private Vector3 _curDoorPos; // 0x150
	private Vector3 _curDoorForward; // 0x15C
	private Vector3 _curAvatarDir; // 0x168

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018986C070-0x000000018986C090 */ get => default; } // 0x000000018542A690-0x000000018542A730 

	// Constructors
	public LCAutoOpenDoor() {} // Dummy constructor
	public LCAutoOpenDoor(float triggerDistance = 3f /* Metadata: 0x00AEA6E7 */, float checkInterval = 0.05f /* Metadata: 0x00AEA6EB */) {} // 0x000000018542A600-0x000000018542A690

	// Methods
	// [XID] // 0x0000000189873510-0x0000000189873530
	public override void Init() {} // 0x0000000185429FB0-0x000000018542A0B0
	// [XID] // 0x00000001896648D0-0x00000001896648F0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018542A230-0x000000018542A2F0
	// [XID] // 0x0000000189B00D80-0x0000000189B00DA0
	protected override void Tick(float inDeltaTime) {} // 0x000000018542A2F0-0x000000018542A600
	// [XID] // 0x0000000189673CB0-0x0000000189673CD0
	public bool IsDoorActive() => default; // 0x0000000185429EF0-0x0000000185429FB0
	// [XID] // 0x0000000189890BA0-0x0000000189890BC0
	public void SetDoorActive(bool bActive) {} // 0x000000018542A0B0-0x000000018542A1C0
	// [XID] // 0x000000018965D300-0x000000018965D320
	public void ResetDoorState() {} // 0x0000000185429D50-0x0000000185429E70
	// [XID] // 0x0000000189682C90-0x0000000189682CB0
	private void OnFieldEnter(BaseEntity other) {} // 0x0000000185429B90-0x0000000185429D50
	// [XID] // 0x00000001898A7060-0x00000001898A7080
	private void OnFieldExit(BaseEntity other) {} // 0x0000000185429A60-0x0000000185429B90
}

