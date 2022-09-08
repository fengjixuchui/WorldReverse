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
public class ConfigModifierStackingOption : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17170
{
	// Fields
	private string _abilitySpecialName; // 0x10
	private UniqueModifierCond _uniqueModifierCondition; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxModifierNumForMultipleType; // 0x20
	private bool _enableMixedUnique; // 0x28

	// Properties
	public string abilitySpecialName { /* [XID] */ /* 0x000000018994DCE0-0x000000018994DD00 */ get => default; /* [XID] */ /* 0x000000018973BD80-0x000000018973BDA0 */ private set {} } // 0x00000001823CA440-0x00000001823CA4E0 0x00000001823C9A70-0x00000001823C9B20
	public UniqueModifierCond uniqueModifierCondition { /* [XID] */ /* 0x0000000189955400-0x0000000189955420 */ get => default; /* [XID] */ /* 0x000000018974B300-0x000000018974B320 */ private set {} } // 0x00000001823CB210-0x00000001823CB2B0 0x00000001823CB2B0-0x00000001823CB360
	public DynamicFloat maxModifierNumForMultipleType { /* [XID] */ /* 0x000000018995CBE0-0x000000018995CC00 */ get => default; /* [XID] */ /* 0x00000001897598E0-0x0000000189759900 */ private set {} } // 0x00000001823CB170-0x00000001823CB210 0x00000001823CACE0-0x00000001823CAD90
	public bool enableMixedUnique { /* [XID] */ /* 0x0000000189761530-0x0000000189761550 */ get => default; /* [XID] */ /* 0x00000001897687C0-0x00000001897687E0 */ private set {} } // 0x00000001823CB6C0-0x00000001823CB760 0x00000001823CA8B0-0x00000001823CA960

	// Constructors
	public ConfigModifierStackingOption() {} // 0x00000001823CBA90-0x00000001823CBB00

	// Methods
	// [XID] // 0x00000001899465C0-0x00000001899465E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823CB760-0x00000001823CB8B0
	// [XID] // 0x00000001897776F0-0x0000000189777710
	public void InitEmpty() {} // 0x00000001823CAD90-0x00000001823CAE70
	[BlackList] // 0x000000018977EDE0-0x000000018977EE20
	// [XID] // 0x000000018977EDE0-0x000000018977EE20
	public bool FromJson(JSONNode node) => default; // 0x00000001823CA960-0x00000001823CACE0
	// [XID] // 0x0000000189A18170-0x0000000189A18190
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001823C9B20-0x00000001823C9F90
	// [XID] // 0x0000000189790BF0-0x0000000189790C10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6571 */, bool useObjectPool = false /* Metadata: 0x00AF6575 */) => default; // 0x00000001823CAE70-0x00000001823CB170
	// [XID] // 0x00000001898B9460-0x00000001898B9480
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6576 */, bool useObjectPool = false /* Metadata: 0x00AF657A */) => default; // 0x00000001823CA4E0-0x00000001823CA8B0
	[BlackList] // 0x00000001897A0390-0x00000001897A03D0
	// [XID] // 0x00000001897A0390-0x00000001897A03D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001823C9F90-0x00000001823CA260
	// [XID] // 0x00000001897AA7E0-0x00000001897AA800
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823CB360-0x00000001823CB6C0
	[BlackList] // 0x00000001897B22D0-0x00000001897B2310
	// [XID] // 0x00000001897B22D0-0x00000001897B2310
	public virtual void AutoAllocTypeFields() {} // 0x00000001823CA260-0x00000001823CA300
	[BlackList] // 0x00000001897BD7A0-0x00000001897BD7E0
	// [XID] // 0x00000001897BD7A0-0x00000001897BD7E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001823CA300-0x00000001823CA440
	[BlackList] // 0x00000001897C8030-0x00000001897C8070
	// [XID] // 0x00000001897C8030-0x00000001897C8070
	public virtual void ReturnToObjectPool() {} // 0x00000001823CB9F0-0x00000001823CBA90
	[BlackList] // 0x00000001897D2410-0x00000001897D2450
	// [XID] // 0x00000001897D2410-0x00000001897D2450
	public virtual void OnPoolAllocated() {} // 0x00000001823CB950-0x00000001823CB9F0
	[BlackList] // 0x00000001897DCBD0-0x00000001897DCC10
	// [XID] // 0x00000001897DCBD0-0x00000001897DCC10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001823CB8B0-0x00000001823CB950
}

