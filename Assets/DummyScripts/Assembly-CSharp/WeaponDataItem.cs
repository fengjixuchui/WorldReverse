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

public sealed class WeaponDataItem : EquipDataItem // TypeDefIndex: 21457
{
	// Fields
	public Dictionary<SafeUInt32, SafeUInt32> affixLevelMap; // 0x98
	public uint subEntityID; // 0xA0
	public EquipEntityType weaponType; // 0xA4
	private AbilitySyncStateInfo _abilitySyncInfo; // 0xA8

	// Properties
	public AbilitySyncStateInfo abilitySyncInfo { /* [XID] */ /* 0x0000000189798D30-0x0000000189798D50 */ get => default; /* [XID] */ /* 0x000000018981E870-0x000000018981E890 */ set {} } // 0x00000001822F8E80-0x00000001822F8F30 0x00000001822F9080-0x00000001822F91D0
	public MapField<uint, uint> affixLevelMapField { /* [XID] */ /* 0x000000018983C2F0-0x000000018983C310 */ set {} } // 0x00000001822F91D0-0x00000001822F9460

	// Constructors
	public WeaponDataItem() {} // 0x00000001822F9640-0x00000001822F96B0

	// Methods
	// [XID] // 0x0000000189825D80-0x0000000189825DA0
	public WeaponItem GetBagItem() => default; // 0x00000001822F9580-0x00000001822F9640
	// [XID] // 0x000000018982D4C0-0x000000018982D4E0
	public void CheckAbilityNeedSyncFromServer(BaseEntity entity) {} // 0x00000001822F9460-0x00000001822F9580
	// [XID] // 0x0000000189834C10-0x0000000189834C30
	public void RefreshAbilitySyncStateInfo(BaseEntity entity) {} // 0x00000001822F8F30-0x00000001822F9080
}

