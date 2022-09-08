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

public sealed class ChangeBirthdayDialogContext : BaseDialogContext // TypeDefIndex: 28861
{
	// Fields
	private MonoChangeBirthdayDialog _dialogMono; // 0x178
	private List<int> _longMonth; // 0x180
	private List<int> _shortMonth; // 0x188
	private int _selectMonth; // 0x190
	private int _selectDay; // 0x194
	private int _selectMonthWithConfirm; // 0x198
	private int _selectDayWithConfirm; // 0x19C
	private GameObject _monthHighlight; // 0x1A0
	private GameObject _dayHighlight; // 0x1A8
	private const string HIGHLIGHT_PREFAB_ROOT = "ART/UI/TemplateUI/Ani_ItemTipsSelected"; // Metadata: 0x00B0E7C8
	private bool _isOnMonth; // 0x1B0

	// Constructors
	public ChangeBirthdayDialogContext() {} // 0x0000000183DA5570-0x0000000183DA5780

	// Methods
	// [XID] // 0x00000001898187B0-0x00000001898187D0
	public override void SetupView() {} // 0x0000000183DA5030-0x0000000183DA5570
	// [XID] // 0x00000001898200C0-0x00000001898200E0
	public override void ClearView() {} // 0x0000000183DA3C80-0x0000000183DA3E10
	// [XID] // 0x0000000189827680-0x00000001898276A0
	protected override void BindViewCallbacks() {} // 0x0000000183DA3890-0x0000000183DA3A50
	// [XID] // 0x000000018982E8A0-0x000000018982E8C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183DA4370-0x0000000183DA4750
	// [XID] // 0x0000000189836240-0x0000000189836260
	private void SetScrollerHighlight(bool isOnMonth) {} // 0x0000000183DA4050-0x0000000183DA4180
	// [XID] // 0x000000018983D6B0-0x000000018983D6D0
	private void RefreshMonthSlot(Transform trans, int index) {} // 0x0000000183DA3A50-0x0000000183DA3C80
	// [XID] // 0x0000000189844E90-0x0000000189844EB0
	private void RefreshDaySlot(Transform trans, int index) {} // 0x0000000183DA47B0-0x0000000183DA49E0
	// [XID] // 0x000000018984C360-0x000000018984C380
	private void OnBirthdaySlotInShowRange(Transform trans, float value) {} // 0x0000000183DA4180-0x0000000183DA4310
	// [XID] // 0x00000001898534F0-0x0000000189853510
	private void OnMonthSlotClick(int index) {} // 0x0000000183DA4AC0-0x0000000183DA4E80
	// [XID] // 0x000000018985AF20-0x000000018985AF40
	private void OnDaySlotClick(int index) {} // 0x0000000183DA32F0-0x0000000183DA33B0
	// [XID] // 0x00000001898623C0-0x00000001898623E0
	private void OnConfirmBtnClick() {} // 0x0000000183DA3560-0x0000000183DA3890
	// [XID] // 0x00000001898698B0-0x00000001898698D0
	private void RequestSetPlayerBirthday() {} // 0x0000000183DA3E10-0x0000000183DA3FC0
	// [XID] // 0x0000000189870A50-0x0000000189870A70
	public void TryCreatMonthHighlight() {} // 0x0000000183DA4E80-0x0000000183DA5030
	// [XID] // 0x0000000189878540-0x0000000189878560
	public void TryCreatDayHighlight() {} // 0x0000000183DA33B0-0x0000000183DA3560
}

