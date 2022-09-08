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
public class MonsterTitleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15850
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 titleIDRawNum; // 0x10
	protected uint _titleNameTextMapHash; // 0x14
	protected bool _isInverted; // 0x18
	protected string _desc; // 0x20

	// Properties
	public uint titleID { /* [XID] */ /* 0x000000018976D320-0x000000018976D340 */ get => default; /* [XID] */ /* 0x0000000189774770-0x0000000189774790 */ protected set {} } // 0x00000001831197C0-0x0000000183119890 0x0000000183119560-0x0000000183119640
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleNameTextMapHash { /* [XID] */ /* 0x000000018977C1C0-0x000000018977C1E0 */ get => default; /* [XID] */ /* 0x0000000189783BF0-0x0000000189783C10 */ protected set {} } // 0x0000000183119890-0x0000000183119930 0x000000018311A630-0x000000018311A6E0
	public string titleName { /* [XID] */ /* 0x000000018978B380-0x000000018978B3A0 */ get => default; } // 0x000000018311A8D0-0x000000018311AA50 
	public bool isInverted { /* [XID] */ /* 0x0000000189792820-0x0000000189792840 */ get => default; /* [XID] */ /* 0x0000000189799DB0-0x0000000189799DD0 */ protected set {} } // 0x0000000183119F90-0x000000018311A030 0x000000018311A030-0x000000018311A0E0
	public string desc { /* [XID] */ /* 0x00000001897A1D00-0x00000001897A1D20 */ get => default; /* [XID] */ /* 0x00000001897A94E0-0x00000001897A9500 */ protected set {} } // 0x000000018311A0E0-0x000000018311A180 0x000000018311A6E0-0x000000018311A790

	// Constructors
	public MonsterTitleExcelConfig() {} // 0x000000018311AAF0-0x000000018311AB50

	// Methods
	// [IDTag] // 0x00000001897B0C60-0x00000001897B0CA0
	// [XID] // 0x00000001897B0C60-0x00000001897B0CA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183119930-0x0000000183119C80
	// [IDTag] // 0x00000001897BC0F0-0x00000001897BC130
	// [XID] // 0x00000001897BC0F0-0x00000001897BC130
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183119C80-0x0000000183119F90
	// [XID] // 0x00000001897C69A0-0x00000001897C69C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2854 */, bool useObjectPool = false /* Metadata: 0x00AF2858 */) => default; // 0x000000018311A180-0x000000018311A630
	[BlackList] // 0x00000001897CE160-0x00000001897CE1A0
	// [XID] // 0x00000001897CE160-0x00000001897CE1A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183119640-0x00000001831196E0
	[BlackList] // 0x00000001897D8DF0-0x00000001897D8E30
	// [XID] // 0x00000001897D8DF0-0x00000001897D8E30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831196E0-0x00000001831197C0
	[BlackList] // 0x00000001897E3060-0x00000001897E30A0
	// [XID] // 0x00000001897E3060-0x00000001897E30A0
	public virtual void ReturnToObjectPool() {} // 0x000000018311AA50-0x000000018311AAF0
	[BlackList] // 0x00000001897EDB70-0x00000001897EDBB0
	// [XID] // 0x00000001897EDB70-0x00000001897EDBB0
	public virtual void OnPoolAllocated() {} // 0x000000018311A830-0x000000018311A8D0
	[BlackList] // 0x00000001897F84A0-0x00000001897F84E0
	// [XID] // 0x00000001897F84A0-0x00000001897F84E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018311A790-0x000000018311A830
}

