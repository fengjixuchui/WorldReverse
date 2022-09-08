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

public sealed class ExplorationActivityChallengeDialog : BaseDialogContext // TypeDefIndex: 29053
{
	// Fields
	private MonoExpeditionActivityChallengeDialog _dialogMono; // 0x178
	private List<MonoExplorationMark_ActivityChallenge> _monoMarkList; // 0x180
	private MonoExplorationMark_ActivityChallenge _currSelectedMarker; // 0x188
	private int _markerSelectedIndexForJoypad; // 0x190
	private RepeatedMessageField<ExpeditionChallengeInfo> _challengeInfoList; // 0x198
	private List<RewardItemConfig> rewardList; // 0x1A0

	// Constructors
	public ExplorationActivityChallengeDialog() {} // 0x0000000181E26560-0x0000000181E26660

	// Methods
	// [XID] // 0x000000018993C7A0-0x000000018993C7C0
	public override void SetupView() {} // 0x0000000181E26130-0x0000000181E263D0
	// [XID] // 0x0000000189943DD0-0x0000000189943DF0
	private void RefreshChallengeMarkRedPoint() {} // 0x0000000181E241E0-0x0000000181E245E0
	// [XID] // 0x000000018994B2F0-0x000000018994B310
	private void AutoSelectMarker() {} // 0x0000000181E24F60-0x0000000181E251C0
	// [XID] // 0x0000000189952CA0-0x0000000189952CC0
	public override void UpdateView() {} // 0x0000000181E263D0-0x0000000181E26560
	// [XID] // 0x000000018995A250-0x000000018995A270
	public override void ClearView() {} // 0x0000000181E240E0-0x0000000181E241E0
	// [XID] // 0x0000000189961C80-0x0000000189961CA0
	protected override void BindViewCallbacks() {} // 0x0000000181E23F60-0x0000000181E240E0
	// [XID] // 0x0000000189969330-0x0000000189969350
	private void RefreshMarkers() {} // 0x0000000181E24BF0-0x0000000181E24D70
	// [XID] // 0x0000000189970DF0-0x0000000189970E10
	private void InitSimpleListMarker(Transform trans, int index) {} // 0x0000000181E23BC0-0x0000000181E23F60
	// [XID] // 0x0000000189978730-0x0000000189978750
	private void OnMarkerClick(MonoExplorationMark_ActivityChallenge monoMark) {} // 0x0000000181E237A0-0x0000000181E23BC0
	// [XID] // 0x000000018997F830-0x000000018997F850
	private void RefreshGotoBtn() {} // 0x0000000181E25F10-0x0000000181E26130
	// [XID] // 0x00000001899871E0-0x0000000189987200
	private void RefreshTitleAndDesc(MonoExplorationMark_ActivityChallenge monoMark) {} // 0x0000000181E245E0-0x0000000181E24810
	// [XID] // 0x000000018998EC70-0x000000018998EC90
	private void RefreshReward(MonoExplorationMark_ActivityChallenge monoMark) {} // 0x0000000181E258B0-0x0000000181E25AD0
	// [XID] // 0x0000000189996850-0x0000000189996870
	private void InitRewardItem(Transform trans, int index) {} // 0x0000000181E248A0-0x0000000181E24BF0
	// [XID] // 0x000000018999E350-0x000000018999E370
	private void OnGotoClick() {} // 0x0000000181E24D70-0x0000000181E24F00
	// [XID] // 0x00000001899A5D10-0x00000001899A5D30
	private void OpenMap() {} // 0x0000000181E255F0-0x0000000181E258B0
	// [XID] // 0x00000001899AD3B0-0x00000001899AD3D0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181E25DC0-0x0000000181E25F10
	// [XID] // 0x00000001899B4C30-0x00000001899B4C50
	private void ShiftMark(bool toNext) {} // 0x0000000181E25B30-0x0000000181E25D30
	// [XID] // 0x00000001899BC330-0x00000001899BC350
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181E251C0-0x0000000181E25530
}

