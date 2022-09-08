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

public sealed class MPInvitationDialogContext : BaseWidgetContext // TypeDefIndex: 29262
{
	// Fields
	private MonoMPInvitationDialog _dialogMono; // 0x168
	public MPRemindType remindType; // 0x170
	private float _remainSeconds; // 0x174
	private ApplingGuestData? _currShowingGuest; // 0x178
	private InvitingHostData? _invitingHost; // 0x1D8
	private float _currMatchTime; // 0x238

	// Constructors
	public MPInvitationDialogContext() {} // 0x000000018502C800-0x000000018502C990

	// Methods
	// [XID] // 0x0000000189BBAB20-0x0000000189BBAB40
	public override void SetupView() {} // 0x000000018502C500-0x000000018502C730
	// [XID] // 0x0000000189BC2B50-0x0000000189BC2B70
	protected override void BindViewCallbacks() {} // 0x000000018502A920-0x000000018502AA80
	// [XID] // 0x0000000189BCA240-0x0000000189BCA260
	public override void UpdateView() {} // 0x000000018502C730-0x000000018502C800
	// [XID] // 0x0000000189BD18D0-0x0000000189BD18F0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018502BEB0-0x000000018502BFA0
	// [XID] // 0x0000000189BD8E80-0x0000000189BD8EA0
	private void UpdateView_GuestAppling() {} // 0x00000001850299A0-0x0000000185029EC0
	// [XID] // 0x00000001895E5A40-0x00000001895E5A60
	private void ShowApplingGuest(ApplingGuestData playerData) {} // 0x000000018502B2B0-0x000000018502B640
	// [XID] // 0x00000001895ED370-0x00000001895ED390
	private void OnClicked_GuestAppling() {} // 0x000000018502B180-0x000000018502B250
	// [XID] // 0x00000001895F4AB0-0x00000001895F4AD0
	private void UpdateView_HostInviting() {} // 0x000000018502A410-0x000000018502A770
	// [XID] // 0x00000001895FC1E0-0x00000001895FC200
	private void InitHostInviting() {} // 0x000000018502B850-0x000000018502BB30
	// [XID] // 0x0000000189603B80-0x0000000189603BA0
	private void RefreshHostInviting() {} // 0x000000018502BB30-0x000000018502BDC0
	// [XID] // 0x000000018960B4E0-0x000000018960B500
	private void OnClicked_HostInviting() {} // 0x000000018502BFA0-0x000000018502C500
	// [XID] // 0x00000001896128B0-0x00000001896128D0
	private void RefreshMatchView() {} // 0x0000000185029EC0-0x000000018502A410
	// [XID] // 0x000000018961A240-0x000000018961A260
	private void RefreshMatchText() {} // 0x000000018502AA80-0x000000018502ADF0
	// [XID] // 0x0000000189621770-0x0000000189621790
	private void UpdateView_Match() {} // 0x000000018502A770-0x000000018502A920
	// [XID] // 0x0000000189629040-0x0000000189629060
	private void OnClicked_Match() {} // 0x000000018502AF60-0x000000018502B050
	// [XID] // 0x00000001896309C0-0x00000001896309E0
	public override void ClearView() {} // 0x000000018502ADF0-0x000000018502AF60
	// [XID] // 0x0000000189638480-0x00000001896384A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018502B640-0x000000018502B790
}

