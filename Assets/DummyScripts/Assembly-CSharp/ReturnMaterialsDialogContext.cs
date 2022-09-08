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

public sealed class ReturnMaterialsDialogContext : BaseDialogContext // TypeDefIndex: 28970
{
	// Fields
	private MonoGeneralDialog _dialogMono; // 0x178
	private WeaponUpgradeTipInfo _tipInfo; // 0x180
	private Action _confirmCB; // 0x188

	// Constructors
	public ReturnMaterialsDialogContext() {} // Dummy constructor
	public ReturnMaterialsDialogContext(WeaponUpgradeTipInfo tipInfo, Action confirmCB) {} // 0x0000000183B52B40-0x0000000183B52C30

	// Methods
	// [XID] // 0x0000000189AF9FA0-0x0000000189AF9FC0
	public override void SetupView() {} // 0x0000000183B528E0-0x0000000183B52B40
	[DebuggerHidden] // 0x0000000189B014B0-0x0000000189B014F0
	// [XID] // 0x0000000189B014B0-0x0000000189B014F0
	private IEnumerator DelayShowScroller() => default; // 0x0000000183B527D0-0x0000000183B528E0
	// [XID] // 0x0000000189B0BB10-0x0000000189B0BB30
	private bool HasReturnItems() => default; // 0x0000000183B51B60-0x0000000183B51C50
	// [XID] // 0x0000000189B13020-0x0000000189B13040
	private void RefreshReturnItems(Transform trans, int index) {} // 0x0000000183B51250-0x0000000183B514D0
	// [XID] // 0x0000000189B1A6F0-0x0000000189B1A710
	private void SetContentText() {} // 0x0000000183B52370-0x0000000183B525A0
	// [XID] // 0x0000000189B21CE0-0x0000000189B21D00
	private string GetCandidateNeedToTipText() => default; // 0x0000000183B51870-0x0000000183B51AD0
	// [XID] // 0x0000000189B293A0-0x0000000189B293C0
	public override void ClearView() {} // 0x0000000183B51630-0x0000000183B516D0
	// [XID] // 0x0000000189B307B0-0x0000000189B307D0
	private void OnClickOKBtn() {} // 0x0000000183B516D0-0x0000000183B51870
	// [XID] // 0x0000000189B38050-0x0000000189B38070
	private string GetExceedLimitTipText() => default; // 0x0000000183B52020-0x0000000183B52370
	// [XID] // 0x0000000189B3FA80-0x0000000189B3FAA0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183B52700-0x0000000183B527D0
	// [XID] // 0x0000000189B472A0-0x0000000189B472C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183B51CB0-0x0000000183B51FC0
	// [XID] // 0x0000000189B4EAC0-0x0000000189B4EAE0
	protected override void BindViewCallbacks() {} // 0x0000000183B514D0-0x0000000183B51630
}

