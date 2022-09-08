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
public class ChannellerSlabLoopDungeonExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15052
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 openDayRawNum; // 0x14
	protected uint _titleTextMapHash; // 0x18
	protected uint _contentTextMapHash; // 0x1C
	protected SimpleSafeUInt32[] _monsterIdVec; // 0x20
	protected SimpleSafeUInt32[] _limitingConditionVec; // 0x28
	protected SimpleSafeUInt32 firstPassRewardIdRawNum; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x000000018977A9E0-0x000000018977AA00 */ get => default; /* [XID] */ /* 0x00000001897825C0-0x00000001897825E0 */ protected set {} } // 0x00000001819674E0-0x00000001819675B0 0x00000001819665B0-0x0000000181966690
	public uint openDay { /* [XID] */ /* 0x00000001897898C0-0x00000001897898E0 */ get => default; /* [XID] */ /* 0x00000001897910F0-0x0000000189791110 */ protected set {} } // 0x0000000181967230-0x0000000181967300 0x0000000181964EB0-0x0000000181964F90
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189798920-0x0000000189798940 */ get => default; /* [XID] */ /* 0x00000001897A06B0-0x00000001897A06D0 */ protected set {} } // 0x0000000181965130-0x00000001819651D0 0x0000000181965280-0x0000000181965330
	public string title { /* [XID] */ /* 0x00000001897A7CC0-0x00000001897A7CE0 */ get => default; } // 0x0000000181967000-0x0000000181967180 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x00000001897AF770-0x00000001897AF790 */ get => default; /* [XID] */ /* 0x00000001897B7610-0x00000001897B7630 */ protected set {} } // 0x0000000181966F60-0x0000000181967000 0x0000000181966690-0x0000000181966740
	public string content { /* [XID] */ /* 0x00000001897BF4D0-0x00000001897BF4F0 */ get => default; } // 0x0000000181966DE0-0x0000000181966F60 
	public SimpleSafeUInt32[] monsterIdVec { /* [XID] */ /* 0x00000001897C6BA0-0x00000001897C6BC0 */ get => default; /* [XID] */ /* 0x00000001897CE360-0x00000001897CE380 */ protected set {} } // 0x0000000181967300-0x00000001819673A0 0x00000001819651D0-0x0000000181965280
	public SimpleSafeUInt32[] limitingConditionVec { /* [XID] */ /* 0x00000001897D58F0-0x00000001897D5910 */ get => default; /* [XID] */ /* 0x00000001897DD010-0x00000001897DD030 */ protected set {} } // 0x0000000181964E10-0x0000000181964EB0 0x0000000181967180-0x0000000181967230
	public uint firstPassRewardId { /* [XID] */ /* 0x00000001897E48F0-0x00000001897E4910 */ get => default; /* [XID] */ /* 0x00000001897EC540-0x00000001897EC560 */ protected set {} } // 0x00000001819664E0-0x00000001819665B0 0x0000000181965330-0x0000000181965410

	// Constructors
	public ChannellerSlabLoopDungeonExcelConfig() {} // 0x0000000181967650-0x00000001819676B0

	// Methods
	// [IDTag] // 0x00000001897F3E90-0x00000001897F3ED0
	// [XID] // 0x00000001897F3E90-0x00000001897F3ED0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181965C70-0x00000001819664E0
	// [IDTag] // 0x00000001897FE100-0x00000001897FE140
	// [XID] // 0x00000001897FE100-0x00000001897FE140
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181965410-0x0000000181965C70
	// [XID] // 0x0000000189808980-0x00000001898089A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF78 */, bool useObjectPool = false /* Metadata: 0x00AEFF7C */) => default; // 0x0000000181966740-0x0000000181966DE0
	[BlackList] // 0x0000000189810370-0x00000001898103B0
	// [XID] // 0x0000000189810370-0x00000001898103B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181964F90-0x0000000181965030
	[BlackList] // 0x000000018981AB00-0x000000018981AB40
	// [XID] // 0x000000018981AB00-0x000000018981AB40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181965030-0x0000000181965130
	[BlackList] // 0x0000000189824F40-0x0000000189824F80
	// [XID] // 0x0000000189824F40-0x0000000189824F80
	public virtual void ReturnToObjectPool() {} // 0x00000001819675B0-0x0000000181967650
	[BlackList] // 0x000000018982F5A0-0x000000018982F5E0
	// [XID] // 0x000000018982F5A0-0x000000018982F5E0
	public virtual void OnPoolAllocated() {} // 0x0000000181967440-0x00000001819674E0
	[BlackList] // 0x0000000189839BE0-0x0000000189839C20
	// [XID] // 0x0000000189839BE0-0x0000000189839C20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001819673A0-0x0000000181967440
}

