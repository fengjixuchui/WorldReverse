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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class HomeWorldLimitShopExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15724
{
	// Fields
	protected SimpleSafeUInt32 goodsIdRawNum; // 0x10
	protected SimpleSafeUInt32 itemIDRawNum; // 0x14
	protected SimpleSafeUInt32 poolIDRawNum; // 0x18
	protected HomeWorldLimitShopCondType _condition; // 0x1C
	protected SimpleSafeInt32 conditionParamRawNum; // 0x20
	protected SimpleSafeUInt32 buyLimitRawNum; // 0x24
	protected IdCountConfig[] _costItems; // 0x28
	protected SimpleSafeUInt32 weightRawNum; // 0x30

	// Properties
	public uint goodsId { /* [XID] */ /* 0x0000000189820BF0-0x0000000189820C10 */ get => default; /* [XID] */ /* 0x00000001898281C0-0x00000001898281E0 */ protected set {} } // 0x0000000181D26C20-0x0000000181D26CF0 0x0000000181D27E90-0x0000000181D27F70
	public uint itemID { /* [XID] */ /* 0x000000018982F480-0x000000018982F4A0 */ get => default; /* [XID] */ /* 0x0000000189836D30-0x0000000189836D50 */ protected set {} } // 0x0000000181D27B80-0x0000000181D27C50 0x0000000181D286B0-0x0000000181D28790
	public uint poolID { /* [XID] */ /* 0x000000018983E1C0-0x000000018983E1E0 */ get => default; /* [XID] */ /* 0x0000000189845950-0x0000000189845970 */ protected set {} } // 0x0000000181D26CF0-0x0000000181D26DC0 0x0000000181D28940-0x0000000181D28A20
	public HomeWorldLimitShopCondType condition { /* [XID] */ /* 0x000000018984CF60-0x000000018984CF80 */ get => default; /* [XID] */ /* 0x0000000189854000-0x0000000189854020 */ protected set {} } // 0x0000000181D27AE0-0x0000000181D27B80 0x0000000181D27D00-0x0000000181D27DB0
	public int conditionParam { /* [XID] */ /* 0x000000018985BA10-0x000000018985BA30 */ get => default; /* [XID] */ /* 0x0000000189862FF0-0x0000000189863010 */ protected set {} } // 0x0000000181D26950-0x0000000181D26A20 0x0000000181D28790-0x0000000181D28870
	public uint buyLimit { /* [XID] */ /* 0x000000018986A460-0x000000018986A480 */ get => default; /* [XID] */ /* 0x00000001898718B0-0x00000001898718D0 */ protected set {} } // 0x0000000181D28870-0x0000000181D28940 0x0000000181D26DC0-0x0000000181D26EA0
	public IdCountConfig[] costItems { /* [XID] */ /* 0x0000000189879170-0x0000000189879190 */ get => default; /* [XID] */ /* 0x0000000189880720-0x0000000189880740 */ protected set {} } // 0x0000000181D28A20-0x0000000181D28AC0 0x0000000181D27C50-0x0000000181D27D00
	public uint weight { /* [XID] */ /* 0x0000000189887CC0-0x0000000189887CE0 */ get => default; /* [XID] */ /* 0x000000018988F040-0x000000018988F060 */ protected set {} } // 0x0000000181D28C00-0x0000000181D28CD0 0x0000000181D27DB0-0x0000000181D27E90

	// Constructors
	public HomeWorldLimitShopExcelConfig() {} // 0x0000000181D28D70-0x0000000181D28DD0

	// Methods
	// [IDTag] // 0x0000000189896540-0x0000000189896580
	// [XID] // 0x0000000189896540-0x0000000189896580
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181D26EA0-0x0000000181D27520
	// [IDTag] // 0x00000001898A08B0-0x00000001898A08F0
	// [XID] // 0x00000001898A08B0-0x00000001898A08F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181D27520-0x0000000181D27AE0
	// [XID] // 0x00000001898AAEC0-0x00000001898AAEE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF244A */, bool useObjectPool = false /* Metadata: 0x00AF244E */) => default; // 0x0000000181D27F70-0x0000000181D286B0
	[BlackList] // 0x00000001898B27B0-0x00000001898B27F0
	// [XID] // 0x00000001898B27B0-0x00000001898B27F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D26A20-0x0000000181D26AC0
	[BlackList] // 0x00000001898BD3A0-0x00000001898BD3E0
	// [XID] // 0x00000001898BD3A0-0x00000001898BD3E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D26AC0-0x0000000181D26C20
	[BlackList] // 0x00000001898C7A80-0x00000001898C7AC0
	// [XID] // 0x00000001898C7A80-0x00000001898C7AC0
	public virtual void ReturnToObjectPool() {} // 0x0000000181D28CD0-0x0000000181D28D70
	[BlackList] // 0x00000001898D20F0-0x00000001898D2130
	// [XID] // 0x00000001898D20F0-0x00000001898D2130
	public virtual void OnPoolAllocated() {} // 0x0000000181D28B60-0x0000000181D28C00
	[BlackList] // 0x00000001898DCAF0-0x00000001898DCB30
	// [XID] // 0x00000001898DCAF0-0x00000001898DCB30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D28AC0-0x0000000181D28B60
}

