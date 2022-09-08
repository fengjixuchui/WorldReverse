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

public sealed class InlevelNameCardPageContext : BasePageContext // TypeDefIndex: 29914
{
	// Fields
	private MonoInLevelNameCardPage _pageMono; // 0x190
	private List<uint> _sortedIdList; // 0x198
	private List<uint> _unlockedIdList; // 0x1A0
	private uint _currNameCardId; // 0x1A8
	private uint _selectedNameCardId; // 0x1AC
	private NameCardJoypadRegion _joypadRegion; // 0x1B0

	// Nested types
	private enum NameCardJoypadRegion // TypeDefIndex: 29915
	{
		Select = 0,
		Detail = 1
	}

	// Constructors
	public InlevelNameCardPageContext() {} // 0x00000001840C1160-0x00000001840C1210

	// Methods
	// [XID] // 0x00000001899ABCE0-0x00000001899ABD00
	public override void SetupView() {} // 0x00000001840C0F90-0x00000001840C1160
	// [XID] // 0x00000001899B3610-0x00000001899B3630
	public override void ClearView() {} // 0x00000001840BEEA0-0x00000001840BEF60
	// [XID] // 0x00000001899BA990-0x00000001899BA9B0
	protected override void BindViewCallbacks() {} // 0x00000001840BE9A0-0x00000001840BEB00
	// [XID] // 0x00000001899C22B0-0x00000001899C22D0
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001840BFC90-0x00000001840BFD50
	// [XID] // 0x00000001899C99E0-0x00000001899C9A00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001840BFD50-0x00000001840BFEC0
	// [XID] // 0x00000001899D11F0-0x00000001899D1210
	public override bool OnNotify(Notify ntf) => default; // 0x00000001840C0D70-0x00000001840C0F90
	// [XID] // 0x00000001899D86E0-0x00000001899D8700
	private void RequestUnlockNameCard() {} // 0x00000001840BF130-0x00000001840BF210
	// [XID] // 0x00000001899DFD90-0x00000001899DFDB0
	private void RequestSetNameCard() {} // 0x00000001840BF4C0-0x00000001840BF5C0
	// [XID] // 0x00000001899E77E0-0x00000001899E7800
	private void RefreshAllNameCard() {} // 0x00000001840C06B0-0x00000001840C08F0
	// [XID] // 0x00000001899EED50-0x00000001899EED70
	private void RefreshNameCardItem(Transform trans, int index) {} // 0x00000001840BEB00-0x00000001840BEEA0
	// [XID] // 0x00000001899F6610-0x00000001899F6630
	private void OnNameCardIconSelect(int index) {} // 0x00000001840BF9E0-0x00000001840BFC30
	// [XID] // 0x00000001899FDB90-0x00000001899FDBB0
	private void SelectNameCardIcon(int index, bool select) {} // 0x00000001840BF650-0x00000001840BF840
	// [XID] // 0x0000000189A05590-0x0000000189A055B0
	private void InitPlayerInfo() {} // 0x00000001840BF210-0x00000001840BF430
	// [XID] // 0x0000000189A0C8B0-0x0000000189A0C8D0
	private void RefreshNameCardPreview(uint id) {} // 0x00000001840BEF60-0x00000001840BF130
	// [XID] // 0x0000000189A14220-0x0000000189A14240
	private void RefreshDetailPreview(uint id) {} // 0x00000001840C0A70-0x00000001840C0CE0
	// [XID] // 0x0000000189A1B4B0-0x0000000189A1B4D0
	private void UseSelectedNameCard() {} // 0x00000001840C01D0-0x00000001840C02A0
	// [XID] // 0x0000000189A22DB0-0x0000000189A22DD0
	private string GetMaterialNameText(uint id) => default; // 0x00000001840C0590-0x00000001840C06B0
	// [XID] // 0x0000000189A2A0C0-0x0000000189A2A0E0
	private string GetMaterialStoryText(uint id) => default; // 0x00000001840C0950-0x00000001840C0A70
	// [XID] // 0x0000000189A31560-0x0000000189A31580
	private string GetMaterialSourceText(uint id) => default; // 0x00000001840BFF20-0x00000001840C0030
	// [XID] // 0x0000000189A39010-0x0000000189A39030
	private void SwitchToDetailRegion() {} // 0x00000001840BF840-0x00000001840BF9E0
	// [XID] // 0x0000000189A407F0-0x0000000189A40810
	private void SwitchToSelectRegion() {} // 0x00000001840C0030-0x00000001840C01D0
	// [XID] // 0x0000000189A47E90-0x0000000189A47EB0
	public void SetUnlockNameCard(List<uint> unlockNameCard) {} // 0x00000001840C02A0-0x00000001840C0590
}

