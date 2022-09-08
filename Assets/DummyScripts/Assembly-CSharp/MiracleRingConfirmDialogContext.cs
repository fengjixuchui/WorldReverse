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

internal sealed class MiracleRingConfirmDialogContext : BaseDialogContext // TypeDefIndex: 30290
{
	// Fields
	private MonoMiracleRingConfirmDialog _dialogMono; // 0x178
	private List<BagPageContext.MiracleRingItemInfo> _items; // 0x180
	private Action _confirmCallBack; // 0x188
	private int _curSelectColumn; // 0x190

	// Constructors
	public MiracleRingConfirmDialogContext() {} // Dummy constructor
	public MiracleRingConfirmDialogContext(List<BagPageContext.MiracleRingItemInfo> items, Action confirmCallBack) {} // 0x0000000182AF4CC0-0x0000000182AF4DC0

	// Methods
	// [XID] // 0x0000000189A9C0C0-0x0000000189A9C0E0
	public override void SetupView() {} // 0x0000000182AF4B10-0x0000000182AF4CC0
	// [XID] // 0x0000000189AA37D0-0x0000000189AA37F0
	public override void ClearView() {} // 0x0000000182AF3B80-0x0000000182AF3C30
	// [XID] // 0x0000000189AAAE30-0x0000000189AAAE50
	private void RefreshDeleteItem(Transform trans, int index) {} // 0x0000000182AF41C0-0x0000000182AF4400
	// [XID] // 0x0000000189AB2800-0x0000000189AB2820
	protected override void BindViewCallbacks() {} // 0x0000000182AF39C0-0x0000000182AF3B80
	// [XID] // 0x0000000189ABA330-0x0000000189ABA350
	private void OnConfirm() {} // 0x0000000182AF3DB0-0x0000000182AF41C0
	// [XID] // 0x0000000189AC1C60-0x0000000189AC1C80
	private void InitJoypadSelectState() {} // 0x0000000182AF3C30-0x0000000182AF3D20
	// [XID] // 0x0000000189AC9210-0x0000000189AC9230
	private void ResetSelect() {} // 0x0000000182AF38B0-0x0000000182AF39C0
	// [XID] // 0x0000000189AD0CA0-0x0000000189AD0CC0
	private bool SetSelect(int newColumn, bool force = false /* Metadata: 0x00B10971 */) => default; // 0x0000000182AF4880-0x0000000182AF4AB0
	// [XID] // 0x0000000189AD88A0-0x0000000189AD88C0
	private MonoItemSlot GetCurSelectItem() => default; // 0x0000000182AF4750-0x0000000182AF4880
	// [XID] // 0x0000000189AE0500-0x0000000189AE0520
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182AF4460-0x0000000182AF46F0
}

