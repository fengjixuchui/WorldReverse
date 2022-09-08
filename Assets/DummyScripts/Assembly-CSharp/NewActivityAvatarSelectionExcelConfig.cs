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
public class NewActivityAvatarSelectionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15897
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected SimpleSafeUInt32 condIdRawNum; // 0x14
	protected SimpleSafeUInt32[] _avatarRewardList; // 0x18
	protected SimpleSafeUInt32 costItemIdRawNum; // 0x20
	protected SimpleSafeUInt32 costItemNumRawNum; // 0x24
	protected uint _descTextMapHash; // 0x28

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x00000001895E95B0-0x00000001895E95D0 */ get => default; /* [XID] */ /* 0x00000001895F0D20-0x00000001895F0D40 */ protected set {} } // 0x0000000184D03490-0x0000000184D03560 0x0000000184D050D0-0x0000000184D051B0
	public uint condId { /* [XID] */ /* 0x00000001895F8710-0x00000001895F8730 */ get => default; /* [XID] */ /* 0x00000001895FFBF0-0x00000001895FFC10 */ protected set {} } // 0x0000000184D04DE0-0x0000000184D04EB0 0x0000000184D03560-0x0000000184D03640
	public SimpleSafeUInt32[] avatarRewardList { /* [XID] */ /* 0x0000000189607340-0x0000000189607360 */ get => default; /* [XID] */ /* 0x000000018960EDE0-0x000000018960EE00 */ protected set {} } // 0x0000000184D05030-0x0000000184D050D0 0x0000000184D053C0-0x0000000184D05470
	public uint costItemId { /* [XID] */ /* 0x00000001896163E0-0x0000000189616400 */ get => default; /* [XID] */ /* 0x000000018961DC10-0x000000018961DC30 */ protected set {} } // 0x0000000184D051B0-0x0000000184D05280 0x0000000184D04EB0-0x0000000184D04F90
	public uint costItemNum { /* [XID] */ /* 0x0000000189625070-0x0000000189625090 */ get => default; /* [XID] */ /* 0x000000018962C8F0-0x000000018962C910 */ protected set {} } // 0x0000000184D044C0-0x0000000184D04590 0x0000000184D04710-0x0000000184D047F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189634610-0x0000000189634630 */ get => default; /* [XID] */ /* 0x000000018963BD40-0x000000018963BD60 */ protected set {} } // 0x0000000184D04F90-0x0000000184D05030 0x0000000184D037F0-0x0000000184D038A0
	public string desc { /* [XID] */ /* 0x0000000189643460-0x0000000189643480 */ get => default; } // 0x0000000184D04590-0x0000000184D04710 

	// Constructors
	public NewActivityAvatarSelectionExcelConfig() {} // 0x0000000184D05510-0x0000000184D05570

	// Methods
	// [IDTag] // 0x000000018964AA20-0x000000018964AA60
	// [XID] // 0x000000018964AA20-0x000000018964AA60
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184D03EA0-0x0000000184D044C0
	// [IDTag] // 0x0000000189655340-0x0000000189655380
	// [XID] // 0x0000000189655340-0x0000000189655380
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184D038A0-0x0000000184D03EA0
	// [XID] // 0x000000018965F8E0-0x000000018965F900
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A8C */, bool useObjectPool = false /* Metadata: 0x00AF2A90 */) => default; // 0x0000000184D047F0-0x0000000184D04DE0
	[BlackList] // 0x0000000189667330-0x0000000189667370
	// [XID] // 0x0000000189667330-0x0000000189667370
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D03640-0x0000000184D036E0
	[BlackList] // 0x0000000189671FA0-0x0000000189671FE0
	// [XID] // 0x0000000189671FA0-0x0000000189671FE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D036E0-0x0000000184D037F0
	[BlackList] // 0x000000018967C6A0-0x000000018967C6E0
	// [XID] // 0x000000018967C6A0-0x000000018967C6E0
	public virtual void ReturnToObjectPool() {} // 0x0000000184D05470-0x0000000184D05510
	[BlackList] // 0x0000000189686D70-0x0000000189686DB0
	// [XID] // 0x0000000189686D70-0x0000000189686DB0
	public virtual void OnPoolAllocated() {} // 0x0000000184D05320-0x0000000184D053C0
	[BlackList] // 0x0000000189691D90-0x0000000189691DD0
	// [XID] // 0x0000000189691D90-0x0000000189691DD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D05280-0x0000000184D05320
}

