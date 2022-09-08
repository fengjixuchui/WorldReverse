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

public sealed class ActivityFoodDeliveryDialogContext : BaseDialogContext // TypeDefIndex: 28747
{
	// Fields
	private MonoActivityFoodDeliveryDialog _dialogMono; // 0x178
	private uint _scheduleId; // 0x180
	private uint _activityConfigId; // 0x184
	private int _curTaskIndex; // 0x188
	private bool _hasReward; // 0x18C
	private bool _isOpen; // 0x18D
	private bool _hasAccepted; // 0x18E
	private ActivityDeliveryDailyExcelConfig _dailyConfig; // 0x190
	private List<RewardItemConfig> _rewardItemList; // 0x198
	private uint _fatherQuestID; // 0x1A0
	private EMode _curMode; // 0x1A4
	private int _rewardIndex; // 0x1A8

	// Nested types
	private enum EMode // TypeDefIndex: 28748
	{
		Defalut = 0,
		Simple = 1
	}

	// Constructors
	public ActivityFoodDeliveryDialogContext() {} // Dummy constructor
	public ActivityFoodDeliveryDialogContext(uint questID) {} // 0x000000018513A9D0-0x000000018513AAD0
	public ActivityFoodDeliveryDialogContext(uint scheduleId, uint configId, int taskIndex, bool isOpen, bool hasAccepted) {} // 0x000000018513A880-0x000000018513A9D0

	// Methods
	// [XID] // 0x0000000189639A70-0x0000000189639A90
	public override void SetupView() {} // 0x000000018513A770-0x000000018513A880
	// [XID] // 0x0000000189640F40-0x0000000189640F60
	private bool FillInfo(uint fatherQuestID) => default; // 0x000000018513A020-0x000000018513A490
	// [XID] // 0x0000000189648830-0x0000000189648850
	private void Refresh() {} // 0x00000001851381B0-0x0000000185138B10
	// [XID] // 0x000000018964FF60-0x000000018964FF80
	private FOOD_DELIVERY_ORDER_STATE GetState(int index) => default; // 0x000000018513A490-0x000000018513A710
	// [XID] // 0x0000000189657800-0x0000000189657820
	protected override void BindViewCallbacks() {} // 0x0000000185138F70-0x0000000185139190
	// [XID] // 0x000000018965EE60-0x000000018965EE80
	private void OnGotoBtn() {} // 0x0000000185139190-0x00000001851395B0
	// [XID] // 0x00000001896665A0-0x00000001896665C0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x00000001851395B0-0x0000000185139930
	// [XID] // 0x000000018966DDA0-0x000000018966DDC0
	private void OnPrevBtnClick() {} // 0x0000000185138E40-0x0000000185138F70
	// [XID] // 0x0000000189675BA0-0x0000000189675BC0
	private void OnNextBtnClick() {} // 0x0000000185138D10-0x0000000185138E40
	// [XID] // 0x000000018967D450-0x000000018967D470
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000185139A20-0x0000000185139DD0
	// [XID] // 0x0000000189684B20-0x0000000189684B40
	private void ShowRewardItemDetail() {} // 0x0000000185139DD0-0x000000018513A020
	// [XID] // 0x000000018968C6D0-0x000000018968C6F0
	private void RefreshRewardSelectState() {} // 0x0000000185138B10-0x0000000185138D10
}

