/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterDataItem : DataItem // TypeDefIndex: 21462
{
	// Fields
	public uint configId; // 0x38
	public uint blockId; // 0x3C
	public uint blockHash; // 0x40
	public uint groupId; // 0x44
	public uint mapInstId; // 0x48
	public uint randomPoolId; // 0x4C
	public uint markFlag; // 0x50
	public uint titleId; // 0x54
	public uint specialNameId; // 0x58
	public LCAIBetaData aiData; // 0x60
	public List<WeaponInfo> weaponList; // 0x68
	public bool isElite; // 0x70
	public List<uint> affixList; // 0x78
	public uint summonTag; // 0x80
	public Dictionary<uint, int> summonTagMap; // 0x88

	// Nested types
	public struct WeaponInfo // TypeDefIndex: 21463
	{
		// Fields
		public uint gadgetID; // 0x00
		public uint entityID; // 0x04
		public AbilitySyncStateInfo abilitySyncInfo; // 0x08
	}

	// Constructors
	public MonsterDataItem() {} // 0x0000000183756600-0x0000000183756720

	// Methods
	// [XID] // 0x0000000189902030-0x0000000189902050
	protected override void ClearFightProps() {} // 0x0000000183756300-0x0000000183756520
	// [XID] // 0x0000000189909860-0x0000000189909880
	protected override void UpdateFightProp(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF840 */) {} // 0x0000000183755D40-0x0000000183755FC0
	// [XID] // 0x0000000189910E70-0x0000000189910E90
	public void UpdateWeaponList(RepeatedMessageField<SceneWeaponInfo> list) {} // 0x0000000183755B50-0x0000000183755D40
	// [XID] // 0x0000000189918990-0x00000001899189B0
	public void UpdateAffixList() {} // 0x00000001837559A0-0x0000000183755A40
	// [XID] // 0x0000000189920150-0x0000000189920170
	protected override void UpdateNormalProp(PropType type, double value, double lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF844 */) {} // 0x0000000183755FC0-0x00000001837561C0
	// [XID] // 0x0000000189888150-0x0000000189888170
	public void UpdateSummonTagMap(MapField<uint, uint> summonTagMap, bool doClear = false /* Metadata: 0x00AFF848 */) {} // 0x0000000183755510-0x00000001837559A0
	// [XID] // 0x000000018992F180-0x000000018992F1A0
	public override GroupEntityType TryGetGroupEntityType() => default; // 0x0000000183755A40-0x0000000183755AE0
	// [XID] // 0x0000000189936590-0x00000001899365B0
	public override uint TryGetGroupId() => default; // 0x0000000183756260-0x0000000183756300
	// [XID] // 0x000000018993DFF0-0x000000018993E010
	public override uint TryGetMapInstId() => default; // 0x00000001837561C0-0x0000000183756260
}

