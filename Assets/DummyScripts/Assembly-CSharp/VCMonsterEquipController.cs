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

public sealed class VCMonsterEquipController : VCBaseEquipController // TypeDefIndex: 11905
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B96E40-0x0000000189B96E60 */ get => default; } // 0x0000000183178B50-0x0000000183178BF0 

	// Constructors
	public VCMonsterEquipController() {} // 0x0000000183178AD0-0x0000000183178B50

	// Methods
	// [XID] // 0x0000000189B9E2B0-0x0000000189B9E2D0
	public override void Init() {} // 0x0000000183178220-0x0000000183178390
	// [XID] // 0x00000001899825F0-0x0000000189982610
	public override void Destroy() {} // 0x0000000183177B90-0x0000000183177D10
	// [XID] // 0x0000000189989D70-0x0000000189989D90
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183177300-0x00000001831773C0
	// [XID] // 0x00000001899FD690-0x00000001899FD6B0
	public void DetachAllEquipEntity() {} // 0x0000000183178390-0x00000001831784B0
	// [XID] // 0x0000000189999180-0x00000001899991A0
	protected override void UpdateEquipPartToAttachPoint(float deltaTime, EquipContent equipContent, bool with) {} // 0x00000001831773C0-0x00000001831774D0
	// [XID] // 0x00000001899A09D0-0x00000001899A09F0
	private void DoAttachEquipEntity(BaseEntity equipEntity, EquipContent equipContent) {} // 0x0000000183177640-0x0000000183177950
	// [XID] // 0x00000001899A84C0-0x00000001899A84E0
	private void AttachEquipEntity(BaseEntity equipEntity, EquipContent equipContent) {} // 0x0000000183177DA0-0x0000000183177F60
	// [XID] // 0x00000001899AFC90-0x00000001899AFCB0
	private void DetachEquipEntity(EquipContent equipPart) {} // 0x0000000183177F60-0x0000000183178190
	// [XID] // 0x00000001896034A0-0x00000001896034C0
	protected override EquipContent AttachEquipContent(ulong guid, GadgetEntity equipEntity, string name, string equipPart, VCBaseEquipController vcEquip) => default; // 0x00000001831784B0-0x00000001831785F0
	// [XID] // 0x00000001899BEB80-0x00000001899BEBA0
	protected override bool DetachPartFromAttachPoint(EquipContent equipPart) => default; // 0x00000001831770C0-0x0000000183177190
	// [XID] // 0x00000001899C65E0-0x00000001899C6600
	public override void PlaceEquip(string name, bool place, Vector3 pos, Quaternion rot) {} // 0x0000000183178700-0x00000001831789F0
	// [XID] // 0x0000000189619C30-0x0000000189619C50
	public override void SetForceAttachPointRealName(string partName, string realName) {} // 0x0000000183177190-0x0000000183177300
	// [XID] // 0x00000001899D5100-0x00000001899D5120
	public override void SetAuxTransEnable(string name, bool setEnable) {} // 0x0000000183177950-0x0000000183177B90
}

