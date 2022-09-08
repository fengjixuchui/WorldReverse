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

public sealed class WidgetSystemModule : BaseModule // TypeDefIndex: 21632
{
	// Fields
	private List<WidgetSlotBackUpData> _backupSlotList; // 0x10
	private Dictionary<uint, List<uint>> _gadgetId2EntityId; // 0x18
	private Dictionary<uint, PacketAnchor> _packetAnchorDict; // 0x20
	private BagItemSlot _curHpMaterial; // 0x28
	private BagItemSlot _curReviveMaterial; // 0x30
	private uint _curHpMaterialId; // 0x38
	private uint _curReviveMaterialId; // 0x3C
	private Dictionary<uint, uint> _clientCollectorDict; // 0x40
	private Dictionary<uint, SeverDetectorData> _hintToData; // 0x48
	private Coroutine _openMapPageCoroutine; // 0x50
	private Coroutine _adeptiAbodeCoroutine; // 0x58

	// Properties
	public Dictionary<uint, PacketAnchor> packetAnchorDict { /* [XID] */ /* 0x000000018967BEE0-0x000000018967BF00 */ get => default; } // 0x00000001839E0050-0x00000001839E00F0 
	public int currentActivePacketAnchorNum { /* [XID] */ /* 0x00000001896834D0-0x00000001896834F0 */ get => default; } // 0x00000001839DD170-0x00000001839DD230 
	public BagItemSlot curHpMaterial { /* [XID] */ /* 0x00000001896DAD20-0x00000001896DAD40 */ get => default; /* [XID] */ /* 0x0000000189B19FE0-0x0000000189B1A000 */ set {} } // 0x00000001839E03C0-0x00000001839E0460 0x00000001839DADA0-0x00000001839DAE80
	public BagItemSlot curReviveMaterial { /* [XID] */ /* 0x00000001896E9920-0x00000001896E9940 */ get => default; /* [XID] */ /* 0x00000001896F0B20-0x00000001896F0B40 */ set {} } // 0x00000001839E2730-0x00000001839E27D0 0x00000001839E00F0-0x00000001839E01D0
	public uint curHpMaterialId { /* [XID] */ /* 0x00000001896F83A0-0x00000001896F83C0 */ get => default; } // 0x00000001839DF880-0x00000001839DF920 
	public uint curReviveMaterialId { /* [XID] */ /* 0x00000001896FFD20-0x00000001896FFD40 */ get => default; } // 0x00000001839DF7E0-0x00000001839DF880 
	public Dictionary<uint, uint> clientCollectorDict { /* [XID] */ /* 0x000000018971DB00-0x000000018971DB20 */ get => default; } // 0x00000001839DE620-0x00000001839DE6C0 

	// Nested types
	public struct WidgetSlotBackUpData // TypeDefIndex: 21633
	{
		// Fields
		public WidgetSlotTag tag; // 0x00
		public uint materialId; // 0x04
		public WidgetSlotOp operation; // 0x08
	}

	public class PacketAnchor // TypeDefIndex: 21634
	{
		// Fields
		public Vector3 pos; // 0x10
		public ulong dismissTime; // 0x20

		// Constructors
		public PacketAnchor() {} // 0x0000000183A8EEE0-0x0000000183A8EF40
	}

	public enum LunchBoxType // TypeDefIndex: 21635
	{
		None = 0,
		Hp = 1,
		Revive = 2
	}

	public class SeverDetectorData // TypeDefIndex: 21636
	{
		// Fields
		public uint materialId; // 0x10
		public Vector3 hintCenterPosition; // 0x14
		public uint hintRadius; // 0x20
		public uint groupId; // 0x24
		public uint mapInstId; // 0x28

		// Constructors
		public SeverDetectorData() {} // 0x0000000183AAF040-0x0000000183AAF0A0
	}

	// Constructors
	public WidgetSystemModule() {} // 0x00000001839E3CD0-0x00000001839E3EC0

	// Methods
	// [XID] // 0x0000000189B61FF0-0x0000000189B62010
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001839DC3A0-0x00000001839DC5D0
	// [XID] // 0x0000000189B69C30-0x0000000189B69C50
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001839E2C70-0x00000001839E2DC0
	// [XID] // 0x0000000189B37980-0x0000000189B379A0
	public LCWidget GetCurrentTeamEntityLcWidget() => default; // 0x00000001839E1AA0-0x00000001839E1BD0
	// [XID] // 0x0000000189B78840-0x0000000189B78860
	public override void ClearOnLevelDestroy() {} // 0x00000001839DBF70-0x00000001839DC0A0
	// [XID] // 0x0000000189B7FDB0-0x0000000189B7FDD0
	public override void ClearOnDisconnect() {} // 0x00000001839E2DC0-0x00000001839E2EF0
	// [XID] // 0x0000000189B87880-0x0000000189B878A0
	public override void ClearOnBackHome() {} // 0x00000001839DE4D0-0x00000001839DE620
	// [XID] // 0x0000000189B8E9C0-0x0000000189B8E9E0
	public override bool OnPacket(Packet packet) => default; // 0x00000001839DB120-0x00000001839DB580
	// [XID] // 0x0000000189B95E60-0x0000000189B95E80
	public override bool OnNotify(Notify ntf) => default; // 0x00000001839E3660-0x00000001839E37C0
	// [XID] // 0x0000000189B9D400-0x0000000189B9D420
	public void RequestBagAttachSlot(uint materialId, WidgetSlotOp op, List<WidgetSlotTag> tags) {} // 0x00000001839DDBE0-0x00000001839DDE50
	// [XID] // 0x0000000189BA4E10-0x0000000189BA4E30
	private void OnSetWidgetSlotRsp(SetWidgetSlotRsp rsp) {} // 0x00000001839DD320-0x00000001839DD6E0
	// [XID] // 0x0000000189BABFF0-0x0000000189BAC010
	public void RequestActionPanel(Vector3? pos = default, bool usePosition = false /* Metadata: 0x00AFFABC */) {} // 0x00000001839E3100-0x00000001839E33C0
	// [XID] // 0x0000000189BB37F0-0x0000000189BB3810
	private void OnQuickUseWidgetRsp(QuickUseWidgetRsp rsp) {} // 0x00000001839DCAC0-0x00000001839DCD20
	// [XID] // 0x0000000189BBAD80-0x0000000189BBADA0
	public void RequestWidgetReport(uint materialId, bool isClearHint, bool isWindSeed) {} // 0x00000001839DCD20-0x00000001839DCEB0
	// [XID] // 0x0000000189BC2D70-0x0000000189BC2D90
	private void OnAllWidgetDataNotify(AllWidgetDataNotify ntf) {} // 0x00000001839E0790-0x00000001839E0B00
	// [XID] // 0x0000000189BCA4D0-0x0000000189BCA4F0
	public void RequestSlotData() {} // 0x00000001839E3BC0-0x00000001839E3CD0
	// [XID] // 0x0000000189BD1B40-0x0000000189BD1B60
	private void OnGetWidgetSlotRsp(GetWidgetSlotRsp rsp) {} // 0x00000001839DFAB0-0x00000001839DFD00
	// [XID] // 0x0000000189BD9110-0x0000000189BD9130
	private void OnWidgetCoolDownNotify(WidgetCoolDownNotify ntf) {} // 0x00000001839E0C70-0x00000001839E0E00
	// [XID] // 0x00000001895E5CF0-0x00000001895E5D10
	private void OnWidgetReportRsp(WidgetReportRsp rsp) {} // 0x00000001839E2220-0x00000001839E2300
	// [XID] // 0x00000001895ED6B0-0x00000001895ED6D0
	private void SetSlot(WidgetSlotData slotData, WidgetSlotOp op) {} // 0x00000001839E2EF0-0x00000001839E3100
	// [XID] // 0x00000001895F4C80-0x00000001895F4CA0
	public void FetchBackupData(out List<WidgetSlotBackUpData> backUpList) {
		backUpList = default;
	} // 0x00000001839DD7B0-0x00000001839DD890
	// [XID] // 0x00000001895FC430-0x00000001895FC450
	private void OnWidgetSlotChangeNotify(WidgetSlotChangeNotify ntf) {} // 0x00000001839DAB40-0x00000001839DAC30
	// [XID] // 0x0000000189603E30-0x0000000189603E50
	public NotifyTypes ConvertToNotify(WidgetEventType type) => default; // 0x00000001839DBCD0-0x00000001839DBD90
	// [XID] // 0x000000018960B710-0x000000018960B730
	public List<uint> GetWidgetGadgetEntityList(uint gadgetId) => default; // 0x00000001839DD230-0x00000001839DD320
	// [XID] // 0x0000000189612BA0-0x0000000189612BC0
	public uint GetCurrentWidgetGadgetNumInScene(uint gadgetId) => default; // 0x00000001839E0F60-0x00000001839E1070
	// [XID] // 0x000000018961A460-0x000000018961A480
	public void RequestCreateSeverGadget(uint materialId, Vector3 pos, Vector3 rot) {} // 0x00000001839E37C0-0x00000001839E3AA0
	// [XID] // 0x00000001896219E0-0x0000000189621A00
	private void OnUseWidgetCreateGadgetRsp(UseWidgetCreateGadgetRsp rsp) {} // 0x00000001839E0E00-0x00000001839E0F60
	// [XID] // 0x00000001896292F0-0x0000000189629310
	public void RequestDestroySeverGadgetAllEntity(uint gadgetId) {} // 0x00000001839E1430-0x00000001839E16A0
	// [XID] // 0x0000000189630C40-0x0000000189630C60
	private void OnUseWidgetRetractGadgetRsp(UseWidgetRetractGadgetRsp rsp) {} // 0x00000001839DAC30-0x00000001839DADA0
	// [XID] // 0x00000001896386C0-0x00000001896386E0
	private void OnWidgetGadgetAllDataNotify(WidgetGadgetAllDataNotify ntf) {} // 0x00000001839E2930-0x00000001839E2C70
	// [XID] // 0x000000018963FB30-0x000000018963FB50
	private void OnWidgetGadgetDataNotify(WidgetGadgetDataNotify ntf) {} // 0x00000001839DFD00-0x00000001839E0050
	// [XID] // 0x0000000189647310-0x0000000189647330
	private void OnWidgetGadgetDestroyNotify(WidgetGadgetDestroyNotify ntf) {} // 0x00000001839DD6E0-0x00000001839DD7B0
	// [XID] // 0x000000018964EA00-0x000000018964EA20
	private void OnGadgetEntityDestroyInternal(uint entityId) {} // 0x00000001839DD930-0x00000001839DDBE0
	// [XID] // 0x00000001896562D0-0x00000001896562F0
	public void OnStoreItemChange(StoreItemChangeNotify ntf) {} // 0x00000001839DE6C0-0x00000001839DE980
	// [XID] // 0x000000018965D9F0-0x000000018965DA10
	public void OnStoreItemDel(StoreItemDelNotify ntf) {} // 0x00000001839DAE80-0x00000001839DB0A0
	// [XID] // 0x0000000189665100-0x0000000189665120
	public void RequestToUseBonfire(Vector3 pos, Vector3 rot) {} // 0x00000001839DCEB0-0x00000001839DD170
	// [XID] // 0x000000018966C7A0-0x000000018966C7C0
	private void OnUseBonfireWidgetRsp(UseBonfireWidgetRsp rsp) {} // 0x00000001839DF440-0x00000001839DF690
	// [XID] // 0x00000001896745B0-0x00000001896745D0
	private void SetBonfireCD(uint nextUsableTime) {} // 0x00000001839DECB0-0x00000001839DEF30
	// [XID] // 0x000000018968B090-0x000000018968B0B0
	public int GetCurrentActivePacketAnchorNum() => default; // 0x00000001839DDE50-0x00000001839DDF10
	// [XID] // 0x0000000189692D90-0x0000000189692DB0
	public Dictionary<uint, PacketAnchor> GetCurrentAllPacketAnchor() => default; // 0x00000001839DD890-0x00000001839DD930
	// [XID] // 0x000000018969A050-0x000000018969A070
	public void RequestToDeletePacketAnchor(uint anchorId) {} // 0x00000001839DF690-0x00000001839DF7E0
	// [XID] // 0x00000001896A1840-0x00000001896A1860
	public void RequestToAddPacketAnchor() {} // 0x00000001839E16A0-0x00000001839E17B0
	// [IDTag] // 0x00000001896A8CE0-0x00000001896A8D20
	// [XID] // 0x00000001896A8CE0-0x00000001896A8D20
	private void OnAnchorPointDataNotify(AnchorPointDataNotify ntf) {} // 0x00000001839DE3E0-0x00000001839DE4D0
	// [IDTag] // 0x00000001896B2C70-0x00000001896B2CB0
	// [XID] // 0x00000001896B2C70-0x00000001896B2CB0
	private void OnAnchorPointDataNotify(RepeatedMessageField<AnchorPointData> anchorList, uint nextUsableTime) {} // 0x00000001839DDF10-0x00000001839DE3E0
	// [XID] // 0x00000001896BD320-0x00000001896BD340
	private void OnAnchorPointOpRsp(AnchorPointOpRsp rsp) {} // 0x00000001839E1070-0x00000001839E1270
	// [XID] // 0x00000001896C4820-0x00000001896C4840
	public void UsePacketAnchor(uint anchorId) {} // 0x00000001839E2300-0x00000001839E2450
	// [XID] // 0x00000001896CBDF0-0x00000001896CBE10
	public void OnAllAnchorDataNotify(RepeatedMessageField<AnchorPointData> list) {} // 0x00000001839E17B0-0x00000001839E1AA0
	// [XID] // 0x00000001896D3140-0x00000001896D3160
	private void OnUseAnchorPointWidgetRsp(UseAnchorPointWidgetRsp rsp) {} // 0x00000001839E27D0-0x00000001839E2930
	// [XID] // 0x0000000189707420-0x0000000189707440
	public void RequestSetLunchBox(LunchBoxType type, uint materialId) {} // 0x00000001839E1D60-0x00000001839E2100
	// [XID] // 0x000000018970ECC0-0x000000018970ECE0
	private void OnSetUpLunchBoxWidgetRsp(SetUpLunchBoxWidgetRsp rsp) {} // 0x00000001839E01D0-0x00000001839E0340
	// [XID] // 0x00000001897160C0-0x00000001897160E0
	private void OnSetLunchBoxSuccess(LunchBoxData lunchBoxData) {} // 0x00000001839DC0A0-0x00000001839DC3A0
	// [IDTag] // 0x0000000189724F60-0x0000000189724FA0
	// [XID] // 0x0000000189724F60-0x0000000189724FA0
	private void OnClientCollectorDataNotify(ClientCollectorDataNotify ntf) {} // 0x00000001839DF250-0x00000001839DF330
	// [IDTag] // 0x000000018972F710-0x000000018972F750
	// [XID] // 0x000000018972F710-0x000000018972F750
	private void OnClientCollectorDataNotify(RepeatedMessageField<ClientCollectorData> dataList) {} // 0x00000001839DF330-0x00000001839DF440
	// [XID] // 0x0000000189739DE0-0x0000000189739E00
	private void RefreshClientCollectorDataFromSever(ClientCollectorData data) {} // 0x00000001839E1BD0-0x00000001839E1D60
	// [XID] // 0x0000000189741900-0x0000000189741920
	private void UpdateStaticData_ClientCollector(ClientCollectorData data) {} // 0x00000001839E0550-0x00000001839E0640
	// [XID] // 0x0000000189749260-0x0000000189749280
	private void CheckClientCollector(uint materialId) {} // 0x00000001839E0640-0x00000001839E0730
	// [XID] // 0x0000000189750760-0x0000000189750780
	private void OnOneoffGatherPointDetectorDataNotify(OneoffGatherPointDetectorDataNotify ntf) {} // 0x00000001839E1360-0x00000001839E1430
	// [XID] // 0x0000000189757C30-0x0000000189757C50
	public void CheckRadarHintGadget(LCRadarHint lcMark) {} // 0x00000001839E3AA0-0x00000001839E3BC0
	// [XID] // 0x000000018975F690-0x000000018975F6B0
	public void RequestRefreshServerDetectorData() {} // 0x00000001839E2450-0x00000001839E2730
	// [XID] // 0x0000000189766B40-0x0000000189766B60
	private void RefreshAllSeverDetectorData(RepeatedMessageField<OneoffGatherPointDetectorData> detectorDatas) {} // 0x00000001839DC880-0x00000001839DCAC0
	// [XID] // 0x000000018976E0A0-0x000000018976E0C0
	private void ClearHintData() {} // 0x00000001839DEA00-0x00000001839DECB0
	// [XID] // 0x0000000189950E90-0x0000000189950EB0
	public void ClearSeverDetectorOpenMapCoroutine() {} // 0x00000001839E0460-0x00000001839E0550
	// [XID] // 0x000000018977D180-0x000000018977D1A0
	public SeverDetectorData GetSeverDetectorData(uint markId) => default; // 0x00000001839E1270-0x00000001839E1360
	// [XID] // 0x0000000189784B20-0x0000000189784B40
	public void AddSeverDetectorData(uint hintGroup, OneoffGatherPointDetectorData detectorData) {} // 0x00000001839DC5D0-0x00000001839DC880
	// [XID] // 0x000000018993A9C0-0x000000018993A9E0
	public void CheckRadarMarkToReport(uint groupId, uint mapInstId) {} // 0x00000001839E33C0-0x00000001839E35D0
	// [XID] // 0x00000001897935A0-0x00000001897935C0
	private void CheckRadarMarkToRemove(uint materialId) {} // 0x00000001839DBD90-0x00000001839DBF70
	// [XID] // 0x000000018979B790-0x000000018979B7B0
	public void RemoveMarkArea(uint markId) {} // 0x00000001839DF920-0x00000001839DFAB0
	// [XID] // 0x00000001897A2BC0-0x00000001897A2BE0
	private void UpdateStaticData_SeverDetector(uint materialId, OneoffGatherPointDetectorData detectorData) {} // 0x00000001839DEF30-0x00000001839DF250
	// [XID] // 0x00000001897AA220-0x00000001897AA240
	private void OnHomeWorldModulePrepareGoIn(bool isIn) {} // 0x00000001839DB580-0x00000001839DBCD0
}

