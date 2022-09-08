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

public sealed class BPShopPageContext : BasePageContext // TypeDefIndex: 28858
{
	// Fields
	private MonoBPShopPage _pageMono; // 0x190
	private List<uint> _tempItemList; // 0x198
	private List<RewardItemConfig> _tempRewardList; // 0x1A0
	private int _selectRewardItemIndex; // 0x1A8
	private bool _disableTotalPrice; // 0x1AC
	private RegionType _currRegion; // 0x1B0

	// Nested types
	private enum RegionType // TypeDefIndex: 28859
	{
		RewardLeft = 0,
		RewardRight = 1
	}

	// Constructors
	public BPShopPageContext() {} // 0x00000001827B9250-0x00000001827B9320

	// Methods
	// [XID] // 0x000000018976B190-0x000000018976B1B0
	public override void SetupView() {} // 0x00000001827B90B0-0x00000001827B9250
	// [XID] // 0x00000001897727E0-0x0000000189772800
	public override void ClearView() {} // 0x00000001827B6770-0x00000001827B6850
	// [XID] // 0x0000000189779E10-0x0000000189779E30
	protected override void BindViewCallbacks() {} // 0x00000001827B6350-0x00000001827B6470
	// [XID] // 0x0000000189781A70-0x0000000189781A90
	public override bool OnNotify(Notify ntf) => default; // 0x00000001827B8D70-0x00000001827B8FA0
	// [XID] // 0x0000000189788F70-0x0000000189788F90
	private void RefreshShopItemView() {} // 0x00000001827B7120-0x00000001827B7DD0
	// [XID] // 0x0000000189790560-0x0000000189790580
	private string GetProductPriceText(string productId) => default; // 0x00000001827B6B20-0x00000001827B6C10
	// [XID] // 0x0000000189797F50-0x0000000189797F70
	private int GetProductPrice(string productId) => default; // 0x00000001827B6850-0x00000001827B6940
	// [XID] // 0x000000018979FC70-0x000000018979FC90
	private void RefreshRewardItems(Transform trans, int index) {} // 0x00000001827B6940-0x00000001827B6A90
	// [XID] // 0x00000001897A71F0-0x00000001897A7210
	private void RefreshNormalShowItems(Transform trans, int index) {} // 0x00000001827B60D0-0x00000001827B61F0
	// [XID] // 0x00000001897AEBA0-0x00000001897AEBC0
	private void BuyNormalBPReward() {} // 0x00000001827B8900-0x00000001827B8A30
	// [XID] // 0x00000001897B6A30-0x00000001897B6A50
	private void BuyExtraBPReward() {} // 0x00000001827B6C10-0x00000001827B6DA0
	// [XID] // 0x00000001897BE870-0x00000001897BE890
	private void OnBattlePassProductPayNotify(Notify ntf) {} // 0x00000001827B8050-0x00000001827B8300
	// [XID] // 0x00000001897C5F60-0x00000001897C5F80
	private void OnBattlePassBuySuccessNotify(BattlePassBuySuccNotify ntf) {} // 0x00000001827B6DA0-0x00000001827B7120
	// [XID] // 0x00000001897CD760-0x00000001897CD780
	private void CloseAndShowBPUnlockAnim() {} // 0x00000001827B8530-0x00000001827B8630
	// [XID] // 0x00000001897D4CE0-0x00000001897D4D00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001827B7E30-0x00000001827B7FF0
	// [XID] // 0x00000001897DC420-0x00000001897DC440
	private void MoveSelectRewardToIndex(int index) {} // 0x00000001827B8630-0x00000001827B8900
	// [XID] // 0x00000001897E3D90-0x00000001897E3DB0
	private void MoveToRegion(RegionType toRegion) {} // 0x00000001827B6470-0x00000001827B6770
	// [XID] // 0x00000001897EB960-0x00000001897EB980
	private void ShowRewardItemDetail() {} // 0x00000001827B8300-0x00000001827B8530
	// [XID] // 0x00000001897F3260-0x00000001897F3280
	private void BuyBPProduct() {} // 0x00000001827B8BC0-0x00000001827B8C80
	// [XID] // 0x00000001897FAAD0-0x00000001897FAAF0
	private MonoSimpleReusableList GetScrollerByRegionType(RegionType region) => default; // 0x00000001827B8FA0-0x00000001827B90B0
	// [XID] // 0x0000000189802080-0x00000001898020A0
	private void CheckHavePrice() {} // 0x00000001827B8A30-0x00000001827B8BC0
	// [XID] // 0x0000000189809510-0x0000000189809530
	private void OnSDKGetProductListResponse(bool success) {} // 0x00000001827B61F0-0x00000001827B6350
}

