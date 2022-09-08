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
public class CutsceneExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15466
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _path; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189790F90-0x0000000189790FB0 */ get => default; /* [XID] */ /* 0x00000001897987E0-0x0000000189798800 */ protected set {} } // 0x000000018322ED60-0x000000018322EE30 0x000000018322E680-0x000000018322E760
	public string path { /* [XID] */ /* 0x00000001897A05F0-0x00000001897A0610 */ get => default; /* [XID] */ /* 0x00000001897A7C20-0x00000001897A7C40 */ protected set {} } // 0x000000018322EB80-0x000000018322EC20 0x000000018322EAD0-0x000000018322EB80

	// Constructors
	public CutsceneExcelConfig() {} // 0x000000018322EED0-0x000000018322EF30

	// Methods
	// [IDTag] // 0x00000001897AF630-0x00000001897AF670
	// [XID] // 0x00000001897AF630-0x00000001897AF670
	public virtual bool ParseFromLine(string line) => default; // 0x000000018322E410-0x000000018322E680
	// [IDTag] // 0x00000001897B9F50-0x00000001897B9F90
	// [XID] // 0x00000001897B9F50-0x00000001897B9F90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018322E1F0-0x000000018322E410
	// [XID] // 0x00000001897C4FA0-0x00000001897C4FC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B45 */, bool useObjectPool = false /* Metadata: 0x00AF1B49 */) => default; // 0x000000018322E760-0x000000018322EAD0
	[BlackList] // 0x00000001897CC790-0x00000001897CC7D0
	// [XID] // 0x00000001897CC790-0x00000001897CC7D0
	public virtual void AutoAllocTypeFields() {} // 0x000000018322E070-0x000000018322E110
	[BlackList] // 0x00000001897D7100-0x00000001897D7140
	// [XID] // 0x00000001897D7100-0x00000001897D7140
	public virtual void AutoRecycleTypeFields() {} // 0x000000018322E110-0x000000018322E1F0
	[BlackList] // 0x00000001897E1920-0x00000001897E1960
	// [XID] // 0x00000001897E1920-0x00000001897E1960
	public virtual void ReturnToObjectPool() {} // 0x000000018322EE30-0x000000018322EED0
	[BlackList] // 0x00000001897EC460-0x00000001897EC4A0
	// [XID] // 0x00000001897EC460-0x00000001897EC4A0
	public virtual void OnPoolAllocated() {} // 0x000000018322ECC0-0x000000018322ED60
	[BlackList] // 0x00000001897F6A00-0x00000001897F6A40
	// [XID] // 0x00000001897F6A00-0x00000001897F6A40
	public virtual void OnBeforePoolRecycled() {} // 0x000000018322EC20-0x000000018322ECC0
}

