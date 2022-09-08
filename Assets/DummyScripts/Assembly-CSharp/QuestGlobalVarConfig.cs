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
public class QuestGlobalVarConfig : IAutoAllocRecycle // TypeDefIndex: 15992
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeInt32 defaultValueRawNum; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897FCC40-0x00000001897FCC60 */ get => default; /* [XID] */ /* 0x0000000189804250-0x0000000189804270 */ protected set {} } // 0x0000000184ABDAD0-0x0000000184ABDBA0 0x0000000184ABD470-0x0000000184ABD550
	public int defaultValue { /* [XID] */ /* 0x000000018980B6A0-0x000000018980B6C0 */ get => default; /* [XID] */ /* 0x0000000189812DA0-0x0000000189812DC0 */ protected set {} } // 0x0000000184ABCF10-0x0000000184ABCFE0 0x0000000184ABD8B0-0x0000000184ABD990

	// Constructors
	public QuestGlobalVarConfig() {} // 0x0000000184ABDC40-0x0000000184ABDCA0

	// Methods
	// [IDTag] // 0x000000018981A9C0-0x000000018981AA00
	// [XID] // 0x000000018981A9C0-0x000000018981AA00
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184ABCFE0-0x0000000184ABD250
	// [IDTag] // 0x0000000189824D80-0x0000000189824DC0
	// [XID] // 0x0000000189824D80-0x0000000189824DC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184ABD250-0x0000000184ABD470
	// [XID] // 0x000000018982F300-0x000000018982F320
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D2E */, bool useObjectPool = false /* Metadata: 0x00AF2D32 */) => default; // 0x0000000184ABD550-0x0000000184ABD8B0
	[BlackList] // 0x0000000189836BF0-0x0000000189836C30
	// [XID] // 0x0000000189836BF0-0x0000000189836C30
	public virtual void AutoAllocTypeFields() {} // 0x0000000184ABCD70-0x0000000184ABCE10
	[BlackList] // 0x0000000189840F40-0x0000000189840F80
	// [XID] // 0x0000000189840F40-0x0000000189840F80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184ABCE10-0x0000000184ABCF10
	[BlackList] // 0x000000018984B6F0-0x000000018984B730
	// [XID] // 0x000000018984B6F0-0x000000018984B730
	public virtual void ReturnToObjectPool() {} // 0x0000000184ABDBA0-0x0000000184ABDC40
	[BlackList] // 0x0000000189855750-0x0000000189855790
	// [XID] // 0x0000000189855750-0x0000000189855790
	public virtual void OnPoolAllocated() {} // 0x0000000184ABDA30-0x0000000184ABDAD0
	[BlackList] // 0x000000018985FC10-0x000000018985FC50
	// [XID] // 0x000000018985FC10-0x000000018985FC50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184ABD990-0x0000000184ABDA30
}

