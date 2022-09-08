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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InfoTextDialogContext : BaseDialogContext // TypeDefIndex: 29162
{
	// Fields
	private MonoInfoTextDialog _dialogMono; // 0x178
	private List<string> _contents; // 0x180
	private bool _needFreeClickButton; // 0x188
	private bool _interactable; // 0x189
	private bool? _customEnableInputPenetrate; // 0x18A
	private InfoState _infoState; // 0x18C
	private float _nextTimeStamp; // 0x190
	private bool _needFadeIn; // 0x194

	// Properties
	public override bool enableInputPenetrate { /* [XID] */ /* 0x00000001898E5390-0x00000001898E53B0 */ get => default; } // 0x00000001846B7770-0x00000001846B7860 

	// Nested types
	private enum InfoState // TypeDefIndex: 29163
	{
		Init = 0,
		ForceShow = 1,
		WaitToClose = 2,
		FadeOut = 3
	}

	// Constructors
	public InfoTextDialogContext() {} // Dummy constructor
	public InfoTextDialogContext(bool needFreeClickButton = true /* Metadata: 0x00B0ECFB */, bool? enableInputPenetrate = default) {} // 0x00000001846B7640-0x00000001846B7770

	// Methods
	// [XID] // 0x000000018978E760-0x000000018978E780
	public void AddContent(string content, bool discardIfDuplicated = false /* Metadata: 0x00B0ECFC */) {} // 0x00000001846B6EF0-0x00000001846B7140
	// [XID] // 0x00000001898F44D0-0x00000001898F44F0
	public override void SetupView() {} // 0x00000001846B7140-0x00000001846B72E0
	// [XID] // 0x00000001898FBC60-0x00000001898FBC80
	private void CheckEmptyContent() {} // 0x00000001846B6C00-0x00000001846B6D50
	// [XID] // 0x00000001899036D0-0x00000001899036F0
	public override void UpdateView() {} // 0x00000001846B72E0-0x00000001846B7640
	// [XID] // 0x000000018990ABC0-0x000000018990ABE0
	public override void ClearView() {} // 0x00000001846B6780-0x00000001846B6840
	// [XID] // 0x00000001899128F0-0x0000000189912910
	protected override void BindViewCallbacks() {} // 0x00000001846B6680-0x00000001846B6780
	// [XID] // 0x000000018991A1C0-0x000000018991A1E0
	public void OnFreeClickButtonClicked() {} // 0x00000001846B6840-0x00000001846B68F0
	// [XID] // 0x00000001899219C0-0x00000001899219E0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846B69E0-0x00000001846B6AD0
	// [XID] // 0x00000001899290E0-0x0000000189929100
	public void UpdateCurrentShowContent(string content) {} // 0x00000001846B6DB0-0x00000001846B6EF0
}

