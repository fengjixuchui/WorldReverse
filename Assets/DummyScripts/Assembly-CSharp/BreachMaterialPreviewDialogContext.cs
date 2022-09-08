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
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BreachMaterialPreviewDialogContext : BaseDialogContext // TypeDefIndex: 28917
{
	// Fields
	private MonoBreachMaterialPreviewDialog _dialogMono; // 0x178
	private List<Tuple<BagItemSlot, uint>> _breakNeedList; // 0x180
	private BreakType _breakType; // 0x188
	private uint _molaNum; // 0x18C
	private uint _nextLevel; // 0x190
	private uint _nextPlayerLevel; // 0x194
	private int _currItemIndex; // 0x198

	// Nested types
	public enum BreakType // TypeDefIndex: 28918
	{
		Avatar = 0,
		Weapon = 1
	}

	// Constructors
	public BreachMaterialPreviewDialogContext() {} // Dummy constructor
	public BreachMaterialPreviewDialogContext(BreakType type, List<Tuple<BagItemSlot, uint>> needList, uint molaNum, uint nextLevel, uint nextPlayerLevel) {} // 0x00000001830C9810-0x00000001830C9940

	// Methods
	// [XID] // 0x0000000189790520-0x0000000189790540
	public override void SetupView() {} // 0x00000001830C9210-0x00000001830C9810
	// [XID] // 0x0000000189797F10-0x0000000189797F30
	private void RefreshNeedItem(Transform trans, int index) {} // 0x00000001830C84E0-0x00000001830C8790
	// [XID] // 0x000000018979FC30-0x000000018979FC50
	private void OnItemClicked(int index) {} // 0x00000001830C8790-0x00000001830C8910
	// [XID] // 0x00000001897A71B0-0x00000001897A71D0
	protected override void BindViewCallbacks() {} // 0x00000001830C8370-0x00000001830C84E0
	// [XID] // 0x00000001897AEB60-0x00000001897AEB80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001830C8A00-0x00000001830C8D20
	// [XID] // 0x00000001897B69F0-0x00000001897B6A10
	private void ClickCurrentItem() {} // 0x00000001830C8D20-0x00000001830C8F10
	// [XID] // 0x00000001897BE830-0x00000001897BE850
	private void SetItemActive(bool isActive) {} // 0x00000001830C8F10-0x00000001830C91B0
}

