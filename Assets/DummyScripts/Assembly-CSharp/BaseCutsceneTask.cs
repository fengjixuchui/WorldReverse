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
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseCutsceneTask // TypeDefIndex: 20697
{
	// Fields
	public const bool CUTSCENE_CAN_SKIP = false; // Metadata: 0x00AFE079
	protected uint _gid; // 0x10
	protected string _alias; // 0x18
	protected uint _questMainId; // 0x20
	protected BaseInterAction _interAction; // 0x28
	protected ConfigBaseCutscene _cfg; // 0x30
	protected ILuaActor _ownerActor; // 0x38
	protected Action<ILuaActor> _startCallback; // 0x40
	protected Action<ILuaActor> _finishCallback; // 0x48
	protected Action<ILuaActor> _destroyCallback; // 0x50
	protected uint _resHandle; // 0x58
	protected PlayableDirector _director; // 0x60
	protected GameObject _timelinePref; // 0x68
	protected GameObject _timelineInst; // 0x70
	protected bool _isStarted; // 0x78
	protected bool _isFinished; // 0x79
	protected bool _needPostStart; // 0x7A
	protected float _timelength; // 0x7C
	protected float _timeCnt; // 0x80
	protected float _timeDeltaReal; // 0x84
	protected float _timeRealCheckPoint; // 0x88
	protected float _timeDelta; // 0x8C
	protected Dictionary<string, List<TrackAsset>> _trackBindingDic; // 0x90
	protected Dictionary<string, List<BindingNode>> _trackBindingListDic; // 0x98
	protected List<int> _trackActiveIndexList; // 0xA0
	public const string PATH_CAST_LIST_PRE = "ART/Cutscene/CastList/"; // Metadata: 0x00AFE07A
	protected uint _castListResHandler; // 0xA8
	protected CastListScriptData _castListData; // 0xB0
	protected List<BaseComponent> _tickBind; // 0xB8

	// Properties
	public uint gid { /* [XID] */ /* 0x0000000189B65360-0x0000000189B65380 */ get => default; } // 0x000000018190C690-0x000000018190C730 
	public string alias { /* [XID] */ /* 0x0000000189B6C9C0-0x0000000189B6C9E0 */ get => default; } // 0x000000018190A210-0x000000018190A2B0 
	public ConfigBaseCutscene cfg { /* [XID] */ /* 0x0000000189B7B6B0-0x0000000189B7B6D0 */ get => default; } // 0x0000000181909960-0x0000000181909A00 
	public bool isStarted { /* [XID] */ /* 0x0000000189612310-0x0000000189612330 */ get => default; } // 0x000000018190D070-0x000000018190D110 
	public bool isFinished { /* [XID] */ /* 0x0000000189B91BE0-0x0000000189B91C00 */ get => default; } // 0x000000018190BEC0-0x000000018190BF60 
	public bool needPostStart { /* [XID] */ /* 0x0000000189B990A0-0x0000000189B990C0 */ get => default; } // 0x000000018190CFD0-0x000000018190D070 
	protected virtual bool isFadeInTaskFinished { /* [XID] */ /* 0x0000000189BA03B0-0x0000000189BA03D0 */ get => default; } // 0x000000018190C020-0x000000018190C0C0 
	protected virtual bool isFadeInTaskStarted { /* [XID] */ /* 0x0000000189BA7C10-0x0000000189BA7C30 */ get => default; } // 0x000000018190CAE0-0x000000018190CB80 
	protected virtual bool isFadeOutTaskFinished { /* [XID] */ /* 0x0000000189BAF040-0x0000000189BAF060 */ get => default; } // 0x0000000181908E30-0x0000000181908ED0 
	protected virtual bool isFadeOutTaskStarted { /* [XID] */ /* 0x0000000189BB6710-0x0000000189BB6730 */ get => default; } // 0x0000000181909440-0x00000001819094E0 
	protected virtual bool isWaitingPreTask { /* [XID] */ /* 0x0000000189BBDDA0-0x0000000189BBDDC0 */ get => default; /* [XID] */ /* 0x0000000189BC5A60-0x0000000189BC5A80 */ set {} } // 0x0000000181909BB0-0x0000000181909C50 0x000000018190CCD0-0x000000018190CD80
	protected virtual bool isRealTimeUp { /* [XID] */ /* 0x0000000189BCD4A0-0x0000000189BCD4C0 */ get => default; } // 0x000000018190B160-0x000000018190B200 
	protected bool IsTimeFinish { /* [XID] */ /* 0x0000000189BD49D0-0x0000000189BD49F0 */ get => default; } // 0x000000018190C160-0x000000018190C2A0 

	// Constructors
	public BaseCutsceneTask() {} // 0x000000018190DE50-0x000000018190DFC0

	// Methods
	// [XID] // 0x0000000189B74120-0x0000000189B74140
	public void InitQuestMainId(uint questMainId) {} // 0x000000018190DCF0-0x000000018190DDA0
	// [XID] // 0x0000000189B830A0-0x0000000189B830C0
	public GameObject GetTimelineInst() => default; // 0x000000018190A6D0-0x000000018190A770
	// [XID] // 0x0000000189BDC480-0x0000000189BDC4A0
	protected virtual void UpdateTimeCnt() {} // 0x0000000181909A00-0x0000000181909AF0
	// [XID] // 0x00000001895E8D70-0x00000001895E8D90
	protected virtual bool isFinishInternal() => default; // 0x0000000181909240-0x00000001819092F0
	// [XID] // 0x00000001895F0600-0x00000001895F0620
	public List<TrackAsset> GetTrackListByRoleName(string roleName) => default; // 0x000000018190B7B0-0x000000018190B930
	// [XID] // 0x00000001895F8090-0x00000001895F80B0
	public List<TrackAsset> GetTrackList(string roleName) => default; // 0x000000018190C2A0-0x000000018190C3C0
	// [XID] // 0x00000001895FF490-0x00000001895FF4B0
	protected bool InitRoleDic() => default; // 0x000000018190A770-0x000000018190AAF0
	// [IDTag] // 0x0000000189606CA0-0x0000000189606CE0
	// [XID] // 0x0000000189606CA0-0x0000000189606CE0
	public void TickBindingList(string roleName, float timeCnt, bool diableDynamicBone = true /* Metadata: 0x00AFE075 */) {} // 0x000000018190AAF0-0x000000018190AE60
	// [IDTag] // 0x0000000189611760-0x00000001896117A0
	// [XID] // 0x0000000189611760-0x00000001896117A0
	public void TickBindingList(float timeCnt) {} // 0x000000018190AE60-0x000000018190B030
	// [XID] // 0x000000018961BD50-0x000000018961BD70
	protected void LoadCastList(string castListPath) {} // 0x000000018190C730-0x000000018190C8A0
	// [XID] // 0x0000000189623280-0x00000001896232A0
	protected void UnloadCastList() {} // 0x000000018190C9F0-0x000000018190CAE0
	// [XID] // 0x000000018962AAC0-0x000000018962AAE0
	protected virtual void StartTimelinePrefab() {} // 0x0000000181909590-0x00000001819096E0
	// [XID] // 0x0000000189632200-0x0000000189632220
	protected void SyncStartTimelinePrefab(ConfigTimeline cfg) {} // 0x000000018190C480-0x000000018190C690
	// [XID] // 0x0000000189639CF0-0x0000000189639D10
	protected void AsyncStartTimelinePrefab(ConfigTimeline cfg) {} // 0x0000000181908C10-0x0000000181908E30
	// [XID] // 0x0000000189641200-0x0000000189641220
	protected virtual void OnStartTimelinePrefabLoaded() {} // 0x000000018190DDA0-0x000000018190DE50
	// [XID] // 0x0000000189648B80-0x0000000189648BA0
	protected virtual void StartTimelinePrefabInternal() {} // 0x000000018190D110-0x000000018190DCF0
	// [XID] // 0x00000001896501E0-0x0000000189650200
	protected virtual void OnPostPrefabStart() {} // 0x000000018190C0C0-0x000000018190C160
	// [XID] // 0x0000000189657AD0-0x0000000189657AF0
	protected virtual void CastStandby(Transform root) {} // 0x0000000181909190-0x0000000181909240
	// [XID] // 0x000000018965F200-0x000000018965F220
	protected void BindMainCamera() {} // 0x000000018190CD80-0x000000018190CFD0
	// [XID] // 0x00000001896669B0-0x00000001896669D0
	protected void BindMainCameraAudio() {} // 0x0000000181909C50-0x0000000181909F20
	// [XID] // 0x000000018966E0B0-0x000000018966E0D0
	protected void FreeMainCamera() {} // 0x000000018190A440-0x000000018190A6D0
	// [XID] // 0x0000000189675F20-0x0000000189675F40
	protected void SwitchCinemachineCamera(TrackAsset trackAsset, Camera camera) {} // 0x00000001819096E0-0x0000000181909960
	// [XID] // 0x000000018967D800-0x000000018967D820
	protected void MuteTrackList(List<TrackAsset> trackList, bool muted = true /* Metadata: 0x00AFE076 */) {} // 0x0000000181909F20-0x000000018190A210
	// [XID] // 0x0000000189684DA0-0x0000000189684DC0
	protected void CreateStandInEntity(List<TrackAsset> trackList, BaseEntity actorEntity, bool matCopy = false /* Metadata: 0x00AFE077 */) {} // 0x0000000181908ED0-0x0000000181909190
	// [XID] // 0x000000018968C8E0-0x000000018968C900
	protected void PrepareStandInEntityMaterial(BaseEntity standInEntity, BaseEntity actorEntity) {} // 0x000000018190B930-0x000000018190BE00
	protected void SwitchExtrasComponent<T>(TrackAsset trackAsset, T component)
		where T : Component {}
	protected void SwitchExtrasParent<T>(TrackAsset trackAsset, T component)
		where T : Component {}
	// [XID] // 0x0000000189694410-0x0000000189694430
	protected void SwitchAudioComponent(TrackAsset trackAsset, BaseEntity vEntity) {} // 0x000000018190B200-0x000000018190B3C0
	// [XID] // 0x000000018969B9D0-0x000000018969B9F0
	protected void StartActor() {} // 0x000000018190A2B0-0x000000018190A440
	// [XID] // 0x00000001896A30A0-0x00000001896A30C0
	protected void FinishActor() {} // 0x000000018190B030-0x000000018190B160
	// [XID] // 0x00000001896AA4F0-0x00000001896AA510
	public virtual void PreStart() {} // 0x00000001819094E0-0x0000000181909590
	// [XID] // 0x00000001896B1410-0x00000001896B1430
	public virtual void PostStart() {} // 0x00000001819092F0-0x0000000181909390
	// [XID] // 0x00000001896B8E90-0x00000001896B8EB0
	public virtual void Start() {} // 0x0000000181909390-0x0000000181909440
	// [XID] // 0x00000001896C01F0-0x00000001896C0210
	public virtual void Finish(bool destroy = false /* Metadata: 0x00AFE078 */) {} // 0x000000018190CB80-0x000000018190CCD0
	// [XID] // 0x00000001896C7990-0x00000001896C79B0
	public virtual void Tick() {} // 0x0000000181909AF0-0x0000000181909BB0
	// [XID] // 0x00000001896CF240-0x00000001896CF260
	protected void TickSpecialBind(float deltaTime) {} // 0x000000018190C8A0-0x000000018190C9F0
	// [XID] // 0x00000001896D6520-0x00000001896D6540
	public virtual void LateTick() {} // 0x000000018190C3C0-0x000000018190C480
	// [XID] // 0x00000001896DDC00-0x00000001896DDC20
	protected void LateTickSpecialBind(float deltaTime) {} // 0x000000018190B3C0-0x000000018190B510
	// [XID] // 0x00000001896E5270-0x00000001896E5290
	protected virtual void OnFinishClear() {} // 0x0000000181908A10-0x0000000181908C10
	// [XID] // 0x00000001896EC780-0x00000001896EC7A0
	protected virtual void CallStartHandler() {} // 0x000000018190BF60-0x000000018190C020
	// [XID] // 0x00000001896F3F60-0x00000001896F3F80
	protected virtual void CallFinishHandler() {} // 0x000000018190B510-0x000000018190B5D0
	// [XID] // 0x00000001896FB830-0x00000001896FB850
	protected virtual void CallDestroyHandler() {} // 0x000000018190BE00-0x000000018190BEC0
	// [XID] // 0x0000000189702E10-0x0000000189702E30
	public string DumpInfo() => default; // 0x000000018190B5D0-0x000000018190B7B0
}

