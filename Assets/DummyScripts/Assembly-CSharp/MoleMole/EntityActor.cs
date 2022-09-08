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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B2DD20-0x0000000189B2DD60
	[RecycleType] // 0x0000000189B2DD20-0x0000000189B2DD60
	public class EntityActor : BaseActor, IAutoAllocRecycle // TypeDefIndex: 20036
	{
		// Fields
		protected LCActor _lcActor; // 0xE0
		protected BaseEntity _entity; // 0xE8
		protected bool _isDaily; // 0xF0
		private Action<ILuaActor> _curDitherCallBack; // 0x100
		private bool _ensureDitherCallBack; // 0x108
		protected Action<ILuaActor> _disappearFinishCallback; // 0x110
		protected bool _isActorOnly; // 0x118
		protected bool _isDisappearToDestroy; // 0x119
		protected WorldTimer _disappearTimer; // 0x120
	
		// Properties
		public override BaseEntity entity { /* [XID] */ /* 0x0000000189B62230-0x0000000189B62250 */ get => default; } // 0x00000001814A47D0-0x00000001814A4880 
		[BlackList] // 0x0000000189811090-0x00000001898110A0
		public bool isDaily { /* [XID] */ /* 0x0000000189B69E90-0x0000000189B69EB0 */ get => default; } // 0x00000001814A4880-0x00000001814A4930 
	
		// Events
		public event Action<ILuaActor, List<ActorSensibleInfo>> SensibleInfoEvent;
	
		// Constructors
		public EntityActor() {} // 0x00000001814A4610-0x00000001814A46B0
	
		// Methods
		[BlackList] // 0x0000000189B42E10-0x0000000189B42E50
		// [XID] // 0x0000000189B42E10-0x0000000189B42E50
		public override void AutoAllocTypeFields() {} // 0x000000018149D910-0x000000018149D9B0
		[BlackList] // 0x0000000189B4D550-0x0000000189B4D590
		// [XID] // 0x0000000189B4D550-0x0000000189B4D590
		public override void AutoRecycleTypeFields() {} // 0x000000018149D9B0-0x000000018149DA90
		[BlackList] // 0x0000000189B57EB0-0x0000000189B57EF0
		// [XID] // 0x0000000189B57EB0-0x0000000189B57EF0
		public override void ReturnToObjectPool() {} // 0x00000001814A1B80-0x00000001814A1C20
		// [XID] // 0x0000000189B714F0-0x0000000189B71510
		public override bool IsValid() => default; // 0x00000001814A0F70-0x00000001814A1030
		// [XID] // 0x0000000189B78A40-0x0000000189B78A60
		public override bool IsEnabled() => default; // 0x00000001814A0C40-0x00000001814A0D20
		// [XID] // 0x0000000189B8EB00-0x0000000189B8EB20
		public bool HasSensibleInfoEvent() => default; // 0x00000001814A0470-0x00000001814A0520
		// [XID] // 0x0000000189B26100-0x0000000189B26120
		public void CallSensibleInfoEvent(List<ActorSensibleInfo> infoList) {} // 0x000000018149DB70-0x000000018149DC50
		// [XID] // 0x0000000189B9D600-0x0000000189B9D620
		public virtual void InitPropData(BaseEntity entity) {} // 0x00000001814A0890-0x00000001814A0940
		// [XID] // 0x0000000189BA4FF0-0x0000000189BA5010
		public float GetPropValue(int propType) => default; // 0x00000001814A0100-0x00000001814A0220
		// [XID] // 0x00000001899B7230-0x00000001899B7250
		public virtual Vector3 GetPos() => default; // 0x00000001814A0000-0x00000001814A0100
		// [XID] // 0x0000000189BB39B0-0x0000000189BB39D0
		public float GetPosX() => default; // 0x000000018149FD60-0x000000018149FE40
		// [XID] // 0x0000000189BBAF40-0x0000000189BBAF60
		public float GetPosY() => default; // 0x000000018149FE40-0x000000018149FF20
		// [XID] // 0x0000000189BC2F30-0x0000000189BC2F50
		public float GetPosZ() => default; // 0x000000018149FF20-0x00000001814A0000
		// [XID] // 0x0000000189BCA730-0x0000000189BCA750
		public float GetDistFromAvatarToSelf() => default; // 0x000000018149FA00-0x000000018149FB60
		// [XID] // 0x0000000189BD1D20-0x0000000189BD1D40
		public Vector3 GetDirFromSelfToAvatar() => default; // 0x000000018149F840-0x000000018149FA00
		// [XID] // 0x0000000189BD9350-0x0000000189BD9370
		public virtual void SetPosAndTurnTo(Vector3 pos, Vector3 dir, bool noPerform = true /* Metadata: 0x00AFD1B4 */) {} // 0x00000001814A23C0-0x00000001814A2680
		// [XID] // 0x0000000189989F90-0x0000000189989FB0
		public virtual void SetPos(Vector3 pos, bool noPerform = true /* Metadata: 0x00AFD1B5 */, bool resetRoute = true /* Metadata: 0x00AFD1B6 */) {} // 0x00000001814A27F0-0x00000001814A2AA0
		// [XID] // 0x00000001895ED890-0x00000001895ED8B0
		protected virtual void SetPosInternal(Vector3 pos, bool noPerform = true /* Metadata: 0x00AFD1B7 */) {} // 0x00000001814A2680-0x00000001814A27F0
		// [XID] // 0x00000001895F4FF0-0x00000001895F5010
		public virtual Vector3 GetEuler() => default; // 0x000000018149FB60-0x000000018149FC60
		// [XID] // 0x00000001895FC5F0-0x00000001895FC610
		public virtual Quaternion GetRotation() => default; // 0x00000001814A0220-0x00000001814A0310
		// [XID] // 0x0000000189603F70-0x0000000189603F90
		public virtual Vector3 GetForward() => default; // 0x000000018149FC60-0x000000018149FD60
		// [XID] // 0x000000018960B8D0-0x000000018960B8F0
		public virtual void SetEuler(Vector3 euler) {} // 0x00000001814A2100-0x00000001814A2240
		// [XID] // 0x0000000189612E20-0x0000000189612E40
		public virtual void SetRotation(Quaternion rotate) {} // 0x00000001814A2AA0-0x00000001814A2B80
		// [XID] // 0x000000018961A5C0-0x000000018961A5E0
		public virtual void WalkTo(Vector3 pos) {} // 0x00000001814A4520-0x00000001814A4610
		// [XID] // 0x0000000189621B20-0x0000000189621B40
		public virtual void WalkToRoute(List<Vector3> posList, bool needDynamicAvoidance = true /* Metadata: 0x00AFD1B8 */, bool exactlyMove = false /* Metadata: 0x00AFD1B9 */) {} // 0x00000001814A4420-0x00000001814A4520
		// [XID] // 0x0000000189629470-0x0000000189629490
		public virtual void WalkToRouteByData(ConfigRoute routeConfig) {} // 0x00000001814A4220-0x00000001814A4420
		// [XID] // 0x0000000189630DA0-0x0000000189630DC0
		public virtual void RunTo(Vector3 pos) {} // 0x00000001814A1F30-0x00000001814A2020
		// [XID] // 0x0000000189638860-0x0000000189638880
		public virtual void RunToRoute(List<Vector3> posList, bool needDynamicAvoidance = true /* Metadata: 0x00AFD1BA */, bool exactlyMove = false /* Metadata: 0x00AFD1BB */) {} // 0x00000001814A1E30-0x00000001814A1F30
		// [XID] // 0x000000018963FCB0-0x000000018963FCD0
		public virtual void RunToRouteByData(ConfigRoute routeConfig) {} // 0x00000001814A1C20-0x00000001814A1E30
		// [XID] // 0x0000000189647490-0x00000001896474B0
		public virtual void TurnTo(Vector3 dir) {} // 0x00000001814A3820-0x00000001814A3910
		// [XID] // 0x000000018964EBE0-0x000000018964EC00
		public virtual void TurnToAvatar() {} // 0x00000001814A3680-0x00000001814A3820
		// [XID] // 0x00000001899A8620-0x00000001899A8640
		public virtual void SyncPos(int state) {} // 0x00000001814A3460-0x00000001814A3540
		// [XID] // 0x000000018965DBD0-0x000000018965DBF0
		public void SwitchAirMode(bool value) {} // 0x00000001814A33A0-0x00000001814A3460
		// [XID] // 0x0000000189665240-0x0000000189665260
		public virtual void CheckShow() {} // 0x000000018149DD10-0x000000018149DDD0
		[BlackList] // 0x000000018966C9C0-0x000000018966CA00
		// [XID] // 0x000000018966C9C0-0x000000018966CA00
		public virtual void CheckShowInternal() {} // 0x000000018149DC50-0x000000018149DD10
		// [XID] // 0x0000000189677840-0x0000000189677860
		public virtual bool IsHided() => default; // 0x00000001814A0D20-0x00000001814A0DE0
		// [XID] // 0x000000018967ED20-0x000000018967ED40
		public virtual void Hide(bool value, bool needCache = false /* Metadata: 0x00AFD1BC */) {} // 0x00000001814A05E0-0x00000001814A06C0
		// [XID] // 0x00000001899D5220-0x00000001899D5240
		public virtual void HideInternal(bool value) {} // 0x00000001814A0520-0x00000001814A05E0
		// [XID] // 0x000000018968E450-0x000000018968E470
		public virtual void SetGroundFollowAnimRotation(bool enable) {} // 0x00000001814A2240-0x00000001814A2300
		// [XID] // 0x0000000189695D30-0x0000000189695D50
		public virtual bool DoingFreeStyle() => default; // 0x000000018149F400-0x000000018149F4C0
		// [XID] // 0x000000018969D4A0-0x000000018969D4C0
		public virtual void DoFreeStyle(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default, bool cacheCmd = true /* Metadata: 0x00AFD1BD */, bool resetRoute = true /* Metadata: 0x00AFD1BE */) {} // 0x000000018149F2D0-0x000000018149F400
		// [XID] // 0x00000001896A44E0-0x00000001896A4500
		public virtual void DoFreeStateTrigger(bool cacheCmd = true /* Metadata: 0x00AFD1BF */) {} // 0x000000018149F210-0x000000018149F2D0
		// [XID] // 0x00000001896ABD10-0x00000001896ABD30
		public virtual void Standby(bool resetRoute = true /* Metadata: 0x00AFD1C0 */) {} // 0x00000001814A3130-0x00000001814A31F0
		// [XID] // 0x00000001896B2EB0-0x00000001896B2ED0
		public virtual void PlayDefault() {} // 0x00000001814A18B0-0x00000001814A1A20
		// [XID] // 0x00000001896BA6F0-0x00000001896BA710
		public virtual void SetWalkSpeedRatio(float speedRatio, bool cacheCmd = true /* Metadata: 0x00AFD1C1 */) {} // 0x00000001814A2D50-0x00000001814A2E30
		// [XID] // 0x00000001896C17C0-0x00000001896C17E0
		public virtual void ResetWalkSpeedRatio() {} // 0x00000001814A1A20-0x00000001814A1AD0
		[BlackList] // 0x00000001896C8EE0-0x00000001896C8F20
		// [XID] // 0x00000001896C8EE0-0x00000001896C8F20
		public virtual void StandbyNoCmd(bool resetRoute = true /* Metadata: 0x00AFD1C2 */) {} // 0x00000001814A3070-0x00000001814A3130
		// [XID] // 0x00000001896D32E0-0x00000001896D3300
		public virtual void ResumeMove() {} // 0x00000001814A1AD0-0x00000001814A1B80
		// [XID] // 0x00000001896DAE80-0x00000001896DAEA0
		public virtual void SitOnChair(int freeStyleType) {} // 0x00000001814A2E30-0x00000001814A2EF0
		// [XID] // 0x00000001896E2680-0x00000001896E26A0
		public virtual void StandFromChair(float? angle = default) {} // 0x00000001814A2FB0-0x00000001814A3070
		// [XID] // 0x00000001896E9BA0-0x00000001896E9BC0
		public virtual void StartCall(Action<ILuaActor> call) {} // 0x00000001814A31F0-0x00000001814A32B0
		// [XID] // 0x00000001896F0D60-0x00000001896F0D80
		public bool IsInIdle() => default; // 0x00000001814A0DE0-0x00000001814A0EA0
		// [XID] // 0x00000001896F85E0-0x00000001896F8600
		public bool IsTalking() => default; // 0x00000001814A0EA0-0x00000001814A0F70
		// [XID] // 0x00000001896FFF40-0x00000001896FFF60
		public int GetCurFreeStyle() => default; // 0x000000018149F730-0x000000018149F840
		// [XID] // 0x0000000189707600-0x0000000189707620
		public override void PlayAudio(string evtName) {} // 0x00000001814A17F0-0x00000001814A18B0
		// [XID] // 0x00000001898B5DF0-0x00000001898B5E10
		public void PerformDither(bool enable, float duration, Action<ILuaActor> finishCallback, bool ensureCallBack = false /* Metadata: 0x00AFD1C3 */) {} // 0x00000001814A15E0-0x00000001814A17F0
		// [XID] // 0x0000000189716360-0x0000000189716380
		private void OnDitherFinish() {} // 0x00000001814A1440-0x00000001814A1530
		// [XID] // 0x00000001898BD780-0x00000001898BD7A0
		private void EnsureDitherCallback() {} // 0x000000018149F680-0x000000018149F730
		// [XID] // 0x0000000189725300-0x0000000189725320
		public void StopCurDither(bool enable) {} // 0x00000001814A32B0-0x00000001814A33A0
		// [XID] // 0x000000018972C940-0x000000018972C960
		private void ClearCurDither() {} // 0x000000018149DF50-0x000000018149E060
		// [XID] // 0x0000000189734030-0x0000000189734050
		public void SetVisible(bool value) {} // 0x00000001814A2B80-0x00000001814A2D50
		// [XID] // 0x000000018973B7D0-0x000000018973B7F0
		public void SpawnAttach(string attachName) {} // 0x00000001814A2EF0-0x00000001814A2FB0
		// [XID] // 0x0000000189743260-0x0000000189743280
		public void UnspawnAttach(string attachName) {} // 0x00000001814A4160-0x00000001814A4220
		// [XID] // 0x000000018974AEC0-0x000000018974AEE0
		public void EnableAI(bool value) {} // 0x000000018149F4C0-0x000000018149F5A0
		// [XID] // 0x0000000189751EF0-0x0000000189751F10
		public void EnableInteraction(bool value) {} // 0x000000018149F5A0-0x000000018149F680
		// [XID] // 0x00000001897595C0-0x00000001897595E0
		public override void HandleStartActor() {} // 0x00000001814A03C0-0x00000001814A0470
		// [XID] // 0x0000000189761190-0x00000001897611B0
		public override void HandleExternalRecover() {} // 0x00000001814A0310-0x00000001814A03C0
		// [XID] // 0x00000001897684E0-0x0000000189768500
		public virtual void InitEntity(BaseEntity entity) {} // 0x00000001814A06C0-0x00000001814A0890
		// [XID] // 0x000000018976FB70-0x000000018976FB90
		public override void ClearActor() {} // 0x000000018149DE90-0x000000018149DF50
		// [XID] // 0x0000000189777370-0x0000000189777390
		protected virtual void InitWithEntity() {} // 0x00000001814A0940-0x00000001814A09E0
		// [XID] // 0x000000018977EB60-0x000000018977EB80
		public override bool IsActorStart() => default; // 0x00000001814A0B80-0x00000001814A0C40
		// [XID] // 0x0000000189786340-0x0000000189786360
		public override void TryStartActor() {} // 0x00000001814A3540-0x00000001814A3680
		[BlackList] // 0x000000018978D950-0x000000018978D990
		// [XID] // 0x000000018978D950-0x000000018978D990
		public override void OnAppear() {} // 0x00000001814A1030-0x00000001814A1170
		[BlackList] // 0x00000001897981E0-0x0000000189798220
		// [XID] // 0x00000001897981E0-0x0000000189798220
		public override void OnDisappear() {} // 0x00000001814A12C0-0x00000001814A1440
		// [XID] // 0x00000001897A2DC0-0x00000001897A2DE0
		public override void Destroy(bool isActorOnly) {} // 0x000000018149EB80-0x000000018149EC90
		// [XID] // 0x00000001897AA400-0x00000001897AA420
		protected virtual void DestroyEntity() {} // 0x000000018149E330-0x000000018149E5F0
		// [XID] // 0x00000001897B1E70-0x00000001897B1E90
		protected override void ClearActorEvent() {} // 0x000000018149DDD0-0x000000018149DE90
		// [XID] // 0x00000001897B98D0-0x00000001897B98F0
		public void DestroyWithDither(bool isActorOnly, float duration) {} // 0x000000018149E930-0x000000018149EB80
		// [XID] // 0x00000001897C18B0-0x00000001897C18D0
		protected void CallDisappearFinishCallback() {} // 0x000000018149DA90-0x000000018149DB70
		// [XID] // 0x00000001897C9300-0x00000001897C9320
		public void Disappear(Action<ILuaActor> finishCallback) {} // 0x000000018149EC90-0x000000018149F050
		// [XID] // 0x00000001897D0930-0x00000001897D0950
		private void DoDisappear() {} // 0x000000018149F130-0x000000018149F210
		// [XID] // 0x00000001897EE180-0x00000001897EE1A0
		public void DestroyWithDisappear(bool isActorOnly, Action<ILuaActor> finishCallback) {} // 0x000000018149E5F0-0x000000018149E930
		// [XID] // 0x00000001897DF7B0-0x00000001897DF7D0
		private void UnRegistDisappearCallBack() {} // 0x00000001814A4050-0x00000001814A4160
		// [XID] // 0x00000001897E6F90-0x00000001897E6FB0
		private void OnDestroyDisappearStateChanged(EvtAnimatorStateChanged evt) {} // 0x00000001814A1170-0x00000001814A12C0
		// [XID] // 0x00000001897F5930-0x00000001897F5950
		private void DoDisappearDestroy(bool isActorOnly) {} // 0x000000018149F050-0x000000018149F130
		// [XID] // 0x00000001897F6320-0x00000001897F6340
		private void InterruptDisappearDestroy() {} // 0x00000001814A09E0-0x00000001814A0B80
		// [XID] // 0x00000001897FDA00-0x00000001897FDA20
		public override void OnReuse() {} // 0x00000001814A1530-0x00000001814A15E0
		// [XID] // 0x0000000189805230-0x0000000189805250
		public void SetActive(bool active) {} // 0x00000001814A2020-0x00000001814A2100
		// [XID] // 0x000000018980C790-0x000000018980C7B0
		public override void ClearInfo() {} // 0x000000018149E060-0x000000018149E1B0
		// [XID] // 0x0000000189813F00-0x0000000189813F20
		public void SetLocalEntityDist(float dist) {} // 0x00000001814A2300-0x00000001814A23C0
		[BlackList] // 0x000000018981BA80-0x000000018981BAC0
		// [XID] // 0x000000018981BA80-0x000000018981BAC0
		public void ClearVelocity() {} // 0x000000018149E1B0-0x000000018149E330
	}
}
