/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuickUseTakePhoto : QuickWidgetBase // TypeDefIndex: 31361
{
	// Fields
	private BagItemSlot _equippedBagItemSlot; // 0x28
	private ulong lastTakePhotoTime; // 0x30
	private ulong takePhotoInterval; // 0x38

	// Constructors
	public QuickUseTakePhoto() {} // 0x0000000181731DA0-0x0000000181731E20

	// Methods
	// [XID] // 0x000000018960F9A0-0x000000018960F9C0
	public override LCWidgetBagActionPara DoBag(LCWidget lcWidget) => default; // 0x0000000181730980-0x0000000181730AC0
	// [XID] // 0x0000000189616BF0-0x0000000189616C10
	public override void DoBagPostAction(LCWidget lcWidget, bool success, WidgetSlotOp op) {} // 0x0000000181731C30-0x0000000181731DA0
	// [XID] // 0x000000018961E7A0-0x000000018961E7C0
	public override void InitOnAttach(WidgetSlotTag tag) {} // 0x0000000181731B30-0x0000000181731C30
	// [XID] // 0x0000000189625B80-0x0000000189625BA0
	public override void ClearOnUnAttach(WidgetSlotTag tag) {} // 0x0000000181731160-0x0000000181731210
	// [XID] // 0x000000018962D4A0-0x000000018962D4C0
	public override LCWidgetButtonActionPara DoActionPanel(LCWidget lcWidget) => default; // 0x0000000181730E40-0x0000000181731060
	// [XID] // 0x0000000189635060-0x0000000189635080
	public override string GetBagPageButtonText(LCWidget lcWidget) => default; // 0x0000000181731060-0x0000000181731160
	// [XID] // 0x000000018963C680-0x000000018963C6A0
	public override BagItemSlot GetCurrentEquippedBagItemSlot() => default; // 0x00000001817312C0-0x0000000181731360
	// [XID] // 0x0000000189643DD0-0x0000000189643DF0
	public override void TickActionPanel(MonoQuickUseButton mono) {} // 0x0000000181730AC0-0x0000000181730B70
	// [XID] // 0x000000018964B510-0x000000018964B530
	public override bool ShouldActionButtonShow(ActionPanelState state) => default; // 0x0000000181731210-0x00000001817312C0
	// [XID] // 0x0000000189652D40-0x0000000189652D60
	private void TakePhoto() {} // 0x0000000181730C60-0x0000000181730DC0
	// [XID] // 0x000000018965A420-0x000000018965A440
	private void DoOpenPhotograph() {} // 0x0000000181731520-0x00000001817318B0
	// [XID] // 0x0000000189661A70-0x0000000189661A90
	private void OnPhotographRelease() {} // 0x0000000181731930-0x0000000181731AD0
}

