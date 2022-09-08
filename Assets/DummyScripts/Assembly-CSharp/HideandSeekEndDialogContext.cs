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

public sealed class HideandSeekEndDialogContext : BaseDialogContext // TypeDefIndex: 30108
{
	// Fields
	private MonoHideandSeekEndDialog _dialogMono; // 0x178
	private HideAndSeekSettleNotify _ntf; // 0x180
	private float _getPlayerSocialDetailTime; // 0x188
	private float _countDownTime; // 0x18C
	private int _countDownSecond; // 0x190
	private bool _showCard; // 0x194
	private const float SHOW_CARD_TIME = 10f; // Metadata: 0x00B107E9
	private const float SHOW_QUIT_TIME = 20f; // Metadata: 0x00B107ED
	private const string fmtStr = "{0}"; // Metadata: 0x00B107F1

	// Constructors
	public HideandSeekEndDialogContext() {} // Dummy constructor
	public HideandSeekEndDialogContext(HideAndSeekSettleNotify ntf) {} // 0x00000001815B91E0-0x00000001815B92B0

	// Methods
	// [XID] // 0x0000000189703FB0-0x0000000189703FD0
	public override void SetupView() {} // 0x00000001815B9050-0x00000001815B9130
	// [XID] // 0x000000018970B8A0-0x000000018970B8C0
	public override void ClearView() {} // 0x00000001815B6E60-0x00000001815B6F10
	// [XID] // 0x0000000189713130-0x0000000189713150
	protected override void BindViewCallbacks() {} // 0x00000001815B6CD0-0x00000001815B6E60
	// [XID] // 0x000000018971A950-0x000000018971A970
	public override bool OnNotify(Notify ntf) => default; // 0x00000001815B8E90-0x00000001815B8FA0
	// [XID] // 0x0000000189721CB0-0x0000000189721CD0
	private void CheckClose() {} // 0x00000001815B8CF0-0x00000001815B8E00
	// [XID] // 0x0000000189729300-0x0000000189729320
	public override void UpdateView() {} // 0x00000001815B9130-0x00000001815B91E0
	// [XID] // 0x0000000189730B60-0x0000000189730B80
	public void TickCountdown() {} // 0x00000001815B7D70-0x00000001815B7F60
	// [XID] // 0x0000000189738490-0x00000001897384B0
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x00000001815B8BB0-0x00000001815B8C90
	// [XID] // 0x00000001897401D0-0x00000001897401F0
	private void RefreshView() {} // 0x00000001815B72B0-0x00000001815B7D70
	// [XID] // 0x00000001897475A0-0x00000001897475C0
	private void RefreshCardItem(Transform trans, int index) {} // 0x00000001815B8270-0x00000001815B8BB0
	// [XID] // 0x000000018974ECF0-0x000000018974ED10
	private void RefreshScoreItem(Transform trans, int index) {} // 0x00000001815B6F70-0x00000001815B72B0
	// [XID] // 0x0000000189756400-0x0000000189756420
	private void OnNextButton() {} // 0x00000001815B7FC0-0x00000001815B8210
	// [XID] // 0x000000018975D7E0-0x000000018975D800
	private void OnQuit() {} // 0x00000001815B8FA0-0x00000001815B9050
}

