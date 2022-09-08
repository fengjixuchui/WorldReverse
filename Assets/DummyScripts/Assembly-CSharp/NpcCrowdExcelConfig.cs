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
public class NpcCrowdExcelConfig : EntityExcelConfig, IAutoAllocRecycle // TypeDefIndex: 15907
{
	// Fields
	protected SimpleSafeUInt32 configIDRawNum; // 0x48

	// Properties
	public uint configID { /* [XID] */ /* 0x0000000189B853F0-0x0000000189B85410 */ get => default; /* [XID] */ /* 0x0000000189B8C220-0x0000000189B8C240 */ protected set {} } // 0x0000000182CD8850-0x0000000182CD8920 0x0000000182CD8550-0x0000000182CD8630

	// Constructors
	public NpcCrowdExcelConfig() {} // 0x0000000182CDA100-0x0000000182CDA160

	// Methods
	// [IDTag] // 0x0000000189B93AB0-0x0000000189B93AF0
	// [XID] // 0x0000000189B93AB0-0x0000000189B93AF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CD8FA0-0x0000000182CD95C0
	// [IDTag] // 0x0000000189B9DC80-0x0000000189B9DCC0
	// [XID] // 0x0000000189B9DC80-0x0000000189B9DCC0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CD8980-0x0000000182CD8FA0
	// [XID] // 0x0000000189BA8370-0x0000000189BA8390
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AD7 */, bool useObjectPool = false /* Metadata: 0x00AF2ADB */) => default; // 0x0000000182CD96B0-0x0000000182CDA000
	[BlackList] // 0x0000000189BAF7E0-0x0000000189BAF820
	// [XID] // 0x0000000189BAF7E0-0x0000000189BAF820
	public override void AutoAllocTypeFields() {} // 0x0000000182CD8630-0x0000000182CD86D0
	[BlackList] // 0x0000000189BB9CC0-0x0000000189BB9D00
	// [XID] // 0x0000000189BB9CC0-0x0000000189BB9D00
	public override void AutoRecycleTypeFields() {} // 0x0000000182CD86D0-0x0000000182CD87B0
	[BlackList] // 0x0000000189BC49A0-0x0000000189BC49E0
	// [XID] // 0x0000000189BC49A0-0x0000000189BC49E0
	public override void ReturnToObjectPool() {} // 0x0000000182CDA060-0x0000000182CDA100
}

