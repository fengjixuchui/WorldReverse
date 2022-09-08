/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class InteractionManager : InLevelManager, INotifyInterface // TypeDefIndex: 20834
	{
		// Fields
		public const string AVATAR_ALIAS = "Avatar"; // Metadata: 0x00AFE68D
		public const string MATE_AVATAR_ALIAS = "MateAvatar"; // Metadata: 0x00AFE697
		public const string DEFAULT_ALIAS = "Default"; // Metadata: 0x00AFE6A5
		public const string TEMP_NPC_ACTOR_PATH = "Actor/Npc/TempNpcActor"; // Metadata: 0x00AFE6B0
		public const uint PLAYER_BOY_NPC_ID = 1025; // Metadata: 0x00AFE6CA
		public const uint PLAYER_GIRL_NPC_ID = 1026; // Metadata: 0x00AFE6CE
		private InteractionAvatarEntityProxy _localAvatarProxy; // 0x10
		private EntityHandle<AvatarEntity> _simpleTalkActionAvatarHandle; // 0x18
		private Action<uint> _interactionInteeCB; // 0x28
		private bool _isManulAttackMode; // 0x30
		private Dictionary<uint, ConfigInterActor> _returnDailyNpcConfigDic; // 0x38
		private HashSet<uint> _participantDic; // 0x40
		private Dictionary<string, string> _tmpAlias2Real; // 0x48
		private Dictionary<string, LCBaseIntee> _alias2intee; // 0x50
		private bool _canShowAvatarEffectWhenTalkStart; // 0x58
		private AnimeOverrideTalkReason _curLoadFreeStyleReason; // 0x5C
		private Dictionary<uint, int[]> _curLoadFreeStyleDic; // 0x60
		private uint _curLoadFreeStyleQuestId; // 0x68
		private ILuaActor _currInterActor; // 0x70
		private LCBaseIntee _mainIntee; // 0x88
		private int _keyInterCnt; // 0x90
		private bool _hasKeyPre; // 0x94
		private bool _havEndFade; // 0x95
		private float _endFadeInTime; // 0x98
		private float _endFadeOutTime; // 0x9C
		private bool _inEndFade; // 0xA0
		private bool _inStartFade; // 0xA1
		private bool _talkLoading; // 0xA2
		private bool _voiceLoading; // 0xA3
		private bool _isLockGameTime; // 0xA4
		private string _interEntityBanConfig; // 0xA8
		private bool _isFromPerformConfig; // 0xB0
		private LinkedList<InterActionGrp> _keyInterList; // 0xB8
		private Dictionary<ulong, LinkedListNode<InterActionGrp>> _idInterDic; // 0xC0
		private LinkedListNode<InterActionGrp> _currInterGrp; // 0xC8
		private List<InterActionGrp> _freeInterList; // 0xD0
		private Dictionary<uint, List<InterActionGrp>> _priorityBtnDic; // 0xD8
		private uint _triggeringEntityID; // 0xE0
		private bool _edtTalkWaiting; // 0xE4
		private List<uint> _evtInterFinishList; // 0xE8
		private Action _keyListFinishHandler; // 0xF0
		private Action _keyListPreFinishHandler; // 0xF8
		private Action _levelLoadFinishHandler; // 0x100
		private NpcInteractionRequestCache _npcInteractionRequest; // 0x108
		private IInterSystem[] _keyInterSystems; // 0x110
		private IInterSystem[] _keyUsingSystems; // 0x118
		private IInterSystem[] _freeInterSystems; // 0x120
		private IInterSystem[] _freeUsingSystems; // 0x128
		private RecycledLinkedList<IInterSystem[]> _systemListPool; // 0x130
		private List<LCBaseIntee> _candidateInteeAddList; // 0x138
		private List<ConfigTalkScheme> _candidateTalkCfgList; // 0x140
		private List<LCBaseIntee> _candidateInteeRemoveList; // 0x148
		private HashSet<uint> _currCandidateIdSet; // 0x150
		private bool _useSkip; // 0x158
		private float _skipMaxTime; // 0x15C
		private float _skipTickTime; // 0x160
		private Dictionary<LCBaseIntee, RecycledLinkedList<PreTalkPerformContext>> _curRunningPreTalkDic; // 0x168
		private RecycledLinkedList<PreTalkPerformContext> _curRunningPreTalkList; // 0x170
		private SimpleObjectPool<PreTalkPerformContext> _talkPerformContextPool; // 0x178
		private TalkDialogVoiceEventResponder _autoTalkVoiceResponder; // 0x180
		private Dictionary<string, List<int>> _effectHandlerDic; // 0x188
	
		// Properties
		public bool IsInInteraction { /* [XID] */ /* 0x00000001899827C0-0x00000001899827E0 */ get => default; } // 0x0000000182BC8F30-0x0000000182BC9000 
		public bool IsInInteractionWithoutVoiceLoading { /* [XID] */ /* 0x0000000189A816D0-0x0000000189A816F0 */ get => default; } // 0x0000000182BC8E40-0x0000000182BC8F30 
		public LCBaseInter inter { /* [XID] */ /* 0x0000000189855ED0-0x0000000189855EF0 */ get => default; } // 0x0000000182BC90E0-0x0000000182BC91A0 
		public bool isLockGametime { /* [XID] */ /* 0x0000000189BA9320-0x0000000189BA9340 */ get => default; } // 0x0000000182BC91A0-0x0000000182BC9250 
		public InterActionGrp CurrInterGrp { /* [XID] */ /* 0x0000000189BB0AF0-0x0000000189BB0B10 */ get => default; } // 0x0000000182BC8D80-0x0000000182BC8E40 
		public bool useSkip { /* [XID] */ /* 0x000000018980C650-0x000000018980C670 */ get => default; /* [XID] */ /* 0x0000000189813DE0-0x0000000189813E00 */ set {} } // 0x0000000182BC9250-0x0000000182BC9300 0x0000000182BC9540-0x0000000182BC96E0
		public TalkDialogVoiceEventResponder autoTalkVoiceResponder { /* [XID] */ /* 0x00000001898BB570-0x00000001898BB590 */ get => default; } // 0x0000000182BC9000-0x0000000182BC90E0 
	
		// Events
		public event Action<ILuaActor, int> StartInterEvent;
		public event Action<ILuaActor, int> FinishInterEvent;
	
		// Nested types
		private class NpcInteractionRequestCache // TypeDefIndex: 20835
		{
			// Fields
			public uint entityRuntimeID; // 0x10
			public bool force; // 0x14
			public bool async; // 0x15
	
			// Constructors
			public NpcInteractionRequestCache() {} // 0x0000000183A465E0-0x0000000183A468B0
	
			// Methods
			// [XID] // 0x00000001899B9440-0x00000001899B9460
			public void SetCache(uint runtimeId, bool force, bool async) {} // 0x0000000183A46500-0x0000000183A465E0
		}
	
		private class PreTalkPerformContext : ISimplePoolObject // TypeDefIndex: 20836
		{
			// Fields
			public LCBaseIntee tarIntee; // 0x10
			public IInterSystem[] allIntersystems; // 0x18
			public IInterSystem[] usedInterSystems; // 0x20
			public RecycledLinkedList<InterActionGrp> interGrpList; // 0x28
			public Dictionary<ulong, RecycledLinkedList<InterActionGrp>> interGrpIdDic; // 0x30
			public RecycledLinkedList<InterActionGrp> curInterGrp; // 0x38
			public uint preFreeStyle; // 0x40
	
			// Constructors
			public PreTalkPerformContext() {} // 0x0000000183A46960-0x0000000183A46A10
	
			// Methods
			// [XID] // 0x00000001899C0E30-0x00000001899C0E50
			public void ResetObject() {} // 0x0000000183A468B0-0x0000000183A46960
		}
	
		// Constructors
		public InteractionManager() {} // 0x0000000182BC8760-0x0000000182BC8B40
	
		// Methods
		// [XID] // 0x000000018985D180-0x000000018985D1A0
		private bool EnableCoop(LCBaseIntee intee, CoopInteractionRequestData coopData) => default; // 0x0000000182BBBCB0-0x0000000182BBBE60
		// [XID] // 0x0000000189864BF0-0x0000000189864C10
		private bool CheckCoopAuto(CoopInteractionRequestData coopData) => default; // 0x0000000182BB45D0-0x0000000182BB46A0
		// [XID] // 0x0000000189A54270-0x0000000189A54290
		public void ClearAfterCoopFinish() {} // 0x0000000182BB5210-0x0000000182BB52C0
		// [XID] // 0x0000000189A5BC80-0x0000000189A5BCA0
		public void RegisterNotify() {} // 0x0000000182BC3790-0x0000000182BC3890
		// [XID] // 0x0000000189A633D0-0x0000000189A633F0
		public void UnregisterNotify() {} // 0x0000000182BC8460-0x0000000182BC8560
		// [XID] // 0x0000000189A6AF30-0x0000000189A6AF50
		public bool OnNotify(Notify ntf) => default; // 0x0000000182BC0570-0x0000000182BC0660
		// [XID] // 0x0000000189BD29F0-0x0000000189BD2A10
		public void UpdateManulAttackMode(bool value) {} // 0x0000000182BC8560-0x0000000182BC8610
		// [XID] // 0x0000000189A890F0-0x0000000189A89110
		public ConfigInterActor GetReturnDailyNpcConfigDic(uint configId) => default; // 0x0000000182BBEF70-0x0000000182BBF060
		// [XID] // 0x0000000189A908D0-0x0000000189A908F0
		private void AddReturnDailyNpcConfigDic(ConfigInterActor cfg) {} // 0x0000000182BB31A0-0x0000000182BB3280
		// [XID] // 0x0000000189A98110-0x0000000189A98130
		private void ReturnDailyNpc() {} // 0x0000000182BC4BA0-0x0000000182BC4E00
		// [XID] // 0x00000001897AAFE0-0x00000001897AB000
		private void AddParticipant(ConfigTalkScheme talkConfig) {} // 0x0000000182BB2CC0-0x0000000182BB2F20
		// [XID] // 0x00000001897DECE0-0x00000001897DED00
		private void RemoveParticipants() {} // 0x0000000182BC3E10-0x0000000182BC4090
		// [XID] // 0x0000000189BB8B20-0x0000000189BB8B40
		public void AddTmpAlias2Real(string tmp, string real) {} // 0x0000000182BB3280-0x0000000182BB33A0
		// [XID] // 0x0000000189BC04D0-0x0000000189BC04F0
		public void AddAlias2Intee(string tmp, LCBaseIntee intee) {} // 0x0000000182BB26B0-0x0000000182BB2800
		// [XID] // 0x0000000189ABD790-0x0000000189ABD7B0
		public bool HasAlias(string alias) => default; // 0x0000000182BBF060-0x0000000182BBF180
		// [IDTag] // 0x0000000189AC51F0-0x0000000189AC5230
		// [XID] // 0x0000000189AC51F0-0x0000000189AC5230
		public LCBaseIntee GetIntee(string alias) => default; // 0x0000000182BBE6F0-0x0000000182BBE7C0
		// [IDTag] // 0x0000000189ACF6D0-0x0000000189ACF710
		// [XID] // 0x0000000189ACF6D0-0x0000000189ACF710
		private LCBaseIntee GetIntee(string alias, out string realAlias) {
			realAlias = default;
			return default;
		} // 0x0000000182BBE590-0x0000000182BBE6F0
		// [XID] // 0x00000001895EFD20-0x00000001895EFD40
		public BaseEntity GetActionAvatarEntity() => default; // 0x0000000182BBD9B0-0x0000000182BBDA80
		// [XID] // 0x0000000189AE1D90-0x0000000189AE1DB0
		private void FreeAvatarIntee() {} // 0x0000000182BBC2D0-0x0000000182BBC7A0
		// [XID] // 0x0000000189A67540-0x0000000189A67560
		private LCBaseIntee CreateInteeInternal(ConfigInterActor cfgActor) => default; // 0x0000000182BB79E0-0x0000000182BB7C00
		// [XID] // 0x0000000189AF1430-0x0000000189AF1450
		public LCBaseIntee CreateIntee(ConfigInterActor cfgActor) => default; // 0x0000000182BB7C00-0x0000000182BB7CC0
		// [XID] // 0x0000000189A19920-0x0000000189A19940
		public void LoadFreestyleAnime(uint talkId, uint questID, Dictionary<uint, int[]> freeStyleDic) {} // 0x0000000182BBF9D0-0x0000000182BBFCA0
		// [XID] // 0x0000000189AFFFD0-0x0000000189AFFFF0
		public void UnloadCurFreeStyleAnime() {} // 0x0000000182BC81F0-0x0000000182BC8460
		// [XID] // 0x0000000189A49150-0x0000000189A49170
		public void CreateInteeByList(ConfigInterActor[] cfgActors, bool forceSetLookAt, uint questID) {} // 0x0000000182BB7750-0x0000000182BB79E0
		// [XID] // 0x0000000189B0ED30-0x0000000189B0ED50
		private void CheckInteeEntityReady(Action finishCallback) {} // 0x0000000182BB47C0-0x0000000182BB4AC0
		// [XID] // 0x0000000189B4B220-0x0000000189B4B240
		private void StartForceSetLookAt() {} // 0x0000000182BC5DE0-0x0000000182BC5FB0
		// [XID] // 0x0000000189B1D750-0x0000000189B1D770
		private void StopLookAtOnly(BaseEntity entity) {} // 0x0000000182BC6A10-0x0000000182BC6AE0
		// [XID] // 0x0000000189B25100-0x0000000189B25120
		private void StopLookAtEyeCtrl(BaseEntity entity) {} // 0x0000000182BC6710-0x0000000182BC6A10
		// [XID] // 0x0000000189B2C630-0x0000000189B2C650
		private void StopForceSetLookAt(BaseEntity entity) {} // 0x0000000182BC65D0-0x0000000182BC6710
		// [XID] // 0x00000001896F1810-0x00000001896F1830
		private void RefreshNpcHeadControlTrigger() {} // 0x0000000182BC2850-0x0000000182BC2910
		// [XID] // 0x0000000189B3B450-0x0000000189B3B470
		public void CreateInterActor(uint guid, string metaPath) {} // 0x0000000182BB7CC0-0x0000000182BB7E40
		// [XID] // 0x0000000189B42CD0-0x0000000189B42CF0
		public void DestroyInterActor() {} // 0x0000000182BBAA50-0x0000000182BBABB0
		// [XID] // 0x0000000189B59640-0x0000000189B59660
		public void CallStartInterEvent() {} // 0x0000000182BB4510-0x0000000182BB45D0
		// [XID] // 0x0000000189B6F9A0-0x0000000189B6F9C0
		public void CallFinishInterEvent() {} // 0x0000000182BB3F50-0x0000000182BB4010
		// [XID] // 0x0000000189B7E520-0x0000000189B7E540
		private void CreateSimpleActorAsync(BaseEntity interEntity, BaseEntity inteeEntity, Action finishCallback) {} // 0x0000000182BB8B30-0x0000000182BB8D30
		// [XID] // 0x0000000189841580-0x00000001898415A0
		private void OnSimpleTalkEntityReady(BaseEntity interEntity, BaseEntity inteeEntity) {} // 0x0000000182BC1530-0x0000000182BC1680
		// [IDTag] // 0x0000000189B8D1D0-0x0000000189B8D210
		// [XID] // 0x0000000189B8D1D0-0x0000000189B8D210
		public void RefreshDialogInsert(LinkedList<InterActionGrp> actionList, bool insert) {} // 0x0000000182BC2000-0x0000000182BC2170
		// [IDTag] // 0x0000000189B97850-0x0000000189B97890
		// [XID] // 0x0000000189B97850-0x0000000189B97890
		public void RefreshDialogInsert(List<LinkedListNode<InterActionGrp>> actionList, bool insert) {} // 0x0000000182BC2170-0x0000000182BC22F0
		// [XID] // 0x000000018972BEA0-0x000000018972BEC0
		private void RefreshDialogInsertByActionGrp(InterActionGrp grp, bool insert) {} // 0x0000000182BC1E70-0x0000000182BC2000
		// [XID] // 0x0000000189BB7DA0-0x0000000189BB7DC0
		public BaseInterAction GetInerAction(InteractionType interType) => default; // 0x0000000182BBE230-0x0000000182BBE3B0
		// [XID] // 0x0000000189BBF470-0x0000000189BBF490
		public void SetNextIdOfCurrInterGrp(ulong nextGrpId) {} // 0x0000000182BC53F0-0x0000000182BC54E0
		// [XID] // 0x0000000189BC7030-0x0000000189BC7050
		public void ClearKeyInterList() {} // 0x0000000182BB6750-0x0000000182BB6880
		// [IDTag] // 0x0000000189BCED60-0x0000000189BCEDA0
		// [XID] // 0x0000000189BCED60-0x0000000189BCEDA0
		private void ClearInter(LinkedList<InterActionGrp> grpList) {} // 0x0000000182BB6630-0x0000000182BB6750
		// [IDTag] // 0x0000000189BD9210-0x0000000189BD9250
		// [XID] // 0x0000000189BD9210-0x0000000189BD9250
		private void ClearInter(List<InterActionGrp> grpList) {} // 0x0000000182BB6510-0x0000000182BB6630
		// [XID] // 0x00000001895E8D50-0x00000001895E8D70
		private void CallBeforeKeyListStart() {} // 0x0000000182BB3C00-0x0000000182BB3F50
		// [XID] // 0x00000001895F05A0-0x00000001895F05C0
		private void ClearPreKeyListFinish() {} // 0x0000000182BB6960-0x0000000182BB6C60
		// [XID] // 0x00000001895F8050-0x00000001895F8070
		private void ClearAfterKeyListFinish(bool isDestroy = false /* Metadata: 0x00AFE653 */) {} // 0x0000000182BB5370-0x0000000182BB5A50
		// [XID] // 0x0000000189797750-0x0000000189797770
		private void ResumeEntitySettings() {} // 0x0000000182BC4780-0x0000000182BC4A80
		// [XID] // 0x0000000189606C60-0x0000000189606C80
		private void DisableCameraDOF() {} // 0x0000000182BBAF80-0x0000000182BBB170
		// [XID] // 0x000000018960E5E0-0x000000018960E600
		private void ClearInteeOnFinal(LCBaseIntee intee) {} // 0x0000000182BB6120-0x0000000182BB6450
		// [XID] // 0x0000000189615C40-0x0000000189615C60
		public void PushInterActionByConfig(LCBaseIntee intee, string cfgStr, bool isExternal) {} // 0x0000000182BC1950-0x0000000182BC1AE0
		// [XID] // 0x000000018961D470-0x000000018961D490
		public void AddRangeToInterList(List<InterActionGrp> list) {} // 0x0000000182BB3020-0x0000000182BB31A0
		// [XID] // 0x0000000189624970-0x0000000189624990
		public void FinishCurrTalk(uint talkID) {} // 0x0000000182BBBFF0-0x0000000182BBC1F0
		// [IDTag] // 0x000000018962C0F0-0x000000018962C130
		// [XID] // 0x000000018962C0F0-0x000000018962C130
		public void AddInterGrpAtLast(InterActionGrp grp) {} // 0x0000000182BB2910-0x0000000182BB29D0
		// [IDTag] // 0x0000000189636E60-0x0000000189636EA0
		// [XID] // 0x0000000189636E60-0x0000000189636EA0
		public void AddInterGrpAtLast(List<InterActionGrp> actions) {} // 0x0000000182BB29D0-0x0000000182BB2B60
		// [XID] // 0x00000001896411E0-0x0000000189641200
		public InterActionGrp RemoveNextInterGrp() => default; // 0x0000000182BC3CB0-0x0000000182BC3E10
		// [XID] // 0x0000000189648B20-0x0000000189648B40
		public void ClearFreeInterList() {} // 0x0000000182BB6070-0x0000000182BB6120
		// [XID] // 0x00000001896501C0-0x00000001896501E0
		public void AddFreeInterByEvt(EvtInterFree evt) {} // 0x0000000182BB2800-0x0000000182BB2910
		// [XID] // 0x0000000189657AB0-0x0000000189657AD0
		public List<InterActionGrp> GetPriorityList(InterTimingType timingType, uint configID) => default; // 0x0000000182BBEE30-0x0000000182BBEF70
		// [XID] // 0x000000018965F1E0-0x000000018965F200
		public void AddPriorityList(InterTimingType timingType, List<InterActionGrp> list, uint configID) {} // 0x0000000182BB2F20-0x0000000182BB3020
		// [XID] // 0x0000000189666990-0x00000001896669B0
		public void ClearPriorityList(InterTimingType timingType, uint configID) {} // 0x0000000182BB6C60-0x0000000182BB6D40
		// [XID] // 0x000000018966E090-0x000000018966E0B0
		public void ClearAllPriorityList() {} // 0x0000000182BB5B20-0x0000000182BB5BE0
		// [XID] // 0x0000000189675F00-0x0000000189675F20
		public bool CheckOnFiledEnter(uint configID) => default; // 0x0000000182BB5050-0x0000000182BB5140
		// [XID] // 0x000000018967D7A0-0x000000018967D7C0
		public bool CheckOnFieldExit(uint configID) => default; // 0x0000000182BB4F60-0x0000000182BB5050
		// [XID] // 0x0000000189621150-0x0000000189621170
		public bool CheckOnBtnTrigger(uint configID) => default; // 0x0000000182BB4E60-0x0000000182BB4F60
		// [XID] // 0x000000018968C8C0-0x000000018968C8E0
		private void PushToList(List<InterActionGrp> tempList, LinkedList<InterActionGrp> targetList) {} // 0x0000000182BC1AE0-0x0000000182BC1C40
		// [XID] // 0x00000001896943F0-0x0000000189694410
		private void InteeAppeared(LCBaseIntee intee) {} // 0x0000000182BBF720-0x0000000182BBF8C0
		// [XID] // 0x0000000189B34850-0x0000000189B34870
		public IGeneralIntee AllocateInteractionInteeBtn(uint entityRuntimeID) => default; // 0x0000000182BB33A0-0x0000000182BB3B10
		// [XID] // 0x00000001896A3080-0x00000001896A30A0
		private void OnInteractionBtnCB(uint id) {} // 0x0000000182BC03F0-0x0000000182BC04B0
		// [XID] // 0x00000001896AA4D0-0x00000001896AA4F0
		public void SetEdtTalkWaiting() {} // 0x0000000182BC5350-0x0000000182BC53F0
		// [XID] // 0x00000001896B13B0-0x00000001896B13D0
		public void DispatchFinishInterEvent() {} // 0x0000000182BBB2E0-0x0000000182BBB4E0
		// [XID] // 0x00000001896B8E70-0x00000001896B8E90
		public void DispatchFinishInterDialogEvent() {} // 0x0000000182BBB170-0x0000000182BBB2E0
		// [XID] // 0x0000000189682C70-0x0000000189682C90
		public bool OnNpcTriggerEnter(LCBaseIntee intee, bool force = false /* Metadata: 0x00AFE654 */) => default; // 0x0000000182BC0E30-0x0000000182BC12F0
		// [XID] // 0x0000000189BB2F20-0x0000000189BB2F40
		public bool OnNpcTriggerExit(LCBaseIntee intee, bool force = true /* Metadata: 0x00AFE655 */) => default; // 0x0000000182BC12F0-0x0000000182BC1530
		// [XID] // 0x00000001896CF220-0x00000001896CF240
		public bool OnNpcTriggerBtn(LCBaseIntee intee, bool force = false /* Metadata: 0x00AFE656 */, bool async = true /* Metadata: 0x00AFE657 */) => default; // 0x0000000182BC0840-0x0000000182BC0E30
		// [XID] // 0x00000001896D6500-0x00000001896D6520
		private bool CheckInteractionAngle(LCBaseInter inter, LCBaseIntee intee, float angle) => default; // 0x0000000182BB4B80-0x0000000182BB4E60
		// [XID] // 0x00000001896DDBE0-0x00000001896DDC00
		private bool CheckInterState(LCBaseInter inter) => default; // 0x0000000182BB4AC0-0x0000000182BB4B80
		// [XID] // 0x00000001896E5250-0x00000001896E5270
		private bool CheckGadgetAlwaysInteractive(BaseEntity entity) => default; // 0x0000000182BB46A0-0x0000000182BB47C0
		// [XID] // 0x0000000189709C00-0x0000000189709C20
		public void RefreshClearCandidate() {} // 0x0000000182BC1D80-0x0000000182BC1E70
		// [XID] // 0x00000001896F3F40-0x00000001896F3F60
		public bool RefreshNpcTalkManual(LCBaseIntee intee, bool batch = false /* Metadata: 0x00AFE658 */, uint lastTalkId = 0 /* Metadata: 0x00AFE659 */) => default; // 0x0000000182BC2910-0x0000000182BC32B0
		// [XID] // 0x00000001896FB7D0-0x00000001896FB7F0
		public void RefreshAllTalkManual() {} // 0x0000000182BC1C40-0x0000000182BC1D80
		// [XID] // 0x0000000189702DF0-0x0000000189702E10
		public void RefreshFromCandidate(LCBaseInter inter) {} // 0x0000000182BC22F0-0x0000000182BC2850
		// [XID] // 0x0000000189A3A270-0x0000000189A3A290
		public void CallOnKeyListFinish(Action handler) {} // 0x0000000182BB4190-0x0000000182BB42A0
		// [XID] // 0x0000000189711FB0-0x0000000189711FD0
		private void CallKeyListFinishHandler() {} // 0x0000000182BB4010-0x0000000182BB40D0
		// [XID] // 0x0000000189719570-0x0000000189719590
		public void CallOnKeyListPreFinish(Action handler) {} // 0x0000000182BB42A0-0x0000000182BB43C0
		// [XID] // 0x000000018962B930-0x000000018962B950
		private void CallKeyListPreFinishHandler() {} // 0x0000000182BB40D0-0x0000000182BB4190
		// [XID] // 0x0000000189728150-0x0000000189728170
		public void CallOnLevelLoadFinish(Action handler) {} // 0x0000000182BB43C0-0x0000000182BB4510
		// [XID] // 0x000000018972F7F0-0x000000018972F810
		private void OnLevelLoadFinishNotify() {} // 0x0000000182BC04B0-0x0000000182BC0570
		// [XID] // 0x0000000189737220-0x0000000189737240
		private void NotifyAudioFeatureWhenKeyEmpty() {} // 0x0000000182BBFCA0-0x0000000182BBFD70
		// [XID] // 0x0000000189871F10-0x0000000189871F30
		private void NotifyAudioFeature(bool disable) {} // 0x0000000182BBFD70-0x0000000182BBFEE0
		// [XID] // 0x0000000189746000-0x0000000189746020
		public void ClearIntee(bool isDestroy = false /* Metadata: 0x00AFE65D */) {} // 0x0000000182BB6450-0x0000000182BB6510
		// [XID] // 0x00000001899C4E70-0x00000001899C4E90
		public bool OnEvtInterruptIntee(bool isDestroy = false /* Metadata: 0x00AFE65E */) => default; // 0x0000000182BC01F0-0x0000000182BC03F0
		// [XID] // 0x0000000189755100-0x0000000189755120
		public bool OnEvtInterFree(EvtInterFree evt) => default; // 0x0000000182BC00F0-0x0000000182BC01F0
		// [XID] // 0x0000000189BDFFF0-0x0000000189BE0010
		public void RequestNPCInteraction(uint entityRuntimeID, bool force = false /* Metadata: 0x00AFE65F */, bool async = true /* Metadata: 0x00AFE660 */) {} // 0x0000000182BC41C0-0x0000000182BC4360
		// [XID] // 0x0000000189763C80-0x0000000189763CA0
		private void DoNPCInteractionRequest() {} // 0x0000000182BBB8C0-0x0000000182BBBBB0
		// [XID] // 0x000000018976B460-0x000000018976B480
		private void UseSystem(int index, ref IInterSystem[] interSystems, ref IInterSystem[] usingSystems) {} // 0x0000000182BC8610-0x0000000182BC8760
		// [XID] // 0x0000000189772A60-0x0000000189772A80
		private void ClearUsingSystem(ref IInterSystem[] usingSystems) {} // 0x0000000182BB6D40-0x0000000182BB6E40
		// [XID] // 0x000000018977A220-0x000000018977A240
		public override void Init() {} // 0x0000000182BBF620-0x0000000182BBF720
		// [XID] // 0x0000000189781DA0-0x0000000189781DC0
		private void InitSystems() {} // 0x0000000182BBF560-0x0000000182BBF620
		// [XID] // 0x0000000189754850-0x0000000189754870
		private IInterSystem[] GenerateSystemList() => default; // 0x0000000182BBC7A0-0x0000000182BBD9B0
		// [XID] // 0x00000001897907D0-0x00000001897907F0
		private void InitConfig() {} // 0x0000000182BBF270-0x0000000182BBF330
		// [XID] // 0x0000000189798120-0x0000000189798140
		private void ReleaseSystemList(IInterSystem[] list) {} // 0x0000000182BC3890-0x0000000182BC39B0
		// [XID] // 0x000000018979FF90-0x000000018979FFB0
		public override void Tick() {} // 0x0000000182BC7BB0-0x0000000182BC7FF0
		// [XID] // 0x00000001897A74E0-0x00000001897A7500
		private bool HasInter(LinkedList<InterActionGrp> grpList) => default; // 0x0000000182BBF180-0x0000000182BBF270
		// [IDTag] // 0x00000001897AEF70-0x00000001897AEFB0
		// [XID] // 0x00000001897AEF70-0x00000001897AEFB0
		private bool TickInter(LinkedList<InterActionGrp> grpList) => default; // 0x0000000182BC70A0-0x0000000182BC73F0
		// [XID] // 0x00000001897B97B0-0x00000001897B97D0
		private bool TickFreeInter(List<InterActionGrp> grpList) => default; // 0x0000000182BC6ED0-0x0000000182BC70A0
		// [XID] // 0x00000001897C1810-0x00000001897C1830
		private void DoActionGrp(InterActionGrp grp, ref IInterSystem[] interSystems, ref IInterSystem[] usingSystems) {} // 0x0000000182BBB4E0-0x0000000182BBB680
		// [XID] // 0x00000001897C9220-0x00000001897C9240
		private void DoClearGrp(InterActionGrp grp, ref IInterSystem[] usingSystems) {} // 0x0000000182BBB7E0-0x0000000182BBB8C0
		// [XID] // 0x00000001897D0850-0x00000001897D0870
		private void DoClearGrpOnly(InterActionGrp grp, ref IInterSystem[] usingSystems) {} // 0x0000000182BBB680-0x0000000182BBB7E0
		// [XID] // 0x00000001897D8560-0x00000001897D8580
		private void TickUsingSystem(ref IInterSystem[] usingSystems) {} // 0x0000000182BC7AA0-0x0000000182BC7BB0
		// [XID] // 0x00000001897DF630-0x00000001897DF650
		private void ClearAfterInteractionFinish() {} // 0x0000000182BB52C0-0x0000000182BB5370
		// [XID] // 0x00000001897E6E50-0x00000001897E6E70
		public override void Destroy() {} // 0x0000000182BBAEC0-0x0000000182BBAF80
		// [XID] // 0x00000001897EEB40-0x00000001897EEB60
		public void ClearAliasIntee() {} // 0x0000000182BB5A50-0x0000000182BB5B20
		// [XID] // 0x00000001897F6260-0x00000001897F6280
		public void ClearAll() {} // 0x0000000182BB5BE0-0x0000000182BB5D00
		// [XID] // 0x00000001897FD8C0-0x00000001897FD8E0
		public override void ClearOnDisconnect() {} // 0x0000000182BB6880-0x0000000182BB6960
		// [XID] // 0x000000018971D310-0x000000018971D330
		private void ForceShowNpcSpeechBubble() {} // 0x0000000182BBC1F0-0x0000000182BBC2D0
		// [XID] // 0x000000018981B920-0x000000018981B940
		private void TickSkipTime() {} // 0x0000000182BC79D0-0x0000000182BC7AA0
		// [XID] // 0x0000000189822ED0-0x0000000189822EF0
		private bool IsDialogSelectActionInGrp(InterActionGrp grp) => default; // 0x0000000182BBF8C0-0x0000000182BBF9D0
		// [XID] // 0x000000018982A830-0x000000018982A850
		private string GetFinishStateLog() => default; // 0x0000000182BBDB70-0x0000000182BBDEC0
		[Preserve] // 0x0000000189831C20-0x0000000189831C60
		// [XID] // 0x0000000189831C20-0x0000000189831C60
		public override string Dump(string tag) => default; // 0x0000000182BBBBB0-0x0000000182BBBCB0
		// [XID] // 0x000000018983C3D0-0x000000018983C3F0
		public void ShowCurrentInteractionFinishState() {} // 0x0000000182BC5D10-0x0000000182BC5DE0
		// [IDTag] // 0x0000000189843940-0x0000000189843980
		// [XID] // 0x0000000189843940-0x0000000189843980
		public void RefreshPrePerform(LCBaseInter inter) {} // 0x0000000182BC3670-0x0000000182BC3790
		// [IDTag] // 0x000000018984DEE0-0x000000018984DF20
		// [XID] // 0x000000018984DEE0-0x000000018984DF20
		public void RefreshPrePerform(LCBaseIntee intee) {} // 0x0000000182BC32B0-0x0000000182BC3670
		// [XID] // 0x00000001898581C0-0x00000001898581E0
		public void OnNpcPreTalkPerformExit(LCBaseIntee intee) {} // 0x0000000182BC0660-0x0000000182BC0840
		// [XID] // 0x000000018985F290-0x000000018985F2B0
		private void RemovePreTalkPerform(LCBaseIntee intee, RecycledLinkedList<PreTalkPerformContext> curItr) {} // 0x0000000182BC4090-0x0000000182BC41C0
		// [IDTag] // 0x0000000189866A70-0x0000000189866AB0
		// [XID] // 0x0000000189866A70-0x0000000189866AB0
		private bool TickInter(PreTalkPerformContext context) => default; // 0x0000000182BC73F0-0x0000000182BC7670
		// [XID] // 0x0000000189870EE0-0x0000000189870F00
		private void TickPreTalkPerforms() {} // 0x0000000182BC7670-0x0000000182BC79D0
		// [XID] // 0x0000000189708310-0x0000000189708330
		private void ReleaseTalkPerformContext(PreTalkPerformContext context) {} // 0x0000000182BC39B0-0x0000000182BC3A90
		// [XID] // 0x000000018987FE40-0x000000018987FE60
		private void ResumeGameTime() {} // 0x0000000182BC4A80-0x0000000182BC4BA0
		// [XID] // 0x0000000189887440-0x0000000189887460
		private void ResumeCameraDisplacement() {} // 0x0000000182BC46C0-0x0000000182BC4780
		// [XID] // 0x000000018988E5C0-0x000000018988E5E0
		private void ResumeAudio() {} // 0x0000000182BC4480-0x0000000182BC45A0
		// [XID] // 0x0000000189895C00-0x0000000189895C20
		private void ResumeAvatarVisibleSet() {} // 0x0000000182BC45A0-0x0000000182BC46C0
		// [XID] // 0x0000000189715730-0x0000000189715750
		private void StopAvatarMoveToTask(BaseEntity avatarEntity) {} // 0x0000000182BC64F0-0x0000000182BC65D0
		// [XID] // 0x00000001898A4BC0-0x00000001898A4BE0
		public List<BaseEntity> GetInteeEntityList() => default; // 0x0000000182BBE3B0-0x0000000182BBE590
		// [XID] // 0x00000001898AC080-0x00000001898AC0A0
		private void InitInteeList(bool disableNpcLod) {} // 0x0000000182BBF330-0x0000000182BBF560
		// [XID] // 0x00000001898B37A0-0x00000001898B37C0
		private void DestroyMarkedNPC() {} // 0x0000000182BBABB0-0x0000000182BBAEC0
		// [XID] // 0x00000001898C2820-0x00000001898C2840
		private void SetDefaultAutoTalk() {} // 0x0000000182BC5220-0x0000000182BC5350
		// [XID] // 0x00000001898CA260-0x00000001898CA280
		private void OnAvatarChangeNotify() {} // 0x0000000182BBFEE0-0x0000000182BBFFA0
		// [XID] // 0x00000001898D1990-0x00000001898D19B0
		private void ClearCameraPostEffect() {} // 0x0000000182BB5D00-0x0000000182BB5E10
		// [XID] // 0x00000001898D9190-0x00000001898D91B0
		private void ClearEffect() {} // 0x0000000182BB5E10-0x0000000182BB6070
		// [XID] // 0x00000001898E0E30-0x00000001898E0E50
		public void PlayEffectForInteraction(string effectIndex, BaseEntity owner, string effectName, Vector3? initPos = default, Quaternion? initRot = default, Vector3? initScale = default) {} // 0x0000000182BC1680-0x0000000182BC1950
		// [XID] // 0x00000001898E8920-0x00000001898E8940
		public void RemoveEffectForInteraction(string effectIndex) {} // 0x0000000182BC3A90-0x0000000182BC3CB0
		// [XID] // 0x0000000189AF09A0-0x0000000189AF09C0
		private LCBaseIntee CreateAvatarIntee(LCBaseIntee intee, ConfigInterActor cfgActor) => default; // 0x0000000182BB6E40-0x0000000182BB7490
		// [XID] // 0x00000001898F7910-0x00000001898F7930
		private void ShowAvatarEffect(AvatarEntity avatarEntity, bool isForce = false /* Metadata: 0x00AFE661 */) {} // 0x0000000182BC5A60-0x0000000182BC5D10
		[DebuggerHidden] // 0x00000001898FEFB0-0x00000001898FEFF0
		// [XID] // 0x00000001898FEFB0-0x00000001898FEFF0
		private IEnumerator AvatarTrySitOnChairAfterFrame(BaseEntity entity, int invokeFrames = 2 /* Metadata: 0x00AFE662 */) => default; // 0x0000000182BB3B10-0x0000000182BB3C00
		// [XID] // 0x00000001895FA3A0-0x00000001895FA3C0
		private LCBaseIntee CreateNpcIntee(ConfigInterActor cfgActor) => default; // 0x0000000182BB7E40-0x0000000182BB8B30
		// [XID] // 0x0000000189B26010-0x0000000189B26030
		private void SetNpcIntee(string realAlias, ConfigInterActor cfgActor, LCBaseIntee intee) {} // 0x0000000182BC54E0-0x0000000182BC5A60
		// [XID] // 0x0000000189918A90-0x0000000189918AB0
		private DummyPoint GetDummyPoint(ConfigInterActor cfgActor) => default; // 0x0000000182BBDA80-0x0000000182BBDB70
		// [XID] // 0x0000000189601D00-0x0000000189601D20
		private DummyPoint GetNpcDummyPoint(ConfigInterActor cfgActor, out bool haveNewPos) {
			haveNewPos = default;
			return default;
		} // 0x0000000182BBE7C0-0x0000000182BBEE30
		// [XID] // 0x0000000189BC7DC0-0x0000000189BC7DE0
		private Vector3 GetGroundPos(Vector3 originPos) => default; // 0x0000000182BBDEC0-0x0000000182BBE230
		// [XID] // 0x000000018992F240-0x000000018992F260
		public void RequestTalkFinish(LCBaseIntee intee, uint talkId) {} // 0x0000000182BC4360-0x0000000182BC4480
		// [XID] // 0x0000000189936610-0x0000000189936630
		private bool CheckTalkAuto(ConfigTalkScheme talkConfig) => default; // 0x0000000182BB5140-0x0000000182BB5210
		// [XID] // 0x000000018993E0D0-0x000000018993E0F0
		private bool EnableTalk(LCBaseIntee intee, ConfigTalkScheme talkConfig, bool isChoose = false /* Metadata: 0x00AFE666 */) => default; // 0x0000000182BBBE60-0x0000000182BBBFF0
		// [XID] // 0x00000001899457E0-0x0000000189945800
		public void StartTalk(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint initDialog, bool isChoose, bool insert, uint questMainId = 0 /* Metadata: 0x00AFE667 */, bool async = true /* Metadata: 0x00AFE66B */, bool isCoop = false /* Metadata: 0x00AFE66C */) {} // 0x0000000182BC6250-0x0000000182BC64F0
		// [XID] // 0x000000018994CC30-0x000000018994CC50
		private void StartTalkInternal(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint initDialog, bool isChoose, bool insert, uint questMainId = 0 /* Metadata: 0x00AFE66D */, bool async = true /* Metadata: 0x00AFE671 */, bool isCoop = false /* Metadata: 0x00AFE672 */) {} // 0x0000000182BC5FB0-0x0000000182BC6250
		// [XID] // 0x00000001899543D0-0x00000001899543F0
		public void SelectTalk(LCBaseIntee intee, ConfigTalkScheme talkConfig, bool insert, uint questMainId = 0 /* Metadata: 0x00AFE673 */) {} // 0x0000000182BC50C0-0x0000000182BC5220
		// [XID] // 0x000000018995BD20-0x000000018995BD40
		public void SelectDialog(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint dialogID, bool insert, uint questMainId = 0 /* Metadata: 0x00AFE677 */) {} // 0x0000000182BC4F60-0x0000000182BC50C0
		// [XID] // 0x0000000189963820-0x0000000189963840
		public void SelectDialogTimeOut(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint dialogID, bool insert, uint questMainId = 0 /* Metadata: 0x00AFE67B */) {} // 0x0000000182BC4E00-0x0000000182BC4F60
		// [XID] // 0x0000000189748970-0x0000000189748990
		private void AddKeyInterActionByTalkConfig(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint initDialog, bool isChoose, bool insert, uint questMainId, bool isCoop) {} // 0x0000000182BB2B60-0x0000000182BB2CC0
		// [XID] // 0x0000000189880D90-0x0000000189880DB0
		private void CreateTalkInterAction(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint initDialog, LinkedList<InterActionGrp> actionList, bool isChoose, bool insert, Action createTalkFinishHandler = null, uint questMainId = 0 /* Metadata: 0x00AFE67F */, bool isCoop = false /* Metadata: 0x00AFE683 */) {} // 0x0000000182BBA6F0-0x0000000182BBAA50
		// [XID] // 0x00000001898DA070-0x00000001898DA090
		private void CreateTalkActionByTalkConfig(LCBaseIntee intee, ConfigTalkScheme talkConfig, uint initDialog, LinkedList<InterActionGrp> actionList, bool isChoose, bool insert = false /* Metadata: 0x00AFE684 */, uint questMainId = 0 /* Metadata: 0x00AFE685 */, bool isCoop = false /* Metadata: 0x00AFE689 */) {} // 0x0000000182BBA2D0-0x0000000182BBA6F0
		// [XID] // 0x00000001899817C0-0x00000001899817E0
		private void CreateTalkActionByTalkConfigInternal(ConfigDialogScheme dialogConfig, LCBaseIntee intee, ConfigTalkScheme talkConfig, uint initDialog, LinkedList<InterActionGrp> actionList, bool isChoose, bool insert, uint questMainId, bool isCoop = false /* Metadata: 0x00AFE68A */) {} // 0x0000000182BB9980-0x0000000182BBA2D0
		// [XID] // 0x00000001899890B0-0x00000001899890D0
		private void CreateTalkActionByPerformCfg(LCBaseIntee intee, ConfigTalkScheme talkConfig, LinkedList<InterActionGrp> actionList, bool insert, Action createTalkFinishHandler = null, bool isCoop = false /* Metadata: 0x00AFE68B */) {} // 0x0000000182BB9200-0x0000000182BB9980
		// [XID] // 0x0000000189990870-0x0000000189990890
		private void CreateTalkActionByPerformCfgInternal(LCBaseIntee intee, ConfigInterContainer grpSet, ConfigTalkScheme talkConfig, LinkedList<InterActionGrp> actionList, bool insert, Action createTalkFinishHandler = null, bool isCoop = false /* Metadata: 0x00AFE68C */) {} // 0x0000000182BB8D30-0x0000000182BB9200
		// [XID] // 0x0000000189998390-0x00000001899983B0
		private void OnCreateTalkFinish(ConfigTalkScheme talkConfig) {} // 0x0000000182BBFFA0-0x0000000182BC00F0
		// [XID] // 0x000000018999FB30-0x000000018999FB50
		private BaseEntity SwitchTalkHeroOn(LCBaseIntee intee, ConfigTalkScheme talkConfig) => default; // 0x0000000182BC6AE0-0x0000000182BC6ED0
		// [XID] // 0x00000001899A77E0-0x00000001899A7800
		private void CreateInteeByListAsync(LCBaseIntee intee, ConfigTalkScheme talkConfig, ConfigInterContainer grpSet, Action finishCallback) {} // 0x0000000182BB7490-0x0000000182BB7750
	}
}
