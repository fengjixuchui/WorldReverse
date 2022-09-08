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
public class ConfigEquipReattach : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19025
{
	// Fields
	private string _equip; // 0x10
	private string _targetPoint; // 0x18
	private SimpleSafeFloat normalizeStartRawNum; // 0x20
	private SimpleSafeFloat normalizeEndRawNum; // 0x24

	// Properties
	public string equip { /* [XID] */ /* 0x00000001896E3E90-0x00000001896E3EB0 */ get => default; /* [XID] */ /* 0x00000001896EB260-0x00000001896EB280 */ private set {} } // 0x0000000182D48820-0x0000000182D488C0 0x0000000182D48BC0-0x0000000182D48C70
	public string targetPoint { /* [XID] */ /* 0x00000001896F25F0-0x00000001896F2610 */ get => default; /* [XID] */ /* 0x00000001896F9F90-0x00000001896F9FB0 */ private set {} } // 0x0000000182D47CA0-0x0000000182D47D40 0x0000000182D47BF0-0x0000000182D47CA0
	public float normalizeStart { /* [XID] */ /* 0x00000001897016A0-0x00000001897016C0 */ get => default; /* [XID] */ /* 0x0000000189708F00-0x0000000189708F20 */ private set {} } // 0x0000000182D47D40-0x0000000182D47E20 0x0000000182D47E20-0x0000000182D47F00
	public float normalizeEnd { /* [XID] */ /* 0x00000001897107D0-0x00000001897107F0 */ get => default; /* [XID] */ /* 0x0000000189717BD0-0x0000000189717BF0 */ private set {} } // 0x0000000182D482A0-0x0000000182D48380 0x0000000182D476B0-0x0000000182D47790

	// Constructors
	public ConfigEquipReattach() {} // 0x0000000182D492E0-0x0000000182D49390

	// Methods
	// [XID] // 0x000000018971F670-0x000000018971F690
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D48FC0-0x0000000182D49100
	// [XID] // 0x0000000189726BE0-0x0000000189726C00
	public void InitEmpty() {} // 0x0000000182D48700-0x0000000182D48820
	[BlackList] // 0x000000018972E170-0x000000018972E1B0
	// [XID] // 0x000000018972E170-0x000000018972E1B0
	public bool FromJson(JSONNode node) => default; // 0x0000000182D48380-0x0000000182D48700
	// [XID] // 0x0000000189738A10-0x0000000189738A30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D471E0-0x0000000182D476B0
	// [XID] // 0x0000000189740780-0x00000001897407A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7DF */, bool useObjectPool = false /* Metadata: 0x00AFB7E3 */) => default; // 0x0000000182D488C0-0x0000000182D48BC0
	// [XID] // 0x0000000189747A90-0x0000000189747AB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7E4 */, bool useObjectPool = false /* Metadata: 0x00AFB7E8 */) => default; // 0x0000000182D47F00-0x0000000182D482A0
	[BlackList] // 0x000000018974F250-0x000000018974F290
	// [XID] // 0x000000018974F250-0x000000018974F290
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D47790-0x0000000182D47A60
	// [XID] // 0x0000000189759660-0x0000000189759680
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D48C70-0x0000000182D48FC0
	[BlackList] // 0x0000000189761210-0x0000000189761250
	// [XID] // 0x0000000189761210-0x0000000189761250
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D47A60-0x0000000182D47B00
	[BlackList] // 0x000000018976B6C0-0x000000018976B700
	// [XID] // 0x000000018976B6C0-0x000000018976B700
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D47B00-0x0000000182D47BF0
	[BlackList] // 0x0000000189775C60-0x0000000189775CA0
	// [XID] // 0x0000000189775C60-0x0000000189775CA0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D49240-0x0000000182D492E0
	[BlackList] // 0x0000000189780360-0x00000001897803A0
	// [XID] // 0x0000000189780360-0x00000001897803A0
	public virtual void OnPoolAllocated() {} // 0x0000000182D491A0-0x0000000182D49240
	[BlackList] // 0x000000018978ABA0-0x000000018978ABE0
	// [XID] // 0x000000018978ABA0-0x000000018978ABE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D49100-0x0000000182D491A0
}

