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
public class ConfigTDPlayTowerData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18124
{
	// Fields
	private TDPlayTowerType _towerType; // 0x10
	private SimpleSafeFloat damagePerLevelRawNum; // 0x14
	private SimpleSafeFloat elemMasteryPerLevelRawNum; // 0x18
	private SimpleSafeFloat elemMasteryPerPerStackRawNum; // 0x1C
	private SimpleSafeFloat damage_A_PerStackRawNum; // 0x20
	private SimpleSafeFloat damage_B_PerStackRawNum; // 0x24
	private SimpleSafeFloat attackSpeed_ARawNum; // 0x28
	private SimpleSafeFloat attackSpeed_BRawNum; // 0x2C
	private SimpleSafeFloat attackRange_ARawNum; // 0x30
	private SimpleSafeFloat attackRange_BRawNum; // 0x34

	// Properties
	public TDPlayTowerType towerType { /* [XID] */ /* 0x0000000189A248F0-0x0000000189A24910 */ get => default; /* [XID] */ /* 0x0000000189A2BEF0-0x0000000189A2BF10 */ private set {} } // 0x0000000185456460-0x0000000185456500 0x00000001854586D0-0x0000000185458780
	public float damagePerLevel { /* [XID] */ /* 0x0000000189A335E0-0x0000000189A33600 */ get => default; /* [XID] */ /* 0x0000000189A3ADC0-0x0000000189A3ADE0 */ private set {} } // 0x0000000185457BE0-0x0000000185457CC0 0x0000000185456ED0-0x0000000185456FB0
	public float elemMasteryPerLevel { /* [XID] */ /* 0x0000000189A42670-0x0000000189A42690 */ get => default; /* [XID] */ /* 0x0000000189A49C40-0x0000000189A49C60 */ private set {} } // 0x00000001854567A0-0x0000000185456880 0x00000001854574F0-0x00000001854575D0
	public float elemMasteryPerPerStack { /* [XID] */ /* 0x0000000189A51650-0x0000000189A51670 */ get => default; /* [XID] */ /* 0x0000000189A58CE0-0x0000000189A58D00 */ private set {} } // 0x0000000185458B80-0x0000000185458C60 0x0000000185457E80-0x0000000185457F60
	public float damage_A_PerStack { /* [XID] */ /* 0x0000000189A60640-0x0000000189A60660 */ get => default; /* [XID] */ /* 0x0000000189A68330-0x0000000189A68350 */ private set {} } // 0x0000000185456500-0x00000001854565E0 0x00000001854566C0-0x00000001854567A0
	public float damage_B_PerStack { /* [XID] */ /* 0x0000000189A6F700-0x0000000189A6F720 */ get => default; /* [XID] */ /* 0x0000000189A76E90-0x0000000189A76EB0 */ private set {} } // 0x00000001854565E0-0x00000001854566C0 0x0000000185458C60-0x0000000185458D40
	public float attackSpeed_A { /* [XID] */ /* 0x0000000189A7E9A0-0x0000000189A7E9C0 */ get => default; /* [XID] */ /* 0x0000000189A86210-0x0000000189A86230 */ private set {} } // 0x0000000185458780-0x0000000185458860 0x0000000185457410-0x00000001854574F0
	public float attackSpeed_B { /* [XID] */ /* 0x0000000189A8DB30-0x0000000189A8DB50 */ get => default; /* [XID] */ /* 0x0000000189A950F0-0x0000000189A95110 */ private set {} } // 0x0000000185457CC0-0x0000000185457DA0 0x0000000185457F60-0x0000000185458040
	public float attackRange_A { /* [XID] */ /* 0x0000000189A9C990-0x0000000189A9C9B0 */ get => default; /* [XID] */ /* 0x0000000189AA4140-0x0000000189AA4160 */ private set {} } // 0x0000000185457800-0x00000001854578E0 0x0000000185457720-0x0000000185457800
	public float attackRange_B { /* [XID] */ /* 0x0000000189AAB610-0x0000000189AAB630 */ get => default; /* [XID] */ /* 0x0000000189AB2FE0-0x0000000189AB3000 */ private set {} } // 0x0000000185457330-0x0000000185457410 0x0000000185457DA0-0x0000000185457E80

	// Constructors
	public ConfigTDPlayTowerData() {} // 0x0000000185458DE0-0x0000000185458EF0

	// Methods
	// [XID] // 0x0000000189ABAC70-0x0000000189ABAC90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185458860-0x0000000185458A40
	// [XID] // 0x0000000189AC24C0-0x0000000189AC24E0
	public void InitEmpty() {} // 0x00000001854575D0-0x0000000185457720
	[BlackList] // 0x0000000189AC9BC0-0x0000000189AC9C00
	// [XID] // 0x0000000189AC9BC0-0x0000000189AC9C00
	public bool FromJson(JSONNode node) => default; // 0x0000000185456FB0-0x0000000185457330
	// [XID] // 0x0000000189AD4820-0x0000000189AD4840
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001854554F0-0x0000000185455FA0
	// [XID] // 0x0000000189ADC120-0x0000000189ADC140
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BEF */, bool useObjectPool = false /* Metadata: 0x00AF8BF3 */) => default; // 0x00000001854578E0-0x0000000185457BE0
	// [XID] // 0x0000000189AE3B30-0x0000000189AE3B50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BF4 */, bool useObjectPool = false /* Metadata: 0x00AF8BF8 */) => default; // 0x0000000185456880-0x0000000185456ED0
	[BlackList] // 0x0000000189AEB370-0x0000000189AEB3B0
	// [XID] // 0x0000000189AEB370-0x0000000189AEB3B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185455FA0-0x0000000185456270
	// [XID] // 0x0000000189AF5BF0-0x0000000189AF5C10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185458040-0x00000001854586D0
	[BlackList] // 0x0000000189AFD110-0x0000000189AFD150
	// [XID] // 0x0000000189AFD110-0x0000000189AFD150
	public virtual void AutoAllocTypeFields() {} // 0x0000000185456270-0x0000000185456310
	[BlackList] // 0x0000000189B077F0-0x0000000189B07830
	// [XID] // 0x0000000189B077F0-0x0000000189B07830
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185456310-0x0000000185456460
	[BlackList] // 0x0000000189B120E0-0x0000000189B12120
	// [XID] // 0x0000000189B120E0-0x0000000189B12120
	public virtual void ReturnToObjectPool() {} // 0x0000000185458D40-0x0000000185458DE0
	[BlackList] // 0x0000000189B1C7D0-0x0000000189B1C810
	// [XID] // 0x0000000189B1C7D0-0x0000000189B1C810
	public virtual void OnPoolAllocated() {} // 0x0000000185458AE0-0x0000000185458B80
	[BlackList] // 0x0000000189B26DA0-0x0000000189B26DE0
	// [XID] // 0x0000000189B26DA0-0x0000000189B26DE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185458A40-0x0000000185458AE0
}

