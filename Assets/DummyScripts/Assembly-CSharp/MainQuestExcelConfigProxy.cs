/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct MainQuestExcelConfigProxy // TypeDefIndex: 14888
{
	// Fields
	private const uint MIN_RANDOM_PARENT_QUEST_ID = 100000; // Metadata: 0x00AEF901
	private const uint DANGEROUS_QUEST_LEVEL_THRESHOLD = 5; // Metadata: 0x00AEF905
	private uint _questMainId; // 0x00
	private ConfigMainQuestScheme _questCfg; // 0x08
	private RandomMainQuestExcelConfig _randCfg; // 0x10

	// Properties
	public uint questMainId { /* [XID] */ /* 0x0000000189BCC760-0x0000000189BCC780 */ get => default; } // 0x0000000181877BF0-0x0000000181877C90 
	public bool isRandom { /* [XID] */ /* 0x0000000189605FB0-0x0000000189605FD0 */ get => default; } // 0x00000001818776B0-0x00000001818777E0 
	public bool hasValue { /* [XID] */ /* 0x000000018960D7C0-0x000000018960D7E0 */ get => default; } // 0x00000001818775F0-0x00000001818776B0 
	public uint recommendLevel { /* [XID] */ /* 0x0000000189615020-0x0000000189615040 */ get => default; } // 0x00000001818765C0-0x0000000181876690 
	public PlayMode activeMode { /* [XID] */ /* 0x000000018961C780-0x000000018961C7A0 */ get => default; } // 0x0000000181877990-0x0000000181877A70 
	public uint[] suggestTrackMainQuestList { /* [XID] */ /* 0x0000000189623BE0-0x0000000189623C00 */ get => default; } // 0x00000001818778C0-0x0000000181877990 
	public bool suggestTrackOutOfOrder { /* [XID] */ /* 0x000000018962B4A0-0x000000018962B4C0 */ get => default; } // 0x00000001818772C0-0x0000000181877470 
	public MainQuestTagType mainQuestTagType { /* [XID] */ /* 0x0000000189632C20-0x0000000189632C40 */ get => default; } // 0x0000000181876F00-0x0000000181876F10 
	public QuestShowType showType { /* [XID] */ /* 0x000000018963A670-0x000000018963A690 */ get => default; } // 0x0000000181876830-0x00000001818768F0 
	public string luaPath { /* [XID] */ /* 0x0000000189641E00-0x0000000189641E20 */ get => default; } // 0x0000000181877A70-0x0000000181877B40 
	public QuestType type { /* [XID] */ /* 0x0000000189649680-0x00000001896496A0 */ get => default; } // 0x0000000181877B40-0x0000000181877BF0 
	public uint chapterId { /* [XID] */ /* 0x0000000189650CB0-0x0000000189650CD0 */ get => default; } // 0x0000000181876760-0x0000000181876830 
	public uint rewardId { /* [XID] */ /* 0x0000000189658550-0x0000000189658570 */ get => default; } // 0x00000001818771E0-0x00000001818772C0 
	public string title { /* [XID] */ /* 0x000000018965FAA0-0x000000018965FAC0 */ get => default; } // 0x0000000181877470-0x0000000181877530 
	public string desc { /* [XID] */ /* 0x0000000189667510-0x0000000189667530 */ get => default; } // 0x0000000181876E40-0x0000000181876F00 
	public bool showRedPoint { /* [XID] */ /* 0x000000018966ED20-0x000000018966ED40 */ get => default; } // 0x0000000181877080-0x00000001818771E0 
	public uint activityId { /* [XID] */ /* 0x0000000189676740-0x0000000189676760 */ get => default; } // 0x0000000181877530-0x00000001818775F0 
	public uint taskID { /* [XID] */ /* 0x0000000189A2E210-0x0000000189A2E230 */ get => default; } // 0x00000001818769B0-0x0000000181876C90 

	// Constructors
	public MainQuestExcelConfigProxy(uint questMainId, uint questConfigMainId = 0 /* Metadata: 0x00AEF8F9 */) : this() {
		_questMainId = default;
		_questCfg = default;
		_randCfg = default;
	} // 0x0000000181877C90-0x0000000181877CC0

	// Methods
	// [XID] // 0x0000000189BD3D10-0x0000000189BD3D30
	public void Clear() {} // 0x00000001818768F0-0x00000001818769B0
	// [XID] // 0x0000000189BDB600-0x0000000189BDB620
	public string GetRandomParam(string param) => default; // 0x00000001818777E0-0x00000001818778C0
	// [XID] // 0x00000001895E7F70-0x00000001895E7F90
	public bool UpdateConfig(uint questMainId, uint questConfigMainId = 0 /* Metadata: 0x00AEF8FD */) => default; // 0x0000000181876C90-0x0000000181876E40
	// [XID] // 0x00000001895EF920-0x00000001895EF940
	public bool IsDangerous(uint avatarLevel) => default; // 0x0000000181876690-0x0000000181876760
	// [XID] // 0x00000001895F7200-0x00000001895F7220
	public bool IsActive() => default; // 0x00000001818764F0-0x00000001818765C0
	// [XID] // 0x00000001895FE640-0x00000001895FE660
	public static bool IsRandom(uint questMainId) => default; // 0x0000000181876F10-0x0000000181877080
}

