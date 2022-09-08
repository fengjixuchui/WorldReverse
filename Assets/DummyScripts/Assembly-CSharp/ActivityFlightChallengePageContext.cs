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

public sealed class ActivityFlightChallengePageContext : BasePageContext // TypeDefIndex: 28402
{
	// Fields
	private MonoFlightChallengePage _pageMono; // 0x190
	public const int DAY_COUNT = 7; // Metadata: 0x00B0D735
	private ActivityInfo _activityInfo; // 0x198
	private int _curDayIndex; // 0x1A0
	private FlightDailyRecord _currRecord; // 0x1A8
	private List<FlightWatcherStruct> _currWatcherList; // 0x1B0
	private List<RewardItemConfig> _currRewardList; // 0x1B8
	private int _curMaxMedalLev; // 0x1C0
	private int _curSelectedMedalIndex; // 0x1C4
	public Action finishCallback; // 0x1C8
	private static uint LastMarkId; // 0x00
	private EMode _mode; // 0x1D0
	private MessagePushPageContext _pushPage; // 0x1D8
	private bool _focus_left; // 0x1E0
	private int _rewardIndex; // 0x1E4

	// Nested types
	private enum EMode // TypeDefIndex: 28403
	{
		Default = 0,
		InterUITrigger = 1
	}

	// Constructors
	public ActivityFlightChallengePageContext() {} // Dummy constructor
	public ActivityFlightChallengePageContext(int mode) {} // 0x00000001817093D0-0x0000000181709500
	static ActivityFlightChallengePageContext() {} // 0x0000000181709370-0x00000001817093D0

	// Methods
	// [XID] // 0x00000001897AECE0-0x00000001897AED00
	public override void SetupView() {} // 0x00000001817091F0-0x0000000181709370
	// [XID] // 0x00000001897B6AF0-0x00000001897B6B10
	protected override void BindViewCallbacks() {} // 0x0000000181703F10-0x00000001817041C0
	// [XID] // 0x00000001897BE910-0x00000001897BE930
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181708E90-0x0000000181709040
	// [XID] // 0x00000001897C6020-0x00000001897C6040
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000181708460-0x0000000181708560
	// [XID] // 0x00000001897CD880-0x00000001897CD8A0
	private void UpdateActivity(uint activityID) {} // 0x0000000181708B20-0x0000000181708BF0
	// [XID] // 0x00000001897D4DA0-0x00000001897D4DC0
	protected override void BindRedPoints() {} // 0x0000000181703CF0-0x0000000181703F10
	// [XID] // 0x00000001897DC4E0-0x00000001897DC500
	private int GetTodayIndex() => default; // 0x00000001817068B0-0x0000000181706B20
	// [XID] // 0x00000001897E3F10-0x00000001897E3F30
	private void Refresh(bool isInit) {} // 0x00000001817036B0-0x0000000181703A70
	// [XID] // 0x00000001897EBA40-0x00000001897EBA60
	private void RefreshEntryRedPoints() {} // 0x0000000181708610-0x00000001817088D0
	// [XID] // 0x00000001897F3380-0x00000001897F33A0
	private bool IsHighLevelRewardTaken(FlightDailyRecord record) => default; // 0x00000001817041C0-0x00000001817044F0
	// [XID] // 0x00000001897FABB0-0x00000001897FABD0
	private int GetMaxMedal(FlightDailyRecord record) => default; // 0x0000000181704AD0-0x0000000181704F90
	// [IDTag] // 0x0000000189802160-0x00000001898021A0
	// [XID] // 0x0000000189802160-0x00000001898021A0
	private int SortCompare(uint a, uint b) => default; // 0x00000001817051B0-0x0000000181705270
	// [XID] // 0x000000018980C370-0x000000018980C390
	private void RefreshEntry(MonoActivityFlightChallengeButton entry, FlightDailyRecord record, int dayIndex) {} // 0x0000000181704750-0x0000000181704AD0
	// [XID] // 0x0000000189813B60-0x0000000189813B80
	private void OnClickReturn() {} // 0x0000000181709040-0x00000001817090F0
	// [XID] // 0x000000018981B710-0x000000018981B730
	private void OnClickDesc() {} // 0x0000000181703A70-0x0000000181703BE0
	// [XID] // 0x0000000189822D00-0x0000000189822D20
	private void OnClickNotOpen() {} // 0x00000001817073D0-0x00000001817074B0
	// [XID] // 0x000000018982A5F0-0x000000018982A610
	private void OnClickQuestDetails(int index) {} // 0x00000001817089F0-0x0000000181708AC0
	// [IDTag] // 0x0000000189831960-0x00000001898319A0
	// [XID] // 0x0000000189831960-0x00000001898319A0
	private bool IsOpen(int dayIndex) => default; // 0x00000001817045E0-0x0000000181704750
	// [IDTag] // 0x000000018983C150-0x000000018983C190
	// [XID] // 0x000000018983C150-0x000000018983C190
	private bool IsOpen(FlightDailyRecord record) => default; // 0x00000001817044F0-0x00000001817045E0
	// [XID] // 0x0000000189846730-0x0000000189846750
	private void OnClickMedal1() {} // 0x0000000181706CB0-0x0000000181706D50
	// [XID] // 0x000000018984DCC0-0x000000018984DCE0
	private void OnClickMedal2() {} // 0x0000000181703C40-0x0000000181703CF0
	// [XID] // 0x0000000189854DA0-0x0000000189854DC0
	private void OnClickMedal3() {} // 0x0000000181708560-0x0000000181708610
	// [XID] // 0x000000018985C560-0x000000018985C580
	private void ClickMedal(int index) {} // 0x0000000181706B20-0x0000000181706CB0
	// [XID] // 0x0000000189863F20-0x0000000189863F40
	private void RefreshRightPanel(bool needAutoChoose) {} // 0x00000001817074B0-0x0000000181707ED0
	// [XID] // 0x000000018986B250-0x000000018986B270
	private void RefreshMedalButton(MonoActivityFlightMedalButton medalBtn, int index) {} // 0x0000000181704F90-0x00000001817051B0
	// [XID] // 0x00000001898725E0-0x0000000189872600
	private float CalcSliderValue(uint score, int medalLev) => default; // 0x0000000181705350-0x0000000181705630
	// [XID] // 0x000000018987A210-0x000000018987A230
	private void OnClickGoto() {} // 0x00000001817062E0-0x00000001817068B0
	// [IDTag] // 0x00000001898813F0-0x0000000189881430
	// [XID] // 0x00000001898813F0-0x0000000189881430
	private int SortCompare(FlightWatcherStruct a, FlightWatcherStruct b) => default; // 0x0000000181705270-0x0000000181705350
	// [XID] // 0x000000018988B710-0x000000018988B730
	private void RefreshWatcherRow(MonoActivityFlightChallengeListRow listRow, int index) {} // 0x0000000181706F40-0x0000000181707270
	// [XID] // 0x0000000189892E10-0x0000000189892E30
	private string GetMedalDesc(int index) => default; // 0x00000001817090F0-0x00000001817091F0
	// [XID] // 0x000000018989A490-0x000000018989A4B0
	private void OnClickTakeReward(uint watcherID) {} // 0x0000000181705920-0x0000000181705A40
	// [XID] // 0x00000001898A16F0-0x00000001898A1710
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000181705630-0x0000000181705890
	// [XID] // 0x00000001898A8F60-0x00000001898A8F80
	private void OnFocusChange(bool focusOnLeft) {} // 0x0000000181705A40-0x0000000181705D00
	// [XID] // 0x00000001898B08A0-0x00000001898B08C0
	private void HideBtnWithParent(Component component, bool active) {} // 0x0000000181707270-0x00000001817073D0
	// [XID] // 0x00000001898B7F30-0x00000001898B7F50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181705D60-0x00000001817062E0
	// [XID] // 0x00000001898BF5C0-0x00000001898BF5E0
	private void SimulateClickMedal(int index) {} // 0x0000000181708BF0-0x0000000181708E00
	// [XID] // 0x00000001898C6EE0-0x00000001898C6F00
	private void RefreshTakeRewardBtn(int index) {} // 0x0000000181707ED0-0x0000000181708030
	// [XID] // 0x00000001898CE400-0x00000001898CE420
	private void RefreshCurrentSelectedDayEntry(bool clear) {} // 0x00000001817088D0-0x00000001817089F0
	// [XID] // 0x00000001898D5E70-0x00000001898D5E90
	private void RefreshCurrentRewardItem(MonoActivityFlightChallengeListRow row, bool prev) {} // 0x0000000181708030-0x0000000181708460
	// [XID] // 0x00000001898DDB60-0x00000001898DDB80
	private void ClickCurrentRewardItem(MonoActivityFlightChallengeListRow row) {} // 0x0000000181706D50-0x0000000181706F40
}

