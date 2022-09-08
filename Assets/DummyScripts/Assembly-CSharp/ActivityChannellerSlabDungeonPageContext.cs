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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityChannellerSlabDungeonPageContext : BasePageContext // TypeDefIndex: 30169
{
	// Fields
	private MonoActivityChannellerSlabDungeonPage _pageMono; // 0x190
	private uint _pointId; // 0x198
	private uint _activityId; // 0x19C
	private StageDataProvider _stageDataProvider; // 0x1A0
	private int _selectedStageIdx; // 0x1A8
	private MonoShopMaterial _totBestScore; // 0x1B0
	private DungeonFactorOverviewComponent _dungeonFactor; // 0x1B8
	private MonsterPreviewComponent _monsterPreview; // 0x1C0
	private RestrictionSelectComponent _timeRestrictionSelect; // 0x1C8
	private RestrictionSelectComponent _monsterHpRestrictionSelect; // 0x1D0
	private RestrictionSelectComponent _otherRestrictionSelect; // 0x1D8
	private RestrictionDataProvider _timeRestrictionDataProvider; // 0x1E0
	private RestrictionDataProvider _monsterHpRestrictionDataProvider; // 0x1E8
	private RestrictionDataProvider _otherRestrictionDataProvider; // 0x1F0
	private DifficultyDataProvider _difficultyDataProvider; // 0x1F8
	private int _selectedDifficultyIdx; // 0x200
	private ChannellerSlabPlateComponent _plate; // 0x208
	private MonoDropdownExtention _difficultyDropDown; // 0x210
	private const string DROP_DOWN_NAME = "DropDown"; // Metadata: 0x00B1084F
	private const string STAGE_INFO_NAME = "StageInfo"; // Metadata: 0x00B1085B
	private const string STAGE_LIST_NAME = "StageList"; // Metadata: 0x00B10868

	// Properties
	private MonoDropdownExtention difficultyDropDown { /* [XID] */ /* 0x00000001898FD480-0x00000001898FD4A0 */ get => default; } // 0x0000000182F01170-0x0000000182F01290 

	// Nested types
	private class StageDataProvider // TypeDefIndex: 30170
	{
		// Fields
		private List<uint> _stageIds; // 0x10

		// Properties
		public int count { /* [XID] */ /* 0x00000001899EBB80-0x00000001899EBBA0 */ get => default; } // 0x0000000182F05410-0x0000000182F054D0 
		public ActivityInfo activityInfo { /* [XID] */ /* 0x00000001899F3650-0x00000001899F3670 */ get => default; } // 0x0000000182F05160-0x0000000182F05250 
		public ChannellerSlabLoopDungeonStageInfo stageInfo { /* [XID] */ /* 0x00000001899FAFB0-0x00000001899FAFD0 */ get => default; } // 0x0000000182F04DB0-0x0000000182F04E80 

		// Nested types
		public enum RewardState // TypeDefIndex: 30171
		{
			Locked = 0,
			Normal = 1,
			CanGetReward = 2,
			RewardGot = 3
		}

		// Constructors
		public StageDataProvider() {} // 0x0000000182F05A60-0x0000000182F05C90

		// Methods
		// [XID] // 0x0000000189A02200-0x0000000189A02220
		private ChannellerSlabLoopDungeonExcelConfig GetConfig(int idx) => default; // 0x0000000182F03EF0-0x0000000182F03FD0
		// [XID] // 0x0000000189A099F0-0x0000000189A09A10
		public uint GetStageId(int idx) => default; // 0x0000000182F049E0-0x0000000182F04AB0
		// [XID] // 0x0000000189A11150-0x0000000189A11170
		public uint GetFactorGroupId(int idx) => default; // 0x0000000182F054D0-0x0000000182F055A0
		// [XID] // 0x0000000189A184E0-0x0000000189A18500
		public uint GetBestScore(int idx) => default; // 0x0000000182F04250-0x0000000182F04350
		// [XID] // 0x0000000189A1FC40-0x0000000189A1FC60
		public uint GetTotBestScore() => default; // 0x0000000182F04620-0x0000000182F04750
		// [XID] // 0x0000000189A26F90-0x0000000189A26FB0
		public string GetTitle(int idx) => default; // 0x0000000182F04180-0x0000000182F04250
		// [XID] // 0x0000000189A2E7B0-0x0000000189A2E7D0
		public bool IsLocked(int idx) => default; // 0x0000000182F04AB0-0x0000000182F04BC0
		// [XID] // 0x0000000189A36100-0x0000000189A36120
		public ulong GetUnlockTimestamp(int idx) => default; // 0x0000000182F04520-0x0000000182F04620
		// [XID] // 0x0000000189A3D6E0-0x0000000189A3D700
		public string GetUnlockTip(int idx) => default; // 0x0000000182F05250-0x0000000182F05410
		// [XID] // 0x0000000189A44DE0-0x0000000189A44E00
		public int GetFirstUnlockedStageIdx() => default; // 0x0000000182F04F70-0x0000000182F05080
		// [XID] // 0x0000000189A4C5E0-0x0000000189A4C600
		public RewardState GetRewardState(int idx) => default; // 0x0000000182F03DB0-0x0000000182F03EF0
		// [XID] // 0x0000000189A53D80-0x0000000189A53DA0
		public uint GetFirstPassRewardId(int idx) => default; // 0x0000000182F05860-0x0000000182F05930
		// [XID] // 0x0000000189A5B7B0-0x0000000189A5B7D0
		public MonsterPreviewDataProvider GetMonsterPreviewDataProvider(int idx) => default; // 0x0000000182F03FD0-0x0000000182F04180
		// [XID] // 0x0000000189A62EA0-0x0000000189A62EC0
		public DifficultyDataProvider GetDifficultyDataProvider(int idx) => default; // 0x0000000182F055A0-0x0000000182F05860
		// [XID] // 0x0000000189A6A9C0-0x0000000189A6A9E0
		public ChannellerSlabDifficulty GetLastDifficulty() => default; // 0x0000000182F04E80-0x0000000182F04F70
		// [XID] // 0x0000000189A720A0-0x0000000189A720C0
		private List<ChannellerSlabLoopDungeonConditionExcelConfig> GetMatchingRestrictions(int idx, ChannellerSlabCondition type, uint exclusiveId) => default; // 0x0000000182F04BC0-0x0000000182F04DB0
		// [XID] // 0x0000000189A79D00-0x0000000189A79D20
		public RestrictionDataProvider GetTimeRestrictionSelectDataProvider(int idx) => default; // 0x0000000182F03CC0-0x0000000182F03DB0
		// [XID] // 0x0000000189A811A0-0x0000000189A811C0
		public RestrictionDataProvider GetMonsterHpRestrictionSelectDataProvider(int idx) => default; // 0x0000000182F04430-0x0000000182F04520
		// [XID] // 0x0000000189A88BC0-0x0000000189A88BE0
		public RestrictionDataProvider GetOtherRestrictionSelectDataProvider(int idx) => default; // 0x0000000182F05930-0x0000000182F05A60
		// [XID] // 0x0000000189A90370-0x0000000189A90390
		private List<int> GetLastRestrictionIdxList(int idx, List<ChannellerSlabLoopDungeonConditionExcelConfig> restrictions) => default; // 0x0000000182F04750-0x0000000182F049E0
		// [XID] // 0x0000000189A97B60-0x0000000189A97B80
		public List<int> GetLastTimeRestrictionIdxList(int idx) => default; // 0x0000000182F05080-0x0000000182F05160
		// [XID] // 0x0000000189A9EF30-0x0000000189A9EF50
		public List<int> GetLastMonsterHpRestrictionIdxList(int idx) => default; // 0x0000000182F04350-0x0000000182F04430
		// [XID] // 0x0000000189AA6890-0x0000000189AA68B0
		public List<int> GetLastOtherRestrictionIdxList(int idx) => default; // 0x0000000182F03BA0-0x0000000182F03CC0
	}

	private class MonsterPreviewDataProvider : MonsterPreviewComponent.DataProvider // TypeDefIndex: 30172
	{
		// Fields
		private List<uint> _monsterIds; // 0x10

		// Properties
		public override int count { /* [XID] */ /* 0x0000000189AADEE0-0x0000000189AADF00 */ get => default; } // 0x0000000182EFA750-0x0000000182EFA810 
		public override bool showLevel { /* [XID] */ /* 0x0000000189AB5870-0x0000000189AB5890 */ get => default; } // 0x0000000182EFA4F0-0x0000000182EFA590 

		// Constructors
		public MonsterPreviewDataProvider() {} // Dummy constructor
		public MonsterPreviewDataProvider(List<uint> monsterIds) {} // 0x0000000182EFA810-0x0000000182EFA890

		// Methods
		// [XID] // 0x0000000189ABD210-0x0000000189ABD230
		public override uint GetMonsterId(int idx) => default; // 0x0000000182EFA680-0x0000000182EFA750
	}

	private class DifficultyDataProvider // TypeDefIndex: 30173
	{
		// Fields
		private List<uint> _difficultyIds; // 0x10

		// Constructors
		public DifficultyDataProvider() {} // Dummy constructor
		public DifficultyDataProvider(List<uint> difficultyIds) {} // 0x0000000182EE49B0-0x0000000182EE4A20

		// Methods
		// [XID] // 0x0000000189AC4C80-0x0000000189AC4CA0
		public ChannellerSlabLoopDungeonDifficultyExcelConfig GetConfig(int idx) => default; // 0x0000000182EE44A0-0x0000000182EE4580
		// [XID] // 0x0000000189ACC300-0x0000000189ACC320
		public float GetScoreRatio(int idx) => default; // 0x0000000182EE4720-0x0000000182EE4800
		// [XID] // 0x0000000189AD3DE0-0x0000000189AD3E00
		public uint GetBaseScore(int idx) => default; // 0x0000000182EE4580-0x0000000182EE4650
		// [XID] // 0x0000000189ADB8E0-0x0000000189ADB900
		public string GetName(int idx) => default; // 0x0000000182EE4800-0x0000000182EE48E0
		// [XID] // 0x0000000189AE31C0-0x0000000189AE31E0
		public uint GetDungeonId(int idx) => default; // 0x0000000182EE4650-0x0000000182EE4720
		// [XID] // 0x0000000189AEABB0-0x0000000189AEABD0
		public ChannellerSlabDifficulty GetDifficulty(int idx) => default; // 0x0000000182EE48E0-0x0000000182EE49B0
	}

	private class RestrictionDataProvider : RestrictionSelectComponent.DataProvider // TypeDefIndex: 30174
	{
		// Fields
		protected List<ChannellerSlabLoopDungeonConditionExcelConfig> _restrictionCfgs; // 0x10

		// Properties
		public override int count { /* [XID] */ /* 0x0000000189AF2480-0x0000000189AF24A0 */ get => default; } // 0x0000000184064750-0x0000000184064810 

		// Constructors
		public RestrictionDataProvider() {} // Dummy constructor
		public RestrictionDataProvider(List<ChannellerSlabLoopDungeonConditionExcelConfig> restrictionCfgs) {} // 0x00000001840648F0-0x0000000184064970

		// Methods
		// [XID] // 0x0000000189AF9E20-0x0000000189AF9E40
		public uint GetRestrictionId(int idx) => default; // 0x0000000184064590-0x0000000184064670
		// [XID] // 0x0000000189B01390-0x0000000189B013B0
		public override uint GetFactorGroupId(int idx) => default; // 0x0000000184064810-0x00000001840648F0
		// [XID] // 0x0000000189B088C0-0x0000000189B088E0
		public override uint GetExlusiveId(int idx) => default; // 0x0000000184064670-0x0000000184064750
		// [XID] // 0x0000000189B10260-0x0000000189B10280
		public override int GetScore(int idx) => default; // 0x0000000184064430-0x0000000184064510
		// [XID] // 0x0000000189B17380-0x0000000189B173A0
		public override string GetOverrideDesc(int idx) => default; // 0x0000000184063FE0-0x0000000184064330
	}

	// Constructors
	public ActivityChannellerSlabDungeonPageContext() {} // Dummy constructor
	public ActivityChannellerSlabDungeonPageContext(uint pointId) {} // 0x0000000182F03A30-0x0000000182F03BA0

	// Methods
	// [XID] // 0x000000018988CD00-0x000000018988CD20
	public override void SetupView() {} // 0x0000000182F038B0-0x0000000182F03A30
	// [XID] // 0x00000001898943F0-0x0000000189894410
	public override void ClearView() {} // 0x0000000182EFFE50-0x0000000182EFFF50
	// [XID] // 0x000000018989B960-0x000000018989B980
	protected override void BindViewCallbacks() {} // 0x0000000182EFF660-0x0000000182EFFA30
	// [XID] // 0x00000001898A2E30-0x00000001898A2E50
	private bool IsDataValid() => default; // 0x0000000182F037C0-0x0000000182F038B0
	// [XID] // 0x00000001898AA350-0x00000001898AA370
	private void CreateTotBestScore() {} // 0x0000000182F003F0-0x0000000182F005A0
	// [XID] // 0x00000001898B1D30-0x00000001898B1D50
	private void RefreshStageList() {} // 0x0000000182F026F0-0x0000000182F028F0
	// [XID] // 0x00000001898B9970-0x00000001898B9990
	private void RefreshStageListItem(Transform trans, int idx) {} // 0x0000000182F00CE0-0x0000000182F00F50
	// [XID] // 0x00000001898C0D90-0x00000001898C0DB0
	private void RefreshStageListSelectState(bool isClear = false /* Metadata: 0x00B1084A */) {} // 0x0000000182EFFA30-0x0000000182EFFC20
	// [XID] // 0x00000001898C8690-0x00000001898C86B0
	private void OnFirstPassRewardClick(int idx, uint itemId) {} // 0x0000000182F022B0-0x0000000182F02450
	// [XID] // 0x00000001898D0060-0x00000001898D0080
	private void RefreshStageInfo() {} // 0x0000000182EFEB30-0x0000000182EFEEB0
	// [XID] // 0x00000001898D7670-0x00000001898D7690
	private void RefreshFirstPassReward() {} // 0x0000000182F03170-0x0000000182F034A0
	// [XID] // 0x00000001898DF3C0-0x00000001898DF3E0
	private void RefreshPlate() {} // 0x0000000182EFFC20-0x0000000182EFFE50
	// [XID] // 0x00000001898E6D40-0x00000001898E6D60
	private void SetupSelectStagePage() {} // 0x0000000182F012F0-0x0000000182F01410
	// [XID] // 0x00000001898EE470-0x00000001898EE490
	private void OpenSelectStagePage() {} // 0x0000000182F01410-0x0000000182F015A0
	// [XID] // 0x00000001898F5CC0-0x00000001898F5CE0
	private void RefreshSelectStagePage() {} // 0x0000000182EFF150-0x0000000182EFF210
	// [XID] // 0x0000000189904D40-0x0000000189904D60
	private void RefreshDifficultyDropdown() {} // 0x0000000182F000E0-0x0000000182F002E0
	// [XID] // 0x000000018990C5C0-0x000000018990C5E0
	private void RefreshDifficultyScoreInfo() {} // 0x0000000182EFEEB0-0x0000000182EFF150
	// [XID] // 0x0000000189913E70-0x0000000189913E90
	private void RefreshSelectedRestrictionInfo() {} // 0x0000000182F020F0-0x0000000182F022B0
	// [XID] // 0x000000018991B7E0-0x000000018991B800
	private void RefreshAllRestrictionInfo() {} // 0x0000000182EFFFD0-0x0000000182F00080
	// [XID] // 0x0000000189922D80-0x0000000189922DA0
	private void ClearSelectedRestrictions(RestrictionSelectComponent component, RestrictionDataProvider dataProvider) {} // 0x0000000182F036B0-0x0000000182F037C0
	// [XID] // 0x000000018992A670-0x000000018992A690
	private void RecoverSelectedRestrictions(RestrictionSelectComponent component, List<int> idxs) {} // 0x0000000182F015A0-0x0000000182F01740
	// [XID] // 0x0000000189931C40-0x0000000189931C60
	private void SetupSelectDifficultyPage() {} // 0x0000000182F01940-0x0000000182F01A50
	// [XID] // 0x00000001899396C0-0x00000001899396E0
	private void OpenSelectDifficultyPage() {} // 0x0000000182F028F0-0x0000000182F02AE0
	// [XID] // 0x0000000189940950-0x0000000189940970
	private void RefreshSelectDifficultyPage() {} // 0x0000000182EFF210-0x0000000182EFF660
	// [XID] // 0x0000000189948210-0x0000000189948230
	private void OnDifficultyChange(int dropIndex) {} // 0x0000000182F01880-0x0000000182F01940
	// [XID] // 0x000000018994F990-0x000000018994F9B0
	private void OnBtnReturnClick() {} // 0x0000000182F00A10-0x0000000182F00AC0
	// [XID] // 0x0000000189956F50-0x0000000189956F70
	private void OnBtnSelectDifficulty_StageClick() {} // 0x0000000182F017A0-0x0000000182F01880
	// [XID] // 0x000000018995EAC0-0x000000018995EAE0
	private void OnBtnFetch_StageClick() {} // 0x0000000182F025C0-0x0000000182F026F0
	// [XID] // 0x0000000189966200-0x0000000189966220
	private void OnBtnRewardInfoClick() {} // 0x0000000182F00AC0-0x0000000182F00BE0
	// [XID] // 0x000000018996D6A0-0x000000018996D6C0
	private void OnBtnBack_DifficultyClick() {} // 0x0000000182F00BE0-0x0000000182F00C80
	// [XID] // 0x0000000189975200-0x0000000189975220
	private void OnBtnChallenge_DifficultyClick() {} // 0x0000000182F01A50-0x0000000182F01FF0
	// [XID] // 0x000000018997C3C0-0x000000018997C3E0
	private void OnBtnPlate_DifficultyClick() {} // 0x0000000182F02450-0x0000000182F02560
	// [XID] // 0x00000001899840E0-0x0000000189984100
	private void OnDifficultyClick() {} // 0x0000000182F002E0-0x0000000182F003F0
	// [XID] // 0x000000018998BC90-0x000000018998BCB0
	private void OnBtnCheckClick() {} // 0x0000000182F008B0-0x0000000182F00A10
	// [XID] // 0x0000000189993820-0x0000000189993840
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182F03020-0x0000000182F03170
	// [XID] // 0x000000018999B100-0x000000018999B120
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000182F01FF0-0x0000000182F020F0
	// [XID] // 0x00000001899A2920-0x00000001899A2940
	protected override void OnEnable() {} // 0x0000000182F02B70-0x0000000182F02C70
	// [XID] // 0x00000001899AA240-0x00000001899AA260
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182F00F50-0x0000000182F01010
	// [XID] // 0x00000001899B1C30-0x00000001899B1C50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182F01010-0x0000000182F01170
	// [XID] // 0x00000001899B8FA0-0x00000001899B8FC0
	private void SetupForJoypad() {} // 0x0000000182F034A0-0x0000000182F036B0
	// [XID] // 0x00000001899C0890-0x00000001899C08B0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B1084B */) {} // 0x0000000182F02EF0-0x0000000182F03020
	// [XID] // 0x00000001899C80E0-0x00000001899C8100
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000182F02C70-0x0000000182F02DB0
	// [XID] // 0x00000001899CFA60-0x00000001899CFA80
	public override void OnJoypadUIModuleLostFocus(MonoJoypadUIModule focusModule) {} // 0x0000000182F02DB0-0x0000000182F02EF0
}

