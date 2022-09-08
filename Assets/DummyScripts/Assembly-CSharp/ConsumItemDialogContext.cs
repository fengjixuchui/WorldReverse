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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class ConsumItemDialogContext : BaseDialogContext // TypeDefIndex: 28888
{
	// Fields
	private MonoConsumItemDialog _dialogMono; // 0x178
	private string _title; // 0x180
	private string _desc; // 0x188
	private List<IdCountStruct> _itemList; // 0x190
	private Action _okCallBack; // 0x198

	// Constructors
	public ConsumItemDialogContext() {} // Dummy constructor
	public ConsumItemDialogContext(string title, string desc, List<IdCountConfig> itemList, Action callBack) {} // 0x0000000181C3B790-0x0000000181C3BA60
	public ConsumItemDialogContext(string title, string desc, List<IdCountStruct> itemList, Action callBack) {} // 0x0000000181C3BA60-0x0000000181C3BBE0

	// Methods
	// [XID] // 0x0000000189B48AA0-0x0000000189B48AC0
	public override void SetupView() {} // 0x0000000181C3B4F0-0x0000000181C3B790
	// [XID] // 0x0000000189B50230-0x0000000189B50250
	private bool CheckItemNumbers() => default; // 0x0000000181C3AC50-0x0000000181C3ADF0
	// [XID] // 0x0000000189B57A60-0x0000000189B57A80
	private void RefreshItemSlot(Transform trans, int index) {} // 0x0000000181C3A820-0x0000000181C3ABF0
	// [XID] // 0x0000000189B5F3D0-0x0000000189B5F3F0
	protected override void BindViewCallbacks() {} // 0x0000000181C3A5D0-0x0000000181C3A790
	// [XID] // 0x0000000189B669C0-0x0000000189B669E0
	private void OnClickOkBtn() {} // 0x0000000181C3B1C0-0x0000000181C3B280
	// [XID] // 0x0000000189B6DF20-0x0000000189B6DF40
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181C3ADF0-0x0000000181C3B1C0
	// [XID] // 0x0000000189B75610-0x0000000189B75630
	private void SetDisabled(Button button, bool value) {} // 0x0000000181C3B2E0-0x0000000181C3B4F0
}

