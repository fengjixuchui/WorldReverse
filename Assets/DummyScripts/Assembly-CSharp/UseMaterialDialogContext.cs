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

public class UseMaterialDialogContext : BaseDialogContext // TypeDefIndex: 29344
{
	// Fields
	protected MonoUseMaterialDialog _dialogMono; // 0x178
	protected List<BagItem> _itemList; // 0x180
	protected uint _useCount; // 0x188
	protected uint _maxCount; // 0x18C
	protected int _selectedIndex; // 0x190
	protected AvatarDataItem _target; // 0x198

	// Constructors
	public UseMaterialDialogContext() {} // Dummy constructor
	public UseMaterialDialogContext(AvatarDataItem target) {} // 0x000000018282CDB0-0x000000018282CEB0

	// Methods
	// [XID] // 0x0000000189841D00-0x0000000189841D20
	public override void SetupView() {} // 0x000000018282C9F0-0x000000018282CDB0
	// [XID] // 0x0000000189849210-0x0000000189849230
	protected override void BindViewCallbacks() {} // 0x000000018282ACB0-0x000000018282AF30
	// [XID] // 0x00000001898509D0-0x00000001898509F0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018282C770-0x000000018282C840
	// [XID] // 0x0000000189857D60-0x0000000189857D80
	protected virtual void UpdateUseableMaterial() {} // 0x000000018282B740-0x000000018282B7E0
	// [XID] // 0x000000018985EE50-0x000000018985EE70
	protected void Refresh() {} // 0x000000018282AAB0-0x000000018282AB70
	// [XID] // 0x0000000189866630-0x0000000189866650
	protected virtual void OnRefresh() {} // 0x000000018282B030-0x000000018282B0D0
	// [XID] // 0x000000018986DF30-0x000000018986DF50
	protected void IncreaseUseCount() {} // 0x000000018282C840-0x000000018282C950
	// [XID] // 0x0000000189875300-0x0000000189875320
	protected virtual void ShowHelp() {} // 0x000000018282AC10-0x000000018282ACB0
	// [XID] // 0x000000018987CED0-0x000000018987CEF0
	private void DecreaseUseCount() {} // 0x000000018282AF30-0x000000018282B030
	// [XID] // 0x0000000189883E70-0x0000000189883E90
	protected virtual void RefreshUsePreview() {} // 0x000000018282AB70-0x000000018282AC10
	// [XID] // 0x000000018988B510-0x000000018988B530
	protected void RefreshSlot(Transform trans, int index) {} // 0x000000018282B480-0x000000018282B740
	// [XID] // 0x0000000189892CD0-0x0000000189892CF0
	protected void OnSlotClicked(int index) {} // 0x000000018282B0D0-0x000000018282B350
	// [XID] // 0x000000018989A330-0x000000018989A350
	protected virtual void OnUseMaterialChanged(int index) {} // 0x000000018282C0C0-0x000000018282C170
	// [XID] // 0x00000001898A1590-0x00000001898A15B0
	protected virtual void Use() {} // 0x000000018282C170-0x000000018282C4B0
	// [XID] // 0x00000001898A8DE0-0x00000001898A8E00
	protected virtual void OnUse() {} // 0x000000018282B350-0x000000018282B3F0
	// [XID] // 0x00000001898B0780-0x00000001898B07A0
	protected virtual void OnNoItemUse() {} // 0x000000018282C950-0x000000018282C9F0
	// [XID] // 0x00000001898B7D90-0x00000001898B7DB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018282B840-0x000000018282C0C0
	// [XID] // 0x00000001898BF400-0x00000001898BF420
	public override void OnInputDeviceChanged() {} // 0x000000018282C600-0x000000018282C770
}

