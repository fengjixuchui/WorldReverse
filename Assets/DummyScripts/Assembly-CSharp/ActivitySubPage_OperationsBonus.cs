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

public sealed class ActivitySubPage_OperationsBonus : BaseSubPageContext // TypeDefIndex: 29410
{
	// Fields
	private MonoActivityOperationsBonus _pageMono; // 0x178
	private uint _activityId; // 0x180
	private OperationsBonusActivityModule.OperationsBonusActivityInfo _info; // 0x188
	private OpActivityExcelConfig _curActivityConfig; // 0x190
	private List<OpActivityBonusExcelConfig> _curBounsList; // 0x198

	// Constructors
	public ActivitySubPage_OperationsBonus() {} // Dummy constructor
	public ActivitySubPage_OperationsBonus(BasePageContext _parent, Transform _mountTrans, uint activityId) {} // 0x00000001817BE660-0x00000001817BE830

	// Methods
	// [XID] // 0x00000001897A2A40-0x00000001897A2A60
	public override void SetupView() {} // 0x00000001817BE460-0x00000001817BE660
	// [XID] // 0x00000001897A9FE0-0x00000001897AA000
	protected override void BindViewCallbacks() {} // 0x00000001817BBCB0-0x00000001817BBE10
	// [XID] // 0x00000001897B19F0-0x00000001897B1A10
	protected override void BindRedPoints() {} // 0x00000001817BBC10-0x00000001817BBCB0
	// [XID] // 0x00000001897B93F0-0x00000001897B9410
	public override bool OnNotify(Notify ntf) => default; // 0x00000001817BE2E0-0x00000001817BE460
	// [XID] // 0x00000001897C1480-0x00000001897C14A0
	private void RefreshData() {} // 0x00000001817BC0E0-0x00000001817BC5A0
	// [XID] // 0x00000001897C8EE0-0x00000001897C8F00
	private void RefreshView() {} // 0x00000001817BCBF0-0x00000001817BD300
	// [XID] // 0x00000001897D0540-0x00000001897D0560
	private void RefreshGridScrollerItem(Transform trans, int index) {} // 0x00000001817BB730-0x00000001817BBBB0
	// [XID] // 0x00000001897D8260-0x00000001897D8280
	private void OnClickGotoBtn() {} // 0x00000001817BBEA0-0x00000001817BBFF0
	// [XID] // 0x00000001897DF320-0x00000001897DF340
	private void OnBlossomBonusClicked(uint bonusId) {} // 0x00000001817BBFF0-0x00000001817BC0E0
	// [XID] // 0x00000001897E6BE0-0x00000001897E6C00
	private void OnBlossomBonusClickedTrackByCity(bool checkCity, OpActivityBonusExcelConfig bonusConfig) {} // 0x00000001817BE010-0x00000001817BE1F0
	// [XID] // 0x00000001897EE750-0x00000001897EE770
	private bool GetBlossomMarkId(bool checkCity, List<uint> refreshId, List<uint> cityId, out uint markId) {
		markId = default;
		return default;
	} // 0x00000001817BDCA0-0x00000001817BE010
	// [XID] // 0x00000001897F5FC0-0x00000001897F5FE0
	private void OnDungeonBonusClicked(uint bonusId) {} // 0x00000001817BD6A0-0x00000001817BD9B0
	// [XID] // 0x00000001897FD6E0-0x00000001897FD700
	private void OnClickDetailBtn(OpActivityExcelConfig config) {} // 0x00000001817BD9B0-0x00000001817BDB20
	// [XID] // 0x0000000189804D40-0x0000000189804D60
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001817BC600-0x00000001817BCBF0
	// [XID] // 0x000000018980C2F0-0x000000018980C310
	public override void OnParentFocusChangeed(bool focusOnSubPage) {} // 0x00000001817BD300-0x00000001817BD580
	// [XID] // 0x0000000189813AA0-0x0000000189813AC0
	private void SelectScrollState(int index, bool focusOnSubPage) {} // 0x00000001817BD580-0x00000001817BD6A0
}

