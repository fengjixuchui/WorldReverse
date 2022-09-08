/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class QuestData // TypeDefIndex: 21666
{
	// Fields
	private static Dictionary<uint, ulong> _mainQuestIndexDic; // 0x00
	private static Dictionary<uint, ulong> _mainQuestBriefIndexDic; // 0x08
	private static Dictionary<uint, ulong> _npcFreeTalkIndexDic; // 0x10
	public const uint MIN_RANDOM_QUEST_CONFIG_ID = 30000; // Metadata: 0x00AFFB95
	public const uint MAX_RANDOM_QUEST_CONFIG_ID = 39999; // Metadata: 0x00AFFB99
	private static Dictionary<uint, ConfigLoadRequest> _mainQuestSchemeDic; // 0x18
	private static Dictionary<uint, ConfigMainQuestScheme> _mainQuestBriefDic; // 0x20
	private static Dictionary<uint, ConfigQuestScheme> _questSchemeDic; // 0x28
	private static Dictionary<uint, ConfigLoadRequest> _npcTalkGroupDic; // 0x30
	private static Dictionary<uint, int> _npcTalkGroupRequestCount; // 0x38
	private static Dictionary<uint, ConfigLoadRequest> _talkDialogDic; // 0x40
	private static Dictionary<uint, Dictionary<uint, ConfigLoadRequest>> _coopDialogDic; // 0x48
	private static List<ConfigTalkScheme> _tempTalkDialogLoadList; // 0x50
	private static List<ConfigTalkScheme> _tempCheckDialogLoadList; // 0x58
	private static Dictionary<uint, ConfigLoadRequest> _npcBlossomTalkConfigDic; // 0x60
	private static Dictionary<uint, ConfigLoadRequest> _activityTalkGroupDic; // 0x68
	private static Dictionary<TickObjectDoubleKey, ConfigLoadRequest> _gadgetTalkGroupDic; // 0x70

	// Properties
	private static string QUEST_CONFIG_PRE_PATH { /* [XID] */ /* 0x0000000189971040-0x0000000189971060 */ get; } // 0x0000000181569B00-0x0000000181569BA0 
	private static string QUEST_CONFIG_BRIEF_PRE_PATH { /* [XID] */ /* 0x0000000189978A50-0x0000000189978A70 */ get; } // 0x000000018155EC30-0x000000018155ECD0 
	private static string NPC_TALK_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x000000018997FAD0-0x000000018997FAF0 */ get; } // 0x0000000181561E00-0x0000000181561EA0 
	private static string NPC_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899873D0-0x00000001899873F0 */ get; } // 0x0000000181562510-0x00000001815625B0 
	private static string QUEST_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x000000018998EFC0-0x000000018998EFE0 */ get; } // 0x0000000181562A60-0x0000000181562B00 
	private static string NPC_BLOSSOM_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899D8110-0x00000001899D8130 */ get; } // 0x0000000181565900-0x00000001815659A0 
	private static string NPC_ACTIVITY_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x000000018999E570-0x000000018999E590 */ get; } // 0x0000000181569BA0-0x0000000181569C40 
	private static string GADGET_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899A5F90-0x00000001899A5FB0 */ get; } // 0x0000000181562E30-0x0000000181562ED0 
	private static string COOP_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899AD5A0-0x00000001899AD5C0 */ get; } // 0x0000000181560DB0-0x0000000181560E50 
	private static string OTHER_DIALOG_GROUP_CONFIG { /* [XID] */ /* 0x00000001899B4E20-0x00000001899B4E40 */ get; } // 0x00000001815632B0-0x0000000181563350 
	private static string NARRATOR_DIALOG_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899BC570-0x00000001899BC590 */ get; } // 0x000000018155ECD0-0x000000018155ED70 
	private static string NPC_BLOSSOM_TALK_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899C3EC0-0x00000001899C3EE0 */ get; } // 0x0000000181563210-0x00000001815632B0 
	private static string NPC_ACTIVITY_TALK_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899CB6F0-0x00000001899CB710 */ get; } // 0x0000000181569D60-0x0000000181569E00 
	private static string GADGET_TALK_GROUP_CONFIG_PRE_PATH { /* [XID] */ /* 0x00000001899D2AB0-0x00000001899D2AD0 */ get; } // 0x000000018155F7E0-0x000000018155F880 

	// Constructors
	static QuestData() {} // 0x000000018156BC00-0x000000018156BF00

	// Methods
	// [XID] // 0x0000000189943FE0-0x0000000189944000
	public static void InitMainQuestIndex(Dictionary<uint, ulong> mainQuestIndexDic) {} // 0x0000000181568030-0x0000000181568100
	// [XID] // 0x000000018994B5F0-0x000000018994B610
	public static bool GetMainQuestIndex(uint mainQuestId, out ulong assetIndex) {
		assetIndex = default;
		return default;
	} // 0x0000000181562C50-0x0000000181562D50
	// [XID] // 0x0000000189952EB0-0x0000000189952ED0
	public static void InitMainQuestBriefIndex(Dictionary<uint, ulong> mainQuestBriefIndexDic) {} // 0x0000000181565280-0x0000000181565350
	// [XID] // 0x000000018989E0B0-0x000000018989E0D0
	public static bool GetMainQuestBriefIndex(uint mainQuestId, out ulong assetIndex) {
		assetIndex = default;
		return default;
	} // 0x0000000181565BA0-0x0000000181565CA0
	// [XID] // 0x0000000189961F30-0x0000000189961F50
	public static void InitNpcFreeTalkIndex(Dictionary<uint, ulong> npcFreeTalkIndexDic) {} // 0x00000001815678D0-0x00000001815679A0
	// [XID] // 0x0000000189969460-0x0000000189969480
	public static bool GetNpcFreeTalkIndex(uint npcId, out ulong assetIndex) {
		assetIndex = default;
		return default;
	} // 0x000000018156B780-0x000000018156B880
	// [XID] // 0x00000001899DA140-0x00000001899DA160
	public static void ClearAllData() {} // 0x0000000181565140-0x0000000181565280
	// [XID] // 0x00000001899E1C30-0x00000001899E1C50
	private static void ClearQuestData() {} // 0x000000018155DCB0-0x000000018155DF50
	// [XID] // 0x00000001899E8FF0-0x00000001899E9010
	private static void ClearNpcTalkGroupData() {} // 0x0000000181569F10-0x000000018156A300
	// [XID] // 0x00000001899F0910-0x00000001899F0930
	private static void ClearNpcBlossomTalkData() {} // 0x000000018156AFA0-0x000000018156B080
	// [XID] // 0x00000001899F7FF0-0x00000001899F8010
	private static void ClearNpcActivityTalkData() {} // 0x000000018155E650-0x000000018155E730
	// [XID] // 0x00000001899FF680-0x00000001899FF6A0
	public static bool IsRandomQuest(uint mainQuestId) => default; // 0x000000018155ED70-0x000000018155EE20
	// [XID] // 0x0000000189A06EA0-0x0000000189A06EC0
	public static bool IsRandomQuestConfig(uint mainQuestId) => default; // 0x0000000181567F80-0x0000000181568030
	// [XID] // 0x0000000189A0E570-0x0000000189A0E590
	public static ConfigMainQuestScheme GetMainQuestConfig(uint id) => default; // 0x0000000181566700-0x0000000181566860
	// [XID] // 0x0000000189A15BC0-0x0000000189A15BE0
	public static ConfigMainQuestScheme GetMainQuestBriefConfig(uint id) => default; // 0x000000018156A300-0x000000018156A590
	// [XID] // 0x0000000189A1CFD0-0x0000000189A1CFF0
	public static void RemoveMainQuestConfig(uint id, uint configId = 0 /* Metadata: 0x00AFFB58 */) {} // 0x00000001815649D0-0x0000000181564EF0
	// [IDTag] // 0x0000000189A24610-0x0000000189A24650
	// [XID] // 0x0000000189A24610-0x0000000189A24650
	public static ConfigQuestScheme GetQuestConfig(uint id) => default; // 0x0000000181563D10-0x0000000181563E10
	// [XID] // 0x0000000189A2EB60-0x0000000189A2EB80
	private static void AddQuestConfig(ConfigQuestScheme questConfig) {} // 0x00000001815699A0-0x0000000181569B00
	// [XID] // 0x0000000189A36490-0x0000000189A364B0
	public static void RemoveQuestConfig(uint id) {} // 0x000000018155FE50-0x000000018155FF90
	// [XID] // 0x0000000189A3DA70-0x0000000189A3DA90
	public static bool IsConfigLoaded(uint mainQuestConfigId) => default; // 0x00000001815642F0-0x00000001815643C0
	// [XID] // 0x0000000189A451B0-0x0000000189A451D0
	private static ConfigLoadRequest.LoadState GetMainQuestSchemeLoadState(uint mainQuestConfigId) => default; // 0x000000018156AA80-0x000000018156ABA0
	// [XID] // 0x0000000189A4C8C0-0x0000000189A4C8E0
	public static void TryGetMainQuestScheme(uint mainQuestConfigId, out ConfigLoadRequest.LoadState loadState, out ConfigMainQuestScheme mainQuestScheme) {
		loadState = default;
		mainQuestScheme = default;
	} // 0x0000000181565640-0x00000001815657F0
	// [XID] // 0x0000000189A540D0-0x0000000189A540F0
	public static bool LoadQuestConfig(uint mainQuestConfigId, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB5C */) => default; // 0x00000001815613E0-0x00000001815619A0
	// [XID] // 0x0000000189A5BB20-0x0000000189A5BB40
	private static ConfigMainQuestScheme LoadQuestBreifConfig(uint mainQuestConfigId) => default; // 0x0000000181569330-0x00000001815696A0
	// [XID] // 0x0000000189A632B0-0x0000000189A632D0
	public static void LoadRqQuestConfig(uint mainQuestConfigId, uint mainQuestId) {} // 0x00000001815664E0-0x0000000181566700
	// [XID] // 0x0000000189A6ADD0-0x0000000189A6ADF0
	private static ConfigLoadRequest.LoadState GetNpcTalkGroupLoadState(uint npcConfigId) => default; // 0x0000000181563BF0-0x0000000181563D10
	// [XID] // 0x0000000189A72480-0x0000000189A724A0
	private static void AddNpcRequestTalkGroupCount(uint npcConfigId) {} // 0x0000000181566860-0x0000000181566990
	// [XID] // 0x0000000189A7A090-0x0000000189A7A0B0
	private static bool RemoveNpcRequestTalkGroupCount(uint npcConfigId) => default; // 0x000000018155FF90-0x0000000181560140
	// [XID] // 0x0000000189A81530-0x0000000189A81550
	public static void LoadNpcTalkGroup(uint npcConfigId, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB5D */) {} // 0x000000018156A590-0x000000018156AA80
	// [XID] // 0x0000000189A88F50-0x0000000189A88F70
	public static AsyncJob LoadNpcTalkGroupWithJob(uint npcConfigId, Action onFinishHandler) => default; // 0x0000000181568100-0x0000000181568540
	// [XID] // 0x0000000189A90770-0x0000000189A90790
	public static void RemoveNpcTalkGroup(uint npcConfigId) {} // 0x00000001815643C0-0x00000001815645B0
	// [XID] // 0x0000000189A97F70-0x0000000189A97F90
	private static bool HasInTempTalkDialogLoadList(uint talkId) => default; // 0x0000000181562390-0x0000000181562510
	// [XID] // 0x0000000189A9F390-0x0000000189A9F3B0
	private static List<ConfigTalkScheme> GenTalkDialogLoadList(ConfigTalkScheme talkConfig, out bool allDone) {
		allDone = default;
		return default;
	} // 0x0000000181564FF0-0x0000000181565140
	// [XID] // 0x0000000189AA6B80-0x0000000189AA6BA0
	private static void GenTalkDialogLoadListInternal(ConfigTalkScheme talkConfig, ref bool allDone) {} // 0x0000000181566A90-0x0000000181566D60
	// [XID] // 0x0000000189AAE310-0x0000000189AAE330
	private static ConfigLoadRequest.LoadState GetTalkDialogLoadState(uint talkId) => default; // 0x0000000181569C40-0x0000000181569D60
	// [XID] // 0x0000000189AB5B60-0x0000000189AB5B80
	public static void LoadTalkDialogConfig(ConfigTalkScheme talkConfig, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB5E */) {} // 0x0000000181566E60-0x00000001815678D0
	// [XID] // 0x000000018970E310-0x000000018970E330
	public static void RemoveTalkDialogConfig(uint talkId) {} // 0x000000018155F220-0x000000018155F4A0
	// [XID] // 0x0000000189AC5090-0x0000000189AC50B0
	public static void LoadOtherDialogConfig(bool asyncLoad = true /* Metadata: 0x00AFFB5F */) {} // 0x00000001815607A0-0x0000000181560A10
	// [XID] // 0x0000000189ACC5C0-0x0000000189ACC5E0
	public static void LoadNarratorDialogGroup(uint narratorId, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB60 */) {} // 0x0000000181565350-0x0000000181565640
	// [XID] // 0x0000000189AD42F0-0x0000000189AD4310
	private static ConfigLoadRequest.LoadState GetNpcBlossomTalkConfigLoadState(uint talkConfigId) => default; // 0x00000001815648B0-0x00000001815649D0
	// [XID] // 0x0000000189ADBC00-0x0000000189ADBC20
	public static void LoadNpcBlossomTalkConfig(uint talkConfigId, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB61 */) {} // 0x00000001815688B0-0x0000000181568C60
	// [XID] // 0x0000000189AE3630-0x0000000189AE3650
	public static void RemoveNpcBlossomTalkConfig(uint talkConfigId) {} // 0x0000000181563350-0x00000001815634F0
	// [XID] // 0x0000000189AEAEB0-0x0000000189AEAED0
	private static ConfigLoadRequest.LoadState GetActivityTalkGroupLoadState(uint npcConfigId) => default; // 0x0000000181561CE0-0x0000000181561E00
	// [XID] // 0x0000000189AF2840-0x0000000189AF2860
	public static void LoadActivityTalkGroup(uint activityConfigId, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB62 */) {} // 0x00000001815626B0-0x0000000181562A60
	// [XID] // 0x0000000189AFA140-0x0000000189AFA160
	public static void RemoveActivityTalkGroup(uint activityConfigId) {} // 0x0000000181560480-0x00000001815607A0
	// [XID] // 0x0000000189B016E0-0x0000000189B01700
	private static ConfigLoadRequest.LoadState GetGadgetTalkGroupLoadState(uint gadgetConfigId, uint groupId) => default; // 0x0000000181562B00-0x0000000181562C50
	// [XID] // 0x0000000189B08C30-0x0000000189B08C50
	public static void LoadGadgetTalkGroup(uint gadgetConfigId, uint groupId, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB63 */) {} // 0x000000018155F980-0x000000018155FD50
	// [XID] // 0x0000000189B10670-0x0000000189B10690
	public static void RemoveGadgetTalkGroup(uint gadgetConfigId, uint groupId) {} // 0x0000000181561150-0x00000001815613E0
	// [XID] // 0x0000000189B177E0-0x0000000189B17800
	public static void ClearGadgetTalkGroup() {} // 0x0000000181564100-0x00000001815641E0
	// [IDTag] // 0x0000000189B1F080-0x0000000189B1F0C0
	// [XID] // 0x0000000189B1F080-0x0000000189B1F0C0
	private static ConfigLoadAndSerializePattern GetQuestConfig(Action onLoadFinish) => default; // 0x0000000181563E10-0x0000000181564100
	// [XID] // 0x0000000189B29580-0x0000000189B295A0
	private static object QuestConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB64 */) => default; // 0x0000000181565AA0-0x0000000181565BA0
	// [XID] // 0x0000000189B30AD0-0x0000000189B30AF0
	private static object QuestConfigSerializeJson(JSONNode node) => default; // 0x000000018155F120-0x000000018155F220
	// [XID] // 0x0000000189B381B0-0x0000000189B381D0
	private static void OnQuestConfigAsyncSerialized(object obj, ulong path) {} // 0x0000000181562D50-0x0000000181562E30
	// [XID] // 0x0000000189B3FBE0-0x0000000189B3FC00
	private static void OnQuestConfigSerialized(object obj, ulong path, bool isAsync) {} // 0x0000000181567AB0-0x0000000181567F80
	// [XID] // 0x0000000189B473D0-0x0000000189B473F0
	private static object QuestBriefConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB68 */) => default; // 0x0000000181566D60-0x0000000181566E60
	// [XID] // 0x0000000189B4EC70-0x0000000189B4EC90
	private static object QuestBriefConfigSerializeJson(JSONNode node) => default; // 0x0000000181563AF0-0x0000000181563BF0
	// [XID] // 0x0000000189625940-0x0000000189625960
	private static ConfigMainQuestScheme OnQuestBriefConfigSerialized(object obj, ulong path) => default; // 0x000000018156B990-0x000000018156BC00
	// [XID] // 0x0000000189B5DD20-0x0000000189B5DD40
	private static ConfigLoadAndSerializePattern GetNpcTalkConfig(Action onLoadFinish) => default; // 0x000000018155E930-0x000000018155EC30
	// [XID] // 0x0000000189B652A0-0x0000000189B652C0
	private static object NpcTalkConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB6C */) => default; // 0x00000001815639F0-0x0000000181563AF0
	// [XID] // 0x0000000189B6C8C0-0x0000000189B6C8E0
	private static object NpcTalkConfigSerializeJson(JSONNode node) => default; // 0x0000000181560A10-0x0000000181560B10
	// [XID] // 0x0000000189B73FA0-0x0000000189B73FC0
	private static void OnNpcTalkConfigSerialized(object obj, ulong path) {} // 0x0000000181562ED0-0x0000000181563210
	// [XID] // 0x0000000189B7B5B0-0x0000000189B7B5D0
	private static ConfigLoadAndSerializePattern GetQuestDialogGroupConfig(Action onLoadFinish) => default; // 0x000000018155EE20-0x000000018155F120
	// [XID] // 0x0000000189B82F40-0x0000000189B82F60
	private static object QuestDialogGroupConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB70 */) => default; // 0x0000000181561EA0-0x0000000181561FB0
	// [XID] // 0x00000001899949E0-0x0000000189994A00
	private static object QuestDialogGroupConfigSerializeJson(JSONNode node) => default; // 0x000000018155FD50-0x000000018155FE50
	// [XID] // 0x0000000189B91B00-0x0000000189B91B20
	private static void OnQuestDialogGroupConfigSerialized(object obj, ulong path) {} // 0x0000000181560140-0x0000000181560480
	// [XID] // 0x000000018977C800-0x000000018977C820
	private static ConfigLoadAndSerializePattern GetNpcDialogGroupConfig(Action onLoadFinish) => default; // 0x000000018156ACA0-0x000000018156AFA0
	// [XID] // 0x0000000189BA0310-0x0000000189BA0330
	private static object NpcDialogGroupConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB74 */) => default; // 0x00000001815657F0-0x0000000181565900
	// [XID] // 0x0000000189BA7B50-0x0000000189BA7B70
	private static object NpcDialogGroupConfigSerializeJson(JSONNode node) => default; // 0x00000001815634F0-0x00000001815635F0
	// [XID] // 0x0000000189BAEF60-0x0000000189BAEF80
	private static void OnNpcDialogGroupConfigSerialized(object obj, ulong path) {} // 0x00000001815619A0-0x0000000181561CE0
	// [XID] // 0x0000000189BB6610-0x0000000189BB6630
	private static ConfigLoadAndSerializePattern GetOtherDialogGroupConfig(Action onLoadFinish) => default; // 0x00000001815696A0-0x00000001815699A0
	// [XID] // 0x0000000189BBDC40-0x0000000189BBDC60
	private static object OtherDialogGroupConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB78 */) => default; // 0x0000000181569E00-0x0000000181569F10
	// [XID] // 0x0000000189BC5960-0x0000000189BC5980
	private static object OtherDialogGroupConfigSerializeJson(JSONNode node) => default; // 0x00000001815659A0-0x0000000181565AA0
	// [XID] // 0x0000000189BCD400-0x0000000189BCD420
	private static void OnOtherDialogGroupConfigSerialized(object obj, ulong path) {} // 0x0000000181565FE0-0x00000001815661E0
	// [XID] // 0x0000000189BD4910-0x0000000189BD4930
	private static ConfigLoadAndSerializePattern GetNarratorDialogGroupConfig(Action onLoadFinish) => default; // 0x00000001815645B0-0x00000001815648B0
	// [XID] // 0x0000000189BDC400-0x0000000189BDC420
	private static object NarratorDialogGroupSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB7C */) => default; // 0x00000001815679A0-0x0000000181567AB0
	// [XID] // 0x00000001895E8C90-0x00000001895E8CB0
	private static object NarratorDialogGroupSerializeJson(JSONNode node) => default; // 0x000000018155E730-0x000000018155E830
	// [XID] // 0x00000001895F0500-0x00000001895F0520
	private static void OnNarratorDialogGroupConfigSerialized(object obj, ulong path) {} // 0x00000001815690E0-0x0000000181569330
	// [XID] // 0x00000001895F7FD0-0x00000001895F7FF0
	private static ConfigLoadAndSerializePattern GetNpcBlossomTalkConfig(Action onLoadFinish) => default; // 0x000000018156B380-0x000000018156B680
	// [XID] // 0x00000001895FF330-0x00000001895FF350
	private static object NpcBlossomTalkConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB80 */) => default; // 0x0000000181566990-0x0000000181566A90
	// [XID] // 0x0000000189606BC0-0x0000000189606BE0
	private static object NpcBlossomTalkConfigSerializeJson(JSONNode node) => default; // 0x000000018156ABA0-0x000000018156ACA0
	// [XID] // 0x000000018960E4C0-0x000000018960E4E0
	private static void OnNpcBlossomTalkConfigSerialized(object obj, ulong path) {} // 0x0000000181565CA0-0x0000000181565FE0
	// [XID] // 0x0000000189615BA0-0x0000000189615BC0
	private static ConfigLoadAndSerializePattern GetActivityTalkConfig(Action onLoadFinish) => default; // 0x000000018156B080-0x000000018156B380
	// [XID] // 0x000000018961D3D0-0x000000018961D3F0
	private static object ActivityTalkConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB84 */) => default; // 0x00000001815625B0-0x00000001815626B0
	// [XID] // 0x0000000189624890-0x00000001896248B0
	private static object ActivityTalkConfigSerializeJson(JSONNode node) => default; // 0x000000018155F880-0x000000018155F980
	// [XID] // 0x000000018962BFF0-0x000000018962C010
	private static void OnActivityTalkConfigSerialized(object obj, ulong path) {} // 0x0000000181561FB0-0x0000000181562390
	// [XID] // 0x0000000189633B90-0x0000000189633BB0
	private static ConfigLoadAndSerializePattern GetGadgetTalkConfig(Action onLoadFinish) => default; // 0x0000000181560E50-0x0000000181561150
	// [XID] // 0x000000018963B410-0x000000018963B430
	private static object GadgetTalkConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB88 */) => default; // 0x000000018155E830-0x000000018155E930
	// [XID] // 0x0000000189642BC0-0x0000000189642BE0
	private static object GadgetTalkConfigSerializeJson(JSONNode node) => default; // 0x0000000181564EF0-0x0000000181564FF0
	// [XID] // 0x000000018964A1F0-0x000000018964A210
	private static void OnGadgetTalkConfigSerialized(object obj, ulong path) {} // 0x0000000181568540-0x00000001815688B0
	// [XID] // 0x0000000189651960-0x0000000189651980
	private static ConfigLoadAndSerializePattern GetGadgetDialogGroupConfig(Action onLoadFinish) => default; // 0x00000001815661E0-0x00000001815664E0
	// [XID] // 0x00000001896591F0-0x0000000189659210
	private static object GadgetDialogGroupConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB8C */) => default; // 0x000000018156B880-0x000000018156B990
	// [XID] // 0x0000000189660870-0x0000000189660890
	private static object GadgetDialogGroupConfigSerializeJson(JSONNode node) => default; // 0x00000001815635F0-0x00000001815636F0
	// [XID] // 0x00000001899EE790-0x00000001899EE7B0
	private static void OnGadgetDialogGroupConfigSerialized(object obj, ulong path) {} // 0x000000018155F4A0-0x000000018155F7E0
	// [XID] // 0x00000001896F0270-0x00000001896F0290
	public static void LoadCoopTalkDialogConfig(ConfigTalkScheme talkConfig, Action onFinishHandler, bool asyncLoad = true /* Metadata: 0x00AFFB90 */) {} // 0x000000018155DF50-0x000000018155E650
	// [XID] // 0x00000001896D5B90-0x00000001896D5BB0
	private static ConfigLoadAndSerializePattern GetCoopDialogGroupConfig(Action onLoadFinish) => default; // 0x00000001815636F0-0x00000001815639F0
	// [XID] // 0x000000018967EB40-0x000000018967EB60
	private static object CoopDialogGroupConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFFB91 */) => default; // 0x00000001815641E0-0x00000001815642F0
	// [XID] // 0x00000001896863F0-0x0000000189686410
	private static object CoopDialogGroupConfigSerializeJson(JSONNode node) => default; // 0x000000018156B680-0x000000018156B780
	// [XID] // 0x000000018968E290-0x000000018968E2B0
	private static void OnCoopDialogGroupConfigSerialized(object obj, ulong path) {} // 0x0000000181568C60-0x00000001815690E0
	// [XID] // 0x0000000189695B10-0x0000000189695B30
	public static void RemoveCoopDialogConfig(uint coopInteractionId) {} // 0x0000000181560B10-0x0000000181560DB0
}

