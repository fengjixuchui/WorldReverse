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

internal sealed class SelectGoldAffixDialog : BaseDialogContext // TypeDefIndex: 30311
{
	// Fields
	private MonoSelectGoldAffixDialog _dialogMono; // 0x178
	private List<WeaponItem> _weaponList; // 0x180
	private Action<WeaponItem> _okCallBack; // 0x188
	private WeaponItem _selectWeaponItem; // 0x190
	private List<MonoGoldAffixItem> _affixItem; // 0x198
	private int _curIndex; // 0x1A0

	// Properties
	public Action<WeaponItem> okCallBack { /* [XID] */ /* 0x000000018963DE80-0x000000018963DEA0 */ set {} } // 0x00000001850AFD50-0x00000001850AFE00

	// Constructors
	public SelectGoldAffixDialog() {} // Dummy constructor
	public SelectGoldAffixDialog(List<WeaponItem> weaponList) {} // 0x00000001850B0460-0x00000001850B0580

	// Methods
	// [XID] // 0x0000000189645830-0x0000000189645850
	public override void SetupView() {} // 0x00000001850B02C0-0x00000001850B0460
	// [XID] // 0x000000018964D010-0x000000018964D030
	protected override void BindViewCallbacks() {} // 0x00000001850AFAF0-0x00000001850AFC80
	// [XID] // 0x00000001896547A0-0x00000001896547C0
	private void RefreshAffixItem(Transform trans, int index) {} // 0x00000001850AF8B0-0x00000001850AFAF0
	// [XID] // 0x000000018965BE90-0x000000018965BEB0
	private void OKCallBack() {} // 0x00000001850AFC80-0x00000001850AFD50
	// [XID] // 0x00000001896634C0-0x00000001896634E0
	private void OnClickItem(int index) {} // 0x00000001850B00F0-0x00000001850B0260
	// [XID] // 0x000000018966AE90-0x000000018966AEB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001850AFEF0-0x00000001850B0020
	// [XID] // 0x0000000189672AB0-0x0000000189672AD0
	public void SelectNext() {} // 0x00000001850B0020-0x00000001850B00F0
}

