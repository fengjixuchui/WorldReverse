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

internal sealed class CrucibleEndPageContext : BasePageContext // TypeDefIndex: 28904
{
	// Fields
	private MonoCrucibleEndPage _pageMono; // 0x190
	private bool _isWin; // 0x198
	private float _countDownTime; // 0x19C
	private int _countDownSecond; // 0x1A0
	private bool _checkLoadingFinish; // 0x1A4
	private bool _waitLoadingFinish; // 0x1A5
	private float _extraWaitTime; // 0x1A8
	private bool _canClose; // 0x1AC
	private uint _playId; // 0x1B0
	private uint _costTime; // 0x1B4
	private float _getPlayerSocialDetailTime; // 0x1B8
	private List<SettlePlayerInfo> _settlePlayerInfoList; // 0x1C0
	private Dictionary<uint, List<SettlePlayerInfo>> _settlePlayerInfoDict; // 0x1C8

	// Properties
	private bool canClosePage { /* [XID] */ /* 0x0000000189B0EA50-0x0000000189B0EA70 */ get => default; } // 0x0000000184790C90-0x0000000184790D50 

	// Nested types
	private struct SettlePlayerInfo // TypeDefIndex: 28905
	{
		// Fields
		public uint Uid; // 0x00
		public uint StatisticId; // 0x04
		public long Param; // 0x08
		public uint HeadImage; // 0x10
		public string Nickname; // 0x18
		public string OnlineId; // 0x20
	}

	// Constructors
	public CrucibleEndPageContext() {} // Dummy constructor
	public CrucibleEndPageContext(bool isWin, uint playId, uint costTime) {} // 0x0000000184793760-0x0000000184793870

	// Methods
	// [XID] // 0x0000000189B15DE0-0x0000000189B15E00
	public override void SetupView() {} // 0x0000000184792A50-0x00000001847936B0
	// [XID] // 0x0000000189B1D510-0x0000000189B1D530
	public void SetCheckLoadingFlag() {} // 0x0000000184790E10-0x0000000184790EC0
	// [XID] // 0x0000000189B24DB0-0x0000000189B24DD0
	public override void UpdateView() {} // 0x00000001847936B0-0x0000000184793760
	// [XID] // 0x0000000189B2C260-0x0000000189B2C280
	public void TickCountdown() {} // 0x0000000184791440-0x00000001847917B0
	// [XID] // 0x0000000189B337F0-0x0000000189B33810
	private void RefreshCardItem(Transform trans, int index) {} // 0x0000000184791870-0x0000000184791DA0
	// [XID] // 0x0000000189B3B0F0-0x0000000189B3B110
	private void PreHandlePlayerInfo() {} // 0x00000001847905E0-0x0000000184790930
	// [XID] // 0x0000000189B42910-0x0000000189B42930
	private void RemoveDuplicate(ScenePlayBattleSettlePlayerInfo playerInfo) {} // 0x000000018478FF50-0x00000001847901B0
	// [XID] // 0x0000000189B4A430-0x0000000189B4A450
	private bool CheckDuplicate(List<SettlePlayerInfo> playerInfoList, ScenePlayBattleSettlePlayerInfo playerInfo) => default; // 0x0000000184790930-0x0000000184790C00
	// [XID] // 0x0000000189B51BD0-0x0000000189B51BF0
	private void GetRandomPlayInfo() {} // 0x00000001847923B0-0x0000000184792750
	// [XID] // 0x0000000189B593D0-0x0000000189B593F0
	private void RefreshDragonSpineCardItem(Transform trans, int index) {} // 0x0000000184791DA0-0x00000001847923B0
	// [XID] // 0x0000000189B60C60-0x0000000189B60C80
	public override bool OnNotify(Notify ntf) => default; // 0x0000000184792920-0x0000000184792A50
	// [XID] // 0x0000000189B68350-0x0000000189B68370
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x0000000184792750-0x0000000184792830
	// [XID] // 0x0000000189B6F650-0x0000000189B6F670
	public void TryClosePage() {} // 0x0000000184790350-0x0000000184790410
	// [XID] // 0x0000000189B76CD0-0x0000000189B76CF0
	public override void ClosePage() {} // 0x00000001847901B0-0x0000000184790250
	// [XID] // 0x0000000189B7E260-0x0000000189B7E280
	public override void ClearView() {} // 0x0000000184790410-0x00000001847905E0
	// [XID] // 0x0000000189B85E60-0x0000000189B85E80
	protected override void BindViewCallbacks() {} // 0x0000000184790250-0x0000000184790350
	// [XID] // 0x0000000189B8CE90-0x0000000189B8CEB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184790EC0-0x0000000184791440
}

