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

public sealed class ActivityGetRewardDialogContext : BaseDialogContext // TypeDefIndex: 28407
{
	// Fields
	private MonoActivityGetRewardDialog _dialogMono; // 0x178
	private List<LampContributionExcelConfig> _sortList; // 0x180
	private ActivityInfo _seaLampActivityInfo; // 0x188
	private const uint big_value = 1000000; // Metadata: 0x00B0D741
	private int _curSelectItemIndex; // 0x190

	// Constructors
	public ActivityGetRewardDialogContext() {} // 0x0000000181DF2860-0x0000000181DF2970

	// Methods
	// [XID] // 0x00000001899291E0-0x0000000189929200
	public override void SetupView() {} // 0x0000000181DF2790-0x0000000181DF2860
	// [XID] // 0x00000001899306F0-0x0000000189930710
	protected override void BindViewCallbacks() {} // 0x0000000181DF0BC0-0x0000000181DF0D20
	// [XID] // 0x0000000189937C80-0x0000000189937CA0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181DF2670-0x0000000181DF2790
	// [XID] // 0x000000018993F730-0x000000018993F750
	private void Refresh() {} // 0x0000000181DF03F0-0x0000000181DF08E0
	// [XID] // 0x0000000189946D40-0x0000000189946D60
	private int SortFunc(LampContributionExcelConfig x, LampContributionExcelConfig y) => default; // 0x0000000181DF23D0-0x0000000181DF2580
	// [XID] // 0x000000018994E380-0x000000018994E3A0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000181DF1030-0x0000000181DF16F0
	// [XID] // 0x0000000189955A00-0x0000000189955A20
	private void TakeReward(uint configId) {} // 0x0000000181DF1780-0x0000000181DF18E0
	// [XID] // 0x000000018995D500-0x000000018995D520
	private void RefreshRowSelectState(RectTransform trans, bool select) {} // 0x0000000181DF0D20-0x0000000181DF1030
	// [XID] // 0x0000000189964C20-0x0000000189964C40
	private void RefreshRewardSelectState(MonoActivityGetRewardsRow row, bool select) {} // 0x0000000181DF08E0-0x0000000181DF0BC0
	// [XID] // 0x000000018996C1D0-0x000000018996C1F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181DF1940-0x0000000181DF23D0
}

