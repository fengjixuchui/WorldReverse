/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct QuestExcelConfigProxy // TypeDefIndex: 14889
{
	// Fields
	private const uint MIN_RANDOM_QUEST_ID = 10000000; // Metadata: 0x00AEF915
	private uint _questId; // 0x00
	private ConfigQuestScheme _questCfg; // 0x08
	private RandomQuestExcelConfig _randCfg; // 0x10

	// Properties
	public uint questID { /* [XID] */ /* 0x0000000189685720-0x0000000189685740 */ get => default; } // 0x00000001822688B0-0x0000000182268970 
	public bool isRandom { /* [XID] */ /* 0x00000001896C0BE0-0x00000001896C0C00 */ get => default; } // 0x0000000182268970-0x0000000182268B10 
	public bool hasValue { /* [XID] */ /* 0x0000000189912170-0x0000000189912190 */ get => default; } // 0x0000000182268560-0x0000000182268630 
	public uint mainId { /* [XID] */ /* 0x00000001896CFC90-0x00000001896CFCB0 */ get => default; } // 0x0000000182268330-0x00000001822684A0 
	public uint questMainId { /* [XID] */ /* 0x00000001896D6EC0-0x00000001896D6EE0 */ get => default; } // 0x0000000182268EE0-0x0000000182269280 
	public uint subId { /* [XID] */ /* 0x0000000189919CD0-0x0000000189919CF0 */ get => default; } // 0x0000000182267690-0x0000000182267880 
	public int order { /* [XID] */ /* 0x00000001896E5A30-0x00000001896E5A50 */ get => default; } // 0x0000000182265D60-0x0000000182265E30 
	public bool finishParent { /* [XID] */ /* 0x000000018994DD60-0x000000018994DD80 */ get => default; } // 0x0000000182268260-0x0000000182268330 
	public bool failParent { /* [XID] */ /* 0x00000001896F4900-0x00000001896F4920 */ get => default; } // 0x0000000182266860-0x00000001822669C0 
	public QuestShowType failParentShow { /* [XID] */ /* 0x00000001896FC190-0x00000001896FC1B0 */ get => default; } // 0x0000000182267330-0x0000000182267340 
	public bool isRewind { /* [XID] */ /* 0x0000000189703730-0x0000000189703750 */ get => default; } // 0x0000000182268CE0-0x0000000182268DB0 
	public QuestShowType showType { /* [XID] */ /* 0x000000018970ADA0-0x000000018970ADC0 */ get => default; } // 0x0000000182266410-0x00000001822665F0 
	public ShowQuestGuideType showGuide { /* [XID] */ /* 0x0000000189712630-0x0000000189712650 */ get => default; } // 0x0000000182268630-0x0000000182268800 
	public QuestGuideEx guide { /* [XID] */ /* 0x0000000189719ED0-0x0000000189719EF0 */ get => default; } // 0x0000000182268C00-0x0000000182268CE0 
	public BanGroupType banType { /* [XID] */ /* 0x00000001897213F0-0x0000000189721410 */ get => default; } // 0x0000000182268DB0-0x0000000182268EE0 
	public uint subIdSet { /* [XID] */ /* 0x00000001897289D0-0x00000001897289F0 */ get => default; } // 0x0000000182265E30-0x0000000182266170 
	public string desc { /* [XID] */ /* 0x000000018973F700-0x000000018973F720 */ get => default; } // 0x0000000182267190-0x0000000182267260 
	public string stepDesc { /* [XID] */ /* 0x0000000189746AA0-0x0000000189746AC0 */ get => default; } // 0x00000001822666C0-0x0000000182266780 
	public string guideTips { /* [XID] */ /* 0x000000018974E450-0x000000018974E470 */ get => default; } // 0x0000000182267260-0x0000000182267330 

	// Constructors
	public QuestExcelConfigProxy(uint questId, uint questConfigId = 0 /* Metadata: 0x00AEF909 */, bool init = false /* Metadata: 0x00AEF90D */) : this() {
		_questId = default;
		_questCfg = default;
		_randCfg = default;
	} // 0x0000000182269330-0x0000000182269360

	// Methods
	// [XID] // 0x000000018968D0A0-0x000000018968D0C0
	public string GetRandomParam(string param) => default; // 0x0000000182268B10-0x0000000182268C00
	// [XID] // 0x0000000189694D00-0x0000000189694D20
	public MainQuestExcelConfigProxy GetMainQuestExcelConfigProxy() => default; // 0x0000000182266CC0-0x0000000182266DC0
	// [XID] // 0x000000018969C480-0x000000018969C4A0
	public bool TryGetMainQuestExcelConfigProxy(out MainQuestExcelConfigProxy configProxy) {
		configProxy = default;
		return default;
	} // 0x00000001822684A0-0x0000000182268560
	// [XID] // 0x00000001896A3920-0x00000001896A3940
	public bool IsDangerous(uint avatarLevel) => default; // 0x00000001822656B0-0x0000000182265C90
	// [XID] // 0x00000001896AADB0-0x00000001896AADD0
	public void Clear() {} // 0x0000000182266780-0x0000000182266860
	// [XID] // 0x00000001896B1DF0-0x00000001896B1E10
	public bool UpdateConfig(uint questId, uint questConfigId = 0 /* Metadata: 0x00AEF90E */, bool init = false /* Metadata: 0x00AEF912 */) => default; // 0x0000000182267080-0x0000000182267190
	// [XID] // 0x00000001896B9890-0x00000001896B98B0
	public static bool IsRandom(uint questId) => default; // 0x0000000182267340-0x00000001822675C0
	// [XID] // 0x0000000189730200-0x0000000189730220
	public uint finishCondCount(int i) => default; // 0x0000000182268800-0x00000001822688B0
	// [XID] // 0x0000000189737BC0-0x0000000189737BE0
	public uint failCondCount(int i) => default; // 0x00000001822655B0-0x00000001822656B0
	// [XID] // 0x0000000189755AD0-0x0000000189755AF0
	public uint GetFailedRewindID() => default; // 0x00000001822653E0-0x00000001822655B0
	// [XID] // 0x000000018975CDB0-0x000000018975CDD0
	public uint GetFinishRewindID() => default; // 0x0000000182264EF0-0x0000000182265230
	// [XID] // 0x0000000189764620-0x0000000189764640
	public uint GetGuideScene() => default; // 0x0000000182266DC0-0x0000000182267080
	// [XID] // 0x000000018976BEC0-0x000000018976BEE0
	public Vector3 GetGuidePos() => default; // 0x0000000182267B80-0x0000000182268180
	// [XID] // 0x00000001897733A0-0x00000001897733C0
	public float GetGuideAreaRadius() => default; // 0x0000000182267880-0x0000000182267B80
	// [XID] // 0x000000018977AAE0-0x000000018977AB00
	public uint GetGuideTargetNpc() => default; // 0x0000000182269280-0x0000000182269330
	// [XID] // 0x0000000189782680-0x00000001897826A0
	public string GetNpcInSceneGuideName(bool useDefault = false /* Metadata: 0x00AEF913 */) => default; // 0x0000000182268180-0x0000000182268260
	// [XID] // 0x00000001897899A0-0x00000001897899C0
	public string GetQuestMarkGuideName(bool useDefault = false /* Metadata: 0x00AEF914 */) => default; // 0x0000000182265C90-0x0000000182265D60
	// [XID] // 0x00000001897911D0-0x00000001897911F0
	public int GetFinishCondParamByType(QuestContentType questType) => default; // 0x0000000182266170-0x0000000182266340
	// [XID] // 0x00000001897989A0-0x00000001897989C0
	public int GetFinishCondParam(int indexCond, int indexParam) => default; // 0x00000001822675C0-0x0000000182267690
	// [XID] // 0x00000001897A0770-0x00000001897A0790
	public QuestContentType GetFinishCondType(int indexCond) => default; // 0x00000001822669C0-0x0000000182266B20
	// [XID] // 0x00000001897A7D60-0x00000001897A7D80
	public QuestExecType GetFinishExecType(int indexCond) => default; // 0x0000000182266B20-0x0000000182266CC0
	// [XID] // 0x00000001897AF810-0x00000001897AF830
	public string GetFinishExecParam(int indexFinish, int indexParam) => default; // 0x0000000182266340-0x0000000182266410
	// [XID] // 0x00000001897B7690-0x00000001897B76B0
	public int GetFailCondParamByType(QuestContentType questType) => default; // 0x0000000182265230-0x00000001822653E0
	// [XID] // 0x00000001897BF590-0x00000001897BF5B0
	public int GetFailCondParam(int indexCond, int indexParam) => default; // 0x00000001822665F0-0x00000001822666C0
}

