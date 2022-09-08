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

public sealed class HideandSeekPreviewPage : BasePageContext // TypeDefIndex: 29352
{
	// Fields
	private FocusNavType _focusRegion; // 0x190
	private MonoHideandSeekPreviewPage _pageMono; // 0x198
	private ActivityInfo activityInfo; // 0x1A0
	private TAB_CATEGORY curSelectTab; // 0x1A8
	private HIDE_AND_SEEK_SKILL_SUB_CATEGORY curSelectSkillSubCategory; // 0x1AC
	private int curSelectSkillTabIndex; // 0x1B0
	private int curSelectSkillIndex; // 0x1B4
	private Dictionary<int, List<HideAndSeekSkillExcelConfig>> _seekSkillInfo; // 0x1B8
	private Dictionary<int, List<HideAndSeekSkillExcelConfig>> _hideSkillInfo; // 0x1C0
	private List<uint> _seekSkillChangeList; // 0x1C8
	private List<uint> _hideSkillChangeList; // 0x1D0

	// Properties
	public int selectSkillTabIndex { /* [XID] */ /* 0x00000001899AEC80-0x00000001899AECA0 */ get => default; } // 0x00000001837EFC90-0x00000001837EFD30 

	// Nested types
	private enum TAB_CATEGORY // TypeDefIndex: 29353
	{
		NONE = 0,
		SEEK = 1,
		HIDE = 2
	}

	private enum FocusNavType // TypeDefIndex: 29354
	{
		Left = 0,
		Right = 1
	}

	// Constructors
	public HideandSeekPreviewPage() {} // 0x00000001837EFFC0-0x00000001837F01F0

	// Methods
	// [XID] // 0x00000001899B5FE0-0x00000001899B6000
	public override void SetupView() {} // 0x00000001837EFE90-0x00000001837EFFC0
	// [XID] // 0x00000001899BDD40-0x00000001899BDD60
	private void BuildSkillData() {} // 0x00000001837ED730-0x00000001837EDE40
	// [XID] // 0x00000001899C5460-0x00000001899C5480
	private void RefreshSkillTab() {} // 0x00000001837EF1B0-0x00000001837EF480
	// [XID] // 0x00000001899CCB30-0x00000001899CCB50
	private void RefreshSkillTabItems(Transform trans, int index) {} // 0x00000001837EE670-0x00000001837EE900
	// [XID] // 0x00000001899D4150-0x00000001899D4170
	private void OnClickSkillTab(int index) {} // 0x00000001837EC790-0x00000001837ECC60
	// [XID] // 0x00000001899DB740-0x00000001899DB760
	private void RefreshSkillInfoItems(Transform trans, int index) {} // 0x00000001837EEDC0-0x00000001837EF150
	// [XID] // 0x00000001899E2E60-0x00000001899E2E80
	private void RefreshSkillInfo() {} // 0x00000001837EE400-0x00000001837EE670
	// [XID] // 0x00000001899EA550-0x00000001899EA570
	private void OnClickSkillInfoItem(int index, uint skillConfigID) {} // 0x00000001837EDF50-0x00000001837EE220
	// [XID] // 0x00000001899F1FC0-0x00000001899F1FE0
	private void RefreshTabIcon() {} // 0x00000001837ECC60-0x00000001837ECE60
	// [XID] // 0x00000001899F9700-0x00000001899F9720
	private void SendDataToServer() {} // 0x00000001837EDE40-0x00000001837EDF50
	// [XID] // 0x0000000189A00A20-0x0000000189A00A40
	protected override void BindViewCallbacks() {} // 0x00000001837ECE60-0x00000001837ED260
	// [XID] // 0x0000000189A08340-0x0000000189A08360
	private void OnClickReturn() {} // 0x00000001837EFD30-0x00000001837EFDF0
	// [XID] // 0x0000000189A0F860-0x0000000189A0F880
	public override void ClearView() {} // 0x00000001837ED680-0x00000001837ED730
	// [XID] // 0x0000000189A16E20-0x0000000189A16E40
	private int CompareHideAnsSeekSkill(HideAndSeekSkillExcelConfig xData, HideAndSeekSkillExcelConfig yData) => default; // 0x00000001837EF480-0x00000001837EF590
	// [XID] // 0x0000000189A1E4E0-0x0000000189A1E500
	private void OnClickMap() {} // 0x00000001837EECB0-0x00000001837EEDC0
	// [XID] // 0x0000000189A25BC0-0x0000000189A25BE0
	private void OnClickSeekTab() {} // 0x00000001837EE330-0x00000001837EE400
	// [XID] // 0x0000000189A2D020-0x0000000189A2D040
	private void OnClickHideTab() {} // 0x00000001837ED5B0-0x00000001837ED680
	// [XID] // 0x0000000189A34A20-0x0000000189A34A40
	private void BackTab() {} // 0x00000001837ED260-0x00000001837ED440
	// [XID] // 0x0000000189A3BDD0-0x0000000189A3BDF0
	private void RefreshTabState() {} // 0x00000001837ED440-0x00000001837ED5B0
	// [XID] // 0x0000000189A43A20-0x0000000189A43A40
	public override bool OnNotify(Notify ntf) => default; // 0x00000001837EFB60-0x00000001837EFC90
	// [XID] // 0x0000000189A4AE70-0x0000000189A4AE90
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x00000001837EF790-0x00000001837EFA20
	// [XID] // 0x0000000189A52590-0x0000000189A525B0
	private void ShowSkillItemArrow(int index, bool show) {} // 0x00000001837EEB10-0x00000001837EECB0
	// [XID] // 0x0000000189A59EE0-0x0000000189A59F00
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transforn, JoypadSelectIndexResult selectResult) {} // 0x00000001837EFA20-0x00000001837EFB60
	// [XID] // 0x0000000189A616B0-0x0000000189A616D0
	public override void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0F62C */) {} // 0x00000001837EF620-0x00000001837EF790
	// [XID] // 0x0000000189A695F0-0x0000000189A69610
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001837EE960-0x00000001837EEAB0
}

