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

public sealed class GeneralScrollDialogContext : BaseDialogContext // TypeDefIndex: 28727
{
	// Fields
	public string title; // 0x178
	public string desc; // 0x180
	public string okBtnText; // 0x188
	public string cancelBtnText; // 0x190
	public Action<bool> buttonCallBack; // 0x198
	private MonoGeneralDialog _dialogMono; // 0x1A0
	private GeneralDialogContext.GeneralDialogType _type; // 0x1A8

	// Constructors
	public GeneralScrollDialogContext() {} // Dummy constructor
	public GeneralScrollDialogContext(GeneralDialogContext.GeneralDialogType type = GeneralDialogContext.GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E5E8 */) {} // 0x000000018212C680-0x000000018212C780

	// Methods
	// [XID] // 0x000000018983F030-0x000000018983F050
	public override void SetupView() {} // 0x000000018212C430-0x000000018212C680
	// [XID] // 0x00000001898466B0-0x00000001898466D0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018212C0E0-0x000000018212C250
	// [XID] // 0x000000018984DC60-0x000000018984DC80
	protected override void BindViewCallbacks() {} // 0x000000018212BD50-0x000000018212BF50
	// [XID] // 0x0000000189854D20-0x0000000189854D40
	private void OnOKButtonCallBack() {} // 0x000000018212BF50-0x000000018212BFF0
	// [XID] // 0x000000018985C4E0-0x000000018985C500
	private void OnCancelButtonCallBack() {} // 0x000000018212C250-0x000000018212C2F0
	// [XID] // 0x0000000189863E40-0x0000000189863E60
	private void OnButtonClick(bool isOk) {} // 0x000000018212C2F0-0x000000018212C3D0
}

