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

public sealed class ErrorDialogContext : BaseDialogContext // TypeDefIndex: 29051
{
	// Fields
	public string title; // 0x178
	public string desc; // 0x180
	public string okBtnText; // 0x188
	public string cancelBtnText; // 0x190
	public Action<bool> buttonCallBack; // 0x198
	private MonoErrorDialog _pageMono; // 0x1A0
	public int fontSize; // 0x1A8
	public GeneralDialogContext.GeneralDialogType dialogBtnType; // 0x1AC

	// Constructors
	public ErrorDialogContext() {} // 0x000000018529C710-0x000000018529C850

	// Methods
	// [XID] // 0x0000000189895860-0x0000000189895880
	public override void SetupView() {} // 0x000000018529C400-0x000000018529C710
	// [XID] // 0x000000018989CFC0-0x000000018989CFE0
	public override void ClearView() {} // 0x000000018529BD10-0x000000018529BDE0
	// [XID] // 0x00000001898A4840-0x00000001898A4860
	public void OnOKButtonCallBack() {} // 0x000000018529BDE0-0x000000018529BE80
	// [XID] // 0x00000001898ABD00-0x00000001898ABD20
	public void OnCancelButtonCallBack() {} // 0x000000018529C220-0x000000018529C2C0
	// [XID] // 0x00000001898B3430-0x00000001898B3450
	private void OnButtonClick(bool isOk) {} // 0x000000018529C2C0-0x000000018529C3A0
	// [XID] // 0x00000001898BB110-0x00000001898BB130
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018529BF70-0x000000018529C160
}

