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

public sealed class SynMeltingSelectListDialogContext : BaseDialogContext // TypeDefIndex: 29633
{
	// Fields
	private MonoSynMeltingDialog _dialogMono; // 0x178
	private List<uint> _combineIDList; // 0x180
	private uint selectedId; // 0x188
	private int selectedIndex; // 0x18C
	private Action<uint> _closeCallBack; // 0x190
	private int _curSelectedIndex; // 0x198
	private static readonly uint _selectRowAudio; // 0x00
	private static readonly uint _selectItemAudio; // 0x04
	private int _curSelectItemIndex; // 0x19C

	// Constructors
	public SynMeltingSelectListDialogContext() {} // Dummy constructor
	public SynMeltingSelectListDialogContext(List<uint> combineIDList, Action<uint> closeCallBack = null, uint selectCombineId = 0 /* Metadata: 0x00B0FA94 */) {} // 0x0000000183FB49C0-0x0000000183FB4B40
	static SynMeltingSelectListDialogContext() {} // 0x0000000183FB4910-0x0000000183FB49C0

	// Methods
	// [XID] // 0x0000000189BDC1B0-0x0000000189BDC1D0
	public override void SetupView() {} // 0x0000000183FB4650-0x0000000183FB4910
	// [XID] // 0x00000001895E89F0-0x00000001895E8A10
	private void SetupViewJotStick() {} // 0x0000000183FB3FE0-0x0000000183FB41E0
	// [XID] // 0x00000001895F0240-0x00000001895F0260
	protected override void BindViewCallbacks() {} // 0x0000000183FB2E50-0x0000000183FB2F50
	// [XID] // 0x00000001895F7D10-0x00000001895F7D30
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183FB3310-0x0000000183FB3F80
	// [XID] // 0x00000001895FF0B0-0x00000001895FF0D0
	private void InitScroller(Transform trans, int index) {} // 0x0000000183FB4240-0x0000000183FB4650
	// [XID] // 0x0000000189606970-0x0000000189606990
	private void OnMeltingRowClick(uint id) {} // 0x0000000183FB30A0-0x0000000183FB32B0
	// [XID] // 0x000000018960E2B0-0x000000018960E2D0
	private void OnBackBtnClick() {} // 0x0000000183FB2DA0-0x0000000183FB2E50
	// [XID] // 0x0000000189615940-0x0000000189615960
	public override void CloseDialog() {} // 0x0000000183FB2F50-0x0000000183FB3010
}

