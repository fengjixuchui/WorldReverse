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
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BreachMaterialPreviewDialogContextV2 : BaseDialogContext // TypeDefIndex: 28920
{
	// Fields
	private MonoBreachMaterialPreviewDialogV2 _dialogMono; // 0x178
	private AvatarDataItem avatarDataItem; // 0x180
	private uint _currBreakLevel; // 0x188
	private uint _showBreakLevel; // 0x18C
	private uint _minBreakLevel; // 0x190
	private uint _maxBreakLevel; // 0x194
	private uint _coinCost; // 0x198
	private uint _avatarLevelRequired; // 0x19C
	private uint _playerLevelRequired; // 0x1A0
	private List<Tuple<BagItemSlot, uint>> _materialList; // 0x1A8
	private List<RewardItemConfig> _rewardList; // 0x1B0
	private bool _hasCurrentLevelBroke; // 0x1B8
	private bool _hasRewardAtThisLevel; // 0x1B9
	private SimpleSafeUInt32[] _avatarRewardLevelList; // 0x1C0
	private SimpleSafeUInt32[] _avatarRewardIdList; // 0x1C8
	private RewardState _rewardState; // 0x1D0

	// Nested types
	private enum RewardState // TypeDefIndex: 28921
	{
		hasReceived = 0,
		canReceived = 1,
		canNotReceived = 2
	}

	// Constructors
	public BreachMaterialPreviewDialogContextV2() {} // Dummy constructor
	public BreachMaterialPreviewDialogContextV2(AvatarDataItem avatarData) {} // 0x0000000181E87590-0x0000000181E87790

	// Methods
	// [XID] // 0x00000001897DC3E0-0x00000001897DC400
	public override void SetupView() {} // 0x0000000181E87270-0x0000000181E87590
	// [XID] // 0x00000001897E3D50-0x00000001897E3D70
	protected override void BindViewCallbacks() {} // 0x0000000181E85090-0x0000000181E85430
	// [XID] // 0x00000001897EB920-0x00000001897EB940
	protected override void BindRedPoints() {} // 0x0000000181E84E70-0x0000000181E85090
	// [XID] // 0x00000001897F3220-0x00000001897F3240
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181E86940-0x0000000181E86A20
	// [XID] // 0x00000001897FAA90-0x00000001897FAAB0
	private void RefreshCurrentData() {} // 0x0000000181E84590-0x0000000181E84D50
	// [XID] // 0x0000000189802040-0x0000000189802060
	private void RefreshCurrentView() {} // 0x0000000181E86A20-0x0000000181E87270
	// [XID] // 0x00000001898094D0-0x00000001898094F0
	private void MaterialItemRefresh(Transform trans, int index) {} // 0x0000000181E85800-0x0000000181E85BB0
	// [XID] // 0x0000000189810CE0-0x0000000189810D00
	private void OnMaterialItemClicked(int index) {} // 0x0000000181E85680-0x0000000181E85800
	// [XID] // 0x0000000189818770-0x0000000189818790
	private void RewardItemRefresh(Transform trans, int index) {} // 0x0000000181E85BB0-0x0000000181E85F20
	// [XID] // 0x0000000189820080-0x00000001898200A0
	private void OnRewardItemClicked(uint itemId, uint count) {} // 0x0000000181E85430-0x0000000181E855F0
	// [XID] // 0x0000000189827640-0x0000000189827660
	private void OnPrevTabClicked() {} // 0x0000000181E865A0-0x0000000181E86660
	// [XID] // 0x000000018982E860-0x000000018982E880
	private void OnNextTabClicked() {} // 0x0000000181E84DB0-0x0000000181E84E70
	// [XID] // 0x0000000189836200-0x0000000189836220
	private void OnStarButtonClicked(int starIndex) {} // 0x0000000181E86660-0x0000000181E86720
	// [XID] // 0x000000018983D670-0x000000018983D690
	private void RefreshView() {} // 0x0000000181E86280-0x0000000181E86500
	// [XID] // 0x0000000189844E50-0x0000000189844E70
	private void OnReceiveButtonClicked() {} // 0x0000000181E86780-0x0000000181E868B0
	// [XID] // 0x000000018984C320-0x000000018984C340
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181E85F80-0x0000000181E86280
	// [XID] // 0x00000001898534B0-0x00000001898534D0
	private void OnRewardGetRsp() {} // 0x0000000181E86500-0x0000000181E865A0
}

