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
public class SeaLampSectionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15182
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 sectionIdRawNum; // 0x14
	protected SimpleSafeUInt32 activityIdRawNum; // 0x18
	protected SimpleSafeUInt32 mainQuestIdRawNum; // 0x1C
	protected SimpleSafeUInt32[] _miniQuestId; // 0x20
	protected SimpleSafeUInt32[] _watcherIdVec; // 0x28
	protected uint _descTextMapHash; // 0x30
	protected uint _titleTextMapHash; // 0x34
	protected uint _nameTextMapHash; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A2AD20-0x0000000189A2AD40 */ get => default; /* [XID] */ /* 0x0000000189A32240-0x0000000189A32260 */ protected set {} } // 0x00000001841A2380-0x00000001841A2450 0x00000001841A1390-0x00000001841A1470
	public uint sectionId { /* [XID] */ /* 0x0000000189A39C70-0x0000000189A39C90 */ get => default; /* [XID] */ /* 0x0000000189A41490-0x0000000189A414B0 */ protected set {} } // 0x00000001841A1520-0x00000001841A15F0 0x00000001841A1050-0x00000001841A1130
	public uint activityId { /* [XID] */ /* 0x0000000189A48B90-0x0000000189A48BB0 */ get => default; /* [XID] */ /* 0x0000000189A502E0-0x0000000189A50300 */ protected set {} } // 0x00000001841A20A0-0x00000001841A2170 0x00000001841A12B0-0x00000001841A1390
	public uint mainQuestId { /* [XID] */ /* 0x0000000189A578B0-0x0000000189A578D0 */ get => default; /* [XID] */ /* 0x0000000189A5F4B0-0x0000000189A5F4D0 */ protected set {} } // 0x00000001841A2170-0x00000001841A2240 0x000000018419FB70-0x000000018419FC50
	public SimpleSafeUInt32[] miniQuestId { /* [XID] */ /* 0x0000000189A66DE0-0x0000000189A66E00 */ get => default; /* [XID] */ /* 0x0000000189A6E5E0-0x0000000189A6E600 */ protected set {} } // 0x000000018419F830-0x000000018419F8D0 0x00000001841A1470-0x00000001841A1520
	public SimpleSafeUInt32[] watcherIdVec { /* [XID] */ /* 0x0000000189A75C90-0x0000000189A75CB0 */ get => default; /* [XID] */ /* 0x0000000189A7D850-0x0000000189A7D870 */ protected set {} } // 0x00000001841A0FB0-0x00000001841A1050 0x00000001841A0F00-0x00000001841A0FB0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A85080-0x0000000189A850A0 */ get => default; /* [XID] */ /* 0x0000000189A8C950-0x0000000189A8C970 */ protected set {} } // 0x00000001841A1DD0-0x00000001841A1E70 0x000000018419FA10-0x000000018419FAC0
	public string desc { /* [XID] */ /* 0x0000000189A93D50-0x0000000189A93D70 */ get => default; } // 0x00000001841A1130-0x00000001841A12B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189A9B800-0x0000000189A9B820 */ get => default; /* [XID] */ /* 0x0000000189AA2BE0-0x0000000189AA2C00 */ protected set {} } // 0x000000018419F970-0x000000018419FA10 0x000000018419FAC0-0x000000018419FB70
	public string title { /* [XID] */ /* 0x0000000189AAA1E0-0x0000000189AAA200 */ get => default; } // 0x00000001841A1E70-0x00000001841A1FF0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189AB2020-0x0000000189AB2040 */ get => default; /* [XID] */ /* 0x0000000189AB9270-0x0000000189AB9290 */ protected set {} } // 0x000000018419F8D0-0x000000018419F970 0x00000001841A1FF0-0x00000001841A20A0
	public string name { /* [XID] */ /* 0x0000000189AC0E90-0x0000000189AC0EB0 */ get => default; } // 0x00000001841A2450-0x00000001841A25D0 

	// Constructors
	public SeaLampSectionExcelConfig() {} // 0x00000001841A2670-0x00000001841A26D0

	// Methods
	// [IDTag] // 0x0000000189AC8890-0x0000000189AC88D0
	// [XID] // 0x0000000189AC8890-0x0000000189AC88D0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018419FC50-0x00000001841A05A0
	// [IDTag] // 0x0000000189AD3320-0x0000000189AD3360
	// [XID] // 0x0000000189AD3320-0x0000000189AD3360
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001841A05A0-0x00000001841A0F00
	// [XID] // 0x0000000189ADDFE0-0x0000000189ADE000
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0321 */, bool useObjectPool = false /* Metadata: 0x00AF0325 */) => default; // 0x00000001841A15F0-0x00000001841A1DD0
	[BlackList] // 0x0000000189AE5A20-0x0000000189AE5A60
	// [XID] // 0x0000000189AE5A20-0x0000000189AE5A60
	public virtual void AutoAllocTypeFields() {} // 0x000000018419F670-0x000000018419F710
	[BlackList] // 0x0000000189AF0510-0x0000000189AF0550
	// [XID] // 0x0000000189AF0510-0x0000000189AF0550
	public virtual void AutoRecycleTypeFields() {} // 0x000000018419F710-0x000000018419F830
	[BlackList] // 0x0000000189AFABE0-0x0000000189AFAC20
	// [XID] // 0x0000000189AFABE0-0x0000000189AFAC20
	public virtual void ReturnToObjectPool() {} // 0x00000001841A25D0-0x00000001841A2670
	[BlackList] // 0x0000000189B04F20-0x0000000189B04F60
	// [XID] // 0x0000000189B04F20-0x0000000189B04F60
	public virtual void OnPoolAllocated() {} // 0x00000001841A22E0-0x00000001841A2380
	[BlackList] // 0x0000000189B0F770-0x0000000189B0F7B0
	// [XID] // 0x0000000189B0F770-0x0000000189B0F7B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841A2240-0x00000001841A22E0
}

