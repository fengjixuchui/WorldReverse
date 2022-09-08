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
public class ConfigEquipment : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18070
{
	// Fields
	private string _attachTo; // 0x10
	private SimpleSafeUInt32 subGadgetIdRawNum; // 0x18
	private string _subAttachTo; // 0x20
	private string _auxToTrans; // 0x28
	private EquipEntityType _equipEntityType; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBladeElementFx _bladeFx; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBowData _bowData; // 0x40

	// Properties
	public string attachTo { /* [XID] */ /* 0x00000001899B52E0-0x00000001899B5300 */ get => default; /* [XID] */ /* 0x00000001899BC950-0x00000001899BC970 */ private set {} } // 0x00000001833451F0-0x0000000183345290 0x0000000183343A60-0x0000000183343B10
	public uint subGadgetId { /* [XID] */ /* 0x0000000189B80AE0-0x0000000189B80B00 */ get => default; /* [XID] */ /* 0x00000001899CBBC0-0x00000001899CBBE0 */ private set {} } // 0x0000000183344010-0x00000001833440E0 0x0000000183343BB0-0x0000000183343C90
	public string subAttachTo { /* [XID] */ /* 0x00000001899D2FF0-0x00000001899D3010 */ get => default; /* [XID] */ /* 0x00000001899DA5E0-0x00000001899DA600 */ private set {} } // 0x0000000183343B10-0x0000000183343BB0 0x0000000183344860-0x0000000183344910
	public string auxToTrans { /* [XID] */ /* 0x0000000189BCB4A0-0x0000000189BCB4C0 */ get => default; /* [XID] */ /* 0x00000001899E9540-0x00000001899E9560 */ private set {} } // 0x0000000183344910-0x00000001833449B0 0x00000001833447B0-0x0000000183344860
	public EquipEntityType equipEntityType { /* [XID] */ /* 0x00000001899F0BD0-0x00000001899F0BF0 */ get => default; /* [XID] */ /* 0x00000001899F84B0-0x00000001899F84D0 */ private set {} } // 0x00000001833442C0-0x0000000183344360 0x00000001833432E0-0x0000000183343390
	public ConfigBladeElementFx bladeFx { /* [XID] */ /* 0x00000001899FFA80-0x00000001899FFAA0 */ get => default; /* [XID] */ /* 0x0000000189A072D0-0x0000000189A072F0 */ private set {} } // 0x0000000183344710-0x00000001833447B0 0x0000000183343390-0x0000000183343440
	public ConfigBowData bowData { /* [XID] */ /* 0x0000000189A0E850-0x0000000189A0E870 */ get => default; /* [XID] */ /* 0x0000000189A15EA0-0x0000000189A15EC0 */ private set {} } // 0x00000001833440E0-0x0000000183344180 0x0000000183344660-0x0000000183344710

	// Constructors
	public ConfigEquipment() {} // 0x0000000183345330-0x0000000183345390

	// Methods
	// [XID] // 0x0000000189A1D420-0x0000000189A1D440
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183344F00-0x00000001833450B0
	// [XID] // 0x0000000189A24910-0x0000000189A24930
	public void InitEmpty() {} // 0x0000000183344180-0x00000001833442C0
	[BlackList] // 0x0000000189A2BF10-0x0000000189A2BF50
	// [XID] // 0x0000000189A2BF10-0x0000000189A2BF50
	public bool FromJson(JSONNode node) => default; // 0x0000000183343C90-0x0000000183344010
	// [XID] // 0x0000000189A36970-0x0000000189A36990
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183342640-0x0000000183342DA0
	// [XID] // 0x0000000189A3DF70-0x0000000189A3DF90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89EF */, bool useObjectPool = false /* Metadata: 0x00AF89F3 */) => default; // 0x0000000183344360-0x0000000183344660
	// [XID] // 0x0000000189A45720-0x0000000189A45740
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89F4 */, bool useObjectPool = false /* Metadata: 0x00AF89F8 */) => default; // 0x0000000183343440-0x0000000183343A60
	[BlackList] // 0x0000000189A4CD20-0x0000000189A4CD60
	// [XID] // 0x0000000189A4CD20-0x0000000189A4CD60
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183342DA0-0x0000000183343070
	// [XID] // 0x0000000189A574D0-0x0000000189A574F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833449B0-0x0000000183344F00
	[BlackList] // 0x0000000189A5EF90-0x0000000189A5EFD0
	// [XID] // 0x0000000189A5EF90-0x0000000189A5EFD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183343070-0x0000000183343110
	[BlackList] // 0x0000000189A69C30-0x0000000189A69C70
	// [XID] // 0x0000000189A69C30-0x0000000189A69C70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183343110-0x00000001833432E0
	[BlackList] // 0x0000000189A74010-0x0000000189A74050
	// [XID] // 0x0000000189A74010-0x0000000189A74050
	public virtual void ReturnToObjectPool() {} // 0x0000000183345290-0x0000000183345330
	[BlackList] // 0x0000000189A7E9C0-0x0000000189A7EA00
	// [XID] // 0x0000000189A7E9C0-0x0000000189A7EA00
	public virtual void OnPoolAllocated() {} // 0x0000000183345150-0x00000001833451F0
	[BlackList] // 0x0000000189A894B0-0x0000000189A894F0
	// [XID] // 0x0000000189A894B0-0x0000000189A894F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833450B0-0x0000000183345150
}

