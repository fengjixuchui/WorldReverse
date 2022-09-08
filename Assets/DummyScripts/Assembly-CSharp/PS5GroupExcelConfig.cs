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
public class PS5GroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14999
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected string _iconPath; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897A50B0-0x00000001897A50D0 */ get => default; /* [XID] */ /* 0x00000001897AC620-0x00000001897AC640 */ protected set {} } // 0x0000000184250950-0x0000000184250A20 0x0000000184250120-0x0000000184250200
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897B4590-0x00000001897B45B0 */ get => default; /* [XID] */ /* 0x00000001897BC350-0x00000001897BC370 */ protected set {} } // 0x000000018424FB00-0x000000018424FBA0 0x00000001842506B0-0x0000000184250760
	public string name { /* [XID] */ /* 0x00000001897C3A10-0x00000001897C3A30 */ get => default; } // 0x0000000184250A20-0x0000000184250BA0 
	public string iconPath { /* [XID] */ /* 0x00000001897CB190-0x00000001897CB1B0 */ get => default; /* [XID] */ /* 0x00000001897D2870-0x00000001897D2890 */ protected set {} } // 0x0000000184250610-0x00000001842506B0 0x0000000184250760-0x0000000184250810

	// Constructors
	public PS5GroupExcelConfig() {} // 0x0000000184250C40-0x0000000184250CA0

	// Methods
	// [IDTag] // 0x00000001897DA570-0x00000001897DA5B0
	// [XID] // 0x00000001897DA570-0x00000001897DA5B0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018424FE40-0x0000000184250120
	// [IDTag] // 0x00000001897E4910-0x00000001897E4950
	// [XID] // 0x00000001897E4910-0x00000001897E4950
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018424FBA0-0x000000018424FE40
	// [XID] // 0x00000001897EF470-0x00000001897EF490
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE0C */, bool useObjectPool = false /* Metadata: 0x00AEFE10 */) => default; // 0x0000000184250200-0x0000000184250610
	[BlackList] // 0x00000001897F6AC0-0x00000001897F6B00
	// [XID] // 0x00000001897F6AC0-0x00000001897F6B00
	public virtual void AutoAllocTypeFields() {} // 0x000000018424F980-0x000000018424FA20
	[BlackList] // 0x0000000189801540-0x0000000189801580
	// [XID] // 0x0000000189801540-0x0000000189801580
	public virtual void AutoRecycleTypeFields() {} // 0x000000018424FA20-0x000000018424FB00
	[BlackList] // 0x000000018980B800-0x000000018980B840
	// [XID] // 0x000000018980B800-0x000000018980B840
	public virtual void ReturnToObjectPool() {} // 0x0000000184250BA0-0x0000000184250C40
	[BlackList] // 0x0000000189816070-0x00000001898160B0
	// [XID] // 0x0000000189816070-0x00000001898160B0
	public virtual void OnPoolAllocated() {} // 0x00000001842508B0-0x0000000184250950
	[BlackList] // 0x0000000189820D10-0x0000000189820D50
	// [XID] // 0x0000000189820D10-0x0000000189820D50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184250810-0x00000001842508B0
}

