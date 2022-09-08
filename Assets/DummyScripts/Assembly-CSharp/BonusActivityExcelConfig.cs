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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BonusActivityExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 16165
{
	// Fields
	protected SimpleSafeUInt32 bonusActivityIdRawNum; // 0x28
	protected LogicType _condComb; // 0x2C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SignInCondConfig[] _condList; // 0x30
	protected SimpleSafeUInt32 watcherIdRawNum; // 0x38
	protected IdCountConfig[] _rewardItemList; // 0x40

	// Properties
	public uint bonusActivityId { /* [XID] */ /* 0x00000001895FE380-0x00000001895FE3A0 */ get => default; /* [XID] */ /* 0x0000000189605CD0-0x0000000189605CF0 */ protected set {} } // 0x0000000182E09800-0x0000000182E098D0 0x0000000182E09680-0x0000000182E09760
	public LogicType condComb { /* [XID] */ /* 0x000000018960D540-0x000000018960D560 */ get => default; /* [XID] */ /* 0x0000000189614CA0-0x0000000189614CC0 */ protected set {} } // 0x0000000182E09760-0x0000000182E09800 0x0000000182E09570-0x0000000182E09620
	public SignInCondConfig[] condList { /* [XID] */ /* 0x000000018961C540-0x000000018961C560 */ get => default; /* [XID] */ /* 0x0000000189623A00-0x0000000189623A20 */ protected set {} } // 0x0000000182E07760-0x0000000182E07800 0x0000000182E07B00-0x0000000182E07BB0
	public uint watcherId { /* [XID] */ /* 0x000000018962B220-0x000000018962B240 */ get => default; /* [XID] */ /* 0x00000001896329E0-0x0000000189632A00 */ protected set {} } // 0x0000000182E08B30-0x0000000182E08C00 0x0000000182E07C10-0x0000000182E07CF0
	public IdCountConfig[] rewardItemList { /* [XID] */ /* 0x000000018963A4F0-0x000000018963A510 */ get => default; /* [XID] */ /* 0x0000000189641B40-0x0000000189641B60 */ protected set {} } // 0x0000000182E08C00-0x0000000182E08CA0 0x0000000182E07A50-0x0000000182E07B00

	// Constructors
	public BonusActivityExcelConfig() {} // 0x0000000182E09970-0x0000000182E099D0

	// Methods
	// [IDTag] // 0x0000000189649440-0x0000000189649480
	// [XID] // 0x0000000189649440-0x0000000189649480
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E083B0-0x0000000182E08B30
	// [IDTag] // 0x0000000189653A80-0x0000000189653AC0
	// [XID] // 0x0000000189653A80-0x0000000189653AC0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E07CF0-0x0000000182E083B0
	// [XID] // 0x000000018965E110-0x000000018965E130
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3308 */, bool useObjectPool = false /* Metadata: 0x00AF330C */) => default; // 0x0000000182E08D90-0x0000000182E09570
	[BlackList] // 0x00000001896657F0-0x0000000189665830
	// [XID] // 0x00000001896657F0-0x0000000189665830
	public override void AutoAllocTypeFields() {} // 0x0000000182E07800-0x0000000182E078A0
	[BlackList] // 0x00000001896706D0-0x0000000189670710
	// [XID] // 0x00000001896706D0-0x0000000189670710
	public override void AutoRecycleTypeFields() {} // 0x0000000182E078A0-0x0000000182E079B0
	[BlackList] // 0x000000018967AC60-0x000000018967ACA0
	// [XID] // 0x000000018967AC60-0x000000018967ACA0
	public override void ReturnToObjectPool() {} // 0x0000000182E098D0-0x0000000182E09970
}

