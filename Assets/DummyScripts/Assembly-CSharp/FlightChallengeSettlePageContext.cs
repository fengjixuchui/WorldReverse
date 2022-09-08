/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FlightChallengeSettlePageContext : BasePageContext // TypeDefIndex: 29089
{
	// Fields
	private MonoActivityFlightChallengeSettle _dialogMono; // 0x190
	private uint _curScheduleId; // 0x198
	private uint _curGroupId; // 0x19C
	private FlightActivitySettleNotify _settleNotify; // 0x1A0
	private WaitForSeconds _waitLeftTime; // 0x1A8
	private WaitForSeconds _waitCollect; // 0x1B0

	// Constructors
	public FlightChallengeSettlePageContext() {} // Dummy constructor
	public FlightChallengeSettlePageContext(FlightActivitySettleNotify flightSettleNotify) {} // 0x0000000181293D20-0x0000000181293E10

	// Methods
	// [XID] // 0x0000000189952C80-0x0000000189952CA0
	public override void SetupView() {} // 0x0000000181293BC0-0x0000000181293D20
	// [XID] // 0x000000018995A230-0x000000018995A250
	protected override void BindViewCallbacks() {} // 0x00000001812929E0-0x0000000181292B40
	// [XID] // 0x0000000189961C60-0x0000000189961C80
	private void RefreshView() {} // 0x00000001812932B0-0x0000000181293750
	// [XID] // 0x00000001899692F0-0x0000000189969310
	private void RefreshCountText(int leftMSec) {} // 0x00000001812927C0-0x00000001812929E0
	// [XID] // 0x0000000189970DB0-0x0000000189970DD0
	private void RefreshCollectText(int collectNum, uint totalNum) {} // 0x0000000181292EE0-0x00000001812930E0
	// [XID] // 0x00000001899786F0-0x0000000189978710
	private void OnAbandonBtnClick() {} // 0x0000000181293870-0x0000000181293920
	// [XID] // 0x000000018997F7F0-0x000000018997F810
	private void OnTryAgainBtnClick() {} // 0x0000000181293920-0x0000000181293A20
	// [XID] // 0x00000001899871A0-0x00000001899871C0
	public void OnScoreEventBegin() {} // 0x0000000181293A20-0x0000000181293B60
	// [XID] // 0x000000018998EC30-0x000000018998EC50
	public void OnCollectEventBegin() {} // 0x0000000181292D10-0x0000000181292E80
	[DebuggerHidden] // 0x00000001899967F0-0x0000000189996830
	// [XID] // 0x00000001899967F0-0x0000000189996830
	private IEnumerator ShowLeftTime(uint leftMSec) => default; // 0x0000000181293750-0x0000000181293870
	[DebuggerHidden] // 0x00000001899A11A0-0x00000001899A11E0
	// [XID] // 0x00000001899A11A0-0x00000001899A11E0
	private IEnumerator ShowCollect(uint CollectNum, uint maxNum) => default; // 0x0000000181292BD0-0x0000000181292D10
	// [XID] // 0x00000001899ABD80-0x00000001899ABDA0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001812930E0-0x00000001812932B0
}

