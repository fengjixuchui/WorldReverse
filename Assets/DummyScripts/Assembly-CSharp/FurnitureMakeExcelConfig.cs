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
public class FurnitureMakeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15720
{
	// Fields
	protected SimpleSafeUInt32 configIDRawNum; // 0x10
	protected SimpleSafeUInt32 furnitureItemIDRawNum; // 0x14
	protected SimpleSafeUInt32 countRawNum; // 0x18
	protected SimpleSafeUInt32 expRawNum; // 0x1C
	protected IdCountConfig[] _materialItems; // 0x20
	protected SimpleSafeUInt32 makeTimeRawNum; // 0x28
	protected SimpleSafeUInt32 maxAccelerateTimeRawNum; // 0x2C
	protected SimpleSafeUInt32 quickFetchMaterialNumRawNum; // 0x30

	// Properties
	public uint configID { /* [XID] */ /* 0x0000000189BCDD60-0x0000000189BCDD80 */ get => default; /* [XID] */ /* 0x0000000189BD5250-0x0000000189BD5270 */ protected set {} } // 0x0000000183FD6D20-0x0000000183FD6DF0 0x0000000183FD68D0-0x0000000183FD69B0
	public uint furnitureItemID { /* [XID] */ /* 0x0000000189BDCDA0-0x0000000189BDCDC0 */ get => default; /* [XID] */ /* 0x00000001895E95F0-0x00000001895E9610 */ protected set {} } // 0x0000000183FD7BC0-0x0000000183FD7C90 0x0000000183FD7E40-0x0000000183FD7F20
	public uint count { /* [XID] */ /* 0x00000001895F0DA0-0x00000001895F0DC0 */ get => default; /* [XID] */ /* 0x00000001895F87B0-0x00000001895F87D0 */ protected set {} } // 0x0000000183FD8740-0x0000000183FD8810 0x0000000183FD7AE0-0x0000000183FD7BC0
	public uint exp { /* [XID] */ /* 0x00000001895FFC50-0x00000001895FFC70 */ get => default; /* [XID] */ /* 0x0000000189607400-0x0000000189607420 */ protected set {} } // 0x0000000183FD8810-0x0000000183FD88E0 0x0000000183FD7D60-0x0000000183FD7E40
	public IdCountConfig[] materialItems { /* [XID] */ /* 0x000000018960EE20-0x000000018960EE40 */ get => default; /* [XID] */ /* 0x0000000189616460-0x0000000189616480 */ protected set {} } // 0x0000000183FD88E0-0x0000000183FD8980 0x0000000183FD6BA0-0x0000000183FD6C50
	public uint makeTime { /* [XID] */ /* 0x000000018961DCF0-0x000000018961DD10 */ get => default; /* [XID] */ /* 0x0000000189625090-0x00000001896250B0 */ protected set {} } // 0x0000000183FD8AC0-0x0000000183FD8B90 0x0000000183FD8B90-0x0000000183FD8C70
	public uint maxAccelerateTime { /* [XID] */ /* 0x000000018962C910-0x000000018962C930 */ get => default; /* [XID] */ /* 0x0000000189634650-0x0000000189634670 */ protected set {} } // 0x0000000183FD7C90-0x0000000183FD7D60 0x0000000183FD7A00-0x0000000183FD7AE0
	public uint quickFetchMaterialNum { /* [XID] */ /* 0x000000018963BDA0-0x000000018963BDC0 */ get => default; /* [XID] */ /* 0x0000000189643480-0x00000001896434A0 */ protected set {} } // 0x0000000183FD6C50-0x0000000183FD6D20 0x0000000183FD8660-0x0000000183FD8740

	// Constructors
	public FurnitureMakeExcelConfig() {} // 0x0000000183FD8D10-0x0000000183FD8D70

	// Methods
	// [IDTag] // 0x000000018964AA60-0x000000018964AAA0
	// [XID] // 0x000000018964AA60-0x000000018964AAA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183FD73A0-0x0000000183FD7A00
	// [IDTag] // 0x00000001896553C0-0x0000000189655400
	// [XID] // 0x00000001896553C0-0x0000000189655400
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183FD6DF0-0x0000000183FD73A0
	// [XID] // 0x000000018965F900-0x000000018965F920
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF242C */, bool useObjectPool = false /* Metadata: 0x00AF2430 */) => default; // 0x0000000183FD7F20-0x0000000183FD8660
	[BlackList] // 0x0000000189667370-0x00000001896673B0
	// [XID] // 0x0000000189667370-0x00000001896673B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183FD69B0-0x0000000183FD6A50
	[BlackList] // 0x0000000189672060-0x00000001896720A0
	// [XID] // 0x0000000189672060-0x00000001896720A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183FD6A50-0x0000000183FD6BA0
	[BlackList] // 0x000000018967C780-0x000000018967C7C0
	// [XID] // 0x000000018967C780-0x000000018967C7C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183FD8C70-0x0000000183FD8D10
	[BlackList] // 0x0000000189686E10-0x0000000189686E50
	// [XID] // 0x0000000189686E10-0x0000000189686E50
	public virtual void OnPoolAllocated() {} // 0x0000000183FD8A20-0x0000000183FD8AC0
	[BlackList] // 0x0000000189691DF0-0x0000000189691E30
	// [XID] // 0x0000000189691DF0-0x0000000189691E30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183FD8980-0x0000000183FD8A20
}

