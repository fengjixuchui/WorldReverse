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
public class ChannellerSlabLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15042
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 stageIDRawNum; // 0x14
	protected SimpleSafeUInt32 waveIDRawNum; // 0x18
	protected uint _pointNameTextMapHash; // 0x1C
	protected uint _campNameTextMapHash; // 0x20
	protected uint _descTextMapHash; // 0x24
	protected SimpleSafeUInt32 previewRewardIDRawNum; // 0x28
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x2C
	protected SimpleSafeUInt32 groupIDRawNum; // 0x30
	protected SimpleSafeUInt32 buffNumRawNum; // 0x34

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BA6E80-0x0000000189BA6EA0 */ get => default; /* [XID] */ /* 0x0000000189BADFC0-0x0000000189BADFE0 */ protected set {} } // 0x00000001817B6710-0x00000001817B67E0 0x00000001817B55A0-0x00000001817B5680
	public uint stageID { /* [XID] */ /* 0x0000000189BB5890-0x0000000189BB58B0 */ get => default; /* [XID] */ /* 0x0000000189BBCFA0-0x0000000189BBCFC0 */ protected set {} } // 0x00000001817B4040-0x00000001817B4110 0x00000001817B6450-0x00000001817B6530
	public uint waveID { /* [XID] */ /* 0x0000000189BC4BC0-0x0000000189BC4BE0 */ get => default; /* [XID] */ /* 0x0000000189BCC640-0x0000000189BCC660 */ protected set {} } // 0x00000001817B4380-0x00000001817B4450 0x00000001817B4110-0x00000001817B41F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint pointNameTextMapHash { /* [XID] */ /* 0x0000000189BD3CF0-0x0000000189BD3D10 */ get => default; /* [XID] */ /* 0x0000000189BDB5C0-0x0000000189BDB5E0 */ protected set {} } // 0x00000001817B6530-0x00000001817B65D0 0x00000001817B4450-0x00000001817B4500
	public string pointName { /* [XID] */ /* 0x00000001895E7EF0-0x00000001895E7F10 */ get => default; } // 0x00000001817B3EC0-0x00000001817B4040 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint campNameTextMapHash { /* [XID] */ /* 0x00000001895EF8C0-0x00000001895EF8E0 */ get => default; /* [XID] */ /* 0x00000001895F7140-0x00000001895F7160 */ protected set {} } // 0x00000001817B5380-0x00000001817B5420 0x00000001817B5F00-0x00000001817B5FB0
	public string campName { /* [XID] */ /* 0x00000001895FE500-0x00000001895FE520 */ get => default; } // 0x00000001817B6200-0x00000001817B6380 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189605F50-0x0000000189605F70 */ get => default; /* [XID] */ /* 0x000000018960D760-0x000000018960D780 */ protected set {} } // 0x00000001817B6160-0x00000001817B6200 0x00000001817B41F0-0x00000001817B42A0
	public string desc { /* [XID] */ /* 0x0000000189614FC0-0x0000000189614FE0 */ get => default; } // 0x00000001817B5420-0x00000001817B55A0 
	public uint previewRewardID { /* [XID] */ /* 0x000000018961C720-0x000000018961C740 */ get => default; /* [XID] */ /* 0x0000000189623B80-0x0000000189623BA0 */ protected set {} } // 0x00000001817B5100-0x00000001817B51D0 0x00000001817B5FB0-0x00000001817B6090
	public uint rewardID { /* [XID] */ /* 0x000000018962B3E0-0x000000018962B400 */ get => default; /* [XID] */ /* 0x0000000189632B60-0x0000000189632B80 */ protected set {} } // 0x00000001817B52B0-0x00000001817B5380 0x00000001817B51D0-0x00000001817B52B0
	public uint groupID { /* [XID] */ /* 0x000000018963A5F0-0x000000018963A610 */ get => default; /* [XID] */ /* 0x0000000189641D40-0x0000000189641D60 */ protected set {} } // 0x00000001817B6380-0x00000001817B6450 0x00000001817B42A0-0x00000001817B4380
	public uint buffNum { /* [XID] */ /* 0x00000001896495A0-0x00000001896495C0 */ get => default; /* [XID] */ /* 0x0000000189650C10-0x0000000189650C30 */ protected set {} } // 0x00000001817B6090-0x00000001817B6160 0x00000001817B67E0-0x00000001817B68C0

	// Constructors
	public ChannellerSlabLevelExcelConfig() {} // 0x00000001817B6960-0x00000001817B69C0

	// Methods
	// [IDTag] // 0x0000000189658490-0x00000001896584D0
	// [XID] // 0x0000000189658490-0x00000001896584D0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817B4500-0x00000001817B4B00
	// [IDTag] // 0x0000000189662960-0x00000001896629A0
	// [XID] // 0x0000000189662960-0x00000001896629A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817B4B00-0x00000001817B5100
	// [XID] // 0x000000018966D1A0-0x000000018966D1C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF41 */, bool useObjectPool = false /* Metadata: 0x00AEFF45 */) => default; // 0x00000001817B5680-0x00000001817B5F00
	[BlackList] // 0x00000001896750D0-0x0000000189675110
	// [XID] // 0x00000001896750D0-0x0000000189675110
	public virtual void AutoAllocTypeFields() {} // 0x00000001817B3CD0-0x00000001817B3D70
	[BlackList] // 0x000000018967F7A0-0x000000018967F7E0
	// [XID] // 0x000000018967F7A0-0x000000018967F7E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817B3D70-0x00000001817B3EC0
	[BlackList] // 0x000000018968A1D0-0x000000018968A210
	// [XID] // 0x000000018968A1D0-0x000000018968A210
	public virtual void ReturnToObjectPool() {} // 0x00000001817B68C0-0x00000001817B6960
	[BlackList] // 0x0000000189694C00-0x0000000189694C40
	// [XID] // 0x0000000189694C00-0x0000000189694C40
	public virtual void OnPoolAllocated() {} // 0x00000001817B6670-0x00000001817B6710
	[BlackList] // 0x000000018969F130-0x000000018969F170
	// [XID] // 0x000000018969F130-0x000000018969F170
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817B65D0-0x00000001817B6670
}

