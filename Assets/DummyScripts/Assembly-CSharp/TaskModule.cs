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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TaskModule : BaseModule // TypeDefIndex: 21622
{
	// Fields
	private List<uint> _dailyTaskList; // 0x10
	private int _finishedDailyTaskCount; // 0x18
	private bool _dailyTaskRewardReceived; // 0x1C
	private uint _dailyTaskRewardID; // 0x20
	private int _targetDailyTaskCount; // 0x24
	private List<DailyTaskData> _ongoingDailyTasks; // 0x28
	private List<DailyTaskData> _finishedDailyTasks; // 0x30
	private DailyTaskData? _prevFinishedDailyTask; // 0x38
	private Dictionary<uint, List<int>> _taskVarDic; // 0x80
	private uint _currTaskID; // 0x88
	private List<DailyTaskData> _taskList; // 0x90
	private float _nextCheckTime; // 0x98
	private const float CHECK_GAP = 1f; // Metadata: 0x00AFFA87
	private DailyTaskData? _activeDailyTask; // 0xA0
	private RandTaskData? _activeRandTask; // 0xE8
	private List<RandTaskData> _randTaskDatas; // 0x120
	private RandTaskData? _prevFinishedRandTask; // 0x128

	// Properties
	public int dailyTaskCount { /* [XID] */ /* 0x00000001899F1690-0x00000001899F16B0 */ get => default; } // 0x0000000182760EA0-0x0000000182760F60 
	public bool dailyTaskOpened { /* [XID] */ /* 0x00000001899E2890-0x00000001899E28B0 */ get => default; } // 0x0000000182762960-0x0000000182762A10 
	public bool canGetDailyTaskReward { /* [XID] */ /* 0x0000000189A91F20-0x0000000189A91F40 */ get => default; } // 0x000000018275F7F0-0x000000018275F8A0 
	public int finishedDailyTaskCount { /* [XID] */ /* 0x0000000189A999A0-0x0000000189A999C0 */ get => default; } // 0x00000001827628C0-0x0000000182762960 
	public bool dailyTaskRewardReceived { /* [XID] */ /* 0x0000000189AA09A0-0x0000000189AA09C0 */ get => default; } // 0x00000001827614B0-0x0000000182761550 
	public uint dailyTaskRewardID { /* [XID] */ /* 0x0000000189AA7F40-0x0000000189AA7F60 */ get => default; } // 0x00000001827609D0-0x0000000182760A70 
	public int targetDailyTaskCount { /* [XID] */ /* 0x0000000189ABEDD0-0x0000000189ABEDF0 */ get => default; } // 0x0000000182760930-0x00000001827609D0 
	public List<DailyTaskData> ongoingDailyTasks { /* [XID] */ /* 0x0000000189ACE0D0-0x0000000189ACE0F0 */ get => default; } // 0x0000000182760A70-0x0000000182760B10 
	public List<DailyTaskData> finishedDailyTasks { /* [XID] */ /* 0x0000000189AD5D40-0x0000000189AD5D60 */ get => default; } // 0x0000000182761280-0x0000000182761320 
	public DailyTaskData? prevFinishedDailyTask { /* [XID] */ /* 0x0000000189B11D40-0x0000000189B11D60 */ get => default; } // 0x0000000182763F90-0x0000000182764110 
	public DailyTaskData? activeDailyTask { /* [XID] */ /* 0x0000000189B6B400-0x0000000189B6B420 */ get => default; } // 0x0000000182761F60-0x00000001827620F0 
	public RandTaskData? activeRandTask { /* [XID] */ /* 0x0000000189B72A10-0x0000000189B72A30 */ get => default; } // 0x0000000182762540-0x00000001827626A0 
	public RandTaskData? prevFinishedRandTask { /* [XID] */ /* 0x0000000189B97730-0x0000000189B97750 */ get => default; } // 0x000000018275FDC0-0x000000018275FF20 

	// Constructors
	public TaskModule() {} // 0x0000000182765CE0-0x0000000182765FB0

	// Methods
	// [XID] // 0x0000000189A469F0-0x0000000189A46A10
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001827607F0-0x0000000182760930
	// [XID] // 0x0000000189A4E1D0-0x0000000189A4E1F0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000182764AC0-0x0000000182764B90
	// [XID] // 0x0000000189A55A00-0x0000000189A55A20
	public override bool OnPacket(Packet packet) => default; // 0x000000018275FF20-0x0000000182760160
	// [XID] // 0x0000000189A5D260-0x0000000189A5D280
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182765A00-0x0000000182765AF0
	// [XID] // 0x0000000189A64B40-0x0000000189A64B60
	public override void ClearOnDisconnect() {} // 0x0000000182764B90-0x0000000182764C30
	// [XID] // 0x0000000189A6C3C0-0x0000000189A6C3E0
	public override void ClearOnLevelDestroy() {} // 0x00000001827602A0-0x0000000182760340
	// [XID] // 0x0000000189A73B30-0x0000000189A73B50
	public override void ClearOnBackHome() {} // 0x00000001827619F0-0x0000000182761AA0
	// [XID] // 0x0000000189A7B600-0x0000000189A7B620
	public void InitOnLevelLoaded(GlobalVars.WorldType worldType) {} // 0x0000000182764550-0x0000000182764600
	// [XID] // 0x0000000189AAFC30-0x0000000189AAFC50
	private void OnDailyTaskDataNotify(DailyTaskDataNotify ntf) {} // 0x0000000182763AE0-0x0000000182763BC0
	// [XID] // 0x0000000189AB7370-0x0000000189AB7390
	private void SetupOngoingDailyTask(RepeatedMessageField<DailyTaskInfo> taskList) {} // 0x0000000182760340-0x00000001827607F0
	// [XID] // 0x0000000189AC68B0-0x0000000189AC68D0
	private void UpdateTargetDailyTaskCount() {} // 0x0000000182761170-0x0000000182761280
	// [XID] // 0x0000000189ADD770-0x0000000189ADD790
	public bool TryGetFinishedDailyTask(uint id, out DailyTaskData taskData) {
		taskData = default;
		return default;
	} // 0x0000000182761320-0x00000001827614B0
	// [XID] // 0x0000000189AE4F40-0x0000000189AE4F60
	public bool TryGetOnGoingDailyTask(uint id, out DailyTaskData taskData) {
		taskData = default;
		return default;
	} // 0x000000018275F660-0x000000018275F7F0
	// [XID] // 0x0000000189AEC580-0x0000000189AEC5A0
	public uint GetPreviewIdBySubQuestID(uint subQuestId) => default; // 0x0000000182760F60-0x0000000182761170
	// [XID] // 0x0000000189AF4050-0x0000000189AF4070
	private void ClearDailyTask() {} // 0x00000001827630C0-0x0000000182763190
	// [XID] // 0x0000000189AFB7C0-0x0000000189AFB7E0
	private void ClearOngoingDailyTask() {} // 0x0000000182760B10-0x0000000182760EA0
	// [XID] // 0x0000000189B02EB0-0x0000000189B02ED0
	public void RefreshDailyTaskMark() {} // 0x0000000182764600-0x0000000182764AC0
	// [XID] // 0x0000000189B0A5A0-0x0000000189B0A5C0
	public void UpdateDailyTaskMarkInRoom() {} // 0x0000000182764110-0x0000000182764550
	// [XID] // 0x0000000189B18F70-0x0000000189B18F90
	private void OnDailyTaskProgressNotify(DailyTaskProgressNotify ntf) {} // 0x0000000182762A10-0x00000001827630C0
	// [XID] // 0x0000000189B20670-0x0000000189B20690
	private void OnDailyTaskScoreRewardNotify(DailyTaskScoreRewardNotify ntf) {} // 0x0000000182763A30-0x0000000182763AE0
	// [XID] // 0x0000000189B27D70-0x0000000189B27D90
	private void OnWorldOwnerDailyTaskNotify(WorldOwnerDailyTaskNotify ntf) {} // 0x00000001827631F0-0x0000000182763410
	// [XID] // 0x0000000189B2F090-0x0000000189B2F0B0
	private void OnTaskVarNotify(TaskVarNotify ntf) {} // 0x0000000182763D00-0x0000000182763F90
	// [XID] // 0x0000000189B369B0-0x0000000189B369D0
	private void ClearTaskVar() {} // 0x00000001827620F0-0x00000001827621B0
	// [XID] // 0x0000000189B3E170-0x0000000189B3E190
	public int GetTaskVarValue(uint key, int index) => default; // 0x000000018275F8A0-0x000000018275F9E0
	// [XID] // 0x0000000189B45EC0-0x0000000189B45EE0
	public void InitDailyTaskPositionAndRadius(uint taskID, uint subQuestID, Vector3 worldPosition, float radius) {} // 0x0000000182763410-0x0000000182763840
	// [XID] // 0x0000000189B4D2F0-0x0000000189B4D310
	public void UpdateDailyTaskPosition(uint taskID, uint subQuestID, Vector3 worldPosition) {} // 0x000000018275F9E0-0x000000018275FD40
	// [XID] // 0x0000000189B54B90-0x0000000189B54BB0
	public void CancelDailyTaskSubQuestTracking(uint taskID, bool clear = true /* Metadata: 0x00AFFA86 */) {} // 0x0000000182761B20-0x0000000182761F60
	// [XID] // 0x0000000189B5C5D0-0x0000000189B5C5F0
	private void HandleDailyTaskStart(ref DailyTaskData taskData) {} // 0x00000001827621B0-0x00000001827624C0
	// [XID] // 0x0000000189B63C70-0x0000000189B63C90
	private void HandleDailyTaskExitRegion(ref DailyTaskData taskData) {} // 0x00000001827626A0-0x00000001827628C0
	// [XID] // 0x0000000189B79F90-0x0000000189B79FB0
	public void CheckTask() {} // 0x0000000182764C30-0x0000000182765970
	// [XID] // 0x0000000189B816F0-0x0000000189B81710
	public bool CheckTaskInProgress(uint taskId) => default; // 0x0000000182763BC0-0x0000000182763D00
	// [XID] // 0x0000000189B88D70-0x0000000189B88D90
	public bool CheckTaskFinished(uint taskId) => default; // 0x0000000182760160-0x00000001827602A0
	// [XID] // 0x0000000189B902E0-0x0000000189B90300
	private void OnAddRandTaskInfoNoitfy(AddRandTaskInfoNotify ntf) {} // 0x0000000182763840-0x0000000182763A30
	// [XID] // 0x0000000189B9EBF0-0x0000000189B9EC10
	private void OnRemoveRandTaskInfoNotify(RemoveRandTaskInfoNotify ntf) {} // 0x0000000182761550-0x00000001827619F0
	// [XID] // 0x0000000189BA64E0-0x0000000189BA6500
	private void ClearRandTask() {} // 0x0000000182765AF0-0x0000000182765CE0
}

