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

public sealed class ArenaChallengeFinishDialogContext : BaseDialogContext // TypeDefIndex: 30099
{
	// Fields
	private MonoArenaChallengeFinishDialog _dialogMono; // 0x178
	private ArenaChallengeFinishNotify _finishInfo; // 0x180
	private ActivityArenaChallengeExcelConfig _config; // 0x188
	private Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> _arenaLevelConfigDic; // 0x190
	private Dictionary<uint, List<ActivityArenaChallengeExcelConfig>> _arenaWatcherConfigDic; // 0x198
	private Dictionary<uint, ActivityWatcherInfo> _arenaWatcherInfoDic; // 0x1A0
	private const int WAITTIME = 13; // Metadata: 0x00B107E5
	private long _autoQuitLimit; // 0x1A8
	private bool _isCoundDown; // 0x1B0

	// Constructors
	public ArenaChallengeFinishDialogContext() {} // 0x0000000183C3CCF0-0x0000000183C3CFA0

	// Methods
	// [XID] // 0x0000000189934B10-0x0000000189934B30
	public override void SetupView() {} // 0x0000000183C3C820-0x0000000183C3CB20
	// [XID] // 0x000000018993C5E0-0x000000018993C600
	public override void UpdateView() {} // 0x0000000183C3CB20-0x0000000183C3CCF0
	// [XID] // 0x0000000189943C50-0x0000000189943C70
	public override void ClearView() {} // 0x0000000183C3B070-0x0000000183C3B110
	// [XID] // 0x000000018994B150-0x000000018994B170
	private void Refresh() {} // 0x0000000183C3AE10-0x0000000183C3AED0
	// [XID] // 0x0000000189952B80-0x0000000189952BA0
	private void RefreshTitleAndRewardTips() {} // 0x0000000183C3B110-0x0000000183C3B4C0
	// [XID] // 0x000000018995A0B0-0x000000018995A0D0
	private void RefreshBtn() {} // 0x0000000183C3B4C0-0x0000000183C3B7D0
	// [XID] // 0x0000000189961AC0-0x0000000189961AE0
	private void SetCondDesc() {} // 0x0000000183C3BF40-0x0000000183C3C7C0
	// [XID] // 0x0000000189969190-0x00000001899691B0
	protected override void BindViewCallbacks() {} // 0x0000000183C3AED0-0x0000000183C3B070
	// [XID] // 0x0000000189970C50-0x0000000189970C70
	private void OnBtnAgain() {} // 0x0000000183C3BAA0-0x0000000183C3BDC0
	// [XID] // 0x00000001899785B0-0x00000001899785D0
	private void RequestStartChallengeLevel() {} // 0x0000000183C3BDC0-0x0000000183C3BF40
	// [XID] // 0x000000018997F6B0-0x000000018997F6D0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183C3B8C0-0x0000000183C3B9E0
}

