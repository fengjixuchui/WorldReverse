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
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CutsceneTask : BaseCutsceneTask // TypeDefIndex: 20702
{
	// Fields
	private bool _skipped; // 0xC0
	private bool _waitingContext; // 0xC1
	private Action _safeFinishHandler; // 0xC8
	private bool _isForceFinished; // 0xD0
	private bool _isRealTimeUp; // 0xD1
	private CutscenePreTask _preTask; // 0xD8
	private bool _isWaitingPreTask; // 0xE0
	private CutsceneFadeTask _fadeInTask; // 0xE8
	private CutsceneFadeTask _fadeOutTask; // 0xF0
	private bool _needTickDirector; // 0xF8
	private ConfigCutsceneIndex _cutsceneIndexConfig; // 0x100

	// Properties
	public bool CanSkip { /* [XID] */ /* 0x000000018976FAB0-0x000000018976FAD0 */ get => default; } // 0x0000000181621650-0x0000000181621770 
	public bool isWaitingContext { /* [XID] */ /* 0x00000001897772F0-0x0000000189777310 */ get => default; } // 0x0000000181621B70-0x0000000181621C20 
	public bool isForceFinished { /* [XID] */ /* 0x00000001897D85C0-0x00000001897D85E0 */ get => default; } // 0x0000000181628BF0-0x0000000181628CA0 
	protected override bool isRealTimeUp { /* [XID] */ /* 0x00000001897DF6F0-0x00000001897DF710 */ get => default; } // 0x0000000181625930-0x00000001816259E0 
	private bool isPreTaskFinished { /* [XID] */ /* 0x00000001897E6EB0-0x00000001897E6ED0 */ get => default; } // 0x0000000181624150-0x0000000181624210 
	protected override bool isWaitingPreTask { /* [XID] */ /* 0x00000001897EEBC0-0x00000001897EEBE0 */ get => default; /* [XID] */ /* 0x00000001897F62A0-0x00000001897F62C0 */ set {} } // 0x0000000181624040-0x00000001816240F0 0x0000000181628050-0x0000000181628100
	protected override bool isFadeInTaskFinished { /* [XID] */ /* 0x00000001897FD900-0x00000001897FD920 */ get => default; } // 0x0000000181627800-0x00000001816278C0 
	protected override bool isFadeOutTaskFinished { /* [XID] */ /* 0x0000000189805170-0x0000000189805190 */ get => default; } // 0x0000000181621930-0x00000001816219F0 
	protected override bool isFadeOutTaskStarted { /* [XID] */ /* 0x000000018980C690-0x000000018980C6B0 */ get => default; } // 0x0000000181622A70-0x0000000181622B30 
	public bool haveFadeOut { /* [XID] */ /* 0x0000000189813E20-0x0000000189813E40 */ get => default; } // 0x0000000181624210-0x00000001816242C0 
	public ConfigCutsceneIndex cutsceneIndexConfig { /* [XID] */ /* 0x0000000189920250-0x0000000189920270 */ set {} } // 0x00000001816202B0-0x0000000181620360

	// Constructors
	public CutsceneTask() {} // 0x0000000181628E60-0x0000000181628F10

	// Methods
	// [XID] // 0x000000018977EA60-0x000000018977EA80
	public void WaitContext() {} // 0x0000000181626FC0-0x0000000181627060
	// [XID] // 0x00000001897861E0-0x0000000189786200
	public void UnWaitContext() {} // 0x00000001816244E0-0x0000000181624580
	// [XID] // 0x000000018978D870-0x000000018978D890
	public void AddInterAction(BaseInterAction interAction) {} // 0x0000000181625F00-0x0000000181625FB0
	// [XID] // 0x0000000189794D40-0x0000000189794D60
	public void AddCallback(ILuaActor ownerActor, Action<ILuaActor> finishCallback, Action<ILuaActor> startCallback, Action<ILuaActor> destroyCallback) {} // 0x00000001816239A0-0x0000000181623AA0
	// [XID] // 0x000000018979D270-0x000000018979D290
	public void InitWithCfgOnly(ConfigBaseCutscene cfg) {} // 0x0000000181627980-0x0000000181627AA0
	// [IDTag] // 0x00000001897A4570-0x00000001897A45B0
	// [XID] // 0x00000001897A4570-0x00000001897A45B0
	public void InitWithCfg(ConfigBaseCutscene cfg, BaseInterAction interAction = null) {} // 0x0000000181621520-0x0000000181621650
	// [IDTag] // 0x00000001897AEFB0-0x00000001897AEFF0
	// [XID] // 0x00000001897AEFB0-0x00000001897AEFF0
	public void InitWithCfg(ConfigBaseCutscene cfg, ILuaActor ownerActor, Action<ILuaActor> finishCallback, Action<ILuaActor> startCallback, Action<ILuaActor> destroyCallback) {} // 0x00000001816213A0-0x0000000181621520
	// [XID] // 0x00000001897B9810-0x00000001897B9830
	private void CreateFadeTask(ConfigTimeline cfg) {} // 0x0000000181621770-0x0000000181621890
	// [XID] // 0x00000001897C1870-0x00000001897C1890
	public void MergeSafeToFinish() {} // 0x0000000181622D70-0x0000000181622F10
	// [XID] // 0x00000001897C9280-0x00000001897C92A0
	public void CallOnSafeFinish(Action func) {} // 0x0000000181625820-0x0000000181625930
	// [XID] // 0x00000001897D08B0-0x00000001897D08D0
	private void CallSafeFinishHandler() {} // 0x0000000181622F10-0x0000000181622FD0
	// [XID] // 0x000000018981B960-0x000000018981B980
	protected override bool isFinishInternal() => default; // 0x0000000181621D10-0x0000000181621E30
	// [XID] // 0x0000000189822EF0-0x0000000189822F10
	protected override void UpdateTimeCnt() {} // 0x0000000181623AA0-0x0000000181623BA0
	// [XID] // 0x000000018982A870-0x000000018982A890
	private void UpdateSpCamera() {} // 0x00000001816201F0-0x00000001816202B0
	// [XID] // 0x0000000189831C80-0x0000000189831CA0
	private void CheckAfterCamera() {} // 0x0000000181623BA0-0x0000000181623DE0
	// [XID] // 0x00000001898392C0-0x00000001898392E0
	private void StartPreTask() {} // 0x0000000181623280-0x0000000181623460
	// [XID] // 0x00000001898408F0-0x0000000189840910
	private void StartFadeInTask() {} // 0x0000000181623110-0x00000001816231D0
	// [XID] // 0x0000000189847E40-0x0000000189847E60
	private void FinishFadeInCurtainTask() {} // 0x00000001816231D0-0x0000000181623280
	// [XID] // 0x000000018984F5C0-0x000000018984F5E0
	private void StartFadeOutTask() {} // 0x0000000181622B30-0x0000000181622CF0
	// [XID] // 0x00000001898567A0-0x00000001898567C0
	public override void PreStart() {} // 0x0000000181622FD0-0x0000000181623110
	// [XID] // 0x000000018985DA50-0x000000018985DA70
	private void OnPostStart() {} // 0x0000000181624660-0x0000000181624E30
	// [XID] // 0x00000001898654F0-0x0000000189865510
	public override void PostStart() {} // 0x0000000181622140-0x0000000181622240
	// [XID] // 0x000000018986C930-0x000000018986C950
	private void OnStart() {} // 0x0000000181626570-0x0000000181626F50
	// [XID] // 0x0000000189873DE0-0x0000000189873E00
	protected override void OnPostPrefabStart() {} // 0x00000001816278C0-0x0000000181627980
	// [XID] // 0x000000018987B860-0x000000018987B880
	private void OnFinishInternal(bool destroy = false /* Metadata: 0x00AFE09C */) {} // 0x0000000181620360-0x0000000181620C60
	// [XID] // 0x0000000189882A30-0x0000000189882A50
	public override void Start() {} // 0x0000000181622240-0x0000000181622340
	// [XID] // 0x000000018988A1D0-0x000000018988A1F0
	protected override void OnStartTimelinePrefabLoaded() {} // 0x0000000181628D70-0x0000000181628E60
	// [XID] // 0x0000000189891660-0x0000000189891680
	private void CheckStartTimelinePrefab() {} // 0x0000000181621E30-0x0000000181621F50
	// [XID] // 0x0000000189898EB0-0x0000000189898ED0
	protected override void StartTimelinePrefabInternal() {} // 0x0000000181628250-0x0000000181628300
	// [XID] // 0x00000001898A00B0-0x00000001898A00D0
	protected override void CastStandby(Transform root) {} // 0x0000000181621C20-0x0000000181621D10
	// [XID] // 0x00000001898A7890-0x00000001898A78B0
	private void MuteLocalAvatarTrackExcept(BodyType bodyType = BodyType.BODY_NONE /* Metadata: 0x00AFE09D */) {} // 0x0000000181623460-0x00000001816239A0
	// [XID] // 0x00000001898AF370-0x00000001898AF390
	public void BindLocalAvatar(Transform root, CutsceneBindType bindType = CutsceneBindType.RESET /* Metadata: 0x00AFE0A1 */) {} // 0x0000000181627060-0x0000000181627450
	// [XID] // 0x00000001898B67F0-0x00000001898B6810
	private void BindLocalAvatarInternal(Transform root, CutsceneBindType bindType, AvatarEntity avatarEntity, List<TrackAsset> trackList, string roleName, AvatarExcelConfig avatarCfg) {} // 0x0000000181628370-0x00000001816289A0
	// [XID] // 0x00000001898BE000-0x00000001898BE020
	public void FreeLocalAvatar() {} // 0x00000001816223C0-0x0000000181622A70
	// [XID] // 0x00000001898C5870-0x00000001898C5890
	public void TickLocalAvatar() {} // 0x0000000181620C60-0x00000001816213A0
	// [XID] // 0x00000001898CCF90-0x00000001898CCFB0
	public void BindCastList(Transform root) {} // 0x0000000181627450-0x0000000181627800
	// [XID] // 0x00000001898D4930-0x00000001898D4950
	private void BindCastInternal(Transform root, BaseEntity vEntity, CastListScriptData.NpcRolePair pair, List<TrackAsset> trackList) {} // 0x0000000181624E90-0x0000000181625380
	// [XID] // 0x00000001898DC2D0-0x00000001898DC2F0
	private void CheckCastAnimatorInterleaved(BaseEntity vEntity) {} // 0x0000000181622020-0x0000000181622140
	// [XID] // 0x00000001898E3D40-0x00000001898E3D60
	public void FreeCastList() {} // 0x00000001816259E0-0x0000000181625F00
	// [XID] // 0x00000001898EB870-0x00000001898EB890
	public void TickCastList() {} // 0x0000000181626080-0x0000000181626570
	// [XID] // 0x00000001898F30C0-0x00000001898F30E0
	public override void Tick() {} // 0x0000000181623DE0-0x0000000181624040
	// [XID] // 0x00000001898FA780-0x00000001898FA7A0
	public override void LateTick() {} // 0x0000000181627AA0-0x0000000181627C10
	// [XID] // 0x0000000189902190-0x00000001899021B0
	public void ForceFinish() {} // 0x0000000181621A50-0x0000000181621B70
	// [XID] // 0x0000000189909900-0x0000000189909920
	public void ForceFinishImmdiately(bool destroy = false /* Metadata: 0x00AFE0A5 */) {} // 0x0000000181628CA0-0x0000000181628D70
	// [XID] // 0x0000000189910F90-0x0000000189910FB0
	public void Destroy() {} // 0x0000000181621890-0x0000000181621930
	// [XID] // 0x0000000189918B10-0x0000000189918B30
	public override void Finish(bool destroy = false /* Metadata: 0x00AFE0A6 */) {} // 0x0000000181627C10-0x0000000181628050
	// [XID] // 0x0000000189927AB0-0x0000000189927AD0
	public void OnCutsceneIndexConfigSerialized(object obj, ulong path) {} // 0x0000000181628A00-0x0000000181628BF0
	// [XID] // 0x000000018992F280-0x000000018992F2A0
	public void OnCutsceneIndexLoadFinish() {} // 0x0000000181625380-0x0000000181625820
	// [XID] // 0x0000000189936650-0x0000000189936670
	private void RemoveCutsceneTask() {} // 0x0000000181624400-0x00000001816244E0
}

