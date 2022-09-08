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
public class ActivityArenaChallengeLevelInfoExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15007
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x14
	protected SimpleSafeUInt32 levelIdRawNum; // 0x18
	protected uint _levelNameTextMapHash; // 0x1C
	protected SimpleSafeUInt32 monsterPreviewIdRawNum; // 0x20
	protected uint _levelDescTextMapHash; // 0x24
	protected uint _levelDetailDescTextMapHash; // 0x28
	protected string _monsterConfig; // 0x30
	protected SimpleSafeUInt32[] _challengeIdList; // 0x38

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189610850-0x0000000189610870 */ get => default; /* [XID] */ /* 0x0000000189617B10-0x0000000189617B30 */ protected set {} } // 0x00000001832E7250-0x00000001832E7320 0x00000001832E57C0-0x00000001832E58A0
	public uint scheduleId { /* [XID] */ /* 0x000000018961F800-0x000000018961F820 */ get => default; /* [XID] */ /* 0x0000000189626B80-0x0000000189626BA0 */ protected set {} } // 0x00000001832E5650-0x00000001832E5720 0x00000001832E7DF0-0x00000001832E7ED0
	public uint levelId { /* [XID] */ /* 0x000000018962E470-0x000000018962E490 */ get => default; /* [XID] */ /* 0x0000000189636070-0x0000000189636090 */ protected set {} } // 0x00000001832E58A0-0x00000001832E5970 0x00000001832E73D0-0x00000001832E74B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelNameTextMapHash { /* [XID] */ /* 0x000000018963D750-0x000000018963D770 */ get => default; /* [XID] */ /* 0x0000000189644CD0-0x0000000189644CF0 */ protected set {} } // 0x00000001832E5E00-0x00000001832E5EA0 0x00000001832E7320-0x00000001832E73D0
	public string levelName { /* [XID] */ /* 0x000000018964C730-0x000000018964C750 */ get => default; } // 0x00000001832E5EA0-0x00000001832E6020 
	public uint monsterPreviewId { /* [XID] */ /* 0x0000000189653C40-0x0000000189653C60 */ get => default; /* [XID] */ /* 0x000000018965B510-0x000000018965B530 */ protected set {} } // 0x00000001832E6EB0-0x00000001832E6F80 0x00000001832E5C80-0x00000001832E5D60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelDescTextMapHash { /* [XID] */ /* 0x00000001896629A0-0x00000001896629C0 */ get => default; /* [XID] */ /* 0x000000018966A4E0-0x000000018966A500 */ protected set {} } // 0x00000001832E5720-0x00000001832E57C0 0x00000001832E74B0-0x00000001832E7560
	public string levelDesc { /* [XID] */ /* 0x0000000189672100-0x0000000189672120 */ get => default; } // 0x00000001832E7ED0-0x00000001832E8050 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelDetailDescTextMapHash { /* [XID] */ /* 0x00000001896799D0-0x00000001896799F0 */ get => default; /* [XID] */ /* 0x00000001896810E0-0x0000000189681100 */ protected set {} } // 0x00000001832E5970-0x00000001832E5A10 0x00000001832E7D40-0x00000001832E7DF0
	public string levelDetailDesc { /* [XID] */ /* 0x0000000189688B80-0x0000000189688BA0 */ get => default; } // 0x00000001832E70D0-0x00000001832E7250 
	public string monsterConfig { /* [XID] */ /* 0x0000000189690640-0x0000000189690660 */ get => default; /* [XID] */ /* 0x0000000189697EA0-0x0000000189697EC0 */ protected set {} } // 0x00000001832E5D60-0x00000001832E5E00 0x00000001832E5BD0-0x00000001832E5C80
	public SimpleSafeUInt32[] challengeIdList { /* [XID] */ /* 0x000000018969F170-0x000000018969F190 */ get => default; /* [XID] */ /* 0x00000001896A65D0-0x00000001896A65F0 */ protected set {} } // 0x00000001832E7030-0x00000001832E70D0 0x00000001832E6F80-0x00000001832E7030

	// Constructors
	public ActivityArenaChallengeLevelInfoExcelConfig() {} // 0x00000001832E8230-0x00000001832E8290

	// Methods
	// [IDTag] // 0x00000001896ADB30-0x00000001896ADB70
	// [XID] // 0x00000001896ADB30-0x00000001896ADB70
	public virtual bool ParseFromLine(string line) => default; // 0x00000001832E6760-0x00000001832E6EB0
	// [IDTag] // 0x00000001896B8150-0x00000001896B8190
	// [XID] // 0x00000001896B8150-0x00000001896B8190
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001832E6020-0x00000001832E6760
	// [XID] // 0x00000001896C21A0-0x00000001896C21C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE48 */, bool useObjectPool = false /* Metadata: 0x00AEFE4C */) => default; // 0x00000001832E7560-0x00000001832E7D40
	[BlackList] // 0x00000001896C97B0-0x00000001896C97F0
	// [XID] // 0x00000001896C97B0-0x00000001896C97F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001832E5A10-0x00000001832E5AB0
	[BlackList] // 0x00000001896D3B80-0x00000001896D3BC0
	// [XID] // 0x00000001896D3B80-0x00000001896D3BC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832E5AB0-0x00000001832E5BD0
	[BlackList] // 0x00000001896DE560-0x00000001896DE5A0
	// [XID] // 0x00000001896DE560-0x00000001896DE5A0
	public virtual void ReturnToObjectPool() {} // 0x00000001832E8190-0x00000001832E8230
	[BlackList] // 0x00000001896E8A00-0x00000001896E8A40
	// [XID] // 0x00000001896E8A00-0x00000001896E8A40
	public virtual void OnPoolAllocated() {} // 0x00000001832E80F0-0x00000001832E8190
	[BlackList] // 0x00000001896F2F90-0x00000001896F2FD0
	// [XID] // 0x00000001896F2F90-0x00000001896F2FD0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832E8050-0x00000001832E80F0
}

