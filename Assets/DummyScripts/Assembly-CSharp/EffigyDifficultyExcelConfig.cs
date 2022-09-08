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
public class EffigyDifficultyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15077
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 challengeIdRawNum; // 0x14
	protected EffigyDifficulty _monsterDifficulty; // 0x18
	protected SimpleSafeUInt32 monsterLevelRawNum; // 0x1C
	protected SimpleSafeFloat scoreRatioRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189608FB0-0x0000000189608FD0 */ get => default; /* [XID] */ /* 0x00000001896107F0-0x0000000189610810 */ protected set {} } // 0x0000000182BAC6B0-0x0000000182BAC780 0x0000000182BABCC0-0x0000000182BABDA0
	public uint challengeId { /* [XID] */ /* 0x0000000189617AB0-0x0000000189617AD0 */ get => default; /* [XID] */ /* 0x000000018961F780-0x000000018961F7A0 */ protected set {} } // 0x0000000182BAC2F0-0x0000000182BAC3C0 0x0000000182BAC780-0x0000000182BAC860
	public EffigyDifficulty monsterDifficulty { /* [XID] */ /* 0x0000000189626B20-0x0000000189626B40 */ get => default; /* [XID] */ /* 0x000000018962E410-0x000000018962E430 */ protected set {} } // 0x0000000182BABB40-0x0000000182BABBE0 0x0000000182BAB220-0x0000000182BAB2D0
	public uint monsterLevel { /* [XID] */ /* 0x0000000189636010-0x0000000189636030 */ get => default; /* [XID] */ /* 0x000000018963D6F0-0x000000018963D710 */ protected set {} } // 0x0000000182BAC4A0-0x0000000182BAC570 0x0000000182BAC3C0-0x0000000182BAC4A0
	public float scoreRatio { /* [XID] */ /* 0x0000000189644C50-0x0000000189644C70 */ get => default; /* [XID] */ /* 0x000000018964C6F0-0x000000018964C710 */ protected set {} } // 0x0000000182BAB2D0-0x0000000182BAB3B0 0x0000000182BABBE0-0x0000000182BABCC0

	// Constructors
	public EffigyDifficultyExcelConfig() {} // 0x0000000182BAC900-0x0000000182BAC960

	// Methods
	// [IDTag] // 0x0000000189653BE0-0x0000000189653C20
	// [XID] // 0x0000000189653BE0-0x0000000189653C20
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182BAB760-0x0000000182BABB40
	// [IDTag] // 0x000000018965E390-0x000000018965E3D0
	// [XID] // 0x000000018965E390-0x000000018965E3D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182BAB3B0-0x0000000182BAB760
	// [XID] // 0x0000000189668D40-0x0000000189668D60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF002B */, bool useObjectPool = false /* Metadata: 0x00AF002F */) => default; // 0x0000000182BABDA0-0x0000000182BAC2F0
	[BlackList] // 0x0000000189670870-0x00000001896708B0
	// [XID] // 0x0000000189670870-0x00000001896708B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182BAB050-0x0000000182BAB0F0
	[BlackList] // 0x000000018967AE60-0x000000018967AEA0
	// [XID] // 0x000000018967AE60-0x000000018967AEA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182BAB0F0-0x0000000182BAB220
	[BlackList] // 0x0000000189685640-0x0000000189685680
	// [XID] // 0x0000000189685640-0x0000000189685680
	public virtual void ReturnToObjectPool() {} // 0x0000000182BAC860-0x0000000182BAC900
	[BlackList] // 0x0000000189690600-0x0000000189690640
	// [XID] // 0x0000000189690600-0x0000000189690640
	public virtual void OnPoolAllocated() {} // 0x0000000182BAC610-0x0000000182BAC6B0
	[BlackList] // 0x000000018969AA10-0x000000018969AA50
	// [XID] // 0x000000018969AA10-0x000000018969AA50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182BAC570-0x0000000182BAC610
}

