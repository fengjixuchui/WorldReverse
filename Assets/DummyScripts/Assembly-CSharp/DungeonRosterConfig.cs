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
public class DungeonRosterConfig : IAutoAllocRecycle // TypeDefIndex: 15559
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _openTimeStr; // 0x18
	protected SimpleSafeUInt32 cycleTimeRawNum; // 0x20
	protected DungeonRosterCycleType _cycleType; // 0x24
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DungeonList[] _rosterPool; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899071F0-0x0000000189907210 */ get => default; /* [XID] */ /* 0x000000018990EB70-0x000000018990EB90 */ protected set {} } // 0x0000000184A26470-0x0000000184A26540 0x0000000184A25B00-0x0000000184A25BE0
	public string openTimeStr { /* [XID] */ /* 0x00000001899162A0-0x00000001899162C0 */ get => default; /* [XID] */ /* 0x000000018991DBF0-0x000000018991DC10 */ protected set {} } // 0x0000000184A24C30-0x0000000184A24CD0 0x0000000184A26130-0x0000000184A261E0
	public uint cycleTime { /* [XID] */ /* 0x00000001899253A0-0x00000001899253C0 */ get => default; /* [XID] */ /* 0x000000018992C940-0x000000018992C960 */ protected set {} } // 0x0000000184A258B0-0x0000000184A25980 0x0000000184A25980-0x0000000184A25A60
	public DungeonRosterCycleType cycleType { /* [XID] */ /* 0x0000000189933F60-0x0000000189933F80 */ get => default; /* [XID] */ /* 0x000000018993BB70-0x000000018993BB90 */ protected set {} } // 0x0000000184A26290-0x0000000184A26330 0x0000000184A25800-0x0000000184A258B0
	public DungeonList[] rosterPool { /* [XID] */ /* 0x0000000189942D10-0x0000000189942D30 */ get => default; /* [XID] */ /* 0x000000018994A5A0-0x000000018994A5C0 */ protected set {} } // 0x0000000184A25A60-0x0000000184A25B00 0x0000000184A261E0-0x0000000184A26290

	// Constructors
	public DungeonRosterConfig() {} // 0x0000000184A265E0-0x0000000184A26640

	// Methods
	// [IDTag] // 0x0000000189951FD0-0x0000000189952010
	// [XID] // 0x0000000189951FD0-0x0000000189952010
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184A252E0-0x0000000184A25800
	// [IDTag] // 0x000000018995C4A0-0x000000018995C4E0
	// [XID] // 0x000000018995C4A0-0x000000018995C4E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184A24E60-0x0000000184A252E0
	// [XID] // 0x0000000189966F70-0x0000000189966F90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F11 */, bool useObjectPool = false /* Metadata: 0x00AF1F15 */) => default; // 0x0000000184A25BE0-0x0000000184A26130
	[BlackList] // 0x000000018996E2C0-0x000000018996E300
	// [XID] // 0x000000018996E2C0-0x000000018996E300
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A24CD0-0x0000000184A24D70
	[BlackList] // 0x0000000189979310-0x0000000189979350
	// [XID] // 0x0000000189979310-0x0000000189979350
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A24D70-0x0000000184A24E60
	[BlackList] // 0x00000001899837F0-0x0000000189983830
	// [XID] // 0x00000001899837F0-0x0000000189983830
	public virtual void ReturnToObjectPool() {} // 0x0000000184A26540-0x0000000184A265E0
	[BlackList] // 0x000000018998E000-0x000000018998E040
	// [XID] // 0x000000018998E000-0x000000018998E040
	public virtual void OnPoolAllocated() {} // 0x0000000184A263D0-0x0000000184A26470
	[BlackList] // 0x0000000189998CB0-0x0000000189998CF0
	// [XID] // 0x0000000189998CB0-0x0000000189998CF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A26330-0x0000000184A263D0
}

