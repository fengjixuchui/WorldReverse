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

public sealed class ActivityMainPageContent : BasePageContext // TypeDefIndex: 29378
{
	// Fields
	public MonoActivityPage _pageMono; // 0x190
	private List<MonoBtnTab> _pageTabList; // 0x198
	private int _selectedIndex; // 0x1A0
	private List<NormalActivityInfo> openActivityList; // 0x1A8
	private uint _jumpActivityID; // 0x1B0
	private ulong lastClickHandleTime; // 0x1B8
	private const ulong clickIntervalTime = 500; // Metadata: 0x00B0F6A2

	// Constructors
	public ActivityMainPageContent() {} // Dummy constructor
	public ActivityMainPageContent(uint jumpActivityID = 0 /* Metadata: 0x00B0F69E */) {} // 0x0000000182795C50-0x0000000182795D70

	// Methods
	// [XID] // 0x0000000189A0C930-0x0000000189A0C950
	protected override void BindViewCallbacks() {} // 0x00000001827904F0-0x00000001827905F0
	// [XID] // 0x0000000189A142C0-0x0000000189A142E0
	private void OnClickCloseBtn() {} // 0x0000000182793DA0-0x0000000182793EA0
	// [XID] // 0x0000000189A1B530-0x0000000189A1B550
	public override void SetupView() {} // 0x0000000182795AE0-0x0000000182795C50
	// [XID] // 0x0000000189A22EB0-0x0000000189A22ED0
	protected override void BindRedPoints() {} // 0x0000000182790450-0x00000001827904F0
	// [XID] // 0x0000000189A2A140-0x0000000189A2A160
	private void BindRedPointsInternal() {} // 0x0000000182791FC0-0x0000000182792A70
	// [XID] // 0x0000000189A315C0-0x0000000189A315E0
	public override void ClearView() {} // 0x0000000182790E30-0x0000000182790EE0
	// [XID] // 0x0000000189A39070-0x0000000189A39090
	private new void Setup() {} // 0x00000001827911E0-0x0000000182791460
	// [XID] // 0x0000000189A40850-0x0000000189A40870
	private void RefreshTabItem(Transform trans, int index) {} // 0x0000000182791940-0x0000000182791CA0
	// [XID] // 0x0000000189A47ED0-0x0000000189A47EF0
	private void SetImageTabState(int index) {} // 0x0000000182794220-0x0000000182794370
	// [XID] // 0x0000000189A4F690-0x0000000189A4F6B0
	private void OnClickTab(int index) {} // 0x00000001827905F0-0x0000000182790B00
	// [XID] // 0x0000000189A56DB0-0x0000000189A56DD0
	private void OnClickExpeditionTab(uint activityId) {} // 0x0000000182793060-0x00000001827931B0
	// [XID] // 0x0000000189A5E8E0-0x0000000189A5E900
	private void OnClickReunionTab() {} // 0x0000000182790160-0x00000001827902A0
	// [XID] // 0x0000000189A660C0-0x0000000189A660E0
	private void OnClickTrialTab(uint activityId) {} // 0x0000000182792C50-0x0000000182792DA0
	// [XID] // 0x0000000189A6D730-0x0000000189A6D750
	private void OnClickBonusTab(uint bonusId) {} // 0x0000000182791610-0x0000000182791760
	// [XID] // 0x0000000189A74E50-0x0000000189A74E70
	private void OnClickFleurFairTab(uint activityId) {} // 0x0000000182790EE0-0x0000000182791090
	// [XID] // 0x0000000189A7CAA0-0x0000000189A7CAC0
	private void OnClickArenaChallengeTab(uint activityId) {} // 0x00000001827938D0-0x0000000182793A20
	// [XID] // 0x0000000189A843C0-0x0000000189A843E0
	private void OnClickSignInTab() {} // 0x0000000182793360-0x0000000182793440
	// [XID] // 0x0000000189A8BD30-0x0000000189A8BD50
	private void OnClickCrucibleTab(uint activityId) {} // 0x0000000182794CD0-0x0000000182794E20
	// [XID] // 0x0000000189A932A0-0x0000000189A932C0
	private void OnClickSalesManTab(uint activityId) {} // 0x0000000182791E70-0x0000000182791FC0
	// [XID] // 0x0000000189A9ACC0-0x0000000189A9ACE0
	private void OnClickNewBeeTab(uint activityId) {} // 0x0000000182793A20-0x0000000182793B70
	// [XID] // 0x0000000189AA1FF0-0x0000000189AA2010
	private void OnClickPersonalLineTab(uint activityId) {} // 0x0000000182793210-0x0000000182793360
	// [XID] // 0x0000000189AA94F0-0x0000000189AA9510
	private void OnClickAsterTab(uint activityId) {} // 0x0000000182791090-0x00000001827911E0
	// [XID] // 0x0000000189AB1430-0x0000000189AB1450
	private void OpenSignInPage() {} // 0x0000000182791CA0-0x0000000182791E70
	// [XID] // 0x0000000189AB86C0-0x0000000189AB86E0
	private void OnClickDeliveryTab() {} // 0x00000001827940E0-0x0000000182794220
	// [XID] // 0x0000000189AC03D0-0x0000000189AC03F0
	private void OnClickFlightTab() {} // 0x0000000182794370-0x00000001827944B0
	// [XID] // 0x0000000189AC7DA0-0x0000000189AC7DC0
	private void OnClickWaterSpriteTab(uint activityID) {} // 0x0000000182790B00-0x0000000182790C50
	// [XID] // 0x0000000189ACF2E0-0x0000000189ACF300
	private void OnClickDragonSpineTab(uint activityID) {} // 0x0000000182794E20-0x0000000182794F70
	// [XID] // 0x0000000189AD71B0-0x0000000189AD71D0
	private void OnClickTowerResetTab(uint activityID) {} // 0x00000001827954B0-0x0000000182795600
	// [XID] // 0x0000000189ADEB50-0x0000000189ADEB70
	private void OnClickEffigyTab(uint activityId) {} // 0x0000000182795600-0x0000000182795750
	// [XID] // 0x0000000189AE6540-0x0000000189AE6560
	private void OnClickTreasureHuntTab(uint activityID) {} // 0x0000000182793EA0-0x00000001827940E0
	// [XID] // 0x0000000189AEDD10-0x0000000189AEDD30
	private void OnClickBlessingTab(uint activityID) {} // 0x0000000182791760-0x00000001827918B0
	// [XID] // 0x0000000189AF5580-0x0000000189AF55A0
	private void OnClickLanternRiteTab(uint activityId) {} // 0x0000000182795750-0x00000001827958A0
	// [XID] // 0x0000000189AFCA70-0x0000000189AFCA90
	private void OnClickOperationsBonusTab(uint activityId) {} // 0x0000000182790C50-0x0000000182790E30
	// [XID] // 0x0000000189B04230-0x0000000189B04250
	private void OnClickMBDrakePrimoRockTab(uint activityId) {} // 0x0000000182793C50-0x0000000182793DA0
	// [XID] // 0x0000000189B0BAB0-0x0000000189B0BAD0
	private void OnClickMBEffigyIceTab(uint activityId) {} // 0x00000001827945B0-0x0000000182794700
	// [XID] // 0x0000000189B12F80-0x0000000189B12FA0
	private void OnClickActivityCoop(uint activityId) {} // 0x0000000182794B20-0x0000000182794C70
	// [XID] // 0x0000000189B1A690-0x0000000189B1A6B0
	private void OnClickMistTrialTab(uint activityId) {} // 0x0000000182793780-0x00000001827938D0
	// [XID] // 0x0000000189B21C80-0x0000000189B21CA0
	private void OnClickChannellerSlabTab(uint activityId) {} // 0x0000000182794850-0x00000001827949A0
	// [XID] // 0x0000000189B29340-0x0000000189B29360
	private void OnClickHideAndSeekTab(uint activityId) {} // 0x0000000182794700-0x0000000182794850
	// [XID] // 0x0000000189B30750-0x0000000189B30770
	private void OnClickFindHilichurlTab(uint activityId) {} // 0x00000001827902A0-0x00000001827903F0
	// [XID] // 0x0000000189B37FF0-0x0000000189B38010
	private void OnClickHomeworldTab(uint activityId) {} // 0x00000001827914C0-0x0000000182791610
	// [XID] // 0x0000000189B3FA20-0x0000000189B3FA40
	private void OnClickH5Tab(uint activityId) {} // 0x0000000182793440-0x0000000182793620
	// [XID] // 0x0000000189B47240-0x0000000189B47260
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001827944B0-0x00000001827945B0
	// [XID] // 0x0000000189B4EA60-0x0000000189B4EA80
	private void ReInit() {} // 0x0000000182792A70-0x0000000182792C50
	// [XID] // 0x0000000189B56260-0x0000000189B56280
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182795170-0x0000000182795300
	// [XID] // 0x0000000189B5DA80-0x0000000189B5DAA0
	protected override void OnEnable() {} // 0x0000000182795000-0x0000000182795170
	// [XID] // 0x0000000189B65000-0x0000000189B65020
	protected override void PostReleaseView() {} // 0x0000000182795900-0x0000000182795AE0
	// [XID] // 0x0000000189B6C5E0-0x0000000189B6C600
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182792E00-0x0000000182793060
	// [XID] // 0x0000000189B73D70-0x0000000189B73D90
	private bool IsClickInvalid() => default; // 0x0000000182793B70-0x0000000182793C50
	// [XID] // 0x0000000189B7B3E0-0x0000000189B7B400
	private void PreTab() {} // 0x00000001827949A0-0x0000000182794B20
	// [XID] // 0x0000000189B82D00-0x0000000189B82D20
	private void NextTab() {} // 0x0000000182795300-0x00000001827954B0
	// [XID] // 0x0000000189B8A300-0x0000000189B8A320
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000182793620-0x0000000182793780
}

