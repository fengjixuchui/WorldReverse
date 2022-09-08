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

public sealed class NameCardSequenceSelectDialogContext : BaseDialogContext // TypeDefIndex: 29213
{
	// Fields
	private MonoNameCardSequenceSelectDialog _dialogMono; // 0x178
	private uint _minSelectNum; // 0x180
	private uint _maxSelectNum; // 0x184
	private List<uint> _nameCardFilteredGuid; // 0x188
	private List<uint> _nameCardShowGuid; // 0x190
	private List<uint> _nameCardSelectedGuid; // 0x198
	private List<uint> _nameCardInitSelectedGuid; // 0x1A0
	private List<uint> _nameCardSortedGuid; // 0x1A8
	private uint _selectedConfigId; // 0x1B0
	private bool _focusOnItemTip; // 0x1B4

	// Constructors
	public NameCardSequenceSelectDialogContext() {} // Dummy constructor
	public NameCardSequenceSelectDialogContext(uint minSelectNum, uint maxSelectNum, List<uint> nameCardSelectedGuid) {} // 0x0000000182CBC640-0x0000000182CBC7F0

	// Methods
	// [XID] // 0x00000001897E2620-0x00000001897E2640
	public override void SetupView() {} // 0x0000000182CBC4F0-0x0000000182CBC640
	// [XID] // 0x00000001897E9D90-0x00000001897E9DB0
	public override void ClearView() {} // 0x0000000182CBA360-0x0000000182CBA410
	// [XID] // 0x00000001897F19F0-0x00000001897F1A10
	protected override void BindViewCallbacks() {} // 0x0000000182CBA200-0x0000000182CBA360
	// [XID] // 0x00000001897F91A0-0x00000001897F91C0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182CBC3E0-0x0000000182CBC4F0
	// [XID] // 0x0000000189800770-0x0000000189800790
	private void RefreshNameCardList(List<uint> newNameCardList) {} // 0x0000000182CBBEE0-0x0000000182CBBFD0
	// [XID] // 0x0000000189807E10-0x0000000189807E30
	private void SortNameCard() {} // 0x0000000182CB9B50-0x0000000182CB9EA0
	// [XID] // 0x000000018980F6F0-0x000000018980F710
	private void RefreshNameCardPanel() {} // 0x0000000182CBA730-0x0000000182CBAA90
	// [XID] // 0x0000000189816DA0-0x0000000189816DC0
	private void RefreshNameCardIcon(Transform trans, int index) {} // 0x0000000182CBB730-0x0000000182CBBA10
	// [XID] // 0x000000018981E610-0x000000018981E630
	private void OnNameCardSelect(int index) {} // 0x0000000182CBB250-0x0000000182CBB620
	// [XID] // 0x0000000189825AF0-0x0000000189825B10
	private void OnNameCardNoRefresh() {} // 0x0000000182CBAF50-0x0000000182CBB1F0
	// [XID] // 0x000000018982D220-0x000000018982D240
	private void RefreshJoypadButtonText(uint configId) {} // 0x0000000182CBBA10-0x0000000182CBBD40
	// [XID] // 0x0000000189834980-0x00000001898349A0
	private void TryShowTip(bool show, uint configId = 0 /* Metadata: 0x00B0EE11 */) {} // 0x0000000182CBA410-0x0000000182CBA730
	// [XID] // 0x000000018983C050-0x000000018983C070
	private void RefreshSourceDungeonListItem(Transform trans, int index) {} // 0x0000000182CBABC0-0x0000000182CBADA0
	// [XID] // 0x0000000189843660-0x0000000189843680
	private string GetMaterialSourceText(uint id) => default; // 0x0000000182CBB620-0x0000000182CBB730
	// [XID] // 0x000000018984ABC0-0x000000018984ABE0
	private void OnCloseBtnClick() {} // 0x0000000182CBA150-0x0000000182CBA200
	// [XID] // 0x0000000189851F20-0x0000000189851F40
	private void OnSaveBtnClick() {} // 0x0000000182CB9EA0-0x0000000182CBA150
	// [XID] // 0x00000001898597E0-0x0000000189859800
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EE15 */) {} // 0x0000000182CBC0C0-0x0000000182CBC3E0
	// [XID] // 0x0000000189860960-0x0000000189860980
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182CBAE00-0x0000000182CBAF50
	// [XID] // 0x0000000189868090-0x00000001898680B0
	private void FocusOnItemTip(bool focus) {} // 0x0000000182CBBD40-0x0000000182CBBEE0
}

