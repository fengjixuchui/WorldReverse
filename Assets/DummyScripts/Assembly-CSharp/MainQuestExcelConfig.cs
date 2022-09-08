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
using MoleMole.Config;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MainQuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14887
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected uint _id; // 0x10
	protected uint _series; // 0x14
	protected QuestType _type; // 0x18
	protected MainQuestTagType _mainQuestTag; // 0x1C
	protected PlayMode _activeMode; // 0x20
	protected uint _titleTextMapHash; // 0x24
	protected uint _descTextMapHash; // 0x28
	protected string _luaPath; // 0x30
	protected uint _recommendLevel; // 0x38
	protected bool _repeatable; // 0x3C
	protected uint[] _suggestTrackMainQuestList; // 0x40
	protected bool _suggestTrackOutOfOrder; // 0x48
	protected uint[] _rewardIdList; // 0x50
	protected QuestShowType _showType; // 0x58
	protected uint _chapterId; // 0x5C
	protected uint _taskID; // 0x60
	protected bool _showRedPoint; // 0x64
	protected uint _activityId; // 0x68
	protected bool _isRelease; // 0x6C

	// Properties
	public uint defaultRewardID { /* [XID] */ /* 0x0000000189A39DD0-0x0000000189A39DF0 */ get => default; } // 0x0000000181D07C60-0x0000000181D07D50 
	public uint id { /* [XID] */ /* 0x0000000189A41690-0x0000000189A416B0 */ get => default; /* [XID] */ /* 0x0000000189A48CD0-0x0000000189A48CF0 */ protected set {} } // 0x0000000181D08280-0x0000000181D08320 0x0000000181D066B0-0x0000000181D06760
	public uint series { /* [XID] */ /* 0x0000000189A50480-0x0000000189A504A0 */ get => default; /* [XID] */ /* 0x0000000189A57990-0x0000000189A579B0 */ protected set {} } // 0x0000000181D05E90-0x0000000181D05F30 0x0000000181D03D90-0x0000000181D03E40
	public QuestType type { /* [XID] */ /* 0x0000000189A5F610-0x0000000189A5F630 */ get => default; /* [XID] */ /* 0x0000000189A66F60-0x0000000189A66F80 */ protected set {} } // 0x0000000181D083C0-0x0000000181D08460 0x0000000181D07E00-0x0000000181D07EB0
	public MainQuestTagType mainQuestTag { /* [XID] */ /* 0x0000000189A6E700-0x0000000189A6E720 */ get => default; /* [XID] */ /* 0x0000000189A75DF0-0x0000000189A75E10 */ protected set {} } // 0x0000000181D07B20-0x0000000181D07BC0 0x0000000181D064A0-0x0000000181D06550
	public PlayMode activeMode { /* [XID] */ /* 0x0000000189A7D8D0-0x0000000189A7D8F0 */ get => default; /* [XID] */ /* 0x0000000189A85140-0x0000000189A85160 */ protected set {} } // 0x0000000181D080A0-0x0000000181D08140 0x0000000181D06600-0x0000000181D066B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189A8CA70-0x0000000189A8CA90 */ get => default; /* [XID] */ /* 0x0000000189A93E10-0x0000000189A93E30 */ protected set {} } // 0x0000000181D03EE0-0x0000000181D03F80 0x0000000181D040E0-0x0000000181D04190
	public string title { /* [XID] */ /* 0x0000000189A9B860-0x0000000189A9B880 */ get => default; } // 0x0000000181D079A0-0x0000000181D07B20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189AA2D00-0x0000000189AA2D20 */ get => default; /* [XID] */ /* 0x0000000189AAA2C0-0x0000000189AAA2E0 */ protected set {} } // 0x0000000181D07900-0x0000000181D079A0 0x0000000181D04030-0x0000000181D040E0
	public string desc { /* [XID] */ /* 0x0000000189AB20E0-0x0000000189AB2100 */ get => default; } // 0x0000000181D06320-0x0000000181D064A0 
	public string luaPath { /* [XID] */ /* 0x0000000189AB9350-0x0000000189AB9370 */ get => default; /* [XID] */ /* 0x0000000189AC0F70-0x0000000189AC0F90 */ protected set {} } // 0x0000000181D08320-0x0000000181D083C0 0x0000000181D061D0-0x0000000181D06280
	public uint recommendLevel { /* [XID] */ /* 0x0000000189AC8950-0x0000000189AC8970 */ get => default; /* [XID] */ /* 0x0000000189AD0110-0x0000000189AD0130 */ protected set {} } // 0x0000000181D03E40-0x0000000181D03EE0 0x0000000181D077B0-0x0000000181D07860
	public bool repeatable { /* [XID] */ /* 0x0000000189AD7E80-0x0000000189AD7EA0 */ get => default; /* [XID] */ /* 0x0000000189ADFAB0-0x0000000189ADFAD0 */ protected set {} } // 0x0000000181D07F60-0x0000000181D08000 0x0000000181D07D50-0x0000000181D07E00
	public uint[] suggestTrackMainQuestList { /* [XID] */ /* 0x0000000189AE70F0-0x0000000189AE7110 */ get => default; /* [XID] */ /* 0x0000000189AEED60-0x0000000189AEED80 */ protected set {} } // 0x0000000181D08000-0x0000000181D080A0 0x0000000181D05F30-0x0000000181D05FE0
	public bool suggestTrackOutOfOrder { /* [XID] */ /* 0x0000000189AF6250-0x0000000189AF6270 */ get => default; /* [XID] */ /* 0x0000000189AFD910-0x0000000189AFD930 */ protected set {} } // 0x0000000181D07860-0x0000000181D07900 0x0000000181D06120-0x0000000181D061D0
	public uint[] rewardIdList { /* [XID] */ /* 0x0000000189B050C0-0x0000000189B050E0 */ get => default; /* [XID] */ /* 0x0000000189B0C790-0x0000000189B0C7B0 */ protected set {} } // 0x0000000181D07660-0x0000000181D07700 0x0000000181D07EB0-0x0000000181D07F60
	public QuestShowType showType { /* [XID] */ /* 0x0000000189B13BD0-0x0000000189B13BF0 */ get => default; /* [XID] */ /* 0x0000000189B1B400-0x0000000189B1B420 */ protected set {} } // 0x0000000181D06080-0x0000000181D06120 0x0000000181D03CE0-0x0000000181D03D90
	public uint chapterId { /* [XID] */ /* 0x0000000189B22A30-0x0000000189B22A50 */ get => default; /* [XID] */ /* 0x0000000189B2A0A0-0x0000000189B2A0C0 */ protected set {} } // 0x0000000181D05DF0-0x0000000181D05E90 0x0000000181D03F80-0x0000000181D04030
	public uint taskID { /* [XID] */ /* 0x0000000189B317B0-0x0000000189B317D0 */ get => default; /* [XID] */ /* 0x0000000189B38B70-0x0000000189B38B90 */ protected set {} } // 0x0000000181D06280-0x0000000181D06320 0x0000000181D04190-0x0000000181D04240
	public bool showRedPoint { /* [XID] */ /* 0x0000000189B40560-0x0000000189B40580 */ get => default; /* [XID] */ /* 0x0000000189B47F00-0x0000000189B47F20 */ protected set {} } // 0x0000000181D06760-0x0000000181D06800 0x0000000181D075B0-0x0000000181D07660
	public uint activityId { /* [XID] */ /* 0x0000000189B4F690-0x0000000189B4F6B0 */ get => default; /* [XID] */ /* 0x0000000189B56F30-0x0000000189B56F50 */ protected set {} } // 0x0000000181D07BC0-0x0000000181D07C60 0x0000000181D06550-0x0000000181D06600
	public bool isRelease { /* [XID] */ /* 0x0000000189B5E8A0-0x0000000189B5E8C0 */ get => default; /* [XID] */ /* 0x0000000189B65E20-0x0000000189B65E40 */ protected set {} } // 0x0000000181D05FE0-0x0000000181D06080 0x0000000181D07700-0x0000000181D077B0

	// Constructors
	public MainQuestExcelConfig() {} // 0x0000000181D08500-0x0000000181D08560

	// Methods
	// [IDTag] // 0x0000000189B6D460-0x0000000189B6D4A0
	// [XID] // 0x0000000189B6D460-0x0000000189B6D4A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181D04240-0x0000000181D04FF0
	// [IDTag] // 0x0000000189B77990-0x0000000189B779D0
	// [XID] // 0x0000000189B77990-0x0000000189B779D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181D04FF0-0x0000000181D05DF0
	// [XID] // 0x0000000189B82170-0x0000000189B82190
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8F4 */, bool useObjectPool = false /* Metadata: 0x00AEF8F8 */) => default; // 0x0000000181D06800-0x0000000181D075B0
	[BlackList] // 0x0000000189B89910-0x0000000189B89950
	// [XID] // 0x0000000189B89910-0x0000000189B89950
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D03B70-0x0000000181D03C10
	[BlackList] // 0x0000000189B93C30-0x0000000189B93C70
	// [XID] // 0x0000000189B93C30-0x0000000189B93C70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D03C10-0x0000000181D03CE0
	[BlackList] // 0x0000000189B9DEA0-0x0000000189B9DEE0
	// [XID] // 0x0000000189B9DEA0-0x0000000189B9DEE0
	public virtual void ReturnToObjectPool() {} // 0x0000000181D08460-0x0000000181D08500
	[BlackList] // 0x0000000189BA8550-0x0000000189BA8590
	// [XID] // 0x0000000189BA8550-0x0000000189BA8590
	public virtual void OnPoolAllocated() {} // 0x0000000181D081E0-0x0000000181D08280
	[BlackList] // 0x0000000189BB2B10-0x0000000189BB2B50
	// [XID] // 0x0000000189BB2B10-0x0000000189BB2B50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D08140-0x0000000181D081E0
}

