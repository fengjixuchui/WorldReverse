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

public sealed class FleurFairDungeonEndDialogContext : BaseDialogContext // TypeDefIndex: 30063
{
	// Fields
	private MonoFleurFairDungeonEndDialog _dialogMono; // 0x178
	private FleurFairBossSettleInfo _bossSettleInfo; // 0x180
	private ActivityInfo _activityInfo; // 0x188
	private List<int> _playerInfoList; // 0x190
	private Dictionary<uint, int> _playerInfoDic; // 0x198
	private float _getPlayerSocialDetailTime; // 0x1A0
	private float _countDownTime; // 0x1A4
	private int _countDownSecond; // 0x1A8
	private bool _showCard; // 0x1AC
	private List<RewardItemConfig> _tempRewardList; // 0x1B0
	private const float SHOW_CARD_TIME = 5f; // Metadata: 0x00B107BC
	private const float SHOW_QUIT_TIME = 12f; // Metadata: 0x00B107C0

	// Constructors
	public FleurFairDungeonEndDialogContext() {} // Dummy constructor
	public FleurFairDungeonEndDialogContext(FleurFairBossSettleInfo info) {} // 0x000000018165DF00-0x000000018165DFE0

	// Methods
	// [XID] // 0x0000000189A903D0-0x0000000189A903F0
	public override void SetupView() {} // 0x000000018165DD70-0x000000018165DE50
	// [XID] // 0x0000000189A97BC0-0x0000000189A97BE0
	public override void ClearView() {} // 0x000000018165B930-0x000000018165BA40
	// [XID] // 0x0000000189A9EF90-0x0000000189A9EFB0
	protected override void BindViewCallbacks() {} // 0x000000018165B7A0-0x000000018165B930
	// [XID] // 0x0000000189AA68F0-0x0000000189AA6910
	public override bool OnNotify(Notify ntf) => default; // 0x000000018165DB80-0x000000018165DC80
	// [XID] // 0x0000000189AADF40-0x0000000189AADF60
	public override void UpdateView() {} // 0x000000018165DE50-0x000000018165DF00
	// [XID] // 0x0000000189AB58B0-0x0000000189AB58D0
	public void TickCountdown() {} // 0x000000018165CA50-0x000000018165CC40
	// [XID] // 0x0000000189ABD250-0x0000000189ABD270
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x000000018165D500-0x000000018165D5E0
	// [XID] // 0x0000000189AC4CC0-0x0000000189AC4CE0
	private void RefreshView() {} // 0x000000018165BD30-0x000000018165CA50
	// [XID] // 0x0000000189ACC340-0x0000000189ACC360
	private void PreparePlayerInfoList() {} // 0x000000018165D6D0-0x000000018165DB80
	// [XID] // 0x0000000189AD3E40-0x0000000189AD3E60
	private void RefreshCardItem(Transform trans, int index) {} // 0x000000018165CFD0-0x000000018165D500
	// [XID] // 0x0000000189ADB940-0x0000000189ADB960
	private void RefreshRewardItem(Transform trans, int index) {} // 0x000000018165BA40-0x000000018165BCD0
	// [XID] // 0x0000000189AE3220-0x0000000189AE3240
	private void OnNextButton() {} // 0x000000018165CCA0-0x000000018165CF70
	// [XID] // 0x0000000189AEAC10-0x0000000189AEAC30
	private void OnQuit() {} // 0x000000018165DC80-0x000000018165DD70
}

