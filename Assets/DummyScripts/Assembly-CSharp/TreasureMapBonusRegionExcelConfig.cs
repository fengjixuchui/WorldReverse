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
public class TreasureMapBonusRegionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15196
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 unlock_region_idRawNum; // 0x14
	protected SimpleSafeUInt32 group_idRawNum; // 0x18
	protected SimpleSafeUInt32 reward_idRawNum; // 0x1C
	protected SimpleSafeUInt32 revise_levelRawNum; // 0x20
	protected uint _map_titleTextMapHash; // 0x24
	protected uint _map_descTextMapHash; // 0x28
	protected string _show_image; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896B3850-0x00000001896B3870 */ get => default; /* [XID] */ /* 0x00000001896BAF50-0x00000001896BAF70 */ protected set {} } // 0x0000000184B05910-0x0000000184B059E0 0x0000000184B04C80-0x0000000184B04D60
	public uint unlock_region_id { /* [XID] */ /* 0x00000001896C2100-0x00000001896C2120 */ get => default; /* [XID] */ /* 0x00000001896C9710-0x00000001896C9730 */ protected set {} } // 0x0000000184B03B50-0x0000000184B03C20 0x0000000184B04890-0x0000000184B04970
	public uint group_id { /* [XID] */ /* 0x00000001896D0E60-0x00000001896D0E80 */ get => default; /* [XID] */ /* 0x00000001896D85B0-0x00000001896D85D0 */ protected set {} } // 0x0000000184B059E0-0x0000000184B05AB0 0x0000000184B04AF0-0x0000000184B04BD0
	public uint reward_id { /* [XID] */ /* 0x00000001896DFFA0-0x00000001896DFFC0 */ get => default; /* [XID] */ /* 0x00000001896E71C0-0x00000001896E71E0 */ protected set {} } // 0x0000000184B05570-0x0000000184B05640 0x0000000184B05640-0x0000000184B05720
	public uint revise_level { /* [XID] */ /* 0x00000001896EE830-0x00000001896EE850 */ get => default; /* [XID] */ /* 0x00000001896F60C0-0x00000001896F60E0 */ protected set {} } // 0x0000000184B054A0-0x0000000184B05570 0x0000000184B03C20-0x0000000184B03D00
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint map_titleTextMapHash { /* [XID] */ /* 0x00000001896FD8F0-0x00000001896FD910 */ get => default; /* [XID] */ /* 0x0000000189704D90-0x0000000189704DB0 */ protected set {} } // 0x0000000184B03960-0x0000000184B03A00 0x0000000184B05720-0x0000000184B057D0
	public string map_title { /* [XID] */ /* 0x000000018970C490-0x000000018970C4B0 */ get => default; } // 0x0000000184B04970-0x0000000184B04AF0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint map_descTextMapHash { /* [XID] */ /* 0x0000000189713E00-0x0000000189713E20 */ get => default; /* [XID] */ /* 0x000000018971B680-0x000000018971B6A0 */ protected set {} } // 0x0000000184B03A00-0x0000000184B03AA0 0x0000000184B04BD0-0x0000000184B04C80
	public string map_desc { /* [XID] */ /* 0x00000001897228C0-0x00000001897228E0 */ get => default; } // 0x0000000184B04710-0x0000000184B04890 
	public string show_image { /* [XID] */ /* 0x000000018972A020-0x000000018972A040 */ get => default; /* [XID] */ /* 0x00000001897316C0-0x00000001897316E0 */ protected set {} } // 0x0000000184B036F0-0x0000000184B03790 0x0000000184B03AA0-0x0000000184B03B50

	// Constructors
	public TreasureMapBonusRegionExcelConfig() {} // 0x0000000184B05B50-0x0000000184B05BB0

	// Methods
	// [IDTag] // 0x0000000189738F10-0x0000000189738F50
	// [XID] // 0x0000000189738F10-0x0000000189738F50
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B03D00-0x0000000184B04210
	// [IDTag] // 0x0000000189743950-0x0000000189743990
	// [XID] // 0x0000000189743950-0x0000000189743990
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B04210-0x0000000184B04710
	// [XID] // 0x000000018974E370-0x000000018974E390
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0386 */, bool useObjectPool = false /* Metadata: 0x00AF038A */) => default; // 0x0000000184B04D60-0x0000000184B054A0
	[BlackList] // 0x0000000189755990-0x00000001897559D0
	// [XID] // 0x0000000189755990-0x00000001897559D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B03790-0x0000000184B03830
	[BlackList] // 0x000000018975FEF0-0x000000018975FF30
	// [XID] // 0x000000018975FEF0-0x000000018975FF30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B03830-0x0000000184B03960
	[BlackList] // 0x000000018976A4D0-0x000000018976A510
	// [XID] // 0x000000018976A4D0-0x000000018976A510
	public virtual void ReturnToObjectPool() {} // 0x0000000184B05AB0-0x0000000184B05B50
	[BlackList] // 0x00000001897748B0-0x00000001897748F0
	// [XID] // 0x00000001897748B0-0x00000001897748F0
	public virtual void OnPoolAllocated() {} // 0x0000000184B05870-0x0000000184B05910
	[BlackList] // 0x000000018977F0E0-0x000000018977F120
	// [XID] // 0x000000018977F0E0-0x000000018977F120
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B057D0-0x0000000184B05870
}

