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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectAwakeningAffixDialogContext : BaseDialogContext // TypeDefIndex: 29267
{
	// Fields
	private MonoSelectAwakeningAffixDialog _dialogMono; // 0x178
	private WeaponItem _weaponItem; // 0x180
	private List<EquipAffixExcelConfig> _affixList; // 0x188
	private Dictionary<uint, uint> _selectAffixDic; // 0x190
	private uint _maxAwakenCount; // 0x198
	private uint _usedAwakenCount; // 0x19C
	private int _selectAffixIndex; // 0x1A0

	// Constructors
	public SelectAwakeningAffixDialogContext() {} // Dummy constructor
	public SelectAwakeningAffixDialogContext(WeaponItem weaponItem, ulong foodGuid) {} // 0x00000001821F9680-0x00000001821F9790

	// Methods
	// [XID] // 0x00000001896F3BB0-0x00000001896F3BD0
	public override void SetupView() {} // 0x00000001821F9360-0x00000001821F9680
	// [XID] // 0x00000001896FB320-0x00000001896FB340
	protected override void BindViewCallbacks() {} // 0x00000001821F7760-0x00000001821F7960
	// [XID] // 0x0000000189702AD0-0x0000000189702AF0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821F8690-0x00000001821F8950
	// [XID] // 0x000000018970A1F0-0x000000018970A210
	private void SelectUpgradeAffix(int index) {} // 0x00000001821F8400-0x00000001821F8630
	// [XID] // 0x0000000189711CD0-0x0000000189711CF0
	private void RefreshAffixSelectPanel() {} // 0x00000001821F8CA0-0x00000001821F9090
	// [XID] // 0x0000000189719170-0x0000000189719190
	private void SetAffixSelectPanelView(MonoAwakenAffixSelect affixSelect, EquipAffixExcelConfig affix) {} // 0x00000001821F7960-0x00000001821F8370
	// [XID] // 0x00000001897207D0-0x00000001897207F0
	private void OnPlusBtnClick(int index) {} // 0x00000001821F7360-0x00000001821F7550
	// [XID] // 0x0000000189727D80-0x0000000189727DA0
	private void OnMinusBtnClick(int index) {} // 0x00000001821F7550-0x00000001821F7760
	// [XID] // 0x000000018972F400-0x000000018972F420
	private void CheckAffixSelectBtnsShow() {} // 0x00000001821F7150-0x00000001821F7360
	// [XID] // 0x0000000189736E00-0x0000000189736E20
	private bool CheckAffixCanLevelUp(EquipAffixExcelConfig affix) => default; // 0x00000001821F8950-0x00000001821F8AC0
	// [XID] // 0x000000018973E9C0-0x000000018973E9E0
	private void RefreshAwakenCountTip() {} // 0x00000001821F8AC0-0x00000001821F8C40
	// [XID] // 0x0000000189745CC0-0x0000000189745CE0
	private void AwakenWeapon() {} // 0x00000001821F9090-0x00000001821F9360
}

