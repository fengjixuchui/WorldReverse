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

public sealed class FriendEditDialogContext : BaseDialogContext // TypeDefIndex: 29102
{
	// Fields
	private MonoFriendEditDialog _dialogMono; // 0x178
	private SocialDetailStruct _socialDetail; // 0x180
	private FriendInformationDialogType _forceType; // 0x1F0
	private FriendInformationDialogType _type; // 0x1F4
	private EditMenuTarget _target; // 0x1F8
	private RectTransform _restrictRect; // 0x200
	private MPRequestState _currHomeworldRequestState; // 0x208
	private int _applyCooldown; // 0x20C

	// Nested types
	private enum CornerType // TypeDefIndex: 29103
	{
		Left = 0,
		LeftUp = 1,
		Up = 2,
		RightUp = 3,
		Right = 4,
		RightDown = 5,
		Down = 6,
		LeftDown = 7
	}

	// Constructors
	public FriendEditDialogContext() {} // Dummy constructor
	public FriendEditDialogContext(SocialDetailStruct socialDetail, FriendInformationDialogType forceType = FriendInformationDialogType.NONE /* Metadata: 0x00B0EB90 */, EditMenuTarget target = null, RectTransform restrictRect = null) {} // 0x0000000183EA6CE0-0x0000000183EA6E20

	// Methods
	// [XID] // 0x0000000189772760-0x0000000189772780
	public override void SetupView() {} // 0x0000000183EA69E0-0x0000000183EA6C40
	// [XID] // 0x0000000189779DB0-0x0000000189779DD0
	public override void ClearView() {} // 0x0000000183EA4820-0x0000000183EA48F0
	// [XID] // 0x00000001897819F0-0x0000000189781A10
	public override void UpdateView() {} // 0x0000000183EA6C40-0x0000000183EA6CE0
	// [XID] // 0x0000000189788EF0-0x0000000189788F10
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EB94 */) {} // 0x0000000183EA6720-0x0000000183EA6940
	// [XID] // 0x00000001897904E0-0x0000000189790500
	public override void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EB98 */) {} // 0x0000000183EA64F0-0x0000000183EA6720
	// [XID] // 0x0000000189797ED0-0x0000000189797EF0
	private void SutupPanel() {} // 0x0000000183EA5040-0x0000000183EA5290
	// [XID] // 0x000000018979FBB0-0x000000018979FBD0
	private void SetupPanelPosition() {} // 0x0000000183EA3670-0x0000000183EA3CD0
	// [XID] // 0x00000001897A7170-0x00000001897A7190
	private Vector3 GetCornerOffset(Vector3[] corners, CornerType type) => default; // 0x0000000183EA3E00-0x0000000183EA4250
	// [XID] // 0x00000001897AEB20-0x00000001897AEB40
	protected override void BindViewCallbacks() {} // 0x0000000183EA43E0-0x0000000183EA4750
	// [XID] // 0x00000001897B69B0-0x00000001897B69D0
	private void Check() {} // 0x0000000183EA49A0-0x0000000183EA4B70
	// [XID] // 0x00000001897BE7F0-0x00000001897BE810
	private void AddFriend() {} // 0x0000000183EA5DD0-0x0000000183EA5EC0
	// [XID] // 0x00000001897C5F00-0x00000001897C5F20
	private void EnterHomeworld() {} // 0x0000000183EA5AD0-0x0000000183EA5BB0
	// [XID] // 0x00000001897CD6E0-0x00000001897CD700
	private void UpdateEnterHomeworldBtn() {} // 0x0000000183EA4C10-0x0000000183EA4F30
	// [XID] // 0x00000001897D4C60-0x00000001897D4C80
	private void RefreshEnterHomeworldBtn(MPRequestState state, bool initial = false /* Metadata: 0x00B0EB9C */) {} // 0x0000000183EA5420-0x0000000183EA59B0
	// [XID] // 0x00000001897DC380-0x00000001897DC3A0
	private void AddRemark() {} // 0x0000000183EA3CD0-0x0000000183EA3E00
	// [XID] // 0x00000001897E3CD0-0x00000001897E3CF0
	private void BlockChat() {} // 0x0000000183EA4F30-0x0000000183EA5040
	// [XID] // 0x00000001897EB900-0x00000001897EB920
	private void RemoveFriend() {} // 0x0000000183EA61B0-0x0000000183EA62A0
	// [XID] // 0x00000001897F31E0-0x00000001897F3200
	private void AddBlackList() {} // 0x0000000183EA48F0-0x0000000183EA49A0
	// [XID] // 0x00000001897FAA50-0x00000001897FAA70
	private void Report() {} // 0x0000000183EA5BB0-0x0000000183EA5CE0
	// [XID] // 0x0000000189802020-0x0000000189802040
	private void AddInBlockChatList() {} // 0x0000000183EA5290-0x0000000183EA5420
	// [XID] // 0x0000000189809490-0x00000001898094B0
	private void RemoveFromBlockChatList() {} // 0x0000000183EA5EC0-0x0000000183EA6150
	// [XID] // 0x0000000189810CA0-0x0000000189810CC0
	private void AddInBlacklist() {} // 0x0000000183EA4250-0x0000000183EA43E0
	// [XID] // 0x0000000189818750-0x0000000189818770
	private void RemoveFromBlacklist() {} // 0x0000000183EA5CE0-0x0000000183EA5DD0
}

