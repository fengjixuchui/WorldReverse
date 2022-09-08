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
public class AsterMidGroupsExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15017
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 group_idRawNum; // 0x14
	protected SimpleSafeUInt32[] _battle_group_vec; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B95170-0x0000000189B95190 */ get => default; /* [XID] */ /* 0x0000000189B9C820-0x0000000189B9C840 */ protected set {} } // 0x000000018368F4B0-0x000000018368F580 0x000000018368EE80-0x000000018368EF60
	public uint group_id { /* [XID] */ /* 0x0000000189BA3ED0-0x0000000189BA3EF0 */ get => default; /* [XID] */ /* 0x0000000189BAB440-0x0000000189BAB460 */ protected set {} } // 0x000000018368F580-0x000000018368F650 0x000000018368ECF0-0x000000018368EDD0
	public SimpleSafeUInt32[] battle_group_vec { /* [XID] */ /* 0x0000000189BB2A50-0x0000000189BB2A70 */ get => default; /* [XID] */ /* 0x0000000189BB9E60-0x0000000189BB9E80 */ protected set {} } // 0x000000018368EC50-0x000000018368ECF0 0x000000018368EDD0-0x000000018368EE80

	// Constructors
	public AsterMidGroupsExcelConfig() {} // 0x000000018368F6F0-0x000000018368F750

	// Methods
	// [IDTag] // 0x0000000189BC1EB0-0x0000000189BC1EF0
	// [XID] // 0x0000000189BC1EB0-0x0000000189BC1EF0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018368E340-0x000000018368E7F0
	// [IDTag] // 0x0000000189BCC6A0-0x0000000189BCC6E0
	// [XID] // 0x0000000189BCC6A0-0x0000000189BCC6E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018368E7F0-0x000000018368EC50
	// [XID] // 0x0000000189BD6880-0x0000000189BD68A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE94 */, bool useObjectPool = false /* Metadata: 0x00AEFE98 */) => default; // 0x000000018368EF60-0x000000018368F370
	[BlackList] // 0x0000000189BDE5E0-0x0000000189BDE620
	// [XID] // 0x0000000189BDE5E0-0x0000000189BDE620
	public virtual void AutoAllocTypeFields() {} // 0x000000018368E1B0-0x000000018368E250
	[BlackList] // 0x00000001895EDFF0-0x00000001895EE030
	// [XID] // 0x00000001895EDFF0-0x00000001895EE030
	public virtual void AutoRecycleTypeFields() {} // 0x000000018368E250-0x000000018368E340
	[BlackList] // 0x00000001895F8990-0x00000001895F89D0
	// [XID] // 0x00000001895F8990-0x00000001895F89D0
	public virtual void ReturnToObjectPool() {} // 0x000000018368F650-0x000000018368F6F0
	[BlackList] // 0x0000000189602E50-0x0000000189602E90
	// [XID] // 0x0000000189602E50-0x0000000189602E90
	public virtual void OnPoolAllocated() {} // 0x000000018368F410-0x000000018368F4B0
	[BlackList] // 0x000000018960D780-0x000000018960D7C0
	// [XID] // 0x000000018960D780-0x000000018960D7C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018368F370-0x000000018368F410
}

