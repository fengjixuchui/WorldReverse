/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using miHoYoEmotion;
using MoleMole.Config;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using VerletEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CutsceneUtils // TypeDefIndex: 20714
{
	// Fields
	public const uint ROLE_PAIMON_ID = 1005; // Metadata: 0x00AFE1C2
	private static Dictionary<uint, bool> _loadedDic; // 0x00
	private static List<DynamicBoneArray> _tempDynamicBones; // 0x08

	// Properties
	private static string CUTSCENE_INDEX_PRE_PATH { /* [XID] */ /* 0x00000001897626D0-0x00000001897626F0 */ get => default; } // 0x000000018210FD70-0x000000018210FE10 

	// Constructors
	public CutsceneUtils() {} // 0x000000018210FFF0-0x0000000182110050
	static CutsceneUtils() {} // 0x000000018210FF30-0x000000018210FFF0

	// Methods
	// [XID] // 0x00000001896A7500-0x00000001896A7520
	private static BaseEntity GetRoleEntity(uint roleID, uint mainQuestId) => default; // 0x000000018210DD10-0x000000018210DF00
	// [XID] // 0x00000001896AE9C0-0x00000001896AE9E0
	private static void PrintSayDialogWarning(uint dialogID) {} // 0x000000018210FE10-0x000000018210FF30
	// [IDTag] // 0x00000001896B61C0-0x00000001896B6200
	// [XID] // 0x00000001896B61C0-0x00000001896B6200
	public static void PreloadTalkSeq(ConfigTalkScheme talkConfig) {} // 0x000000018210E000-0x000000018210E190
	// [IDTag] // 0x00000001896C01B0-0x00000001896C01F0
	// [XID] // 0x00000001896C01B0-0x00000001896C01F0
	public static void PreloadTalkSeq(TalkExcelConfig talkConfig) {} // 0x000000018210E190-0x000000018210E320
	// [XID] // 0x00000001896CA6B0-0x00000001896CA6D0
	private static void PreloadTalkSeqInternal(uint dialogId, CutsceneManager cutsceneMgr, Dictionary<uint, bool> loadedDic) {} // 0x000000018210DA00-0x000000018210DD10
	// [IDTag] // 0x00000001896D1D40-0x00000001896D1D80
	// [XID] // 0x00000001896D1D40-0x00000001896D1D80
	public static void TryStopTalkDialog(DialogAction dialogAction, EmoSync emoSync, VCBaseAudio vcAudio, uint mainQuestId) {} // 0x000000018210D780-0x000000018210D8F0
	// [IDTag] // 0x00000001896DC3E0-0x00000001896DC420
	// [XID] // 0x00000001896DC3E0-0x00000001896DC420
	public static void TryStopTalkDialog(ConfigDialogScheme dialogCfg, EmoSync emoSync = null, VCBaseAudio vcAudio = null, uint mainQuestId = 0 /* Metadata: 0x00AFE1B0 */) {} // 0x000000018210D5F0-0x000000018210D780
	// [IDTag] // 0x00000001896E6900-0x00000001896E6940
	// [XID] // 0x00000001896E6900-0x00000001896E6940
	public static void TrySayTalkDialog(uint dialogID, uint mainQuestId = 0 /* Metadata: 0x00AFE1B4 */) {} // 0x000000018210E6E0-0x000000018210E800
	// [IDTag] // 0x00000001896F0C40-0x00000001896F0C80
	// [XID] // 0x00000001896F0C40-0x00000001896F0C80
	public static VCBaseAudio TrySayTalkDialog(ConfigDialogScheme dialogCfg, EmoSync emoSync = null, VCBaseAudio vcAudio = null, uint mainQuestId = 0 /* Metadata: 0x00AFE1B8 */, IDialogVoiceEventResponder responder = null) => default; // 0x000000018210EAD0-0x000000018210EE10
	[BlackList] // 0x00000001896FB7F0-0x00000001896FB830
	// [XID] // 0x00000001896FB7F0-0x00000001896FB830
	public static bool TrySayAutoNarrator(uint dialogID, uint mainQuestId, IDialogVoiceEventResponder responder) => default; // 0x000000018210F220-0x000000018210F470
	// [IDTag] // 0x0000000189705C20-0x0000000189705C60
	// [XID] // 0x0000000189705C20-0x0000000189705C60
	private static bool TrySayTalkDialog(ConfigDialogScheme dialogCfg, uint mainQuestId, IDialogVoiceEventResponder responder) => default; // 0x000000018210E800-0x000000018210EAD0
	// [XID] // 0x00000001897105C0-0x00000001897105E0
	public static void TrySayEmoSync(string assetPath, EmoSync emoSync, BaseEntity entity = null) {} // 0x000000018210CBF0-0x000000018210CD80
	// [XID] // 0x00000001897179E0-0x0000000189717A00
	public static void TryStopLocalAvatar() {} // 0x000000018210FC50-0x000000018210FD70
	// [XID] // 0x000000018971F470-0x000000018971F490
	public static void CopyCineBrain(CinemachineBrain from, CinemachineBrain to) {} // 0x000000018210C6F0-0x000000018210C870
	// [XID] // 0x0000000189726AA0-0x0000000189726AC0
	public static Transform GetRootTrans(GameObject go) => default; // 0x000000018210F0A0-0x000000018210F220
	public static List<BindingNode> BuildBindingList<T>(string roleName, T bindingComponent, List<TrackAsset> trackList, PlayableDirector director, ref Dictionary<string, List<BindingNode>> cache)
		where T : Component => default;
	// [XID] // 0x000000018972DFD0-0x000000018972DFF0
	public static void FreeBindingNode(BindingNode bindingNode, PlayableDirector director) {} // 0x000000018210CD80-0x000000018210CEF0
	// [XID] // 0x0000000189735670-0x0000000189735690
	public static void BindBindingNode(BindingNode bindingNode, PlayableDirector director, bool disableDynamicBone = true /* Metadata: 0x00AFE1BC */) {} // 0x000000018210D8F0-0x000000018210DA00
	// [XID] // 0x000000018973D250-0x000000018973D270
	public static void SwitchBindingComponent(BindingNode bindingNode, PlayableDirector director, bool disableDynamicBone = true /* Metadata: 0x00AFE1BD */) {} // 0x000000018210F470-0x000000018210F930
	// [XID] // 0x0000000189744730-0x0000000189744750
	public static void SwitchDynamicBone(GameObject entityGO, bool value) {} // 0x000000018210EE10-0x000000018210F0A0
	// [XID] // 0x000000018974C3F0-0x000000018974C410
	public static void SwitchBindngParent(BindingNode bindingNode) {} // 0x000000018210C9B0-0x000000018210CBF0
	// [XID] // 0x00000001897536A0-0x00000001897536C0
	public static void ClearCutsceneTemp() {} // 0x000000018210F930-0x000000018210FA10
	// [XID] // 0x000000018975ABA0-0x000000018975ABC0
	public static void UpdateSensorCutsceneMode(bool value) {} // 0x000000018210D4D0-0x000000018210D5F0
	// [XID] // 0x0000000189769D50-0x0000000189769D70
	public static void LoadAndPlayCutsceneIndexAsync(uint cutsceneIndex, CutsceneTask cutsceneTask) {} // 0x000000018210CEF0-0x000000018210D290
	// [XID] // 0x0000000189771340-0x0000000189771360
	public static void LoadAndPlayCutsceneIndexSync(uint cutsceneIndex, CutsceneTask cutsceneTask) {} // 0x000000018210E320-0x000000018210E6E0
	// [XID] // 0x0000000189778BA0-0x0000000189778BC0
	private static object CutsceneIndexSerializeBin(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFE1BE */) => default; // 0x000000018210DF00-0x000000018210E000
	// [XID] // 0x0000000189780140-0x0000000189780160
	private static object CutsceneIndexSerializeJson(JSONNode node) => default; // 0x000000018210FB50-0x000000018210FC50
	// [XID] // 0x0000000189787A00-0x0000000189787A20
	public static void OnCutsceneStart(bool pauseGameLogic) {} // 0x000000018210FA10-0x000000018210FB50
	// [XID] // 0x000000018978F060-0x000000018978F080
	public static void OnCutsceneFinish(bool pauseGameLogic) {} // 0x000000018210C870-0x000000018210C9B0
	// [XID] // 0x0000000189796890-0x00000001897968B0
	public static void ClearCurAvatarOwnGadgets() {} // 0x000000018210D290-0x000000018210D4D0
}

