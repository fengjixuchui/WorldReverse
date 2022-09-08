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
public class LoadingSituationExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15788
{
	// Fields
	protected SimpleSafeUInt32 stageIDRawNum; // 0x10
	protected string _picPath; // 0x18

	// Properties
	public uint stageID { /* [XID] */ /* 0x00000001897F52B0-0x00000001897F52D0 */ get => default; /* [XID] */ /* 0x00000001897FCC80-0x00000001897FCCA0 */ protected set {} } // 0x0000000184302220-0x00000001843022F0 0x0000000184302BA0-0x0000000184302C80
	public string picPath { /* [XID] */ /* 0x0000000189804290-0x00000001898042B0 */ get => default; /* [XID] */ /* 0x000000018980B720-0x000000018980B740 */ protected set {} } // 0x0000000184302DC0-0x0000000184302E60 0x0000000184302AF0-0x0000000184302BA0

	// Constructors
	public LoadingSituationExcelConfig() {} // 0x0000000184302F00-0x0000000184302F60

	// Methods
	// [IDTag] // 0x0000000189812EA0-0x0000000189812EE0
	// [XID] // 0x0000000189812EA0-0x0000000189812EE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184302510-0x0000000184302780
	// [IDTag] // 0x000000018981D930-0x000000018981D970
	// [XID] // 0x000000018981D930-0x000000018981D970
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843022F0-0x0000000184302510
	// [XID] // 0x0000000189828160-0x0000000189828180
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2606 */, bool useObjectPool = false /* Metadata: 0x00AF260A */) => default; // 0x0000000184302780-0x0000000184302AF0
	[BlackList] // 0x000000018982F400-0x000000018982F440
	// [XID] // 0x000000018982F400-0x000000018982F440
	public virtual void AutoAllocTypeFields() {} // 0x00000001843020A0-0x0000000184302140
	[BlackList] // 0x0000000189839A60-0x0000000189839AA0
	// [XID] // 0x0000000189839A60-0x0000000189839AA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184302140-0x0000000184302220
	[BlackList] // 0x00000001898442C0-0x0000000189844300
	// [XID] // 0x00000001898442C0-0x0000000189844300
	public virtual void ReturnToObjectPool() {} // 0x0000000184302E60-0x0000000184302F00
	[BlackList] // 0x000000018984E720-0x000000018984E760
	// [XID] // 0x000000018984E720-0x000000018984E760
	public virtual void OnPoolAllocated() {} // 0x0000000184302D20-0x0000000184302DC0
	[BlackList] // 0x0000000189858B00-0x0000000189858B40
	// [XID] // 0x0000000189858B00-0x0000000189858B40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184302C80-0x0000000184302D20
}

