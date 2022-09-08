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

public sealed class DungeonInvitationDialogContext : BaseDialogContext // TypeDefIndex: 28941
{
	// Fields
	private MonoMPInvitationListDialog _dialogMono; // 0x178
	private Dictionary<uint, MonoMPInvitationRow> _uid2row; // 0x180
	private int _curSelectIndex; // 0x188

	// Constructors
	public DungeonInvitationDialogContext() {} // 0x0000000181F90630-0x0000000181F90710

	// Methods
	// [XID] // 0x0000000189BA79C0-0x0000000189BA79E0
	public override void SetupView() {} // 0x0000000181F901A0-0x0000000181F90320
	// [XID] // 0x0000000189BAED50-0x0000000189BAED70
	private void Refresh() {} // 0x0000000181F8EA60-0x0000000181F8EEC0
	// [XID] // 0x0000000189BB6440-0x0000000189BB6460
	private void RefreshPlayerState(MonoMPInvitationRow ins, uint uid) {} // 0x0000000181F8E780-0x0000000181F8EA60
	// [XID] // 0x0000000189BBDA80-0x0000000189BBDAA0
	protected override void BindViewCallbacks() {} // 0x0000000181F8EFB0-0x0000000181F8F0B0
	// [XID] // 0x0000000189BC5780-0x0000000189BC57A0
	public override void UpdateView() {} // 0x0000000181F90320-0x0000000181F90630
	// [XID] // 0x0000000189BCD1E0-0x0000000189BCD200
	public override void ClearView() {} // 0x0000000181F8F580-0x0000000181F8F660
	// [XID] // 0x0000000189BD46E0-0x0000000189BD4700
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181F8FD50-0x0000000181F8FFB0
	// [XID] // 0x0000000189BDC250-0x0000000189BDC270
	private void OnDungeonInviteRefused(uint uid) {} // 0x0000000181F8EEC0-0x0000000181F8EFB0
	// [XID] // 0x00000001895E8A70-0x00000001895E8A90
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181F8F750-0x0000000181F8FBA0
	// [IDTag] // 0x00000001895F02E0-0x00000001895F0320
	// [XID] // 0x00000001895F02E0-0x00000001895F0320
	private void RefreshInvitItemSelectState(MonoReusableListItem item, int index) {} // 0x0000000181F8F0B0-0x0000000181F8F1D0
	// [IDTag] // 0x00000001895FA9A0-0x00000001895FA9E0
	// [XID] // 0x00000001895FA9A0-0x00000001895FA9E0
	private void RefreshInvitItemSelectState(MonoMPInvitationRow item, int index) {} // 0x0000000181F8F1D0-0x0000000181F8F580
	// [XID] // 0x0000000189605080-0x00000001896050A0
	private void SetCurSelectIndex(int tarIndex, bool force) {} // 0x0000000181F8FFB0-0x0000000181F901A0
}

