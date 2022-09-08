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
public class FeatureTagGroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15605
{
	// Fields
	protected SimpleSafeUInt32 groupIDRawNum; // 0x10
	protected SimpleSafeUInt32[] _tagIDs; // 0x18

	// Properties
	public uint groupID { /* [XID] */ /* 0x000000018993D1B0-0x000000018993D1D0 */ get => default; /* [XID] */ /* 0x0000000189944900-0x0000000189944920 */ protected set {} } // 0x0000000182DBD2C0-0x0000000182DBD390 0x0000000182DBC650-0x0000000182DBC730
	public SimpleSafeUInt32[] tagIDs { /* [XID] */ /* 0x000000018994BE60-0x000000018994BE80 */ get => default; /* [XID] */ /* 0x0000000189953530-0x0000000189953550 */ protected set {} } // 0x0000000182DBCE00-0x0000000182DBCEA0 0x0000000182DBCEA0-0x0000000182DBCF50

	// Constructors
	public FeatureTagGroupExcelConfig() {} // 0x0000000182DBD570-0x0000000182DBD5D0

	// Methods
	// [IDTag] // 0x000000018995ACF0-0x000000018995AD30
	// [XID] // 0x000000018995ACF0-0x000000018995AD30
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182DBCA70-0x0000000182DBCE00
	// [IDTag] // 0x0000000189965670-0x00000001899656B0
	// [XID] // 0x0000000189965670-0x00000001899656B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182DBC730-0x0000000182DBCA70
	// [XID] // 0x000000018996FA40-0x000000018996FA60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF205B */, bool useObjectPool = false /* Metadata: 0x00AF205F */) => default; // 0x0000000182DBCF50-0x0000000182DBD2C0
	[BlackList] // 0x0000000189977820-0x0000000189977860
	// [XID] // 0x0000000189977820-0x0000000189977860
	public virtual void AutoAllocTypeFields() {} // 0x0000000182DBC4D0-0x0000000182DBC570
	[BlackList] // 0x00000001899820E0-0x0000000189982120
	// [XID] // 0x00000001899820E0-0x0000000189982120
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182DBC570-0x0000000182DBC650
	[BlackList] // 0x000000018998C770-0x000000018998C7B0
	// [XID] // 0x000000018998C770-0x000000018998C7B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182DBD4D0-0x0000000182DBD570
	[BlackList] // 0x00000001899971C0-0x0000000189997200
	// [XID] // 0x00000001899971C0-0x0000000189997200
	public virtual void OnPoolAllocated() {} // 0x0000000182DBD430-0x0000000182DBD4D0
	[BlackList] // 0x00000001899A1E10-0x00000001899A1E50
	// [XID] // 0x00000001899A1E10-0x00000001899A1E50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182DBD390-0x0000000182DBD430
}

