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

public sealed class RewardPreviewComponent : BaseContextComponent // TypeDefIndex: 29472
{
	// Fields
	private List<IdCountStrConfig> _rewardList; // 0x30
	private uint _rewardPreviewId; // 0x38
	private object _rewardListObj; // 0x40
	private List<RewardItemConfig> _tempRewardList; // 0x48
	private uint _rewardId; // 0x50

	// Constructors
	public RewardPreviewComponent() {} // 0x00000001849E36E0-0x00000001849E3790

	// Methods
	// [XID] // 0x0000000189BCD120-0x0000000189BCD140
	public override void Init(GameObject view) {} // 0x00000001849E2D30-0x00000001849E2E20
	// [XID] // 0x0000000189BD4660-0x0000000189BD4680
	public void SetRewards(object rewardListObj, uint rewardPreviewId = 0 /* Metadata: 0x00B0F81C */, uint rewardID = 0 /* Metadata: 0x00B0F820 */, bool forceInit = false /* Metadata: 0x00B0F824 */) {} // 0x00000001849E2F60-0x00000001849E3390
	// [XID] // 0x0000000189BDC1D0-0x0000000189BDC1F0
	private void SetRewardPreviewItem(Transform trans, int index) {} // 0x00000001849E28E0-0x00000001849E2BF0
	// [XID] // 0x00000001895E8A10-0x00000001895E8A30
	private void RefreshRewardItem(Transform trans, int index) {} // 0x00000001849E2670-0x00000001849E28E0
	// [XID] // 0x00000001895F0260-0x00000001895F0280
	private void InitMonoReusableListRewardPreview(MonoReusableList monoReusableList) {} // 0x00000001849E2BF0-0x00000001849E2D30
	// [XID] // 0x00000001895F7D30-0x00000001895F7D50
	private void InitMonoReusableListReward(MonoReusableList monoReusableList) {} // 0x00000001849E2E20-0x00000001849E2F60
	// [XID] // 0x00000001895FF0D0-0x00000001895FF0F0
	public void ShowCurrRewardDetail() {} // 0x00000001849E3390-0x00000001849E36E0
}

