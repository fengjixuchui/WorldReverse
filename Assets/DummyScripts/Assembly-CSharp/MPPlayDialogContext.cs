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

public sealed class MPPlayDialogContext : BaseDialogContext // TypeDefIndex: 28955
{
	// Fields
	private MonoMPPlayDialog _dialogMono; // 0x178
	private List<OnlinePlayerData> _playerData; // 0x180
	private uint _playId; // 0x188
	private MPPlayDialogType _type; // 0x18C
	private PlayType _playType; // 0x190
	private float _currTime; // 0x194
	private float _responseTime; // 0x198
	private bool _isRemainReward; // 0x19C
	private bool _useServerTime; // 0x19D
	private uint _startTimeStamp; // 0x1A0

	// Nested types
	public enum MPPlayDialogType // TypeDefIndex: 28956
	{
		HOST = 0,
		GUEST = 1
	}

	public enum PlayType // TypeDefIndex: 28957
	{
		MPPlay = 0,
		Dungeon = 1,
		Draft = 2,
		DraftTwiceConfirm = 3,
		Match = 4
	}

	// Constructors
	public MPPlayDialogContext() {} // Dummy constructor
	public MPPlayDialogContext(uint playId, MPPlayDialogType type, float responseTime, bool isRemainReward = false /* Metadata: 0x00B0E8B9 */, PlayType playType = PlayType.MPPlay /* Metadata: 0x00B0E8BA */, uint startTimeStamp = 0 /* Metadata: 0x00B0E8BE */) {} // 0x0000000182CCB1F0-0x0000000182CCB370

	// Methods
	// [XID] // 0x00000001898B1EB0-0x00000001898B1ED0
	public override void SetupView() {} // 0x0000000182CCA9A0-0x0000000182CCAFF0
	// [XID] // 0x00000001898B9B30-0x00000001898B9B50
	public override void UpdateView() {} // 0x0000000182CCAFF0-0x0000000182CCB1F0
	// [XID] // 0x00000001898C0F30-0x00000001898C0F50
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182CCA2E0-0x0000000182CCA4A0
	// [XID] // 0x00000001898C8870-0x00000001898C8890
	protected override void BindViewCallbacks() {} // 0x0000000182CC7B20-0x0000000182CC7C80
	// [XID] // 0x00000001898D0200-0x00000001898D0220
	private void SetupContext() {} // 0x0000000182CC8660-0x0000000182CC9550
	// [XID] // 0x00000001898D77D0-0x00000001898D77F0
	private void SetupApplyButtonState(bool active, bool canReject = true /* Metadata: 0x00B0E8C2 */) {} // 0x0000000182CC7C80-0x0000000182CC7E30
	// [XID] // 0x00000001898DF520-0x00000001898DF540
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x0000000182CC74F0-0x0000000182CC7A70
	// [XID] // 0x00000001898E6F00-0x00000001898E6F20
	private void OnAcceptBtnClick() {} // 0x0000000182CC9BF0-0x0000000182CC9CB0
	// [XID] // 0x00000001898EE6D0-0x00000001898EE6F0
	private void OnAcceptBtnClickBigWorld() {} // 0x0000000182CC9930-0x0000000182CC9B50
	// [XID] // 0x00000001898F5E60-0x00000001898F5E80
	private void OnAcceptBtnClickBigWorldDungeon() {} // 0x0000000182CC9B50-0x0000000182CC9BF0
	// [XID] // 0x00000001898FD6A0-0x00000001898FD6C0
	private void OnAcceptBtnClickMatch() {} // 0x0000000182CC7EC0-0x0000000182CC8110
	// [XID] // 0x0000000189904F60-0x0000000189904F80
	private void OnRejectBtnClick() {} // 0x0000000182CC9890-0x0000000182CC9930
	// [XID] // 0x000000018990C760-0x000000018990C780
	private void ReplayForInvite(bool isAgree) {} // 0x0000000182CC8370-0x0000000182CC8660
	// [XID] // 0x0000000189914010-0x0000000189914030
	private void SetSelfAnimator(bool accept) {} // 0x0000000182CC95B0-0x0000000182CC9890
	// [XID] // 0x000000018991BA60-0x000000018991BA80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182CC8170-0x0000000182CC8370
	// [XID] // 0x0000000189922FE0-0x0000000189923000
	private void RefreshPlayGuestState(uint uid) {} // 0x0000000182CC9CB0-0x0000000182CCA1F0
	// [XID] // 0x000000018992A7D0-0x000000018992A7F0
	private void ShowInviteResult() {} // 0x0000000182CCA4A0-0x0000000182CCA9A0
}

