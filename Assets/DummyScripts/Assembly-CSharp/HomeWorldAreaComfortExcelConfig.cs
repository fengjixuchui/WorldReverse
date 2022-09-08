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
public class HomeWorldAreaComfortExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15728
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 configIDRawNum; // 0x10
	protected SimpleSafeUInt32 sceneIDRawNum; // 0x14
	protected SimpleSafeUInt32 areaIDRawNum; // 0x18
	protected HomeWorldAreaType _areaType; // 0x1C
	protected uint _nameTextMapHash; // 0x20
	protected SimpleSafeUInt32 maxComfortRawNum; // 0x24

	// Properties
	public uint configID { /* [XID] */ /* 0x0000000189A65520-0x0000000189A65540 */ get => default; /* [XID] */ /* 0x0000000189A6CC20-0x0000000189A6CC40 */ protected set {} } // 0x0000000181BAFE00-0x0000000181BAFED0 0x0000000181BAFAD0-0x0000000181BAFBB0
	public uint sceneID { /* [XID] */ /* 0x0000000189A743B0-0x0000000189A743D0 */ get => default; /* [XID] */ /* 0x0000000189A7BD60-0x0000000189A7BD80 */ protected set {} } // 0x0000000181BB0910-0x0000000181BB09E0 0x0000000181BAFED0-0x0000000181BAFFB0
	public uint areaID { /* [XID] */ /* 0x0000000189A83740-0x0000000189A83760 */ get => default; /* [XID] */ /* 0x0000000189A8AFA0-0x0000000189A8AFC0 */ protected set {} } // 0x0000000181BB0C40-0x0000000181BB0D10 0x0000000181BB0830-0x0000000181BB0910
	public HomeWorldAreaType areaType { /* [XID] */ /* 0x0000000189A92770-0x0000000189A92790 */ get => default; /* [XID] */ /* 0x0000000189A9A1E0-0x0000000189A9A200 */ protected set {} } // 0x0000000181BB1300-0x0000000181BB13A0 0x0000000181BB09E0-0x0000000181BB0A90
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189AA1280-0x0000000189AA12A0 */ get => default; /* [XID] */ /* 0x0000000189AA8920-0x0000000189AA8940 */ protected set {} } // 0x0000000181BAFD60-0x0000000181BAFE00 0x0000000181BB13A0-0x0000000181BB1450
	public string name { /* [XID] */ /* 0x0000000189AB04E0-0x0000000189AB0500 */ get => default; } // 0x0000000181BB1590-0x0000000181BB1710 
	public uint maxComfort { /* [XID] */ /* 0x0000000189AB7B60-0x0000000189AB7B80 */ get => default; /* [XID] */ /* 0x0000000189ABF650-0x0000000189ABF670 */ protected set {} } // 0x0000000181BB0A90-0x0000000181BB0B60 0x0000000181BB0B60-0x0000000181BB0C40

	// Constructors
	public HomeWorldAreaComfortExcelConfig() {} // 0x0000000181BB17B0-0x0000000181BB1810

	// Methods
	// [IDTag] // 0x0000000189AC7060-0x0000000189AC70A0
	// [XID] // 0x0000000189AC7060-0x0000000189AC70A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181BB03E0-0x0000000181BB0830
	// [IDTag] // 0x0000000189AD1850-0x0000000189AD1890
	// [XID] // 0x0000000189AD1850-0x0000000189AD1890
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181BAFFB0-0x0000000181BB03E0
	// [XID] // 0x0000000189ADC6C0-0x0000000189ADC6E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2468 */, bool useObjectPool = false /* Metadata: 0x00AF246C */) => default; // 0x0000000181BB0D10-0x0000000181BB1300
	[BlackList] // 0x0000000189AE3FD0-0x0000000189AE4010
	// [XID] // 0x0000000189AE3FD0-0x0000000189AE4010
	public virtual void AutoAllocTypeFields() {} // 0x0000000181BAFBB0-0x0000000181BAFC50
	[BlackList] // 0x0000000189AEEB60-0x0000000189AEEBA0
	// [XID] // 0x0000000189AEEB60-0x0000000189AEEBA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181BAFC50-0x0000000181BAFD60
	[BlackList] // 0x0000000189AF92B0-0x0000000189AF92F0
	// [XID] // 0x0000000189AF92B0-0x0000000189AF92F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181BB1710-0x0000000181BB17B0
	[BlackList] // 0x0000000189B035F0-0x0000000189B03630
	// [XID] // 0x0000000189B035F0-0x0000000189B03630
	public virtual void OnPoolAllocated() {} // 0x0000000181BB14F0-0x0000000181BB1590
	[BlackList] // 0x0000000189B0DE90-0x0000000189B0DED0
	// [XID] // 0x0000000189B0DE90-0x0000000189B0DED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181BB1450-0x0000000181BB14F0
}

