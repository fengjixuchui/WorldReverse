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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialMainPageContext : BasePageContext // TypeDefIndex: 30200
{
	// Fields
	private MonoMistTrialMainPage _pageMono; // 0x190
	private ActivityMistTrialLevelDataExcelConfig _levelConfig; // 0x198
	private List<ulong> _avatarConfigIdList; // 0x1A0
	private uint[] _selectedList; // 0x1A8
	private bool _isSelectAvatarPage; // 0x1B0
	private int _lastClickedAvatarIndex; // 0x1B4
	private MessagePushPageContext _pushPage; // 0x1B8
	private uint _tutorialID; // 0x1C0
	private SimpleSafeUInt32[] _monsterIdList; // 0x1C8
	private List<Tuple<ActivityMistTrialWatcherListDataExcelConfig, ActivityWatcherInfo>> _watcherList; // 0x1D0
	private List<RewardItemConfig> rewardList; // 0x1D8
	private List<ActivityMistTrialAvatarDataExcelConfig> _avatarList; // 0x1E0
	private MonoAvatarIcon[] _leftSelectedAvatarIcon; // 0x1E8
	private const int MAIN_PAGE = 0; // Metadata: 0x00B108BE
	private const int AVATAR_PAGE = 1; // Metadata: 0x00B108C2
	private bool _isLeftRegion; // 0x1F0

	// Constructors
	public MistTrialMainPageContext() {} // Dummy constructor
	public MistTrialMainPageContext(ActivityMistTrialLevelDataExcelConfig levelConfig) {} // 0x00000001820DA6D0-0x00000001820DA820

	// Methods
	// [XID] // 0x0000000189ADEA70-0x0000000189ADEA90
	public override void SetupView() {} // 0x00000001820DA3E0-0x00000001820DA570
	// [XID] // 0x0000000189AE6460-0x0000000189AE6480
	protected override void OnEnable() {} // 0x00000001820D9600-0x00000001820D9890
	// [XID] // 0x0000000189AEDBF0-0x0000000189AEDC10
	public override void ClearView() {} // 0x00000001820D4360-0x00000001820D4410
	// [XID] // 0x0000000189AF5480-0x0000000189AF54A0
	private void RemoveFakeDataFromDataItemManager() {} // 0x00000001820D40E0-0x00000001820D4260
	// [XID] // 0x0000000189AFC970-0x0000000189AFC990
	private void GenerateFakeAvatarItemData() {} // 0x00000001820D7760-0x00000001820D7AA0
	// [XID] // 0x0000000189B04130-0x0000000189B04150
	public override void UpdateView() {} // 0x00000001820DA570-0x00000001820DA6D0
	// [XID] // 0x0000000189B0B9D0-0x0000000189B0B9F0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001820D9A00-0x00000001820D9B20
	// [XID] // 0x0000000189B12EA0-0x0000000189B12EC0
	private void Refresh() {} // 0x00000001820D2E00-0x00000001820D2FE0
	// [XID] // 0x0000000189B1A5B0-0x0000000189B1A5D0
	private void RefreshTitle() {} // 0x00000001820D6E60-0x00000001820D6FC0
	// [XID] // 0x0000000189B21B00-0x0000000189B21B20
	private void RefreshMonsterList() {} // 0x00000001820D7BC0-0x00000001820D7D20
	// [XID] // 0x0000000189B29200-0x0000000189B29220
	private void InitMonsterItem(Transform trans, int index) {} // 0x00000001820D8100-0x00000001820D8450
	// [XID] // 0x0000000189B305D0-0x0000000189B305F0
	private void RefreshWatcherList() {} // 0x00000001820D7E20-0x00000001820D8100
	// [XID] // 0x0000000189B37EF0-0x0000000189B37F10
	private void InitWatcherList(Transform trans, int index) {} // 0x00000001820D4D50-0x00000001820D5270
	// [XID] // 0x0000000189B3F900-0x0000000189B3F920
	private void InitRewardItem(Transform trans, int index) {} // 0x00000001820D4A80-0x00000001820D4D50
	// [XID] // 0x0000000189B47160-0x0000000189B47180
	private void RequestWatchReward(uint activityId, uint watcherId) {} // 0x00000001820D7490-0x00000001820D75B0
	// [XID] // 0x0000000189B4E8C0-0x0000000189B4E8E0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001820D7D20-0x00000001820D7E20
	// [XID] // 0x0000000189B56100-0x0000000189B56120
	private void RefreshPrevAndNextArrow() {} // 0x00000001820D68A0-0x00000001820D6A40
	// [XID] // 0x0000000189B5D9E0-0x0000000189B5DA00
	private bool NextLevelIsOpen() => default; // 0x00000001820D6FC0-0x00000001820D71B0
	// [XID] // 0x0000000189B64F20-0x0000000189B64F40
	private void SetupAvatarSelectPage() {} // 0x00000001820D4260-0x00000001820D4360
	// [XID] // 0x0000000189B6C500-0x0000000189B6C520
	private void RefreshAvatarSelect() {} // 0x00000001820D4650-0x00000001820D4710
	// [XID] // 0x0000000189B73C50-0x0000000189B73C70
	private void RefreshAvatarPageTitle() {} // 0x00000001820D7AA0-0x00000001820D7BC0
	// [XID] // 0x0000000189B7B2A0-0x0000000189B7B2C0
	private void RefreshAvatarScroll() {} // 0x00000001820D5270-0x00000001820D5430
	// [XID] // 0x0000000189B82C00-0x0000000189B82C20
	private void InitAvatarItem(Transform trans, int index) {} // 0x00000001820D8E60-0x00000001820D92C0
	// [XID] // 0x0000000189B8A200-0x0000000189B8A220
	private void ResortSelectedAvatarIcon() {} // 0x00000001820D34A0-0x00000001820D3960
	// [XID] // 0x0000000189B91860-0x0000000189B91880
	private void OnAvatarBtnClick(uint trialId, MonoAvatarIcon avatarIcon) {} // 0x00000001820D9B20-0x00000001820D9EE0
	// [XID] // 0x0000000189B98C40-0x0000000189B98C60
	private void RefreshSelectedList() {} // 0x00000001820D5F10-0x00000001820D6090
	// [XID] // 0x0000000189BA0020-0x0000000189BA0040
	private void InitSelectedAvatarItem(Transform trans, int index) {} // 0x00000001820D8450-0x00000001820D88A0
	// [XID] // 0x0000000189BA7860-0x0000000189BA7880
	private void RefreshFactorScroll() {} // 0x00000001820D71B0-0x00000001820D7320
	// [XID] // 0x0000000189BAEBB0-0x0000000189BAEBD0
	private void InitFactorItem(Transform trans, int index) {} // 0x00000001820D9EE0-0x00000001820DA180
	// [XID] // 0x0000000189BB62A0-0x0000000189BB62C0
	private void OpenSelectAvatarPage() {} // 0x00000001820D3160-0x00000001820D33A0
	// [XID] // 0x0000000189BBD8E0-0x0000000189BBD900
	private void CloseSelectAvatarPage() {} // 0x00000001820D3E10-0x00000001820D40E0
	// [XID] // 0x0000000189BC5640-0x0000000189BC5660
	private void RefreshPageState() {} // 0x00000001820D59A0-0x00000001820D5F10
	// [XID] // 0x0000000189BCD020-0x0000000189BCD040
	protected override void BindViewCallbacks() {} // 0x00000001820D3960-0x00000001820D3E10
	// [XID] // 0x0000000189BD45C0-0x0000000189BD45E0
	private void OnBtnBackClick() {} // 0x00000001820D4770-0x00000001820D4810
	// [XID] // 0x0000000189BDC0F0-0x0000000189BDC110
	private void OnBtnGotoClick() {} // 0x00000001820D5430-0x00000001820D54D0
	// [XID] // 0x00000001895E88D0-0x00000001895E88F0
	private void OnBtnInstructionClick() {} // 0x00000001820D48B0-0x00000001820D49F0
	// [XID] // 0x00000001895F0160-0x00000001895F0180
	private void OnBtnCheckAvatarClick() {} // 0x00000001820D54D0-0x00000001820D57B0
	// [XID] // 0x00000001895F7C50-0x00000001895F7C70
	private void OnBtnStartChanllengeClick() {} // 0x00000001820D4410-0x00000001820D4650
	// [XID] // 0x00000001895FEF90-0x00000001895FEFB0
	private void OnBtnResonanceClick() {} // 0x00000001820D6A40-0x00000001820D6D20
	// [XID] // 0x0000000189606810-0x0000000189606830
	private void OnBtnSwitchPrevClick() {} // 0x00000001820D7320-0x00000001820D7490
	// [XID] // 0x000000018960E1B0-0x000000018960E1D0
	private void OnBtnSwitchNextClick() {} // 0x00000001820D8900-0x00000001820D8A70
	// [XID] // 0x0000000189615820-0x0000000189615840
	private void SetWatcherScrollToInit() {} // 0x00000001820D33A0-0x00000001820D34A0
	// [XID] // 0x000000018961D000-0x000000018961D020
	private void SetMonsterScrollRectToInit() {} // 0x00000001820D2FE0-0x00000001820D3160
	// [XID] // 0x0000000189624550-0x0000000189624570
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B108BA */) {} // 0x00000001820D9890-0x00000001820D9A00
	// [XID] // 0x000000018962BC50-0x000000018962BC70
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001820D5810-0x00000001820D5940
	// [XID] // 0x0000000189633770-0x0000000189633790
	private bool HandleInputActionEvent_MainPage(InputActionEvent actionEvent) => default; // 0x00000001820D6090-0x00000001820D6840
	// [XID] // 0x000000018963B030-0x000000018963B050
	private void RefreshPSFetchAndDetailBtnState() {} // 0x00000001820D92C0-0x00000001820D9570
	// [XID] // 0x0000000189642720-0x0000000189642740
	private bool HandleInputActionEvent_AvatarPage(InputActionEvent actionEvent) => default; // 0x00000001820D8A70-0x00000001820D8E60
	// [XID] // 0x0000000189649E30-0x0000000189649E50
	private void ChangeRegion(bool toRight) {} // 0x00000001820DA180-0x00000001820DA3E0
	// [XID] // 0x0000000189651550-0x0000000189651570
	private void RefreshBtnSelect() {} // 0x00000001820D6D20-0x00000001820D6E60
	// [XID] // 0x0000000189658D90-0x0000000189658DB0
	private bool IsHoverAvatarInList() => default; // 0x00000001820D75B0-0x00000001820D7760
}

