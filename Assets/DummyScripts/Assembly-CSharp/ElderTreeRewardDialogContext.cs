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

public sealed class ElderTreeRewardDialogContext : BaseDialogContext // TypeDefIndex: 29016
{
	// Fields
	private MonoElderTreeRewardDialog _dialogMono; // 0x178
	private List<RewardExcelConfig> _allLevelRewards; // 0x180
	private List<RewardItemConfig> _tempRewardList; // 0x188
	private int _targetIndex; // 0x190

	// Constructors
	public ElderTreeRewardDialogContext() {} // 0x0000000182CD83A0-0x0000000182CD8460

	// Methods
	// [XID] // 0x0000000189868130-0x0000000189868150
	public override void SetupView() {} // 0x0000000182CD81A0-0x0000000182CD83A0
	// [XID] // 0x000000018986F6F0-0x000000018986F710
	private void RefreshLevelRewards(Transform trans, int index) {} // 0x0000000182CD79A0-0x0000000182CD7DA0
	// [XID] // 0x0000000189876CA0-0x0000000189876CC0
	private void ShowTips() {} // 0x0000000182CD77D0-0x0000000182CD79A0
	// [XID] // 0x000000018987E7A0-0x000000018987E7C0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000182CD6DB0-0x0000000182CD7000
	// [XID] // 0x0000000189885B90-0x0000000189885BB0
	public override void ClearView() {} // 0x0000000182CD6D10-0x0000000182CD6DB0
	// [XID] // 0x000000018988CE80-0x000000018988CEA0
	protected override void BindViewCallbacks() {} // 0x0000000182CD69F0-0x0000000182CD6AF0
	// [XID] // 0x0000000189894570-0x0000000189894590
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182CD8000-0x0000000182CD81A0
	// [XID] // 0x000000018989BB40-0x000000018989BB60
	private void FocusTarget() {} // 0x0000000182CD7130-0x0000000182CD7350
	// [XID] // 0x00000001898A2FB0-0x00000001898A2FD0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0E922 */) {} // 0x0000000182CD7E90-0x0000000182CD8000
	// [XID] // 0x00000001898AA490-0x00000001898AA4B0
	private void RefreshJoypadButtons(Transform transform) {} // 0x0000000182CD6AF0-0x0000000182CD6D10
	// [XID] // 0x00000001898B1E90-0x00000001898B1EB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182CD73B0-0x0000000182CD7770
}

