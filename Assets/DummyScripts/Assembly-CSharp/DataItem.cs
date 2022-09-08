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

public abstract class DataItem // TypeDefIndex: 21453
{
	// Fields
	protected Dictionary<SafeUInt32, SafeDouble> _cacheNormalPropValueDic; // 0x18
	protected Dictionary<SafeUInt32, SafeFloat> _cacheFightPropValueDic; // 0x20
	private bool _isToBeRemoved; // 0x28
	private bool _unCacheEntity; // 0x29
	public JsonClimateType climateType; // 0x2C
	public uint climateAreaID; // 0x30

	// Properties
	public virtual uint entityId { /* [XID] */ /* 0x000000018971ACA0-0x000000018971ACE0 */ get; /* [XID] */ /* 0x0000000189725000-0x0000000189725040 */ set; } // 0x0000000182DB4190-0x0000000182DB41F0 0x0000000182DB4130-0x0000000182DB4190

	// Constructors
	protected DataItem() {} // 0x0000000182DB5C30-0x0000000182DB5CB0

	// Methods
	// [XID] // 0x000000018972F750-0x000000018972F770
	public void SetToBeRemoved() {} // 0x0000000182DB39C0-0x0000000182DB3A60
	// [XID] // 0x00000001897371C0-0x00000001897371E0
	public bool IsToBeRemove() => default; // 0x0000000182DB5320-0x0000000182DB53C0
	// [XID] // 0x000000018973ED20-0x000000018973ED40
	public bool NeedRemoveEntity() => default; // 0x0000000182DB50F0-0x0000000182DB5190
	// [XID] // 0x0000000189745FA0-0x0000000189745FC0
	public virtual void ReInit(bool unCacheEntity = false /* Metadata: 0x00AFF7FE */) {} // 0x0000000182DB4660-0x0000000182DB4710
	// [XID] // 0x000000018974DA50-0x000000018974DA70
	public virtual void Clear() {} // 0x0000000182DB45B0-0x0000000182DB4660
	// [XID] // 0x000000018963AC90-0x000000018963ACB0
	public virtual void HandleFightProp(uint type, float value, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF7FF */) {} // 0x0000000182DB41F0-0x0000000182DB45B0
	// [XID] // 0x000000018975C230-0x000000018975C250
	public virtual void HandleNormalProp(uint type, long value, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF803 */) {} // 0x0000000182DB5460-0x0000000182DB5850
	protected abstract void UpdateNormalProp(PropType type, double value, double lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF807 */);
	protected abstract void UpdateFightProp(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF80B */);
	// [XID] // 0x0000000189763BE0-0x0000000189763C00
	protected virtual void ClearNormalProps() {} // 0x0000000182DB3B20-0x0000000182DB3BE0
	// [XID] // 0x000000018962B970-0x000000018962B990
	protected virtual void ClearFightProps() {} // 0x0000000182DB5B70-0x0000000182DB5C30
	// [XID] // 0x0000000189772A00-0x0000000189772A20
	public double GetNormalPropValue(PropType type) => default; // 0x0000000182DB5190-0x0000000182DB5320
	// [XID] // 0x000000018977A080-0x000000018977A0A0
	public float GetFightPropValue(FightPropType type) => default; // 0x0000000182DB4710-0x0000000182DB48A0
	// [XID] // 0x000000018979A510-0x000000018979A530
	public virtual void RefreshAllProps() {} // 0x0000000182DB3BE0-0x0000000182DB4130
	// [IDTag] // 0x0000000189789140-0x0000000189789180
	// [XID] // 0x0000000189789140-0x0000000189789180
	public void HandleNormalProps(MapField<uint, PropValue> propMap, bool doClear = false /* Metadata: 0x00AFF80F */, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF810 */) {} // 0x0000000182DB4B20-0x0000000182DB4DC0
	// [XID] // 0x00000001897935E0-0x0000000189793600
	public void HandleNormalPropsList(RepeatedMessageField<PropPair> propList, bool doClear = false /* Metadata: 0x00AFF814 */, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF815 */) {} // 0x0000000182DB5850-0x0000000182DB5AD0
	// [IDTag] // 0x000000018979B7F0-0x000000018979B830
	// [XID] // 0x000000018979B7F0-0x000000018979B830
	public void HandleNormalProps(MapField<uint, long> propMap, bool doClear = false /* Metadata: 0x00AFF819 */, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF81A */) {} // 0x0000000182DB48A0-0x0000000182DB4B20
	// [XID] // 0x00000001897A5FE0-0x00000001897A6000
	public virtual void HandleFightProps(MapField<uint, float> propMap, bool doClear = false /* Metadata: 0x00AFF81E */, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF81F */) {} // 0x0000000182DB36B0-0x0000000182DB3920
	// [XID] // 0x00000001897AD4B0-0x00000001897AD4D0
	public virtual void HandleFightPropsList(RepeatedMessageField<FightPropPair> propList, bool doClear = false /* Metadata: 0x00AFF823 */, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF824 */) {} // 0x0000000182DB4E80-0x0000000182DB50F0
	// [XID] // 0x00000001897B55D0-0x00000001897B55F0
	public virtual void HandleFightPropChange(FightPropType type, EntityFightPropChangeReasonNotify reason) {} // 0x0000000182DB3A60-0x0000000182DB3B20
	// [XID] // 0x00000001897BD1B0-0x00000001897BD1D0
	public virtual void HandleNormalPropChange(PropType type, float value) {} // 0x0000000182DB4DC0-0x0000000182DB4E80
	// [XID] // 0x00000001897C4540-0x00000001897C4560
	public virtual GroupEntityType TryGetGroupEntityType() => default; // 0x0000000182DB3920-0x0000000182DB39C0
	// [XID] // 0x00000001897CBD30-0x00000001897CBD50
	public virtual uint TryGetGroupId() => default; // 0x0000000182DB5AD0-0x0000000182DB5B70
	// [XID] // 0x00000001897D3760-0x00000001897D3780
	public virtual uint TryGetMapInstId() => default; // 0x0000000182DB53C0-0x0000000182DB5460
	// [XID] // 0x000000018966F260-0x000000018966F280
	private void CheckOnHpChangeCallback() {} // 0x0000000182DB3530-0x0000000182DB36B0
}

