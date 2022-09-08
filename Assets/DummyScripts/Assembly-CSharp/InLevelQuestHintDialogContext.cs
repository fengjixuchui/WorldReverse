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
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelQuestHintDialogContext : BaseDialogContext // TypeDefIndex: 29580
{
	// Fields
	private MonoQuestHintText _questHint; // 0x178
	private MonoPrefabPlugin _prefabPlugin; // 0x180
	private bool _challengeInit; // 0x188
	private RecycledLinkedList<Tuple<QuestExcelConfigProxy, QuestHintType, string, int>> _cache; // 0x190
	private Dictionary<uint, RecycledLinkedList<Tuple<QuestExcelConfigProxy, QuestHintType, string, int>>> _cacheDic; // 0x198
	private TaskProgressHintData _taskProgressHintData; // 0x1A0
	private MonoEventTargetProgress _dailyTaskProgress; // 0x1D0
	private bool _forceRefreshDailyTaskProgress; // 0x1D8
	private MonoQuestTrace _monoTrace; // 0x1E0
	private uint _preTraceID; // 0x1E8
	private List<uint> _preSubQuestIDList; // 0x1F0
	private const float REFRESH_QUEST_POS_INTERVAL = 0.5f; // Metadata: 0x00B0F9BB
	private float _lastRefreshQuestPosTime; // 0x1F8
	private bool _needRefreshQuestPos; // 0x1FC
	private TaskProgressHintData _randTaskProgressData; // 0x200
	private MonoEventTargetProgress _randTaskProgress; // 0x230
	private TaskProgressHintData _routineProgressData; // 0x238
	private MonoEventTargetProgress _routineProgress; // 0x268
	private ChallengeProgressData _challengeData; // 0x270
	private List<LevelModule.ChallengeData> _subChallengeDataList; // 0x280
	private List<SubChallengeStatus> _subChallengeStatusList; // 0x288
	private MonoLevelChallengeSide _challengeHint; // 0x290
	private bool _challengeProcessIsShow; // 0x298
	private HashSet<uint> _processedChallengeIndexSet; // 0x2A0
	private BlossomProgressData _blossomProcessData; // 0x2A8
	private MonoLevelChallengeSide _bloosomHint; // 0x2C0
	private bool _bloosomProcessIsShow; // 0x2C8
	private MechanicusProgressData _mechanicusProcessData; // 0x2CC
	private MonoLevelChallengeSide _mechanicusHint; // 0x2F8
	private bool _mechanicusProcessIsShow; // 0x300
	private float _mechanicusTriggerTime; // 0x304
	private uint _lastBuildingPoints; // 0x308
	private bool _mechanicusNeedStartBtn; // 0x30C
	private ActivityRegionSearch _activityRegionSearchData; // 0x310
	private bool _activityRegionSearchIsShow; // 0x328
	private MonoLevelChallengeSide _activityRegionSearchHint; // 0x330
	private FleurFairDungeon _fleurFairDungeonData; // 0x338
	private bool _fleurFairDungeonIsShow; // 0x350
	private MonoLevelChallengeSide _fleurFairDungeonHint; // 0x358

	// Properties
	public MonoQuestHintText questHint { /* [XID] */ /* 0x0000000189625EA0-0x0000000189625EC0 */ get => default; } // 0x00000001815FE5A0-0x00000001815FE650 

	// Nested types
	private enum HintState // TypeDefIndex: 29581
	{
		InActive = 0,
		Showing = 1,
		FadeOut = 2,
		Suspend = 3
	}

	private struct TaskProgressHintData // TypeDefIndex: 29582
	{
		// Fields
		public bool valid; // 0x00
		public bool titleShowed; // 0x01
		public DailyTaskExcelConfig dailyTask; // 0x08
		public RandTaskExcelConfig randTask; // 0x10
		public RoutineDetailExcelConfig routine; // 0x18
		public uint finishProgress; // 0x20
		public uint currProgress; // 0x24
		public HintState hintState; // 0x28
		public bool suspend; // 0x2C

		// Properties
		public bool active { /* [XID] */ /* 0x000000018990F6A0-0x000000018990F6C0 */ get => default; } // 0x00000001816155E0-0x0000000181615610 
	}

	private struct ChallengeProgressData // TypeDefIndex: 29583
	{
		// Fields
		public bool valid; // 0x00
		public bool active; // 0x01
		public bool suspend; // 0x02
		public uint challengeIndex; // 0x04
		public DungeonChallengeConfig config; // 0x08
	}

	private struct BlossomProgressData // TypeDefIndex: 29584
	{
		// Fields
		public bool valid; // 0x00
		public bool active; // 0x01
		public bool suspend; // 0x02
		public uint groupID; // 0x04
		public uint current; // 0x08
		public uint max; // 0x0C
		public BlossomGroupsExcelConfig config; // 0x10
	}

	private struct MechanicusProgressData // TypeDefIndex: 29585
	{
		// Fields
		public bool valid; // 0x00
		public bool active; // 0x01
		public bool suspend; // 0x02
		public uint currRound; // 0x04
		public uint totalRound; // 0x08
		public uint leftMonsterNum; // 0x0C
		public uint escapedMonsterNum; // 0x10
		public uint maxEscapedMonsterNum; // 0x14
		public uint currentBuildingPoints; // 0x18
		public uint currentBuildingNum; // 0x1C
		public uint maxBuildingNum; // 0x20
		public bool isInBuildStage; // 0x24
	}

	private struct ActivityRegionSearch // TypeDefIndex: 29586
	{
		// Fields
		public bool valid; // 0x00
		public bool active; // 0x01
		public bool suspend; // 0x02
		public RegionSearchCondExcelConfig config; // 0x08
		public uint progress; // 0x10
	}

	private struct FleurFairDungeon // TypeDefIndex: 29587
	{
		// Fields
		public bool valid; // 0x00
		public bool active; // 0x01
		public bool suspend; // 0x02
		public GalleryExcelConfig config; // 0x08
		public uint progress; // 0x10
		public uint maxProgress; // 0x14
	}

	// Constructors
	public InLevelQuestHintDialogContext() {} // 0x00000001816084A0-0x0000000181608700

	// Methods
	// [XID] // 0x000000018962D840-0x000000018962D860
	public override void SetupView() {} // 0x0000000181608000-0x0000000181608230
	// [XID] // 0x00000001896353C0-0x00000001896353E0
	protected override void BindViewCallbacks() {} // 0x00000001815FC1F0-0x00000001815FC2F0
	// [XID] // 0x000000018963CA60-0x000000018963CA80
	public override void ClearView() {} // 0x00000001815FDCF0-0x00000001815FDE70
	// [XID] // 0x00000001896440E0-0x0000000189644100
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181601460-0x0000000181601850
	// [XID] // 0x000000018964B890-0x000000018964B8B0
	private void NavigateOrOpenQuestDialog() {} // 0x00000001815FEE70-0x00000001815FF0A0
	// [XID] // 0x0000000189653020-0x0000000189653040
	private void TryToRemoveFromRedPointList(uint mainId) {} // 0x0000000181603EC0-0x0000000181604080
	// [XID] // 0x000000018965A6E0-0x000000018965A700
	public void AddQuestHint(ref QuestExcelConfigProxy cfg, QuestHintType type) {} // 0x00000001815FEB80-0x00000001815FEE70
	// [XID] // 0x0000000189661D10-0x0000000189661D30
	protected override void OnEnable() {} // 0x00000001816070D0-0x0000000181607290
	// [XID] // 0x00000001896698F0-0x0000000189669910
	public override void UpdateView() {} // 0x0000000181608230-0x00000001816084A0
	// [XID] // 0x0000000189671420-0x0000000189671440
	protected override void OnDisable() {} // 0x0000000181607000-0x00000001816070D0
	// [IDTag] // 0x0000000189678CC0-0x0000000189678D00
	// [XID] // 0x0000000189678CC0-0x0000000189678D00
	public void AddTaskProgressHint(DailyTaskData taskData) {} // 0x00000001815FFB00-0x00000001815FFF40
	// [XID] // 0x0000000189683250-0x0000000189683270
	private void ShowTaskProgressHint() {} // 0x0000000181603540-0x00000001816037F0
	// [XID] // 0x000000018968AD80-0x000000018968ADA0
	private void RefreshTaskProgressHint() {} // 0x0000000181604E60-0x0000000181605180
	// [XID] // 0x0000000189692A50-0x0000000189692A70
	private void SuspendDailyTaskProgress() {} // 0x0000000181605180-0x0000000181605230
	// [XID] // 0x0000000189699DA0-0x0000000189699DC0
	public void RefreshTaskProgress() {} // 0x00000001815FDA00-0x00000001815FDAA0
	// [XID] // 0x00000001896A1500-0x00000001896A1520
	public void RemoveDailyTaskProgress() {} // 0x00000001815FBCA0-0x00000001815FBE70
	// [XID] // 0x00000001896A89A0-0x00000001896A89C0
	public void CompleteTaskProgressHint(DailyTaskData taskData) {} // 0x00000001816075A0-0x0000000181607890
	// [XID] // 0x00000001896AFB20-0x00000001896AFB40
	private bool TickDailyTaskProgress() => default; // 0x00000001816065D0-0x0000000181606940
	// [XID] // 0x00000001896B7490-0x00000001896B74B0
	private void TrySkipDailyTaskFadeOut() {} // 0x0000000181604CB0-0x0000000181604E60
	// [XID] // 0x00000001896BE5C0-0x00000001896BE5E0
	private bool CanShowTraceHint() => default; // 0x00000001815FB340-0x00000001815FB540
	// [XID] // 0x00000001896C5E30-0x00000001896C5E50
	private bool TickTaskTraceHint() => default; // 0x00000001815FB0A0-0x00000001815FB340
	// [XID] // 0x00000001896CD560-0x00000001896CD580
	private void PaimonNavigation() {} // 0x0000000181600E60-0x0000000181600F40
	// [XID] // 0x00000001896D49B0-0x00000001896D49D0
	public void ShowTaskTraceHint() {} // 0x00000001816037F0-0x0000000181603EC0
	// [XID] // 0x00000001896DC030-0x00000001896DC050
	private void SetTaskInfo() {} // 0x0000000181602760-0x0000000181602BE0
	// [XID] // 0x00000001896E37A0-0x00000001896E37C0
	private void AddQuestMark(uint id) {} // 0x00000001816053E0-0x00000001816055D0
	// [XID] // 0x00000001896EABD0-0x00000001896EABF0
	private void RefreshCurQuestMark(bool force) {} // 0x0000000181606200-0x0000000181606430
	// [XID] // 0x00000001896F1F80-0x00000001896F1FA0
	private void SetQuestInfo(uint questID) {} // 0x00000001815FCD50-0x00000001815FD540
	// [XID] // 0x00000001896F9940-0x00000001896F9960
	private void SetSubQuestDesc(QuestExcelConfigProxy cfg) {} // 0x00000001815FC880-0x00000001815FCB10
	// [XID] // 0x0000000189701170-0x0000000189701190
	public void StopTrace() {} // 0x00000001815FBBC0-0x00000001815FBCA0
	// [XID] // 0x0000000189708860-0x0000000189708880
	private void ClearTraceInfo() {} // 0x00000001816045A0-0x0000000181604660
	// [XID] // 0x0000000189710170-0x0000000189710190
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181607350-0x00000001816075A0
	// [IDTag] // 0x0000000189717550-0x0000000189717590
	// [XID] // 0x0000000189717550-0x0000000189717590
	public void AddTaskProgressHint(RandTaskData taskData) {} // 0x00000001815FFF40-0x0000000181600060
	// [XID] // 0x0000000189721D90-0x0000000189721DB0
	private void ShowRandTaskProgress() {} // 0x0000000181606940-0x0000000181606B50
	// [XID] // 0x0000000189729460-0x0000000189729480
	private void SuspendRandTaskProgress() {} // 0x00000001816030A0-0x0000000181603150
	// [XID] // 0x0000000189730C40-0x0000000189730C60
	public void RemoveRandTaskProgress() {} // 0x00000001815FA6D0-0x00000001815FA8C0
	// [XID] // 0x0000000189738570-0x0000000189738590
	public void CompleteRandTaskProgress(RandTaskData taskData) {} // 0x0000000181602DE0-0x00000001816030A0
	// [XID] // 0x0000000189740310-0x0000000189740330
	private bool TickRandTaskProgress() => default; // 0x00000001815FA8C0-0x00000001815FAAC0
	// [XID] // 0x00000001897476A0-0x00000001897476C0
	private void TrySkipRandTaskFadeOut() {} // 0x00000001815FEAD0-0x00000001815FEB80
	// [XID] // 0x000000018974EDB0-0x000000018974EDD0
	private void ClearRandTaskProgress() {} // 0x0000000181607890-0x0000000181607970
	// [XID] // 0x00000001897564A0-0x00000001897564C0
	public void AddRoutineProgressHint(RoutineDetailExcelConfig config) {} // 0x00000001815FF180-0x00000001815FF280
	// [XID] // 0x000000018975D920-0x000000018975D940
	private void ShowRoutineProgress() {} // 0x0000000181600A20-0x0000000181600C90
	// [XID] // 0x0000000189764E70-0x0000000189764E90
	private void SuspendRoutineProgress() {} // 0x0000000181602220-0x00000001816022D0
	// [XID] // 0x000000018976C930-0x000000018976C950
	public void RemoveRoutineProgress() {} // 0x00000001815FF9E0-0x00000001815FFB00
	// [XID] // 0x0000000189773DD0-0x0000000189773DF0
	public void CompleteRoutineProgress(RoutineDetailExcelConfig config) {} // 0x00000001816033A0-0x0000000181603540
	// [XID] // 0x000000018977B480-0x000000018977B4A0
	private bool TickRoutineProgress() => default; // 0x00000001815FE0B0-0x00000001815FE2B0
	// [XID] // 0x0000000189782FC0-0x0000000189782FE0
	private void TrySkipRoutineFadeOut() {} // 0x0000000181603150-0x0000000181603200
	// [XID] // 0x000000018978A470-0x000000018978A490
	private void ClearRoutineProgress() {} // 0x00000001815FF0A0-0x00000001815FF180
	// [XID] // 0x0000000189791C90-0x0000000189791CB0
	public bool IsChallengeValid(DungeonChallengeConfig config) => default; // 0x00000001815FE650-0x00000001815FE710
	// [XID] // 0x0000000189799290-0x00000001897992B0
	public void AddChallengeProgress(DungeonChallengeConfig config) {} // 0x0000000181606B50-0x0000000181606CA0
	// [XID] // 0x00000001897A11F0-0x00000001897A1210
	public void AddSubChallenge(LevelModule.ChallengeData subChallengeData) {} // 0x0000000181607C30-0x0000000181608000
	// [XID] // 0x00000001897A87E0-0x00000001897A8800
	public void TryRemoveSubChallenge(int index) {} // 0x00000001815FDE70-0x00000001815FE0B0
	// [XID] // 0x00000001897B0200-0x00000001897B0220
	private void InitChallengeData() {} // 0x0000000181604790-0x0000000181604CB0
	// [XID] // 0x00000001897B7F30-0x00000001897B7F50
	private void ShowChallangeProgress() {} // 0x0000000181601D80-0x00000001816020C0
	// [XID] // 0x00000001897C0050-0x00000001897C0070
	private void RefreshSubChallengeList() {} // 0x0000000181600060-0x0000000181600540
	// [XID] // 0x00000001897C7880-0x00000001897C78A0
	private void OnSubChallengeFinishStatusChange(uint challengeIndex, SubChallengeStatus value) {} // 0x00000001816022D0-0x00000001816025B0
	// [XID] // 0x00000001897CEB20-0x00000001897CEB40
	private void RefrechChallengeHintContent() {} // 0x00000001815FF280-0x00000001815FF760
	// [XID] // 0x00000001897D6260-0x00000001897D6280
	public override void OnInputDeviceChanged() {} // 0x0000000181607290-0x0000000181607350
	// [XID] // 0x00000001897DDB40-0x00000001897DDB60
	private void TrySetChallengeInterruptIcon() {} // 0x0000000181604660-0x0000000181604790
	// [XID] // 0x00000001897E5430-0x00000001897E5450
	private void TrySetMechanicusStartIcon() {} // 0x0000000181602120-0x0000000181602220
	// [XID] // 0x00000001897ECFD0-0x00000001897ECFF0
	private void SetChallengeInterruptIcon(MonoControlElement keyElement) {} // 0x00000001815FE2B0-0x00000001815FE5A0
	// [XID] // 0x00000001897F47F0-0x00000001897F4810
	private void OnChallengeResetConfirm() {} // 0x00000001815FDAA0-0x00000001815FDCF0
	// [XID] // 0x00000001897FC2B0-0x00000001897FC2D0
	private void OnChallengeReset(bool confirm) {} // 0x0000000181607B70-0x0000000181607C30
	// [XID] // 0x0000000189803710-0x0000000189803730
	private void RequestDungeonInterruptChallenge() {} // 0x00000001815FD860-0x00000001815FDA00
	// [XID] // 0x000000018980ACE0-0x000000018980AD00
	private void CheckOtherReset() {} // 0x00000001816025B0-0x0000000181602760
	// [XID] // 0x00000001898122D0-0x00000001898122F0
	private void OnChallengeOtherResetConfirm() {} // 0x00000001815FBE70-0x00000001815FC1F0
	// [XID] // 0x0000000189819EA0-0x0000000189819EC0
	private void OnChallengeOtherReset(bool confirm) {} // 0x00000001815FD540-0x00000001815FD780
	// [XID] // 0x00000001898216C0-0x00000001898216E0
	public void UpdateChallengeProgress(DungeonChallengeConfig config, bool triggerUpdate = false /* Metadata: 0x00B0F9B0 */, uint challengeIndex = 0 /* Metadata: 0x00B0F9B1 */) {} // 0x00000001816018B0-0x0000000181601B30
	// [XID] // 0x0000000189828CF0-0x0000000189828D10
	public void RemoveChallengeProgress(DungeonChallengeConfig config) {} // 0x0000000181604330-0x00000001816045A0
	// [XID] // 0x00000001898300C0-0x00000001898300E0
	private void ClearChallengeProgress() {} // 0x0000000181602BE0-0x0000000181602D40
	// [XID] // 0x0000000189837840-0x0000000189837860
	private void TrySkipChallengeFadeOut() {} // 0x0000000181602D40-0x0000000181602DE0
	// [XID] // 0x000000018983EF30-0x000000018983EF50
	private bool TickChallengeProgress() => default; // 0x00000001815FC630-0x00000001815FC880
	// [XID] // 0x0000000189846550-0x0000000189846570
	public void AddBlossomProgress(uint groupID, uint current, uint max) {} // 0x00000001816012D0-0x0000000181601460
	// [XID] // 0x000000018984DB00-0x000000018984DB20
	private void ShowBlossomProgress() {} // 0x00000001816055D0-0x00000001816057C0
	// [XID] // 0x0000000189854BE0-0x0000000189854C00
	private void RefrechBloosomHintContent(uint current, uint max) {} // 0x0000000181604080-0x0000000181604330
	// [XID] // 0x000000018985C400-0x000000018985C420
	public void UpdateBloosomProgress(uint groupID, uint current, uint max, bool triggerUpdate = false /* Metadata: 0x00B0F9B5 */) {} // 0x0000000181605A40-0x0000000181605CB0
	// [XID] // 0x0000000189863D60-0x0000000189863D80
	public void RemoveBlossomProgress() {} // 0x00000001815FE710-0x00000001815FE8A0
	// [XID] // 0x000000018986B090-0x000000018986B0B0
	private void ClearBlossomProgressOnDisable() {} // 0x00000001816060F0-0x00000001816061A0
	// [XID] // 0x0000000189872460-0x0000000189872480
	private bool TickBloosomProgress() => default; // 0x00000001816057C0-0x00000001816059E0
	// [XID] // 0x000000018987A090-0x000000018987A0B0
	public void SetMechanicusNeedStartBtn(bool isNeeded) {} // 0x0000000181603200-0x00000001816032B0
	// [XID] // 0x0000000189881250-0x0000000189881270
	public void AddMechanicusProgress(InBattleMechanicusInfo info) {} // 0x0000000181600700-0x00000001816007D0
	// [XID] // 0x0000000189888820-0x0000000189888840
	private void RefreshMechanicusProgress(InBattleMechanicusInfo info) {} // 0x0000000181600540-0x0000000181600700
	// [XID] // 0x000000018988FBA0-0x000000018988FBC0
	private void ShowMechanicusProgress() {} // 0x0000000181605CB0-0x00000001816060F0
	// [XID] // 0x0000000189897060-0x0000000189897080
	private void OnMechanicusStartBtnClick() {} // 0x00000001815FD780-0x00000001815FD860
	// [XID] // 0x000000018989E5A0-0x000000018989E5C0
	private void RefrechMechanicusHintContent(MechanicusModule.MechanicusRefreshType type = MechanicusModule.MechanicusRefreshType.All /* Metadata: 0x00B0F9B6 */) {} // 0x00000001815FB540-0x00000001815FBBC0
	// [XID] // 0x00000001898A60A0-0x00000001898A60C0
	public void UpdateMechanicusProgress(InBattleMechanicusInfo info, MechanicusModule.MechanicusRefreshType type, bool triggerUpdate = false /* Metadata: 0x00B0F9BA */) {} // 0x00000001815FF760-0x00000001815FF8F0
	// [XID] // 0x00000001898AD6D0-0x00000001898AD6F0
	public void RemoveMechanicusProgress() {} // 0x0000000181607970-0x0000000181607B70
	// [XID] // 0x00000001898B4BF0-0x00000001898B4C10
	private bool TickMechanicusProgress() => default; // 0x00000001815FAAC0-0x00000001815FB0A0
	// [XID] // 0x00000001898BC720-0x00000001898BC740
	public void AddActivityRegionSearchProgress(ActivityRegion activityRegion) {} // 0x0000000181606430-0x00000001816065D0
	// [XID] // 0x00000001898C3D80-0x00000001898C3DA0
	public void RemoveActivityRegionSearchProgress() {} // 0x00000001815FE8A0-0x00000001815FEA70
	// [XID] // 0x00000001898CB5A0-0x00000001898CB5C0
	private void ShowActivityRegionSearchProgress() {} // 0x00000001815FC2F0-0x00000001815FC630
	// [XID] // 0x00000001898D2C70-0x00000001898D2C90
	public void UpdateActivityRegionSearchProgress(ActivityRegion activityRegion) {} // 0x0000000181606D30-0x0000000181607000
	// [XID] // 0x00000001898DA620-0x00000001898DA640
	private bool TickActivityRegionSearchProgress() => default; // 0x00000001816007D0-0x0000000181600A20
	// [XID] // 0x00000001898E2270-0x00000001898E2290
	public void AddFleurFairDungeonProgress(uint galleryId, uint progress, uint maxProgress) {} // 0x00000001816032B0-0x00000001816033A0
	// [XID] // 0x00000001898E9E50-0x00000001898E9E70
	public void RemoveFleurFairDungeonProgress() {} // 0x0000000181600C90-0x0000000181600E60
	// [XID] // 0x00000001898F15E0-0x00000001898F1600
	private void UpdateFleurFairDungeonHintSub() {} // 0x0000000181600FA0-0x00000001816012D0
	// [XID] // 0x00000001898F8DC0-0x00000001898F8DE0
	private void ShowFleurFairDungeonProgress() {} // 0x00000001815FCB10-0x00000001815FCD50
	// [XID] // 0x0000000189900760-0x0000000189900780
	public void UpdateFleurFairDungeonProgress(uint galleryId, uint progress, uint maxProgress) {} // 0x0000000181605230-0x00000001816053E0
	// [XID] // 0x0000000189907EB0-0x0000000189907ED0
	private bool TickFleurFairDungeonProgress() => default; // 0x0000000181601B30-0x0000000181601D80
}

