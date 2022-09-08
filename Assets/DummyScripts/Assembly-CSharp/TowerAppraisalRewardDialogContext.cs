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

public sealed class TowerAppraisalRewardDialogContext : BaseDialogContext // TypeDefIndex: 28978
{
	// Fields
	private MonoTowerAppraisalRewardDialog _dialogMono; // 0x178
	private TowerFloorExcelConfig _floorConfig; // 0x180
	private uint _floorId; // 0x188
	private List<RewardItemConfig> _tempRewardList; // 0x190
	private int _currItemIndex; // 0x198
	private int _currRowIndex; // 0x19C

	// Constructors
	public TowerAppraisalRewardDialogContext() {} // Dummy constructor
	public TowerAppraisalRewardDialogContext(uint floorId) {} // 0x0000000184C2EFC0-0x0000000184C2F0A0

	// Methods
	// [XID] // 0x00000001896A7110-0x00000001896A7130
	public override void SetupView() {} // 0x0000000184C2EEB0-0x0000000184C2EFC0
	// [XID] // 0x00000001896AE730-0x00000001896AE750
	protected override void BindViewCallbacks() {} // 0x0000000184C2D220-0x0000000184C2D390
	// [XID] // 0x00000001896B5F50-0x00000001896B5F70
	private void RefreshDialogView() {} // 0x0000000184C2D390-0x0000000184C2D8D0
	// [XID] // 0x00000001896BD110-0x00000001896BD130
	private void RefreshAppraisalRewardRow(Transform trans, int index) {} // 0x0000000184C2EAF0-0x0000000184C2EE50
	// [XID] // 0x00000001896C4610-0x00000001896C4630
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000184C2D8D0-0x0000000184C2DB30
	// [XID] // 0x00000001896CBC70-0x00000001896CBC90
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184C2E250-0x0000000184C2E900
	// [XID] // 0x00000001896D2F10-0x00000001896D2F30
	private void RefreshCurrentItem(MonoTowerAppraisalRewardRow row, bool prev) {} // 0x0000000184C2DB30-0x0000000184C2DE90
	// [XID] // 0x00000001896DAAE0-0x00000001896DAB00
	private void ClearCurrentItem() {} // 0x0000000184C2DF20-0x0000000184C2E1F0
	// [XID] // 0x00000001896E2210-0x00000001896E2230
	private void ClickCurrentItem(MonoTowerAppraisalRewardRow row) {} // 0x0000000184C2E900-0x0000000184C2EAF0
}

