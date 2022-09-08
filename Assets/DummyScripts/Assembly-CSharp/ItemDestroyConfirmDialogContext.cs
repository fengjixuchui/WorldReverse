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

public sealed class ItemDestroyConfirmDialogContext : BaseDialogContext // TypeDefIndex: 29168
{
	// Fields
	private MonoItemDestroyConfirmDialog _dialogMono; // 0x178
	private Action _closeDestroyDialog; // 0x180
	private List<BagItemSlot> _sourceScrollList; // 0x188
	private int _currSourceItemIndex; // 0x190
	private List<BagItemSlot> _targetScrollList; // 0x198
	private int _currTargetItemIndex; // 0x1A0
	private Foucs _foucs; // 0x1A4
	private bool _haveTarget; // 0x1A8

	// Nested types
	private enum Foucs // TypeDefIndex: 29169
	{
		None = 0,
		Source = 1,
		Target = 2
	}

	// Constructors
	public ItemDestroyConfirmDialogContext() {} // Dummy constructor
	public ItemDestroyConfirmDialogContext(List<BagItemSlot> source, List<BagItemSlot> target, Action closeDestroyDialog) {} // 0x0000000184A93260-0x0000000184A933E0

	// Methods
	// [XID] // 0x00000001899EBD40-0x00000001899EBD60
	public override void SetupView() {} // 0x0000000184A93050-0x0000000184A93260
	// [XID] // 0x00000001899F37D0-0x00000001899F37F0
	protected override void BindViewCallbacks() {} // 0x0000000184A911A0-0x0000000184A91360
	// [XID] // 0x00000001899FB0F0-0x00000001899FB110
	private void OnCancelButtonClicked() {} // 0x0000000184A91360-0x0000000184A91410
	// [XID] // 0x0000000189A02340-0x0000000189A02360
	private void OnConfirmButtonClicked() {} // 0x0000000184A92BB0-0x0000000184A92E50
	// [XID] // 0x0000000189A09B30-0x0000000189A09B50
	private void SetupSourceScrollView() {} // 0x0000000184A91BA0-0x0000000184A91D10
	// [XID] // 0x0000000189A112D0-0x0000000189A112F0
	private void SourceScrollOnChangeCallBack(Transform trans, int index) {} // 0x0000000184A92210-0x0000000184A92430
	// [XID] // 0x0000000189A186E0-0x0000000189A18700
	private void OnSourceScrollItemClicked(int index) {} // 0x0000000184A927E0-0x0000000184A92930
	// [XID] // 0x0000000189A1FD60-0x0000000189A1FD80
	private void OnSourceScrollItemSelected(bool active) {} // 0x0000000184A91630-0x0000000184A918A0
	// [XID] // 0x0000000189A270F0-0x0000000189A27110
	private void OnSourceScrollItemConfirmed() {} // 0x0000000184A92FA0-0x0000000184A93050
	// [XID] // 0x0000000189A2E8F0-0x0000000189A2E910
	private void SetupTargetScrollView() {} // 0x0000000184A92930-0x0000000184A92AA0
	// [XID] // 0x0000000189A36240-0x0000000189A36260
	private void TargetScrollOnChangeCallBack(Transform trans, int index) {} // 0x0000000184A91410-0x0000000184A91630
	// [XID] // 0x0000000189A3D840-0x0000000189A3D860
	private void OnTargetScrollItemClicked(int index) {} // 0x0000000184A925B0-0x0000000184A92700
	// [XID] // 0x0000000189A44FC0-0x0000000189A44FE0
	private void OnTargetScrollItemSelected(bool active) {} // 0x0000000184A91930-0x0000000184A91BA0
	// [XID] // 0x0000000189A4C700-0x0000000189A4C720
	private void OnTargetScrollItemConfirmed() {} // 0x0000000184A92160-0x0000000184A92210
	// [XID] // 0x0000000189A53EE0-0x0000000189A53F00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A91E10-0x0000000184A92160
	// [XID] // 0x0000000189A5B910-0x0000000189A5B930
	private void HandlePrevRow() {} // 0x0000000184A92EB0-0x0000000184A92FA0
	// [XID] // 0x0000000189A62FC0-0x0000000189A62FE0
	private void HandleNextRow() {} // 0x0000000184A92AA0-0x0000000184A92BB0
	// [XID] // 0x0000000189A6AB20-0x0000000189A6AB40
	private void HandlePrevSlot() {} // 0x0000000184A90FD0-0x0000000184A91100
	// [XID] // 0x0000000189A721E0-0x0000000189A72200
	private void HandleNextSlot() {} // 0x0000000184A92430-0x0000000184A925B0
	// [XID] // 0x0000000189A79E80-0x0000000189A79EA0
	private void HandleConfirm() {} // 0x0000000184A91100-0x0000000184A911A0
	// [XID] // 0x0000000189A81300-0x0000000189A81320
	private void HandleBack() {} // 0x0000000184A91D70-0x0000000184A91E10
	// [XID] // 0x0000000189A88D00-0x0000000189A88D20
	private void HandleShowItemDetail() {} // 0x0000000184A92700-0x0000000184A927E0
}

