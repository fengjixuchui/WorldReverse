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
public class SignInPeriodExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16163
{
	// Fields
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected SimpleSafeUInt32 periodIdRawNum; // 0x14
	protected string _perfabPath; // 0x18

	// Properties
	public uint configId { /* [XID] */ /* 0x0000000189AF19F0-0x0000000189AF1A10 */ get => default; /* [XID] */ /* 0x0000000189AF9170-0x0000000189AF9190 */ protected set {} } // 0x0000000182B39210-0x0000000182B392E0 0x0000000182B39790-0x0000000182B39870
	public uint periodId { /* [XID] */ /* 0x0000000189B006D0-0x0000000189B006F0 */ get => default; /* [XID] */ /* 0x0000000189B07CB0-0x0000000189B07CD0 */ protected set {} } // 0x0000000182B39140-0x0000000182B39210 0x0000000182B39870-0x0000000182B39950
	public string perfabPath { /* [XID] */ /* 0x0000000189B0F4F0-0x0000000189B0F510 */ get => default; /* [XID] */ /* 0x0000000189B167D0-0x0000000189B167F0 */ protected set {} } // 0x0000000182B396F0-0x0000000182B39790 0x0000000182B38B10-0x0000000182B38BC0

	// Constructors
	public SignInPeriodExcelConfig() {} // 0x0000000182B39B30-0x0000000182B39B90

	// Methods
	// [IDTag] // 0x0000000189B1DEB0-0x0000000189B1DEF0
	// [XID] // 0x0000000189B1DEB0-0x0000000189B1DEF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B38BC0-0x0000000182B38EA0
	// [IDTag] // 0x0000000189B28550-0x0000000189B28590
	// [XID] // 0x0000000189B28550-0x0000000189B28590
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B38EA0-0x0000000182B39140
	// [XID] // 0x0000000189B32A60-0x0000000189B32A80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32F9 */, bool useObjectPool = false /* Metadata: 0x00AF32FD */) => default; // 0x0000000182B392E0-0x0000000182B396F0
	[BlackList] // 0x0000000189B3A3B0-0x0000000189B3A3F0
	// [XID] // 0x0000000189B3A3B0-0x0000000189B3A3F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B38980-0x0000000182B38A20
	[BlackList] // 0x0000000189B44CF0-0x0000000189B44D30
	// [XID] // 0x0000000189B44CF0-0x0000000189B44D30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B38A20-0x0000000182B38B10
	[BlackList] // 0x0000000189B4F470-0x0000000189B4F4B0
	// [XID] // 0x0000000189B4F470-0x0000000189B4F4B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182B39A90-0x0000000182B39B30
	[BlackList] // 0x0000000189B59C20-0x0000000189B59C60
	// [XID] // 0x0000000189B59C20-0x0000000189B59C60
	public virtual void OnPoolAllocated() {} // 0x0000000182B399F0-0x0000000182B39A90
	[BlackList] // 0x0000000189B64410-0x0000000189B64450
	// [XID] // 0x0000000189B64410-0x0000000189B64450
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B39950-0x0000000182B399F0
}

