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

public sealed class LCLoadingDoor : LCBase // TypeDefIndex: 11745
{
	// Fields
	public ConfigLoadingDoor config; // 0x130
	private LCTrigger _trigger; // 0x138
	private LCSimpleInteraction _inter; // 0x140
	private bool _active; // 0x148
	private float _checkTime; // 0x14C
	private uint _id; // 0x150
	private Coroutine exitCoroutine; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899E40C0-0x00000001899E40E0 */ get => default; } // 0x0000000183E0B150-0x0000000183E0B1F0 

	// Constructors
	public LCLoadingDoor() {} // Dummy constructor
	public LCLoadingDoor(uint id) {} // 0x0000000183E0B0D0-0x0000000183E0B150

	// Methods
	// [XID] // 0x00000001899F3260-0x00000001899F3280
	public override void Init() {} // 0x0000000183E0A3B0-0x0000000183E0A6B0
	// [XID] // 0x0000000189617ED0-0x0000000189617EF0
	protected override void Tick(float inDeltaTime) {} // 0x0000000183E0AF60-0x0000000183E0B0D0
	// [XID] // 0x0000000189AAD940-0x0000000189AAD960
	public override void OnDisable() {} // 0x0000000183E0AE20-0x0000000183E0AEC0
	// [XID] // 0x0000000189626E70-0x0000000189626E90
	public override void OnEnable() {} // 0x0000000183E0AEC0-0x0000000183E0AF60
	// [XID] // 0x0000000189AD1FA0-0x0000000189AD1FC0
	public override void Destroy() {} // 0x0000000183E09FA0-0x0000000183E0A1D0
	// [XID] // 0x0000000189636480-0x00000001896364A0
	private void StateIDChanged(EvtStateIDChanged evt) {} // 0x0000000183E0A2B0-0x0000000183E0A3B0
	// [XID] // 0x0000000189A26BB0-0x0000000189A26BD0
	private void OnUICallBack() {} // 0x0000000183E0A8E0-0x0000000183E0AA90
	// [XID] // 0x0000000189645060-0x0000000189645080
	private void OpenDoor() {} // 0x0000000183E09620-0x0000000183E099C0
	// [XID] // 0x000000018964CB20-0x000000018964CB40
	private void CloseDoor() {} // 0x0000000183E09250-0x0000000183E093B0
	// [XID] // 0x0000000189653F50-0x0000000189653F70
	private Vector3 GetAvatarPosition(AvatarEntity avatar) => default; // 0x0000000183E09AC0-0x0000000183E09D20
	// [XID] // 0x0000000189A35AA0-0x0000000189A35AC0
	private void OnDoorClosed() {} // 0x0000000183E0A6B0-0x0000000183E0A880
	// [XID] // 0x0000000189662CD0-0x0000000189662CF0
	private void StopExitCoroutine() {} // 0x0000000183E099C0-0x0000000183E09AC0
	// [XID] // 0x000000018966A830-0x000000018966A850
	private void OnFieldEnter(BaseEntity other) {} // 0x0000000183E09E80-0x0000000183E09F40
	// [XID] // 0x0000000189A88560-0x0000000189A88580
	private void OnFieldExit(BaseEntity other) {} // 0x0000000183E09D20-0x0000000183E09E80
	// [XID] // 0x0000000189A3D110-0x0000000189A3D130
	private void DoOnFieldExit() {} // 0x0000000183E0AD70-0x0000000183E0AE20
	// [XID] // 0x0000000189681460-0x0000000189681480
	private uint GetStandingRoom(Vector3 pos) => default; // 0x0000000183E0AB00-0x0000000183E0AD70
	// [XID] // 0x00000001899EB530-0x00000001899EB550
	private uint GetOppositeRoom(Vector3 pos) => default; // 0x0000000183E093B0-0x0000000183E09620
}

