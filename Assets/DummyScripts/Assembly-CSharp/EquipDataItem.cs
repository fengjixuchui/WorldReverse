/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EquipDataItem : UniqueDataItem // TypeDefIndex: 21455
{
	// Fields
	public SafeUInt32 level; // 0x40
	public SafeUInt32 promoteLevel; // 0x50
	public uint itemId; // 0x60
	public SafeUInt32 configId; // 0x68
	public bool isLocal; // 0x78
	public ulong avatarGuid; // 0x80
	public EquipType equipType; // 0x88
	public BagItem bagItem; // 0x90

	// Properties
	public override uint entityId { /* [XID] */ /* 0x00000001897F1C90-0x00000001897F1CB0 */ get => default; /* [XID] */ /* 0x00000001897F9490-0x00000001897F94B0 */ set {} } // 0x000000018352E710-0x000000018352E7C0 0x000000018352E480-0x000000018352E630

	// Constructors
	public EquipDataItem() {} // 0x000000018352E980-0x000000018352E9F0

	// Methods
	// [XID] // 0x0000000189800AB0-0x0000000189800AD0
	protected override void UpdateNormalProp(PropType type, double value, double lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF830 */) {} // 0x000000018352E830-0x000000018352E910
	// [XID] // 0x0000000189808000-0x0000000189808020
	protected override void UpdateFightProp(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF834 */) {} // 0x000000018352E630-0x000000018352E710
}

