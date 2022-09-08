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
public class MechanicusDifficultyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16220
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected uint _descTextMapHash; // 0x14
	protected SimpleSafeUInt32[] _dungeonList; // 0x18
	protected SimpleSafeUInt32 coinRateRawNum; // 0x20
	protected SimpleSafeUInt32 buildGearLimitRawNum; // 0x24

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189B81F10-0x0000000189B81F30 */ get => default; /* [XID] */ /* 0x0000000189B89610-0x0000000189B89630 */ protected set {} } // 0x00000001822424E0-0x00000001822425B0 0x0000000182242400-0x00000001822424E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B90C10-0x0000000189B90C30 */ get => default; /* [XID] */ /* 0x0000000189B97F40-0x0000000189B97F60 */ protected set {} } // 0x0000000182242690-0x0000000182242730 0x0000000182240E60-0x0000000182240F10
	public string desc { /* [XID] */ /* 0x0000000189B9F370-0x0000000189B9F390 */ get => default; } // 0x0000000182241D30-0x0000000182241EB0 
	public SimpleSafeUInt32[] dungeonList { /* [XID] */ /* 0x0000000189BA6C00-0x0000000189BA6C20 */ get => default; /* [XID] */ /* 0x0000000189BADD80-0x0000000189BADDA0 */ protected set {} } // 0x0000000182240F10-0x0000000182240FB0 0x0000000182241AD0-0x0000000182241B80
	public uint coinRate { /* [XID] */ /* 0x0000000189BB5590-0x0000000189BB55B0 */ get => default; /* [XID] */ /* 0x0000000189BBCCA0-0x0000000189BBCCC0 */ protected set {} } // 0x0000000182241C60-0x0000000182241D30 0x0000000182241B80-0x0000000182241C60
	public uint buildGearLimit { /* [XID] */ /* 0x0000000189BC4920-0x0000000189BC4940 */ get => default; /* [XID] */ /* 0x0000000189BCC340-0x0000000189BCC360 */ protected set {} } // 0x0000000182242870-0x0000000182242940 0x00000001822425B0-0x0000000182242690

	// Constructors
	public MechanicusDifficultyExcelConfig() {} // 0x00000001822429E0-0x0000000182242A40

	// Methods
	// [IDTag] // 0x0000000189BD39D0-0x0000000189BD3A10
	// [XID] // 0x0000000189BD39D0-0x0000000189BD3A10
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182241530-0x0000000182241AD0
	// [IDTag] // 0x0000000189BDE360-0x0000000189BDE3A0
	// [XID] // 0x0000000189BDE360-0x0000000189BDE3A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182240FB0-0x0000000182241530
	// [XID] // 0x00000001895EDD10-0x00000001895EDD30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34AF */, bool useObjectPool = false /* Metadata: 0x00AF34B3 */) => default; // 0x0000000182241EB0-0x0000000182242400
	[BlackList] // 0x00000001895F5570-0x00000001895F55B0
	// [XID] // 0x00000001895F5570-0x00000001895F55B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182240CC0-0x0000000182240D60
	[BlackList] // 0x00000001895FFAD0-0x00000001895FFB10
	// [XID] // 0x00000001895FFAD0-0x00000001895FFB10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182240D60-0x0000000182240E60
	[BlackList] // 0x000000018960A5D0-0x000000018960A610
	// [XID] // 0x000000018960A5D0-0x000000018960A610
	public virtual void ReturnToObjectPool() {} // 0x0000000182242940-0x00000001822429E0
	[BlackList] // 0x0000000189614C60-0x0000000189614CA0
	// [XID] // 0x0000000189614C60-0x0000000189614CA0
	public virtual void OnPoolAllocated() {} // 0x00000001822427D0-0x0000000182242870
	[BlackList] // 0x000000018961F540-0x000000018961F580
	// [XID] // 0x000000018961F540-0x000000018961F580
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182242730-0x00000001822427D0
}

