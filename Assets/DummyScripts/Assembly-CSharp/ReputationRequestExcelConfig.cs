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
public class ReputationRequestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16045
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 RequestIdRawNum; // 0x10
	protected SimpleSafeUInt32 QuestIdRawNum; // 0x14
	protected SimpleSafeUInt32 GroupIdRawNum; // 0x18
	protected SimpleSafeUInt32 weightRawNum; // 0x1C
	protected SimpleSafeUInt32 npcIdRawNum; // 0x20
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x24
	protected uint _nameTextMapHash; // 0x28
	protected uint _descTextMapHash; // 0x2C
	protected string _iconName; // 0x30

	// Properties
	public uint RequestId { /* [XID] */ /* 0x00000001899F8870-0x00000001899F8890 */ get => default; /* [XID] */ /* 0x00000001899FFE80-0x00000001899FFEA0 */ protected set {} } // 0x000000018456D3C0-0x000000018456D490 0x000000018456D490-0x000000018456D570
	public uint QuestId { /* [XID] */ /* 0x0000000189A07750-0x0000000189A07770 */ get => default; /* [XID] */ /* 0x0000000189A0EBB0-0x0000000189A0EBD0 */ protected set {} } // 0x000000018456D110-0x000000018456D1E0 0x000000018456E2A0-0x000000018456E380
	public uint GroupId { /* [XID] */ /* 0x0000000189A163A0-0x0000000189A163C0 */ get => default; /* [XID] */ /* 0x0000000189A1D940-0x0000000189A1D960 */ protected set {} } // 0x000000018456F050-0x000000018456F120 0x000000018456E380-0x000000018456E460
	public uint weight { /* [XID] */ /* 0x0000000189A24D70-0x0000000189A24D90 */ get => default; /* [XID] */ /* 0x0000000189A2C330-0x0000000189A2C350 */ protected set {} } // 0x000000018456F500-0x000000018456F5D0 0x000000018456E460-0x000000018456E540
	public uint npcId { /* [XID] */ /* 0x0000000189A339E0-0x0000000189A33A00 */ get => default; /* [XID] */ /* 0x0000000189A3B1C0-0x0000000189A3B1E0 */ protected set {} } // 0x000000018456E1D0-0x000000018456E2A0 0x000000018456EF70-0x000000018456F050
	public uint rewardId { /* [XID] */ /* 0x0000000189A42BB0-0x0000000189A42BD0 */ get => default; /* [XID] */ /* 0x0000000189A4A020-0x0000000189A4A040 */ protected set {} } // 0x000000018456EEA0-0x000000018456EF70 0x000000018456D030-0x000000018456D110
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189A519B0-0x0000000189A519D0 */ get => default; /* [XID] */ /* 0x0000000189A59220-0x0000000189A59240 */ protected set {} } // 0x000000018456D570-0x000000018456D610 0x000000018456F1C0-0x000000018456F270
	public string name { /* [XID] */ /* 0x0000000189A60B60-0x0000000189A60B80 */ get => default; } // 0x000000018456F5D0-0x000000018456F750 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A688D0-0x0000000189A688F0 */ get => default; /* [XID] */ /* 0x0000000189A6FC80-0x0000000189A6FCA0 */ protected set {} } // 0x000000018456F120-0x000000018456F1C0 0x000000018456D610-0x000000018456D6C0
	public string desc { /* [XID] */ /* 0x0000000189A77410-0x0000000189A77430 */ get => default; } // 0x000000018456E540-0x000000018456E6C0 
	public string iconName { /* [XID] */ /* 0x0000000189A7ECC0-0x0000000189A7ECE0 */ get => default; /* [XID] */ /* 0x0000000189A864F0-0x0000000189A86510 */ protected set {} } // 0x000000018456F270-0x000000018456F310 0x000000018456F450-0x000000018456F500

	// Constructors
	public ReputationRequestExcelConfig() {} // 0x000000018456F7F0-0x000000018456F850

	// Methods
	// [IDTag] // 0x0000000189A8DF90-0x0000000189A8DFD0
	// [XID] // 0x0000000189A8DF90-0x0000000189A8DFD0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018456D6C0-0x000000018456DC50
	// [IDTag] // 0x0000000189A98840-0x0000000189A98880
	// [XID] // 0x0000000189A98840-0x0000000189A98880
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018456DC50-0x000000018456E1D0
	// [XID] // 0x0000000189AA2A20-0x0000000189AA2A40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EC9 */, bool useObjectPool = false /* Metadata: 0x00AF2ECD */) => default; // 0x000000018456E6C0-0x000000018456EEA0
	[BlackList] // 0x0000000189AAA100-0x0000000189AAA140
	// [XID] // 0x0000000189AAA100-0x0000000189AAA140
	public virtual void AutoAllocTypeFields() {} // 0x000000018456D1E0-0x000000018456D280
	[BlackList] // 0x0000000189AB4C10-0x0000000189AB4C50
	// [XID] // 0x0000000189AB4C10-0x0000000189AB4C50
	public virtual void AutoRecycleTypeFields() {} // 0x000000018456D280-0x000000018456D3C0
	[BlackList] // 0x0000000189ABF5B0-0x0000000189ABF5F0
	// [XID] // 0x0000000189ABF5B0-0x0000000189ABF5F0
	public virtual void ReturnToObjectPool() {} // 0x000000018456F750-0x000000018456F7F0
	[BlackList] // 0x0000000189AC9FA0-0x0000000189AC9FE0
	// [XID] // 0x0000000189AC9FA0-0x0000000189AC9FE0
	public virtual void OnPoolAllocated() {} // 0x000000018456F3B0-0x000000018456F450
	[BlackList] // 0x0000000189AD4D00-0x0000000189AD4D40
	// [XID] // 0x0000000189AD4D00-0x0000000189AD4D40
	public virtual void OnBeforePoolRecycled() {} // 0x000000018456F310-0x000000018456F3B0
}

