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
public class TowerBuffExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16200
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 towerBuffIdRawNum; // 0x10
	protected TowerBuffLastingType _lastingType; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string _buffIcon; // 0x20
	protected SimpleSafeUInt32 buffIdRawNum; // 0x28

	// Properties
	public uint towerBuffId { /* [XID] */ /* 0x00000001897582B0-0x00000001897582D0 */ get => default; /* [XID] */ /* 0x000000018975FD90-0x000000018975FDB0 */ protected set {} } // 0x00000001822C5C20-0x00000001822C5CF0 0x00000001822C5880-0x00000001822C5960
	public TowerBuffLastingType lastingType { /* [XID] */ /* 0x0000000189767420-0x0000000189767440 */ get => default; /* [XID] */ /* 0x000000018976E9A0-0x000000018976E9C0 */ protected set {} } // 0x00000001822C57E0-0x00000001822C5880 0x00000001822C5B70-0x00000001822C5C20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189776380-0x00000001897763A0 */ get => default; /* [XID] */ /* 0x000000018977DA60-0x000000018977DA80 */ protected set {} } // 0x00000001822C5740-0x00000001822C57E0 0x00000001822C46A0-0x00000001822C4750
	public string desc { /* [XID] */ /* 0x0000000189785240-0x0000000189785260 */ get => default; } // 0x00000001822C5070-0x00000001822C51F0 
	public string buffIcon { /* [XID] */ /* 0x000000018978C770-0x000000018978C790 */ get => default; /* [XID] */ /* 0x0000000189793C00-0x0000000189793C20 */ protected set {} } // 0x00000001822C4600-0x00000001822C46A0 0x00000001822C4EE0-0x00000001822C4F90
	public uint buffId { /* [XID] */ /* 0x000000018979BF90-0x000000018979BFB0 */ get => default; /* [XID] */ /* 0x00000001897A3420-0x00000001897A3440 */ protected set {} } // 0x00000001822C5960-0x00000001822C5A30 0x00000001822C4F90-0x00000001822C5070

	// Constructors
	public TowerBuffExcelConfig() {} // 0x00000001822C5D90-0x00000001822C5DF0

	// Methods
	// [IDTag] // 0x00000001897AA9C0-0x00000001897AAA00
	// [XID] // 0x00000001897AA9C0-0x00000001897AAA00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001822C4750-0x00000001822C4B30
	// [IDTag] // 0x00000001897B5C50-0x00000001897B5C90
	// [XID] // 0x00000001897B5C50-0x00000001897B5C90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001822C4B30-0x00000001822C4EE0
	// [XID] // 0x00000001897C0980-0x00000001897C09A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33F7 */, bool useObjectPool = false /* Metadata: 0x00AF33FB */) => default; // 0x00000001822C51F0-0x00000001822C5740
	[BlackList] // 0x00000001897C8330-0x00000001897C8370
	// [XID] // 0x00000001897C8330-0x00000001897C8370
	public virtual void AutoAllocTypeFields() {} // 0x00000001822C4470-0x00000001822C4510
	[BlackList] // 0x00000001897D2650-0x00000001897D2690
	// [XID] // 0x00000001897D2650-0x00000001897D2690
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822C4510-0x00000001822C4600
	[BlackList] // 0x00000001897DCDF0-0x00000001897DCE30
	// [XID] // 0x00000001897DCDF0-0x00000001897DCE30
	public virtual void ReturnToObjectPool() {} // 0x00000001822C5CF0-0x00000001822C5D90
	[BlackList] // 0x00000001897E7630-0x00000001897E7670
	// [XID] // 0x00000001897E7630-0x00000001897E7670
	public virtual void OnPoolAllocated() {} // 0x00000001822C5AD0-0x00000001822C5B70
	[BlackList] // 0x00000001897F2590-0x00000001897F25D0
	// [XID] // 0x00000001897F2590-0x00000001897F25D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822C5A30-0x00000001822C5AD0
}

