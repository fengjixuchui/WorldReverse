/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B2DD20-0x0000000189B2DD60
	[RecycleType] // 0x0000000189B2DD20-0x0000000189B2DD60
	public sealed class NpcActor : EntityActor, IAutoAllocRecycle // TypeDefIndex: 20221
	{
		// Fields
		private const float MAX_SELFTICK_INTERNAL = 1f; // Metadata: 0x00AFD3C4
		private const float MIN_SELFTICK_INTERNAL = 0.5f; // Metadata: 0x00AFD3C8
		private const float MAX_SELFTICK_FIRST_INTERNAL_OFFSET = 0.07f; // Metadata: 0x00AFD3CC
		private const float MAX_SELFTICK_FIRST_INTERNAL_OFFSET_MAX = 1f; // Metadata: 0x00AFD3D0
		private LCBaseIntee _lcBaseIntee; // 0x128
		private ActorFSMSystem _fsm; // 0x130
		private ActorFSMBlackBoard _blackBoard; // 0x138
		private ActorFSMSchedule _fsmSchedule; // 0x140
		private bool _isInInteraction; // 0x148
		private int _cachedFreeStyle; // 0x14C
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		private List<TitleData> _titleList; // 0x150
		private string _curTitle; // 0x158
		private float _lastInternalTickTime; // 0x160
		private float _nextSelfTickInternal; // 0x164
		private static float _curSelfTickInternal; // 0x00
		private bool _isAppeared; // 0x168
		private bool _isBanEntity; // 0x169
		private float _titleLeftTickTime; // 0x16C
		private const float TICK_TITLE_INTERVAL = 0.5f; // Metadata: 0x00AFD3D4
		private float _talkMarkLeftTickTime; // 0x170
		private const float TICK_TALKMARK_INTERVAL = 0.5f; // Metadata: 0x00AFD3D8
		private bool _isTalkMarkValid; // 0x174
		private uint _talkMarkQuestId; // 0x178
		private static float _disappearNPCRefreshDailyInterval; // 0x04
		private float _nextDisappearRefreshTime; // 0x17C
	
		// Properties
		public bool isAppeared { /* [XID] */ /* 0x000000018987FF60-0x000000018987FF80 */ get => default; } // 0x00000001824BA4D0-0x00000001824BA580 
		public bool isBanEntity { /* [XID] */ /* 0x00000001898874E0-0x0000000189887500 */ get => default; } // 0x00000001824BA580-0x00000001824BA630 
	
		// Constructors
		public NpcActor() {} // 0x00000001824BA410-0x00000001824BA4D0
		static NpcActor() {} // 0x00000001824BA3A0-0x00000001824BA410
	
		// Methods
		[BlackList] // 0x0000000189860CB0-0x0000000189860CF0
		// [XID] // 0x0000000189860CB0-0x0000000189860CF0
		public override void AutoAllocTypeFields() {} // 0x00000001824B24A0-0x00000001824B2580
		[BlackList] // 0x000000018986B500-0x000000018986B540
		// [XID] // 0x000000018986B500-0x000000018986B540
		public override void AutoRecycleTypeFields() {} // 0x00000001824B2580-0x00000001824B26A0
		[BlackList] // 0x0000000189875880-0x00000001898758C0
		// [XID] // 0x0000000189875880-0x00000001898758C0
		public override void ReturnToObjectPool() {} // 0x00000001824B7260-0x00000001824B7300
		// [XID] // 0x000000018988E760-0x000000018988E780
		protected override void InitWithEntity() {} // 0x00000001824B4B00-0x00000001824B4C60
		[BlackList] // 0x0000000189895CC0-0x0000000189895D00
		// [XID] // 0x0000000189895CC0-0x0000000189895D00
		public override void TryClearOnSwitch() {} // 0x00000001824B81B0-0x00000001824B8280
		// [XID] // 0x00000001898A0170-0x00000001898A0190
		private List<List<ConfigBaseInterAction>> GetInterCfgGrp(LuaTable luaTable) => default; // 0x00000001824B4150-0x00000001824B4360
		// [XID] // 0x00000001898A7950-0x00000001898A7970
		public void AddPriorityInter(InterTimingType timingType, LuaTable luaTable) {} // 0x00000001824B1F30-0x00000001824B20B0
		// [XID] // 0x00000001898AF3F0-0x00000001898AF410
		public void ClearPriorityInter(InterTimingType timingType) {} // 0x00000001824B2E60-0x00000001824B2F80
		// [XID] // 0x00000001898B6870-0x00000001898B6890
		public void CallOnCollisionEnter(Action<ILuaActor, ILuaActorCollisionInfo> enterHandler) {} // 0x00000001824B26A0-0x00000001824B2800
		// [XID] // 0x00000001898BE060-0x00000001898BE080
		public void ClearOnCollisionEnter(Action<ILuaActor, ILuaActorCollisionInfo> enterHandler) {} // 0x00000001824B2D70-0x00000001824B2E60
		// [XID] // 0x00000001898C5910-0x00000001898C5930
		private void SyncMetaPos() {} // 0x00000001824B78F0-0x00000001824B7B60
		// [XID] // 0x00000001898CD040-0x00000001898CD060
		public override void SyncPos(int state) {} // 0x00000001824B7B60-0x00000001824B7C20
		// [XID] // 0x00000001898D49B0-0x00000001898D49D0
		public override void TurnTo(Vector3 dir) {} // 0x00000001824B8280-0x00000001824B8360
		[BlackList] // 0x00000001898DC350-0x00000001898DC390
		// [XID] // 0x00000001898DC350-0x00000001898DC390
		public override void CheckShowInternal() {} // 0x00000001824B28F0-0x00000001824B29B0
		// [XID] // 0x00000001898E7230-0x00000001898E7250
		public override void Hide(bool value, bool needCache = false /* Metadata: 0x00AFD3C2 */) {} // 0x00000001824B4970-0x00000001824B4B00
		// [XID] // 0x00000001898EEA60-0x00000001898EEA80
		public override void HideInternal(bool value) {} // 0x00000001824B4780-0x00000001824B4970
		// [XID] // 0x00000001898F6220-0x00000001898F6240
		public void CheckNpcTalk() {} // 0x00000001824B2800-0x00000001824B28F0
		// [XID] // 0x00000001898FDAA0-0x00000001898FDAC0
		public void EnableHeadCtrl(bool value) {} // 0x00000001824B3D70-0x00000001824B3E60
		// [XID] // 0x0000000189905280-0x00000001899052A0
		public void LookAt(Vector3 pos) {} // 0x00000001824B4ED0-0x00000001824B4FC0
		// [XID] // 0x000000018990CAF0-0x000000018990CB10
		public void ClearLookAt() {} // 0x00000001824B2CC0-0x00000001824B2D70
		// [XID] // 0x0000000189914280-0x00000001899142A0
		public void DisableInteeHeadCtrl(bool isDisable) {} // 0x00000001824B35C0-0x00000001824B3680
		// [XID] // 0x000000018991BD80-0x000000018991BDA0
		public Vector3 GetLookAtViewPoint(Vector3 dir) => default; // 0x00000001824B4360-0x00000001824B44D0
		// [XID] // 0x00000001899233A0-0x00000001899233C0
		public bool ControlHeadEnabled() => default; // 0x00000001824B3240-0x00000001824B3300
		// [XID] // 0x000000018992AB60-0x000000018992AB80
		public void AddGeneralMark(string iconName) {} // 0x00000001824B1E70-0x00000001824B1F30
		// [XID] // 0x0000000189932140-0x0000000189932160
		public void ClearGeneralMark() {} // 0x00000001824B2C10-0x00000001824B2CC0
		// [XID] // 0x0000000189939B50-0x0000000189939B70
		public override void ClearCmd() {} // 0x00000001824B29B0-0x00000001824B2AC0
		// [XID] // 0x0000000189940D60-0x0000000189940D80
		public override void Destroy(bool isActorOnly) {} // 0x00000001824B34A0-0x00000001824B35C0
		// [XID] // 0x0000000189948720-0x0000000189948740
		public override void OnBeforePoolRecycled() {} // 0x00000001824B5850-0x00000001824B5950
		// [XID] // 0x000000018994FE70-0x000000018994FE90
		protected override void DestroyEntity() {} // 0x00000001824B3300-0x00000001824B34A0
		// [XID] // 0x0000000189957420-0x0000000189957440
		public uint GetNpcConfigId() => default; // 0x00000001824B45D0-0x00000001824B46D0
		// [XID] // 0x000000018995EEF0-0x000000018995EF10
		public string GetNpcAlias() => default; // 0x00000001824B44D0-0x00000001824B45D0
		// [XID] // 0x0000000189966750-0x0000000189966770
		private float GetFirstPauseTickInterval() => default; // 0x00000001824B3FF0-0x00000001824B4150
		// [XID] // 0x000000018996DB10-0x000000018996DB30
		public override void Tick() {} // 0x00000001824B7C20-0x00000001824B7F50
		// [XID] // 0x0000000189975710-0x0000000189975730
		public override void AddDailyConfigData(ILuaActorDailyConfigData data) {} // 0x00000001824B1DB0-0x00000001824B1E70
		// [XID] // 0x000000018997C8B0-0x000000018997C8D0
		public void SetIsDaily(bool isDaily) {} // 0x00000001824B75D0-0x00000001824B76B0
		// [XID] // 0x0000000189984610-0x0000000189984630
		public void OnDataInited() {} // 0x00000001824B5A60-0x00000001824B5B10
		// [XID] // 0x000000018998C050-0x000000018998C070
		public override void SetActionPointWeight(int actionPointType, float weight) {} // 0x00000001824B7300-0x00000001824B73E0
		// [XID] // 0x0000000189993D70-0x0000000189993D90
		public override void StartDailyFSM() {} // 0x00000001824B7830-0x00000001824B78F0
		// [XID] // 0x000000018999B5C0-0x000000018999B5E0
		public override void ForceRefreshDaily() {} // 0x00000001824B3E60-0x00000001824B3F20
		// [XID] // 0x00000001899A2D10-0x00000001899A2D30
		public override void SetEntityBan(bool isBan) {} // 0x00000001824B7510-0x00000001824B75D0
		// [XID] // 0x00000001899AA7C0-0x00000001899AA7E0
		public void ResetAsNoDaily() {} // 0x00000001824B70B0-0x00000001824B7260
		[BlackList] // 0x00000001899B2140-0x00000001899B2180
		// [XID] // 0x00000001899B2140-0x00000001899B2180
		public void SetTransition(ActorFSMTransition t) {} // 0x00000001824B76B0-0x00000001824B7830
		// [XID] // 0x00000001899BC710-0x00000001899BC730
		private void MakeFSM() {} // 0x00000001824B4FC0-0x00000001824B5570
		// [XID] // 0x00000001899C4080-0x00000001899C40A0
		private void ClearFSM() {} // 0x00000001824B2AC0-0x00000001824B2C10
		// [XID] // 0x00000001899CB850-0x00000001899CB870
		public bool IsFSMValid() => default; // 0x00000001824B4C60-0x00000001824B4D20
		// [XID] // 0x00000001899D2CF0-0x00000001899D2D10
		private void UpdateFSM(float internalDeltaTime, float realDeltaTime) {} // 0x00000001824B9EA0-0x00000001824BA0F0
		[BlackList] // 0x00000001899DA280-0x00000001899DA2C0
		// [XID] // 0x00000001899DA280-0x00000001899DA2C0
		public override void OnAppear() {} // 0x00000001824B5570-0x00000001824B5670
		[BlackList] // 0x00000001899E4DE0-0x00000001899E4E20
		// [XID] // 0x00000001899E4DE0-0x00000001899E4E20
		public override void OnDisappear() {} // 0x00000001824B5B10-0x00000001824B5CC0
		// [XID] // 0x00000001899EF1A0-0x00000001899EF1C0
		protected override void OnSelfDayTime() {} // 0x00000001824B6660-0x00000001824B6810
		// [XID] // 0x00000001899F6B50-0x00000001899F6B70
		protected override void OnSelfNightTime() {} // 0x00000001824B68F0-0x00000001824B6AA0
		// [XID] // 0x00000001899FE190-0x00000001899FE1B0
		protected override void OnSelfHour(int hour) {} // 0x00000001824B6810-0x00000001824B68F0
		// [XID] // 0x0000000189A05AF0-0x0000000189A05B10
		protected override void OnSelfWeatherChange(EnviroWeatherPreset weatherType) {} // 0x00000001824B6AA0-0x00000001824B6BC0
		[BlackList] // 0x0000000189A0CDA0-0x0000000189A0CDE0
		// [XID] // 0x0000000189A0CDA0-0x0000000189A0CDE0
		public override bool OnEntityEventTrigger(BaseEvent e) => default; // 0x00000001824B5CC0-0x00000001824B5E90
		[BlackList] // 0x0000000189A17170-0x0000000189A171B0
		// [XID] // 0x0000000189A17170-0x0000000189A171B0
		public override void OnScriptNotifyTrigger(int param) {} // 0x00000001824B6310-0x00000001824B6410
		// [XID] // 0x0000000189A21790-0x0000000189A217B0
		private void OnBHVChange() {} // 0x00000001824B5670-0x00000001824B5850
		// [XID] // 0x0000000189A28D10-0x0000000189A28D30
		private void TriggerReaction(ActorFSMReactionType reactionType, int freestyle, BaseEntity target) {} // 0x00000001824B8050-0x00000001824B81B0
		// [XID] // 0x0000000189A30370-0x0000000189A30390
		private bool IsInState(ActorFSMStateID stateID) => default; // 0x00000001824B4D20-0x00000001824B4E00
		[BlackList] // 0x0000000189A37DD0-0x0000000189A37E10
		// [XID] // 0x0000000189A37DD0-0x0000000189A37E10
		public override void OnResetFreeStyleTrigger() {} // 0x00000001824B6230-0x00000001824B6310
		[BlackList] // 0x0000000189A423D0-0x0000000189A42410
		// [XID] // 0x0000000189A423D0-0x0000000189A42410
		public override void OnCollisionEnterTrigger(BaseEntity collider, ActorCollisionInfo colInfo) {} // 0x00000001824B5950-0x00000001824B5A60
		[BlackList] // 0x0000000189A4CA80-0x0000000189A4CAC0
		// [XID] // 0x0000000189A4CA80-0x0000000189A4CAC0
		public override void OnStartInteractionTrigger(bool stayFreeStyle) {} // 0x00000001824B6BC0-0x00000001824B6D20
		[BlackList] // 0x0000000189A57130-0x0000000189A57170
		// [XID] // 0x0000000189A57130-0x0000000189A57170
		public override void OnStopInteractionTrigger(bool rewindFreeStyle = false /* Metadata: 0x00AFD3C3 */) {} // 0x00000001824B6D20-0x00000001824B6FA0
		[BlackList] // 0x0000000189A61AB0-0x0000000189A61AF0
		// [XID] // 0x0000000189A61AB0-0x0000000189A61AF0
		public void TransitToLastState() {} // 0x00000001824B7F50-0x00000001824B8050
		// [XID] // 0x0000000189A6C4C0-0x0000000189A6C4E0
		private void UpdateRouteToTarget() {} // 0x00000001824BA1E0-0x00000001824BA2C0
		[BlackList] // 0x0000000189A73C30-0x0000000189A73C70
		// [XID] // 0x0000000189A73C30-0x0000000189A73C70
		public override void OnScriptSitOnChair(int freeStyleType) {} // 0x00000001824B6410-0x00000001824B6510
		[BlackList] // 0x0000000189A7E620-0x0000000189A7E660
		// [XID] // 0x0000000189A7E620-0x0000000189A7E660
		public override void OnScriptStandFromChair(float? standAngle = default) {} // 0x00000001824B6510-0x00000001824B6660
		[BlackList] // 0x0000000189A89190-0x0000000189A891D0
		// [XID] // 0x0000000189A89190-0x0000000189A891D0
		public override bool IsSitting() => default; // 0x00000001824B4E00-0x00000001824B4ED0
		[BlackList] // 0x0000000189A935D0-0x0000000189A93610
		// [XID] // 0x0000000189A935D0-0x0000000189A93610
		public void OnFinalPointArrived() {} // 0x00000001824B5FC0-0x00000001824B6080
		[BlackList] // 0x0000000189A9DBD0-0x0000000189A9DC10
		// [XID] // 0x0000000189A9DBD0-0x0000000189A9DC10
		public bool OnPerformStateFinished() => default; // 0x00000001824B6160-0x00000001824B6230
		[BlackList] // 0x0000000189AA8140-0x0000000189AA8180
		// [XID] // 0x0000000189AA8140-0x0000000189AA8180
		public override LevelActionPoint GetCurrentActionPoint() => default; // 0x00000001824B3F20-0x00000001824B3FF0
		[BlackList] // 0x0000000189AB2D00-0x0000000189AB2D40
		// [XID] // 0x0000000189AB2D00-0x0000000189AB2D40
		public override void OverrideTargetFreestyle(int freestyle, bool doRefresh) {} // 0x00000001824B6FA0-0x00000001824B70B0
		[BlackList] // 0x0000000189ABD810-0x0000000189ABD850
		// [XID] // 0x0000000189ABD810-0x0000000189ABD850
		public void OnEntityRuntimeIdChanged(uint oldRuntimeId, uint newRuntimeId) {} // 0x00000001824B5E90-0x00000001824B5FC0
		// [XID] // 0x0000000189AC8110-0x0000000189AC8130
		public override void AddTitleConfigData(ILuaActorTitleConfigData data) {} // 0x00000001824B20B0-0x00000001824B24A0
		// [XID] // 0x0000000189ACF810-0x0000000189ACF830
		private void UpdateTitle(float deltaTime) {} // 0x00000001824BA2C0-0x00000001824BA3A0
		// [XID] // 0x0000000189AD75A0-0x0000000189AD75C0
		private static int CompareTitle(TitleData title1, TitleData title2) => default; // 0x00000001824B3170-0x00000001824B3240
		// [XID] // 0x0000000189ADEFF0-0x0000000189ADF010
		private static int CompareCond(TitleConditionList cond1, TitleConditionList cond2) => default; // 0x00000001824B30A0-0x00000001824B3170
		// [XID] // 0x0000000189AE68E0-0x0000000189AE6900
		private void UpdateCurTitle() {} // 0x00000001824B9B80-0x00000001824B9EA0
		// [XID] // 0x0000000189AEE2C0-0x0000000189AEE2E0
		public void SetCurTitle(string title) {} // 0x00000001824B73E0-0x00000001824B7510
		// [XID] // 0x0000000189AF5930-0x0000000189AF5950
		public override string GetTitle() => default; // 0x00000001824B46D0-0x00000001824B4780
		// [XID] // 0x0000000189AFCD90-0x0000000189AFCDB0
		public bool OnNotify(Notify ntf) => default; // 0x00000001824B6080-0x00000001824B6160
		// [XID] // 0x0000000189B04520-0x0000000189B04540
		public void UpdatePreTalkPerform(float deltaTime) {} // 0x00000001824BA0F0-0x00000001824BA1E0
		// [XID] // 0x0000000189B0BDB0-0x0000000189B0BDD0
		public void UpdateCurTalkMark() {} // 0x00000001824B9770-0x00000001824B9B80
		// [XID] // 0x0000000189B133E0-0x0000000189B13400
		private void ClearTalkMark() {} // 0x00000001824B2F80-0x00000001824B30A0
		[Preserve] // 0x0000000189B1AB60-0x0000000189B1ABA0
		// [XID] // 0x0000000189B1AB60-0x0000000189B1ABA0
		public string Dump(string tag) => default; // 0x00000001824B3680-0x00000001824B3D70
		// [XID] // 0x0000000189B25180-0x0000000189B251A0
		private void UpdateBasicDailyActions(float deltaTime) {} // 0x00000001824B9480-0x00000001824B9770
	}
}
