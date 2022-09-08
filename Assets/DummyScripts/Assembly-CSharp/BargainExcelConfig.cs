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
public class BargainExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15243
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 quest_idRawNum; // 0x10
	protected SimpleSafeUInt32 idRawNum; // 0x14
	protected SimpleSafeUInt32[] _dialog_id; // 0x18
	protected SimpleSafeUInt32[] _expected_value; // 0x20
	protected SimpleSafeUInt32 spaceRawNum; // 0x28
	protected SimpleSafeUInt32[] _success_talk_id; // 0x30
	protected SimpleSafeUInt32 fail_talk_idRawNum; // 0x38
	protected SimpleSafeUInt32 mood_npc_idRawNum; // 0x3C
	protected SimpleSafeUInt32 mood_upper_limitRawNum; // 0x40
	protected SimpleSafeUInt32[] _random_mood; // 0x48
	protected SimpleSafeUInt32 mood_alert_limitRawNum; // 0x50
	protected SimpleSafeInt32 mood_low_limitRawNum; // 0x54
	protected uint _mood_low_limit_textTextMapHash; // 0x58
	protected SimpleSafeUInt32 single_fail_mood_deductionRawNum; // 0x5C
	protected SimpleSafeUInt32[] _single_fail_talk_id; // 0x60
	protected bool _delete_item; // 0x68
	protected SimpleSafeUInt32 item_idRawNum; // 0x6C
	protected uint _title_textTextMapHash; // 0x70
	protected uint _afford_textTextMapHash; // 0x74
	protected uint _storage_textTextMapHash; // 0x78
	protected uint _mood_hint_textTextMapHash; // 0x7C
	protected uint _mood_desc_textTextMapHash; // 0x80

	// Properties
	public uint quest_id { /* [XID] */ /* 0x0000000189789860-0x0000000189789880 */ get => default; /* [XID] */ /* 0x0000000189790FF0-0x0000000189791010 */ protected set {} } // 0x00000001836FA370-0x00000001836FA440 0x00000001836FA4E0-0x00000001836FA5C0
	public uint id { /* [XID] */ /* 0x0000000189798880-0x00000001897988A0 */ get => default; /* [XID] */ /* 0x00000001897A0610-0x00000001897A0630 */ protected set {} } // 0x00000001836FCBE0-0x00000001836FCCB0 0x00000001836FA940-0x00000001836FAA20
	public SimpleSafeUInt32[] dialog_id { /* [XID] */ /* 0x00000001897A7C40-0x00000001897A7C60 */ get => default; /* [XID] */ /* 0x00000001897AF6B0-0x00000001897AF6D0 */ protected set {} } // 0x00000001836FC0F0-0x00000001836FC190 0x00000001836FC320-0x00000001836FC3D0
	public SimpleSafeUInt32[] expected_value { /* [XID] */ /* 0x00000001897B7590-0x00000001897B75B0 */ get => default; /* [XID] */ /* 0x00000001897BF410-0x00000001897BF430 */ protected set {} } // 0x00000001836F70F0-0x00000001836F7190 0x00000001836F7380-0x00000001836F7430
	public uint space { /* [XID] */ /* 0x00000001897C6B20-0x00000001897C6B40 */ get => default; /* [XID] */ /* 0x00000001897CE2C0-0x00000001897CE2E0 */ protected set {} } // 0x00000001836FCCB0-0x00000001836FCD80 0x00000001836FC480-0x00000001836FC560
	public SimpleSafeUInt32[] success_talk_id { /* [XID] */ /* 0x00000001897D5810-0x00000001897D5830 */ get => default; /* [XID] */ /* 0x00000001897DCF10-0x00000001897DCF30 */ protected set {} } // 0x00000001836FAA20-0x00000001836FAAC0 0x00000001836FA660-0x00000001836FA710
	public uint fail_talk_id { /* [XID] */ /* 0x00000001897E4830-0x00000001897E4850 */ get => default; /* [XID] */ /* 0x00000001897EC4A0-0x00000001897EC4C0 */ protected set {} } // 0x00000001836FA040-0x00000001836FA110 0x00000001836F6F30-0x00000001836F7010
	public uint mood_npc_id { /* [XID] */ /* 0x00000001897F3DB0-0x00000001897F3DD0 */ get => default; /* [XID] */ /* 0x00000001897FB750-0x00000001897FB770 */ protected set {} } // 0x00000001836FCD80-0x00000001836FCE50 0x00000001836FA710-0x00000001836FA7F0
	public uint mood_upper_limit { /* [XID] */ /* 0x0000000189802BC0-0x0000000189802BE0 */ get => default; /* [XID] */ /* 0x000000018980A1B0-0x000000018980A1D0 */ protected set {} } // 0x00000001836F6E60-0x00000001836F6F30 0x00000001836F74E0-0x00000001836F75C0
	public SimpleSafeUInt32[] random_mood { /* [XID] */ /* 0x00000001898118C0-0x00000001898118E0 */ get => default; /* [XID] */ /* 0x00000001898194B0-0x00000001898194D0 */ protected set {} } // 0x00000001836FBCB0-0x00000001836FBD50 0x00000001836FCFA0-0x00000001836FD050
	public uint mood_alert_limit { /* [XID] */ /* 0x0000000189820C90-0x0000000189820CB0 */ get => default; /* [XID] */ /* 0x00000001898282E0-0x0000000189828300 */ protected set {} } // 0x00000001836FBF80-0x00000001836FC050 0x00000001836F7010-0x00000001836F70F0
	public int mood_low_limit { /* [XID] */ /* 0x000000018982F540-0x000000018982F560 */ get => default; /* [XID] */ /* 0x0000000189836E10-0x0000000189836E30 */ protected set {} } // 0x00000001836FBD50-0x00000001836FBE20 0x00000001836FA290-0x00000001836FA370
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mood_low_limit_textTextMapHash { /* [XID] */ /* 0x000000018983E2A0-0x000000018983E2C0 */ get => default; /* [XID] */ /* 0x0000000189845A50-0x0000000189845A70 */ protected set {} } // 0x00000001836FCF00-0x00000001836FCFA0 0x00000001836FCE50-0x00000001836FCF00
	public string mood_low_limit_text { /* [XID] */ /* 0x000000018984D000-0x000000018984D020 */ get => default; } // 0x00000001836FC850-0x00000001836FC9D0 
	public uint single_fail_mood_deduction { /* [XID] */ /* 0x00000001898540E0-0x0000000189854100 */ get => default; /* [XID] */ /* 0x000000018985BAD0-0x000000018985BAF0 */ protected set {} } // 0x00000001836FC9D0-0x00000001836FCAA0 0x00000001836F7740-0x00000001836F7820
	public SimpleSafeUInt32[] single_fail_talk_id { /* [XID] */ /* 0x0000000189863070-0x0000000189863090 */ get => default; /* [XID] */ /* 0x000000018986A4E0-0x000000018986A500 */ protected set {} } // 0x00000001836FA5C0-0x00000001836FA660 0x00000001836F7230-0x00000001836F72E0
	public bool delete_item { /* [XID] */ /* 0x00000001898719B0-0x00000001898719D0 */ get => default; /* [XID] */ /* 0x0000000189879230-0x0000000189879250 */ protected set {} } // 0x00000001836F72E0-0x00000001836F7380 0x00000001836FA7F0-0x00000001836FA8A0
	public uint item_id { /* [XID] */ /* 0x0000000189AF1FF0-0x0000000189AF2010 */ get => default; /* [XID] */ /* 0x0000000189887D20-0x0000000189887D40 */ protected set {} } // 0x00000001836FC600-0x00000001836FC6D0 0x00000001836FC240-0x00000001836FC320
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint title_textTextMapHash { /* [XID] */ /* 0x000000018988F0E0-0x000000018988F100 */ get => default; /* [XID] */ /* 0x0000000189896640-0x0000000189896660 */ protected set {} } // 0x00000001836F7190-0x00000001836F7230 0x00000001836FC3D0-0x00000001836FC480
	public string title_text { /* [XID] */ /* 0x000000018989DBE0-0x000000018989DC00 */ get => default; } // 0x00000001836F75C0-0x00000001836F7740 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint afford_textTextMapHash { /* [XID] */ /* 0x00000001898A55C0-0x00000001898A55E0 */ get => default; /* [XID] */ /* 0x00000001898ACB20-0x00000001898ACB40 */ protected set {} } // 0x00000001836FA8A0-0x00000001836FA940 0x00000001836FBE20-0x00000001836FBED0
	public string afford_text { /* [XID] */ /* 0x00000001898B3FA0-0x00000001898B3FC0 */ get => default; } // 0x00000001836F7820-0x00000001836F79A0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storage_textTextMapHash { /* [XID] */ /* 0x00000001898BBC90-0x00000001898BBCB0 */ get => default; /* [XID] */ /* 0x00000001898C3180-0x00000001898C31A0 */ protected set {} } // 0x00000001836FA440-0x00000001836FA4E0 0x00000001836F7430-0x00000001836F74E0
	public string storage_text { /* [XID] */ /* 0x00000001898CAB80-0x00000001898CABA0 */ get => default; } // 0x00000001836FBB30-0x00000001836FBCB0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mood_hint_textTextMapHash { /* [XID] */ /* 0x00000001898D2250-0x00000001898D2270 */ get => default; /* [XID] */ /* 0x00000001898D9A50-0x00000001898D9A70 */ protected set {} } // 0x00000001836FC560-0x00000001836FC600 0x00000001836FBED0-0x00000001836FBF80
	public string mood_hint_text { /* [XID] */ /* 0x00000001898E1730-0x00000001898E1750 */ get => default; } // 0x00000001836FA110-0x00000001836FA290 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mood_desc_textTextMapHash { /* [XID] */ /* 0x00000001898E9200-0x00000001898E9220 */ get => default; /* [XID] */ /* 0x00000001898F0A00-0x00000001898F0A20 */ protected set {} } // 0x00000001836FC050-0x00000001836FC0F0 0x00000001836FC190-0x00000001836FC240
	public string mood_desc_text { /* [XID] */ /* 0x00000001898F8310-0x00000001898F8330 */ get => default; } // 0x00000001836FC6D0-0x00000001836FC850 

	// Constructors
	public BargainExcelConfig() {} // 0x00000001836FD0F0-0x00000001836FD150

	// Methods
	// [IDTag] // 0x00000001898FF990-0x00000001898FF9D0
	// [XID] // 0x00000001898FF990-0x00000001898FF9D0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001836F79A0-0x00000001836F8CE0
	// [IDTag] // 0x000000018990A020-0x000000018990A060
	// [XID] // 0x000000018990A020-0x000000018990A060
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001836F8CE0-0x00000001836FA040
	// [XID] // 0x0000000189914A20-0x0000000189914A40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF050A */, bool useObjectPool = false /* Metadata: 0x00AF050E */) => default; // 0x00000001836FAAC0-0x00000001836FBB30
	[BlackList] // 0x000000018991C640-0x000000018991C680
	// [XID] // 0x000000018991C640-0x000000018991C680
	public virtual void AutoAllocTypeFields() {} // 0x00000001836F6C00-0x00000001836F6CA0
	[BlackList] // 0x0000000189926CA0-0x0000000189926CE0
	// [XID] // 0x0000000189926CA0-0x0000000189926CE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836F6CA0-0x00000001836F6E60
	[BlackList] // 0x00000001899311E0-0x0000000189931220
	// [XID] // 0x00000001899311E0-0x0000000189931220
	public virtual void ReturnToObjectPool() {} // 0x00000001836FD050-0x00000001836FD0F0
	[BlackList] // 0x000000018993BC30-0x000000018993BC70
	// [XID] // 0x000000018993BC30-0x000000018993BC70
	public virtual void OnPoolAllocated() {} // 0x00000001836FCB40-0x00000001836FCBE0
	[BlackList] // 0x00000001899460E0-0x0000000189946120
	// [XID] // 0x00000001899460E0-0x0000000189946120
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836FCAA0-0x00000001836FCB40
}

