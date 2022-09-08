/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OfferingModule : BaseModule // TypeDefIndex: 21639
{
	// Fields
	private RepeatedMessageField<PlayerOfferingData> _allOfferingStatusList; // 0x10

	// Constructors
	public OfferingModule() {} // 0x00000001820AEAD0-0x00000001820AEB80

	// Methods
	// [XID] // 0x0000000189AA53E0-0x0000000189AA5400
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001820ACF30-0x00000001820AD020
	// [XID] // 0x0000000189AACC40-0x0000000189AACC60
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001820AE350-0x00000001820AE400
	// [XID] // 0x0000000189AB44D0-0x0000000189AB44F0
	private void CheckLoadData() {} // 0x00000001820AD1E0-0x00000001820AD2B0
	// [XID] // 0x0000000189ABC1A0-0x0000000189ABC1C0
	public List<RewardExcelConfig> GetRewards(uint offeringSystemId) => default; // 0x00000001820ACB00-0x00000001820ACD30
	// [XID] // 0x0000000189AC3A80-0x0000000189AC3AA0
	public RewardExcelConfig GetOfferingLevelReward(uint offeringSystemId, uint level) => default; // 0x00000001820ADD80-0x00000001820ADFA0
	// [XID] // 0x0000000189ACAF20-0x0000000189ACAF40
	public List<IdCountConfig> GetOfferingLevelConsume(uint offeringSystemId, uint level) => default; // 0x00000001820AE000-0x00000001820AE230
	// [XID] // 0x0000000189AD2A40-0x0000000189AD2A60
	public OfferingLevelUpExcelConfig GetOfferingLevelUpExcelConfig(uint offeringSystemId, uint level) => default; // 0x00000001820AE4A0-0x00000001820AE6A0
	// [XID] // 0x0000000189ADA400-0x0000000189ADA420
	public PlayerOfferingData GetOfferingData(uint offeringSystemId) => default; // 0x00000001820AC930-0x00000001820ACB00
	// [XID] // 0x0000000189AE1D10-0x0000000189AE1D30
	public uint GetCurrentOfferingLevel(uint offeringSystemId) => default; // 0x00000001820AD6B0-0x00000001820AD880
	// [XID] // 0x0000000189AE95B0-0x0000000189AE95D0
	public bool IsGotLevelReward(uint offeringSystemId, uint level) => default; // 0x00000001820AD020-0x00000001820AD120
	// [XID] // 0x0000000189AF1350-0x0000000189AF1370
	public bool HasLevelRewardWaitingGet(uint offeringSystemId) => default; // 0x00000001820ADC80-0x00000001820ADD80
	// [XID] // 0x0000000189AF8910-0x0000000189AF8930
	public void DoOffering(uint offeringSystemId) {} // 0x00000001820AD330-0x00000001820AD430
	// [XID] // 0x0000000189AFFE70-0x0000000189AFFE90
	public void FetchOfferingLevelReward(uint offeringSystemId, uint level) {} // 0x00000001820AE230-0x00000001820AE350
	// [XID] // 0x0000000189B07450-0x0000000189B07470
	public RewardState GetOfferingLevelRewardState(uint offeringSystemId, uint level) => default; // 0x00000001820AE9D0-0x00000001820AEAD0
	// [XID] // 0x0000000189B0EC10-0x0000000189B0EC30
	public override bool OnPacket(Packet packet) => default; // 0x00000001820ACD30-0x00000001820ACE90
	// [XID] // 0x0000000189B15FD0-0x0000000189B15FF0
	private void OnPlayerOfferingDataNotify(PlayerOfferingDataNotify notify) {} // 0x00000001820AD880-0x00000001820AD960
	// [XID] // 0x0000000189B1D650-0x0000000189B1D670
	private void OnPlayerOfferingRsp(PlayerOfferingRsp rsp) {} // 0x00000001820AE6A0-0x00000001820AE9D0
	// [XID] // 0x0000000189B25040-0x0000000189B25060
	private void OnTakeOfferingLevelRewardRsp(TakeOfferingLevelRewardRsp rsp) {} // 0x00000001820AD430-0x00000001820AD6B0
	// [XID] // 0x0000000189B2C4D0-0x0000000189B2C4F0
	private void ShowItemList(RepeatedMessageField<ItemParam> itemParams) {} // 0x00000001820AD9E0-0x00000001820ADC80
	// [XID] // 0x0000000189B33A00-0x0000000189B33A20
	public override void ClearOnDisconnect() {} // 0x00000001820AE400-0x00000001820AE4A0
	// [XID] // 0x0000000189B3B310-0x0000000189B3B330
	public override void ClearOnLevelDestroy() {} // 0x00000001820ACE90-0x00000001820ACF30
	// [XID] // 0x0000000189B42B50-0x0000000189B42B70
	public override void ClearOnBackHome() {} // 0x00000001820AD120-0x00000001820AD1E0
}

