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
public class NewActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15887
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 activityIdRawNum; // 0x10
	protected NewActivityType _activityType; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected string _activitySceneTag; // 0x20
	protected bool _isLoadTerrain; // 0x28
	protected SimpleSafeUInt32[] _condGroupId; // 0x30
	protected SimpleSafeUInt32[] _watcherId; // 0x38

	// Properties
	public uint activityId { /* [XID] */ /* 0x000000018961F5C0-0x000000018961F5E0 */ get => default; /* [XID] */ /* 0x00000001896269C0-0x00000001896269E0 */ protected set {} } // 0x00000001858A8D00-0x00000001858A8DD0 0x00000001858A8420-0x00000001858A8500
	public NewActivityType activityType { /* [XID] */ /* 0x000000018962E2F0-0x000000018962E310 */ get => default; /* [XID] */ /* 0x0000000189635E70-0x0000000189635E90 */ protected set {} } // 0x00000001858A8240-0x00000001858A82E0 0x00000001858A8E70-0x00000001858A8F20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x000000018963D5D0-0x000000018963D5F0 */ get => default; /* [XID] */ /* 0x0000000189644B90-0x0000000189644BB0 */ protected set {} } // 0x00000001858A6EF0-0x00000001858A6F90 0x00000001858A8C50-0x00000001858A8D00
	public string name { /* [XID] */ /* 0x000000018964C530-0x000000018964C550 */ get => default; } // 0x00000001858A9110-0x00000001858A9290 
	public string activitySceneTag { /* [XID] */ /* 0x0000000189653B00-0x0000000189653B20 */ get => default; /* [XID] */ /* 0x000000018965B370-0x000000018965B390 */ protected set {} } // 0x00000001858A8380-0x00000001858A8420 0x00000001858A8BA0-0x00000001858A8C50
	public bool isLoadTerrain { /* [XID] */ /* 0x0000000189662820-0x0000000189662840 */ get => default; /* [XID] */ /* 0x000000018966A3C0-0x000000018966A3E0 */ protected set {} } // 0x00000001858A6F90-0x00000001858A7030 0x00000001858A9060-0x00000001858A9110
	public SimpleSafeUInt32[] condGroupId { /* [XID] */ /* 0x0000000189671FE0-0x0000000189672000 */ get => default; /* [XID] */ /* 0x00000001896798F0-0x0000000189679910 */ protected set {} } // 0x00000001858A8DD0-0x00000001858A8E70 0x00000001858A70E0-0x00000001858A7190
	public SimpleSafeUInt32[] watcherId { /* [XID] */ /* 0x0000000189680FE0-0x0000000189681000 */ get => default; /* [XID] */ /* 0x0000000189688A80-0x0000000189688AA0 */ protected set {} } // 0x00000001858A82E0-0x00000001858A8380 0x00000001858A7030-0x00000001858A70E0

	// Constructors
	public NewActivityExcelConfig() {} // 0x00000001858A9330-0x00000001858A9390

	// Methods
	// [IDTag] // 0x0000000189690420-0x0000000189690460
	// [XID] // 0x0000000189690420-0x0000000189690460
	public virtual bool ParseFromLine(string line) => default; // 0x00000001858A79E0-0x00000001858A8240
	// [IDTag] // 0x000000018969A8B0-0x000000018969A8F0
	// [XID] // 0x000000018969A8B0-0x000000018969A8F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001858A7190-0x00000001858A79E0
	// [XID] // 0x00000001896A4C60-0x00000001896A4C80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A46 */, bool useObjectPool = false /* Metadata: 0x00AF2A4A */) => default; // 0x00000001858A8500-0x00000001858A8BA0
	[BlackList] // 0x00000001896AC430-0x00000001896AC470
	// [XID] // 0x00000001896AC430-0x00000001896AC470
	public virtual void AutoAllocTypeFields() {} // 0x00000001858A6D70-0x00000001858A6E10
	[BlackList] // 0x00000001896B66C0-0x00000001896B6700
	// [XID] // 0x00000001896B66C0-0x00000001896B6700
	public virtual void AutoRecycleTypeFields() {} // 0x00000001858A6E10-0x00000001858A6EF0
	[BlackList] // 0x00000001896C0980-0x00000001896C09C0
	// [XID] // 0x00000001896C0980-0x00000001896C09C0
	public virtual void ReturnToObjectPool() {} // 0x00000001858A9290-0x00000001858A9330
	[BlackList] // 0x00000001896CADF0-0x00000001896CAE30
	// [XID] // 0x00000001896CADF0-0x00000001896CAE30
	public virtual void OnPoolAllocated() {} // 0x00000001858A8FC0-0x00000001858A9060
	[BlackList] // 0x00000001896D5600-0x00000001896D5640
	// [XID] // 0x00000001896D5600-0x00000001896D5640
	public virtual void OnBeforePoolRecycled() {} // 0x00000001858A8F20-0x00000001858A8FC0
}

