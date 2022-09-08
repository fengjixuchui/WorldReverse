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

public sealed class ForgingPageContext : BasePageContext // TypeDefIndex: 29093
{
	// Fields
	private MonoForgingPage _pageMono; // 0x190
	private bool _isQueueView; // 0x198
	private Dictionary<uint, List<uint>> _forgeDic; // 0x1A0
	private uint _forgeType; // 0x1A8
	private int _selectedIndex; // 0x1AC
	private uint _selectedItemId; // 0x1B0
	private uint _minCount; // 0x1B4
	private uint _maxCount; // 0x1B8
	private uint _selectedCount; // 0x1BC
	private bool _forgePointEnough; // 0x1C0
	private List<uint> _avatarList; // 0x1C8
	private uint _selectedAvatarId; // 0x1D0
	private uint _toSelectAvatarId; // 0x1D4
	private int _toSelectAvatarIndex; // 0x1D8
	private Dictionary<uint, uint> _bonusAvatarDic; // 0x1E0
	private SortType _sortType; // 0x1E8
	private bool _isAsce; // 0x1EC
	private bool _screenOpen; // 0x1ED
	private List<uint> _screenTypeList; // 0x1F0
	private List<IdCountConfig> _foodItemList; // 0x1F8
	private List<SimpleItemStruct> _itemGotList; // 0x200
	private static readonly uint _selectItemAudio; // 0x00
	private uint _queueNum; // 0x208
	private Dictionary<uint, ForgeQueueData> _queueDataDic; // 0x210
	private List<ForgeQueueStruct> _queueList; // 0x218
	private int _selectedQueueIndex; // 0x220
	private uint _countDownQueueId; // 0x224
	private uint _remainingSec; // 0x228
	private const int INPUT_STATE_FORMULAR = 0; // Metadata: 0x00B0EB78
	private const int INPUT_STATE_SCREEN = 1; // Metadata: 0x00B0EB7C
	private const int INPUT_STATE_SORT_SELECT = 2; // Metadata: 0x00B0EB80
	private const int INPUT_STATE_CHAR_SELECT = 3; // Metadata: 0x00B0EB84
	private const int INPUT_STATE_QUEUE = 4; // Metadata: 0x00B0EB88
	private const int INPUT_STATE_FETCH_ITEM = 5; // Metadata: 0x00B0EB8C
	private int _foodItemIndex; // 0x22C
	private bool _focusOnFormular; // 0x230

	// Properties
	private bool screenOpen { /* [XID] */ /* 0x0000000189A390B0-0x0000000189A390D0 */ get => default; /* [XID] */ /* 0x0000000189A40890-0x0000000189A408B0 */ set {} } // 0x0000000181D4BF30-0x0000000181D4BFE0 0x0000000181D43300-0x0000000181D43460

	// Constructors
	public ForgingPageContext() {} // 0x0000000181D4F3D0-0x0000000181D4F5A0
	static ForgingPageContext() {} // 0x0000000181D4F340-0x0000000181D4F3D0

	// Methods
	// [XID] // 0x0000000189A47F10-0x0000000189A47F30
	public override void SetupView() {} // 0x0000000181D4F000-0x0000000181D4F280
	// [XID] // 0x0000000189A4F6D0-0x0000000189A4F6F0
	public override void ClearView() {} // 0x0000000181D43B10-0x0000000181D43BD0
	// [XID] // 0x0000000189A56DF0-0x0000000189A56E10
	private void ResetAnimator() {} // 0x0000000181D44020-0x0000000181D44290
	// [XID] // 0x0000000189A5E920-0x0000000189A5E940
	public override void UpdateView() {} // 0x0000000181D4F280-0x0000000181D4F340
	// [XID] // 0x0000000189A66100-0x0000000189A66120
	protected override void BindViewCallbacks() {} // 0x0000000181D42B00-0x0000000181D43300
	// [XID] // 0x0000000189A6D770-0x0000000189A6D790
	protected override void BindRedPoints() {} // 0x0000000181D42A10-0x0000000181D42B00
	// [XID] // 0x0000000189A74E90-0x0000000189A74EB0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181D4E7B0-0x0000000181D4E960
	// [XID] // 0x0000000189A7CB00-0x0000000189A7CB20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181D47D20-0x0000000181D484A0
	// [XID] // 0x0000000189A84420-0x0000000189A84440
	private void SetForgingView() {} // 0x0000000181D4E960-0x0000000181D4EAB0
	// [XID] // 0x0000000189A8BD90-0x0000000189A8BDB0
	private void ResetItemScrollerFocus() {} // 0x0000000181D45F00-0x0000000181D46060
	// [XID] // 0x0000000189A93300-0x0000000189A93320
	private void RefreshForgeList() {} // 0x0000000181D460F0-0x0000000181D46600
	// [XID] // 0x0000000189A9AD20-0x0000000189A9AD40
	private void RefreshForgeView() {} // 0x0000000181D48500-0x0000000181D48800
	// [XID] // 0x0000000189AA2090-0x0000000189AA20B0
	private void RefreshForgeItem(Transform trans, int index) {} // 0x0000000181D4C270-0x0000000181D4C480
	// [XID] // 0x0000000189AA9570-0x0000000189AA9590
	private void OnForgeRowClick(int index) {} // 0x0000000181D44500-0x0000000181D44970
	// [XID] // 0x0000000189AB1470-0x0000000189AB1490
	private void RefreshForgeDetail(uint forgeId) {} // 0x0000000181D48BA0-0x0000000181D48FF0
	// [XID] // 0x0000000189AB8720-0x0000000189AB8740
	private void RefreshFoodItemSlot(Transform trans, int index) {} // 0x0000000181D427B0-0x0000000181D42A10
	// [XID] // 0x0000000189AC03F0-0x0000000189AC0410
	private void RefreshForgeCount(uint forgeId) {} // 0x0000000181D4CCE0-0x0000000181D4D360
	// [XID] // 0x0000000189AC7DC0-0x0000000189AC7DE0
	private void SetNumBtnActive(bool showTip) {} // 0x0000000181D43460-0x0000000181D43620
	// [XID] // 0x0000000189ACF300-0x0000000189ACF320
	private void RefreshQueueBtnText() {} // 0x0000000181D4D420-0x0000000181D4D5B0
	// [XID] // 0x0000000189AD71D0-0x0000000189AD71F0
	private void OnSelectedCountChange() {} // 0x0000000181D44E30-0x0000000181D45300
	// [XID] // 0x0000000189ADEBB0-0x0000000189ADEBD0
	private void OnNumPlusBtnClick() {} // 0x0000000181D4D8A0-0x0000000181D4D960
	// [XID] // 0x0000000189AE6560-0x0000000189AE6580
	private void OnNumMinusBtnClick() {} // 0x0000000181D4BFE0-0x0000000181D4C0A0
	// [XID] // 0x0000000189AEDD70-0x0000000189AEDD90
	private void OnNumSliderValueChange(float value) {} // 0x0000000181D4AC10-0x0000000181D4ACE0
	// [XID] // 0x0000000189AF55A0-0x0000000189AF55C0
	private void OnForgingBtnClick() {} // 0x0000000181D45300-0x0000000181D45920
	// [XID] // 0x0000000189AFCA90-0x0000000189AFCAB0
	private void OnGetForgeStartNotify() {} // 0x0000000181D44290-0x0000000181D44400
	// [XID] // 0x0000000189B04250-0x0000000189B04270
	private void RefreshLastSelectedIndex() {} // 0x0000000181D47C00-0x0000000181D47D20
	// [XID] // 0x0000000189B0BAD0-0x0000000189B0BAF0
	private void SetForgingViewActive(bool isQueueView) {} // 0x0000000181D4A090-0x0000000181D4A5D0
	// [XID] // 0x0000000189B12FA0-0x0000000189B12FC0
	private void OnFormulaBtnClick() {} // 0x0000000181D49840-0x0000000181D49910
	// [XID] // 0x0000000189B1A6B0-0x0000000189B1A6D0
	private void OnQueueBtnClick() {} // 0x0000000181D492A0-0x0000000181D49380
	// [XID] // 0x0000000189B21CA0-0x0000000189B21CC0
	private void SetAvatarIconView() {} // 0x0000000181D4C480-0x0000000181D4C860
	// [XID] // 0x0000000189B29360-0x0000000189B29380
	private void RefreshSelectAvatar(uint avatarId, bool showCanUpImg = true /* Metadata: 0x00B0EB77 */) {} // 0x0000000181D49C50-0x0000000181D4A090
	// [XID] // 0x0000000189B30770-0x0000000189B30790
	private void OpenAvatarSelectPanel() {} // 0x0000000181D471D0-0x0000000181D473B0
	// [XID] // 0x0000000189B38010-0x0000000189B38030
	private void CloseAvatarSelectPanel() {} // 0x0000000181D45920-0x0000000181D45BF0
	// [XID] // 0x0000000189B3FA40-0x0000000189B3FA60
	private void SetAvatarSelectView() {} // 0x0000000181D4ACE0-0x0000000181D4AFC0
	// [XID] // 0x0000000189B47260-0x0000000189B47280
	private void InitToSelectAvatarIndex() {} // 0x0000000181D4C150-0x0000000181D4C270
	// [XID] // 0x0000000189B4EA80-0x0000000189B4EAA0
	private void RefreshAvatarList() {} // 0x0000000181D48800-0x0000000181D48BA0
	// [XID] // 0x0000000189B56280-0x0000000189B562A0
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x0000000181D48FF0-0x0000000181D492A0
	// [XID] // 0x0000000189B5DAA0-0x0000000189B5DAC0
	private void RefreshSelectedAvatarState() {} // 0x0000000181D49380-0x0000000181D496D0
	// [XID] // 0x0000000189B65020-0x0000000189B65040
	private void OnAvatarRowClick(int index) {} // 0x0000000181D47960-0x0000000181D47BA0
	// [XID] // 0x0000000189B6C600-0x0000000189B6C620
	private uint CheckIsBonusAvatar(uint forgeType, AvatarDataItem avatarData) => default; // 0x0000000181D4A5D0-0x0000000181D4A9A0
	// [XID] // 0x0000000189B73D90-0x0000000189B73DB0
	private bool CheckHaveBonusAvatar(uint forgeType) => default; // 0x0000000181D43E70-0x0000000181D44020
	// [XID] // 0x0000000189B7B400-0x0000000189B7B420
	private void OnSelectAvatarBtnClick() {} // 0x0000000181D4D9C0-0x0000000181D4DAC0
	// [XID] // 0x0000000189B82D20-0x0000000189B82D40
	private void OnSelectAvatar() {} // 0x0000000181D43840-0x0000000181D43900
	// [XID] // 0x0000000189B8A360-0x0000000189B8A380
	private SortType SortDropdownIndexToType(int index) => default; // 0x0000000181D4AFC0-0x0000000181D4B080
	// [XID] // 0x0000000189B91960-0x0000000189B91980
	private void OnSortTypeChange(int index) {} // 0x0000000181D4B080-0x0000000181D4B150
	// [XID] // 0x0000000189B98D20-0x0000000189B98D40
	private void SortForgeList() {} // 0x0000000181D46B10-0x0000000181D46D50
	// [XID] // 0x0000000189BA0140-0x0000000189BA0160
	private void FilterForgeList(ref List<uint> forgeList) {} // 0x0000000181D4B150-0x0000000181D4B5A0
	// [XID] // 0x0000000189BA7980-0x0000000189BA79A0
	private int CompareForgeItem(uint x, uint y) => default; // 0x0000000181D43900-0x0000000181D43B10
	// [XID] // 0x0000000189BAED10-0x0000000189BAED30
	private void ChangeSortOrder() {} // 0x0000000181D4B5A0-0x0000000181D4B790
	// [XID] // 0x0000000189BB6400-0x0000000189BB6420
	private void OnScreenBtnClick() {} // 0x0000000181D42390-0x0000000181D42590
	// [XID] // 0x0000000189BBDA40-0x0000000189BBDA60
	private void OnScreenBackClick() {} // 0x0000000181D4BCB0-0x0000000181D4BE20
	// [XID] // 0x0000000189BC5740-0x0000000189BC5760
	private void OnScreenResetClick() {} // 0x0000000181D43D50-0x0000000181D43E70
	// [XID] // 0x0000000189BCD1A0-0x0000000189BCD1C0
	private void SetScreeningView() {} // 0x0000000181D4EAB0-0x0000000181D4EE10
	// [XID] // 0x0000000189BD46A0-0x0000000189BD46C0
	private void RefreshScreeninRow(Transform trans, int index) {} // 0x0000000181D4E280-0x0000000181D4E530
	// [XID] // 0x0000000189BDC210-0x0000000189BDC230
	private void OnScreeningRowClick(int index) {} // 0x0000000181D4D5B0-0x0000000181D4D7E0
	// [XID] // 0x00000001895E8A50-0x00000001895E8A70
	private string GetForgeTypeName(uint forgeType) => default; // 0x0000000181D45DE0-0x0000000181D45F00
	// [XID] // 0x00000001895F02A0-0x00000001895F02C0
	private void OnGetForgeOutputNotify(List<SimpleItemStruct> itemList) {} // 0x0000000181D4B790-0x0000000181D4B910
	// [XID] // 0x00000001895F7D50-0x00000001895F7D70
	private void SetupForgeGotPanel() {} // 0x0000000181D43620-0x0000000181D43840
	// [XID] // 0x00000001895FF110-0x00000001895FF130
	private void OnSelectRewardStateChange(Transform trans, bool isSelect) {} // 0x0000000181D4C940-0x0000000181D4CA70
	// [XID] // 0x00000001896069B0-0x00000001896069D0
	private void RefreshItemGotSlot(Transform trans, int index) {} // 0x0000000181D44970-0x0000000181D44C20
	// [XID] // 0x000000018960E2F0-0x000000018960E310
	private void CloseItemGotPanel() {} // 0x0000000181D44400-0x0000000181D44500
	// [XID] // 0x0000000189615980-0x00000001896159A0
	private void OnForgeStopNotify(List<SimpleItemStruct> itemList) {} // 0x0000000181D43BD0-0x0000000181D43D50
	// [XID] // 0x000000018961D120-0x000000018961D140
	private void RequestForgeQueueData() {} // 0x0000000181D4C860-0x0000000181D4C940
	// [XID] // 0x0000000189624690-0x00000001896246B0
	private void OnGetForgeQueueNotify(ForgeGetQueueDataRsp rsp) {} // 0x0000000181D4DAC0-0x0000000181D4DDF0
	// [XID] // 0x000000018962BDD0-0x000000018962BDF0
	private void OnForgeQueueUpdateNotify(ForgeQueueDataNotify ntf) {} // 0x0000000181D4B910-0x0000000181D4BCB0
	// [XID] // 0x0000000189633910-0x0000000189633930
	private void SetQueueView() {} // 0x0000000181D49730-0x0000000181D49840
	// [XID] // 0x000000018963B1F0-0x000000018963B210
	private void RefreshQueueView() {} // 0x0000000181D42080-0x0000000181D42210
	// [XID] // 0x0000000189642920-0x0000000189642940
	private void RefreshQueueList() {} // 0x0000000181D46600-0x0000000181D46B10
	// [XID] // 0x000000018964A050-0x000000018964A070
	private void RefreshQueueRow(Transform trans, int index) {} // 0x0000000181D4A9A0-0x0000000181D4AC10
	// [XID] // 0x0000000189651770-0x0000000189651790
	private void OnQueueRowClick(int index) {} // 0x0000000181D49910-0x0000000181D49C50
	// [XID] // 0x0000000189658F70-0x0000000189658F90
	private void RefreshQueueDetail(ForgeQueueStruct queueStruct) {} // 0x0000000181D473B0-0x0000000181D47960
	// [XID] // 0x0000000189660640-0x0000000189660660
	private void SetFetchBtnStyle(uint finishNum) {} // 0x0000000181D4E040-0x0000000181D4E280
	// [XID] // 0x0000000189667FC0-0x0000000189667FE0
	private void OnFetchBtnClick() {} // 0x0000000181D4E5C0-0x0000000181D4E7B0
	// [XID] // 0x000000018966FA40-0x000000018966FA60
	private void OnStopBtnClick() {} // 0x0000000181D4BE20-0x0000000181D4BF30
	// [XID] // 0x0000000189677360-0x0000000189677380
	private void RequestForgeQueueStop() {} // 0x0000000181D45BF0-0x0000000181D45DE0
	// [XID] // 0x000000018967E8D0-0x000000018967E8F0
	private void UpdateTargetItemTime() {} // 0x0000000181D4EE10-0x0000000181D4F000
	// [XID] // 0x0000000189686180-0x00000001896861A0
	private void UpdateCurrItemProgress() {} // 0x0000000181D425F0-0x0000000181D427B0
	// [XID] // 0x000000018968DF70-0x000000018968DF90
	private bool CheckHaveFinishItem() => default; // 0x0000000181D42210-0x0000000181D42390
	// [XID] // 0x00000001896958C0-0x00000001896958E0
	private void SetConsoleUIStateID(int id) {} // 0x0000000181D4C0A0-0x0000000181D4C150
	// [XID] // 0x000000018969CF50-0x000000018969CF70
	private void IterateFoodItemList(bool forward) {} // 0x0000000181D4DE60-0x0000000181D4E040
	// [XID] // 0x00000001896A4220-0x00000001896A4240
	private void BackToFormula() {} // 0x0000000181D4D360-0x0000000181D4D420
	// [XID] // 0x00000001896AB7E0-0x00000001896AB800
	private void SelectFoodItem(int index) {} // 0x0000000181D4CA70-0x0000000181D4CCE0
	// [XID] // 0x00000001896B2A10-0x00000001896B2A30
	private bool HandleInputActionGamdpadCharacter(InputActionEvent actionEvent) => default; // 0x0000000181D46D50-0x0000000181D471D0
	// [XID] // 0x00000001896BA1C0-0x00000001896BA1E0
	private void RefreshNormalState() {} // 0x0000000181D44C20-0x0000000181D44E30
}

