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
public class ReviseLevelGrowExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16065
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _grade; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189905840-0x0000000189905860 */ get => default; /* [XID] */ /* 0x000000018990D1B0-0x000000018990D1D0 */ protected set {} } // 0x0000000183B50D60-0x0000000183B50E30 0x0000000183B507D0-0x0000000183B508B0
	public SimpleSafeUInt32[] grade { /* [XID] */ /* 0x00000001899148E0-0x0000000189914900 */ get => default; /* [XID] */ /* 0x000000018991C500-0x000000018991C520 */ protected set {} } // 0x0000000183B50730-0x0000000183B507D0 0x0000000183B4FFB0-0x0000000183B50060

	// Constructors
	public ReviseLevelGrowExcelConfig() {} // 0x0000000183B50ED0-0x0000000183B50F30

	// Methods
	// [IDTag] // 0x0000000189923C40-0x0000000189923C80
	// [XID] // 0x0000000189923C40-0x0000000189923C80
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183B50060-0x0000000183B503F0
	// [IDTag] // 0x000000018992E1F0-0x000000018992E230
	// [XID] // 0x000000018992E1F0-0x000000018992E230
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183B503F0-0x0000000183B50730
	// [XID] // 0x0000000189938570-0x0000000189938590
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F57 */, bool useObjectPool = false /* Metadata: 0x00AF2F5B */) => default; // 0x0000000183B508B0-0x0000000183B50C20
	[BlackList] // 0x000000018993FF60-0x000000018993FFA0
	// [XID] // 0x000000018993FF60-0x000000018993FFA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B4FE30-0x0000000183B4FED0
	[BlackList] // 0x000000018994A420-0x000000018994A460
	// [XID] // 0x000000018994A420-0x000000018994A460
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B4FED0-0x0000000183B4FFB0
	[BlackList] // 0x0000000189954AE0-0x0000000189954B20
	// [XID] // 0x0000000189954AE0-0x0000000189954B20
	public virtual void ReturnToObjectPool() {} // 0x0000000183B50E30-0x0000000183B50ED0
	[BlackList] // 0x000000018995F5F0-0x000000018995F630
	// [XID] // 0x000000018995F5F0-0x000000018995F630
	public virtual void OnPoolAllocated() {} // 0x0000000183B50CC0-0x0000000183B50D60
	[BlackList] // 0x0000000189969C00-0x0000000189969C40
	// [XID] // 0x0000000189969C00-0x0000000189969C40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B50C20-0x0000000183B50CC0
}

