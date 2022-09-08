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
public class MpPlayLevelTextDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15875
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898E1670-0x00000001898E1690 */ get => default; /* [XID] */ /* 0x00000001898E9140-0x00000001898E9160 */ protected set {} } // 0x0000000182D5E3B0-0x0000000182D5E480 0x0000000182D5DC30-0x0000000182D5DD10
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001898F0900-0x00000001898F0920 */ get => default; /* [XID] */ /* 0x00000001898F8270-0x00000001898F8290 */ protected set {} } // 0x0000000182D5D3E0-0x0000000182D5D480 0x0000000182D5E1C0-0x0000000182D5E270
	public string name { /* [XID] */ /* 0x00000001898FF8D0-0x00000001898FF8F0 */ get => default; } // 0x0000000182D5E480-0x0000000182D5E600 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189907110-0x0000000189907130 */ get => default; /* [XID] */ /* 0x000000018990EA50-0x000000018990EA70 */ protected set {} } // 0x0000000182D5E120-0x0000000182D5E1C0 0x0000000182D5D480-0x0000000182D5D530
	public string desc { /* [XID] */ /* 0x00000001899161A0-0x00000001899161C0 */ get => default; } // 0x0000000182D5DAB0-0x0000000182D5DC30 

	// Constructors
	public MpPlayLevelTextDataExcelConfig() {} // 0x0000000182D5E6A0-0x0000000182D5E700

	// Methods
	// [IDTag] // 0x000000018991DB70-0x000000018991DBB0
	// [XID] // 0x000000018991DB70-0x000000018991DBB0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182D5D7D0-0x0000000182D5DAB0
	// [IDTag] // 0x0000000189928350-0x0000000189928390
	// [XID] // 0x0000000189928350-0x0000000189928390
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182D5D530-0x0000000182D5D7D0
	// [XID] // 0x00000001899329C0-0x00000001899329E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2919 */, bool useObjectPool = false /* Metadata: 0x00AF291D */) => default; // 0x0000000182D5DD10-0x0000000182D5E120
	[BlackList] // 0x000000018993A3B0-0x000000018993A3F0
	// [XID] // 0x000000018993A3B0-0x000000018993A3F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D5D270-0x0000000182D5D310
	[BlackList] // 0x0000000189944820-0x0000000189944860
	// [XID] // 0x0000000189944820-0x0000000189944860
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D5D310-0x0000000182D5D3E0
	[BlackList] // 0x000000018994ED80-0x000000018994EDC0
	// [XID] // 0x000000018994ED80-0x000000018994EDC0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D5E600-0x0000000182D5E6A0
	[BlackList] // 0x0000000189959490-0x00000001899594D0
	// [XID] // 0x0000000189959490-0x00000001899594D0
	public virtual void OnPoolAllocated() {} // 0x0000000182D5E310-0x0000000182D5E3B0
	[BlackList] // 0x0000000189963E20-0x0000000189963E60
	// [XID] // 0x0000000189963E20-0x0000000189963E60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D5E270-0x0000000182D5E310
}

