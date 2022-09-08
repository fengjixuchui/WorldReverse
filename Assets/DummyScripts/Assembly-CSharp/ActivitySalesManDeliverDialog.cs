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

public sealed class ActivitySalesManDeliverDialog : BaseDialogContext // TypeDefIndex: 29516
{
	// Fields
	private MonoActivitySalesManDetialDialog _dialogMono; // 0x178
	private ActivityInfo activityInfo; // 0x180
	private List<IdCountConfig> costItemList; // 0x188
	private List<RewardItemConfig> rewardItemList; // 0x190

	// Constructors
	public ActivitySalesManDeliverDialog() {} // 0x000000018260CF10-0x000000018260D030

	// Methods
	// [XID] // 0x0000000189909650-0x0000000189909670
	public override void SetupView() {} // 0x000000018260C8A0-0x000000018260CF10
	// [XID] // 0x0000000189910AE0-0x0000000189910B00
	protected override void BindViewCallbacks() {} // 0x000000018260B670-0x000000018260B940
	// [XID] // 0x00000001899186C0-0x00000001899186E0
	private void OnClickRewardInfo() {} // 0x000000018260BC70-0x000000018260BD70
	// [XID] // 0x000000018991FEC0-0x000000018991FEE0
	private void OnClickDeliver() {} // 0x000000018260C390-0x000000018260C4C0
	// [XID] // 0x0000000189927720-0x0000000189927740
	private void Refresh(uint rewardID) {} // 0x000000018260B390-0x000000018260B670
	// [XID] // 0x000000018992EEA0-0x000000018992EEC0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x000000018260BD70-0x000000018260C060
	// [XID] // 0x00000001899362B0-0x00000001899362D0
	private void RefreshNeedItem(Transform trans, int index) {} // 0x000000018260B940-0x000000018260BBC0
	// [XID] // 0x000000018993DC90-0x000000018993DCB0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018260C720-0x000000018260C8A0
	// [XID] // 0x00000001899453E0-0x0000000189945400
	private void CheckClose(uint activityId) {} // 0x000000018260C520-0x000000018260C690
	// [XID] // 0x000000018994C920-0x000000018994C940
	private void DoClose() {} // 0x000000018260BBC0-0x000000018260BC70
	// [XID] // 0x0000000189953FC0-0x0000000189953FE0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018260C230-0x000000018260C390
	// [XID] // 0x000000018995B870-0x000000018995B890
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018260C150-0x000000018260C230
}

