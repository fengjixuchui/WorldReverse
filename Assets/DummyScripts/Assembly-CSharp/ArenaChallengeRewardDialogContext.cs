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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengeRewardDialogContext : BaseDialogContext // TypeDefIndex: 30104
{
	// Fields
	private MonoArenaChallengeRewardDialog _pageMono; // 0x178
	private ActivityInfo _activityInfo; // 0x180
	private Dictionary<uint, ActivityWatcherInfo> _watcherInfoDic; // 0x188
	private Dictionary<uint, List<ActivityArenaChallengeExcelConfig>> _arenaWatcherDic; // 0x190
	private Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> _arenaLevelInfoDic; // 0x198
	private List<MonoArenaChallengeRewardListRow> _monoRewardListRowList; // 0x1A0
	private int _currMonoRewardListRowIndex; // 0x1A8
	private int _firstRewardIndex; // 0x1AC

	// Constructors
	public ArenaChallengeRewardDialogContext() {} // 0x0000000181740C00-0x0000000181740CF0

	// Methods
	// [XID] // 0x0000000189BBA9E0-0x0000000189BBAA00
	public override void SetupView() {} // 0x00000001817406B0-0x0000000181740C00
	// [XID] // 0x0000000189BC2A00-0x0000000189BC2A20
	public override void ClearView() {} // 0x000000018173ED30-0x000000018173EDE0
	// [XID] // 0x0000000189BCA1C0-0x0000000189BCA1E0
	private void Refresh() {} // 0x000000018173E510-0x000000018173E5B0
	// [XID] // 0x0000000189BD1810-0x0000000189BD1830
	private void RefreshLevelList() {} // 0x000000018173F770-0x00000001817400A0
	// [XID] // 0x0000000189BD8DE0-0x0000000189BD8E00
	protected override void BindViewCallbacks() {} // 0x000000018173E6D0-0x000000018173E7F0
	// [XID] // 0x00000001895E59E0-0x00000001895E5A00
	private void OnFetchButton(uint activityId, uint watcherId) {} // 0x000000018173E5B0-0x000000018173E6D0
	// [XID] // 0x00000001895ED310-0x00000001895ED330
	private void OnBtnCloseClick() {} // 0x000000018173EDE0-0x000000018173EE90
	// [XID] // 0x00000001895F49D0-0x00000001895F49F0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001817404B0-0x00000001817406B0
	// [XID] // 0x00000001895FC120-0x00000001895FC140
	private void OnTakeWatcherRewardUpdateNotify(Notify ntf) {} // 0x0000000181740190-0x00000001817404B0
	// [XID] // 0x0000000189603B20-0x0000000189603B40
	private List<SimpleItemStruct> CreateSimpleItemStructListByRewardId(uint rewardId) => default; // 0x000000018173F570-0x000000018173F770
	// [XID] // 0x000000018960B480-0x000000018960B4A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018173F220-0x000000018173F510
	// [XID] // 0x0000000189612850-0x0000000189612870
	private void ToNextListRow(bool prev) {} // 0x000000018173E7F0-0x000000018173EAC0
	// [XID] // 0x000000018961A1E0-0x000000018961A200
	private void OnJoyPadFetchBtn() {} // 0x000000018173EF70-0x000000018173F1C0
	// [XID] // 0x00000001896216F0-0x0000000189621710
	private void RefreshPS4Btn() {} // 0x000000018173EAC0-0x000000018173ED30
}

