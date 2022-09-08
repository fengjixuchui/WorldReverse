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
public class HomeWorldComfortLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15730
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 levelIDRawNum; // 0x10
	protected SimpleSafeUInt32 comfortRawNum; // 0x14
	protected SimpleSafeUInt32 homeCoinProduceRateRawNum; // 0x18
	protected SimpleSafeUInt32 companionshipExpProduceRateRawNum; // 0x1C
	protected uint _levelNameTextMapHash; // 0x20
	protected byte _levelIconHashPre; // 0x24
	protected uint _levelIconHashSuffix; // 0x28

	// Properties
	public uint levelID { /* [XID] */ /* 0x0000000189BA2870-0x0000000189BA2890 */ get => default; /* [XID] */ /* 0x0000000189BA9C80-0x0000000189BA9CA0 */ protected set {} } // 0x0000000183A085E0-0x0000000183A086B0 0x0000000183A09190-0x0000000183A09270
	public uint comfort { /* [XID] */ /* 0x0000000189BB1550-0x0000000189BB1570 */ get => default; /* [XID] */ /* 0x0000000189BB8520-0x0000000189BB8540 */ protected set {} } // 0x0000000183A09620-0x0000000183A096F0 0x0000000183A09270-0x0000000183A09350
	public uint homeCoinProduceRate { /* [XID] */ /* 0x0000000189BBFE50-0x0000000189BBFE70 */ get => default; /* [XID] */ /* 0x0000000189BC7860-0x0000000189BC7880 */ protected set {} } // 0x0000000183A09E20-0x0000000183A09EF0 0x0000000183A09EF0-0x0000000183A09FD0
	public uint companionshipExpProduceRate { /* [XID] */ /* 0x0000000189BCF410-0x0000000189BCF430 */ get => default; /* [XID] */ /* 0x0000000189BD67E0-0x0000000189BD6800 */ protected set {} } // 0x0000000183A08210-0x0000000183A082E0 0x0000000183A09D40-0x0000000183A09E20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelNameTextMapHash { /* [XID] */ /* 0x0000000189BDE4C0-0x0000000189BDE4E0 */ get => default; /* [XID] */ /* 0x00000001895EB010-0x00000001895EB030 */ protected set {} } // 0x0000000183A086B0-0x0000000183A08750 0x0000000183A094A0-0x0000000183A09550
	public string levelName { /* [XID] */ /* 0x00000001895F2450-0x00000001895F2470 */ get => default; } // 0x0000000183A08750-0x0000000183A088D0 
	public byte levelIconHashPre { /* [XID] */ /* 0x00000001895F9E40-0x00000001895F9E60 */ get => default; /* [XID] */ /* 0x0000000189601680-0x00000001896016A0 */ protected set {} } // 0x0000000183A082E0-0x0000000183A08380 0x0000000183A08380-0x0000000183A08430
	public uint levelIconHashSuffix { /* [XID] */ /* 0x0000000189608F10-0x0000000189608F30 */ get => default; /* [XID] */ /* 0x00000001896106D0-0x00000001896106F0 */ protected set {} } // 0x0000000183A09350-0x0000000183A093F0 0x0000000183A093F0-0x0000000183A094A0
	public ulong levelIconHash { /* [XID] */ /* 0x00000001896179D0-0x00000001896179F0 */ get => default; } // 0x0000000183A09550-0x0000000183A09620 

	// Constructors
	public HomeWorldComfortLevelExcelConfig() {} // 0x0000000183A0A1B0-0x0000000183A0A210

	// Methods
	// [IDTag] // 0x000000018961F5E0-0x000000018961F620
	// [XID] // 0x000000018961F5E0-0x000000018961F620
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183A08D20-0x0000000183A09190
	// [IDTag] // 0x0000000189629BD0-0x0000000189629C10
	// [XID] // 0x0000000189629BD0-0x0000000189629C10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183A088D0-0x0000000183A08D20
	// [XID] // 0x0000000189634630-0x0000000189634650
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2477 */, bool useObjectPool = false /* Metadata: 0x00AF247B */) => default; // 0x0000000183A096F0-0x0000000183A09D40
	[BlackList] // 0x000000018963BD60-0x000000018963BDA0
	// [XID] // 0x000000018963BD60-0x000000018963BDA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A08430-0x0000000183A084D0
	[BlackList] // 0x0000000189646360-0x00000001896463A0
	// [XID] // 0x0000000189646360-0x00000001896463A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A084D0-0x0000000183A085E0
	[BlackList] // 0x0000000189650AD0-0x0000000189650B10
	// [XID] // 0x0000000189650AD0-0x0000000189650B10
	public virtual void ReturnToObjectPool() {} // 0x0000000183A0A110-0x0000000183A0A1B0
	[BlackList] // 0x000000018965B3F0-0x000000018965B430
	// [XID] // 0x000000018965B3F0-0x000000018965B430
	public virtual void OnPoolAllocated() {} // 0x0000000183A0A070-0x0000000183A0A110
	[BlackList] // 0x0000000189665970-0x00000001896659B0
	// [XID] // 0x0000000189665970-0x00000001896659B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A09FD0-0x0000000183A0A070
}

