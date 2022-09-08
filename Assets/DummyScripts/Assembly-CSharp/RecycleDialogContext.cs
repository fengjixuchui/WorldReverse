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

internal sealed class RecycleDialogContext : BaseDialogContext // TypeDefIndex: 30307
{
	// Fields
	private MonoRecycleDialog _dialogMono; // 0x178
	private MapField<uint, uint> _deleteMap; // 0x180
	private MapField<uint, uint> _returnMap; // 0x188
	private List<uint> _deleteItemList; // 0x190
	private List<uint> _returnItemList; // 0x198
	private int _curSelectRow; // 0x1A0
	private int _curSelectColumn; // 0x1A4

	// Constructors
	public RecycleDialogContext() {} // Dummy constructor
	public RecycleDialogContext(MapField<uint, uint> deleteMap, MapField<uint, uint> returnMap) {} // 0x0000000183737C30-0x0000000183738150

	// Methods
	// [XID] // 0x0000000189BB9030-0x0000000189BB9050
	public override void SetupView() {} // 0x0000000183737880-0x0000000183737C30
	// [XID] // 0x0000000189BC0E40-0x0000000189BC0E60
	public override void ClearView() {} // 0x0000000183736AF0-0x0000000183736BA0
	// [XID] // 0x0000000189BC8550-0x0000000189BC8570
	private void RefreshDeleteItem(Transform trans, int index) {} // 0x0000000183736D30-0x0000000183736FD0
	// [XID] // 0x0000000189BCFDF0-0x0000000189BCFE10
	private void RefreshReturnItem(Transform trans, int index) {} // 0x0000000183736650-0x00000001837368E0
	// [XID] // 0x0000000189BD73F0-0x0000000189BD7410
	protected override void BindViewCallbacks() {} // 0x00000001837369F0-0x0000000183736AF0
	// [XID] // 0x0000000189BDEEF0-0x0000000189BDEF10
	private void InitJoypadSelectState() {} // 0x0000000183736BA0-0x0000000183736CA0
	// [XID] // 0x00000001895EBBA0-0x00000001895EBBC0
	private void ResetSelect() {} // 0x00000001837368E0-0x00000001837369F0
	// [XID] // 0x00000001895F2F20-0x00000001895F2F40
	private void ClampRowColumnIndex(ref int row, ref int column) {} // 0x00000001837374D0-0x0000000183737650
	// [XID] // 0x00000001895FA780-0x00000001895FA7A0
	private bool SetSelect(int newRow, int newColumn, bool force = false /* Metadata: 0x00B109AD */) => default; // 0x0000000183737650-0x0000000183737820
	// [XID] // 0x0000000189602150-0x0000000189602170
	private MonoBagProxySlot GetCurSelectItem() => default; // 0x00000001837372D0-0x00000001837374D0
	// [XID] // 0x0000000189609930-0x0000000189609950
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183737030-0x0000000183737270
}

