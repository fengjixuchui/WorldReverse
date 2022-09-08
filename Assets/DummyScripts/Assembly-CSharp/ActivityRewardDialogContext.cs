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

public sealed class ActivityRewardDialogContext : BaseDialogContext // TypeDefIndex: 28412
{
	// Fields
	private MonoActivityRewardDialog _dialogMono; // 0x178
	private uint _rewardId; // 0x180
	private bool _isTaken; // 0x184
	private uint _factor; // 0x188
	private List<RewardItemConfig> _rewardItemList; // 0x190
	private NewActivityType _activityType; // 0x198
	private List<IdCountStrConfig> _rewardPreviewList; // 0x1A0

	// Constructors
	public ActivityRewardDialogContext() {} // Dummy constructor
	public ActivityRewardDialogContext(NewActivityType activityType, uint rewardId = 0 /* Metadata: 0x00B0D745 */, bool isTaken = true /* Metadata: 0x00B0D749 */, uint factor = 0 /* Metadata: 0x00B0D74A */) {} // 0x000000018340ADA0-0x000000018340AF10

	// Methods
	// [XID] // 0x00000001899FB230-0x00000001899FB250
	public override void SetupView() {} // 0x000000018340ACD0-0x000000018340ADA0
	// [XID] // 0x0000000189A02400-0x0000000189A02420
	protected override void BindViewCallbacks() {} // 0x00000001834098D0-0x00000001834099F0
	// [XID] // 0x0000000189A09C30-0x0000000189A09C50
	private void Refresh() {} // 0x00000001834094E0-0x00000001834095B0
	// [XID] // 0x0000000189A11430-0x0000000189A11450
	private void RefreshSalesMan() {} // 0x00000001834095B0-0x00000001834098D0
	// [XID] // 0x0000000189A18800-0x0000000189A18820
	private void RefreshSeaLamp() {} // 0x0000000183409100-0x00000001834094E0
	// [XID] // 0x0000000189A1FE80-0x0000000189A1FEA0
	private void RefreshReunion() {} // 0x000000018340A9D0-0x000000018340ACD0
	// [XID] // 0x0000000189A271D0-0x0000000189A271F0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x00000001834099F0-0x0000000183409EA0
	// [XID] // 0x0000000189A2EA30-0x0000000189A2EA50
	private void RefreshRewardPreviewItem(Transform trans, int index) {} // 0x000000018340A440-0x000000018340A970
	// [XID] // 0x0000000189A362E0-0x0000000189A36300
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183409F90-0x000000018340A440
}

