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
public class TauntLevelTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15325
{
	// Fields
	protected TauntLevel _type; // 0x10
	protected SimpleSafeUInt32 tauntLevelValRawNum; // 0x14

	// Properties
	public TauntLevel type { /* [XID] */ /* 0x00000001899AF790-0x00000001899AF7B0 */ get => default; /* [XID] */ /* 0x00000001899B6C70-0x00000001899B6C90 */ protected set {} } // 0x000000018121B3F0-0x000000018121B490 0x000000018121B130-0x000000018121B1E0
	public uint tauntLevelVal { /* [XID] */ /* 0x00000001899BE730-0x00000001899BE750 */ get => default; /* [XID] */ /* 0x00000001899C5F90-0x00000001899C5FB0 */ protected set {} } // 0x000000018121B320-0x000000018121B3F0 0x000000018121B050-0x000000018121B130

	// Constructors
	public TauntLevelTemplateExcelConfig() {} // 0x000000018121B530-0x000000018121B590

	// Methods
	// [IDTag] // 0x00000001899CD770-0x00000001899CD7B0
	// [XID] // 0x00000001899CD770-0x00000001899CD7B0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018121AA60-0x000000018121ACF0
	// [IDTag] // 0x00000001899D7BF0-0x00000001899D7C30
	// [XID] // 0x00000001899D7BF0-0x00000001899D7C30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018121A820-0x000000018121AA60
	// [XID] // 0x00000001899E2440-0x00000001899E2460
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF079A */, bool useObjectPool = false /* Metadata: 0x00AF079E */) => default; // 0x000000018121ACF0-0x000000018121B050
	[BlackList] // 0x00000001899E9960-0x00000001899E99A0
	// [XID] // 0x00000001899E9960-0x00000001899E99A0
	public virtual void AutoAllocTypeFields() {} // 0x000000018121A6B0-0x000000018121A750
	[BlackList] // 0x00000001899F46D0-0x00000001899F4710
	// [XID] // 0x00000001899F46D0-0x00000001899F4710
	public virtual void AutoRecycleTypeFields() {} // 0x000000018121A750-0x000000018121A820
	[BlackList] // 0x00000001899FE9B0-0x00000001899FE9F0
	// [XID] // 0x00000001899FE9B0-0x00000001899FE9F0
	public virtual void ReturnToObjectPool() {} // 0x000000018121B490-0x000000018121B530
	[BlackList] // 0x0000000189A08EF0-0x0000000189A08F30
	// [XID] // 0x0000000189A08EF0-0x0000000189A08F30
	public virtual void OnPoolAllocated() {} // 0x000000018121B280-0x000000018121B320
	[BlackList] // 0x0000000189A13780-0x0000000189A137C0
	// [XID] // 0x0000000189A13780-0x0000000189A137C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018121B1E0-0x000000018121B280
}

