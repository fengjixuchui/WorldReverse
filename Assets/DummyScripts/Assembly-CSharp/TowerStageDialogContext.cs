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

public sealed class TowerStageDialogContext : BaseDialogContext // TypeDefIndex: 28986
{
	// Fields
	private MonoTowerStageDialog _dialogMono; // 0x178
	private uint _levelId; // 0x180
	private uint _floorId; // 0x184
	private TowerFloorExcelConfig _floorConfig; // 0x188
	private TowerLevelExcelConfig _levelConfig; // 0x190
	private List<uint> _tempMonsterList; // 0x198

	// Constructors
	public TowerStageDialogContext() {} // Dummy constructor
	public TowerStageDialogContext(uint levelId, uint floorId) {} // 0x000000018357B970-0x000000018357BA60

	// Methods
	// [XID] // 0x00000001897F7760-0x00000001897F7780
	public override void SetupView() {} // 0x000000018357B820-0x000000018357B970
	// [XID] // 0x00000001897FEE70-0x00000001897FEE90
	protected override void BindViewCallbacks() {} // 0x000000018357A590-0x000000018357A700
	// [XID] // 0x00000001898065F0-0x0000000189806610
	private void RefreshDialogView() {} // 0x000000018357A700-0x000000018357ACF0
	// [XID] // 0x000000018980DCF0-0x000000018980DD10
	private void RefreshMonsterIcon(Transform trans, int index) {} // 0x000000018357B110-0x000000018357B3E0
	// [XID] // 0x0000000189815470-0x0000000189815490
	private void RefreshStarDetail() {} // 0x000000018357B3E0-0x000000018357B820
	// [XID] // 0x000000018981CEB0-0x000000018981CED0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018357ADE0-0x000000018357B0B0
}

