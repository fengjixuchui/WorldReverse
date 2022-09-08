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

public sealed class CodexCreaturePageContext : BasePageContext // TypeDefIndex: 28496
{
	// Fields
	private MonoCodexCreaturePage _pageMono; // 0x190
	private CodexCreatureUISceneComponent _uiSceneComp; // 0x198
	private Dictionary<uint, List<CodexModule.CodexCreatureData>> _creatureDic; // 0x1A0
	private List<uint> _creatureSubTypeList; // 0x1A8
	private AnimalCodexType _currType; // 0x1B0
	private int _currRowIndex; // 0x1B4
	private int _selectedRowIndex; // 0x1B8
	private int _selectedSlotIndex; // 0x1BC
	private uint _selectedPushTipsId; // 0x1C0
	private bool _isInPreview; // 0x1C4

	// Constructors
	public CodexCreaturePageContext() {} // 0x0000000183958360-0x0000000183958450

	// Methods
	// [XID] // 0x000000018986B1F0-0x000000018986B210
	public override void SetupView() {} // 0x00000001839580A0-0x0000000183958360
	// [XID] // 0x0000000189872580-0x00000001898725A0
	public override void ClearView() {} // 0x0000000183954130-0x0000000183954270
	// [XID] // 0x000000018987A1F0-0x000000018987A210
	protected override void OnEnable() {} // 0x0000000183957490-0x0000000183957A00
	// [XID] // 0x00000001898813D0-0x00000001898813F0
	protected override void BindViewCallbacks() {} // 0x0000000183953B90-0x0000000183953E50
	// [XID] // 0x0000000189888960-0x0000000189888980
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183954C70-0x0000000183954FF0
	// [XID] // 0x000000018988FCA0-0x000000018988FCC0
	private void SetMenuTab() {} // 0x0000000183956E60-0x0000000183957170
	// [XID] // 0x0000000189897160-0x0000000189897180
	private string GetIconKey(AnimalCodexType type) => default; // 0x0000000183956780-0x0000000183956880
	// [XID] // 0x000000018989E6E0-0x000000018989E700
	private string GetTitleText() => default; // 0x00000001839565F0-0x0000000183956700
	// [XID] // 0x00000001898A6200-0x00000001898A6220
	private void OnTabClicked(int index) {} // 0x00000001839549F0-0x0000000183954B60
	// [XID] // 0x00000001898AD830-0x00000001898AD850
	private AnimalCodexType GetTabType(int index) => default; // 0x0000000183953E50-0x0000000183953F10
	// [XID] // 0x00000001898B4D70-0x00000001898B4D90
	private void RefreshView() {} // 0x0000000183954FF0-0x0000000183955610
	// [XID] // 0x00000001898BC8C0-0x00000001898BC8E0
	private void SetupJoypadHandle() {} // 0x0000000183953770-0x0000000183953B90
	// [XID] // 0x00000001898C3EC0-0x00000001898C3EE0
	private void RefreshCreatureRow(Transform trans, int index) {} // 0x0000000183956B60-0x0000000183956E60
	// [XID] // 0x00000001898CB6A0-0x00000001898CB6C0
	private string GetSubTypeTitle(AnimalCodexSubType type) => default; // 0x0000000183956880-0x0000000183956A30
	// [XID] // 0x00000001898D2DF0-0x00000001898D2E10
	private void RefreshCreatureSlot(Transform trans, int index) {} // 0x0000000183954430-0x0000000183954640
	// [XID] // 0x00000001898DA740-0x00000001898DA760
	private void RefreshMonsterIcon(MonoMonsterIcon slot, AnimalCodexExcelConfig codexConfig, CodexModule.CodexCreatureData currCodexCreatureData, int rowIndex, int index) {} // 0x0000000183957170-0x0000000183957490
	// [XID] // 0x00000001898E23D0-0x00000001898E23F0
	private void RefreshAnimalIcon(MonoMonsterIcon slot, AnimalCodexExcelConfig codexConfig, CodexModule.CodexCreatureData currCodexCreatureData, int rowIndex, int index) {} // 0x00000001839546D0-0x00000001839549F0
	// [XID] // 0x00000001898E9FB0-0x00000001898E9FD0
	private void OnCreatureIconClick(int rowIndex, int slotIndex) {} // 0x00000001839557C0-0x0000000183956340
	// [XID] // 0x00000001898F1760-0x00000001898F1780
	private void RefreshMonsterInfo(AnimalCodexExcelConfig codexConfig) {} // 0x0000000183957B40-0x0000000183957DF0
	// [XID] // 0x00000001898F8F00-0x00000001898F8F20
	private void RefreshAnimalInfo(AnimalCodexExcelConfig codexConfig) {} // 0x0000000183957DF0-0x00000001839580A0
	// [XID] // 0x0000000189900880-0x00000001899008A0
	private void OnClose() {} // 0x0000000183954B60-0x0000000183954C10
	// [XID] // 0x0000000189908050-0x0000000189908070
	private void OnTabPrevBtnClick() {} // 0x0000000183956A30-0x0000000183956B00
	// [XID] // 0x000000018990F7E0-0x000000018990F800
	private void OnTabNextBtnClick() {} // 0x0000000183955670-0x0000000183955740
	// [XID] // 0x0000000189917230-0x0000000189917250
	private void OnPreviewBtnClick() {} // 0x0000000183956340-0x00000001839565F0
	// [XID] // 0x000000018991E930-0x000000018991E950
	private void OnPreviewReturnBtnClick() {} // 0x0000000183953F10-0x0000000183954130
	// [XID] // 0x00000001899261D0-0x00000001899261F0
	private void OnTipsBtnClick() {} // 0x0000000183957A00-0x0000000183957B40
	// [XID] // 0x000000018992D8C0-0x000000018992D8E0
	private void OnVisibleToggleChanged(bool on) {} // 0x00000001839542D0-0x0000000183954430
}

