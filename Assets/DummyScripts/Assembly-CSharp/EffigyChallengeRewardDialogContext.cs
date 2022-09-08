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

public sealed class EffigyChallengeRewardDialogContext : BaseDialogContext // TypeDefIndex: 29535
{
	// Fields
	private MonoEffigyChallengeRewardDialog _dialogMono; // 0x178
	private uint _activityID; // 0x180
	private ActivityInfo _activityInfo; // 0x188
	private List<uint> _rewardList; // 0x190
	private List<RewardItemConfig> _tempRewardList; // 0x198

	// Constructors
	public EffigyChallengeRewardDialogContext() {} // Dummy constructor
	public EffigyChallengeRewardDialogContext(uint activityId) {} // 0x0000000182D638B0-0x0000000182D639A0

	// Methods
	// [XID] // 0x0000000189B60BA0-0x0000000189B60BC0
	public override void SetupView() {} // 0x0000000182D637D0-0x0000000182D638B0
	// [XID] // 0x0000000189B68210-0x0000000189B68230
	public override void ClearView() {} // 0x0000000182D62CE0-0x0000000182D62DB0
	// [XID] // 0x0000000189B6F5B0-0x0000000189B6F5D0
	protected override void BindViewCallbacks() {} // 0x0000000182D62BC0-0x0000000182D62CE0
	// [XID] // 0x0000000189B76C30-0x0000000189B76C50
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182D636C0-0x0000000182D637D0
	// [XID] // 0x0000000189B7E1A0-0x0000000189B7E1C0
	private int SortFunc(uint x, uint y) => default; // 0x0000000182D63160-0x0000000182D63360
	// [XID] // 0x0000000189B85DC0-0x0000000189B85DE0
	private void Refresh() {} // 0x0000000182D621D0-0x0000000182D62600
	// [XID] // 0x0000000189B8CDF0-0x0000000189B8CE10
	private void RefreshRewardRow(Transform trans, int index) {} // 0x0000000182D62600-0x0000000182D62BC0
	// [XID] // 0x0000000189B945A0-0x0000000189B945C0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000182D62DB0-0x0000000182D63000
	// [XID] // 0x0000000189B9BC50-0x0000000189B9BC70
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0F87D */) {} // 0x0000000182D63450-0x0000000182D636C0
}

