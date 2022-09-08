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
public class FindHilichurlAssignmentExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15131
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 indexRawNum; // 0x14
	protected SimpleSafeUInt32 dayIndexRawNum; // 0x18
	protected SimpleSafeUInt32 questIDRawNum; // 0x1C
	protected FindHilichurlAssignmentType _assignmentType; // 0x20
	protected string _keyWord; // 0x28
	protected SimpleSafeUInt32 hintSubQuestIdRawNum; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AECEC0-0x0000000189AECEE0 */ get => default; /* [XID] */ /* 0x0000000189AF47F0-0x0000000189AF4810 */ protected set {} } // 0x0000000182A61880-0x0000000182A61950 0x0000000182A608D0-0x0000000182A609B0
	public uint index { /* [XID] */ /* 0x0000000189AFBE60-0x0000000189AFBE80 */ get => default; /* [XID] */ /* 0x0000000189B03710-0x0000000189B03730 */ protected set {} } // 0x0000000182A609B0-0x0000000182A60A80 0x0000000182A611E0-0x0000000182A612C0
	public uint dayIndex { /* [XID] */ /* 0x0000000189B0AE40-0x0000000189B0AE60 */ get => default; /* [XID] */ /* 0x0000000189B126C0-0x0000000189B126E0 */ protected set {} } // 0x0000000182A60A80-0x0000000182A60B50 0x0000000182A607F0-0x0000000182A608D0
	public uint questID { /* [XID] */ /* 0x0000000189B19A30-0x0000000189B19A50 */ get => default; /* [XID] */ /* 0x0000000189B20F90-0x0000000189B20FB0 */ protected set {} } // 0x0000000182A615D0-0x0000000182A616A0 0x0000000182A614F0-0x0000000182A615D0
	public FindHilichurlAssignmentType assignmentType { /* [XID] */ /* 0x0000000189B286D0-0x0000000189B286F0 */ get => default; /* [XID] */ /* 0x0000000189B2FAF0-0x0000000189B2FB10 */ protected set {} } // 0x0000000182A616A0-0x0000000182A61740 0x0000000182A61440-0x0000000182A614F0
	public string keyWord { /* [XID] */ /* 0x0000000189B374D0-0x0000000189B374F0 */ get => default; /* [XID] */ /* 0x0000000189B3ED40-0x0000000189B3ED60 */ protected set {} } // 0x0000000182A5FDF0-0x0000000182A5FE90 0x0000000182A612C0-0x0000000182A61370
	public uint hintSubQuestId { /* [XID] */ /* 0x0000000189B46800-0x0000000189B46820 */ get => default; /* [XID] */ /* 0x0000000189B4DD40-0x0000000189B4DD60 */ protected set {} } // 0x0000000182A61370-0x0000000182A61440 0x0000000182A5FD10-0x0000000182A5FDF0

	// Constructors
	public FindHilichurlAssignmentExcelConfig() {} // 0x0000000182A619F0-0x0000000182A61A50

	// Methods
	// [IDTag] // 0x0000000189B555F0-0x0000000189B55630
	// [XID] // 0x0000000189B555F0-0x0000000189B55630
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182A60330-0x0000000182A607F0
	// [IDTag] // 0x0000000189B600C0-0x0000000189B60100
	// [XID] // 0x0000000189B600C0-0x0000000189B60100
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182A5FE90-0x0000000182A60330
	// [XID] // 0x0000000189B6A5F0-0x0000000189B6A610
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF01A3 */, bool useObjectPool = false /* Metadata: 0x00AF01A7 */) => default; // 0x0000000182A60B50-0x0000000182A611E0
	[BlackList] // 0x0000000189B71D70-0x0000000189B71DB0
	// [XID] // 0x0000000189B71D70-0x0000000189B71DB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A5FB40-0x0000000182A5FBE0
	[BlackList] // 0x0000000189B7C070-0x0000000189B7C0B0
	// [XID] // 0x0000000189B7C070-0x0000000189B7C0B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A5FBE0-0x0000000182A5FD10
	[BlackList] // 0x0000000189B86A60-0x0000000189B86AA0
	// [XID] // 0x0000000189B86A60-0x0000000189B86AA0
	public virtual void ReturnToObjectPool() {} // 0x0000000182A61950-0x0000000182A619F0
	[BlackList] // 0x0000000189B90E70-0x0000000189B90EB0
	// [XID] // 0x0000000189B90E70-0x0000000189B90EB0
	public virtual void OnPoolAllocated() {} // 0x0000000182A617E0-0x0000000182A61880
	[BlackList] // 0x0000000189B9B120-0x0000000189B9B160
	// [XID] // 0x0000000189B9B120-0x0000000189B9B160
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A61740-0x0000000182A617E0
}

