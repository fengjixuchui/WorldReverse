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

public sealed class ActivitySubPage_FlightChallenge : BaseSubPageContext // TypeDefIndex: 29396
{
	// Fields
	private MonoActivityFlightChallenge _pageMono; // 0x178
	private const string FLIGHT_PREFAB_PATH = "ART/UI/Menus/Widget/Activity/Activity_FlightChallenge"; // Metadata: 0x00B0F6EF
	private List<IdCountStrConfig> _rewardItemList; // 0x180
	private ActivityInfo _activityInfo; // 0x188
	public static readonly uint ShowTutorialId; // 0x00
	public static bool FlightChallengeOpened; // 0x04
	private MessagePushPageContext _pushPage; // 0x190

	// Constructors
	public ActivitySubPage_FlightChallenge() {} // Dummy constructor
	public ActivitySubPage_FlightChallenge(BasePageContext _parent, Transform _mountTrans) {} // 0x0000000182BF1910-0x0000000182BF1A00
	static ActivitySubPage_FlightChallenge() {} // 0x0000000182BF18A0-0x0000000182BF1910

	// Methods
	// [XID] // 0x0000000189ABA410-0x0000000189ABA430
	public override void SetupView() {} // 0x0000000182BF1560-0x0000000182BF18A0
	// [XID] // 0x0000000189AC1D60-0x0000000189AC1D80
	protected override void BindViewCallbacks() {} // 0x0000000182BEFA30-0x0000000182BEFBE0
	// [XID] // 0x0000000189AC9310-0x0000000189AC9330
	protected override void BindRedPoints() {} // 0x0000000182BEF890-0x0000000182BEFA30
	// [XID] // 0x0000000189AD0DE0-0x0000000189AD0E00
	private void Refresh() {} // 0x0000000182BEF340-0x0000000182BEF7B0
	// [XID] // 0x0000000189AD8A10-0x0000000189AD8A30
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000182BEFE70-0x0000000182BF01A0
	// [XID] // 0x0000000189AE05E0-0x0000000189AE0600
	private void OnClickQuestDetails() {} // 0x0000000182BF1350-0x0000000182BF1500
	// [XID] // 0x0000000189AE7B70-0x0000000189AE7B90
	private void OnClickGoto() {} // 0x0000000182BF0A40-0x0000000182BF0EA0
	// [XID] // 0x0000000189AEF8D0-0x0000000189AEF8F0
	private void OnClickRuleDesc() {} // 0x0000000182BEFD00-0x0000000182BEFE70
	// [XID] // 0x0000000189AF6DF0-0x0000000189AF6E10
	private void SelectReward(int index, bool focusOnParent) {} // 0x0000000182BEFBE0-0x0000000182BEFD00
	// [XID] // 0x0000000189AFE320-0x0000000189AFE340
	private void HideBtnWithParent(Component component, bool active) {} // 0x0000000182BF11F0-0x0000000182BF1350
	// [XID] // 0x0000000189B05B10-0x0000000189B05B30
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182BF0290-0x0000000182BF0A40
	// [XID] // 0x0000000189B0D2A0-0x0000000189B0D2C0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000182BF0EA0-0x0000000182BF11F0
}

