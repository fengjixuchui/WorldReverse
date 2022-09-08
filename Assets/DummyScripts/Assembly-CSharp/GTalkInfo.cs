/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GTalkInfo // TypeDefIndex: 21674
{
	// Fields
	private static uint _curDirtyFlag; // 0x00
	private static Dictionary<uint, ConfigTalkScheme> _globalTalkDic; // 0x08
	private static Dictionary<uint, int> _globalTalkCntDic; // 0x10
	private static TickDictionary<uint, NpcTalkContainer> _npcTalkContainerDic; // 0x18
	private static TickDictionary<TickObjectDoubleKey, GadgetTalkContainer> _gadgetTalkContainerDic; // 0x20

	// Properties
	public static uint curDirtyFlag { /* [XID] */ /* 0x00000001898C2700-0x00000001898C2720 */ get => default; } // 0x000000018587C600-0x000000018587C6D0 

	// Constructors
	public GTalkInfo() {} // 0x000000018587D3C0-0x000000018587D420
	static GTalkInfo() {} // 0x000000018587D290-0x000000018587D3C0

	// Methods
	// [XID] // 0x00000001898CA160-0x00000001898CA180
	private static int GetTalkCnt(uint talkId) => default; // 0x000000018587C020-0x000000018587C120
	// [XID] // 0x00000001898D18B0-0x00000001898D18D0
	private static void AddTalkCnt(uint talkId) {} // 0x000000018587CCA0-0x000000018587CE50
	// [XID] // 0x00000001898D9010-0x00000001898D9030
	private static int RemoveTalkCnt(uint talkId) => default; // 0x000000018587C490-0x000000018587C600
	// [XID] // 0x000000018971E940-0x000000018971E960
	public static ConfigTalkScheme GetTalkScheme(uint talkId) => default; // 0x000000018587BD60-0x000000018587BE60
	// [XID] // 0x00000001898E8840-0x00000001898E8860
	public static bool HasTalkConfig(uint talkId) => default; // 0x000000018587B5C0-0x000000018587B6B0
	// [XID] // 0x00000001898EFF20-0x00000001898EFF40
	public static void AddTalkConfig(uint talkId, ConfigTalkScheme talkConfig) {} // 0x000000018587B7E0-0x000000018587B930
	// [XID] // 0x0000000189715750-0x0000000189715770
	public static bool RemoveTalkConfig(uint talkId) => default; // 0x000000018587CF30-0x000000018587D0A0
	// [XID] // 0x00000001898FEE90-0x00000001898FEEB0
	public static void ClearTalkConfig() {} // 0x000000018587D0A0-0x000000018587D1A0
	// [XID] // 0x0000000189AB51F0-0x0000000189AB5210
	public static NpcTalkContainer GetNpcTalkContainer(uint npcConfigID) => default; // 0x000000018587C120-0x000000018587C2A0
	// [XID] // 0x000000018990E130-0x000000018990E150
	public static NpcTalkContainer TryGetNpcTalkContainer(uint npcConfigID) => default; // 0x000000018587BB30-0x000000018587BC20
	// [XID] // 0x0000000189915880-0x00000001899158A0
	public static void AddNpcTalkByNpcId(uint npcConfigID, uint mainQuestId, ConfigTalkScheme talkConfig) {} // 0x000000018587C390-0x000000018587C490
	// [XID] // 0x000000018991D270-0x000000018991D290
	public static void RemoveNpcTalkByNpcId(uint npcConfigID, uint mainQuestId) {} // 0x000000018587B4D0-0x000000018587B5C0
	// [XID] // 0x0000000189924AE0-0x0000000189924B00
	public static void FlushNpcToBeRemoveTalk(uint npcConfigID, uint mainQuestId) {} // 0x000000018587CBC0-0x000000018587CCA0
	// [XID] // 0x000000018992C060-0x000000018992C080
	public static void AddNpcAutonomyTalk(uint npcConfigID, ConfigTalkScheme talkConfig) {} // 0x000000018587C2A0-0x000000018587C390
	// [XID] // 0x00000001899334E0-0x0000000189933500
	public static void RemoveNpcAutonomyTalk(uint npcConfigID, uint talkId) {} // 0x000000018587D1A0-0x000000018587D290
	// [XID] // 0x000000018993B150-0x000000018993B170
	public static void RefreshNpcTalkMainQuest(uint npcConfigID, uint mainQuestId) {} // 0x000000018587B2D0-0x000000018587B3C0
	// [XID] // 0x00000001899422A0-0x00000001899422C0
	public static uint GetValidTalk(uint npcConfigID, uint mainQuestId, bool isDiscard) => default; // 0x000000018587B6B0-0x000000018587B7E0
	// [XID] // 0x00000001897CFF30-0x00000001897CFF50
	public static ConfigTalkScheme GetValidPrePerformTalk(uint npcConfigID, uint mainQuestId, bool isDiscard) => default; // 0x000000018587CA80-0x000000018587CBC0
	// [XID] // 0x0000000189951740-0x0000000189951760
	public static ConfigTalkScheme GetValidMarkTalk(uint npcConfigID, uint mainQuestId, bool isDiscard) => default; // 0x000000018587BC20-0x000000018587BD60
	// [XID] // 0x0000000189958D10-0x0000000189958D30
	public static uint GetValidPrePerformTalkId(uint npcConfigID, uint mainQuestId, bool isDiscard) => default; // 0x000000018587B3C0-0x000000018587B4D0
	// [XID] // 0x00000001899603C0-0x00000001899603E0
	public static void ClearNpcTalk() {} // 0x000000018587CE50-0x000000018587CF30
	// [XID] // 0x0000000189612330-0x0000000189612350
	public static void SetNpcTalkDirty() {} // 0x000000018587BE60-0x000000018587C020
	// [XID] // 0x0000000189874C50-0x0000000189874C70
	public static void SetNpcTalkDirtyById(uint configId) {} // 0x000000018587C6D0-0x000000018587C7C0
	// [XID] // 0x0000000189976B70-0x0000000189976B90
	public static void AddGadgetTalkByMapInstId(uint mapInstId, uint groupId, ConfigTalkScheme talkConfig) {} // 0x000000018587BA30-0x000000018587BB30
	// [XID] // 0x000000018997DFA0-0x000000018997DFC0
	public static void RemoveGadgetTalkByMapInstId(uint mapInstId, uint groupId, uint talkId) {} // 0x000000018587B930-0x000000018587BA30
	// [XID] // 0x0000000189985B30-0x0000000189985B50
	public static GadgetTalkContainer GetGadgetTalkContainer(uint mapInstId, uint groupId) => default; // 0x000000018587C7C0-0x000000018587C970
	// [XID] // 0x000000018998D740-0x000000018998D760
	public static uint GetGadgetValidTalk(uint mapInstId, uint groupId) => default; // 0x000000018587C970-0x000000018587CA80
}

