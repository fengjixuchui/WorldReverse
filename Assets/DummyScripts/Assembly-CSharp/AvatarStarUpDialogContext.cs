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

public sealed class AvatarStarUpDialogContext : BaseDialogContext // TypeDefIndex: 28822
{
	// Fields
	private MonoAvatarStarUpDialog _dialogMono; // 0x178
	private AvatarDataItem _avatarData; // 0x180
	private uint _currBreakLevel; // 0x188
	private uint _currLevel; // 0x18C
	private uint _currMaxLevel; // 0x190
	private uint _postMaxLevel; // 0x194
	private AvatarPromoteExcelConfig _currBreakConfig; // 0x198
	private AvatarPromoteExcelConfig _postBreakConfig; // 0x1A0
	private List<PropertyChange> _propertyChangeList; // 0x1A8
	private List<uint> _unlockSkillGroupList; // 0x1B0

	// Constructors
	public AvatarStarUpDialogContext() {} // Dummy constructor
	public AvatarStarUpDialogContext(AvatarDataItem avatarData) {} // 0x0000000183435620-0x0000000183435750

	// Methods
	// [XID] // 0x000000018985EF50-0x000000018985EF70
	public override void SetupView() {} // 0x0000000183435550-0x0000000183435620
	// [XID] // 0x0000000189866710-0x0000000189866730
	protected override void BindViewCallbacks() {} // 0x0000000183434890-0x0000000183434B30
	// [XID] // 0x000000018986DFD0-0x000000018986DFF0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001834351D0-0x0000000183435420
	// [XID] // 0x0000000189875400-0x0000000189875420
	private void Refresh() {} // 0x0000000183434000-0x0000000183434890
	// [XID] // 0x000000018987CF70-0x000000018987CF90
	private void RequestBreakThrough() {} // 0x0000000183434D20-0x00000001834350E0
	// [XID] // 0x0000000189883F10-0x0000000189883F30
	private void GotoLevelUp() {} // 0x0000000183435420-0x0000000183435550
	// [XID] // 0x000000018988B5F0-0x000000018988B610
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183434C20-0x0000000183434D20
}

