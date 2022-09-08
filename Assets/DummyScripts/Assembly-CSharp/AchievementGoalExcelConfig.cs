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
public class AchievementGoalExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14995
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 orderIdRawNum; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected SimpleSafeUInt32 finishRewardIdRawNum; // 0x1C
	protected string _iconPath; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B44F70-0x0000000189B44F90 */ get => default; /* [XID] */ /* 0x0000000189B4C760-0x0000000189B4C780 */ protected set {} } // 0x000000018384B0E0-0x000000018384B1B0 0x000000018384A5B0-0x000000018384A690
	public uint orderId { /* [XID] */ /* 0x0000000189B53E20-0x0000000189B53E40 */ get => default; /* [XID] */ /* 0x0000000189B5B730-0x0000000189B5B750 */ protected set {} } // 0x000000018384A4E0-0x000000018384A5B0 0x000000018384AE10-0x000000018384AEF0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B62B20-0x0000000189B62B40 */ get => default; /* [XID] */ /* 0x0000000189B6A630-0x0000000189B6A650 */ protected set {} } // 0x0000000183849CF0-0x0000000183849D90 0x000000018384AD60-0x000000018384AE10
	public string name { /* [XID] */ /* 0x0000000189B71DD0-0x0000000189B71DF0 */ get => default; } // 0x000000018384B1B0-0x000000018384B330 
	public uint finishRewardId { /* [XID] */ /* 0x0000000189B791E0-0x0000000189B79200 */ get => default; /* [XID] */ /* 0x0000000189B805F0-0x0000000189B80610 */ protected set {} } // 0x0000000183849A80-0x0000000183849B50 0x000000018384ABE0-0x000000018384ACC0
	public string iconPath { /* [XID] */ /* 0x0000000189B881C0-0x0000000189B881E0 */ get => default; /* [XID] */ /* 0x0000000189B8F490-0x0000000189B8F4B0 */ protected set {} } // 0x000000018384ACC0-0x000000018384AD60 0x000000018384AEF0-0x000000018384AFA0

	// Constructors
	public AchievementGoalExcelConfig() {} // 0x000000018384B3D0-0x000000018384B430

	// Methods
	// [IDTag] // 0x0000000189B968D0-0x0000000189B96910
	// [XID] // 0x0000000189B968D0-0x0000000189B96910
	public virtual bool ParseFromLine(string line) => default; // 0x000000018384A120-0x000000018384A4E0
	// [IDTag] // 0x0000000189BA0E10-0x0000000189BA0E50
	// [XID] // 0x0000000189BA0E10-0x0000000189BA0E50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183849D90-0x000000018384A120
	// [XID] // 0x0000000189BAB460-0x0000000189BAB480
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDEE */, bool useObjectPool = false /* Metadata: 0x00AEFDF2 */) => default; // 0x000000018384A690-0x000000018384ABE0
	[BlackList] // 0x0000000189BB2A70-0x0000000189BB2AB0
	// [XID] // 0x0000000189BB2A70-0x0000000189BB2AB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183849B50-0x0000000183849BF0
	[BlackList] // 0x0000000189BBCFC0-0x0000000189BBD000
	// [XID] // 0x0000000189BBCFC0-0x0000000189BBD000
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183849BF0-0x0000000183849CF0
	[BlackList] // 0x0000000189BC7A20-0x0000000189BC7A60
	// [XID] // 0x0000000189BC7A20-0x0000000189BC7A60
	public virtual void ReturnToObjectPool() {} // 0x000000018384B330-0x000000018384B3D0
	[BlackList] // 0x0000000189BD2540-0x0000000189BD2580
	// [XID] // 0x0000000189BD2540-0x0000000189BD2580
	public virtual void OnPoolAllocated() {} // 0x000000018384B040-0x000000018384B0E0
	[BlackList] // 0x0000000189BDCF00-0x0000000189BDCF40
	// [XID] // 0x0000000189BDCF00-0x0000000189BDCF40
	public virtual void OnBeforePoolRecycled() {} // 0x000000018384AFA0-0x000000018384B040
}

