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

public sealed class HomeworldVisitorDialogContext : BaseDialogContext // TypeDefIndex: 29158
{
	// Fields
	private MonoHomeworldVisitorDialog _dialogMono; // 0x178
	private List<uint> _visitorList; // 0x180
	private static List<string> _settingOptions; // 0x00
	private EditMenuTarget _target; // 0x188
	private RectTransform _restrictRect; // 0x190

	// Constructors
	public HomeworldVisitorDialogContext() {} // 0x0000000183182D80-0x0000000183182E70
	static HomeworldVisitorDialogContext() {} // 0x0000000183182D20-0x0000000183182D80

	// Methods
	// [XID] // 0x000000018982BCE0-0x000000018982BD00
	public override void SetupView() {} // 0x0000000183182BF0-0x0000000183182D20
	// [XID] // 0x0000000189833270-0x0000000189833290
	public override void ClearView() {} // 0x0000000183180F10-0x0000000183180FB0
	// [XID] // 0x000000018983A720-0x000000018983A740
	protected override void BindViewCallbacks() {} // 0x0000000183180DB0-0x0000000183180F10
	// [XID] // 0x0000000189841D20-0x0000000189841D40
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183182780-0x00000001831828A0
	// [XID] // 0x0000000189849230-0x0000000189849250
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183181700-0x0000000183181AD0
	// [XID] // 0x00000001898509F0-0x0000000189850A10
	private bool HandleDropdownInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183180FB0-0x00000001831810E0
	// [XID] // 0x0000000189857D80-0x0000000189857DA0
	private void RefreshView() {} // 0x0000000183181AD0-0x0000000183181FA0
	// [XID] // 0x000000018985EE70-0x000000018985EE90
	private void SetupDropdown() {} // 0x00000001831828A0-0x0000000183182BF0
	// [XID] // 0x0000000189866670-0x0000000189866690
	private void RefreshVisitorList(Transform trans, int index) {} // 0x00000001831810E0-0x0000000183181500
	// [XID] // 0x000000018986DF70-0x000000018986DF90
	private void OnIconBtnClick(uint uid, EditMenuTarget target, MonoGridScroller scroller) {} // 0x0000000183182210-0x0000000183182360
	// [XID] // 0x0000000189875340-0x0000000189875360
	private void OnKickBtnClick(uint uid) {} // 0x0000000183182000-0x0000000183182210
	// [XID] // 0x000000018987CEF0-0x000000018987CF10
	private void OnAllowJoinChanged(int value) {} // 0x0000000183180CC0-0x0000000183180DB0
	// [XID] // 0x0000000189883EB0-0x0000000189883ED0
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x0000000183182460-0x0000000183182580
	// [XID] // 0x000000018988B550-0x000000018988B570
	private void ShowDropdown() {} // 0x00000001831825E0-0x00000001831826F0
	// [XID] // 0x0000000189892D10-0x0000000189892D30
	private void OnDropdownSelectConfirm() {} // 0x0000000183182360-0x0000000183182460
	// [XID] // 0x000000018989A3B0-0x000000018989A3D0
	private void MoveSortDropdownIndex(bool prevOrNext) {} // 0x00000001831815F0-0x0000000183181700
}

