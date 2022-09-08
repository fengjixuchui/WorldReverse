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

public sealed class HomeworldLevelPageContext : BasePageContext // TypeDefIndex: 30249
{
	// Fields
	private MonoHomeworldLevelPage _pageMono; // 0x190
	private HomeworldLevelExcelConfig _selectHomeworldLevelExcelConfig; // 0x198
	private List<RewardItemConfig> _tempRewardList; // 0x1A0
	private int _curLevelIndex; // 0x1A8
	private uint _lastStoreCoinNum; // 0x1AC

	// Constructors
	public HomeworldLevelPageContext() {} // 0x0000000182639F80-0x000000018263A040

	// Methods
	// [XID] // 0x0000000189972460-0x0000000189972480
	public override void SetupView() {} // 0x00000001826397C0-0x0000000182639F80
	// [XID] // 0x0000000189979C40-0x0000000189979C60
	private void SetupLevelRewardView() {} // 0x00000001826369D0-0x0000000182636BE0
	// [XID] // 0x0000000189981450-0x0000000189981470
	private void RefreshLevelItem(Transform trans, int index) {} // 0x00000001826387C0-0x0000000182638BF0
	// [XID] // 0x0000000189988C60-0x0000000189988C80
	private void OnLevelSlotInShowRange(Transform trans, float value) {} // 0x0000000182638150-0x0000000182638300
	// [XID] // 0x0000000189990420-0x0000000189990440
	private void OnClickLevelItem(int index) {} // 0x0000000182637C10-0x0000000182638150
	// [XID] // 0x0000000189997FF0-0x0000000189998010
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000182636BE0-0x0000000182636E30
	// [XID] // 0x000000018999F6D0-0x000000018999F6F0
	private void RefreshLevelFuncItem(Transform trans, int index) {} // 0x0000000182638300-0x00000001826387C0
	// [XID] // 0x00000001899A7250-0x00000001899A7270
	protected override void RegisterHandlePacket() {} // 0x0000000182639700-0x00000001826397C0
	// [XID] // 0x00000001899AEB80-0x00000001899AEBA0
	public override bool OnPacket(Packet pkt) => default; // 0x0000000182639440-0x0000000182639560
	// [XID] // 0x00000001899B5F00-0x00000001899B5F20
	private void CheckSetRedPoint() {} // 0x0000000182635C70-0x0000000182635E30
	// [XID] // 0x00000001899BDC00-0x00000001899BDC20
	private void OnHomeResourceTakeHomeCoinRsp(HomeResourceTakeHomeCoinRsp rsp) {} // 0x0000000182637170-0x0000000182637380
	// [XID] // 0x00000001899C5380-0x00000001899C53A0
	private void OnGetHomeLevelUpRewardRsp(GetHomeLevelUpRewardRsp rsp) {} // 0x0000000182637410-0x0000000182637540
	// [XID] // 0x00000001899CCA10-0x00000001899CCA30
	private void RefreshCoinView() {} // 0x0000000182637880-0x0000000182637B80
	// [XID] // 0x00000001899D4090-0x00000001899D40B0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182639320-0x0000000182639440
	// [XID] // 0x00000001899DB620-0x00000001899DB640
	private void OnItemAddedNotify(List<SimpleItemStruct> itemList) {} // 0x0000000182636790-0x0000000182636880
	// [XID] // 0x00000001899E2D40-0x00000001899E2D60
	public override void ClearView() {} // 0x0000000182636920-0x00000001826369D0
	// [XID] // 0x00000001899EA490-0x00000001899EA4B0
	protected override void BindViewCallbacks() {} // 0x0000000182636370-0x0000000182636790
	// [XID] // 0x00000001899F1E20-0x00000001899F1E40
	private void OnBtnReturnClick() {} // 0x0000000182637540-0x00000001826375F0
	// [XID] // 0x00000001899F9620-0x00000001899F9640
	private void OnBtnDescriptionClick() {} // 0x0000000182638BF0-0x0000000182638D00
	// [XID] // 0x0000000189A00940-0x0000000189A00960
	private void OnBtnComfortTipsClick() {} // 0x0000000182637060-0x0000000182637170
	// [XID] // 0x0000000189A08260-0x0000000189A08280
	private void OnBtnHomeCUClick() {} // 0x0000000182639560-0x0000000182639700
	// [XID] // 0x0000000189A0F6C0-0x0000000189A0F6E0
	private void OnBtnLevelRewardClick() {} // 0x0000000182636E30-0x0000000182636EF0
	// [XID] // 0x0000000189A16D00-0x0000000189A16D20
	private void OnBtnBack_LevelRewardClick() {} // 0x0000000182636EF0-0x0000000182636FC0
	// [XID] // 0x0000000189A1E380-0x0000000189A1E3A0
	private void OnBtnFetch_LevelRewardClick() {} // 0x0000000182639190-0x0000000182639290
	// [XID] // 0x0000000189A25A60-0x0000000189A25A80
	private void OnBtnItemDetail_LevelRewardClick() {} // 0x0000000182636880-0x0000000182636920
	// [XID] // 0x0000000189A2CEC0-0x0000000189A2CEE0
	private void OnShopMaterialsItemClick() {} // 0x00000001826375F0-0x00000001826376C0
	// [XID] // 0x0000000189A34890-0x0000000189A348B0
	private void OnBtnHomeCUClick2() {} // 0x0000000182636FC0-0x0000000182637060
	// [XID] // 0x0000000189A3BCB0-0x0000000189A3BCD0
	private int GetHomeCoinNum() => default; // 0x0000000182636230-0x0000000182636370
	// [XID] // 0x0000000189A43940-0x0000000189A43960
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182637720-0x0000000182637820
	// [XID] // 0x0000000189A4AD70-0x0000000189A4AD90
	private bool HandleInputActionEventLevelMain(InputActionEvent actionEvent) => default; // 0x0000000182638D00-0x0000000182639130
	// [XID] // 0x0000000189A52490-0x0000000189A524B0
	private bool HandleInputActionEventLevelReward(InputActionEvent actionEvent) => default; // 0x0000000182635E90-0x00000001826361B0
}

