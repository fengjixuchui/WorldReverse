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

public sealed class ActivityRewardDialogContextV2 : BaseDialogContext // TypeDefIndex: 28415
{
	// Fields
	private MonoActivityRewardDialog _dialogMono; // 0x178
	private uint _rewardId; // 0x180
	private uint _rewardId2; // 0x184
	private NewActivityType _activityType; // 0x188
	private List<IdCountStrConfig> _rewardPreviewList; // 0x190

	// Constructors
	public ActivityRewardDialogContextV2() {} // Dummy constructor
	public ActivityRewardDialogContextV2(NewActivityType activityType, uint rewardId = 0 /* Metadata: 0x00B0D74E */, uint rewardId2 = 0 /* Metadata: 0x00B0D752 */, bool isTaken = true /* Metadata: 0x00B0D756 */, uint factor = 0 /* Metadata: 0x00B0D757 */) {} // 0x0000000181C4CE80-0x0000000181C4CFA0

	// Methods
	// [XID] // 0x0000000189A6AC00-0x0000000189A6AC20
	public override void SetupView() {} // 0x0000000181C4CDB0-0x0000000181C4CE80
	// [XID] // 0x0000000189A722C0-0x0000000189A722E0
	protected override void BindViewCallbacks() {} // 0x0000000181C4C060-0x0000000181C4C170
	// [XID] // 0x0000000189A79F60-0x0000000189A79F80
	private void Refresh() {} // 0x0000000181C4BFA0-0x0000000181C4C060
	// [XID] // 0x0000000189A813A0-0x0000000189A813C0
	private void RefreshBlessing() {} // 0x0000000181C4C760-0x0000000181C4C910
	// [XID] // 0x0000000189A88DA0-0x0000000189A88DC0
	private void RefreshReward() {} // 0x0000000181C4C910-0x0000000181C4CD50
	// [XID] // 0x0000000189A90550-0x0000000189A90570
	private void RefreshRewardPreviewItem(Transform trans, int index) {} // 0x0000000181C4C1D0-0x0000000181C4C760
}

