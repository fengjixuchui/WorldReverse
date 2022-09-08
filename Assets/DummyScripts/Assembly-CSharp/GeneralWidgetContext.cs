/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GeneralWidgetContext : BaseWidgetContext // TypeDefIndex: 29349
{
	// Fields
	public string title; // 0x168
	public string desc; // 0x170
	public string okBtnText; // 0x178
	public string cancelBtnText; // 0x180
	public Action<bool> buttonCallBack; // 0x188
	private MonoUIContainer _okBtn; // 0x190
	private MonoUIContainer _cancelBtn; // 0x198
	private GeneralDialogType _type; // 0x1A0

	// Nested types
	public enum GeneralDialogType // TypeDefIndex: 29350
	{
		DOUBLE_BUTTON = 0,
		SINGLE_BUTTON = 1
	}

	// Constructors
	public GeneralWidgetContext() {} // Dummy constructor
	public GeneralWidgetContext(GeneralDialogType type = GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0F620 */) {} // 0x0000000180DD2DC0-0x0000000180DD2EB0

	// Methods
	// [XID] // 0x000000018995D3A0-0x000000018995D3C0
	public override void SetupView() {} // 0x0000000180DD27B0-0x0000000180DD2DC0
	// [XID] // 0x0000000189964A50-0x0000000189964A70
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000180DD2350-0x0000000180DD2450
	// [XID] // 0x000000018996C110-0x000000018996C130
	protected override void BindViewCallbacks() {} // 0x0000000180DD2060-0x0000000180DD21C0
	// [XID] // 0x0000000189973BC0-0x0000000189973BE0
	public void OnOKButtonCallBack() {} // 0x0000000180DD21C0-0x0000000180DD2260
	// [XID] // 0x000000018997B230-0x000000018997B250
	public void OnCancelButtonCallBack() {} // 0x0000000180DD24B0-0x0000000180DD2550
	// [XID] // 0x0000000189982CE0-0x0000000189982D00
	public void OnBGClick(BaseEventData evtData = null) {} // 0x0000000180DD2550-0x0000000180DD2610
	// [XID] // 0x000000018998A4D0-0x000000018998A4F0
	private void OnButtonClick(bool isOk) {} // 0x0000000180DD2610-0x0000000180DD26F0
}

