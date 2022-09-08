/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class OpActivityBonusExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14879
{
	// Fields
	private List<uint> _blossomParaList; // 0x10
	private List<uint> _blossomTrack_City_List; // 0x18
	private List<uint> _dungeonParamList; // 0x20
	protected SimpleSafeUInt32 bonusIdRawNum; // 0x28
	protected OpActivityBonusSourceType _sourceType; // 0x2C
	protected string _sourceParam; // 0x30
	protected SimpleSafeUInt32 openLevelRawNum; // 0x38
	protected SimpleSafeUInt32 bonusRatioRawNum; // 0x3C
	protected string[] _textMapIdList; // 0x40
	protected OpActivityTrackType _trackType; // 0x48
	protected SimpleSafeUInt32[] _trackPara; // 0x50

	// Properties
	public List<uint> blossomParaList { /* [XID] */ /* 0x00000001896496A0-0x00000001896496C0 */ get => default; } // 0x00000001846584E0-0x0000000184658780 
	public List<uint> blossomTrack_City_List { /* [XID] */ /* 0x0000000189650CD0-0x0000000189650CF0 */ get => default; } // 0x0000000184657610-0x00000001846577B0 
	public List<uint> dungeonParamList { /* [XID] */ /* 0x0000000189658570-0x0000000189658590 */ get => default; } // 0x0000000184657190-0x0000000184657430 
	public uint bonusId { /* [XID] */ /* 0x000000018965FAC0-0x000000018965FAE0 */ get => default; /* [XID] */ /* 0x0000000189667530-0x0000000189667550 */ protected set {} } // 0x0000000184657F90-0x0000000184658060 0x0000000184658210-0x00000001846582F0
	public OpActivityBonusSourceType sourceType { /* [XID] */ /* 0x000000018966ED40-0x000000018966ED60 */ get => default; /* [XID] */ /* 0x0000000189676760-0x0000000189676780 */ protected set {} } // 0x00000001846574D0-0x0000000184657570 0x00000001846570E0-0x0000000184657190
	public string sourceParam { /* [XID] */ /* 0x000000018967DF20-0x000000018967DF40 */ get => default; /* [XID] */ /* 0x0000000189685740-0x0000000189685760 */ protected set {} } // 0x0000000184657430-0x00000001846574D0 0x0000000184655F60-0x0000000184656010
	public uint openLevel { /* [XID] */ /* 0x000000018968D0C0-0x000000018968D0E0 */ get => default; /* [XID] */ /* 0x0000000189694D20-0x0000000189694D40 */ protected set {} } // 0x0000000184655DE0-0x0000000184655EB0 0x0000000184658130-0x0000000184658210
	public uint bonusRatio { /* [XID] */ /* 0x000000018969C4A0-0x000000018969C4C0 */ get => default; /* [XID] */ /* 0x00000001896A3940-0x00000001896A3960 */ protected set {} } // 0x0000000184658060-0x0000000184658130 0x0000000184656010-0x00000001846560F0
	public string[] textMapIdList { /* [XID] */ /* 0x00000001896AADD0-0x00000001896AADF0 */ get => default; /* [XID] */ /* 0x00000001896B1E10-0x00000001896B1E30 */ protected set {} } // 0x0000000184657EF0-0x0000000184657F90 0x0000000184655B80-0x0000000184655C30
	public OpActivityTrackType trackType { /* [XID] */ /* 0x00000001896B98B0-0x00000001896B98D0 */ get => default; /* [XID] */ /* 0x00000001896C0C00-0x00000001896C0C20 */ protected set {} } // 0x0000000184657570-0x0000000184657610 0x0000000184655EB0-0x0000000184655F60
	public SimpleSafeUInt32[] trackPara { /* [XID] */ /* 0x00000001896C82B0-0x00000001896C82D0 */ get => default; /* [XID] */ /* 0x00000001896CFCB0-0x00000001896CFCD0 */ protected set {} } // 0x0000000184655AE0-0x0000000184655B80 0x00000001846582F0-0x00000001846583A0

	// Constructors
	public OpActivityBonusExcelConfig() {} // 0x0000000184658820-0x0000000184658890

	// Methods
	// [IDTag] // 0x00000001896D6EE0-0x00000001896D6F20
	// [XID] // 0x00000001896D6EE0-0x00000001896D6F20
	public virtual bool ParseFromLine(string line) => default; // 0x00000001846568D0-0x00000001846570E0
	// [IDTag] // 0x00000001896E1710-0x00000001896E1750
	// [XID] // 0x00000001896E1710-0x00000001896E1750
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001846560F0-0x00000001846568D0
	// [XID] // 0x00000001896EBA60-0x00000001896EBA80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8D1 */, bool useObjectPool = false /* Metadata: 0x00AEF8D5 */) => default; // 0x00000001846577B0-0x0000000184657EF0
	[BlackList] // 0x00000001896F3050-0x00000001896F3090
	// [XID] // 0x00000001896F3050-0x00000001896F3090
	public virtual void AutoAllocTypeFields() {} // 0x0000000184655C30-0x0000000184655CD0
	[BlackList] // 0x00000001896FD9F0-0x00000001896FDA30
	// [XID] // 0x00000001896FD9F0-0x00000001896FDA30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184655CD0-0x0000000184655DE0
	[BlackList] // 0x0000000189707D90-0x0000000189707DD0
	// [XID] // 0x0000000189707D90-0x0000000189707DD0
	public virtual void ReturnToObjectPool() {} // 0x0000000184658780-0x0000000184658820
	[BlackList] // 0x0000000189712650-0x0000000189712690
	// [XID] // 0x0000000189712650-0x0000000189712690
	public virtual void OnPoolAllocated() {} // 0x0000000184658440-0x00000001846584E0
	[BlackList] // 0x000000018971CE00-0x000000018971CE40
	// [XID] // 0x000000018971CE00-0x000000018971CE40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846583A0-0x0000000184658440
}

