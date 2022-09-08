/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B53370-0x0000000189B533A0
	public static class ActorUtils // TypeDefIndex: 21050
	{
		// Fields
		private static uint _taskUniqId; // 0x00
		private static Vector3 _cameraPos; // 0x04
		private static Vector3 _cameraEuler; // 0x10
		private static Vector3 _avatarPos; // 0x1C
		private static Action _avatarSitHandler; // 0x28
		private static Action _avatarStandHandler; // 0x30
		private static Action _elemViewOpenHandler; // 0x38
		private static Action _elemViewCloseHandler; // 0x40
		private const int MAX_DATA_TASK = 200; // Metadata: 0x00AFED65
		private static PrepareDataTask[] _dataTasks; // 0x48
		private static StringBuilder stringBuilder; // 0x50
		private const string prePath = "Lua/"; // Metadata: 0x00AFED69
		private const string postPath = ".lua"; // Metadata: 0x00AFED71
	
		// Properties
		private static WorldInfoManager infoMgr { /* [XID] */ /* 0x000000018994C4A0-0x000000018994C4C0 */ get; } // 0x0000000181A57530-0x0000000181A575F0 
	
		// Nested types
		[BlackList] // 0x0000000189811090-0x00000001898110A0
		public class PrepareDataTask : ISimplePoolObject // TypeDefIndex: 21051
		{
			// Fields
			private static int _currTaskId; // 0x00
			private static SimpleObjectPool<PrepareDataTask> _pool; // 0x08
			private int _taskId; // 0x10
			private float _cnt; // 0x14
			private Action<ILuaActor> _callback; // 0x18
			private ILuaActor _actor; // 0x20
			private Action<QuestModule.QuestUpdateRequest> _questCallback; // 0x28
			private QuestModule.QuestUpdateRequest _questRequest; // 0x30
			private IndexBinDataReceiver.IndexResultHandler _onLoadResult; // 0x38
			private AssetJobPriority _loadPrioriy; // 0x40
			private List<string> _paths; // 0x48
	
			// Properties
			public static int currTaskId { /* [XID] */ /* 0x0000000189A0E630-0x0000000189A0E650 */ get => default; } // 0x0000000184E92F80-0x0000000184E93090 
			public int taskId { /* [XID] */ /* 0x0000000189A39390-0x0000000189A393B0 */ get => default; } // 0x0000000184E93090-0x0000000184E93130 
	
			// Constructors
			public PrepareDataTask() {} // 0x0000000184E92EC0-0x0000000184E92F80
			static PrepareDataTask() {} // 0x0000000184E92E30-0x0000000184E92EC0
	
			// Methods
			// [IDTag] // 0x0000000189A15C60-0x0000000189A15CA0
			// [XID] // 0x0000000189A15C60-0x0000000189A15CA0
			public static PrepareDataTask Get(int taskId, Action<ILuaActor> callback, ILuaActor actor) => default; // 0x0000000184E924B0-0x0000000184E925F0
			// [IDTag] // 0x0000000189A200B0-0x0000000189A200F0
			// [XID] // 0x0000000189A200B0-0x0000000189A200F0
			public static PrepareDataTask Get(int taskId, Action<QuestModule.QuestUpdateRequest> questCallback, QuestModule.QuestUpdateRequest request) => default; // 0x0000000184E925F0-0x0000000184E92730
			// [XID] // 0x0000000189A2A3E0-0x0000000189A2A400
			public static void Release(PrepareDataTask task) {} // 0x0000000184E928F0-0x0000000184E929E0
			// [XID] // 0x0000000189A31850-0x0000000189A31870
			public void ResetObject() {} // 0x0000000184E929E0-0x0000000184E92AB0
			// [XID] // 0x0000000189A40B30-0x0000000189A40B50
			public void AddPath(string path) {} // 0x0000000184E922C0-0x0000000184E92390
			// [IDTag] // 0x0000000189A481D0-0x0000000189A48210
			// [XID] // 0x0000000189A481D0-0x0000000189A48210
			public void Init(int taskId, Action<ILuaActor> callback, ILuaActor actor) {} // 0x0000000184E92730-0x0000000184E92810
			// [IDTag] // 0x0000000189A52860-0x0000000189A528A0
			// [XID] // 0x0000000189A52860-0x0000000189A528A0
			public void Init(int taskId, Action<QuestModule.QuestUpdateRequest> questCallback, QuestModule.QuestUpdateRequest request) {} // 0x0000000184E92810-0x0000000184E928F0
			// [XID] // 0x0000000189A5D2A0-0x0000000189A5D2C0
			public void SetPrepare() {} // 0x0000000184E92AB0-0x0000000184E92B60
			// [XID] // 0x0000000189A64C00-0x0000000189A64C20
			public void Start(IndexBinDataReceiver.IndexResultHandler onLoadResult, AssetJobPriority loadPrioriy) {} // 0x0000000184E92D60-0x0000000184E92E30
			// [XID] // 0x0000000189A6C400-0x0000000189A6C420
			private void StartPathLoad() {} // 0x0000000184E92B60-0x0000000184E92D60
			// [XID] // 0x0000000189A73BB0-0x0000000189A73BD0
			public bool FinishPrepare() => default; // 0x0000000184E92390-0x0000000184E924B0
		}
	
		// Constructors
		static ActorUtils() {} // 0x0000000181A57380-0x0000000181A57530
	
		// Methods
		[BlackList] // 0x000000018960E5A0-0x000000018960E5E0
		// [XID] // 0x000000018960E5A0-0x000000018960E5E0
		public static void AddCacheCmd(string alias, BaseCommand cmd) {} // 0x0000000181A4A610-0x0000000181A4A710
		[BlackList] // 0x0000000189618FA0-0x0000000189618FE0
		// [XID] // 0x0000000189618FA0-0x0000000189618FE0
		public static void ClearCacheCmd(string alias, ActorCommandType cmdType) {} // 0x0000000181A4C4C0-0x0000000181A4C5C0
		// [XID] // 0x0000000189623220-0x0000000189623240
		public static void ClearCacheCmdExternal(string alias, int cmdType) {} // 0x0000000181A4C3C0-0x0000000181A4C4C0
		// [XID] // 0x000000018962AA40-0x000000018962AA60
		public static void ClearCacheCmdAll(string alias) {} // 0x0000000181A4C2D0-0x0000000181A4C3C0
		// [XID] // 0x0000000189632180-0x00000001896321A0
		public static void DoFreeStyle(string alias, int freeStyleType, bool forceInterrupt, float? freeStyleParam = default, bool resetRoute = true /* Metadata: 0x00AFED5C */) {} // 0x0000000181A4E030-0x0000000181A4E160
		// [XID] // 0x0000000189639C30-0x0000000189639C50
		public static void DoLookAt(string alias, Vector3 pos) {} // 0x0000000181A4E280-0x0000000181A4E390
		// [XID] // 0x0000000189641160-0x0000000189641180
		public static void DoSitOnChair(string alias, int freeStyleType) {} // 0x0000000181A4E560-0x0000000181A4E660
		// [XID] // 0x0000000189648AA0-0x0000000189648AC0
		public static void DoSetWalkSpeedRatio(string alias, float speedRatio) {} // 0x0000000181A4E460-0x0000000181A4E560
		// [XID] // 0x0000000189650140-0x0000000189650160
		public static void DoResetWalkSpeedRatio(string alias) {} // 0x0000000181A4E390-0x0000000181A4E460
		// [XID] // 0x0000000189657A30-0x0000000189657A50
		public static void DoStartCall(string alias, Action<ILuaActor> call) {} // 0x0000000181A4E660-0x0000000181A4E740
		// [XID] // 0x000000018965F120-0x000000018965F140
		public static void DoAddGeneralMark(string alias, string iconName) {} // 0x0000000181A4DE80-0x0000000181A4DF60
		// [XID] // 0x0000000189666910-0x0000000189666930
		public static void DoClearGeneralMark(string alias) {} // 0x0000000181A4DF60-0x0000000181A4E030
		// [XID] // 0x000000018966E010-0x000000018966E030
		public static void DestroyLocalGadget(string alias) {} // 0x0000000181A4DCB0-0x0000000181A4DD90
		// [XID] // 0x0000000189675E80-0x0000000189675EA0
		public static void DoHide(string alias, bool hide) {} // 0x0000000181A4E160-0x0000000181A4E280
		// [XID] // 0x000000018967D720-0x000000018967D740
		public static void DisableInteeHeadCtrl(string alias, bool isDisable) {} // 0x0000000181A4DD90-0x0000000181A4DE80
		// [XID] // 0x0000000189684D40-0x0000000189684D60
		public static uint GenNextTaskUniqId() => default; // 0x0000000181A4F780-0x0000000181A4F8B0
		[BlackList] // 0x000000018968C840-0x000000018968C880
		// [XID] // 0x000000018968C840-0x000000018968C880
		public static void Clear() {} // 0x0000000181A4C5C0-0x0000000181A4C6C0
		[BlackList] // 0x0000000189697560-0x00000001896975A0
		// [XID] // 0x0000000189697560-0x00000001896975A0
		public static void RefreshGlobalHandler() {} // 0x0000000181A53D90-0x0000000181A53E50
		// [XID] // 0x00000001896A1940-0x00000001896A1960
		public static void ShowMessageByTextMap(string mapID) {} // 0x0000000181A54F50-0x0000000181A55030
		// [XID] // 0x00000001896A8E20-0x00000001896A8E40
		public static void ShowTextMapWithParam(string mapID, string[] param) {} // 0x0000000181A55400-0x0000000181A55540
		// [XID] // 0x00000001896AFED0-0x00000001896AFEF0
		public static void ShowMessage(string content) {} // 0x0000000181A55030-0x0000000181A550F0
		// [XID] // 0x00000001896B7820-0x00000001896B7840
		public static void UnrequireLua(string luaPath) {} // 0x0000000181A56FF0-0x0000000181A57100
		[BlackList] // 0x00000001896BE990-0x00000001896BE9D0
		// [XID] // 0x00000001896BE990-0x00000001896BE9D0
		public static AvatarEntity GetAvatarEntity(uint cfgId) => default; // 0x0000000181A4FEB0-0x0000000181A500E0
		[BlackList] // 0x00000001896C8E20-0x00000001896C8E60
		// [XID] // 0x00000001896C8E20-0x00000001896C8E60
		public static void SpawnAttach(string attachName, uint cfgId) {} // 0x0000000181A55660-0x0000000181A557C0
		[BlackList] // 0x00000001896D31E0-0x00000001896D3220
		// [XID] // 0x00000001896D31E0-0x00000001896D3220
		public static void UnspawnAttach(string attachName, uint cfgId) {} // 0x0000000181A57220-0x0000000181A57380
		[BlackList] // 0x00000001896DDB80-0x00000001896DDBC0
		// [XID] // 0x00000001896DDB80-0x00000001896DDBC0
		public static void SpawnAttachHeroEntity(string attachName, uint cfgId) {} // 0x0000000181A55540-0x0000000181A55660
		[BlackList] // 0x00000001896E7F80-0x00000001896E7FC0
		// [XID] // 0x00000001896E7F80-0x00000001896E7FC0
		public static void UnspawnAttachHeroEntity(string attachName, uint cfgId) {} // 0x0000000181A57100-0x0000000181A57220
		// [XID] // 0x00000001896F2370-0x00000001896F2390
		public static Vector3 GetCameraPos() => default; // 0x0000000181A50630-0x0000000181A50810
		// [XID] // 0x00000001896F9CF0-0x00000001896F9D10
		public static Vector3 GetCameraEuler() => default; // 0x0000000181A50450-0x0000000181A50630
		// [XID] // 0x00000001897014C0-0x00000001897014E0
		public static Vector3 GetAvatarPos() => default; // 0x0000000181A50250-0x0000000181A50450
		// [XID] // 0x0000000189708CC0-0x0000000189708CE0
		public static void AvatarGotoPoint(Vector3 pos, Action callback, Action<float> updateCB = null) {} // 0x0000000181A4A710-0x0000000181A4A8A0
		// [XID] // 0x0000000189710560-0x0000000189710580
		public static void AvatarMoveTo(Vector3 pos, float len, bool changeMoveState, bool isWalk) {} // 0x0000000181A4A8A0-0x0000000181A4AA50
		// [XID] // 0x00000001898B9320-0x00000001898B9340
		public static LCTempController GetAndCreateTempControl(BaseEntity avatarEntity) => default; // 0x0000000181A4F8B0-0x0000000181A4F9B0
		// [XID] // 0x000000018971F3F0-0x000000018971F410
		public static void RemoveTempControl(BaseEntity avatarEntity) {} // 0x0000000181A53E50-0x0000000181A53F00
		// [XID] // 0x00000001897269E0-0x0000000189726A00
		public static Vector3 GetAvatarForward() => default; // 0x0000000181A500E0-0x0000000181A50250
		// [XID] // 0x000000018972DF50-0x000000018972DF70
		public static void SetAvatarPos(Vector3 pos) {} // 0x0000000181A54180-0x0000000181A542D0
		// [XID] // 0x00000001897355F0-0x0000000189735610
		public static void SetAvatarEuler(Vector3 eular) {} // 0x0000000181A54040-0x0000000181A54180
		// [XID] // 0x000000018973D1D0-0x000000018973D1F0
		public static void SyncAvatarMotion(int state) {} // 0x0000000181A558B0-0x0000000181A55A00
		// [XID] // 0x00000001897446B0-0x00000001897446D0
		public static void TriggerAvatarAbility(string name) {} // 0x0000000181A55E70-0x0000000181A55FC0
		// [XID] // 0x000000018974C370-0x000000018974C390
		private static void AvatarSitHandler() {} // 0x0000000181A4AA50-0x0000000181A4ACA0
		// [XID] // 0x0000000189753620-0x0000000189753640
		public static void CallOnAvatarSit(Action sitDownHandler) {} // 0x0000000181A4B330-0x0000000181A4B550
		// [XID] // 0x000000018975AB20-0x000000018975AB40
		public static void UncallOnAvatarSit(Action sitDownHandler) {} // 0x0000000181A56690-0x0000000181A56860
		[BlackList] // 0x0000000189762630-0x0000000189762670
		// [XID] // 0x0000000189762630-0x0000000189762670
		private static void CallOnAvatarSitInternal(Action onSitDown) {} // 0x0000000181A4B110-0x0000000181A4B330
		[BlackList] // 0x000000018976CCA0-0x000000018976CCE0
		// [XID] // 0x000000018976CCA0-0x000000018976CCE0
		private static void UncallOnAvatarSitInternal(Action onSitDown) {} // 0x0000000181A56540-0x0000000181A56690
		// [XID] // 0x0000000189777270-0x0000000189777290
		private static void AvatarStandHandler() {} // 0x0000000181A4ACA0-0x0000000181A4AEF0
		// [XID] // 0x000000018977E9C0-0x000000018977E9E0
		public static void CallOnAvatarStand(Action standUpHandler) {} // 0x0000000181A4B6F0-0x0000000181A4B910
		// [XID] // 0x0000000189786140-0x0000000189786160
		public static void UncallOnAvatarStand(Action standUpHandler) {} // 0x0000000181A569B0-0x0000000181A56B80
		[BlackList] // 0x000000018978D7B0-0x000000018978D7F0
		// [XID] // 0x000000018978D7B0-0x000000018978D7F0
		private static void CallOnAvatarStandInternal(Action onStandUp) {} // 0x0000000181A4B550-0x0000000181A4B6F0
		[BlackList] // 0x00000001897980C0-0x0000000189798100
		// [XID] // 0x00000001897980C0-0x0000000189798100
		private static void UncallOnAvatarStandInternal(Action onStandUp) {} // 0x0000000181A56860-0x0000000181A569B0
		[BlackList] // 0x00000001897A2CC0-0x00000001897A2D00
		// [XID] // 0x00000001897A2CC0-0x00000001897A2D00
		private static void RefreshAvatarSitStandHandler() {} // 0x0000000181A53850-0x0000000181A53AF0
		[BlackList] // 0x00000001897AD4F0-0x00000001897AD530
		// [XID] // 0x00000001897AD4F0-0x00000001897AD530
		public static void OnAvatarChange(uint oldEntityId) {} // 0x0000000181A52530-0x0000000181A528D0
		// [XID] // 0x00000001897B8320-0x00000001897B8340
		public static void CallOnElemViewOpen(Action elemViewOpenHandler) {} // 0x0000000181A4C010-0x0000000181A4C240
		// [XID] // 0x00000001897C03C0-0x00000001897C03E0
		public static void UncallOnElemViewOpen(Action elemViewOpenHandler) {} // 0x0000000181A56E20-0x0000000181A56FF0
		// [XID] // 0x00000001897C7C10-0x00000001897C7C30
		private static void ElemViewOpenHandler() {} // 0x0000000181A4E9A0-0x0000000181A4EC00
		// [XID] // 0x00000001897CEEC0-0x00000001897CEEE0
		private static void CallOnElemViewOpenInternal(Action onElemViewOpen) {} // 0x0000000181A4BDF0-0x0000000181A4C010
		// [XID] // 0x00000001897D6680-0x00000001897D66A0
		private static void UncallElemViewOpenInternal(Action onElemViewOpen) {} // 0x0000000181A563D0-0x0000000181A56540
		// [XID] // 0x00000001897DDE50-0x00000001897DDE70
		public static void CallOnElemViewClose(Action elemViewCloseHandler) {} // 0x0000000181A4BBC0-0x0000000181A4BDF0
		// [XID] // 0x00000001897E5900-0x00000001897E5920
		public static void UncallOnElemViewClose(Action elemViewCloseHandler) {} // 0x0000000181A56C50-0x0000000181A56E20
		// [XID] // 0x00000001897ED3F0-0x00000001897ED410
		private static void ElemViewCloseHandler() {} // 0x0000000181A4E740-0x0000000181A4E9A0
		// [XID] // 0x00000001897F4B30-0x00000001897F4B50
		private static void CallOnElemViewCloseInternal(Action onElemViewClose) {} // 0x0000000181A4B9E0-0x0000000181A4BBC0
		// [XID] // 0x00000001897FC620-0x00000001897FC640
		private static void UncallElemViewCloseInternal(Action onElemViewClose) {} // 0x0000000181A56260-0x0000000181A563D0
		// [XID] // 0x0000000189803BD0-0x0000000189803BF0
		private static void RefreshElemViewHandler() {} // 0x0000000181A53AF0-0x0000000181A53D90
		// [XID] // 0x000000018980B050-0x000000018980B070
		public static void CallOnDoorOpen(Action<uint, uint> doorOpenHandler) {} // 0x0000000181A4B910-0x0000000181A4B9E0
		// [XID] // 0x00000001898126A0-0x00000001898126C0
		public static void UncallOnDoorOpen() {} // 0x0000000181A56B80-0x0000000181A56C50
		// [XID] // 0x000000018981A300-0x000000018981A320
		public static void SyncEntityPos(BaseEntity entity, int state) {} // 0x0000000181A55A00-0x0000000181A55E70
		// [XID] // 0x00000001898219F0-0x0000000189821A10
		public static void FireEvent(ActorEvtTargetType targetType, string alias, int evtType, object[] evtParams, bool canRecover) {} // 0x0000000181A4F150-0x0000000181A4F2D0
		// [XID] // 0x0000000189828FA0-0x0000000189828FC0
		public static void FireEventWithSource(ActorEvtTargetType targetType, string alias, int evtType, object[] evtParams, bool canRecover, int sourceType, uint sourceId) {} // 0x0000000181A4EED0-0x0000000181A4F150
		[BlackList] // 0x00000001898304B0-0x00000001898304F0
		// [XID] // 0x00000001898304B0-0x00000001898304F0
		public static void FireEventWithSourceInternal(ActorEvtTargetType targetType, string alias, int evtType, object[] evtParams, bool canRecover, int sourceType, uint sourceId) {} // 0x0000000181A4ED20-0x0000000181A4EED0
		// [XID] // 0x0000000189ADB2B0-0x0000000189ADB2D0
		public static void FireLightEventWithSource(ActorEvtTargetType targetType, string alias, int evtType, object[] evtParams, bool canRecover, int sourceType, uint sourceId) {} // 0x0000000181A4F2D0-0x0000000181A4F5B0
		// [XID] // 0x0000000189842060-0x0000000189842080
		public static void ForceRefreshDaily(string alias) {} // 0x0000000181A4F680-0x0000000181A4F780
		// [XID] // 0x0000000189849520-0x0000000189849540
		public static void PauseActor(ActorEvtTargetType target, string alias) {} // 0x0000000181A528D0-0x0000000181A52A10
		// [XID] // 0x0000000189850DB0-0x0000000189850DD0
		public static void ResumeActor(ActorEvtTargetType target, string alias) {} // 0x0000000181A53F00-0x0000000181A54040
		// [XID] // 0x0000000189858140-0x0000000189858160
		public static BaseActor CreateActor(ILuaActor luaActor, ActorType actorType, string alias, string metaPath) => default; // 0x0000000181A4C7B0-0x0000000181A4CBA0
		// [XID] // 0x000000018985F1F0-0x000000018985F210
		public static void ActorDebugError(string msg) {} // 0x0000000181A4A550-0x0000000181A4A610
		// [XID] // 0x0000000189866A10-0x0000000189866A30
		public static EntityActor CreateEntityActor(BaseEntity entity, BaseActor baseActor) => default; // 0x0000000181A4CBA0-0x0000000181A4CCF0
		// [XID] // 0x000000018986E2D0-0x000000018986E2F0
		public static GadgetActor CreateGadgeActor(uint configID, Vector3 pos, Vector3 euler, BaseActor baseActor, ILuaActorInfoData actorData) => default; // 0x0000000181A4CCF0-0x0000000181A4D140
		// [XID] // 0x0000000189875780-0x00000001898757A0
		public static void PostInitGadgetActor(GadgetActor gadgetActor) {} // 0x0000000181A52A10-0x0000000181A52AC0
		// [XID] // 0x000000018987D2D0-0x000000018987D2F0
		public static void CheckActorCreateMainQuestId(uint questMainId) {} // 0x0000000181A4C240-0x0000000181A4C2D0
		// [XID] // 0x0000000189884210-0x0000000189884230
		public static void NotifyActorCreateSoft(ActorType actorType, string alias, string metaPath, uint configID, Vector3 initPos, Vector3 intRot, uint sceneId, uint roomId, uint questMainId, uint level, uint dropId, float scale) {} // 0x0000000181A50F70-0x0000000181A512B0
		// [XID] // 0x000000018988B960-0x000000018988B980
		public static void NotifyActorCreate(ActorType actorType, string alias, string metaPath, uint configID, Vector3 initPos, Vector3 initRot, uint sceneId, uint roomId, uint questMainId, uint level, uint dropId, float scale) {} // 0x0000000181A512B0-0x0000000181A51690
		// [XID] // 0x0000000189892FF0-0x0000000189893010
		public static void NotifyActorAutoStart(uint configID, uint questMainID, bool isAutoStart) {} // 0x0000000181A50E50-0x0000000181A50F70
		// [XID] // 0x000000018989A710-0x000000018989A730
		public static void NotifyActorPreCreate(string alias) {} // 0x0000000181A51970-0x0000000181A51A90
		// [XID] // 0x00000001898A19A0-0x00000001898A19C0
		public static void NotifyActorDestroy(string alias, uint sceneId, bool checkDaily) {} // 0x0000000181A51690-0x0000000181A51970
		[BlackList] // 0x00000001898A9210-0x00000001898A9250
		// [XID] // 0x00000001898A9210-0x00000001898A9250
		public static void NotifyNpcActorDestroy(uint configId, uint subKeyId, bool checkDaily) {} // 0x0000000181A51EB0-0x0000000181A521F0
		// [XID] // 0x00000001898B3740-0x00000001898B3760
		public static void NotifyNpcActorDestroyByAlias(string alias, bool checkDaily) {} // 0x0000000181A51CB0-0x0000000181A51EB0
		// [XID] // 0x0000000189AC4750-0x0000000189AC4770
		private static void NotifyNpcActorReturnDaily(uint configId, uint mainQuestId = 0 /* Metadata: 0x00AFED5D */) {} // 0x0000000181A521F0-0x0000000181A52530
		[BlackList] // 0x00000001898C27A0-0x00000001898C27E0
		// [XID] // 0x00000001898C27A0-0x00000001898C27E0
		public static bool NotifyEntityReturnDestroy(uint configId, uint subKeyId, bool checkDaily) => default; // 0x0000000181A51A90-0x0000000181A51CB0
		// [XID] // 0x00000001898CCF30-0x00000001898CCF50
		public static string TrySwitchNpcActor(uint configID, uint questMainID, string alias) => default; // 0x0000000181A55FC0-0x0000000181A56260
		// [XID] // 0x00000001898D48D0-0x00000001898D48F0
		public static NpcActor CreateNpcActor(uint configID, Vector3 pos, Vector3 euler, BaseActor baseActor, uint sceneID, uint roomID, uint questMainID, bool isLocal, bool isAutoStart) => default; // 0x0000000181A4D280-0x0000000181A4DB50
		// [XID] // 0x00000001898DC290-0x00000001898DC2B0
		public static GlobalActor CreateGlobalActor(BaseActor baseActor) => default; // 0x0000000181A4D140-0x0000000181A4D280
		// [XID] // 0x00000001898E3C60-0x00000001898E3C80
		public static QuestActor CreateQuestActor(uint mainID, BaseActor baseActor) => default; // 0x0000000181A4DB50-0x0000000181A4DCB0
		// [XID] // 0x00000001898EB810-0x00000001898EB830
		public static string GetLuaFullPath(string dataPath) => default; // 0x0000000181A50810-0x0000000181A509B0
		// [IDTag] // 0x00000001898F3060-0x00000001898F30A0
		// [XID] // 0x00000001898F3060-0x00000001898F30A0
		public static void PrepareData(Action<ILuaActor> callback, ILuaActor actor, string dataPath0) {} // 0x0000000181A53020-0x0000000181A532A0
		// [IDTag] // 0x00000001898FD9C0-0x00000001898FDA00
		// [XID] // 0x00000001898FD9C0-0x00000001898FDA00
		public static void PrepareData(Action<ILuaActor> callback, ILuaActor actor, string dataPath0, string dataPath1) {} // 0x0000000181A53590-0x0000000181A53850
		// [IDTag] // 0x0000000189908290-0x00000001899082D0
		// [XID] // 0x0000000189908290-0x00000001899082D0
		public static void PrepareData(Action<QuestModule.QuestUpdateRequest> callback, QuestModule.QuestUpdateRequest request, string dataPath0, string dataPath1, string dataPath2) {} // 0x0000000181A532A0-0x0000000181A53590
		// [XID] // 0x0000000189912BE0-0x0000000189912C00
		public static void PrepareDataByFullPath(Action<QuestModule.QuestUpdateRequest> callback, QuestModule.QuestUpdateRequest request, string dataPath0 = null, string dataPath1 = null, string dataPath2 = null) {} // 0x0000000181A52AC0-0x0000000181A52E30
		[BlackList] // 0x000000018991A510-0x000000018991A550
		// [XID] // 0x000000018991A510-0x000000018991A550
		private static void PrepareDataCallback(int index, ulong requestedPath, bool loadSucceeded, byte[] asset) {} // 0x0000000181A52E30-0x0000000181A53020
		// [XID] // 0x0000000189924CA0-0x0000000189924CC0
		public static void FinishQuestID(bool isFailed, uint questId) {} // 0x0000000181A4EC00-0x0000000181A4ED20
		// [XID] // 0x000000018992C1A0-0x000000018992C1C0
		public static void SetQuestVarByMainId(uint mainQuestId, uint index, int value) {} // 0x0000000181A54440-0x0000000181A54590
		// [XID] // 0x0000000189933620-0x0000000189933640
		public static int SetQuestVarByMainIdWithInterval(uint mainQuestId, uint index, int min, int max) => default; // 0x0000000181A542D0-0x0000000181A54440
		[BlackList] // 0x000000018993B2B0-0x000000018993B2F0
		// [XID] // 0x000000018993B2B0-0x000000018993B2F0
		public static void ForceGC() {} // 0x0000000181A4F5B0-0x0000000181A4F680
		// [XID] // 0x0000000189945780-0x00000001899457A0
		public static void InterruptReminder() {} // 0x0000000181A509B0-0x0000000181A50AC0
		// [XID] // 0x000000018994CBF0-0x000000018994CC10
		public static bool StopAllTask(int taskQueueId, LuaTaskType type) => default; // 0x0000000181A557C0-0x0000000181A558B0
		// [XID] // 0x0000000189954370-0x0000000189954390
		public static float? GetAvatarAbilityGlobalValue(uint avatarId, string globalValueKey) => default; // 0x0000000181A4FC20-0x0000000181A4FEB0
		// [XID] // 0x000000018995BCC0-0x000000018995BCE0
		public static float? GetAvatarAbilityGlobalValueByIndex(int avatarIndex, string globalValueKey) => default; // 0x0000000181A4F9B0-0x0000000181A4FC20
		// [XID] // 0x00000001899637E0-0x0000000189963800
		public static void CacheQuestTask(string alias, uint questMainId, int taskUniqId, ActorCommandType cmdType) {} // 0x0000000181A4B000-0x0000000181A4B110
		// [XID] // 0x000000018996AC20-0x000000018996AC40
		public static bool IsMalePlayer() => default; // 0x0000000181A50D70-0x0000000181A50E50
		// [XID] // 0x0000000189972870-0x0000000189972890
		public static bool IsMainQuestActive(uint mainQuestConfigId) => default; // 0x0000000181A50C10-0x0000000181A50D70
		// [XID] // 0x000000018997A010-0x000000018997A030
		public static void ShowPage(string pageName) {} // 0x0000000181A550F0-0x0000000181A55300
		// [XID] // 0x0000000189981760-0x0000000189981780
		public static bool InvokePageFunction(string funcName) => default; // 0x0000000181A50AC0-0x0000000181A50C10
		// [XID] // 0x0000000189989050-0x0000000189989070
		public static void BackPage(string pageName = null) {} // 0x0000000181A4AEF0-0x0000000181A4B000
		// [XID] // 0x0000000189990830-0x0000000189990850
		public static void ShowDragonSpinePage(int pageIndex) {} // 0x0000000181A54C10-0x0000000181A54DD0
		// [XID] // 0x0000000189998350-0x0000000189998370
		public static void ShowFleurFairMiniGame(int pageIndex) {} // 0x0000000181A54DD0-0x0000000181A54F50
		// [XID] // 0x000000018999FAF0-0x000000018999FB10
		public static void ShowActivityAsterPage() {} // 0x0000000181A54590-0x0000000181A546E0
		// [XID] // 0x00000001899A77C0-0x00000001899A77E0
		public static void ShowActivityMimiTomoPage() {} // 0x0000000181A546E0-0x0000000181A54830
		// [XID] // 0x00000001899AF010-0x00000001899AF030
		public static void ShowTeamPage(bool showExitDialog, Action callback = null, uint showTutorialId = 0 /* Metadata: 0x00AFED61 */) {} // 0x0000000181A55300-0x0000000181A55400
		// [XID] // 0x00000001899B6390-0x00000001899B63B0
		public static void ShowActivityPage(uint activityId) {} // 0x0000000181A54830-0x0000000181A549F0
		// [XID] // 0x00000001899BDF90-0x00000001899BDFB0
		public static void ShowBargainPage(uint bargainID) {} // 0x0000000181A549F0-0x0000000181A54C10
		[BlackList] // 0x0000000189811090-0x00000001898110A0
		public static bool CompareValue<TValue>(TValue curValue, TValue tarValue, ActorActionOperator opt)
			where TValue : IComparable<TValue> => default;
		[BlackList] // 0x00000001899CCE20-0x00000001899CCE50
		[DebuggerHidden] // 0x00000001899CCE20-0x00000001899CCE50
		public static IEnumerable<CustomEventType> ConvertToCustomEvent<T>(IEnumerable<T> target)
			where T : IRelateCustomEvent => default;
		[BlackList] // 0x00000001899D72C0-0x00000001899D72F0
		[DebuggerHidden] // 0x00000001899D72C0-0x00000001899D72F0
		public static IEnumerable<T> ReduceDimension<T>(IEnumerable<IEnumerable<T>> target) => default;
		[BlackList] // 0x00000001899CCE20-0x00000001899CCE50
		[DebuggerHidden] // 0x00000001899CCE20-0x00000001899CCE50
		public static IEnumerable<T> ReduceDicDimension<TKey, T>(Dictionary<TKey, T[]> target) => default;
		[BlackList] // 0x00000001899EC130-0x00000001899EC170
		[DebuggerHidden] // 0x00000001899EC130-0x00000001899EC170
		// [XID] // 0x00000001899EC130-0x00000001899EC170
		public static IEnumerable<CustomEventType> ConvertToCustomEvent(IEnumerable<CustomEventType> param1, IEnumerable<CustomEventType> param2) => default; // 0x0000000181A4C6C0-0x0000000181A4C7B0
	
		// Extension methods
		[BlackList] // 0x00000001899F9930-0x00000001899F9970
		[DebuggerHidden] // 0x00000001899F9930-0x00000001899F9970
		public static IEnumerable<T> Combine<T>(this IEnumerable<T> param1, IEnumerable<T> param2) => default;
	}
}
