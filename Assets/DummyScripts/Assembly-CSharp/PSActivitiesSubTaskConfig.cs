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
public class PSActivitiesSubTaskConfig : PSActivitiesBaseConfig, IAutoAllocRecycle // TypeDefIndex: 15961
{
	// Fields
	protected SimpleSafeUInt32 taskIDRawNum; // 0x20
	protected bool _hidden; // 0x24

	// Properties
	public uint taskID { /* [XID] */ /* 0x0000000189ABDF50-0x0000000189ABDF70 */ get => default; /* [XID] */ /* 0x0000000189AC5A70-0x0000000189AC5A90 */ protected set {} } // 0x0000000183121B10-0x0000000183121BE0 0x00000001831213C0-0x00000001831214A0
	public bool hidden { /* [XID] */ /* 0x0000000189ACCFE0-0x0000000189ACD000 */ get => default; /* [XID] */ /* 0x0000000189AD4D60-0x0000000189AD4D80 */ protected set {} } // 0x0000000183122180-0x0000000183122220 0x0000000183122280-0x0000000183122330

	// Constructors
	public PSActivitiesSubTaskConfig() {} // 0x00000001831223D0-0x0000000183122430

	// Methods
	// [IDTag] // 0x0000000189ADC620-0x0000000189ADC660
	// [XID] // 0x0000000189ADC620-0x0000000189ADC660
	public virtual bool ParseFromLine(string line) => default; // 0x00000001831214A0-0x00000001831217F0
	// [IDTag] // 0x0000000189AE6FD0-0x0000000189AE7010
	// [XID] // 0x0000000189AE6FD0-0x0000000189AE7010
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001831217F0-0x0000000183121B10
	// [XID] // 0x0000000189AF1A90-0x0000000189AF1AB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C57 */, bool useObjectPool = false /* Metadata: 0x00AF2C5B */) => default; // 0x0000000183121CD0-0x0000000183122180
	[BlackList] // 0x0000000189AF9250-0x0000000189AF9290
	// [XID] // 0x0000000189AF9250-0x0000000189AF9290
	public override void AutoAllocTypeFields() {} // 0x0000000183121140-0x00000001831211E0
	[BlackList] // 0x0000000189B03530-0x0000000189B03570
	// [XID] // 0x0000000189B03530-0x0000000189B03570
	public override void AutoRecycleTypeFields() {} // 0x00000001831211E0-0x00000001831212C0
	[BlackList] // 0x0000000189B0DDD0-0x0000000189B0DE10
	// [XID] // 0x0000000189B0DDD0-0x0000000189B0DE10
	public override void ReturnToObjectPool() {} // 0x0000000183122330-0x00000001831223D0
}

