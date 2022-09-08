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
public class SceneTagConfig : IAutoAllocRecycle // TypeDefIndex: 16099
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _sceneTagName; // 0x18
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SceneTagCond[] _cond; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AB6440-0x0000000189AB6460 */ get => default; /* [XID] */ /* 0x0000000189ABDF10-0x0000000189ABDF30 */ protected set {} } // 0x00000001835DCCF0-0x00000001835DCDC0 0x00000001835DC330-0x00000001835DC410
	public string sceneTagName { /* [XID] */ /* 0x0000000189AC5A30-0x0000000189AC5A50 */ get => default; /* [XID] */ /* 0x0000000189ACCFA0-0x0000000189ACCFC0 */ protected set {} } // 0x00000001835DCB10-0x00000001835DCBB0 0x00000001835DB7C0-0x00000001835DB870
	public uint sceneId { /* [XID] */ /* 0x0000000189AD4CE0-0x0000000189AD4D00 */ get => default; /* [XID] */ /* 0x0000000189ADC5A0-0x0000000189ADC5C0 */ protected set {} } // 0x00000001835DC410-0x00000001835DC4E0 0x00000001835DCA30-0x00000001835DCB10
	public SceneTagCond[] cond { /* [XID] */ /* 0x0000000189AE3F30-0x0000000189AE3F50 */ get => default; /* [XID] */ /* 0x0000000189AEB7D0-0x0000000189AEB7F0 */ protected set {} } // 0x00000001835DC990-0x00000001835DCA30 0x00000001835DBA00-0x00000001835DBAB0

	// Constructors
	public SceneTagConfig() {} // 0x00000001835DCE60-0x00000001835DCF50

	// Methods
	// [IDTag] // 0x0000000189AF3110-0x0000000189AF3150
	// [XID] // 0x0000000189AF3110-0x0000000189AF3150
	public virtual bool ParseFromLine(string line) => default; // 0x00000001835DBEA0-0x00000001835DC330
	// [IDTag] // 0x0000000189AFD610-0x0000000189AFD650
	// [XID] // 0x0000000189AFD610-0x0000000189AFD650
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835DBAB0-0x00000001835DBEA0
	// [XID] // 0x0000000189B07CF0-0x0000000189B07D10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF303B */, bool useObjectPool = false /* Metadata: 0x00AF303F */) => default; // 0x00000001835DC4E0-0x00000001835DC990
	[BlackList] // 0x0000000189B0F530-0x0000000189B0F570
	// [XID] // 0x0000000189B0F530-0x0000000189B0F570
	public virtual void AutoAllocTypeFields() {} // 0x00000001835DB870-0x00000001835DB910
	[BlackList] // 0x0000000189B19790-0x0000000189B197D0
	// [XID] // 0x0000000189B19790-0x0000000189B197D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835DB910-0x00000001835DBA00
	[BlackList] // 0x0000000189B240C0-0x0000000189B24100
	// [XID] // 0x0000000189B240C0-0x0000000189B24100
	public virtual void ReturnToObjectPool() {} // 0x00000001835DCDC0-0x00000001835DCE60
	[BlackList] // 0x0000000189B2E230-0x0000000189B2E270
	// [XID] // 0x0000000189B2E230-0x0000000189B2E270
	public virtual void OnPoolAllocated() {} // 0x00000001835DCC50-0x00000001835DCCF0
	[BlackList] // 0x0000000189B38970-0x0000000189B389B0
	// [XID] // 0x0000000189B38970-0x0000000189B389B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835DCBB0-0x00000001835DCC50
}

