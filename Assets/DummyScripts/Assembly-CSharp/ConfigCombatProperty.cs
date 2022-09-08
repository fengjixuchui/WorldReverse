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
public class ConfigCombatProperty : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17685
{
	// Fields
	private EndureType _endureType; // 0x10
	private bool _useCreatorProperty; // 0x14
	private CombatPropertyIndex[] _useCreatorPropertyPartly; // 0x18
	private bool _useCreatorBuffedProperty; // 0x20
	private bool _useAbilityProperty; // 0x21
	private SimpleSafeFloat HPRawNum; // 0x24
	private SimpleSafeFloat attackRawNum; // 0x28
	private SimpleSafeFloat defenseRawNum; // 0x2C
	private SimpleSafeFloat weightRawNum; // 0x30
	private SimpleSafeFloat endureShakeRawNum; // 0x34
	private bool _isInvincible; // 0x38
	private bool _isLockHP; // 0x39
	private bool _isGhostToAllied; // 0x3A
	private bool _isGhostToEnemy; // 0x3B
	private bool _canTriggerBullet; // 0x3C
	private bool _denyElementStick; // 0x3D
	private bool _ignorePurgeRate; // 0x3E
	private bool _ignoreDamageToSelf; // 0x3F

	// Properties
	public EndureType endureType { /* [XID] */ /* 0x0000000189BB4980-0x0000000189BB49A0 */ get => default; /* [XID] */ /* 0x00000001899BC990-0x00000001899BC9B0 */ private set {} } // 0x000000018462FAB0-0x000000018462FB50 0x00000001846309A0-0x0000000184630A50
	public bool useCreatorProperty { /* [XID] */ /* 0x00000001899C43C0-0x00000001899C43E0 */ get => default; /* [XID] */ /* 0x00000001899CBC20-0x00000001899CBC40 */ private set {} } // 0x000000018462FCA0-0x000000018462FD40 0x000000018462F300-0x000000018462F3B0
	public CombatPropertyIndex[] useCreatorPropertyPartly { /* [XID] */ /* 0x00000001899D3110-0x00000001899D3130 */ get => default; /* [XID] */ /* 0x00000001899DA700-0x00000001899DA720 */ private set {} } // 0x000000018462EDA0-0x000000018462EE40 0x000000018462F250-0x000000018462F300
	public bool useCreatorBuffedProperty { /* [XID] */ /* 0x00000001899E2120-0x00000001899E2140 */ get => default; /* [XID] */ /* 0x00000001899E9600-0x00000001899E9620 */ private set {} } // 0x0000000184631000-0x00000001846310A0 0x000000018462E9F0-0x000000018462EAA0
	public bool useAbilityProperty { /* [XID] */ /* 0x00000001899F0C70-0x00000001899F0C90 */ get => default; /* [XID] */ /* 0x00000001899F84F0-0x00000001899F8510 */ private set {} } // 0x000000018462F8B0-0x000000018462F950 0x000000018462F950-0x000000018462FA00
	public float HP { /* [XID] */ /* 0x0000000189603580-0x00000001896035A0 */ get => default; /* [XID] */ /* 0x0000000189A072F0-0x0000000189A07310 */ private set {} } // 0x0000000184630810-0x00000001846308F0 0x000000018462C1B0-0x000000018462C290
	public float attack { /* [XID] */ /* 0x00000001896211D0-0x00000001896211F0 */ get => default; /* [XID] */ /* 0x0000000189A15F80-0x0000000189A15FA0 */ private set {} } // 0x000000018462ECC0-0x000000018462EDA0 0x0000000184630F20-0x0000000184631000
	public float defense { /* [XID] */ /* 0x0000000189628A40-0x0000000189628A60 */ get => default; /* [XID] */ /* 0x0000000189A249D0-0x0000000189A249F0 */ private set {} } // 0x000000018462EF80-0x000000018462F060 0x000000018462D730-0x000000018462D810
	public float weight { /* [XID] */ /* 0x0000000189638000-0x0000000189638020 */ get => default; /* [XID] */ /* 0x0000000189A33720-0x0000000189A33740 */ private set {} } // 0x0000000184630E40-0x0000000184630F20 0x000000018462EAA0-0x000000018462EB80
	public float endureShake { /* [XID] */ /* 0x000000018967B580-0x000000018967B5A0 */ get => default; /* [XID] */ /* 0x0000000189A42770-0x0000000189A42790 */ private set {} } // 0x000000018462C0D0-0x000000018462C1B0 0x000000018462D810-0x000000018462D8F0
	public bool isInvincible { /* [XID] */ /* 0x0000000189682CD0-0x0000000189682CF0 */ get => default; /* [XID] */ /* 0x0000000189A516D0-0x0000000189A516F0 */ private set {} } // 0x000000018462EE40-0x000000018462EEE0 0x000000018462F3B0-0x000000018462F460
	public bool isLockHP { /* [XID] */ /* 0x0000000189A58DA0-0x0000000189A58DC0 */ get => default; /* [XID] */ /* 0x0000000189A60700-0x0000000189A60720 */ private set {} } // 0x000000018462EB80-0x000000018462EC20 0x000000018462F460-0x000000018462F510
	public bool isGhostToAllied { /* [XID] */ /* 0x0000000189A68510-0x0000000189A68530 */ get => default; /* [XID] */ /* 0x0000000189A6F860-0x0000000189A6F880 */ private set {} } // 0x000000018462EC20-0x000000018462ECC0 0x000000018462DA40-0x000000018462DAF0
	public bool isGhostToEnemy { /* [XID] */ /* 0x0000000189A77010-0x0000000189A77030 */ get => default; /* [XID] */ /* 0x0000000189A7EA60-0x0000000189A7EA80 */ private set {} } // 0x000000018462F810-0x000000018462F8B0 0x00000001846308F0-0x00000001846309A0
	public bool canTriggerBullet { /* [XID] */ /* 0x0000000189A862D0-0x0000000189A862F0 */ get => default; /* [XID] */ /* 0x0000000189A8DC50-0x0000000189A8DC70 */ private set {} } // 0x000000018462D9A0-0x000000018462DA40 0x000000018462D8F0-0x000000018462D9A0
	public bool denyElementStick { /* [XID] */ /* 0x00000001896C5930-0x00000001896C5950 */ get => default; /* [XID] */ /* 0x0000000189A9CA50-0x0000000189A9CA70 */ private set {} } // 0x000000018462FC00-0x000000018462FCA0 0x000000018462E5C0-0x000000018462E670
	public bool ignorePurgeRate { /* [XID] */ /* 0x0000000189AA4260-0x0000000189AA4280 */ get => default; /* [XID] */ /* 0x0000000189AAB6F0-0x0000000189AAB710 */ private set {} } // 0x000000018462F060-0x000000018462F100 0x000000018462FA00-0x000000018462FAB0
	public bool ignoreDamageToSelf { /* [XID] */ /* 0x00000001896DEDE0-0x00000001896DEE00 */ get => default; /* [XID] */ /* 0x0000000189ABAD30-0x0000000189ABAD50 */ private set {} } // 0x000000018462EEE0-0x000000018462EF80 0x000000018462FB50-0x000000018462FC00

	// Constructors
	public ConfigCombatProperty() {} // 0x0000000184631140-0x0000000184631200

	// Methods
	// [XID] // 0x0000000189BAD140-0x0000000189BAD160
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184630A50-0x0000000184630D00
	// [XID] // 0x0000000189AC9CA0-0x0000000189AC9CC0
	public void InitEmpty() {} // 0x000000018462F100-0x000000018462F250
	[BlackList] // 0x0000000189AD1510-0x0000000189AD1550
	// [XID] // 0x0000000189AD1510-0x0000000189AD1550
	public bool FromJson(JSONNode node) => default; // 0x000000018462E670-0x000000018462E9F0
	// [XID] // 0x0000000189ADC1C0-0x0000000189ADC1E0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018462C290-0x000000018462D280
	// [XID] // 0x0000000189AE3B90-0x0000000189AE3BB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77AB */, bool useObjectPool = false /* Metadata: 0x00AF77AF */) => default; // 0x000000018462F510-0x000000018462F810
	// [XID] // 0x0000000189AEB430-0x0000000189AEB450
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77B0 */, bool useObjectPool = false /* Metadata: 0x00AF77B4 */) => default; // 0x000000018462DAF0-0x000000018462E5C0
	[BlackList] // 0x0000000189AF2DD0-0x0000000189AF2E10
	// [XID] // 0x0000000189AF2DD0-0x0000000189AF2E10
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018462D280-0x000000018462D550
	// [XID] // 0x0000000189AFD270-0x0000000189AFD290
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018462FD40-0x0000000184630810
	[BlackList] // 0x0000000189B04A40-0x0000000189B04A80
	// [XID] // 0x0000000189B04A40-0x0000000189B04A80
	public virtual void AutoAllocTypeFields() {} // 0x000000018462D550-0x000000018462D5F0
	[BlackList] // 0x0000000189B0F170-0x0000000189B0F1B0
	// [XID] // 0x0000000189B0F170-0x0000000189B0F1B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018462D5F0-0x000000018462D730
	[BlackList] // 0x0000000189B194F0-0x0000000189B19530
	// [XID] // 0x0000000189B194F0-0x0000000189B19530
	public virtual void ReturnToObjectPool() {} // 0x00000001846310A0-0x0000000184631140
	[BlackList] // 0x0000000189B23E40-0x0000000189B23E80
	// [XID] // 0x0000000189B23E40-0x0000000189B23E80
	public virtual void OnPoolAllocated() {} // 0x0000000184630DA0-0x0000000184630E40
	[BlackList] // 0x0000000189B2E070-0x0000000189B2E0B0
	// [XID] // 0x0000000189B2E070-0x0000000189B2E0B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184630D00-0x0000000184630DA0
}

