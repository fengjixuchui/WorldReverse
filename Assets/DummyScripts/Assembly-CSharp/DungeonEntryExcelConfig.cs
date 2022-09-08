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
public class DungeonEntryExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15520
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 dungeon_entry_idRawNum; // 0x14
	protected DungunEntryType _type; // 0x18
	protected bool _isShowInAdvHandbook; // 0x1C
	protected uint _descTextMapHash; // 0x20
	protected SimpleSafeUInt32[] _cooldown_tips_dungeon_id; // 0x28
	protected bool _is_default_open; // 0x30
	protected bool _is_daily_refresh; // 0x31
	protected LogicType _cond_comb; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DungeonEntrySatisfiedCond[] _satisfied_cond; // 0x38
	protected string _pic_path; // 0x40
	protected SimpleSafeUInt32 system_open_ui_idRawNum; // 0x48
	protected SimpleSafeUInt32 reward_data_idRawNum; // 0x4C
	protected SimpleSafeUInt32[][] _description_cycle_reward_list; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BA6D60-0x0000000189BA6D80 */ get => default; /* [XID] */ /* 0x0000000189BADF00-0x0000000189BADF20 */ protected set {} } // 0x00000001851D92C0-0x00000001851D9390 0x00000001851D7D10-0x00000001851D7DF0
	public uint dungeon_entry_id { /* [XID] */ /* 0x0000000189BB5790-0x0000000189BB57B0 */ get => default; /* [XID] */ /* 0x0000000189BBCE40-0x0000000189BBCE60 */ protected set {} } // 0x00000001851D90B0-0x00000001851D9180 0x00000001851D8C80-0x00000001851D8D60
	public DungunEntryType type { /* [XID] */ /* 0x0000000189BC4B00-0x0000000189BC4B20 */ get => default; /* [XID] */ /* 0x0000000189BCC580-0x0000000189BCC5A0 */ protected set {} } // 0x00000001851D9440-0x00000001851D94E0 0x00000001851D8F50-0x00000001851D9000
	public bool isShowInAdvHandbook { /* [XID] */ /* 0x0000000189BD3C30-0x0000000189BD3C50 */ get => default; /* [XID] */ /* 0x0000000189BDB4E0-0x0000000189BDB500 */ protected set {} } // 0x00000001851D53B0-0x00000001851D5450 0x00000001851D9390-0x00000001851D9440
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001895E7DF0-0x00000001895E7E10 */ get => default; /* [XID] */ /* 0x00000001895EF780-0x00000001895EF7A0 */ protected set {} } // 0x00000001851D8BE0-0x00000001851D8C80 0x00000001851D5850-0x00000001851D5900
	public string desc { /* [XID] */ /* 0x00000001895F70A0-0x00000001895F70C0 */ get => default; } // 0x00000001851D7AF0-0x00000001851D7C70 
	public SimpleSafeUInt32[] cooldown_tips_dungeon_id { /* [XID] */ /* 0x00000001895FE4A0-0x00000001895FE4C0 */ get => default; /* [XID] */ /* 0x0000000189605E30-0x0000000189605E50 */ protected set {} } // 0x00000001851D8E00-0x00000001851D8EA0 0x00000001851D8B30-0x00000001851D8BE0
	public bool is_default_open { /* [XID] */ /* 0x000000018960D680-0x000000018960D6A0 */ get => default; /* [XID] */ /* 0x0000000189614E60-0x0000000189614E80 */ protected set {} } // 0x00000001851D7EA0-0x00000001851D7F40 0x00000001851D7A40-0x00000001851D7AF0
	public bool is_daily_refresh { /* [XID] */ /* 0x000000018961C640-0x000000018961C660 */ get => default; /* [XID] */ /* 0x0000000189623AE0-0x0000000189623B00 */ protected set {} } // 0x00000001851D56E0-0x00000001851D5780 0x00000001851D7DF0-0x00000001851D7EA0
	public LogicType cond_comb { /* [XID] */ /* 0x000000018962B340-0x000000018962B360 */ get => default; /* [XID] */ /* 0x0000000189632AE0-0x0000000189632B00 */ protected set {} } // 0x00000001851D7C70-0x00000001851D7D10 0x00000001851D77D0-0x00000001851D7880
	public DungeonEntrySatisfiedCond[] satisfied_cond { /* [XID] */ /* 0x000000018963A570-0x000000018963A590 */ get => default; /* [XID] */ /* 0x0000000189641C60-0x0000000189641C80 */ protected set {} } // 0x00000001851D5310-0x00000001851D53B0 0x00000001851D8EA0-0x00000001851D8F50
	public string pic_path { /* [XID] */ /* 0x0000000189649540-0x0000000189649560 */ get => default; /* [XID] */ /* 0x0000000189650BF0-0x0000000189650C10 */ protected set {} } // 0x00000001851D5900-0x00000001851D59A0 0x00000001851D9000-0x00000001851D90B0
	public uint system_open_ui_id { /* [XID] */ /* 0x0000000189658390-0x00000001896583B0 */ get => default; /* [XID] */ /* 0x000000018965F980-0x000000018965F9A0 */ protected set {} } // 0x00000001851D5780-0x00000001851D5850 0x00000001851D7880-0x00000001851D7960
	public uint reward_data_id { /* [XID] */ /* 0x0000000189667430-0x0000000189667450 */ get => default; /* [XID] */ /* 0x000000018966EC40-0x000000018966EC60 */ protected set {} } // 0x00000001851D7F40-0x00000001851D8010 0x00000001851D7960-0x00000001851D7A40
	public SimpleSafeUInt32[][] description_cycle_reward_list { /* [XID] */ /* 0x0000000189676660-0x0000000189676680 */ get => default; /* [XID] */ /* 0x000000018967DE40-0x000000018967DE60 */ protected set {} } // 0x00000001851D8D60-0x00000001851D8E00 0x00000001851D5450-0x00000001851D5500

	// Constructors
	public DungeonEntryExcelConfig() {} // 0x00000001851D9580-0x00000001851D95E0

	// Methods
	// [IDTag] // 0x0000000189685540-0x0000000189685580
	// [XID] // 0x0000000189685540-0x0000000189685580
	public virtual bool ParseFromLine(string line) => default; // 0x00000001851D6850-0x00000001851D77D0
	// [IDTag] // 0x0000000189690560-0x00000001896905A0
	// [XID] // 0x0000000189690560-0x00000001896905A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001851D59A0-0x00000001851D6850
	// [XID] // 0x000000018969A950-0x000000018969A970
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1D0F */, bool useObjectPool = false /* Metadata: 0x00AF1D13 */) => default; // 0x00000001851D8010-0x00000001851D8B30
	[BlackList] // 0x00000001896A2380-0x00000001896A23C0
	// [XID] // 0x00000001896A2380-0x00000001896A23C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001851D5500-0x00000001851D55A0
	[BlackList] // 0x00000001896AC550-0x00000001896AC590
	// [XID] // 0x00000001896AC550-0x00000001896AC590
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851D55A0-0x00000001851D56E0
	[BlackList] // 0x00000001896B67A0-0x00000001896B67E0
	// [XID] // 0x00000001896B67A0-0x00000001896B67E0
	public virtual void ReturnToObjectPool() {} // 0x00000001851D94E0-0x00000001851D9580
	[BlackList] // 0x00000001896C0A40-0x00000001896C0A80
	// [XID] // 0x00000001896C0A40-0x00000001896C0A80
	public virtual void OnPoolAllocated() {} // 0x00000001851D9220-0x00000001851D92C0
	[BlackList] // 0x00000001896CAEF0-0x00000001896CAF30
	// [XID] // 0x00000001896CAEF0-0x00000001896CAF30
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851D9180-0x00000001851D9220
}

