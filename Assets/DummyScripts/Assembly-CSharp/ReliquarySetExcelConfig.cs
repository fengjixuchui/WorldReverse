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
public class ReliquarySetExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16023
{
	// Fields
	protected SimpleSafeUInt32 setIdRawNum; // 0x10
	protected string _setIcon; // 0x18
	protected SimpleSafeUInt32[] _setNeedNum; // 0x20
	protected SimpleSafeUInt32 EquipAffixIdRawNum; // 0x28
	protected SimpleSafeUInt32 DisableFilterRawNum; // 0x2C
	protected SimpleSafeUInt32[] _containsList; // 0x30

	// Properties
	public uint setId { /* [XID] */ /* 0x00000001898F97F0-0x00000001898F9810 */ get => default; /* [XID] */ /* 0x0000000189901130-0x0000000189901150 */ protected set {} } // 0x0000000183CCB860-0x0000000183CCB930 0x0000000183CCB930-0x0000000183CCBA10
	public string setIcon { /* [XID] */ /* 0x0000000189908A30-0x0000000189908A50 */ get => default; /* [XID] */ /* 0x000000018990FFD0-0x000000018990FFF0 */ protected set {} } // 0x0000000183CCA6D0-0x0000000183CCA770 0x0000000183CCBA10-0x0000000183CCBAC0
	public SimpleSafeUInt32[] setNeedNum { /* [XID] */ /* 0x0000000189917BA0-0x0000000189917BC0 */ get => default; /* [XID] */ /* 0x000000018991F0C0-0x000000018991F0E0 */ protected set {} } // 0x0000000183CCA770-0x0000000183CCA810 0x0000000183CCBC70-0x0000000183CCBD20
	public uint EquipAffixId { /* [XID] */ /* 0x0000000189926B60-0x0000000189926B80 */ get => default; /* [XID] */ /* 0x000000018992E230-0x000000018992E250 */ protected set {} } // 0x0000000183CCBBA0-0x0000000183CCBC70 0x0000000183CCBAC0-0x0000000183CCBBA0
	public uint DisableFilter { /* [XID] */ /* 0x00000001899355D0-0x00000001899355F0 */ get => default; /* [XID] */ /* 0x000000018993D130-0x000000018993D150 */ protected set {} } // 0x0000000183CCC400-0x0000000183CCC4D0 0x0000000183CCC320-0x0000000183CCC400
	public SimpleSafeUInt32[] containsList { /* [XID] */ /* 0x00000001899447A0-0x00000001899447C0 */ get => default; /* [XID] */ /* 0x000000018994BDC0-0x000000018994BDE0 */ protected set {} } // 0x0000000183CCA810-0x0000000183CCA8B0 0x0000000183CCC4D0-0x0000000183CCC580

	// Constructors
	public ReliquarySetExcelConfig() {} // 0x0000000183CCC760-0x0000000183CCC7C0

	// Methods
	// [IDTag] // 0x00000001899534F0-0x0000000189953530
	// [XID] // 0x00000001899534F0-0x0000000189953530
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183CCB080-0x0000000183CCB860
	// [IDTag] // 0x000000018995DDF0-0x000000018995DE30
	// [XID] // 0x000000018995DDF0-0x000000018995DE30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183CCA8B0-0x0000000183CCB080
	// [XID] // 0x00000001899684C0-0x00000001899684E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E2C */, bool useObjectPool = false /* Metadata: 0x00AF2E30 */) => default; // 0x0000000183CCBD20-0x0000000183CCC320
	[BlackList] // 0x000000018996F9A0-0x000000018996F9E0
	// [XID] // 0x000000018996F9A0-0x000000018996F9E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183CCA530-0x0000000183CCA5D0
	[BlackList] // 0x000000018997A6B0-0x000000018997A6F0
	// [XID] // 0x000000018997A6B0-0x000000018997A6F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183CCA5D0-0x0000000183CCA6D0
	[BlackList] // 0x0000000189984AD0-0x0000000189984B10
	// [XID] // 0x0000000189984AD0-0x0000000189984B10
	public virtual void ReturnToObjectPool() {} // 0x0000000183CCC6C0-0x0000000183CCC760
	[BlackList] // 0x000000018998F760-0x000000018998F7A0
	// [XID] // 0x000000018998F760-0x000000018998F7A0
	public virtual void OnPoolAllocated() {} // 0x0000000183CCC620-0x0000000183CCC6C0
	[BlackList] // 0x000000018999A670-0x000000018999A6B0
	// [XID] // 0x000000018999A670-0x000000018999A6B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183CCC580-0x0000000183CCC620
}

