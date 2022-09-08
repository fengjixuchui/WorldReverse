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

public sealed class GivenDialogContext : BaseDialogContext // TypeDefIndex: 29121
{
	// Fields
	private MonoGivenDialog _pageMono; // 0x178
	private ulong[] _selectedItemGuid; // 0x180
	private int _selectedTabIndex; // 0x188
	private int _tabCount; // 0x18C
	private bool _opened; // 0x190
	private BagTabConfig _tabConfig; // 0x198
	private BagTabConfig.Config _currTabConfig; // 0x1A0
	private List<BagItemSlot> _slotList; // 0x1C8
	private SortType _sortType; // 0x1D0
	private uint _relicSetID; // 0x1D4
	private int _selectedRelicSetIndex; // 0x1D8
	private List<uint> _reliquarySetIDList; // 0x1E0
	private uint _npcId; // 0x1E8
	private uint _givingId; // 0x1EC
	private uint _questId; // 0x1F0
	private Dictionary<uint, uint> _itemParams; // 0x1F8
	private List<uint> _highLightItem; // 0x200
	private Dictionary<uint, int> _markedItem; // 0x208
	private int _clickedGivenIndex; // 0x210
	private BagItemSlot _clickedBagItem; // 0x218
	private const int INPUT_STATE_DROPDOWN = 1; // Metadata: 0x00B0EC58
	private const int INPUT_STATE_ITEM_TIPS = 2; // Metadata: 0x00B0EC5C
	private const int INPUT_STATE_GIVEN_SLOTS = 3; // Metadata: 0x00B0EC60
	private float _lastGiveTime; // 0x220
	private int _selectedGivenSlotIndex; // 0x224

	// Properties
	private bool showSort { /* [XID] */ /* 0x00000001898C8810-0x00000001898C8830 */ get => default; } // 0x00000001845E58D0-0x00000001845E5990 

	// Constructors
	public GivenDialogContext() {} // Dummy constructor
	public GivenDialogContext(uint givingId, uint npcId, uint questId) {} // 0x00000001845E6E60-0x00000001845E7290

	// Methods
	// [XID] // 0x00000001897DAF10-0x00000001897DAF30
	public override void SetupView() {} // 0x00000001845E6CD0-0x00000001845E6E60
	// [XID] // 0x00000001897E2680-0x00000001897E26A0
	public override void ClearView() {} // 0x00000001845E0470-0x00000001845E0560
	// [XID] // 0x00000001897E9DF0-0x00000001897E9E10
	private void CloseItemTip() {} // 0x00000001845DFC00-0x00000001845DFCE0
	// [XID] // 0x00000001897F1A30-0x00000001897F1A50
	private void OnReturnBtnClick() {} // 0x00000001845E2640-0x00000001845E2740
	// [XID] // 0x00000001897F9200-0x00000001897F9220
	protected override void BindViewCallbacks() {} // 0x00000001845DFEB0-0x00000001845E0290
	// [XID] // 0x00000001898007D0-0x00000001898007F0
	protected override void PostProcessOfSetActive() {} // 0x00000001845E6BF0-0x00000001845E6CD0
	// [XID] // 0x0000000189807E50-0x0000000189807E70
	protected override void OnEnable() {} // 0x00000001845E66C0-0x00000001845E67D0
	// [XID] // 0x000000018980F750-0x000000018980F770
	public override bool OnNotify(Notify ntf) => default; // 0x00000001845E67D0-0x00000001845E6900
	// [XID] // 0x0000000189816E00-0x0000000189816E20
	private void TriggerNpcSpeechBubble(uint dialogID = 0 /* Metadata: 0x00B0EC54 */) {} // 0x00000001845DE890-0x00000001845DEC10
	// [XID] // 0x000000018981E670-0x000000018981E690
	private void OnItemGivingFinish() {} // 0x00000001845E6600-0x00000001845E66C0
	// [XID] // 0x0000000189825B50-0x0000000189825B70
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001845E1D80-0x00000001845E2140
	// [XID] // 0x000000018982D280-0x000000018982D2A0
	private bool HandleInputActionEventDropdown(InputActionEvent actionEvent) => default; // 0x00000001845DEC10-0x00000001845DEE00
	// [XID] // 0x00000001898349E0-0x0000000189834A00
	private bool HandleInputActionEvent_ItemTips(InputActionEvent actionEvent) => default; // 0x00000001845E3770-0x00000001845E3980
	// [XID] // 0x000000018983C0B0-0x000000018983C0D0
	private bool HandleInputActionEvent_GivenSlots(InputActionEvent actionEvent) => default; // 0x00000001845E2140-0x00000001845E2350
	// [XID] // 0x00000001898436C0-0x00000001898436E0
	private void UpdateBagItemMarkNum(uint itemID, int num) {} // 0x00000001845E23B0-0x00000001845E2640
	// [XID] // 0x000000018984AC20-0x000000018984AC40
	private void OnTakeButtonClicked() {} // 0x00000001845E0560-0x00000001845E0A00
	// [XID] // 0x0000000189851F80-0x0000000189851FA0
	private void OnSubmitButtonClicked() {} // 0x00000001845E4A70-0x00000001845E55C0
	// [XID] // 0x0000000189859840-0x0000000189859860
	private void OnBagSlotUpdate(Notify ntf) {} // 0x00000001845E5990-0x00000001845E5B00
	// [XID] // 0x00000001898609C0-0x00000001898609E0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001845E57E0-0x00000001845E58D0
	// [XID] // 0x00000001898680F0-0x0000000189868110
	private void SetupGivenContent() {} // 0x00000001845E3AB0-0x00000001845E43F0
	// [XID] // 0x000000018986F6B0-0x000000018986F6D0
	private void SelectGivenSlots() {} // 0x00000001845E36B0-0x00000001845E3770
	// [XID] // 0x0000000189876C60-0x0000000189876C80
	private void ClearGivenSlotsSelect() {} // 0x00000001845E46C0-0x00000001845E4780
	// [XID] // 0x000000018987E760-0x000000018987E780
	private void ToPrevGivenSlot() {} // 0x00000001845E1820-0x00000001845E18E0
	// [XID] // 0x0000000189885B50-0x0000000189885B70
	private void ToNextGivenSlot() {} // 0x00000001845E56E0-0x00000001845E57E0
	// [XID] // 0x000000018988CE40-0x000000018988CE60
	private void ChangeGivenSlotSelectedView(int prevIndex, int currIndex) {} // 0x00000001845DE5C0-0x00000001845DE7C0
	// [XID] // 0x0000000189894530-0x0000000189894550
	private new void Setup() {} // 0x00000001845E0AB0-0x00000001845E0DF0
	// [XID] // 0x000000018989BB00-0x000000018989BB20
	private void UpdateTab(Dictionary<int, Dictionary<int, bool>> dirtyDict) {} // 0x00000001845DFCE0-0x00000001845DFEB0
	// [XID] // 0x00000001898A2F70-0x00000001898A2F90
	private void CheckTakeButton(uint itemId) {} // 0x00000001845E0290-0x00000001845E03C0
	// [XID] // 0x00000001898AA450-0x00000001898AA470
	private void OnItemClicked(BagItemSlot itemData) {} // 0x00000001845E13A0-0x00000001845E16A0
	// [XID] // 0x00000001898B1E50-0x00000001898B1E70
	private void OnGivenSlotClick(int index) {} // 0x00000001845DEE00-0x00000001845DF3E0
	// [XID] // 0x00000001898B9AF0-0x00000001898B9B10
	private void OnPutButtonClicked() {} // 0x00000001845E2740-0x00000001845E3590
	// [XID] // 0x00000001898C0ED0-0x00000001898C0EF0
	private void OnTabClicked(int tabIndex) {} // 0x00000001845E18E0-0x00000001845E1BF0
	// [XID] // 0x00000001898D01C0-0x00000001898D01E0
	private void RefreshTabContent() {} // 0x00000001845DF4B0-0x00000001845DFC00
	// [XID] // 0x00000001898D7750-0x00000001898D7770
	private void SetupSortDropdown() {} // 0x00000001845E1120-0x00000001845E13A0
	// [XID] // 0x00000001898DF4A0-0x00000001898DF4C0
	private void OnSortTypeChanged(int index) {} // 0x00000001845E0F70-0x00000001845E1120
	// [XID] // 0x00000001898E6E60-0x00000001898E6E80
	private void ToggleSortAscend() {} // 0x00000001845E63D0-0x00000001845E6570
	// [XID] // 0x00000001898EE630-0x00000001898EE650
	private void RefreshSlotList() {} // 0x00000001845E5E00-0x00000001845E63D0
	// [XID] // 0x00000001898F5DC0-0x00000001898F5DE0
	private void OnScreenButtonClicked() {} // 0x00000001845E55C0-0x00000001845E56E0
	// [XID] // 0x00000001898FD600-0x00000001898FD620
	private void RefreshScreenOptionItem(Transform trans, int index) {} // 0x00000001845E6900-0x00000001845E6BF0
	// [XID] // 0x0000000189904EC0-0x0000000189904EE0
	private void OnScreenOptionClicked(int index) {} // 0x00000001845E3590-0x00000001845E36B0
	// [XID] // 0x000000018990C6C0-0x000000018990C6E0
	private void OpenScreenOptionScroller() {} // 0x00000001845E1730-0x00000001845E1820
	// [XID] // 0x0000000189913F70-0x0000000189913F90
	private void CancelScreenSelect() {} // 0x00000001845E43F0-0x00000001845E46C0
	// [XID] // 0x000000018991B9A0-0x000000018991B9C0
	private void ToPrevScreenOption() {} // 0x00000001845E4780-0x00000001845E4A00
	// [XID] // 0x0000000189922F20-0x0000000189922F40
	private void ToNextScreenOption() {} // 0x00000001845E5B60-0x00000001845E5E00
	// [XID] // 0x000000018992A750-0x000000018992A770
	public override void CloseDialog() {} // 0x00000001845E0E50-0x00000001845E0F70
	// [XID] // 0x0000000189931D50-0x0000000189931D70
	private void ToPrevTab() {} // 0x00000001845E03C0-0x00000001845E0470
	// [XID] // 0x0000000189939760-0x0000000189939780
	private void ToNextTab() {} // 0x00000001845E0A00-0x00000001845E0AB0
	// [XID] // 0x0000000189940A30-0x0000000189940A50
	private void ToNextSlot() {} // 0x00000001845DE7C0-0x00000001845DE890
	// [XID] // 0x00000001899482F0-0x0000000189948310
	private void ToPrevSlot() {} // 0x00000001845E1BF0-0x00000001845E1CC0
	// [XID] // 0x000000018994F9F0-0x000000018994FA10
	private void ToNextRow() {} // 0x00000001845E39E0-0x00000001845E3AB0
	// [XID] // 0x0000000189957030-0x0000000189957050
	private void ToPrevRow() {} // 0x00000001845DF3E0-0x00000001845DF4B0
}

