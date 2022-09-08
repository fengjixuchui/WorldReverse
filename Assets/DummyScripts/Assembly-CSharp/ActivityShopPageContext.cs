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

public sealed class ActivityShopPageContext : ShopPageContext // TypeDefIndex: 28758
{
	// Fields
	private const int SECONDS_ONE_DAY = 86400; // Metadata: 0x00B0E661
	private MonoActivityShopPage _activityPageMono; // 0x230
	private Dictionary<uint, List<ShopItem>> _shopTabItemMap; // 0x238
	private Dictionary<uint, ActivityShopSheetInfo> _shopTabInfo; // 0x240
	private List<uint> _shopTabIndexList; // 0x248
	private List<ShopItem> _rawShopItemList; // 0x250
	private List<bool> _tabReqConditions; // 0x258
	private List<MonoBtnTab> _tabMonoBtns; // 0x260
	private uint _curSecondaryTabID; // 0x268
	private bool _curSecondaryTabUnlocked; // 0x26C
	private bool _curSecondaryTabPreview; // 0x26D
	private int _selectedTabIndex; // 0x270
	private static bool _shopSheetConfigLoaded; // 0x00
	private uint _activityID; // 0x274
	private ActivityScheduleInfo _scheduleInfo; // 0x278
	private ActivityInfo _activityInfo; // 0x280
	private string _lockedCondtionString; // 0x288
	private DateTime _activityBeginDate; // 0x290
	private bool _shopDataUpdated; // 0x2A0
	private bool _shopSheetUpdated; // 0x2A1
	private bool _sheetUpdateSelectTab; // 0x2A2
	private bool _joypadFocusTab; // 0x2A3

	// Constructors
	public ActivityShopPageContext() {} // 0x00000001853A48F0-0x00000001853A4B00
	static ActivityShopPageContext() {} // 0x00000001853A4890-0x00000001853A48F0

	// Methods
	// [XID] // 0x00000001898ABD80-0x00000001898ABDA0
	public override void SetupView() {} // 0x00000001853A4270-0x00000001853A4890
	// [XID] // 0x00000001898B34B0-0x00000001898B34D0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001853A3C90-0x00000001853A41C0
	// [XID] // 0x00000001898BB190-0x00000001898BB1B0
	private void InitShopSheetTabs() {} // 0x00000001853A41C0-0x00000001853A4270
	// [XID] // 0x00000001898C2540-0x00000001898C2560
	private void UpdateTabs() {} // 0x00000001853A1410-0x00000001853A1800
	// [XID] // 0x00000001898C9F60-0x00000001898C9F80
	private void RefreshTab(Transform tabTrans, int index) {} // 0x00000001853A2C60-0x00000001853A2F40
	// [XID] // 0x00000001898D15E0-0x00000001898D1600
	private void OnTabSelected(int scrollerIndex) {} // 0x00000001853A2FF0-0x00000001853A3790
	// [XID] // 0x00000001898D8E20-0x00000001898D8E40
	private void ShowNotUnlockedPage() {} // 0x00000001853A3790-0x00000001853A3B50
	// [XID] // 0x00000001898E0B10-0x00000001898E0B30
	private bool IsTabMeetCondition(uint secTabIndex, bool updateUnlockConditionText = false /* Metadata: 0x00B0E660 */) => default; // 0x00000001853A2780-0x00000001853A2BB0
	// [XID] // 0x00000001898E8650-0x00000001898E8670
	private void ClearUnlockConditionText() {} // 0x00000001853A12A0-0x00000001853A1410
	// [XID] // 0x00000001898EFE30-0x00000001898EFE50
	private void UpdateUnlockConditionText(ActivityShopSheetCond unlockCond, ActivityShopSheetInfo sheetInfo) {} // 0x00000001853A1980-0x00000001853A1DD0
	// [XID] // 0x00000001898F7670-0x00000001898F7690
	private void ClearItemSelectState() {} // 0x00000001853A1E80-0x00000001853A2000
	// [XID] // 0x00000001898FED80-0x00000001898FEDA0
	private void SelectCurrentSelectedItem() {} // 0x00000001853A3B50-0x00000001853A3C00
	// [XID] // 0x0000000189906520-0x0000000189906540
	private void InitForJoystick() {} // 0x00000001853A1800-0x00000001853A18A0
	// [XID] // 0x000000018990DF60-0x000000018990DF80
	private void SetJoypadFocusTab(bool focus) {} // 0x00000001853A2090-0x00000001853A2440
	// [XID] // 0x00000001899156D0-0x00000001899156F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001853A24A0-0x00000001853A2710
	// [XID] // 0x000000018991D100-0x000000018991D120
	protected override bool IsTabLocked() => default; // 0x00000001853A2F40-0x00000001853A2FF0
	// [XID] // 0x00000001899249B0-0x00000001899249D0
	protected override bool IsTabPreviewd() => default; // 0x00000001853A1DD0-0x00000001853A1E80
	// [XID] // 0x000000018992BF40-0x000000018992BF60
	protected override string TabLockReason() => default; // 0x00000001853A2BB0-0x00000001853A2C60
}

