/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMassiveElementTriggerAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17380
{
	// Fields
	private MassiveElementTriggerType _triggerType; // 0x10
	private ModifierStacking _stackType; // 0x14
	private SimpleSafeFloat reduceDurabilityRawNum; // 0x18
	private SimpleSafeFloat durationRawNum; // 0x1C
	private string _attackID; // 0x20
	private string _actionID; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onFlush; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onPreUpdate; // 0x38

	// Properties
	public MassiveElementTriggerType triggerType { /* [XID] */ /* 0x000000018966CD20-0x000000018966CD40 */ get => default; /* [XID] */ /* 0x0000000189674BB0-0x0000000189674BD0 */ private set {} } // 0x0000000184BE5F30-0x0000000184BE5FD0 0x0000000184BE5680-0x0000000184BE5730
	public ModifierStacking stackType { /* [XID] */ /* 0x000000018967C460-0x000000018967C480 */ get => default; /* [XID] */ /* 0x0000000189683AB0-0x0000000189683AD0 */ private set {} } // 0x0000000184BE6A70-0x0000000184BE6B10 0x0000000184BE55D0-0x0000000184BE5680
	public float reduceDurability { /* [XID] */ /* 0x000000018968B7F0-0x000000018968B810 */ get => default; /* [XID] */ /* 0x0000000189693380-0x00000001896933A0 */ private set {} } // 0x0000000184BE5E50-0x0000000184BE5F30 0x0000000184BE6400-0x0000000184BE64E0
	public float duration { /* [XID] */ /* 0x000000018969A5D0-0x000000018969A5F0 */ get => default; /* [XID] */ /* 0x00000001896A1F40-0x00000001896A1F60 */ private set {} } // 0x0000000184BE53A0-0x0000000184BE5480 0x0000000184BE5D70-0x0000000184BE5E50
	public string attackID { /* [XID] */ /* 0x00000001896A92A0-0x00000001896A92C0 */ get => default; /* [XID] */ /* 0x00000001896B03D0-0x00000001896B03F0 */ private set {} } // 0x0000000184BE5480-0x0000000184BE5520 0x0000000184BE5520-0x0000000184BE55D0
	public string actionID { /* [XID] */ /* 0x00000001896B7DD0-0x00000001896B7DF0 */ get => default; /* [XID] */ /* 0x00000001896BED70-0x00000001896BED90 */ private set {} } // 0x0000000184BE69D0-0x0000000184BE6A70 0x0000000184BE64E0-0x0000000184BE6590
	public ConfigAbilityAction[] onFlush { /* [XID] */ /* 0x00000001896C6710-0x00000001896C6730 */ get => default; /* [XID] */ /* 0x00000001896CDC70-0x00000001896CDC90 */ private set {} } // 0x0000000184BE6BC0-0x0000000184BE6C60 0x0000000184BE5FD0-0x0000000184BE6080
	public ConfigAbilityAction[] onPreUpdate { /* [XID] */ /* 0x00000001896D52E0-0x00000001896D5300 */ get => default; /* [XID] */ /* 0x00000001896DC840-0x00000001896DC860 */ private set {} } // 0x0000000184BE4E80-0x0000000184BE4F20 0x0000000184BE6B10-0x0000000184BE6BC0

	// Constructors
	public ConfigMassiveElementTriggerAction() {} // 0x0000000184BE75C0-0x0000000184BE7620

	// Methods
	// [XID] // 0x00000001896E4190-0x00000001896E41B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BE7230-0x0000000184BE73E0
	// [XID] // 0x00000001896EB640-0x00000001896EB660
	public void InitEmpty() {} // 0x0000000184BE6590-0x0000000184BE66D0
	[BlackList] // 0x00000001896F2A30-0x00000001896F2A70
	// [XID] // 0x00000001896F2A30-0x00000001896F2A70
	public bool FromJson(JSONNode node) => default; // 0x0000000184BE6080-0x0000000184BE6400
	// [XID] // 0x00000001896FD510-0x00000001896FD530
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184BE4610-0x0000000184BE4E80
	// [XID] // 0x0000000189704970-0x0000000189704990
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C61 */, bool useObjectPool = false /* Metadata: 0x00AF6C65 */) => default; // 0x0000000184BE66D0-0x0000000184BE69D0
	// [XID] // 0x000000018970C110-0x000000018970C130
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C66 */, bool useObjectPool = false /* Metadata: 0x00AF6C6A */) => default; // 0x0000000184BE5730-0x0000000184BE5D70
	[BlackList] // 0x0000000189713AE0-0x0000000189713B20
	// [XID] // 0x0000000189713AE0-0x0000000189713B20
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BE4F20-0x0000000184BE51F0
	// [XID] // 0x000000018971E140-0x000000018971E160
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BE6C60-0x0000000184BE7230
	[BlackList] // 0x00000001897256A0-0x00000001897256E0
	// [XID] // 0x00000001897256A0-0x00000001897256E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184BE51F0-0x0000000184BE5290
	[BlackList] // 0x000000018972FE00-0x000000018972FE40
	// [XID] // 0x000000018972FE00-0x000000018972FE40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184BE5290-0x0000000184BE53A0
	[BlackList] // 0x000000018973A310-0x000000018973A350
	// [XID] // 0x000000018973A310-0x000000018973A350
	public virtual void ReturnToObjectPool() {} // 0x0000000184BE7520-0x0000000184BE75C0
	[BlackList] // 0x0000000189744BF0-0x0000000189744C30
	// [XID] // 0x0000000189744BF0-0x0000000189744C30
	public virtual void OnPoolAllocated() {} // 0x0000000184BE7480-0x0000000184BE7520
	[BlackList] // 0x000000018974F550-0x000000018974F590
	// [XID] // 0x000000018974F550-0x000000018974F590
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184BE73E0-0x0000000184BE7480
}

