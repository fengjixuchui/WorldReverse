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
using MihoyoOptimization;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B018C0-0x0000000189B01900
	[RecycleType] // 0x0000000189B018C0-0x0000000189B01900
	public class BaseActor : LuaLogic, IAutoAllocRecycle // TypeDefIndex: 20010
	{
		// Fields
		protected string _alias; // 0x30
		protected string _metaPath; // 0x38
		protected ILuaActor _luaActor; // 0x40
		protected LuaAbilityParam _luaAbilityParam; // 0x48
		protected ActorManager _actMgr; // 0x50
		protected bool _isPaused; // 0x58
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		protected List<Queue<LuaTask>> _taskQueues; // 0x60
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		protected List<LuaTask> _runningTaskList; // 0x68
		protected bool _isDestroied; // 0x70
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		protected Dictionary<int, Coroutine> _coroutineDic; // 0x78
		protected int _coroutinueId; // 0x80
		protected bool _isDayRegistered; // 0x84
		protected Action<ILuaActor> _onLuaActorDayTime; // 0x88
		protected bool _isNightRegistered; // 0x90
		protected Action<ILuaActor> _onLuaActorNightTime; // 0x98
		protected bool _isWeatherRegistered; // 0xA0
		protected bool _isHourRegistered; // 0xB0
		protected Action<ILuaActor, int> _onLuaHour; // 0xB8
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		private Dictionary<string, List<LuaTask>> _tag2Task; // 0xC0
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		private Dictionary<string, int> _tagTaskHasPaused; // 0xC8
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		private Dictionary<string, Action<ILuaActor>> _tag2PauseCallback; // 0xD0
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		private Dictionary<string, Action<ILuaActor>> _tag2ResumeCallback; // 0xD8
	
		// Properties
		public string alias { /* [XID] */ /* 0x0000000189B330B0-0x0000000189B330D0 */ get => default; /* [XID] */ /* 0x0000000189A90AB0-0x0000000189A90AD0 */ set {} } // 0x0000000182DD52D0-0x0000000182DD5370 0x0000000182DD5C10-0x0000000182DD5CC0
		public string metaPath { /* [XID] */ /* 0x0000000189A1F770-0x0000000189A1F790 */ get => default; /* [XID] */ /* 0x0000000189A9F590-0x0000000189A9F5B0 */ set {} } // 0x0000000182DD5790-0x0000000182DD5830 0x0000000182DD5CC0-0x0000000182DD5D70
		public ILuaActor luaActor { /* [XID] */ /* 0x00000001898CC4C0-0x00000001898CC4E0 */ get => default; } // 0x0000000182DD56F0-0x0000000182DD5790 
		public bool isAutoStart { /* [XID] */ /* 0x0000000189AB5D60-0x0000000189AB5D80 */ get => default; } // 0x0000000182DD54F0-0x0000000182DD55B0 
		public ActorManager actMgr { /* [XID] */ /* 0x0000000189B1ABA0-0x0000000189B1ABC0 */ get => default; } // 0x0000000182DD51F0-0x0000000182DD52D0 
		public bool isPaused { /* [XID] */ /* 0x0000000189B3E370-0x0000000189B3E390 */ get => default; } // 0x0000000182DD5650-0x0000000182DD56F0 
		public virtual BaseEntity entity { /* [XID] */ /* 0x0000000189B90500-0x0000000189B90520 */ get => default; } // 0x0000000182DD5450-0x0000000182DD54F0 
		public uint configID { /* [XID] */ /* 0x00000001896A5340-0x00000001896A5360 */ get => default; } // 0x0000000182DD5370-0x0000000182DD5450 
		public uint questID { /* [XID] */ /* 0x0000000189B9ED90-0x0000000189B9EDB0 */ get => default; } // 0x0000000182DD58F0-0x0000000182DD59D0 
		public bool isDestroied { /* [XID] */ /* 0x00000001895EEE60-0x00000001895EEE80 */ get => default; } // 0x0000000182DD55B0-0x0000000182DD5650 
		protected int newCoroutinueId { /* [XID] */ /* 0x000000018969BAF0-0x000000018969BB10 */ get => default; } // 0x0000000182DD5830-0x0000000182DD58F0 
	
		// Events
		public event Action<ILuaActor, ActorEvent> OnActorEvent;
		protected event Action<ILuaActor, int> _onSelfWeatherChanged;
	
		// Nested types
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void CoCallback1Param(ILuaActor luaActor, object param0); // TypeDefIndex: 20011; 0x0000000182DD7010-0x0000000182DD72C0
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void CoCallback2Param(ILuaActor luaActor, object param0, object param1); // TypeDefIndex: 20012; 0x0000000182DD7450-0x0000000182DD7740
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void CoCallback3Param(ILuaActor luaActor, object param0, object param1, object param2); // TypeDefIndex: 20013; 0x0000000182DD78E0-0x0000000182DD7C40
	
		// Constructors
		public BaseActor() {} // 0x0000000182DD4EF0-0x0000000182DD4FB0
	
		// Methods
		[BlackList] // 0x0000000189A43DF0-0x0000000189A43E30
		// [XID] // 0x0000000189A43DF0-0x0000000189A43E30
		public virtual void AutoAllocTypeFields() {} // 0x0000000182DC1160-0x0000000182DC12B0
		[BlackList] // 0x0000000189A4E370-0x0000000189A4E3B0
		// [XID] // 0x0000000189A4E370-0x0000000189A4E3B0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000182DC12B0-0x0000000182DC1450
		[BlackList] // 0x0000000189A589E0-0x0000000189A58A20
		// [XID] // 0x0000000189A589E0-0x0000000189A58A20
		public virtual void ReturnToObjectPool() {} // 0x0000000182DCDF10-0x0000000182DCDFB0
		// [XID] // 0x0000000189A63550-0x0000000189A63570
		public virtual void OnPoolAllocated() {} // 0x0000000182DC9F50-0x0000000182DCA000
		// [XID] // 0x0000000189A6AFD0-0x0000000189A6AFF0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000182DC9AE0-0x0000000182DC9B80
		// [XID] // 0x0000000189ABB7F0-0x0000000189ABB810
		public void CallOnActorEvent(ActorEvent actorEvt) {} // 0x0000000182DC2840-0x0000000182DC2910
		// [XID] // 0x0000000189AAE510-0x0000000189AAE530
		public void InitLuaActor(ILuaActor luaActor) {} // 0x0000000182DC8C70-0x0000000182DC8D20
		[BlackList] // 0x0000000189ABD8B0-0x0000000189ABD8F0
		// [XID] // 0x0000000189ABD8B0-0x0000000189ABD8F0
		public void CallOnAbility(CallLuaTask config) {} // 0x0000000182DC2720-0x0000000182DC2840
		// [XID] // 0x00000001899DF880-0x00000001899DF8A0
		public virtual bool IsValid() => default; // 0x0000000182DC94A0-0x0000000182DC9550
		// [XID] // 0x0000000189ACF850-0x0000000189ACF870
		public virtual bool IsEnabled() => default; // 0x0000000182DC9000-0x0000000182DC90B0
		// [XID] // 0x0000000189AD7600-0x0000000189AD7620
		public virtual void HandleStartActor() {} // 0x0000000182DC84C0-0x0000000182DC8560
		// [XID] // 0x0000000189ADF070-0x0000000189ADF090
		public virtual void HandleExternalRecover() {} // 0x0000000182DC8420-0x0000000182DC84C0
		// [XID] // 0x0000000189AE6920-0x0000000189AE6940
		public virtual void AddDailyConfigData(ILuaActorDailyConfigData data) {} // 0x0000000182DC0D50-0x0000000182DC0E00
		// [XID] // 0x0000000189AEE300-0x0000000189AEE320
		public virtual void AddTitleConfigData(ILuaActorTitleConfigData data) {} // 0x0000000182DC10B0-0x0000000182DC1160
		// [XID] // 0x0000000189B52B40-0x0000000189B52B60
		public virtual string GetTitle() => default; // 0x0000000182DC8380-0x0000000182DC8420
		// [XID] // 0x0000000189AFCDF0-0x0000000189AFCE10
		public virtual void SetActionPointWeight(int actionPointType, float weight) {} // 0x0000000182DCE840-0x0000000182DCE900
		// [XID] // 0x0000000189B04540-0x0000000189B04560
		public virtual void StartDailyFSM() {} // 0x0000000182DD1D70-0x0000000182DD1E10
		// [XID] // 0x00000001898C7FE0-0x00000001898C8000
		public virtual void SetEntityBan(bool isBan) {} // 0x0000000182DCEB20-0x0000000182DCEBD0
		// [XID] // 0x0000000189B13480-0x0000000189B134A0
		public virtual void ForceRefreshDaily() {} // 0x0000000182DC6E50-0x0000000182DC6EF0
		[BlackList] // 0x0000000189B22150-0x0000000189B22190
		// [XID] // 0x0000000189B22150-0x0000000189B22190
		public virtual void OnAppear() {} // 0x0000000182DC9A40-0x0000000182DC9AE0
		[BlackList] // 0x0000000189B2C6B0-0x0000000189B2C6F0
		// [XID] // 0x0000000189B2C6B0-0x0000000189B2C6F0
		public virtual void OnDisappear() {} // 0x0000000182DC9C50-0x0000000182DC9CF0
		// [XID] // 0x0000000189B36BF0-0x0000000189B36C10
		public virtual bool IsActorStart() => default; // 0x0000000182DC8E80-0x0000000182DC8F20
		// [XID] // 0x0000000189A7F140-0x0000000189A7F160
		public void OnPause() {} // 0x0000000182DC9EA0-0x0000000182DC9F50
		// [XID] // 0x0000000189A9D3E0-0x0000000189A9D400
		public void OnResume() {} // 0x0000000182DCA0A0-0x0000000182DCA150
		// [XID] // 0x0000000189B54DB0-0x0000000189B54DD0
		public Queue<LuaTask> GetTaskQueue(int taskQueueID, bool forceGet = true /* Metadata: 0x00AFD171 */) => default; // 0x0000000182DC80E0-0x0000000182DC8270
		// [XID] // 0x0000000189B5C770-0x0000000189B5C790
		public void AddTask(LuaTask task) {} // 0x0000000182DC0FB0-0x0000000182DC10B0
		// [XID] // 0x0000000189B63DD0-0x0000000189B63DF0
		public void RemoveTask(int taskQueueID) {} // 0x0000000182DCD0F0-0x0000000182DCD1E0
		// [XID] // 0x0000000189B6B560-0x0000000189B6B580
		public void ClearTaskQueue(int taskQueueID) {} // 0x0000000182DC33D0-0x0000000182DC34E0
		// [XID] // 0x0000000189B72B70-0x0000000189B72B90
		public void ClearAllTask() {} // 0x0000000182DC2DB0-0x0000000182DC2E60
		// [XID] // 0x0000000189B7A150-0x0000000189B7A170
		public virtual void ClearActor() {} // 0x0000000182DC2C00-0x0000000182DC2CA0
		// [XID] // 0x0000000189B81870-0x0000000189B81890
		public virtual void ClearInfo() {} // 0x0000000182DC2F00-0x0000000182DC2FA0
		// [XID] // 0x0000000189B34830-0x0000000189B34850
		public virtual void OnReuse() {} // 0x0000000182DCA150-0x0000000182DCA1F0
		// [XID] // 0x0000000189B70A40-0x0000000189B70A60
		public LuaTask GetRuningTask(int taskQueueID) => default; // 0x0000000182DC7D40-0x0000000182DC7E30
		// [XID] // 0x0000000189BAD900-0x0000000189BAD920
		public void ClearRunningTask(int taskQueueID) {} // 0x0000000182DC30C0-0x0000000182DC3200
		// [XID] // 0x0000000189BB50C0-0x0000000189BB50E0
		public void AddRunningTask(LuaTask task) {} // 0x0000000182DC0E00-0x0000000182DC0FB0
		// [XID] // 0x0000000189BBC740-0x0000000189BBC760
		public void CheckTaskShouldRun() {} // 0x0000000182DC29F0-0x0000000182DC2B60
		// [XID] // 0x0000000189A86CC0-0x0000000189A86CE0
		protected void PauseTask() {} // 0x0000000182DCAE90-0x0000000182DCAFB0
		// [XID] // 0x0000000189BCBDC0-0x0000000189BCBDE0
		protected void ResumeTask() {} // 0x0000000182DCDDF0-0x0000000182DCDF10
		// [XID] // 0x0000000189BD32F0-0x0000000189BD3310
		public void TickTask() {} // 0x0000000182DD28C0-0x0000000182DD2A40
		// [XID] // 0x00000001897F2C70-0x00000001897F2C90
		public virtual void StartActor() {} // 0x0000000182DD1CA0-0x0000000182DD1D70
		// [XID] // 0x00000001895E7560-0x00000001895E7580
		public override void Tick() {} // 0x0000000182DD2A40-0x0000000182DD2B20
		// [XID] // 0x00000001895F6860-0x00000001895F6880
		public virtual void ClearCmd() {} // 0x0000000182DC2E60-0x0000000182DC2F00
		// [XID] // 0x00000001895FDC80-0x00000001895FDCA0
		public virtual void Destroy(bool isActorOnly) {} // 0x0000000182DC56A0-0x0000000182DC5810
		// [XID] // 0x0000000189605430-0x0000000189605450
		public virtual void PostDestroy() {} // 0x0000000182DCBFD0-0x0000000182DCC0A0
		// [XID] // 0x000000018960CE40-0x000000018960CE60
		protected virtual void ClearActorEvent() {} // 0x0000000182DC2B60-0x0000000182DC2C00
		// [XID] // 0x0000000189614410-0x0000000189614430
		protected virtual void DestroyListener() {} // 0x0000000182DC4D00-0x0000000182DC4DC0
		// [XID] // 0x0000000189AFF5D0-0x0000000189AFF5F0
		protected virtual void DestroyTasks(bool clearBackGround = true /* Metadata: 0x00AFD172 */) {} // 0x0000000182DC53A0-0x0000000182DC56A0
		// [XID] // 0x0000000189A77BE0-0x0000000189A77C00
		public void OnEvent(ActorEvent evt) {} // 0x0000000182DC9DA0-0x0000000182DC9EA0
		// [XID] // 0x0000000189B16E00-0x0000000189B16E20
		public virtual void TryStartActor() {} // 0x0000000182DD3FD0-0x0000000182DD4070
		[BlackList] // 0x0000000189632300-0x0000000189632340
		// [XID] // 0x0000000189632300-0x0000000189632340
		public virtual void TryClearOnSwitch() {} // 0x0000000182DD3900-0x0000000182DD39B0
		[BlackList] // 0x000000018963CFD0-0x000000018963D010
		// [XID] // 0x000000018963CFD0-0x000000018963D010
		public virtual bool OnEntityEventTrigger(BaseEvent e) => default; // 0x0000000182DC9CF0-0x0000000182DC9DA0
		[BlackList] // 0x00000001896474B0-0x00000001896474F0
		// [XID] // 0x00000001896474B0-0x00000001896474F0
		public virtual void OnResetFreeStyleTrigger() {} // 0x0000000182DCA000-0x0000000182DCA0A0
		[BlackList] // 0x0000000189651BA0-0x0000000189651BE0
		// [XID] // 0x0000000189651BA0-0x0000000189651BE0
		public virtual void OnCollisionEnterTrigger(BaseEntity collider, ActorCollisionInfo colInfo) {} // 0x0000000182DC9B80-0x0000000182DC9C50
		[BlackList] // 0x000000018965C3D0-0x000000018965C410
		// [XID] // 0x000000018965C3D0-0x000000018965C410
		public virtual void OnStartInteractionTrigger(bool stayFreeStyle) {} // 0x0000000182DCA720-0x0000000182DCA7D0
		[BlackList] // 0x0000000189666B10-0x0000000189666B50
		// [XID] // 0x0000000189666B10-0x0000000189666B50
		public virtual void OnStopInteractionTrigger(bool rewindFreeStyle = false /* Metadata: 0x00AFD173 */) {} // 0x0000000182DCA7D0-0x0000000182DCA880
		[BlackList] // 0x0000000189671980-0x00000001896719C0
		// [XID] // 0x0000000189671980-0x00000001896719C0
		public virtual void OnScriptNotifyTrigger(int eventType) {} // 0x0000000182DCA1F0-0x0000000182DCA2A0
		[BlackList] // 0x000000018967C0C0-0x000000018967C100
		// [XID] // 0x000000018967C0C0-0x000000018967C100
		public virtual void OnScriptSitOnChair(int freeStyleType) {} // 0x0000000182DCA2A0-0x0000000182DCA350
		[BlackList] // 0x0000000189686630-0x0000000189686670
		// [XID] // 0x0000000189686630-0x0000000189686670
		public virtual void OnScriptStandFromChair(float? standDirection = default) {} // 0x0000000182DCA350-0x0000000182DCA3F0
		[BlackList] // 0x0000000189691760-0x00000001896917A0
		// [XID] // 0x0000000189691760-0x00000001896917A0
		public virtual bool IsSitting() => default; // 0x0000000182DC9300-0x0000000182DC93A0
		// [XID] // 0x00000001896A3160-0x00000001896A3180
		protected int AddCoroutine(int cId, Coroutine co) => default; // 0x0000000182DC0C70-0x0000000182DC0D50
		// [XID] // 0x00000001896AA5D0-0x00000001896AA5F0
		protected int RemoveCoroutine(int cId) => default; // 0x0000000182DCD020-0x0000000182DCD0F0
		// [XID] // 0x0000000189A68F90-0x0000000189A68FB0
		public void StopAllCoroutine() {} // 0x0000000182DD1E10-0x0000000182DD2040
		[DebuggerHidden] // 0x00000001896B8F50-0x00000001896B8F90
		// [XID] // 0x00000001896B8F50-0x00000001896B8F90
		protected IEnumerator CoBody(int cId, object to_yield, Action callback) => default; // 0x0000000182DC3AC0-0x0000000182DC3C10
		// [XID] // 0x00000001896C3220-0x00000001896C3240
		public int CoroutineCall(float delayTime, Action callback) => default; // 0x0000000182DC4160-0x0000000182DC42E0
		[DebuggerHidden] // 0x00000001896CA7B0-0x00000001896CA7F0
		// [XID] // 0x00000001896CA7B0-0x00000001896CA7F0
		protected IEnumerator CoBody1Param(int cId, object to_yield, CoCallback1Param callback, ILuaActor luaActor, object param0) => default; // 0x0000000182DC35D0-0x0000000182DC3760
		// [XID] // 0x00000001896D4E60-0x00000001896D4E80
		public int CoroutineCall1Param(float delayTime, CoCallback1Param callback, ILuaActor luaActor, object param0) => default; // 0x0000000182DC3C10-0x0000000182DC3DC0
		[DebuggerHidden] // 0x00000001896DC520-0x00000001896DC560
		// [XID] // 0x00000001896DC520-0x00000001896DC560
		protected IEnumerator CoBody2Param(int cId, object to_yield, CoCallback2Param callback, ILuaActor luaActor, object param0, object param1) => default; // 0x0000000182DC3760-0x0000000182DC3900
		// [XID] // 0x00000001896E6A40-0x00000001896E6A60
		public int CoroutineCall2Param(float delayTime, CoCallback2Param callback, ILuaActor luaActor, object param0, object param1) => default; // 0x0000000182DC3DC0-0x0000000182DC3F80
		[DebuggerHidden] // 0x00000001896EE010-0x00000001896EE050
		// [XID] // 0x00000001896EE010-0x00000001896EE050
		protected IEnumerator CoBody3Param(int cId, object to_yield, CoCallback3Param callback, ILuaActor luaActor, object param0, object param1, object param2) => default; // 0x0000000182DC3900-0x0000000182DC3AC0
		// [XID] // 0x00000001896F8600-0x00000001896F8620
		public int CoroutineCall3Param(float delayTime, CoCallback3Param callback, ILuaActor luaActor, object param0, object param1, object param2) => default; // 0x0000000182DC3F80-0x0000000182DC4160
		// [XID] // 0x00000001896FFF60-0x00000001896FFF80
		public void StopCoroutine(int cId) {} // 0x0000000182DD2040-0x0000000182DD2190
		// [XID] // 0x0000000189707620-0x0000000189707640
		public void SpawnMonster(uint configID, uint level, Vector3 bornPos, Vector3 bornEuler, float scale, uint sceneID, string alias, uint questId, uint roomId) {} // 0x0000000182DD1A10-0x0000000182DD1CA0
		// [XID] // 0x000000018970EF20-0x000000018970EF40
		public void SpawnLocalMonster(uint configID, uint level, Vector3 bornPos, float yaw, uint dropID, float scale, string alias, bool isElite, List<uint> affixList) {} // 0x0000000182DD1800-0x0000000182DD1A10
		// [XID] // 0x0000000189716380-0x00000001897163A0
		public void SpawnItem(uint configID, Vector3 bornPos, Vector3 bornEuler, uint sceneID, string alias, int bornType, uint questId, uint roomId) {} // 0x0000000182DD1220-0x0000000182DD1490
		// [XID] // 0x000000018971DE20-0x000000018971DE40
		public void SpawnLocalItem(uint configID, Vector3 bornPos, float yaw, string alias) {} // 0x0000000182DD1630-0x0000000182DD1800
		// [XID] // 0x0000000189725320-0x0000000189725340
		public void SpawnGadget(uint configID, Vector3 bornPos, Vector3 bornEuler, uint sceneID, string alias, uint questId, uint roomId) {} // 0x0000000182DD0FC0-0x0000000182DD1220
		// [XID] // 0x000000018972C960-0x000000018972C980
		public void SpawnChest(uint configID, Vector3 bornPos, Vector3 bornEuler, uint sceneID, string alias, uint chestDropId, bool isShowCutscene, uint questId, uint roomId) {} // 0x0000000182DD0D30-0x0000000182DD0FC0
		// [XID] // 0x0000000189734050-0x0000000189734070
		public void SpawnLocalGadget(uint configID, Vector3 bornPos, Vector3 bornEuler, string alias = "" /* Metadata: 0x00AFD174 */) {} // 0x0000000182DD1490-0x0000000182DD1630
		// [XID] // 0x000000018973B7F0-0x000000018973B810
		public void UnSpawnEntity(uint runtimeID, string alias, uint sceneId) {} // 0x0000000182DD4440-0x0000000182DD45A0
		// [XID] // 0x0000000189743280-0x00000001897432A0
		public void PlayCutsceneIndex(uint cutsceneIndex, Action<ILuaActor> finishCallback, Action<ILuaActor> startCallback, Action<ILuaActor> destroyCallback, bool syncLoad, uint mainQuestId) {} // 0x0000000182DCB230-0x0000000182DCB3B0
		// [XID] // 0x000000018974AEE0-0x000000018974AF00
		public void PlayCutscene(ConfigTimeline cfg, Action<ILuaActor> finishCallback, Action<ILuaActor> startCallback, Action<ILuaActor> destroyCallback, uint mainQuestId) {} // 0x0000000182DCB3B0-0x0000000182DCB510
		// [XID] // 0x0000000189751F10-0x0000000189751F30
		public void PlayFreeCutscene(ConfigTimeline cfg, ILuaActor luaActor, Action<ILuaActor> finishCallback, Action<ILuaActor> startCallback) {} // 0x0000000182DCB940-0x0000000182DCBA80
		// [XID] // 0x00000001897595E0-0x0000000189759600
		public void StopFreeCutscene(ConfigTimeline cfg, bool force) {} // 0x0000000182DD2370-0x0000000182DD2480
		// [XID] // 0x00000001897611B0-0x00000001897611D0
		protected void RegisterDailyCallback() {} // 0x0000000182DCC260-0x0000000182DCC580
		// [XID] // 0x00000001899A6CF0-0x00000001899A6D10
		protected virtual void OnSelfDayTime() {} // 0x0000000182DCA3F0-0x0000000182DCA4B0
		// [XID] // 0x000000018976FB90-0x000000018976FBB0
		public void RegisterSelfDayTime(Action<ILuaActor> dayCallback) {} // 0x0000000182DCC580-0x0000000182DCC740
		// [XID] // 0x0000000189777390-0x00000001897773B0
		public void UnregisterSelfDayTime(Action<ILuaActor> dayCallback) {} // 0x0000000182DD45A0-0x0000000182DD4690
		// [XID] // 0x000000018977EB80-0x000000018977EBA0
		protected void DestroySelfDayTime() {} // 0x0000000182DC4DC0-0x0000000182DC4F30
		// [XID] // 0x00000001898983E0-0x0000000189898400
		protected virtual void OnSelfNightTime() {} // 0x0000000182DCA580-0x0000000182DCA640
		// [XID] // 0x000000018978D990-0x000000018978D9B0
		public void RegisterSelfNightTime(Action<ILuaActor> nightCallback) {} // 0x0000000182DCC900-0x0000000182DCCAC0
		// [XID] // 0x0000000189794E40-0x0000000189794E60
		public void UnregisterSelfNightTime(Action<ILuaActor> nightCallback) {} // 0x0000000182DD4780-0x0000000182DD4870
		// [XID] // 0x0000000189A310A0-0x0000000189A310C0
		protected void DestroySelfNightTime() {} // 0x0000000182DC50A0-0x0000000182DC5210
		// [XID] // 0x00000001897A4610-0x00000001897A4630
		public bool GetIsDay() => default; // 0x0000000182DC75B0-0x0000000182DC7690
		// [XID] // 0x00000001897E0770-0x00000001897E0790
		protected virtual void OnSelfWeatherChange(EnviroWeatherPreset weatherType) {} // 0x0000000182DCA640-0x0000000182DCA720
		// [XID] // 0x00000001897C31F0-0x00000001897C3210
		public void RegisterSelfWeatherChange(Action<ILuaActor, int> weatherCallback) {} // 0x0000000182DCCAC0-0x0000000182DCCC80
		// [XID] // 0x00000001897CA9D0-0x00000001897CA9F0
		public void UnregisterSelfWeatherChange(Action<ILuaActor, int> weatherCallback) {} // 0x0000000182DD4870-0x0000000182DD4920
		// [XID] // 0x00000001896E3340-0x00000001896E3360
		protected void DestroySelfWeatherChange() {} // 0x0000000182DC5210-0x0000000182DC53A0
		// [XID] // 0x00000001896EA860-0x00000001896EA880
		protected virtual void OnSelfHour(int hour) {} // 0x0000000182DCA4B0-0x0000000182DCA580
		// [XID] // 0x00000001897E1120-0x00000001897E1140
		public void RegisterSelfHour(Action<ILuaActor, int> hourCallback) {} // 0x0000000182DCC740-0x0000000182DCC900
		// [XID] // 0x00000001897E8930-0x00000001897E8950
		public void UnregisterSelfHour(Action<ILuaActor, int> hourCallback) {} // 0x0000000182DD4690-0x0000000182DD4780
		// [XID] // 0x00000001897F0500-0x00000001897F0520
		protected void DestroySelfHour() {} // 0x0000000182DC4F30-0x0000000182DC50A0
		// [XID] // 0x00000001897F7C70-0x00000001897F7C90
		public float GetLevelTime() => default; // 0x0000000182DC7690-0x0000000182DC7780
		// [XID] // 0x00000001897FF2F0-0x00000001897FF310
		public void CountDownUIStart(float duration, float warningLimit, float readyDuration, Action callback = null) {} // 0x0000000182DC42E0-0x0000000182DC44B0
		// [XID] // 0x0000000189806AB0-0x0000000189806AD0
		public void CountDownUITerminate() {} // 0x0000000182DC44B0-0x0000000182DC45F0
		// [XID] // 0x000000018980E1F0-0x000000018980E210
		public void CountNumUIStart() {} // 0x0000000182DC45F0-0x0000000182DC4730
		// [XID] // 0x0000000189815950-0x0000000189815970
		public void CountNumUIUpdate(int num) {} // 0x0000000182DC4870-0x0000000182DC49E0
		// [XID] // 0x000000018981D2C0-0x000000018981D2E0
		public void CountNumUITerminate() {} // 0x0000000182DC4730-0x0000000182DC4870
		// [XID] // 0x0000000189824780-0x00000001898247A0
		public void ShowQuestQuit(uint questID) {} // 0x0000000182DD0720-0x0000000182DD0890
		// [XID] // 0x000000018982C250-0x000000018982C270
		public void HideQuestQuit() {} // 0x0000000182DC8B30-0x0000000182DC8C70
		// [XID] // 0x0000000189833700-0x0000000189833720
		public virtual void PlayAudio(string evtName) {} // 0x0000000182DCB180-0x0000000182DCB230
		// [XID] // 0x000000018983AC20-0x000000018983AC40
		public virtual void PlayAudioState(string stateGroup, string state) {} // 0x0000000182DCAFB0-0x0000000182DCB180
		// [XID] // 0x0000000189842280-0x00000001898422A0
		public virtual void PlayEffect(string patternName, Vector3 pos, Vector3 euler, Vector3 scale, Transform followTrans) {} // 0x0000000182DCB510-0x0000000182DCB850
		// [XID] // 0x00000001898496A0-0x00000001898496C0
		public void SetEntityMaterialPropValue(uint entityId, int propNameIndex, float value) {} // 0x0000000182DCEBD0-0x0000000182DCED90
		// [XID] // 0x0000000189850ED0-0x0000000189850EF0
		public void EnablePlayerInput(bool enable, bool hideUI) {} // 0x0000000182DC5950-0x0000000182DC5B60
		// [XID] // 0x0000000189858360-0x0000000189858380
		public void ShowPage(string pageName) {} // 0x0000000182DD00D0-0x0000000182DD02F0
		// [XID] // 0x000000018985F3D0-0x000000018985F3F0
		public bool InvokePageFunction(string funcName) => default; // 0x0000000182DC8D20-0x0000000182DC8E80
		// [XID] // 0x0000000189866BB0-0x0000000189866BD0
		public void BackPage(string pageName = null) {} // 0x0000000182DC1BF0-0x0000000182DC1D10
		// [XID] // 0x000000018986E490-0x000000018986E4B0
		public void ShowDragonSpinePage(int pageIndex) {} // 0x0000000182DCFC60-0x0000000182DCFE20
		// [XID] // 0x00000001898758C0-0x00000001898758E0
		public void ShowFleurFairMiniGame(int pageIndex) {} // 0x0000000182DCFF40-0x0000000182DD00D0
		// [XID] // 0x000000018987D450-0x000000018987D470
		public void ShowActivityAsterPage() {} // 0x0000000182DCF2D0-0x0000000182DCF430
		// [XID] // 0x0000000189884370-0x0000000189884390
		public void ShowActivityMimiTomoPage() {} // 0x0000000182DCF430-0x0000000182DCF590
		// [XID] // 0x000000018988BB00-0x000000018988BB20
		public void ShowTeamPage(bool showExitDialog, Action callback = null, uint showTutorialId = 0 /* Metadata: 0x00AFD178 */) {} // 0x0000000182DD09A0-0x0000000182DD0AB0
		// [XID] // 0x0000000189893190-0x00000001898931B0
		public void ShowBargainPage(uint bargainID) {} // 0x0000000182DCF590-0x0000000182DCF7B0
		// [XID] // 0x000000018989A8B0-0x000000018989A8D0
		public void BargainFixPrice(uint bargainID) {} // 0x0000000182DC1E40-0x0000000182DC20D0
		// [XID] // 0x00000001898A1B60-0x00000001898A1B80
		public void ShowQuestLikingBar(uint questID, uint npcID, float fillValue, bool isWarning, string likingBarText) {} // 0x0000000182DD02F0-0x0000000182DD0630
		// [XID] // 0x00000001898A93F0-0x00000001898A9410
		public void UpdateQuestLikingBar(float fillValue, bool isWarning, string likingBarText) {} // 0x0000000182DD4CA0-0x0000000182DD4EF0
		// [XID] // 0x00000001898B0BE0-0x00000001898B0C00
		public void HideQuestLikingBar() {} // 0x0000000182DC89A0-0x0000000182DC8B30
		// [XID] // 0x00000001898B82C0-0x00000001898B82E0
		public void SetLikingBarAttachParam(string attachPoint, float x, float y, float z) {} // 0x0000000182DCEEC0-0x0000000182DCF0B0
		// [XID] // 0x00000001898BFA40-0x00000001898BFA60
		public void ShowBlackScreen(float durationToBlack, float durationKeepBlack, float durationFromBlack, Action<ILuaActor> callback, Action<ILuaActor> finishCallback, CurtainTask task, string textMapId) {} // 0x0000000182DCF7B0-0x0000000182DCFA70
		// [XID] // 0x00000001898C7300-0x00000001898C7320
		public void TryAddShake(Vector3 shakeDir, float shakeRange, float shakeTime, float shakeDinstance) {} // 0x0000000182DD36E0-0x0000000182DD3900
		// [XID] // 0x00000001898CE8B0-0x00000001898CE8D0
		public void ShowReadingDialog(uint docId) {} // 0x0000000182DD0890-0x0000000182DD09A0
		// [XID] // 0x00000001898D62A0-0x00000001898D62C0
		public void CancelCurrentNavigation() {} // 0x0000000182DC2910-0x0000000182DC29F0
		// [XID] // 0x00000001898DDEA0-0x00000001898DDEC0
		public void SetNavigationByMainId(uint mainId, bool isQuest) {} // 0x0000000182DCF0B0-0x0000000182DCF1C0
		// [XID] // 0x00000001898E5780-0x00000001898E57A0
		public bool IsInNavigation() => default; // 0x0000000182DC91B0-0x0000000182DC9300
		// [XID] // 0x00000001898ED040-0x00000001898ED060
		public void ShowCommonTips(string tittleTextMapID, string contentTextMapID, int autoCloseTime = 0 /* Metadata: 0x00AFD17C */) {} // 0x0000000182DCFA70-0x0000000182DCFC60
		// [XID] // 0x00000001898F48E0-0x00000001898F4900
		public void CloseCommonTips() {} // 0x0000000182DC34E0-0x0000000182DC35D0
		// [XID] // 0x00000001898FC110-0x00000001898FC130
		public void ShowDragonSpineWeaponDialog() {} // 0x0000000182DCFE20-0x0000000182DCFF40
		// [XID] // 0x0000000189903C10-0x0000000189903C30
		public void ShowWeaponInfoDialog(uint weaponId) {} // 0x0000000182DD0BA0-0x0000000182DD0D30
		// [XID] // 0x000000018990B0F0-0x000000018990B110
		public void ShowTutorialDialog(uint tutorialId, Action callback) {} // 0x0000000182DD0AB0-0x0000000182DD0BA0
		// [XID] // 0x0000000189912D20-0x0000000189912D40
		public void ShowQuestPictureDialog(uint tutorialId, Action callback) {} // 0x0000000182DD0630-0x0000000182DD0720
		// [XID] // 0x000000018991A630-0x000000018991A650
		public void RequestInteraction(string alias) {} // 0x0000000182DCD320-0x0000000182DCD760
		// [XID] // 0x0000000189921E00-0x0000000189921E20
		public void ActionPreSafeCall(Action<ILuaActor> handler) {} // 0x0000000182DC0910-0x0000000182DC0AE0
		// [XID] // 0x00000001899295A0-0x00000001899295C0
		public void ActionSafeCall(Action<ILuaActor> handler) {} // 0x0000000182DC0AE0-0x0000000182DC0C70
		// [XID] // 0x0000000189930BE0-0x0000000189930C00
		public uint GetSubQuestState(uint questId) => default; // 0x0000000182DC7FE0-0x0000000182DC80E0
		// [XID] // 0x0000000189937F70-0x0000000189937F90
		public bool TryTransmitPlayer(uint sceneId, Vector3 targetPos, Vector3 targetEuler, string[] textMapId, float textShowTime, Action<ILuaActor> transFinishCallback, Action<ILuaActor> transPreCallback, CurtainTask task, uint questId, uint pointId) => default; // 0x0000000182DD4070-0x0000000182DD43E0
		[BlackList] // 0x000000018993FA20-0x000000018993FA60
		// [XID] // 0x000000018993FA20-0x000000018993FA60
		private void RequestTransmitInternal(BaseLevel curLevel, uint sceneId, Vector3 targetPos, Vector3 targetEuler, string[] textMapId, float textShowTime, Action<ILuaActor> transFinishCallback, Action<ILuaActor> transPreCallback, CurtainTask task, uint questId, uint pointId) {} // 0x0000000182DCD760-0x0000000182DCD9B0
		[BlackList] // 0x0000000189949EC0-0x0000000189949F00
		// [XID] // 0x0000000189949EC0-0x0000000189949F00
		public bool TransmitPlayerInternal(AvatarEntity localAvatar, uint sceneId, Vector3 targetPos, Vector3 targetEuler, string[] textMapId, float textShowTime, Action<ILuaActor> transFinishCallback, Action<ILuaActor> transPreCallback, CurtainTask task, uint questId, uint pointId) => default; // 0x0000000182DD2B20-0x0000000182DD32D0
		// [XID] // 0x0000000189954500-0x0000000189954520
		public void TryShowNameDialog(Action finishCallback = null) {} // 0x0000000182DD3F00-0x0000000182DD3FD0
		// [XID] // 0x000000018995BDA0-0x000000018995BDC0
		public Vector3 GetCameraPos() => default; // 0x0000000182DC7220-0x0000000182DC7330
		// [XID] // 0x00000001899638A0-0x00000001899638C0
		public Vector3 GetCameraEuler() => default; // 0x0000000182DC7110-0x0000000182DC7220
		// [XID] // 0x000000018996ADC0-0x000000018996ADE0
		public Vector3 GetAvatarPos() => default; // 0x0000000182DC7000-0x0000000182DC7110
		// [XID] // 0x0000000189972950-0x0000000189972970
		public Vector3 GetAvatarForward() => default; // 0x0000000182DC6EF0-0x0000000182DC7000
		// [XID] // 0x000000018997A0D0-0x000000018997A0F0
		public virtual void SetAvatarPos(Vector3 pos) {} // 0x0000000182DCEA10-0x0000000182DCEB20
		// [XID] // 0x0000000189981860-0x0000000189981880
		public virtual void SetAvatarEuler(Vector3 euler) {} // 0x0000000182DCE900-0x0000000182DCEA10
		// [XID] // 0x0000000189989190-0x00000001899891B0
		public virtual void ResetCameraToAvatarBackward() {} // 0x0000000182DCD9B0-0x0000000182DCDA70
		// [XID] // 0x0000000189990950-0x0000000189990970
		public void AvatarGotoPoint(Vector3 pos, Action callback = null) {} // 0x0000000182DC1450-0x0000000182DC1580
		// [XID] // 0x00000001899983D0-0x00000001899983F0
		public void AvatarMoveTo(Vector3 pos, float len, bool changeMoveState, bool isWalk) {} // 0x0000000182DC1580-0x0000000182DC16E0
		// [XID] // 0x000000018999FBB0-0x000000018999FBD0
		public void EnterSceneLookCamera(Vector3 targetPos, float offsetY, float duration, bool forceLook, bool recoverKeepCurrent) {} // 0x0000000182DC6040-0x0000000182DC6260
		// [XID] // 0x00000001899A7840-0x00000001899A7860
		public void EnterSceneLookCameraByAlias(string alias, float offsetY, float duration, bool forceLook, bool recoverKeepCurrent) {} // 0x0000000182DC5DC0-0x0000000182DC6040
		// [XID] // 0x00000001899AF130-0x00000001899AF150
		public void ExitSceneLookCamera() {} // 0x0000000182DC67C0-0x0000000182DC69B0
		// [XID] // 0x00000001899B6490-0x00000001899B64B0
		public void NarratorAutoTask(ILuaNarratorData data, Action<ILuaActor, LuaTask> onFinish, uint mainQuestId) {} // 0x0000000182DC96E0-0x0000000182DC9890
		// [XID] // 0x00000001899BE070-0x00000001899BE090
		public LuaNarratorTask NarratorOnlyAutoTask(ILuaNarratorData data, Action<ILuaActor, LuaTask> onFinish, uint mainQuestId) => default; // 0x0000000182DC9890-0x0000000182DC9A40
		// [XID] // 0x00000001899C5870-0x00000001899C5890
		public void TryPauseNarratorOnlyAutoTask(bool pauseImmediately) {} // 0x0000000182DD39B0-0x0000000182DD3A90
		// [XID] // 0x00000001899CCEB0-0x00000001899CCED0
		public void TryResumeNarratorOnlyAutoTask() {} // 0x0000000182DD3CD0-0x0000000182DD3DA0
		// [XID] // 0x00000001899D43A0-0x00000001899D43C0
		public void SayNarrator(uint dialogID, uint mainQuestId) {} // 0x0000000182DCE1F0-0x0000000182DCE400
		// [XID] // 0x00000001899DBA90-0x00000001899DBAB0
		public void StopNarrator() {} // 0x0000000182DD2480-0x0000000182DD2610
		// [XID] // 0x00000001899E3410-0x00000001899E3430
		public void SayWarningNarrator(uint dialogID, uint mainQuestId) {} // 0x0000000182DCE630-0x0000000182DCE840
		// [XID] // 0x00000001899EA820-0x00000001899EA840
		public void StopWarningNarrator() {} // 0x0000000182DD2730-0x0000000182DD28C0
		// [XID] // 0x00000001899F2430-0x00000001899F2450
		public uint GetShowReminder(uint reminderID, uint dialogID) => default; // 0x0000000182DC7E30-0x0000000182DC7FE0
		// [XID] // 0x00000001899F9A10-0x00000001899F9A30
		public float GetReminderDelay(uint dialogID) => default; // 0x0000000182DC7C70-0x0000000182DC7D40
		// [XID] // 0x0000000189A00D90-0x0000000189A00DB0
		public float SayReminder(uint reminderID, uint dialogID) => default; // 0x0000000182DCE400-0x0000000182DCE630
		// [XID] // 0x0000000189A08710-0x0000000189A08730
		public void StopReminder(uint reminderID) {} // 0x0000000182DD2610-0x0000000182DD2730
		// [XID] // 0x0000000189A0FD30-0x0000000189A0FD50
		public void AvatarPaimonAppear(Action callback = null, bool directly = false /* Metadata: 0x00AFD180 */) {} // 0x0000000182DC16E0-0x0000000182DC1880
		// [XID] // 0x0000000189A171D0-0x0000000189A171F0
		public void AvatarPaimonPlayer(string skillName, Action callback = null) {} // 0x0000000182DC1A10-0x0000000182DC1BF0
		// [XID] // 0x0000000189A1E860-0x0000000189A1E880
		public void AvatarPaimonDisappear(Action callback = null, bool directly = false /* Metadata: 0x00AFD181 */) {} // 0x0000000182DC1880-0x0000000182DC1A10
		// [XID] // 0x0000000189A25FD0-0x0000000189A25FF0
		public void BlackScreen(float value) {} // 0x0000000182DC25D0-0x0000000182DC2720
		// [XID] // 0x0000000189A2D370-0x0000000189A2D390
		public bool IsTalkDialogActive() => default; // 0x0000000182DC93A0-0x0000000182DC94A0
		// [XID] // 0x0000000189A34E50-0x0000000189A34E70
		public bool IsGivenDialogActive() => default; // 0x0000000182DC90B0-0x0000000182DC91B0
		// [XID] // 0x0000000189A3C200-0x0000000189A3C220
		public void SetOpenState(OpenStateType type, bool active) {} // 0x0000000182DCF1C0-0x0000000182DCF2D0
		// [XID] // 0x0000000189A43DD0-0x0000000189A43DF0
		public void TryShowMoveToggle(bool show) {} // 0x0000000182DD3DA0-0x0000000182DD3F00
		// [IDTag] // 0x0000000189A4B300-0x0000000189A4B340
		// [XID] // 0x0000000189A4B300-0x0000000189A4B340
		public bool SayDialogAudio(uint dialogId, IDialogVoiceEventResponder responder) => default; // 0x0000000182DCDFB0-0x0000000182DCE0E0
		// [IDTag] // 0x0000000189A55BE0-0x0000000189A55C20
		// [XID] // 0x0000000189A55BE0-0x0000000189A55C20
		public void SayDialogAudio(uint dialogId) {} // 0x0000000182DCE0E0-0x0000000182DCE1F0
		// [XID] // 0x0000000189A604E0-0x0000000189A60500
		public void StopDialogAudio() {} // 0x0000000182DD2270-0x0000000182DD2370
		// [XID] // 0x0000000189A680D0-0x0000000189A680F0
		public void SetFlyStateParams(float flyBackSpeedMax, float flyHorizontalSpeedMax, float flyRotationAngularVelocity, float flyDownSpeed, float flyForwardSpeedMax) {} // 0x0000000182DCED90-0x0000000182DCEEC0
		// [XID] // 0x0000000189A6F4E0-0x0000000189A6F500
		public void ResetFlyStateParams() {} // 0x0000000182DCDA70-0x0000000182DCDB10
		// [XID] // 0x0000000189A76CA0-0x0000000189A76CC0
		public void EnterSneakMode(float sensingRange) {} // 0x0000000182DC6260-0x0000000182DC6510
		// [XID] // 0x0000000189A7E680-0x0000000189A7E6A0
		public void ExitSneakMode() {} // 0x0000000182DC69B0-0x0000000182DC6C00
		// [XID] // 0x0000000189A85FB0-0x0000000189A85FD0
		public void EnterBomberMode() {} // 0x0000000182DC5B60-0x0000000182DC5C90
		// [XID] // 0x0000000189A8D870-0x0000000189A8D890
		public void BackToNormalMode() {} // 0x0000000182DC1D10-0x0000000182DC1E40
		// [XID] // 0x0000000189A94DF0-0x0000000189A94E10
		public void EnterFindCatMode() {} // 0x0000000182DC5C90-0x0000000182DC5DC0
		// [XID] // 0x0000000189A9C6D0-0x0000000189A9C6F0
		public void EnterWildSneakMode(float sensingRange) {} // 0x0000000182DC6510-0x0000000182DC67C0
		// [XID] // 0x0000000189AA3E20-0x0000000189AA3E40
		public void ExitWildSneakMode() {} // 0x0000000182DC6C00-0x0000000182DC6CA0
		// [XID] // 0x0000000189AAB350-0x0000000189AAB370
		public uint GetChallengeBestValue(uint challengeIndex) => default; // 0x0000000182DC7330-0x0000000182DC7420
		// [XID] // 0x0000000189AB2D80-0x0000000189AB2DA0
		public uint GetChallengeRecordCurrValue(uint challengeIndex) => default; // 0x0000000182DC7420-0x0000000182DC7510
		// [XID] // 0x0000000189ABA940-0x0000000189ABA960
		public void BattleUIStart(int total, uint teammateID, int teammateScore, uint opponentID, int opponentScore) {} // 0x0000000182DC22A0-0x0000000182DC2490
		// [XID] // 0x0000000189AC21D0-0x0000000189AC21F0
		public void BattleUIChange(int teammateScore, int teammateAdd, int opponentScore, int opponentAdd) {} // 0x0000000182DC20D0-0x0000000182DC22A0
		// [XID] // 0x0000000189AC98A0-0x0000000189AC98C0
		public void BattleUITerminate() {} // 0x0000000182DC2490-0x0000000182DC25D0
		// [XID] // 0x0000000189AD1170-0x0000000189AD1190
		public void RequestCoopInteractionFromSubStartPoint(uint mainCoopId, uint subStartPointId) {} // 0x0000000182DCD1E0-0x0000000182DCD320
		// [XID] // 0x0000000189AD8F90-0x0000000189AD8FB0
		public void RemoveCoopInteractionDataFromSubStartPoint(uint mainCoopId, uint subStartPointId) {} // 0x0000000182DCCEE0-0x0000000182DCD020
		// [XID] // 0x0000000189AE0A00-0x0000000189AE0A20
		public void EnableElementView(bool enable) {} // 0x0000000182DC5810-0x0000000182DC5950
		// [XID] // 0x0000000189AE7ED0-0x0000000189AE7EF0
		public void LevelLoadFinishSafeCall(Action<ILuaActor> handler) {} // 0x0000000182DC9550-0x0000000182DC96E0
		// [XID] // 0x0000000189AEFC40-0x0000000189AEFC60
		public void TriggerLevelAbility(string name) {} // 0x0000000182DD3420-0x0000000182DD35A0
		// [XID] // 0x0000000189AF71C0-0x0000000189AF71E0
		public void TriggerAbility(string name) {} // 0x0000000182DD32D0-0x0000000182DD3420
		// [XID] // 0x0000000189AFE810-0x0000000189AFE830
		public void TriggerNpcSpeechBubble(uint npcID, uint dialogID, uint mainQuestId, uint priority) {} // 0x0000000182DD35A0-0x0000000182DD36E0
		// [XID] // 0x0000000189B06080-0x0000000189B060A0
		public void ClearNpcSpeechBubble(uint npcID, uint mainQuestId, uint priority) {} // 0x0000000182DC2FA0-0x0000000182DC30C0
		// [XID] // 0x0000000189B0D7D0-0x0000000189B0D7F0
		public void TryPlayVideo(string videoName, uint subtitleId, bool canSkip, Action<ILuaActor> finishCallBack, Color bgColor, float fadeIn = 0f /* Metadata: 0x00AFD182 */, float fadeOut = 0f /* Metadata: 0x00AFD186 */) {} // 0x0000000182DD3A90-0x0000000182DD3CD0
		// [XID] // 0x00000001899FD6D0-0x00000001899FD6F0
		public bool IsCurrentFreeTask(int freeStyle) => default; // 0x0000000182DC8F20-0x0000000182DC9000
		[BlackList] // 0x0000000189B1C5B0-0x0000000189B1C5F0
		// [XID] // 0x0000000189B1C5B0-0x0000000189B1C5F0
		public void UpdateFreeStyleTask(int freeStyle) {} // 0x0000000182DD4BC0-0x0000000182DD4CA0
		// [XID] // 0x0000000189B26B50-0x0000000189B26B70
		public void FinishFreeStyleTask(int freeStyle) {} // 0x0000000182DC6CA0-0x0000000182DC6D80
		// [XID] // 0x000000018970FE30-0x000000018970FE50
		protected void ClearAllTag() {} // 0x0000000182DC2CA0-0x0000000182DC2DB0
		// [XID] // 0x0000000189B35170-0x0000000189B35190
		public void RecordTaskByTag(LuaTask luaTask) {} // 0x0000000182DCC0A0-0x0000000182DCC260
		// [XID] // 0x0000000189B3CA40-0x0000000189B3CA60
		public void ClearTaskByTag(LuaTask task) {} // 0x0000000182DC3200-0x0000000182DC33D0
		// [XID] // 0x0000000189B44790-0x0000000189B447B0
		public void RegisterTaskTagCB(string tag, Action<ILuaActor> pauseCB, Action<ILuaActor> resumeCB = null) {} // 0x0000000182DCCC80-0x0000000182DCCEE0
		// [XID] // 0x0000000189B4C000-0x0000000189B4C020
		public void UnregisterTaskTagCB(string tag, Action<ILuaActor> pauseCB = null, Action<ILuaActor> resumeCB = null) {} // 0x0000000182DD4920-0x0000000182DD4BC0
		// [XID] // 0x0000000189B53500-0x0000000189B53520
		public bool HasTask(string tag) => default; // 0x0000000182DC8780-0x0000000182DC89A0
		// [XID] // 0x0000000189B5AD90-0x0000000189B5ADB0
		public bool HasTagTask(string taskTag) => default; // 0x0000000182DC8560-0x0000000182DC8680
		// [XID] // 0x0000000189B62250-0x0000000189B62270
		public void PauseByTag(string tag) {} // 0x0000000182DCA940-0x0000000182DCAE90
		// [XID] // 0x0000000189B69EB0-0x0000000189B69ED0
		public void ResumeByTag(string tag) {} // 0x0000000182DCDB10-0x0000000182DCDDF0
		// [XID] // 0x0000000189B71510-0x0000000189B71530
		public void DelayResumeByTag(string tag) {} // 0x0000000182DC49E0-0x0000000182DC4D00
		// [XID] // 0x0000000189779980-0x00000001897799A0
		public bool HasTaskResumed(string taskTag) => default; // 0x0000000182DC8680-0x0000000182DC8780
		// [XID] // 0x0000000189B7FE90-0x0000000189B7FEB0
		public void PlayEmojiBubble(string pattarnName) {} // 0x0000000182DCB850-0x0000000182DCB940
		// [XID] // 0x0000000189B879C0-0x0000000189B879E0
		public void StopCurEmojiBubble() {} // 0x0000000182DD2190-0x0000000182DD2270
		// [XID] // 0x0000000189B8EB20-0x0000000189B8EB40
		public void PlayerSitOnChair() {} // 0x0000000182DCBA80-0x0000000182DCBDA0
		// [XID] // 0x0000000189B95F80-0x0000000189B95FA0
		public void PlayerStandFromChair(float angle) {} // 0x0000000182DCBDA0-0x0000000182DCBFD0
		// [XID] // 0x0000000189B9D620-0x0000000189B9D640
		public void ForceFlushRemove() {} // 0x0000000182DC6D80-0x0000000182DC6E50
		[BlackList] // 0x0000000189BA5010-0x0000000189BA5050
		// [XID] // 0x0000000189BA5010-0x0000000189BA5050
		public virtual LevelActionPoint GetCurrentActionPoint() => default; // 0x0000000182DC7510-0x0000000182DC75B0
		[BlackList] // 0x0000000189BAF120-0x0000000189BAF160
		// [XID] // 0x0000000189BAF120-0x0000000189BAF160
		public virtual void OverrideTargetFreestyle(int freestyle, bool doRefresh) {} // 0x0000000182DCA880-0x0000000182DCA940
		// [XID] // 0x0000000189BB95C0-0x0000000189BB95E0
		public int GetQuestGlobalVar(uint id) => default; // 0x0000000182DC7B80-0x0000000182DC7C70
		// [XID] // 0x0000000189BC14E0-0x0000000189BC1500
		public int GetTaskVar(uint id, int index) => default; // 0x0000000182DC8270-0x0000000182DC8380
		[Preserve] // 0x0000000189BC8C60-0x0000000189BC8CA0
		// [XID] // 0x0000000189BC8C60-0x0000000189BC8CA0
		public string GetLuaTaskInfo() => default; // 0x0000000182DC7780-0x0000000182DC7B80
	}
}
