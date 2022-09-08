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

public sealed class DungeonRuleDialogContext : BaseDialogContext // TypeDefIndex: 29003
{
	// Fields
	private MonoDungeonRuleDialog _dialogMono; // 0x178
	private uint _pointID; // 0x180
	private List<List<SimpleSafeUInt32>> _cycleRewardList; // 0x188
	private int _currItemIndex; // 0x190

	// Constructors
	public DungeonRuleDialogContext() {} // Dummy constructor
	public DungeonRuleDialogContext(uint pointID) {} // 0x0000000181ECAE10-0x0000000181ECAF10

	// Methods
	// [XID] // 0x0000000189BCFFB0-0x0000000189BCFFD0
	public override void SetupView() {} // 0x0000000181ECACF0-0x0000000181ECAE10
	// [XID] // 0x0000000189BD75F0-0x0000000189BD7610
	public override void ClearView() {} // 0x0000000181EC94C0-0x0000000181EC9590
	// [XID] // 0x0000000189BDF0F0-0x0000000189BDF110
	protected override void BindViewCallbacks() {} // 0x0000000181EC9340-0x0000000181EC94C0
	// [XID] // 0x00000001895EBD60-0x00000001895EBD80
	private void RefreshCycleRewardPanel() {} // 0x0000000181EC8DF0-0x0000000181EC9340
	// [XID] // 0x00000001895F3100-0x00000001895F3120
	private void RefreshCycleRewardRow(Transform trans, int index) {} // 0x0000000181ECA910-0x0000000181ECACF0
	// [XID] // 0x00000001895FA960-0x00000001895FA980
	private string GetCycleTextByIndex(int index) => default; // 0x0000000181EC9590-0x0000000181EC96B0
	// [XID] // 0x0000000189602310-0x0000000189602330
	private string GetCycleTitleByType(DungunEntryType type) => default; // 0x0000000181ECA820-0x0000000181ECA910
	// [XID] // 0x0000000189609B30-0x0000000189609B50
	private string GetCycleDescByType(DungunEntryType type) => default; // 0x0000000181EC9AA0-0x0000000181EC9BB0
	// [XID] // 0x00000001896112C0-0x00000001896112E0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181EC9EE0-0x0000000181ECA570
	// [XID] // 0x0000000189618CD0-0x0000000189618CF0
	private void RefreshCurrentItem(MonoDungeonRuleRow row, bool prev) {} // 0x0000000181EC96B0-0x0000000181EC9A10
	// [XID] // 0x00000001896201C0-0x00000001896201E0
	private void ClearCurrentItem() {} // 0x0000000181EC9BB0-0x0000000181EC9E80
	// [XID] // 0x0000000189627630-0x0000000189627650
	private void ClickCurrentItem(MonoDungeonRuleRow row) {} // 0x0000000181ECA570-0x0000000181ECA760
}

