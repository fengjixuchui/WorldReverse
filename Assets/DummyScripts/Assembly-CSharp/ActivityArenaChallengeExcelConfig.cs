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
public class ActivityArenaChallengeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15009
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x14
	protected SimpleSafeUInt32 arenaChallengeIdRawNum; // 0x18
	protected SimpleSafeUInt32 arenaChallengeLevelRawNum; // 0x1C
	protected SimpleSafeUInt32 watcherIdRawNum; // 0x20
	protected SimpleSafeUInt32[] _groupIdList; // 0x28
	protected uint _challengeTargetTextMapHash; // 0x30
	protected uint _challengeTarget1TextMapHash; // 0x34
	protected uint _challengeTarget2TextMapHash; // 0x38

	// Properties
	public uint ID { /* [XID] */ /* 0x000000018979F0D0-0x000000018979F0F0 */ get => default; /* [XID] */ /* 0x00000001897A6720-0x00000001897A6740 */ protected set {} } // 0x0000000184849C00-0x0000000184849CD0 0x0000000184848230-0x0000000184848310
	public uint scheduleId { /* [XID] */ /* 0x00000001897ADD50-0x00000001897ADD70 */ get => default; /* [XID] */ /* 0x00000001897B5E70-0x00000001897B5E90 */ protected set {} } // 0x0000000184848160-0x0000000184848230 0x000000018484A6E0-0x000000018484A7C0
	public uint arenaChallengeId { /* [XID] */ /* 0x00000001897BDC60-0x00000001897BDC80 */ get => default; /* [XID] */ /* 0x00000001897C5040-0x00000001897C5060 */ protected set {} } // 0x000000018484A610-0x000000018484A6E0 0x000000018484A860-0x000000018484A940
	public uint arenaChallengeLevel { /* [XID] */ /* 0x00000001897CC870-0x00000001897CC890 */ get => default; /* [XID] */ /* 0x00000001897D40E0-0x00000001897D4100 */ protected set {} } // 0x000000018484AB60-0x000000018484AC30 0x0000000184848920-0x0000000184848A00
	public uint watcherId { /* [XID] */ /* 0x00000001897DB9B0-0x00000001897DB9D0 */ get => default; /* [XID] */ /* 0x00000001897E3240-0x00000001897E3260 */ protected set {} } // 0x0000000184849B30-0x0000000184849C00 0x0000000184848A00-0x0000000184848AE0
	public SimpleSafeUInt32[] groupIdList { /* [XID] */ /* 0x00000001897EA9E0-0x00000001897EAA00 */ get => default; /* [XID] */ /* 0x00000001897F2770-0x00000001897F2790 */ protected set {} } // 0x000000018484A940-0x000000018484A9E0 0x0000000184849D80-0x0000000184849E30
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeTargetTextMapHash { /* [XID] */ /* 0x00000001897F9F40-0x00000001897F9F60 */ get => default; /* [XID] */ /* 0x0000000189801520-0x0000000189801540 */ protected set {} } // 0x0000000184848880-0x0000000184848920 0x0000000184849A80-0x0000000184849B30
	public string challengeTarget { /* [XID] */ /* 0x00000001898089A0-0x00000001898089C0 */ get => default; } // 0x000000018484A9E0-0x000000018484AB60 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeTarget1TextMapHash { /* [XID] */ /* 0x00000001898103B0-0x00000001898103D0 */ get => default; /* [XID] */ /* 0x0000000189817A40-0x0000000189817A60 */ protected set {} } // 0x000000018484A7C0-0x000000018484A860 0x00000001848499D0-0x0000000184849A80
	public string challengeTarget1 { /* [XID] */ /* 0x000000018981F340-0x000000018981F360 */ get => default; } // 0x0000000184848310-0x0000000184848490 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeTarget2TextMapHash { /* [XID] */ /* 0x0000000189826830-0x0000000189826850 */ get => default; /* [XID] */ /* 0x000000018982DF40-0x000000018982DF60 */ protected set {} } // 0x0000000184848660-0x0000000184848700 0x0000000184849CD0-0x0000000184849D80
	public string challengeTarget2 { /* [XID] */ /* 0x0000000189835570-0x0000000189835590 */ get => default; } // 0x0000000184848700-0x0000000184848880 

	// Constructors
	public ActivityArenaChallengeExcelConfig() {} // 0x000000018484AE10-0x000000018484AE70

	// Methods
	// [IDTag] // 0x000000018983CD50-0x000000018983CD90
	// [XID] // 0x000000018983CD50-0x000000018983CD90
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184849260-0x00000001848499D0
	// [IDTag] // 0x0000000189847230-0x0000000189847270
	// [XID] // 0x0000000189847230-0x0000000189847270
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184848AE0-0x0000000184849260
	// [XID] // 0x0000000189851630-0x0000000189851650
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE57 */, bool useObjectPool = false /* Metadata: 0x00AEFE5B */) => default; // 0x0000000184849E30-0x000000018484A610
	[BlackList] // 0x0000000189858BE0-0x0000000189858C20
	// [XID] // 0x0000000189858BE0-0x0000000189858C20
	public virtual void AutoAllocTypeFields() {} // 0x0000000184848490-0x0000000184848530
	[BlackList] // 0x00000001898630D0-0x0000000189863110
	// [XID] // 0x00000001898630D0-0x0000000189863110
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184848530-0x0000000184848660
	[BlackList] // 0x000000018986D1D0-0x000000018986D210
	// [XID] // 0x000000018986D1D0-0x000000018986D210
	public virtual void ReturnToObjectPool() {} // 0x000000018484AD70-0x000000018484AE10
	[BlackList] // 0x00000001898777B0-0x00000001898777F0
	// [XID] // 0x00000001898777B0-0x00000001898777F0
	public virtual void OnPoolAllocated() {} // 0x000000018484ACD0-0x000000018484AD70
	[BlackList] // 0x0000000189881CC0-0x0000000189881D00
	// [XID] // 0x0000000189881CC0-0x0000000189881D00
	public virtual void OnBeforePoolRecycled() {} // 0x000000018484AC30-0x000000018484ACD0
}

