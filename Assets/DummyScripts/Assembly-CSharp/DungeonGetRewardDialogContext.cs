/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonGetRewardDialogContext : BasePageContext // TypeDefIndex: 28938
{
	// Fields
	private MonoDungeonEndDialog _dialogMono; // 0x190
	private List<Item> _itemList; // 0x198
	private long _autoQuitLimit; // 0x1A0
	private float _restartCountDown; // 0x1A8
	private float RESTART_COUNT_DOWN; // 0x1AC

	// Constructors
	public DungeonGetRewardDialogContext() {} // Dummy constructor
	public DungeonGetRewardDialogContext(GadgetAutoPickDropInfoNotify notify) {} // 0x000000018118A2F0-0x000000018118A570

	// Methods
	// [XID] // 0x0000000189AC1E40-0x0000000189AC1E60
	private int ItemComparer(Item x, Item y) => default; // 0x0000000181189B30-0x0000000181189C50
	// [XID] // 0x0000000189AC93F0-0x0000000189AC9410
	public override void SetupView() {} // 0x0000000181189E00-0x0000000181189F70
	// [XID] // 0x0000000189AD0E80-0x0000000189AD0EA0
	public override void UpdateView() {} // 0x0000000181189F70-0x000000018118A2F0
	// [XID] // 0x0000000189AD8B10-0x0000000189AD8B30
	private void InitUIVisible() {} // 0x0000000181187E60-0x0000000181188980
	[DebuggerHidden] // 0x0000000189AE06A0-0x0000000189AE06E0
	// [XID] // 0x0000000189AE06A0-0x0000000189AE06E0
	private IEnumerator DelaySetButtonBGInteractable() => default; // 0x0000000181189640-0x0000000181189750
	// [XID] // 0x0000000189AEAD30-0x0000000189AEAD50
	private void SetScroller() {} // 0x0000000181188E30-0x0000000181188FE0
	// [XID] // 0x0000000189AF2600-0x0000000189AF2620
	private void SetAutoQuitLimit() {} // 0x0000000181188A10-0x0000000181188B90
	// [XID] // 0x0000000189AF9FC0-0x0000000189AF9FE0
	private void ResetRestartCountDown() {} // 0x00000001811876E0-0x00000001811878C0
	// [XID] // 0x0000000189B014F0-0x0000000189B01510
	protected override void BindViewCallbacks() {} // 0x0000000181187500-0x00000001811876E0
	// [XID] // 0x0000000189B08A00-0x0000000189B08A20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181189040-0x0000000181189560
	// [XID] // 0x0000000189B103E0-0x0000000189B10400
	private void RefreshItemSlot(Transform trans, int index) {} // 0x0000000181188B90-0x0000000181188E30
	// [XID] // 0x0000000189B17520-0x0000000189B17540
	private uint GetItemCount(Item item) => default; // 0x00000001811878C0-0x00000001811879C0
	// [XID] // 0x0000000189B1EE40-0x0000000189B1EE60
	private void RequestQuit() {} // 0x0000000181189CB0-0x0000000181189E00
	// [XID] // 0x0000000189B267B0-0x0000000189B267D0
	private void RequestRestart() {} // 0x0000000181189800-0x0000000181189930
	// [XID] // 0x0000000189B2D9C0-0x0000000189B2D9E0
	private void OnBtnRestartClick() {} // 0x0000000181189750-0x0000000181189800
	// [XID] // 0x0000000189B34DE0-0x0000000189B34E00
	private bool CheckAndShowNoResinTip() => default; // 0x00000001811879C0-0x0000000181187E60
	// [XID] // 0x0000000189B3C670-0x0000000189B3C690
	private void ShowTips(string title, string desc) {} // 0x0000000181189930-0x0000000181189B30
}

