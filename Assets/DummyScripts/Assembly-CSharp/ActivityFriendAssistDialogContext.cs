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

public class ActivityFriendAssistDialogContext : BaseDialogContext // TypeDefIndex: 30057
{
	// Fields
	protected MonoFriendAssistDialog _dialogMono; // 0x178
	protected List<AssistAvatarData> _showAvatarList; // 0x180
	protected uint _maxAvatarNum; // 0x188
	protected uint _friendUid; // 0x18C
	protected uint _friendAvatarId; // 0x190
	protected int _selectedIndex; // 0x194
	protected List<AssistAvatarData> _selectedAvatarList; // 0x198

	// Nested types
	protected struct AssistAvatarData // TypeDefIndex: 30058
	{
		// Fields
		public uint friendUid; // 0x00
		public uint avatarUid; // 0x04
		public uint level; // 0x08
	}

	// Constructors
	public ActivityFriendAssistDialogContext() {} // 0x0000000181AA5D20-0x0000000181AA5DC0
	public ActivityFriendAssistDialogContext(uint maxAvatarNum) {} // 0x0000000181AA5C30-0x0000000181AA5D20

	// Methods
	// [XID] // 0x000000018988B410-0x000000018988B430
	protected void SetBasicConfig() {} // 0x0000000181AA4DE0-0x0000000181AA4EC0
	// [XID] // 0x0000000189892B50-0x0000000189892B70
	protected override void BindViewCallbacks() {} // 0x0000000181AA37C0-0x0000000181AA3980
	// [XID] // 0x000000018989A1D0-0x000000018989A1F0
	public override void SetupView() {} // 0x0000000181AA5B30-0x0000000181AA5C30
	// [XID] // 0x00000001898A1490-0x00000001898A14B0
	public override void ClearView() {} // 0x0000000181AA3FA0-0x0000000181AA40B0
	// [XID] // 0x00000001898A8D00-0x00000001898A8D20
	protected void Refresh(bool setup = false /* Metadata: 0x00B107B6 */) {} // 0x0000000181AA3230-0x0000000181AA3340
	// [XID] // 0x00000001898B0680-0x00000001898B06A0
	private void AutoSelectFirst() {} // 0x0000000181AA5060-0x0000000181AA51A0
	// [XID] // 0x00000001898B7C90-0x00000001898B7CB0
	private void RefreshAvatarGridScroller() {} // 0x0000000181AA49A0-0x0000000181AA4D80
	// [XID] // 0x00000001898BF280-0x00000001898BF2A0
	private void FilterFriendAvatars() {} // 0x0000000181AA3A50-0x0000000181AA3FA0
	// [XID] // 0x00000001898C6C20-0x00000001898C6C40
	private void RefreshAvatar(Transform trans, int index) {} // 0x0000000181AA4380-0x0000000181AA4670
	// [XID] // 0x00000001898CE1E0-0x00000001898CE200
	private void OnAvatarClick(int index) {} // 0x0000000181AA34D0-0x0000000181AA3590
	// [XID] // 0x00000001898D5C30-0x00000001898D5C50
	private void ShowAvatar(int index) {} // 0x0000000181AA5850-0x0000000181AA5B30
	// [XID] // 0x00000001898DD920-0x00000001898DD940
	private void OnHandleClickAvatar(int index) {} // 0x0000000181AA5460-0x0000000181AA5560
	// [XID] // 0x00000001898E51B0-0x00000001898E51D0
	protected bool IsSelected(int index) => default; // 0x0000000181AA3340-0x0000000181AA3400
	// [XID] // 0x00000001898EC9A0-0x00000001898EC9C0
	protected int GetSelectedIndex(int index) => default; // 0x0000000181AA51A0-0x0000000181AA5360
	// [XID] // 0x00000001898F4390-0x00000001898F43B0
	private void AddSelect(int index) {} // 0x0000000181AA47F0-0x0000000181AA4940
	// [XID] // 0x00000001898FBB60-0x00000001898FBB80
	private void UnSelect(int index) {} // 0x0000000181AA3590-0x0000000181AA37C0
	// [XID] // 0x0000000189903590-0x00000001899035B0
	protected void RefreshMarkNo() {} // 0x0000000181AA3400-0x0000000181AA34D0
	// [XID] // 0x000000018990AAE0-0x000000018990AB00
	private MonoAvatarIcon GetAvatarIcon(int index) => default; // 0x0000000181AA5720-0x0000000181AA5850
	// [XID] // 0x0000000189912770-0x0000000189912790
	protected virtual void OnConfirm() {} // 0x0000000181AA4670-0x0000000181AA4750
	// [XID] // 0x000000018991A060-0x000000018991A080
	protected void OnCancel() {} // 0x0000000181AA42D0-0x0000000181AA4380
	// [XID] // 0x00000001899218A0-0x00000001899218C0
	protected virtual int CompareSort(AssistAvatarData a, AssistAvatarData b) => default; // 0x0000000181AA4F60-0x0000000181AA5060
	// [XID] // 0x0000000189928FC0-0x0000000189928FE0
	protected virtual bool IsFriendAvatarOccupied(uint friendUid, uint avatarUid) => default; // 0x0000000181AA3980-0x0000000181AA3A50
	// [XID] // 0x0000000189930510-0x0000000189930530
	protected virtual void OnSelect(int gridIndex, AssistAvatarData avatarData) {} // 0x0000000181AA5650-0x0000000181AA5720
	// [XID] // 0x00000001899379E0-0x0000000189937A00
	protected virtual void OnUnSelect(int gridIndex, AssistAvatarData avatarData) {} // 0x0000000181AA4160-0x0000000181AA4230
	// [XID] // 0x000000018993F4B0-0x000000018993F4D0
	protected virtual void OnDoConfirm() {} // 0x0000000181AA5360-0x0000000181AA5400
	// [XID] // 0x0000000189946A80-0x0000000189946AA0
	protected virtual void OnSetupView() {} // 0x0000000181AA4750-0x0000000181AA47F0
	// [XID] // 0x000000018994E140-0x000000018994E160
	protected virtual void OnClearView() {} // 0x0000000181AA4EC0-0x0000000181AA4F60
	// [XID] // 0x0000000189955760-0x0000000189955780
	protected virtual void OnRefresh(bool setup = false /* Metadata: 0x00B107B7 */) {} // 0x0000000181AA40B0-0x0000000181AA4160
	// [XID] // 0x000000018995D280-0x000000018995D2A0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B107B8 */) {} // 0x0000000181AA5560-0x0000000181AA5650
	// [XID] // 0x0000000189964930-0x0000000189964950
	private void SetBtnOKText(int index) {} // 0x0000000181AA30D0-0x0000000181AA3230
}

