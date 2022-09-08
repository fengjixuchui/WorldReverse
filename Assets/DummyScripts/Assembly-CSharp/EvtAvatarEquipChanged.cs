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

public sealed class EvtAvatarEquipChanged : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20064
{
	// Fields
	private OP _op; // 0x30
	private ulong _avatarGuid; // 0x38
	private ulong _equipGuid; // 0x40
	private EquipType _equipType; // 0x48
	public bool needVoice; // 0x4C
	private uint _avatarEntityID; // 0x50
	private bool _toOpenState; // 0x54

	// Properties
	public OP op { /* [XID] */ /* 0x00000001896D4E40-0x00000001896D4E60 */ get => default; } // 0x0000000185169EA0-0x0000000185169F40 
	public ulong avatarGuid { /* [XID] */ /* 0x00000001896DC4C0-0x00000001896DC4E0 */ get => default; } // 0x0000000185169DA0-0x0000000185169E40 
	public ulong equipGuid { /* [XID] */ /* 0x00000001896E3D30-0x00000001896E3D50 */ get => default; } // 0x0000000185169FA0-0x000000018516A040 
	public EquipType equipType { /* [XID] */ /* 0x00000001896EB0A0-0x00000001896EB0C0 */ get => default; } // 0x0000000185169C60-0x0000000185169D00 
	public uint avatarEntityID { /* [XID] */ /* 0x00000001896F2470-0x00000001896F2490 */ get => default; } // 0x0000000185169D00-0x0000000185169DA0 
	public bool toOpenState { /* [XID] */ /* 0x00000001896F9DB0-0x00000001896F9DD0 */ get => default; } // 0x0000000185169BC0-0x0000000185169C60 

	// Nested types
	public enum OP // TypeDefIndex: 20065
	{
		INVALID = -1,
		ON = 0,
		OFF = 1
	}

	// Constructors
	public EvtAvatarEquipChanged() {} // 0x000000018516A0E0-0x000000018516A150

	// Methods
	[BlackList] // 0x00000001896B62C0-0x00000001896B6300
	// [XID] // 0x00000001896B62C0-0x00000001896B6300
	public override void AutoAllocTypeFields() {} // 0x00000001851698B0-0x0000000185169950
	[BlackList] // 0x00000001896C0290-0x00000001896C02D0
	// [XID] // 0x00000001896C0290-0x00000001896C02D0
	public override void AutoRecycleTypeFields() {} // 0x0000000185169950-0x0000000185169A10
	[BlackList] // 0x00000001896CA750-0x00000001896CA790
	// [XID] // 0x00000001896CA750-0x00000001896CA790
	public override void ReturnToObjectPool() {} // 0x000000018516A040-0x000000018516A0E0
	// [XID] // 0x0000000189701580-0x00000001897015A0
	public void Init(uint targetID, OP pOp, ulong pAvatarGuid, ulong pEquipGuid, EquipType pEquipType, bool nv = false /* Metadata: 0x00AFD212 */, bool toOpenState = false /* Metadata: 0x00AFD213 */) {} // 0x0000000185169A70-0x0000000185169BC0
}

