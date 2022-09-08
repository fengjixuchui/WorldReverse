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
public class RefreshPolicyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16009
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected RefreshType _type; // 0x14
	protected string _time; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897C9820-0x00000001897C9840 */ get => default; /* [XID] */ /* 0x00000001897D0E70-0x00000001897D0E90 */ protected set {} } // 0x00000001842D8090-0x00000001842D8160 0x00000001842D7900-0x00000001842D79E0
	public RefreshType type { /* [XID] */ /* 0x00000001897D8D50-0x00000001897D8D70 */ get => default; /* [XID] */ /* 0x00000001897DFF50-0x00000001897DFF70 */ protected set {} } // 0x00000001842D8160-0x00000001842D8200 0x00000001842D7DF0-0x00000001842D7EA0
	public string time { /* [XID] */ /* 0x00000001897E76B0-0x00000001897E76D0 */ get => default; /* [XID] */ /* 0x00000001897EF290-0x00000001897EF2B0 */ protected set {} } // 0x00000001842D8200-0x00000001842D82A0 0x00000001842D7EA0-0x00000001842D7F50

	// Constructors
	public RefreshPolicyExcelConfig() {} // 0x00000001842D8340-0x00000001842D83A0

	// Methods
	// [IDTag] // 0x00000001897F68A0-0x00000001897F68E0
	// [XID] // 0x00000001897F68A0-0x00000001897F68E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001842D7360-0x00000001842D7650
	// [IDTag] // 0x00000001898012A0-0x00000001898012E0
	// [XID] // 0x00000001898012A0-0x00000001898012E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001842D7650-0x00000001842D7900
	// [XID] // 0x000000018980B680-0x000000018980B6A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D9E */, bool useObjectPool = false /* Metadata: 0x00AF2DA2 */) => default; // 0x00000001842D79E0-0x00000001842D7DF0
	[BlackList] // 0x0000000189812D60-0x0000000189812DA0
	// [XID] // 0x0000000189812D60-0x0000000189812DA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001842D71E0-0x00000001842D7280
	[BlackList] // 0x000000018981D870-0x000000018981D8B0
	// [XID] // 0x000000018981D870-0x000000018981D8B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842D7280-0x00000001842D7360
	[BlackList] // 0x0000000189828080-0x00000001898280C0
	// [XID] // 0x0000000189828080-0x00000001898280C0
	public virtual void ReturnToObjectPool() {} // 0x00000001842D82A0-0x00000001842D8340
	[BlackList] // 0x0000000189832450-0x0000000189832490
	// [XID] // 0x0000000189832450-0x0000000189832490
	public virtual void OnPoolAllocated() {} // 0x00000001842D7FF0-0x00000001842D8090
	[BlackList] // 0x000000018983CBB0-0x000000018983CBF0
	// [XID] // 0x000000018983CBB0-0x000000018983CBF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842D7F50-0x00000001842D7FF0
}

