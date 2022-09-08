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
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ActorFSMSchedule : IAutoAllocRecycle // TypeDefIndex: 19930
{
	// Fields
	private NpcActor owner; // 0x10
	private ActorFSMBlackBoard blackBoard; // 0x18
	private SchedulePoint currentSchedulePoint; // 0x20
	private bool teleportCurrent; // 0x28
	private static int INVALID_INDEX; // 0x00
	public static int INVALID_PRIORITY; // 0x04
	private int currentActionIndex; // 0x34
	private DummyActionPoint targetActionPoint; // 0x38
	private DummyActionPoint tempActionPoint; // 0x40
	private DummyActionPoint lastActionPoint; // 0x48
	private NormalTimer requestConvTimer; // 0x50
	private static float CONVERSATION_REQUEST_INTERVAL; // 0x08
	private const float DITHER_EFFECT_DURATION = 2f; // Metadata: 0x00AFD0BE
	private const float DITHER_TIMER_DURATION = 2.2f; // Metadata: 0x00AFD0C2
	private bool requestStartDaily; // 0x58
	private bool _isDailyScheduleDirty; // 0x59
	private int _curConversationTrafficNode; // 0x5C
	private bool _isDailySchedulePosDirty; // 0x60
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private RuntimeScheduleInfo runtimeSchedule; // 0x68
	private TrafficPathQueryPattern _curTrafficPattern; // 0x70
	private HidingState hidingState; // 0x78
	private NormalTimer ditherTimer; // 0x80

	// Properties
	public int currentDailyActionIndex { /* [XID] */ /* 0x00000001898A33C0-0x00000001898A3400 */ get; /* [XID] */ /* 0x00000001898ADBF0-0x00000001898ADC30 */ private set; } // 0x000000018332FD90-0x000000018332FDF0 0x000000018332CA40-0x000000018332CAA0
	public int currentScheduleIndex { /* [XID] */ /* 0x00000001898B8300-0x00000001898B8340 */ get; /* [XID] */ /* 0x00000001898C2900-0x00000001898C2940 */ private set; } // 0x000000018332A1A0-0x000000018332A200 0x000000018332B050-0x000000018332B0B0
	public bool isDailyScheduleDirty { /* [XID] */ /* 0x00000001898CD0E0-0x00000001898CD100 */ get => default; /* [XID] */ /* 0x00000001898D49D0-0x00000001898D49F0 */ private set {} } // 0x000000018332D8F0-0x000000018332D990 0x000000018332B780-0x000000018332B830
	public bool isDailySchedulePosDirty { /* [XID] */ /* 0x00000001898DC3F0-0x00000001898DC410 */ get => default; /* [XID] */ /* 0x00000001898E3E00-0x00000001898E3E20 */ set {} } // 0x000000018332D770-0x000000018332D810 0x000000018332BDB0-0x000000018332BE60
	public LevelActionPoint CurrentActionPoint { /* [XID] */ /* 0x00000001898EB950-0x00000001898EB970 */ get => default; } // 0x000000018332DE90-0x000000018332DF40 

	// Nested types
	[RecycleType] // 0x00000001898422C0-0x00000001898422E0
	public class RuntimeScheduleInfo : IAutoAllocRecycle // TypeDefIndex: 19931
	{
		// Fields
		public int trafficNodeId; // 0x10
		public List<Vector3> posList; // 0x18
		public List<LevelActionPoint> levelActionPointList; // 0x20
		public LevelActionPoint curActionPoint; // 0x28

		// Constructors
		public RuntimeScheduleInfo() {} // 0x0000000183317E30-0x0000000183317EB0

		// Methods
		[BlackList] // 0x0000000189A82FA0-0x0000000189A82FE0
		// [XID] // 0x0000000189A82FA0-0x0000000189A82FE0
		public virtual void AutoAllocTypeFields() {} // 0x0000000183317940-0x00000001833179E0
		[BlackList] // 0x0000000189A8D8F0-0x0000000189A8D930
		// [XID] // 0x0000000189A8D8F0-0x0000000189A8D930
		public virtual void AutoRecycleTypeFields() {} // 0x00000001833179E0-0x0000000183317A90
		[BlackList] // 0x0000000189A98230-0x0000000189A98270
		// [XID] // 0x0000000189A98230-0x0000000189A98270
		public virtual void ReturnToObjectPool() {} // 0x0000000183317D90-0x0000000183317E30
		// [XID] // 0x0000000189AA2450-0x0000000189AA2470
		public void SetCurrrentActionPoint(LevelActionPoint levelActionPoint, BaseEntity entity) {} // 0x0000000183317B60-0x0000000183317C50
		// [XID] // 0x0000000189AA99E0-0x0000000189AA9A00
		public void ReleaseCurrentActionPoint(BaseEntity entity) {} // 0x0000000183317A90-0x0000000183317B60
		// [XID] // 0x0000000189AB1860-0x0000000189AB1880
		public virtual void OnPoolAllocated() {} // 0x0000000183317CF0-0x0000000183317D90
		// [XID] // 0x0000000189AB8B80-0x0000000189AB8BA0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000183317C50-0x0000000183317CF0
	}

	private enum HidingState // TypeDefIndex: 19932
	{
		UnHided = 0,
		TransitToHide = 1,
		Hided = 2,
		TransitToUnHide = 3
	}

	// Constructors
	public ActorFSMSchedule() {} // 0x0000000183330630-0x00000001833308C0
	static ActorFSMSchedule() {} // 0x00000001833305A0-0x0000000183330630

	// Methods
	[BlackList] // 0x00000001898843D0-0x0000000189884410
	// [XID] // 0x00000001898843D0-0x0000000189884410
	public virtual void AutoAllocTypeFields() {} // 0x000000018332AAD0-0x000000018332ABA0
	[BlackList] // 0x000000018988E800-0x000000018988E840
	// [XID] // 0x000000018988E800-0x000000018988E840
	public virtual void AutoRecycleTypeFields() {} // 0x000000018332ABA0-0x000000018332AD40
	[BlackList] // 0x0000000189899010-0x0000000189899050
	// [XID] // 0x0000000189899010-0x0000000189899050
	public virtual void ReturnToObjectPool() {} // 0x0000000183330500-0x00000001833305A0
	// [XID] // 0x00000001898F3140-0x00000001898F3160
	public virtual void OnPoolAllocated() {} // 0x0000000183330170-0x0000000183330210
	// [XID] // 0x00000001898FA800-0x00000001898FA820
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183330070-0x0000000183330170
	// [XID] // 0x0000000189902350-0x0000000189902370
	public void Init(NpcActor actor, ActorFSMSystem fsm, ActorFSMBlackBoard board) {} // 0x000000018332C590-0x000000018332C890
	// [XID] // 0x0000000189909980-0x00000001899099A0
	public void Update(float deltaTime) {} // 0x000000018332D440-0x000000018332D510
	// [XID] // 0x0000000189911090-0x00000001899110B0
	private bool IsConversationEnable() => default; // 0x000000018332C890-0x000000018332C980
	// [XID] // 0x0000000189918C30-0x0000000189918C50
	private void UpdateRequestConversation(float deltaTime) {} // 0x000000018332DB70-0x000000018332DE90
	// [XID] // 0x00000001899202F0-0x0000000189920310
	private void TryStopConversation() {} // 0x0000000183330300-0x0000000183330410
	// [XID] // 0x0000000189927B50-0x0000000189927B70
	public void OnStartDaily() {} // 0x000000018332ED00-0x000000018332EE30
	// [XID] // 0x000000018992F340-0x000000018992F360
	public void ForceRefreshDaily() {} // 0x000000018332EE30-0x000000018332EED0
	// [XID] // 0x00000001899366D0-0x00000001899366F0
	public void OnScriptBHVTypeChange() {} // 0x000000018332A060-0x000000018332A1A0
	// [XID] // 0x000000018993E2B0-0x000000018993E2D0
	public bool UpdateCurSchedule() => default; // 0x000000018332B830-0x000000018332B9E0
	// [XID] // 0x00000001899458C0-0x00000001899458E0
	public bool GetCurScheduleStartPoint(out Vector3 pos) {
		pos = default;
		return default;
	} // 0x000000018332E110-0x000000018332E6D0
	// [XID] // 0x000000018994CCF0-0x000000018994CD10
	private void OnRequestStartDaily() {} // 0x000000018332DF40-0x000000018332E110
	// [XID] // 0x0000000189954520-0x0000000189954540
	private DummyActionPoint GetInitActionPoint() => default; // 0x000000018332D810-0x000000018332D8F0
	// [XID] // 0x000000018995BDC0-0x000000018995BDE0
	private DummyActionPoint ConvertToDummyActionPoint(LevelActionPoint levelActionPoint) => default; // 0x000000018332C370-0x000000018332C490
	// [XID] // 0x00000001899638C0-0x00000001899638E0
	private DummyActionPoint GetDefualtDummyActionPoint(Vector3 pos) => default; // 0x000000018332FDF0-0x0000000183330070
	// [XID] // 0x000000018996ADE0-0x000000018996AE00
	private bool UpdateScheduleActivity(int hour, bool forceUpdate) => default; // 0x000000018332A200-0x000000018332A750
	// [XID] // 0x0000000189972970-0x0000000189972990
	public void OnSelfHour(int hour) {} // 0x000000018332C980-0x000000018332CA40
	// [XID] // 0x000000018997A0F0-0x000000018997A110
	public bool IsCanDoDailyAction() => default; // 0x000000018332BCD0-0x000000018332BDB0
	// [XID] // 0x00000001899818C0-0x00000001899818E0
	public bool UpdateStaticListActivity(bool forceUpdate) => default; // 0x000000018332A750-0x000000018332AAD0
	// [XID] // 0x00000001899891B0-0x00000001899891D0
	private void StaticListCheckHide() {} // 0x000000018332D990-0x000000018332DB70
	// [XID] // 0x00000001899909B0-0x00000001899909D0
	private bool IsQuestConditionValid(uint mainQuestID, uint questState) => default; // 0x000000018332FBE0-0x000000018332FCF0
	// [XID] // 0x0000000189998410-0x0000000189998430
	public void UpdateMoveTargetWithStaticList(bool doIncrement) {} // 0x000000018332EF70-0x000000018332F110
	// [XID] // 0x000000018999FC10-0x000000018999FC30
	public void TrySetTargetActionPoint(DummyActionPoint dummyActionPoint, List<Vector3> resultPath = null) {} // 0x000000018332AE60-0x000000018332B050
	// [XID] // 0x00000001899A78A0-0x00000001899A78C0
	private LevelActionPoint GetRandomLevelActionPoint(List<LevelActionPoint> pointList) => default; // 0x000000018332CCF0-0x000000018332D1E0
	// [XID] // 0x00000001899AF150-0x00000001899AF170
	private void TryMoveToNextTarget() {} // 0x000000018332F110-0x000000018332F1E0
	// [XID] // 0x00000001899B64B0-0x00000001899B64D0
	private void UpdateRuntimeSchedule() {} // 0x000000018332F1E0-0x000000018332F450
	// [XID] // 0x00000001899BE0B0-0x00000001899BE0D0
	public void UpdateScheduleRoute() {} // 0x000000018332F7A0-0x000000018332F9C0
	// [XID] // 0x00000001899C5890-0x00000001899C58B0
	private void OnFindCurPos2TargetPointPathResult(bool result, List<Vector3> resultPath) {} // 0x000000018332BAA0-0x000000018332BBA0
	// [XID] // 0x00000001899CCED0-0x00000001899CCEF0
	private void OnFindTrafficPathResult(bool result, List<Vector3> resultPath) {} // 0x000000018332B330-0x000000018332B780
	// [XID] // 0x00000001899D43E0-0x00000001899D4400
	private void ForceSetScheduleTargetPoint(LevelTrafficPlugin.TrafficNode targetNode) {} // 0x000000018332F450-0x000000018332F7A0
	// [XID] // 0x00000001899DBB50-0x00000001899DBB70
	private void UpdateMoveTargetWithSchedule() {} // 0x000000018332D510-0x000000018332D5F0
	// [XID] // 0x00000001899E3470-0x00000001899E3490
	private void RequestBeginConversation(int trafficNodeId, uint npcId) {} // 0x000000018332D1E0-0x000000018332D310
	// [XID] // 0x00000001899EA880-0x00000001899EA8A0
	private void RequestEndConversation(int trafficNodeId, uint npcId) {} // 0x000000018332BBA0-0x000000018332BCD0
	// [XID] // 0x00000001899F2450-0x00000001899F2470
	public void OnFinalPointArrived() {} // 0x000000018332D310-0x000000018332D440
	// [XID] // 0x00000001899F9A30-0x00000001899F9A50
	private ActorFSMTransition GetTransitionByPattern(GeneralPattern pattern) => default; // 0x000000018332B140-0x000000018332B210
	// [XID] // 0x0000000189A00DB0-0x0000000189A00DD0
	public bool OnPerformStateFinished() => default; // 0x000000018332F9C0-0x000000018332FBE0
	// [XID] // 0x0000000189A08730-0x0000000189A08750
	private void CacheLastDummyActionPoint(DummyActionPoint tarPoint) {} // 0x000000018332BE60-0x000000018332BF20
	// [XID] // 0x0000000189A0FD50-0x0000000189A0FD70
	public bool CanDoReaction(ActorFSMReactionType reationType) => default; // 0x0000000183330410-0x0000000183330500
	// [XID] // 0x0000000189A171F0-0x0000000189A17210
	public void OnLeaveDailyAction() {} // 0x0000000183330210-0x0000000183330300
	// [XID] // 0x0000000189A1E880-0x0000000189A1E8A0
	public void OnClear() {} // 0x000000018332FCF0-0x000000018332FD90
	// [XID] // 0x0000000189A26070-0x0000000189A26090
	public void RefreshCurAction() {} // 0x000000018332BF20-0x000000018332C370
	// [XID] // 0x0000000189A2D390-0x0000000189A2D3B0
	private void UpdateHiding(float deltaTime) {} // 0x000000018332E6D0-0x000000018332ED00
	// [XID] // 0x0000000189A34E70-0x0000000189A34E90
	private void TransitToTargetState(GeneralPattern targetPattern) {} // 0x000000018332CAA0-0x000000018332CB90
	// [XID] // 0x0000000189A3C220-0x0000000189A3C240
	public void HideSelf() {} // 0x000000018332CB90-0x000000018332CCF0
	// [XID] // 0x0000000189A43E30-0x0000000189A43E50
	public void HideSelfNow(bool forceSet) {} // 0x000000018332B210-0x000000018332B330
	// [XID] // 0x0000000189A4B340-0x0000000189A4B360
	public void UnHideSelfNow(bool forceSet) {} // 0x000000018332AD40-0x000000018332AE60
	// [XID] // 0x0000000189A52940-0x0000000189A52960
	public void UnHideSelf() {} // 0x000000018332D5F0-0x000000018332D770
	// [XID] // 0x0000000189A5A300-0x0000000189A5A320
	private void OnDitherHideFinished(ILuaActor obj) {} // 0x000000018332C490-0x000000018332C590
	// [XID] // 0x0000000189A61AF0-0x0000000189A61B10
	private void OnDitherUnHideFinished(ILuaActor obj) {} // 0x000000018332B9E0-0x000000018332BAA0
	// [XID] // 0x0000000189A69A10-0x0000000189A69A30
	public int GetHideState() => default; // 0x000000018332EED0-0x000000018332EF70
}

