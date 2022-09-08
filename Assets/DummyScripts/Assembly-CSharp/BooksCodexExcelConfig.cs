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
public class BooksCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15317
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 materialIdRawNum; // 0x14
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x18
	protected bool _isDisuse; // 0x1C

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189AD4EC0-0x0000000189AD4EE0 */ get => default; /* [XID] */ /* 0x0000000189ADC7A0-0x0000000189ADC7C0 */ protected set {} } // 0x0000000182A04490-0x0000000182A04560 0x0000000182A04AE0-0x0000000182A04BC0
	public uint materialId { /* [XID] */ /* 0x0000000189AE40F0-0x0000000189AE4110 */ get => default; /* [XID] */ /* 0x0000000189AEB950-0x0000000189AEB970 */ protected set {} } // 0x0000000182A043C0-0x0000000182A04490 0x0000000182A042E0-0x0000000182A043C0
	public uint SortOrder { /* [XID] */ /* 0x0000000189AF3330-0x0000000189AF3350 */ get => default; /* [XID] */ /* 0x0000000189AFAB60-0x0000000189AFAB80 */ protected set {} } // 0x0000000182A04560-0x0000000182A04630 0x0000000182A04200-0x0000000182A042E0
	public bool isDisuse { /* [XID] */ /* 0x0000000189B020F0-0x0000000189B02110 */ get => default; /* [XID] */ /* 0x0000000189B09530-0x0000000189B09550 */ protected set {} } // 0x0000000182A04BC0-0x0000000182A04C60 0x0000000182A04C60-0x0000000182A04D10

	// Constructors
	public BooksCodexExcelConfig() {} // 0x0000000182A04EF0-0x0000000182A04F50

	// Methods
	// [IDTag] // 0x0000000189B11090-0x0000000189B110D0
	// [XID] // 0x0000000189B11090-0x0000000189B110D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182A03B90-0x0000000182A03EE0
	// [IDTag] // 0x0000000189B1B280-0x0000000189B1B2C0
	// [XID] // 0x0000000189B1B280-0x0000000189B1B2C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182A03EE0-0x0000000182A04200
	// [XID] // 0x0000000189B25940-0x0000000189B25960
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF075E */, bool useObjectPool = false /* Metadata: 0x00AF0762 */) => default; // 0x0000000182A04630-0x0000000182A04AE0
	[BlackList] // 0x0000000189B2CD90-0x0000000189B2CDD0
	// [XID] // 0x0000000189B2CD90-0x0000000189B2CDD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A039F0-0x0000000182A03A90
	[BlackList] // 0x0000000189B37410-0x0000000189B37450
	// [XID] // 0x0000000189B37410-0x0000000189B37450
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A03A90-0x0000000182A03B90
	[BlackList] // 0x0000000189B41E70-0x0000000189B41EB0
	// [XID] // 0x0000000189B41E70-0x0000000189B41EB0
	public virtual void ReturnToObjectPool() {} // 0x0000000182A04E50-0x0000000182A04EF0
	[BlackList] // 0x0000000189B4C680-0x0000000189B4C6C0
	// [XID] // 0x0000000189B4C680-0x0000000189B4C6C0
	public virtual void OnPoolAllocated() {} // 0x0000000182A04DB0-0x0000000182A04E50
	[BlackList] // 0x0000000189B56E90-0x0000000189B56ED0
	// [XID] // 0x0000000189B56E90-0x0000000189B56ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A04D10-0x0000000182A04DB0
}

