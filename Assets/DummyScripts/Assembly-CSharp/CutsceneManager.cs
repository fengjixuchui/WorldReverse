/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoEmotion;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CutsceneManager : GlobalManager, IWorldShiftAgent // TypeDefIndex: 20707
{
	// Fields
	private const string DIRECTOR_PREFAB_PATH = "Build/Common/Director"; // Metadata: 0x00AFE0B2
	private const string WWISE_AUDIO_PREFAB_PATH = "Build/Camera/CameraWwiseAudio"; // Metadata: 0x00AFE0CB
	private uint _resHandler; // 0x10
	private uint _resCameraAudioHandler; // 0x14
	private Queue<CutsceneTask> _taskQueue; // 0x18
	private Action<ConfigBaseCutscene> _externalStartHandler; // 0x20
	private Action<ConfigBaseCutscene> _externalFinishHandler; // 0x28
	private CutsceneTask _tickedTask; // 0x30
	private List<BaseCutsceneTask> _freeTasks; // 0x38
	private Dictionary<string, int> _freeTaskIndexDic; // 0x40
	private MonoWwiseAudio _cameraWwiseAudio; // 0x48
	private const int MAX_SHORT_DIALOG_NUM = 200; // Metadata: 0x00AFE0EC
	public const string EMO_SHORT_DIALOG_PRE_PATH = "ART/"; // Metadata: 0x00AFE0F0
	public const string EMO_SHORT_DIALOG_MID_PATH = "Cutscene/ShortDialog/"; // Metadata: 0x00AFE0F8
	public const string EMO_SHORT_DIALOG_PHONEME_PATH = "Cs_Emo_Avatar_Simple_Common_Set/Cs_Emo_Phonemes/"; // Metadata: 0x00AFE111
	public const string EMO_SHORT_DIALOG_EMOTION_PATH = "Cs_Emo_Avatar_Simple_Common_Set/Cs_Emo_Emotions/"; // Metadata: 0x00AFE145
	public const string EMO_SHORT_DIALOG_TALK_PATH = "Cs_Emo_Avatar_Simple_Common_Set/Cs_Emo_Avatar_Talk/"; // Metadata: 0x00AFE179
	public static readonly int EMO_SHORT_DIALOG_PRE_PATH_LENGTH; // 0x00
	private Dictionary<ulong, SequenceBakeData> _seqHashDataCache; // 0x50
	private Dictionary<ulong, uint> _seqHashDataHandlerCache; // 0x58
	private Dictionary<ulong, SubSequenceBakeData> _subSeqHashDataCache; // 0x60
	private Dictionary<ulong, uint> _subSeqHashDataHandlerCache; // 0x68
	private Dictionary<string, SequenceBakeData> _seqDataCache; // 0x70
	private Dictionary<string, SubSequenceBakeData> _subSeqDataCache; // 0x78
	private Dictionary<string, uint> _seqDataHandlerCache; // 0x80
	public static bool DebugFreeCamera; // 0x04
	private bool _isMusicCameraLooping; // 0x88
	private bool _isMusicCameraPlaying; // 0x89
	private string _currentMusicCameraPath; // 0x90
	private ConfigMusicCamera _currentCameraConfig; // 0x98
	private float _waitTime; // 0xA0
	private ConfigMusicGameCamera _configMusicGameCamera; // 0xA8
	private ConfigMusicCamera[] cameraConfigList; // 0xB0
	private int _currPlayingIndex; // 0xB8
	private static string CameraLookAnchorPoint; // 0x08

	// Properties
	public CutsceneTask currRunningTask { /* [XID] */ /* 0x00000001895F44B0-0x00000001895F44D0 */ get => default; } // 0x000000018183D9B0-0x000000018183DAB0 
	public MonoWwiseAudio cameraWwiseAudio { /* [XID] */ /* 0x0000000189A39450-0x0000000189A39470 */ get => default; } // 0x0000000181840DF0-0x0000000181840FA0 

	// Constructors
	public CutsceneManager() {} // 0x0000000181841620-0x0000000181841820
	static CutsceneManager() {} // 0x0000000181841570-0x0000000181841620

	// Methods
	// [XID] // 0x00000001899D8B70-0x00000001899D8B90
	public override void ReloadRes() {} // 0x0000000181840FA0-0x0000000181841040
	// [XID] // 0x00000001899E7D20-0x00000001899E7D40
	public void RegisterExternalStartHandler(Action<ConfigBaseCutscene> handler) {} // 0x000000018183AE40-0x000000018183AF20
	// [XID] // 0x00000001899EF120-0x00000001899EF140
	public void UnRegisterExternalStartHandler(Action<ConfigBaseCutscene> handler) {} // 0x000000018183AC90-0x000000018183AD70
	// [XID] // 0x00000001899F6B10-0x00000001899F6B30
	private void CallExternalStartHandler() {} // 0x000000018183F8A0-0x000000018183F990
	// [XID] // 0x00000001899FE0F0-0x00000001899FE110
	public void RegisterExternalFinishHandler(Action<ConfigBaseCutscene> handler) {} // 0x000000018183E970-0x000000018183EA50
	// [XID] // 0x0000000189A059F0-0x0000000189A05A10
	public void UnRegisterExternalFinishHandler(Action<ConfigBaseCutscene> handler) {} // 0x000000018183B390-0x000000018183B470
	// [XID] // 0x0000000189A0CCE0-0x0000000189A0CD00
	private void CallExternalFinishHandler(CutsceneTask task) {} // 0x000000018183C1E0-0x000000018183C2D0
	// [XID] // 0x0000000189A14600-0x0000000189A14620
	public void CutsceneSafeCall(Action func) {} // 0x000000018183CEA0-0x000000018183CF90
	// [XID] // 0x0000000189A1B890-0x0000000189A1B8B0
	public bool HasFreeTask(string resPath) => default; // 0x000000018183FD50-0x000000018183FE20
	// [XID] // 0x0000000189A23280-0x0000000189A232A0
	public BaseCutsceneTask GetFreeTask(string resPath) => default; // 0x000000018183B020-0x000000018183B130
	// [XID] // 0x0000000189A2A480-0x0000000189A2A4A0
	public void AddFreeTask(BaseCutsceneTask task) {} // 0x000000018183AAF0-0x000000018183AC90
	// [XID] // 0x0000000189A31950-0x0000000189A31970
	public void RemoveFreeTask(string resPath) {} // 0x000000018183C860-0x000000018183C990
	// [XID] // 0x0000000189A40C10-0x0000000189A40C30
	public override void Init() {} // 0x000000018183E480-0x000000018183E630
	// [XID] // 0x0000000189A48290-0x0000000189A482B0
	public void PlayByIndex(uint cutsceneIndex, uint mainQuestId, bool asyncLoad, BaseInterAction interAction, ILuaActor ownerActor, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null, Action<ILuaActor> destroyCallback = null) {} // 0x000000018183BA10-0x000000018183BD60
	// [XID] // 0x0000000189A4FB40-0x0000000189A4FB60
	public void RemoveCutsceneTask(CutsceneTask task) {} // 0x000000018183CCB0-0x000000018183CDF0
	// [XID] // 0x0000000189A570D0-0x0000000189A570F0
	public void PlayByContext(ConfigBaseCutscene cutsceneConfig) {} // 0x00000001818400F0-0x0000000181840200
	// [XID] // 0x0000000189A5EC70-0x0000000189A5EC90
	public void PlayByInterAction(BaseInterAction interAction, uint mainQuestId) {} // 0x000000018183BF40-0x000000018183C1E0
	// [XID] // 0x0000000189A66410-0x0000000189A66430
	public void PlayByConfigTimeline(ConfigTimeline cfg, uint mainQuestId, ILuaActor owner, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null, Action<ILuaActor> destroyCallback = null) {} // 0x000000018183DAB0-0x000000018183DDE0
	// [XID] // 0x0000000189A6DB00-0x0000000189A6DB20
	public void PlayerFreeByPath(string path, Vector3 pos, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null, bool useTargetPos = true /* Metadata: 0x00AFE0A8 */, CutsceneInitPosType initType = CutsceneInitPosType.FREE /* Metadata: 0x00AFE0A9 */, bool syncLoad = true /* Metadata: 0x00AFE0AD */, bool keep = false /* Metadata: 0x00AFE0AE */, bool forceGC = true /* Metadata: 0x00AFE0AF */) {} // 0x000000018183F080-0x000000018183F280
	// [XID] // 0x0000000189A75250-0x0000000189A75270
	public void StopFreeByPath(string path) {} // 0x0000000181840480-0x0000000181840550
	// [XID] // 0x0000000189A7CED0-0x0000000189A7CEF0
	public void PlayFreeByConfigTimeline(ConfigTimeline cfg, ILuaActor owner, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null) {} // 0x000000018183CB70-0x000000018183CCB0
	// [XID] // 0x0000000189A847E0-0x0000000189A84800
	public void StopFreeByConfigTimeline(ConfigTimeline cfg, bool force) {} // 0x000000018183AF20-0x000000018183B020
	// [XID] // 0x0000000189A8C0C0-0x0000000189A8C0E0
	public override void Tick() {} // 0x00000001818413A0-0x0000000181841570
	// [XID] // 0x0000000189A93570-0x0000000189A93590
	public override void LateTick() {} // 0x000000018183F990-0x000000018183FAD0
	// [XID] // 0x0000000189A9B040-0x0000000189A9B060
	private void TickMainTask() {} // 0x000000018183C2D0-0x000000018183C490
	// [XID] // 0x0000000189AA23B0-0x0000000189AA23D0
	private void LateTickMainTask() {} // 0x000000018183AD70-0x000000018183AE40
	// [XID] // 0x0000000189AA9940-0x0000000189AA9960
	private void TickFreeTask() {} // 0x000000018183A940-0x000000018183AAF0
	// [XID] // 0x0000000189AB16E0-0x0000000189AB1700
	private void LateTickFreeTask() {} // 0x0000000181840C70-0x0000000181840DF0
	// [IDTag] // 0x0000000189AB8AA0-0x0000000189AB8AE0
	// [XID] // 0x0000000189AB8AA0-0x0000000189AB8AE0
	public SequenceBakeData GetSequenceData(ulong hash) => default; // 0x000000018183F430-0x000000018183F5C0
	// [IDTag] // 0x0000000189AC3B40-0x0000000189AC3B80
	// [XID] // 0x0000000189AC3B40-0x0000000189AC3B80
	public SubSequenceBakeData GetSubSequenceData(ulong hash) => default; // 0x000000018183E7E0-0x000000018183E970
	// [IDTag] // 0x0000000189ACE170-0x0000000189ACE1B0
	// [XID] // 0x0000000189ACE170-0x0000000189ACE1B0
	public SequenceBakeData GetSequenceData(string path) => default; // 0x000000018183F280-0x000000018183F430
	// [IDTag] // 0x0000000189AD8E70-0x0000000189AD8EB0
	// [XID] // 0x0000000189AD8E70-0x0000000189AD8EB0
	public SubSequenceBakeData GetSubSequenceData(string path) => default; // 0x000000018183E630-0x000000018183E7E0
	// [XID] // 0x00000001897976D0-0x00000001897976F0
	private void ClearSequenceData(bool forceClear = false /* Metadata: 0x00AFE0B0 */) {} // 0x000000018183D3B0-0x000000018183D9B0
	// [XID] // 0x0000000189AEB0B0-0x0000000189AEB0D0
	public bool PlayEmoSyncByInterAction(BaseInterAction interAction, BaseEntity owner, EmoSync emoSync = null) => default; // 0x0000000181840550-0x0000000181840C10
	// [XID] // 0x0000000189736610-0x0000000189736630
	public bool PlayEmoSyncByPath(string dataPath, EmoSync emoSync, BaseEntity entity = null) => default; // 0x000000018183FBA0-0x000000018183FD50
	// [XID] // 0x0000000189AFA280-0x0000000189AFA2A0
	public void TryPlayEmotionByPath(string emotionPath, EmoSync emoSync, BaseEntity entity) {} // 0x000000018183D180-0x000000018183D330
	// [XID] // 0x0000000189B01820-0x0000000189B01840
	public void TryClearPlayEmotionFromTemplate(EmoSync emoSync) {} // 0x000000018183D090-0x000000018183D180
	// [XID] // 0x0000000189B92780-0x0000000189B927A0
	private void PlayEmoSyncOnAsyncLoad(string path, EmoSync emoSync, BaseEntity entity) {} // 0x000000018183EF20-0x000000018183F080
	// [XID] // 0x0000000189B10850-0x0000000189B10870
	private void PlayEmoSyncOnAsyncInternal(string path, string fullPath, EmoSync emoSync, BaseEntity entity) {} // 0x000000018183C9F0-0x000000018183CB70
	// [XID] // 0x0000000189B17900-0x0000000189B17920
	public void PreloadEmoSync(string path) {} // 0x000000018183B750-0x000000018183B880
	// [XID] // 0x00000001898AD000-0x00000001898AD020
	private void PreloadEmoSyncInternal(string path, string fullPath) {} // 0x000000018183FF90-0x00000001818400F0
	// [XID] // 0x0000000189B26AB0-0x0000000189B26AD0
	private ulong GetHashToUse(ulong[] list, bool isSub = false /* Metadata: 0x00AFE0B1 */) => default; // 0x000000018183B130-0x000000018183B390
	// [XID] // 0x0000000189B2DC80-0x0000000189B2DCA0
	private string GetSeqDataPath(string path) => default; // 0x0000000181840200-0x0000000181840300
	// [XID] // 0x0000000189B350F0-0x0000000189B35110
	private string GetSeqEmoDataPath(string path) => default; // 0x000000018183CF90-0x000000018183D090
	// [XID] // 0x0000000189B3C9A0-0x0000000189B3C9C0
	private string GetSeqPhoDataPath(string path) => default; // 0x000000018183E380-0x000000018183E480
	// [XID] // 0x0000000189B44710-0x0000000189B44730
	private string GetSeqDataFullPath(string path) => default; // 0x000000018183B650-0x000000018183B750
	// [XID] // 0x0000000189B4BF00-0x0000000189B4BF20
	public override void Destroy() {} // 0x000000018183BD60-0x000000018183BE10
	// [XID] // 0x0000000189B53420-0x0000000189B53440
	public override void ClearOnLevelDestroy() {} // 0x000000018183B550-0x000000018183B650
	// [XID] // 0x0000000189B5AD30-0x0000000189B5AD50
	public override void ClearOnDisconnect() {} // 0x000000018183B470-0x000000018183B550
	// [XID] // 0x0000000189B621B0-0x0000000189B621D0
	private void DestroyTasks(bool needFinish) {} // 0x000000018183C6C0-0x000000018183C860
	// [XID] // 0x0000000189B69DF0-0x0000000189B69E10
	public void ResetCutsceneEmo() {} // 0x000000018183F5C0-0x000000018183F8A0
	[Preserve] // 0x0000000189B71320-0x0000000189B71360
	// [XID] // 0x0000000189B71320-0x0000000189B71360
	public override string Dump(string tag) => default; // 0x000000018183BE10-0x000000018183BF40
	// [XID] // 0x0000000189B7B690-0x0000000189B7B6B0
	public void ReadMusicGameCameraConfig() {} // 0x000000018183C490-0x000000018183C6C0
	// [XID] // 0x0000000189B83080-0x0000000189B830A0
	public void TickFreeSeq() {} // 0x000000018183B880-0x000000018183B960
	// [XID] // 0x0000000189B8A5D0-0x0000000189B8A5F0
	public void TryStartMusicCameraLoop() {} // 0x000000018183FE20-0x000000018183FF90
	// [XID] // 0x0000000189B91BC0-0x0000000189B91BE0
	private void TryPlayDefaultMusicCamera() {} // 0x000000018183CDF0-0x000000018183CEA0
	// [XID] // 0x0000000189B99080-0x0000000189B990A0
	private void TryPlayNextMusicCamera() {} // 0x000000018183E280-0x000000018183E380
	// [XID] // 0x0000000189BA0390-0x0000000189BA03B0
	private bool CheckCameraPlayable(ConfigMusicCamera config) => default; // 0x000000018183DDE0-0x000000018183E280
	// [XID] // 0x0000000189BA7BF0-0x0000000189BA7C10
	private bool PlayMusicCamera(int index) => default; // 0x000000018183EA50-0x000000018183EF20
	// [XID] // 0x0000000189BAF020-0x0000000189BAF040
	private void OnMusicCameraFinish(ILuaActor actor) {} // 0x000000018183FAD0-0x000000018183FBA0
	// [XID] // 0x0000000189BB66F0-0x0000000189BB6710
	public void StopMusicCamera() {} // 0x0000000181840300-0x0000000181840480
	// [XID] // 0x0000000189BBDD80-0x0000000189BBDDA0
	public bool ShiftWorld(Vector3 offset, Vector3 oldOffset) => default; // 0x0000000181841040-0x00000001818413A0
}

