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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCActor : LCBase // TypeDefIndex: 11683
{
	// Fields
	private List<BaseCommand> _cachedTempCmdList; // 0x130
	public bool needPath; // 0x138
	private EntityActor _actor; // 0x140
	private bool _isLostAttention; // 0x148
	private bool _isActorStarted; // 0x149
	private const string AGENT_NAME = "Undead01"; // Metadata: 0x00AEA6D0
	private const int ANIM_FLY_PARAM = 20; // Metadata: 0x00AEA6DC
	private LCAIBeta _ai; // 0x150
	private AIPathfinding _pathfinding; // 0x158
	private VCBaseMove _vcMove; // 0x160
	private VCBaseAudio _vcAudio; // 0x168
	private List<Vector3> _posList; // 0x170
	private List<ActorSensibleInfo> _sensibleInfoList; // 0x178

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B32EF0-0x0000000189B32F10 */ get => default; } // 0x0000000181A3EBA0-0x0000000181A3EC40 
	public EntityActor actor { /* [XID] */ /* 0x00000001898AEBD0-0x00000001898AEBF0 */ get => default; } // 0x0000000181A3A900-0x0000000181A3A9B0 
	private bool isDaily { /* [XID] */ /* 0x000000018976AD30-0x000000018976AD50 */ get => default; } // 0x0000000181A39330-0x0000000181A393F0 
	public bool isActorStarted { /* [XID] */ /* 0x000000018960C3C0-0x000000018960C3E0 */ get => default; } // 0x0000000181A3CCB0-0x0000000181A3CD60 

	// Constructors
	public LCActor() {} // 0x0000000181A3EAC0-0x0000000181A3EBA0

	// Methods
	// [IDTag] // 0x0000000189B3A9A0-0x0000000189B3A9E0
	// [XID] // 0x0000000189B3A9A0-0x0000000189B3A9E0
	private void HandleExternalCache(List<BaseCommand> cmdList) {} // 0x0000000181A3D2B0-0x0000000181A3D4F0
	// [IDTag] // 0x0000000189B454C0-0x0000000189B45500
	// [XID] // 0x0000000189B454C0-0x0000000189B45500
	private void HandleExternalCache(Dictionary<int, List<BaseCommand>> cmdDic) {} // 0x0000000181A3D4F0-0x0000000181A3D6B0
	// [IDTag] // 0x0000000189B4FB30-0x0000000189B4FB70
	// [XID] // 0x0000000189B4FB30-0x0000000189B4FB70
	private List<BaseCommand> HandleStartCacheInternal(ActorCommandType cmdType, List<BaseCommand> cmdList) => default; // 0x0000000181A3A550-0x0000000181A3A640
	// [IDTag] // 0x0000000189B5A360-0x0000000189B5A3A0
	// [XID] // 0x0000000189B5A360-0x0000000189B5A3A0
	private List<BaseCommand> HandleStartCacheInternal(ActorCommandType cmdType, Dictionary<int, List<BaseCommand>> cmdDic) => default; // 0x0000000181A3A640-0x0000000181A3A740
	// [XID] // 0x0000000189B64AF0-0x0000000189B64B10
	private List<BaseCommand> HandleCacheInternal(ActorCommandType cmdType, List<BaseCommand> cmdList) => default; // 0x0000000181A3C0C0-0x0000000181A3C310
	// [XID] // 0x0000000189B6BF00-0x0000000189B6BF20
	private void HandleMove(List<BaseCommand> cmdList) {} // 0x0000000181A3DEA0-0x0000000181A3E010
	// [XID] // 0x0000000189B73810-0x0000000189B73830
	private void HandleMoveRoute(List<BaseCommand> cmdList) {} // 0x0000000181A39960-0x0000000181A39AB0
	// [XID] // 0x0000000189B7AC50-0x0000000189B7AC70
	private void HandleFreeStyle(List<BaseCommand> cmdList) {} // 0x0000000181A3D920-0x0000000181A3DAD0
	// [XID] // 0x0000000189B82570-0x0000000189B82590
	private void HandleFreeStateTrigger(List<BaseCommand> cmdList) {} // 0x0000000181A3E2F0-0x0000000181A3E3A0
	// [XID] // 0x0000000189B89D50-0x0000000189B89D70
	private void HandleSitOnChair(List<BaseCommand> cmdList) {} // 0x0000000181A3BEA0-0x0000000181A3BFB0
	// [XID] // 0x00000001899D3B70-0x00000001899D3B90
	private void HandleStandFromChair(List<BaseCommand> cmdList) {} // 0x0000000181A3A740-0x0000000181A3A850
	// [XID] // 0x0000000189B985B0-0x0000000189B985D0
	private void HandleNotify(List<BaseCommand> cmdList) {} // 0x0000000181A38D40-0x0000000181A38E60
	// [XID] // 0x0000000189B9FAA0-0x0000000189B9FAC0
	private void HandleHide(List<BaseCommand> cmdList) {} // 0x0000000181A3ACB0-0x0000000181A3ADC0
	// [XID] // 0x0000000189AE8BB0-0x0000000189AE8BD0
	private void HandleDestroy(List<BaseCommand> cmdList) {} // 0x0000000181A3AF40-0x0000000181A3B030
	// [XID] // 0x00000001896D2AD0-0x00000001896D2AF0
	private void HandleSetWalkSpeedRatio(List<BaseCommand> cmdList) {} // 0x0000000181A3BFB0-0x0000000181A3C0C0
	// [XID] // 0x0000000189B42390-0x0000000189B423B0
	private void HandleAttach(List<BaseCommand> cmdList) {} // 0x0000000181A3A000-0x0000000181A3A140
	// [XID] // 0x0000000189BBD390-0x0000000189BBD3B0
	private void HandleLookAt(List<BaseCommand> cmdList) {} // 0x0000000181A3DD80-0x0000000181A3DEA0
	// [IDTag] // 0x0000000189BC4F20-0x0000000189BC4F60
	// [XID] // 0x0000000189BC4F20-0x0000000189BC4F60
	private void HandleStartCall(List<BaseCommand> cmdList) {} // 0x0000000181A3D0C0-0x0000000181A3D1D0
	// [XID] // 0x0000000189B85A00-0x0000000189B85A20
	private void HandleAddGeneralMark(List<BaseCommand> cmdList) {} // 0x0000000181A38B60-0x0000000181A38C70
	// [XID] // 0x0000000189BD6D20-0x0000000189BD6D40
	private void HandleQuestTask(List<BaseCommand> cmdList) {} // 0x0000000181A3C6B0-0x0000000181A3C7F0
	// [IDTag] // 0x0000000189BDEAA0-0x0000000189BDEAE0
	// [XID] // 0x0000000189BDEAA0-0x0000000189BDEAE0
	private void HandleDisableInteeHeadCtrl(List<BaseCommand> cmdList) {} // 0x0000000181A3C7F0-0x0000000181A3C900
	// [XID] // 0x0000000189797840-0x0000000189797860
	public void LostAttention() {} // 0x0000000181A38210-0x0000000181A382B0
	// [XID] // 0x000000018979F7B0-0x000000018979F7D0
	public void GetAttention() {} // 0x0000000181A391C0-0x0000000181A39260
	// [XID] // 0x0000000189763570-0x0000000189763590
	public List<BaseCommand> GetCacheCmd(ActorCommandType cmdType, Dictionary<int, List<BaseCommand>> cmdDic) => default; // 0x0000000181A3B4C0-0x0000000181A3B5C0
	// [XID] // 0x00000001897A6C60-0x00000001897A6C80
	public override void PreInit() {} // 0x0000000181A3E8F0-0x0000000181A3EA00
	// [XID] // 0x00000001897B6570-0x00000001897B6590
	public override void Init() {} // 0x0000000181A3B5C0-0x0000000181A3B660
	// [XID] // 0x000000018962A140-0x000000018962A160
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181A39060-0x0000000181A39110
	// [XID] // 0x00000001897CD0F0-0x00000001897CD110
	public void ClearActor() {} // 0x0000000181A3E590-0x0000000181A3E630
	// [XID] // 0x00000001897D46D0-0x00000001897D46F0
	public void InitActor(EntityActor entityActor) {} // 0x0000000181A39110-0x0000000181A391C0
	// [XID] // 0x0000000189640760-0x0000000189640780
	public override void OnEntityReady() {} // 0x0000000181A3E3A0-0x0000000181A3E4B0
	// [XID] // 0x0000000189810850-0x0000000189810870
	public void HandleStartActor() {} // 0x0000000181A3A850-0x0000000181A3A900
	// [XID] // 0x0000000189869380-0x00000001898693A0
	public void HandleStartRecover() {} // 0x0000000181A3CE20-0x0000000181A3CEF0
	// [XID] // 0x0000000189657140-0x0000000189657160
	public void HandleExternalRecover() {} // 0x0000000181A3A480-0x0000000181A3A550
	// [XID] // 0x0000000189826F60-0x0000000189826F80
	private void HandleExternalCacheCmd() {} // 0x0000000181A3AB40-0x0000000181A3ACB0
	// [XID] // 0x0000000189886CC0-0x0000000189886CE0
	public void MoveToRoute(List<Vector3> targetPosList, VCMoveData.MotionFlag motionFlag, bool needDynamicAvoidance = true /* Metadata: 0x00AEA6B7 */, bool exactlyMove = false /* Metadata: 0x00AEA6B8 */) {} // 0x0000000181A3E630-0x0000000181A3E7C0
	// [XID] // 0x000000018966D5F0-0x000000018966D610
	public void MoveTo(Vector3 targetPos, VCMoveData.MotionFlag motionFlag = VCMoveData.MotionFlag.Walk /* Metadata: 0x00AEA6B9 */) {} // 0x0000000181A3B930-0x0000000181A3BAC0
	// [IDTag] // 0x0000000189675590-0x00000001896755D0
	// [XID] // 0x0000000189675590-0x00000001896755D0
	private void MoveToInternal(List<Vector3> posList, VCMoveData.MotionFlag motionFlag = VCMoveData.MotionFlag.Walk /* Metadata: 0x00AEA6BD */, bool needDynamicAvoidance = true /* Metadata: 0x00AEA6C1 */, bool exactlyMove = false /* Metadata: 0x00AEA6C2 */) {} // 0x0000000181A3CB30-0x0000000181A3CCB0
	// [IDTag] // 0x000000018967FC70-0x000000018967FCB0
	// [XID] // 0x000000018967FC70-0x000000018967FCB0
	private void MoveToInternal(Vector3 targetPos, VCMoveData.MotionFlag motionFlag = VCMoveData.MotionFlag.Walk /* Metadata: 0x00AEA6C3 */) {} // 0x0000000181A3C9E0-0x0000000181A3CB30
	// [XID] // 0x000000018968A6C0-0x000000018968A6E0
	public void Standby(bool resetRoute) {} // 0x0000000181A3A9B0-0x0000000181A3AB40
	[BlackList] // 0x00000001896923B0-0x00000001896923F0
	// [XID] // 0x00000001896923B0-0x00000001896923F0
	public void StandbyNoCmd(bool resetRoute = true /* Metadata: 0x00AEA6C7 */) {} // 0x0000000181A38C70-0x0000000181A38D40
	// [XID] // 0x000000018969C770-0x000000018969C790
	private void StandbyInternal(bool resetRoute = true /* Metadata: 0x00AEA6C8 */) {} // 0x0000000181A3E010-0x0000000181A3E140
	// [XID] // 0x00000001898C98E0-0x00000001898C9900
	public void ResumeMove() {} // 0x0000000181A38670-0x0000000181A38730
	// [XID] // 0x00000001898D8770-0x00000001898D8790
	public void RefreshTargetPos(Vector3 targetPos) {} // 0x0000000181A3B270-0x0000000181A3B380
	// [XID] // 0x00000001896B2190-0x00000001896B21B0
	public bool IsInIdle() => default; // 0x0000000181A39780-0x0000000181A39840
	// [XID] // 0x00000001898EF7C0-0x00000001898EF7E0
	public bool DoingFreeStyle() => default; // 0x0000000181A38FA0-0x0000000181A39060
	// [XID] // 0x00000001896C0FA0-0x00000001896C0FC0
	public void DoFreeStyle(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default, bool cacheCmd = true /* Metadata: 0x00AEA6C9 */, bool resetRoute = true /* Metadata: 0x00AEA6CA */) {} // 0x0000000181A3E140-0x0000000181A3E2F0
	// [XID] // 0x000000018998FE70-0x000000018998FE90
	private void DoFreeStyleInternal(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default, bool resetRoute = true /* Metadata: 0x00AEA6CB */) {} // 0x0000000181A39840-0x0000000181A39960
	// [XID] // 0x00000001896CFF10-0x00000001896CFF30
	public void DoFreeStateTrigger(bool cacheCmd = true /* Metadata: 0x00AEA6CC */) {} // 0x0000000181A3A350-0x0000000181A3A480
	// [XID] // 0x00000001896D72C0-0x00000001896D72E0
	private void DoFreeStateTriggerInternal(bool clearFreeStyle = true /* Metadata: 0x00AEA6CD */) {} // 0x0000000181A3B660-0x0000000181A3B770
	// [XID] // 0x00000001896DEB50-0x00000001896DEB70
	public void ResetFreeStyle() {} // 0x0000000181A3DAD0-0x0000000181A3DD80
	// [XID] // 0x000000018995FD10-0x000000018995FD30
	public void SetWalkSpeedRatio(float speedRatio, bool cacheCmd = true /* Metadata: 0x00AEA6CE */) {} // 0x0000000181A38A00-0x0000000181A38B60
	// [XID] // 0x00000001896DA4F0-0x00000001896DA510
	private void SetWalkSpeedRatioInternal(float speedRatio, bool cacheCmd = true /* Metadata: 0x00AEA6CF */) {} // 0x0000000181A3A140-0x0000000181A3A350
	// [XID] // 0x000000018997D710-0x000000018997D730
	public void ResetWalkSpeed() {} // 0x0000000181A38390-0x0000000181A38670
	// [XID] // 0x00000001899A2510-0x00000001899A2530
	public void TurnTo(Vector3 dir) {} // 0x0000000181A393F0-0x0000000181A39550
	// [XID] // 0x00000001899A9C60-0x00000001899A9C80
	public void PlayAudio(string evtName) {} // 0x0000000181A3B130-0x0000000181A3B270
	// [XID] // 0x00000001899C7D50-0x00000001899C7D70
	public void SwitchAirMode(bool value) {} // 0x0000000181A387F0-0x0000000181A38920
	// [XID] // 0x0000000189712A10-0x0000000189712A30
	public void SetGroundFollowAnimRotation(bool enable) {} // 0x0000000181A3C400-0x0000000181A3C570
	// [XID] // 0x000000018971A350-0x000000018971A370
	public void SitOnChair(int freeStyleType) {} // 0x0000000181A380E0-0x0000000181A38210
	// [XID] // 0x00000001899BD4B0-0x00000001899BD4D0
	private void SitOnChairInternal(int freeStyleType) {} // 0x0000000181A39B30-0x0000000181A39C90
	// [XID] // 0x0000000189A3EC50-0x0000000189A3EC70
	public void StandFromChair(float? standAngle = default) {} // 0x0000000181A3C570-0x0000000181A3C6B0
	// [XID] // 0x00000001899DB140-0x00000001899DB160
	private void StandFromChairInternal(float? standAngle = default) {} // 0x0000000181A38920-0x0000000181A38A00
	// [XID] // 0x0000000189737EB0-0x0000000189737ED0
	private void NotifyInternal(int evtType, object[] evtParams, int sourceType, uint sourceId) {} // 0x0000000181A3B380-0x0000000181A3B4C0
	// [XID] // 0x000000018973FA00-0x000000018973FA20
	private void HideInternal(bool hide) {} // 0x0000000181A37F80-0x0000000181A380E0
	// [XID] // 0x0000000189A4D9B0-0x0000000189A4D9D0
	public void Attach(string attachName, bool on) {} // 0x0000000181A39550-0x0000000181A396A0
	// [XID] // 0x000000018974E730-0x000000018974E750
	private void HandleAttachInternal(string attachName, bool on) {} // 0x0000000181A3B770-0x0000000181A3B870
	// [XID] // 0x0000000189755DE0-0x0000000189755E00
	public void DoLookAt(Vector3 pos) {} // 0x0000000181A39E90-0x0000000181A3A000
	// [XID] // 0x0000000189A64430-0x0000000189A64450
	public void DoClearLookAt() {} // 0x0000000181A3B030-0x0000000181A3B130
	// [XID] // 0x0000000189764880-0x00000001897648A0
	private void HandleLookAtInternal(Vector3 pos) {} // 0x0000000181A38E60-0x0000000181A38FA0
	// [XID] // 0x000000018976C320-0x000000018976C340
	private void HandleClearLookAtInternal() {} // 0x0000000181A3C310-0x0000000181A3C400
	// [XID] // 0x0000000189773740-0x0000000189773760
	public void SetDisableInteeHeadCtrl(bool isDisable) {} // 0x0000000181A3D720-0x0000000181A3D850
	// [IDTag] // 0x000000018977AEF0-0x000000018977AF30
	// [XID] // 0x000000018977AEF0-0x000000018977AF30
	private void HandleDisableInteeHeadCtrl(bool isDisable) {} // 0x0000000181A3C900-0x0000000181A3C9E0
	// [XID] // 0x0000000189785800-0x0000000189785820
	public Vector3 GetLookAtViewPoint(Vector3 dir) => default; // 0x0000000181A3ADC0-0x0000000181A3AF40
	// [XID] // 0x000000018978CD20-0x000000018978CD40
	public bool ControlHeadEnabled() => default; // 0x0000000181A3D850-0x0000000181A3D920
	// [XID] // 0x0000000189B8C890-0x0000000189B8C8B0
	public void DoAddGeneralMark(string iconName) {} // 0x0000000181A3E7C0-0x0000000181A3E8F0
	// [XID] // 0x0000000189AA02F0-0x0000000189AA0310
	public void DoClearGeneralMark() {} // 0x0000000181A3CEF0-0x0000000181A3CFF0
	// [XID] // 0x00000001897A3A90-0x00000001897A3AB0
	private void HandleAddGeneralMarkInternal(string iconName) {} // 0x0000000181A382B0-0x0000000181A38390
	// [XID] // 0x00000001897AAE80-0x00000001897AAEA0
	private void HandleClearGeneralMarkInternal() {} // 0x0000000181A3CD60-0x0000000181A3CE20
	// [XID] // 0x00000001896F7CF0-0x00000001896F7D10
	private void DoQuestTaskInternal(uint questMainId, int taskUniqId, ActorCommandType cmdType) {} // 0x0000000181A39C90-0x0000000181A39E90
	// [XID] // 0x00000001897BA5A0-0x00000001897BA5C0
	public void StartCall(Action<ILuaActor> call) {} // 0x0000000181A39260-0x0000000181A39330
	// [IDTag] // 0x00000001897C2480-0x00000001897C24C0
	// [XID] // 0x00000001897C2480-0x00000001897C24C0
	private void HandleStartCall(Action<ILuaActor> call) {} // 0x0000000181A3D1D0-0x0000000181A3D2B0
	// [XID] // 0x00000001897CCDA0-0x00000001897CCDC0
	protected override void Tick(float inDeltaTime) {} // 0x0000000181A3EA00-0x0000000181A3EAC0
	// [XID] // 0x00000001897D4440-0x00000001897D4460
	private void TickSensing() {} // 0x0000000181A3BAC0-0x0000000181A3BEA0
	// [XID] // 0x0000000189B2D380-0x0000000189B2D3A0
	public override void Destroy() {} // 0x0000000181A396A0-0x0000000181A39780
	// [XID] // 0x0000000189B34890-0x0000000189B348B0
	public void SetTitle(string title) {} // 0x0000000181A3E4B0-0x0000000181A3E590
	// [XID] // 0x00000001897EAE00-0x00000001897EAE20
	public string GetTitle() => default; // 0x0000000181A38730-0x0000000181A387F0
}

