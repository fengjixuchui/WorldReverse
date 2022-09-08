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

public sealed class ReputationRewardDialogContext : BaseDialogContext // TypeDefIndex: 28966
{
	// Fields
	private CityConfig _cityConfig; // 0x178
	private MonoReputationRewardDialog _dialogMono; // 0x180
	private List<ReputationLevelExcelConfig> _cityLevelList; // 0x188
	private List<RewardItemConfig> _tempRewardList; // 0x190

	// Constructors
	public ReputationRewardDialogContext() {} // Dummy constructor
	public ReputationRewardDialogContext(CityConfig cityConfig) {} // 0x0000000183602D30-0x0000000183602E20

	// Methods
	// [XID] // 0x0000000189A556F0-0x0000000189A55710
	public override void SetupView() {} // 0x0000000183602A70-0x0000000183602D30
	// [XID] // 0x0000000189A5D070-0x0000000189A5D090
	public override void ClearView() {} // 0x0000000183601400-0x00000001836014A0
	// [XID] // 0x0000000189A64910-0x0000000189A64930
	protected override void BindViewCallbacks() {} // 0x00000001836010E0-0x00000001836011E0
	// [XID] // 0x0000000189A6C130-0x0000000189A6C150
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183602990-0x0000000183602A70
	// [XID] // 0x0000000189A738A0-0x0000000189A738C0
	private void FocusTarget() {} // 0x00000001836017F0-0x0000000183601B10
	// [IDTag] // 0x0000000189A7B400-0x0000000189A7B440
	// [XID] // 0x0000000189A7B400-0x0000000189A7B440
	private void RefreshReward() {} // 0x0000000183602410-0x00000001836025F0
	// [IDTag] // 0x0000000189A85B80-0x0000000189A85BC0
	// [XID] // 0x0000000189A85B80-0x0000000189A85BC0
	private void RefreshReward(Transform trans, int index) {} // 0x0000000183601F90-0x0000000183602410
	// [XID] // 0x0000000189A904D0-0x0000000189A904F0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000183601540-0x0000000183601760
	// [XID] // 0x0000000189A97D60-0x0000000189A97D80
	private void ShowDesc(string desc) {} // 0x0000000183602650-0x0000000183602790
	// [XID] // 0x0000000189A9F0B0-0x0000000189A9F0D0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0E8DF */) {} // 0x0000000183602820-0x0000000183602990
	// [XID] // 0x0000000189AA69B0-0x0000000189AA69D0
	private void RefreshJoypadButtons(Transform transform) {} // 0x00000001836011E0-0x0000000183601400
	// [XID] // 0x0000000189AAE040-0x0000000189AAE060
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183601B70-0x0000000183601F30
}

