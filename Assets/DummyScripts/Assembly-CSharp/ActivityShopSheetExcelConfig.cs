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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ActivityShopSheetExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15192
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected bool _isAheadPreview; // 0x14
	protected LogicType _condComb; // 0x18
	protected uint _SheetNameTextMapHash; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ActivityShopSheetCond[] _cond; // 0x20
	protected SimpleSafeUInt32[] _sortLevel; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189971AC0-0x0000000189971AE0 */ get => default; /* [XID] */ /* 0x00000001899793B0-0x00000001899793D0 */ protected set {} } // 0x0000000182136460-0x0000000182136530 0x0000000182135860-0x0000000182135940
	public bool isAheadPreview { /* [XID] */ /* 0x00000001899804E0-0x0000000189980500 */ get => default; /* [XID] */ /* 0x0000000189987DF0-0x0000000189987E10 */ protected set {} } // 0x00000001821361E0-0x0000000182136280 0x00000001821357B0-0x0000000182135860
	public LogicType condComb { /* [XID] */ /* 0x000000018998F800-0x000000018998F820 */ get => default; /* [XID] */ /* 0x0000000189997260-0x0000000189997280 */ protected set {} } // 0x0000000182136280-0x0000000182136320 0x0000000182135FE0-0x0000000182136090
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint SheetNameTextMapHash { /* [XID] */ /* 0x000000018999EE70-0x000000018999EE90 */ get => default; /* [XID] */ /* 0x00000001899A6750-0x00000001899A6770 */ protected set {} } // 0x0000000182136090-0x0000000182136130 0x0000000182136130-0x00000001821361E0
	public string SheetName { /* [XID] */ /* 0x00000001899ADF20-0x00000001899ADF40 */ get => default; } // 0x0000000182136530-0x00000001821366B0 
	public ActivityShopSheetCond[] cond { /* [XID] */ /* 0x00000001899B5760-0x00000001899B5780 */ get => default; /* [XID] */ /* 0x00000001899BCF30-0x00000001899BCF50 */ protected set {} } // 0x0000000182135F40-0x0000000182135FE0 0x00000001821349B0-0x0000000182134A60
	public SimpleSafeUInt32[] sortLevel { /* [XID] */ /* 0x00000001899C48E0-0x00000001899C4900 */ get => default; /* [XID] */ /* 0x00000001899CC040-0x00000001899CC060 */ protected set {} } // 0x0000000182134A60-0x0000000182134B00 0x0000000182134900-0x00000001821349B0

	// Constructors
	public ActivityShopSheetExcelConfig() {} // 0x0000000182136750-0x00000001821367B0

	// Methods
	// [IDTag] // 0x00000001899D35D0-0x00000001899D3610
	// [XID] // 0x00000001899D35D0-0x00000001899D3610
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182134B00-0x00000001821351B0
	// [IDTag] // 0x00000001899DD9E0-0x00000001899DDA20
	// [XID] // 0x00000001899DD9E0-0x00000001899DDA20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001821351B0-0x00000001821357B0
	// [XID] // 0x00000001899E85E0-0x00000001899E8600
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0368 */, bool useObjectPool = false /* Metadata: 0x00AF036C */) => default; // 0x0000000182135940-0x0000000182135F40
	[BlackList] // 0x00000001899EFC10-0x00000001899EFC50
	// [XID] // 0x00000001899EFC10-0x00000001899EFC50
	public virtual void AutoAllocTypeFields() {} // 0x0000000182134780-0x0000000182134820
	[BlackList] // 0x00000001899FA210-0x00000001899FA250
	// [XID] // 0x00000001899FA210-0x00000001899FA250
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182134820-0x0000000182134900
	[BlackList] // 0x0000000189A046D0-0x0000000189A04710
	// [XID] // 0x0000000189A046D0-0x0000000189A04710
	public virtual void ReturnToObjectPool() {} // 0x00000001821366B0-0x0000000182136750
	[BlackList] // 0x0000000189A0ECB0-0x0000000189A0ECF0
	// [XID] // 0x0000000189A0ECB0-0x0000000189A0ECF0
	public virtual void OnPoolAllocated() {} // 0x00000001821363C0-0x0000000182136460
	[BlackList] // 0x0000000189A19230-0x0000000189A19270
	// [XID] // 0x0000000189A19230-0x0000000189A19270
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182136320-0x00000001821363C0
}

