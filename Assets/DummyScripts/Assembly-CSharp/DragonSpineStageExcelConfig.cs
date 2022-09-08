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
public class DragonSpineStageExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15066
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected SimpleSafeUInt32[] _coin_id_list; // 0x20
	protected SimpleSafeUInt32 opendayRawNum; // 0x28
	protected SimpleSafeUInt32 preQuestIdRawNum; // 0x2C
	protected SimpleSafeUInt32[] _mission_id_list; // 0x30
	protected SimpleSafeUInt32 rewardPreviewIdRawNum; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x000000018976A590-0x000000018976A5B0 */ get => default; /* [XID] */ /* 0x0000000189771D10-0x0000000189771D30 */ protected set {} } // 0x00000001843F3C50-0x00000001843F3D20 0x00000001843F30D0-0x00000001843F31B0
	public uint chapterId { /* [XID] */ /* 0x00000001897793E0-0x0000000189779400 */ get => default; /* [XID] */ /* 0x0000000189780D00-0x0000000189780D20 */ protected set {} } // 0x00000001843F2850-0x00000001843F2920 0x00000001843F1500-0x00000001843F15E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189788260-0x0000000189788280 */ get => default; /* [XID] */ /* 0x000000018978F880-0x000000018978F8A0 */ protected set {} } // 0x00000001843F38F0-0x00000001843F3990 0x00000001843F15E0-0x00000001843F1690
	public string desc { /* [XID] */ /* 0x0000000189797070-0x0000000189797090 */ get => default; } // 0x00000001843F2F50-0x00000001843F30D0 
	public SimpleSafeUInt32[] coin_id_list { /* [XID] */ /* 0x000000018979F0B0-0x000000018979F0D0 */ get => default; /* [XID] */ /* 0x00000001897A6700-0x00000001897A6720 */ protected set {} } // 0x00000001843F3990-0x00000001843F3A30 0x00000001843F2DD0-0x00000001843F2E80
	public uint openday { /* [XID] */ /* 0x00000001897ADD30-0x00000001897ADD50 */ get => default; /* [XID] */ /* 0x00000001897B5E50-0x00000001897B5E70 */ protected set {} } // 0x00000001843F2E80-0x00000001843F2F50 0x00000001843F2C10-0x00000001843F2CF0
	public uint preQuestId { /* [XID] */ /* 0x00000001897BDC40-0x00000001897BDC60 */ get => default; /* [XID] */ /* 0x00000001897C5020-0x00000001897C5040 */ protected set {} } // 0x00000001843F2AA0-0x00000001843F2B70 0x00000001843F3A30-0x00000001843F3B10
	public SimpleSafeUInt32[] mission_id_list { /* [XID] */ /* 0x00000001897CC850-0x00000001897CC870 */ get => default; /* [XID] */ /* 0x00000001897D4080-0x00000001897D40A0 */ protected set {} } // 0x00000001843F2B70-0x00000001843F2C10 0x00000001843F2920-0x00000001843F29D0
	public uint rewardPreviewId { /* [XID] */ /* 0x00000001897DB990-0x00000001897DB9B0 */ get => default; /* [XID] */ /* 0x00000001897E3220-0x00000001897E3240 */ protected set {} } // 0x00000001843F29D0-0x00000001843F2AA0 0x00000001843F2CF0-0x00000001843F2DD0

	// Constructors
	public DragonSpineStageExcelConfig() {} // 0x00000001843F3DC0-0x00000001843F3E20

	// Methods
	// [IDTag] // 0x00000001897EA9A0-0x00000001897EA9E0
	// [XID] // 0x00000001897EA9A0-0x00000001897EA9E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843F1690-0x00000001843F1F70
	// [IDTag] // 0x00000001897F53B0-0x00000001897F53F0
	// [XID] // 0x00000001897F53B0-0x00000001897F53F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843F1F70-0x00000001843F2850
	// [XID] // 0x00000001897FFD10-0x00000001897FFD30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFDE */, bool useObjectPool = false /* Metadata: 0x00AEFFE2 */) => default; // 0x00000001843F31B0-0x00000001843F38F0
	[BlackList] // 0x0000000189807390-0x00000001898073D0
	// [XID] // 0x0000000189807390-0x00000001898073D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001843F1330-0x00000001843F13D0
	[BlackList] // 0x0000000189811940-0x0000000189811980
	// [XID] // 0x0000000189811940-0x0000000189811980
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843F13D0-0x00000001843F1500
	[BlackList] // 0x000000018981C140-0x000000018981C180
	// [XID] // 0x000000018981C140-0x000000018981C180
	public virtual void ReturnToObjectPool() {} // 0x00000001843F3D20-0x00000001843F3DC0
	[BlackList] // 0x00000001898267F0-0x0000000189826830
	// [XID] // 0x00000001898267F0-0x0000000189826830
	public virtual void OnPoolAllocated() {} // 0x00000001843F3BB0-0x00000001843F3C50
	[BlackList] // 0x0000000189830DE0-0x0000000189830E20
	// [XID] // 0x0000000189830DE0-0x0000000189830E20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843F3B10-0x00000001843F3BB0
}

