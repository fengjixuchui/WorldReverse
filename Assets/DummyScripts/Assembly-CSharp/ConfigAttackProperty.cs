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
public class ConfigAttackProperty : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17670
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damagePercentage; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damagePercentageRatio; // 0x18
	private ElementType _elementType; // 0x20
	private SimpleSafeFloat elementRankRawNum; // 0x24
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _elementDurability; // 0x28
	private bool _overrideByWeapon; // 0x30
	private bool _ignoreAttackerProperty; // 0x31
	private StrikeType _strikeType; // 0x34
	private SimpleSafeFloat enBreakRawNum; // 0x38
	private SimpleSafeFloat enHeadBreakRawNum; // 0x3C
	private AttackType _attackType; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damageExtra; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _bonusCritical; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _bonusCriticalHurt; // 0x58
	private bool _ignoreLevelDiff; // 0x60
	private bool _trueDamage; // 0x61

	// Properties
	public DynamicFloat damagePercentage { /* [XID] */ /* 0x0000000189879800-0x0000000189879820 */ get => default; /* [XID] */ /* 0x000000018985DD90-0x000000018985DDB0 */ private set {} } // 0x0000000184AABDF0-0x0000000184AABE90 0x0000000184AAA1B0-0x0000000184AAA260
	public DynamicFloat damagePercentageRatio { /* [XID] */ /* 0x0000000189880E10-0x0000000189880E30 */ get => default; /* [XID] */ /* 0x000000018986CC70-0x000000018986CC90 */ private set {} } // 0x0000000184AA94E0-0x0000000184AA9580 0x0000000184AAA790-0x0000000184AAA840
	public ElementType elementType { /* [XID] */ /* 0x0000000189874100-0x0000000189874120 */ get => default; /* [XID] */ /* 0x000000018987BC20-0x000000018987BC40 */ private set {} } // 0x0000000184AA9580-0x0000000184AA9620 0x0000000184AAAE90-0x0000000184AAAF40
	public float elementRank { /* [XID] */ /* 0x0000000189882DB0-0x0000000189882DD0 */ get => default; /* [XID] */ /* 0x000000018988A610-0x000000018988A630 */ private set {} } // 0x0000000184AA9BC0-0x0000000184AA9CA0 0x0000000184AAA3B0-0x0000000184AAA490
	public DynamicFloat elementDurability { /* [XID] */ /* 0x000000018989CB40-0x000000018989CB60 */ get => default; /* [XID] */ /* 0x0000000189899390-0x00000001898993B0 */ private set {} } // 0x0000000184AAACA0-0x0000000184AAAD40 0x0000000184AAA260-0x0000000184AAA310
	public bool overrideByWeapon { /* [XID] */ /* 0x00000001898A0630-0x00000001898A0650 */ get => default; /* [XID] */ /* 0x00000001898A7CB0-0x00000001898A7CD0 */ private set {} } // 0x0000000184AAAF40-0x0000000184AAAFE0 0x0000000184AAA490-0x0000000184AAA540
	public bool ignoreAttackerProperty { /* [XID] */ /* 0x00000001898A4300-0x00000001898A4320 */ get => default; /* [XID] */ /* 0x00000001898B6D30-0x00000001898B6D50 */ private set {} } // 0x0000000184AAAD40-0x0000000184AAADE0 0x0000000184AABD40-0x0000000184AABDF0
	public StrikeType strikeType { /* [XID] */ /* 0x00000001898BE460-0x00000001898BE480 */ get => default; /* [XID] */ /* 0x00000001898C5C70-0x00000001898C5C90 */ private set {} } // 0x0000000184AAB080-0x0000000184AAB120 0x0000000184AAA840-0x0000000184AAA8F0
	public float enBreak { /* [XID] */ /* 0x00000001898B2E00-0x00000001898B2E20 */ get => default; /* [XID] */ /* 0x00000001898D4CB0-0x00000001898D4CD0 */ private set {} } // 0x0000000184AAA0D0-0x0000000184AAA1B0 0x0000000184AABC60-0x0000000184AABD40
	public float enHeadBreak { /* [XID] */ /* 0x00000001898DC790-0x00000001898DC7B0 */ get => default; /* [XID] */ /* 0x00000001898E41C0-0x00000001898E41E0 */ private set {} } // 0x0000000184AAA540-0x0000000184AAA620 0x0000000184AA8620-0x0000000184AA8700
	public AttackType attackType { /* [XID] */ /* 0x00000001898C1F80-0x00000001898C1FA0 */ get => default; /* [XID] */ /* 0x00000001898F34E0-0x00000001898F3500 */ private set {} } // 0x0000000184AAA310-0x0000000184AAA3B0 0x0000000184AA8910-0x0000000184AA89C0
	public DynamicFloat damageExtra { /* [XID] */ /* 0x00000001898FAAA0-0x00000001898FAAC0 */ get => default; /* [XID] */ /* 0x0000000189902640-0x0000000189902660 */ private set {} } // 0x0000000184AAAFE0-0x0000000184AAB080 0x0000000184AAADE0-0x0000000184AAAE90
	public DynamicFloat bonusCritical { /* [XID] */ /* 0x0000000189909C20-0x0000000189909C40 */ get => default; /* [XID] */ /* 0x0000000189911460-0x0000000189911480 */ private set {} } // 0x0000000184AA7CF0-0x0000000184AA7D90 0x0000000184AA9CA0-0x0000000184AA9D50
	public DynamicFloat bonusCriticalHurt { /* [XID] */ /* 0x00000001898D8790-0x00000001898D87B0 */ get => default; /* [XID] */ /* 0x00000001899205D0-0x00000001899205F0 */ private set {} } // 0x0000000184AA8700-0x0000000184AA87A0 0x0000000184AA7D90-0x0000000184AA7E40
	public bool ignoreLevelDiff { /* [XID] */ /* 0x00000001898E0580-0x00000001898E05A0 */ get => default; /* [XID] */ /* 0x000000018992F5A0-0x000000018992F5C0 */ private set {} } // 0x0000000184AA6DB0-0x0000000184AA6E50 0x0000000184AAA8F0-0x0000000184AAA9A0
	public bool trueDamage { /* [XID] */ /* 0x0000000189936A30-0x0000000189936A50 */ get => default; /* [XID] */ /* 0x000000018993E550-0x000000018993E570 */ private set {} } // 0x0000000184AAB120-0x0000000184AAB1C0 0x0000000184AA8570-0x0000000184AA8620

	// Constructors
	public ConfigAttackProperty() {} // 0x0000000184AAC360-0x0000000184AAC480

	// Methods
	// [XID] // 0x0000000189872040-0x0000000189872060
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AABE90-0x0000000184AAC180
	// [XID] // 0x000000018994D090-0x000000018994D0B0
	public void Copy(ConfigAttackProperty other) {} // 0x0000000184AA9620-0x0000000184AA9BC0
	// [XID] // 0x00000001899547E0-0x0000000189954800
	public void Reset() {} // 0x0000000184AA87A0-0x0000000184AA8910
	// [XID] // 0x000000018995C080-0x000000018995C0A0
	public void InitEmpty() {} // 0x0000000184AAA620-0x0000000184AAA790
	[BlackList] // 0x0000000189963AC0-0x0000000189963B00
	// [XID] // 0x0000000189963AC0-0x0000000189963B00
	public bool FromJson(JSONNode node) => default; // 0x0000000184AA9D50-0x0000000184AAA0D0
	// [XID] // 0x000000018996DEE0-0x000000018996DF00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184AA6E50-0x0000000184AA7CF0
	// [XID] // 0x0000000189975AB0-0x0000000189975AD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7711 */, bool useObjectPool = false /* Metadata: 0x00AF7715 */) => default; // 0x0000000184AAA9A0-0x0000000184AAACA0
	// [XID] // 0x000000018997CA70-0x000000018997CA90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7716 */, bool useObjectPool = false /* Metadata: 0x00AF771A */) => default; // 0x0000000184AA89C0-0x0000000184AA94E0
	[BlackList] // 0x0000000189984870-0x00000001899848B0
	// [XID] // 0x0000000189984870-0x00000001899848B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AA7E40-0x0000000184AA8110
	// [XID] // 0x000000018998F4C0-0x000000018998F4E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AAB1C0-0x0000000184AABC60
	[BlackList] // 0x0000000189996E80-0x0000000189996EC0
	// [XID] // 0x0000000189996E80-0x0000000189996EC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AA8110-0x0000000184AA81B0
	[BlackList] // 0x00000001899A1A10-0x00000001899A1A50
	// [XID] // 0x00000001899A1A10-0x00000001899A1A50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AA81B0-0x0000000184AA8570
	[BlackList] // 0x00000001899AC590-0x00000001899AC5D0
	// [XID] // 0x00000001899AC590-0x00000001899AC5D0
	public virtual void ReturnToObjectPool() {} // 0x0000000184AAC2C0-0x0000000184AAC360
	[BlackList] // 0x00000001899B68F0-0x00000001899B6930
	// [XID] // 0x00000001899B68F0-0x00000001899B6930
	public virtual void OnPoolAllocated() {} // 0x0000000184AAC220-0x0000000184AAC2C0
	[BlackList] // 0x00000001899C1330-0x00000001899C1370
	// [XID] // 0x00000001899C1330-0x00000001899C1370
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184AAC180-0x0000000184AAC220
}

