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

public sealed class CodexEquipPageContext : BasePageContext // TypeDefIndex: 28499
{
	// Fields
	private MonoCodexEquipPage _pageMono; // 0x190
	private CodexEquipUISceneComponent _uiSceneComp; // 0x198
	private CodexEquipPageType _currType; // 0x1A0
	private List<CodexModule.CodexWeaponData> _weaponList; // 0x1A8
	private Dictionary<uint, List<CodexModule.CodexReliquaryData>> _reliquarySuitDic; // 0x1B0
	private List<uint> _reliquarySuitIdList; // 0x1B8
	private int _selectedWeaponIndex; // 0x1C0
	private uint _storyId; // 0x1C4
	private EquipType _equipType; // 0x1C8
	private ReliquaryCodexExcelConfig _currCodexConfig; // 0x1D0
	private int _currRowIndex; // 0x1D8
	private int _selectedRelicRowIndex; // 0x1DC
	private int _selectedRelicSlotIndex; // 0x1E0
	private CodexWeaponScreenDialogContext _dialog; // 0x1E8
	private bool _showAwakenTexture; // 0x1F0
	private bool _firstShowAwakenTexture; // 0x1F1
	private List<uint> _reliquaryStoryIdList; // 0x1F8
	private static readonly int Step; // 0x00

	// Nested types
	public enum CodexEquipPageType // TypeDefIndex: 28500
	{
		Weapon = 0,
		Reliquary = 1
	}

	// Constructors
	public CodexEquipPageContext() {} // 0x0000000182B9B080-0x0000000182B9B1C0
	static CodexEquipPageContext() {} // 0x0000000182B9B020-0x0000000182B9B080

	// Methods
	// [XID] // 0x0000000189985970-0x0000000189985990
	public override void SetupView() {} // 0x0000000182B9AED0-0x0000000182B9B020
	// [XID] // 0x000000018998D630-0x000000018998D650
	public override void ClearView() {} // 0x0000000182B95D60-0x0000000182B95E70
	// [XID] // 0x0000000189995070-0x0000000189995090
	protected override void BindViewCallbacks() {} // 0x0000000182B95370-0x0000000182B956D0
	// [XID] // 0x000000018999CAB0-0x000000018999CAD0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182B977B0-0x0000000182B97920
	// [XID] // 0x00000001899A4440-0x00000001899A4460
	private void SetMenuTab() {} // 0x0000000182B9A6D0-0x0000000182B9A9D0
	// [XID] // 0x00000001899ABE20-0x00000001899ABE40
	private string GetIconKey(CodexEquipPageType type) => default; // 0x0000000182B990B0-0x0000000182B991B0
	// [XID] // 0x00000001899B3710-0x00000001899B3730
	private string GetTitleText() => default; // 0x0000000182B98F20-0x0000000182B99030
	// [XID] // 0x00000001899BAB10-0x00000001899BAB30
	private void OnTabClicked(int index) {} // 0x0000000182B973B0-0x0000000182B97520
	// [XID] // 0x00000001899C2410-0x00000001899C2430
	private void RefreshView() {} // 0x0000000182B97920-0x0000000182B98430
	// [XID] // 0x00000001899C9B00-0x00000001899C9B20
	public void RefreshWeaponScreenPanel(List<CodexModule.CodexWeaponData> screenList) {} // 0x0000000182B95830-0x0000000182B95C00
	// [XID] // 0x00000001899D13D0-0x00000001899D13F0
	private void RefreshWeapon(Transform trans, int index) {} // 0x0000000182B9AAF0-0x0000000182B9AED0
	// [XID] // 0x00000001899D8820-0x00000001899D8840
	private void OnWeaponIconClick(int index) {} // 0x0000000182B994D0-0x0000000182B99F40
	// [XID] // 0x00000001899DFF50-0x00000001899DFF70
	private void RefreshReliquaryRow(Transform trans, int index) {} // 0x0000000182B99F40-0x0000000182B9A220
	// [XID] // 0x00000001899E7980-0x00000001899E79A0
	private void RefreshReliquarySlot(Transform trans, int index) {} // 0x0000000182B98750-0x0000000182B98C70
	// [XID] // 0x00000001899EEEB0-0x00000001899EEED0
	private void OnReliquaryIconClick(int rowIndex, int slotIndex) {} // 0x0000000182B95F90-0x0000000182B96EB0
	// [XID] // 0x00000001899F67D0-0x00000001899F67F0
	private void OnWeaponStoryBtnClick() {} // 0x0000000182B9A9D0-0x0000000182B9AAF0
	// [XID] // 0x00000001899FDD90-0x00000001899FDDB0
	private void OnReliquaryStoryBtnClick() {} // 0x0000000182B95200-0x0000000182B95370
	// [XID] // 0x0000000189A05770-0x0000000189A05790
	private void OnAwakenToggleChanged(bool on) {} // 0x0000000182B97100-0x0000000182B973B0
	// [XID] // 0x0000000189A0C9F0-0x0000000189A0CA10
	private void InitRelicTab() {} // 0x0000000182B975D0-0x0000000182B97750
	// [XID] // 0x0000000189A14340-0x0000000189A14360
	private void OnRelicTypeChange(int tab) {} // 0x0000000182B95C00-0x0000000182B95CB0
	// [XID] // 0x0000000189A1B5B0-0x0000000189A1B5D0
	private void ChangeRelicType(EquipType equipType) {} // 0x0000000182B94FC0-0x0000000182B95080
	// [XID] // 0x0000000189A22F70-0x0000000189A22F90
	private void UpdateRelicTab() {} // 0x0000000182B991B0-0x0000000182B994D0
	// [XID] // 0x0000000189A2A200-0x0000000189A2A220
	private uint GetRelicIdByType(ReliquaryCodexExcelConfig config, EquipType type) => default; // 0x0000000182B956D0-0x0000000182B95830
	// [XID] // 0x0000000189A31660-0x0000000189A31680
	private void RefreshReliquaryInfo() {} // 0x0000000182B9A220-0x0000000182B9A5A0
	// [XID] // 0x0000000189A39170-0x0000000189A39190
	private void OnClose() {} // 0x0000000182B97520-0x0000000182B975D0
	// [XID] // 0x0000000189A40930-0x0000000189A40950
	private void OnScreenBtnClick() {} // 0x0000000182B95080-0x0000000182B95200
	// [XID] // 0x0000000189A47F70-0x0000000189A47F90
	private void OnTabPrevBtnClick() {} // 0x0000000182B9A5A0-0x0000000182B9A670
	// [XID] // 0x0000000189A4F730-0x0000000189A4F750
	private void OnTabNextBtnClick() {} // 0x0000000182B98490-0x0000000182B98560
	// [XID] // 0x0000000189A56E50-0x0000000189A56E70
	public void OnReliquaryTabPrevBtnClick() {} // 0x0000000182B96F40-0x0000000182B97100
	// [XID] // 0x0000000189A5E9C0-0x0000000189A5E9E0
	public void OnReliquaryTabNextBtnClick() {} // 0x0000000182B98CE0-0x0000000182B98EA0
	// [XID] // 0x0000000189A66140-0x0000000189A66160
	private bool GetTabButtonStateByIndex(int index) => default; // 0x0000000182B95E70-0x0000000182B95F90
	// [XID] // 0x0000000189A6D810-0x0000000189A6D830
	public void ChangeStateID(int id) {} // 0x0000000182B95CB0-0x0000000182B95D60
	// [XID] // 0x0000000189A74F30-0x0000000189A74F50
	public void RefreshActionBtn(bool active) {} // 0x0000000182B985E0-0x0000000182B98750
}

