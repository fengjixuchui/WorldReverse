/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySubPage_Crucible : BaseSubPageContext // TypeDefIndex: 29385
{
	// Fields
	private MonoActivityCrucible _pageMono; // 0x178
	private uint questID; // 0x180
	private int _selectedAssistIndex; // 0x184
	private uint _activityID; // 0x188
	private ActivityInfo activityInfo; // 0x190
	private MessagePushPageContext _pushPage; // 0x198

	// Constructors
	public ActivitySubPage_Crucible() {} // Dummy constructor
	public ActivitySubPage_Crucible(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000182B7A580-0x0000000182B7A690

	// Methods
	// [XID] // 0x00000001897B0260-0x00000001897B0280
	protected override void BindViewCallbacks() {} // 0x0000000182B78410-0x0000000182B784B0
	// [XID] // 0x00000001897B7F90-0x00000001897B7FB0
	public override void SetupView() {} // 0x0000000182B7A2F0-0x0000000182B7A580
	// [XID] // 0x00000001897C00B0-0x00000001897C00D0
	private void Refresh() {} // 0x0000000182B77110-0x0000000182B78390
	// [XID] // 0x00000001897C78E0-0x00000001897C7900
	private void OnClickReward() {} // 0x0000000182B79690-0x0000000182B797A0
	// [XID] // 0x00000001897CEB80-0x00000001897CEBA0
	private void OnClickTask() {} // 0x0000000182B78540-0x0000000182B786A0
	// [XID] // 0x00000001897D62C0-0x00000001897D62E0
	private void OnClickDescription() {} // 0x0000000182B79560-0x0000000182B79690
	// [XID] // 0x00000001897DDBA0-0x00000001897DDBC0
	private void OnClickGoto() {} // 0x0000000182B792E0-0x0000000182B79560
	// [XID] // 0x00000001897E5490-0x00000001897E54B0
	private void OnClickST() {} // 0x0000000182B79190-0x0000000182B792E0
	// [XID] // 0x00000001897ED030-0x00000001897ED050
	private void SetTipsText() {} // 0x0000000182B79DD0-0x0000000182B79EC0
	// [XID] // 0x00000001897F4850-0x00000001897F4870
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182B7A090-0x0000000182B7A1E0
	// [XID] // 0x00000001897FC310-0x00000001897FC330
	private void RefreshActivity(uint activityId) {} // 0x0000000182B7A1E0-0x0000000182B7A2F0
	// [XID] // 0x0000000189803790-0x00000001898037B0
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x0000000182B79EC0-0x0000000182B79FA0
	// [XID] // 0x000000018980AD40-0x000000018980AD60
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182B78970-0x0000000182B79190
	// [XID] // 0x00000001898122F0-0x0000000189812310
	public void SelectNextAssistAvatar(bool next) {} // 0x0000000182B786A0-0x0000000182B78910
	// [XID] // 0x0000000189819EC0-0x0000000189819EE0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000182B797A0-0x0000000182B79DD0
}

