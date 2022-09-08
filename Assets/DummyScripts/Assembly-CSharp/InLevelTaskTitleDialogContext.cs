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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelTaskTitleDialogContext : BaseDialogContext // TypeDefIndex: 29599
{
	// Fields
	private MonoPrefabPlugin _prefabPlugin; // 0x178
	private TaskHintData _taskTitleHintData; // 0x180
	private MonoEventTargetTitle _eventTargetTitle; // 0x1B0
	private ReminderData _reminderData; // 0x1B8
	private Animator _reminderAnimator; // 0x1D0
	private UnityEngine.UI.Text _reminderLabel; // 0x1D8
	private ChallengeData _challengeData; // 0x1E0
	private Queue<ChallengeData> _bufferedChallengeData; // 0x218
	private MonoDungeonChallenge _challengeIns; // 0x220
	private BlossomChallengeData _blossomChallengeData; // 0x228
	private MonoDungeonChallenge _blosspmChallengeIns; // 0x240
	private HuntingChallengeData _huntingChallengeData; // 0x248
	private MonoDungeonChallenge _huntingChallengeIns; // 0x260
	private MonoDungeonChallenge _expeditionChallengeIns; // 0x268
	private ExpeditionChallengeData _expeditionChallengeData; // 0x270
	private MonoDungeonChallenge _activityCommonChallengeIns; // 0x280
	private ActivityCommonChallengeData _activityCommonChallengeData; // 0x288

	// Nested types
	public enum TaskHintType // TypeDefIndex: 29600
	{
		Start = 0,
		Complete = 1,
		Fail = 2,
		Description = 3
	}

	private struct TaskHintData // TypeDefIndex: 29601
	{
		// Fields
		public bool valid; // 0x00
		public TaskHintType hintType; // 0x04
		public DailyTaskExcelConfig dailyTask; // 0x08
		public RandTaskExcelConfig randTask; // 0x10
		public RoutineDetailExcelConfig routine; // 0x18
		public string description; // 0x20
		public HintState state; // 0x28
	}

	private enum HintState // TypeDefIndex: 29602
	{
		InActive = 0,
		Show = 1,
		FadeOut = 2
	}

	private struct ReminderData // TypeDefIndex: 29603
	{
		// Fields
		public bool valid; // 0x00
		public string content; // 0x08
		public ReminderDataState state; // 0x10
		public bool contentIsNext; // 0x14
	}

	private enum ReminderDataState // TypeDefIndex: 29604
	{
		Inactive = 0,
		Active = 1,
		FadeOut = 2
	}

	private enum ChallengeHintType // TypeDefIndex: 29605
	{
		Start = 0,
		Complete = 1,
		Fail = 2
	}

	private enum ChallengeHintStateType // TypeDefIndex: 29606
	{
		InActive = 0,
		Show = 1
	}

	private struct ChallengeData // TypeDefIndex: 29607
	{
		// Fields
		public bool valid; // 0x00
		public ChallengeHintStateType state; // 0x04
		public ChallengeHintType hintType; // 0x08
		public DungeonChallengeConfig config; // 0x10
		public string description; // 0x18
		public string subDescription; // 0x20
		public bool isNewRecord; // 0x28
		public uint challengeRecordType; // 0x2C
		public uint currentValue; // 0x30
		public uint challengeIndex; // 0x34
	}

	private struct BlossomChallengeData // TypeDefIndex: 29608
	{
		// Fields
		public bool valid; // 0x00
		public ChallengeHintStateType state; // 0x04
		public ChallengeHintType hintType; // 0x08
		public BlossomGroupsExcelConfig config; // 0x10
	}

	private struct HuntingChallengeData // TypeDefIndex: 29609
	{
		// Fields
		public bool valid; // 0x00
		public ChallengeHintStateType state; // 0x04
		public ChallengeHintType hintType; // 0x08
		public HuntingMonsterExcelConfig config; // 0x10
	}

	private struct ExpeditionChallengeData // TypeDefIndex: 29610
	{
		// Fields
		public bool valid; // 0x00
		public ChallengeHintStateType state; // 0x04
		public ChallengeHintType hintType; // 0x08
		public bool isPuzzleSolved; // 0x0C
	}

	private struct ActivityCommonChallengeData // TypeDefIndex: 29611
	{
		// Fields
		public bool valid; // 0x00
		public ChallengeHintStateType state; // 0x04
		public ChallengeHintType hintType; // 0x08
		public List<string> tips; // 0x10
	}

	// Constructors
	public InLevelTaskTitleDialogContext() {} // 0x0000000181677740-0x0000000181677860

	// Methods
	// [XID] // 0x0000000189B8B650-0x0000000189B8B670
	public override void SetupView() {} // 0x0000000181677540-0x0000000181677600
	// [XID] // 0x0000000189B92D80-0x0000000189B92DA0
	public override void ClearView() {} // 0x0000000181673E50-0x0000000181673F40
	// [XID] // 0x0000000189B9A360-0x0000000189B9A380
	public override void UpdateView() {} // 0x0000000181677600-0x0000000181677740
	// [XID] // 0x0000000189BA1A70-0x0000000189BA1A90
	private bool TickCurrentActiveHint() => default; // 0x0000000181675B20-0x0000000181675CB0
	// [XID] // 0x0000000189BA8EB0-0x0000000189BA8ED0
	protected override void OnDisable() {} // 0x0000000181676F60-0x0000000181677000
	// [IDTag] // 0x0000000189BB0660-0x0000000189BB06A0
	// [XID] // 0x0000000189BB0660-0x0000000189BB06A0
	public void AddTaskStartHint(DailyTaskExcelConfig config) {} // 0x0000000181676C20-0x0000000181676D30
	// [IDTag] // 0x0000000189BBAAE0-0x0000000189BBAB20
	// [XID] // 0x0000000189BBAAE0-0x0000000189BBAB20
	public void AddTaskStartHint(RandTaskExcelConfig config) {} // 0x0000000181676B10-0x0000000181676C20
	// [XID] // 0x0000000189BC56E0-0x0000000189BC5700
	public void AddRoutineStartHint(RoutineDetailExcelConfig config) {} // 0x0000000181673C60-0x0000000181673D70
	// [IDTag] // 0x0000000189BCD0E0-0x0000000189BCD120
	// [XID] // 0x0000000189BCD0E0-0x0000000189BCD120
	public void AddTaskCompleteHint(DailyTaskExcelConfig config) {} // 0x0000000181674CD0-0x0000000181674DE0
	// [IDTag] // 0x0000000189BD74F0-0x0000000189BD7530
	// [XID] // 0x0000000189BD74F0-0x0000000189BD7530
	public void AddTaskCompleteHint(RandTaskExcelConfig config) {} // 0x0000000181674DE0-0x0000000181674EF0
	// [XID] // 0x00000001895E70F0-0x00000001895E7110
	public void AddRoutineCompleteHint(RoutineDetailExcelConfig config) {} // 0x00000001816754C0-0x00000001816755D0
	// [XID] // 0x00000001895EEA40-0x00000001895EEA60
	public void AddTaskFailHint(DailyTaskExcelConfig config) {} // 0x0000000181674870-0x0000000181674980
	// [XID] // 0x00000001895F6400-0x00000001895F6420
	public void AddRandTaskFail(RandTaskExcelConfig config) {} // 0x0000000181677000-0x0000000181677110
	// [XID] // 0x00000001895FD730-0x00000001895FD750
	public void AddRoutineFail(RoutineDetailExcelConfig config) {} // 0x00000001816764E0-0x00000001816765F0
	// [XID] // 0x0000000189604FC0-0x0000000189604FE0
	private void ShowTaskTitleHint() {} // 0x0000000181673170-0x00000001816737B0
	// [XID] // 0x000000018960CA30-0x000000018960CA50
	private bool TickTaskHint() => default; // 0x0000000181672E30-0x0000000181672F70
	// [XID] // 0x0000000189613FA0-0x0000000189613FC0
	public void AddTaskDescriptionHint(string content) {} // 0x0000000181675A60-0x0000000181675B20
	// [XID] // 0x000000018961B900-0x000000018961B920
	public void RemoveTaskDescriptionHint() {} // 0x0000000181673F40-0x00000001816740A0
	// [XID] // 0x0000000189622EE0-0x0000000189622F00
	private bool TickReminder() => default; // 0x0000000181675020-0x00000001816752F0
	// [XID] // 0x000000018962A6D0-0x000000018962A6F0
	private void CheckReminderOnEnable() {} // 0x0000000181673030-0x0000000181673170
	// [XID] // 0x0000000189631E10-0x0000000189631E30
	private void ClearReminder() {} // 0x00000001816773A0-0x0000000181677460
	// [XID] // 0x0000000189639970-0x0000000189639990
	public void AddChallengeBegin(DungeonChallengeConfig config, uint challengeIndex) {} // 0x0000000181676D30-0x0000000181676F60
	// [XID] // 0x0000000189640E00-0x0000000189640E20
	private void OnDungeonChallengeBegin() {} // 0x0000000181677110-0x00000001816773A0
	// [XID] // 0x0000000189648730-0x0000000189648750
	public void AddChallengeFinishHint(DungeonChallengeConfig config, bool success, bool isNewRecord = false /* Metadata: 0x00B0F9F7 */, uint challengeRecordType = 0 /* Metadata: 0x00B0F9F8 */, uint currentValue = 0 /* Metadata: 0x00B0F9FC */) {} // 0x00000001816745F0-0x0000000181674870
	// [XID] // 0x000000018964FE20-0x000000018964FE40
	private void OnDungeonChallengeComplete() {} // 0x0000000181676810-0x0000000181676B10
	// [XID] // 0x00000001896576E0-0x0000000189657700
	private void OnDungeonChallengeFail() {} // 0x0000000181673930-0x0000000181673AA0
	// [XID] // 0x000000018965ED60-0x000000018965ED80
	private bool TickChallengeHint() => default; // 0x0000000181674250-0x00000001816743A0
	// [XID] // 0x0000000189666460-0x0000000189666480
	private bool TryShowBufferedChallengeHint() => default; // 0x00000001816763C0-0x00000001816764E0
	// [XID] // 0x000000018966DC40-0x000000018966DC60
	public void AddBlossomChallengeBegin(uint groupID) {} // 0x00000001816740A0-0x0000000181674190
	// [XID] // 0x0000000189675A20-0x0000000189675A40
	private void OnBlossomChallengeBegin() {} // 0x0000000181676150-0x00000001816763C0
	// [XID] // 0x000000018967D310-0x000000018967D330
	public void AddBlossomChallengeFinishHint(uint groupID, bool success) {} // 0x0000000181673D70-0x0000000181673E50
	// [XID] // 0x00000001896849E0-0x0000000189684A00
	private void OnBlossomChallengeComplete() {} // 0x00000001816737B0-0x0000000181673930
	// [XID] // 0x000000018968C5B0-0x000000018968C5D0
	private void OnBlossomChallengeFail() {} // 0x00000001816752F0-0x0000000181675460
	// [XID] // 0x0000000189694000-0x0000000189694020
	private bool TickBlossomChallengeHint() => default; // 0x0000000181674B80-0x0000000181674CD0
	// [XID] // 0x000000018969B570-0x000000018969B590
	public void AddHuntingChallengeBegin(uint monsterConfigId) {} // 0x0000000181677460-0x0000000181677540
	// [XID] // 0x00000001896A2CF0-0x00000001896A2D10
	private void OnHuntingChallengeBegin() {} // 0x0000000181673AA0-0x0000000181673C60
	// [XID] // 0x00000001896AA1A0-0x00000001896AA1C0
	public void AddHuntingChallengeFinishHint(bool success) {} // 0x0000000181672F70-0x0000000181673030
	// [XID] // 0x00000001896B0F80-0x00000001896B0FA0
	private void OnHuntingChallengeComplete() {} // 0x0000000181672940-0x0000000181672B20
	// [XID] // 0x00000001896B8BB0-0x00000001896B8BD0
	private void OnHuntingChallengeFail() {} // 0x0000000181675D70-0x0000000181675F30
	// [XID] // 0x00000001896BFDD0-0x00000001896BFDF0
	private bool TickHuntingChallengeHint() => default; // 0x0000000181675F30-0x0000000181676080
	// [XID] // 0x00000001896C76D0-0x00000001896C76F0
	public void AddExpeditionChallengeBegin(bool isPuzzleSolve) {} // 0x0000000181676080-0x0000000181676150
	// [XID] // 0x00000001896CEE50-0x00000001896CEE70
	private void OnExpeditionChallengeBegin() {} // 0x00000001816765F0-0x0000000181676810
	// [XID] // 0x00000001896D6230-0x00000001896D6250
	public void AddExpeditionChallengeFinishHint(bool success) {} // 0x0000000181672B20-0x0000000181672BE0
	// [XID] // 0x00000001896DD850-0x00000001896DD870
	private void OnExpeditionChallengeComplete() {} // 0x00000001816749E0-0x0000000181674B80
	// [XID] // 0x00000001896E4EE0-0x00000001896E4F00
	private bool TickExpeditionChallengeHint() => default; // 0x0000000181674EF0-0x0000000181675020
	// [XID] // 0x00000001896EC3E0-0x00000001896EC400
	public void AddActivityCommonChallengeStart(List<string> tips) {} // 0x0000000181675CB0-0x0000000181675D70
	// [XID] // 0x00000001896F3B70-0x00000001896F3B90
	private void OnActivityCommonChallengeStart() {} // 0x00000001816743A0-0x00000001816745F0
	// [XID] // 0x00000001896FB2E0-0x00000001896FB300
	public void AddActivityCommonChallengeFinish(List<string> tips) {} // 0x0000000181675690-0x0000000181675750
	// [XID] // 0x0000000189702A90-0x0000000189702AB0
	private void OnActivityCommonChallengeFinish() {} // 0x00000001816758A0-0x0000000181675A60
	// [XID] // 0x000000018970A1B0-0x000000018970A1D0
	public void AddActivityCommonChallengeFail(List<string> tips) {} // 0x0000000181674190-0x0000000181674250
	// [XID] // 0x0000000189711C90-0x0000000189711CB0
	private void OnActivityCommonChallengeFail() {} // 0x0000000181672BE0-0x0000000181672E30
	// [XID] // 0x00000001897190F0-0x0000000189719110
	private bool TickActivityCommonChallengeHint() => default; // 0x0000000181675750-0x00000001816758A0
}

