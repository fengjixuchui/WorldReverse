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

public sealed class MPInvitationListDialogContext : BaseWidgetContext // TypeDefIndex: 29264
{
	// Fields
	private MonoMPInvitationListDialog _dialogMono; // 0x168
	private List<ApplingGuestData> _playerData; // 0x170
	private Dictionary<ApplingGuestKey, ApplingGuestData> _uid2data; // 0x178
	private Dictionary<ApplingGuestKey, MonoMPInvitationRow> _uid2row; // 0x180
	private int _curSelectIndex; // 0x188

	// Nested types
	public struct ApplingGuestKey // TypeDefIndex: 29265
	{
		// Fields
		public uint uid; // 0x00
		public uint type; // 0x04
	}

	// Constructors
	public MPInvitationListDialogContext() {} // 0x0000000181824890-0x00000001818249C0

	// Methods
	// [XID] // 0x0000000189660620-0x0000000189660640
	public override void SetupView() {} // 0x00000001818242E0-0x0000000181824650
	// [XID] // 0x0000000189667F60-0x0000000189667F80
	protected override void BindViewCallbacks() {} // 0x0000000181822520-0x0000000181822620
	// [XID] // 0x000000018966FA20-0x000000018966FA40
	public override void ClearView() {} // 0x0000000181822B10-0x0000000181822BF0
	// [XID] // 0x0000000189677340-0x0000000189677360
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181823F90-0x00000001818240F0
	// [XID] // 0x000000018967E8B0-0x000000018967E8D0
	public override void UpdateView() {} // 0x0000000181824650-0x0000000181824890
	// [XID] // 0x0000000189686160-0x0000000189686180
	private void DoClose() {} // 0x00000001818229B0-0x0000000181822B10
	// [XID] // 0x000000018968DF50-0x000000018968DF70
	private void SetupItem(MonoMPInvitationRow ins, ref ApplingGuestData playerData, bool skipFadeIn = false /* Metadata: 0x00B0F473 */) {} // 0x0000000181823990-0x0000000181823F00
	// [XID] // 0x00000001896958A0-0x00000001896958C0
	private void OnNoButtonClicked(MonoMPInvitationRow ins) {} // 0x0000000181822BF0-0x0000000181822DC0
	// [XID] // 0x000000018969CF30-0x000000018969CF50
	private void OnYesButtonClicked(MonoMPInvitationRow ins) {} // 0x00000001818222D0-0x0000000181822520
	// [XID] // 0x00000001896A4200-0x00000001896A4220
	private void UpdateItem(MonoMPInvitationRow ins, ApplingGuestData playerData) {} // 0x00000001818237D0-0x0000000181823930
	// [XID] // 0x00000001896AB7C0-0x00000001896AB7E0
	private void OnNewPlayerAppling(uint uid, uint type) {} // 0x0000000181822DC0-0x0000000181823070
	// [XID] // 0x00000001896B29F0-0x00000001896B2A10
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181823160-0x0000000181823710
	// [IDTag] // 0x00000001896BA180-0x00000001896BA1C0
	// [XID] // 0x00000001896BA180-0x00000001896BA1C0
	private void RefreshInvitItemSelectState(MonoReusableListItem item, int index) {} // 0x0000000181822620-0x0000000181822740
	// [IDTag] // 0x00000001896C4570-0x00000001896C45B0
	// [XID] // 0x00000001896C4570-0x00000001896C45B0
	private void RefreshInvitItemSelectState(MonoMPInvitationRow item, int index) {} // 0x0000000181822740-0x00000001818229B0
	// [XID] // 0x00000001896CEEB0-0x00000001896CEED0
	private void SetCurSelectIndex(int tarIndex, bool force) {} // 0x00000001818240F0-0x00000001818242E0
}

