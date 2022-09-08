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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonSettleDialogContext : BaseDialogContext // TypeDefIndex: 29005
{
	// Fields
	private DungeonSettleNotify _ntf; // 0x178
	private MonoDungeonSettleDialog _dialogMono; // 0x180
	private DungeonExcelConfig _dungeonConfig; // 0x188
	private uint _closeTime; // 0x190
	private bool actived; // 0x194
	private bool isTrial; // 0x195
	private const ulong EXIT_TIME = 3; // Metadata: 0x00B0E912
	private FinishType finishType; // 0x198
	private bool arenaChallengeFinishShowed; // 0x19C
	private float remainingTime; // 0x1A0

	// Nested types
	public enum FinishType // TypeDefIndex: 29006
	{
		Regular = 0,
		ArenaChallengeSpecialFail = 1
	}

	// Constructors
	public DungeonSettleDialogContext() {} // Dummy constructor
	public DungeonSettleDialogContext(FinishType finishType, object ntf) {} // 0x0000000180F16170-0x0000000180F162D0

	// Methods
	// [XID] // 0x00000001896459B0-0x00000001896459D0
	protected override void OnEnable() {} // 0x0000000180F15130-0x0000000180F15280
	// [XID] // 0x000000018964D1C0-0x000000018964D1E0
	public override void SetupView() {} // 0x0000000180F15E60-0x0000000180F15F30
	// [XID] // 0x0000000189654960-0x0000000189654980
	public override void UpdateView() {} // 0x0000000180F15F30-0x0000000180F16170
	// [XID] // 0x000000018965C050-0x000000018965C070
	public override void ClearView() {} // 0x0000000180F13DC0-0x0000000180F13F60
	// [XID] // 0x0000000189663710-0x0000000189663730
	public override bool OnNotify(Notify ntf) => default; // 0x0000000180F15280-0x0000000180F15380
	// [XID] // 0x000000018966B050-0x000000018966B070
	private void DungeonSettleDialogContext_Regular(DungeonSettleNotify ntf) {} // 0x0000000180F14080-0x0000000180F14150
	// [XID] // 0x0000000189672C50-0x0000000189672C70
	private void SetupRegularDungeonFinish() {} // 0x0000000180F154F0-0x0000000180F15E60
	// [XID] // 0x000000018967A350-0x000000018967A370
	private void OnDungeonGetReward(GadgetAutoPickDropInfoNotify body) {} // 0x0000000180F15380-0x0000000180F15440
	// [XID] // 0x0000000189681BA0-0x0000000189681BC0
	private void SetSettleItem(UnityEngine.UI.Text label, SettleShowType type, ParamList param) {} // 0x0000000180F14330-0x0000000180F14850
	// [XID] // 0x0000000189689630-0x0000000189689650
	private void HideSettleHint() {} // 0x0000000180F14D80-0x0000000180F150A0
	[DebuggerHidden] // 0x0000000189691250-0x0000000189691290
	// [XID] // 0x0000000189691250-0x0000000189691290
	private IEnumerator HideSettleHintRoutine() => default; // 0x0000000180F14C70-0x0000000180F14D80
	// [XID] // 0x000000018969B610-0x000000018969B630
	private void DungeonSettleDialogContext_Arena(ArenaChallengeFinishNotify ntf) {} // 0x0000000180F15440-0x0000000180F154F0
	// [XID] // 0x00000001896A2D70-0x00000001896A2D90
	private void SetupArenaChallengeSpecialFail() {} // 0x0000000180F14850-0x0000000180F14C70
	// [XID] // 0x00000001896AA240-0x00000001896AA260
	private void ShowArenaChallengeFinish() {} // 0x0000000180F141B0-0x0000000180F14330
}

