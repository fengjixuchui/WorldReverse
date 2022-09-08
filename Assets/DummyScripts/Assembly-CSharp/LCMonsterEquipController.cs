/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCMonsterEquipController : LCBaseEquipController // TypeDefIndex: 11749
{
	// Fields
	public const float PICK_RANGE = 2f; // Metadata: 0x00AEA792
	public uint tryPickRuntimeID; // 0x168
	private bool hasWeapon; // 0x16C
	public readonly Vector3 defaultWeaponCreatePosition; // 0x170
	private Dictionary<uint, Tuple<ulong, WeaponDataItem>> weaponEntityIdDic; // 0x180

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189880D70-0x0000000189880D90 */ get => default; } // 0x0000000181C4BDE0-0x0000000181C4BE80 

	// Constructors
	public LCMonsterEquipController() {} // 0x0000000181C4BD30-0x0000000181C4BDE0

	// Methods
	// [XID] // 0x000000018985BF80-0x000000018985BFA0
	public override void Init() {} // 0x0000000181C49D70-0x0000000181C49E20
	// [XID] // 0x0000000189924470-0x0000000189924490
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181C4BC70-0x0000000181C4BD30
	// [XID] // 0x000000018992B9A0-0x000000018992B9C0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181C492F0-0x0000000181C493C0
	// [XID] // 0x000000018976EE10-0x000000018976EE30
	protected override void ClearEquips() {} // 0x0000000181C49920-0x0000000181C499F0
	// [XID] // 0x0000000189776A00-0x0000000189776A20
	private void InitEquips() {} // 0x0000000181C4A730-0x0000000181C4AC00
	// [XID] // 0x000000018977DE70-0x000000018977DE90
	private bool MonsterCreateEquip(uint gadgetID, uint entityID, AbilitySyncStateInfo abilitySyncInfo) => default; // 0x0000000181C4A300-0x0000000181C4A5E0
	// [XID] // 0x00000001897857C0-0x00000001897857E0
	private void MonsterEquipLoaded() {} // 0x0000000181C4AD00-0x0000000181C4ADA0
	// [XID] // 0x000000018978CCE0-0x000000018978CD00
	public override void OnEntityReady() {} // 0x0000000181C4BA40-0x0000000181C4BB60
	// [XID] // 0x0000000189A62740-0x0000000189A62760
	protected override GadgetEntity CreateEquip(uint entityId, ulong guid, uint configId, uint ownerRuntimeID, uint campID, TargetType targetType, bool anyncLoad = true /* Metadata: 0x00AEA790 */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x0000000181C49E20-0x0000000181C4A0A0
	// [XID] // 0x000000018979C550-0x000000018979C570
	public override bool AttachItem(ulong guid, string equipPart = null, bool showSub = true /* Metadata: 0x00AEA791 */) => default; // 0x0000000181C49500-0x0000000181C49920
	// [XID] // 0x0000000189B5D450-0x0000000189B5D470
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181C499F0-0x0000000181C49AF0
	// [XID] // 0x0000000189B9FC80-0x0000000189B9FCA0
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000181C4BB60-0x0000000181C4BC70
	// [XID] // 0x00000001897B2A90-0x00000001897B2AB0
	public void OnEvtPickUp() {} // 0x0000000181C49AF0-0x0000000181C49D00
	// [XID] // 0x00000001897BA560-0x00000001897BA580
	private void MonsterOnEquip(ConfigEquipment equipConfig) {} // 0x0000000181C490B0-0x0000000181C49220
	// [XID] // 0x00000001897C2440-0x00000001897C2460
	public override void PickUpItem(uint runtimeID) {} // 0x0000000181C4ADA0-0x0000000181C4B010
	// [XID] // 0x00000001897C9C20-0x00000001897C9C40
	private void OnEvtMonsterTryDropEquip(EvtMonsterTryDropEquip evt) {} // 0x0000000181C4A0A0-0x0000000181C4A300
	// [XID] // 0x00000001897D1290-0x00000001897D12B0
	public void OnAnimationEventTryDropAllEquips() {} // 0x0000000181C4B7F0-0x0000000181C4BA40
	// [XID] // 0x00000001897D92D0-0x00000001897D92F0
	public void UpdateWeaponData(List<MonsterDataItem.WeaponInfo> weaponInfoList, uint authorityPeerID) {} // 0x0000000181C4B010-0x0000000181C4B7F0
}

