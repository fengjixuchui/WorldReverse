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

public sealed class InvestigationModule : BaseModule // TypeDefIndex: 21536
{
	// Fields
	private Dictionary<uint, InvestigationStruct> _investigationDic; // 0x10
	private Dictionary<uint, List<InvestigationTargetStruct>> _investigationTargetDic; // 0x18
	private List<uint> _chapterIDList; // 0x20
	private List<uint> _chapterIDListOfHomeworld; // 0x28
	private bool _showNewCityRedPoint; // 0x30
	private bool _showDailyDungeonToBeExploredRP; // 0x31
	private bool _isShowDungeonItem; // 0x32
	private Dictionary<uint, List<uint>> _cityInvestigationMonsterIDs; // 0x38
	private Dictionary<uint, InvestigationMonsterStruct> _monsterDatas; // 0x40
	private List<uint> _cleardCityIDList; // 0x48

	// Properties
	public int chapterNum { /* [XID] */ /* 0x00000001895FF370-0x00000001895FF390 */ get => default; } // 0x000000018194AD50-0x000000018194AE10 
	public int chapterNumOfHomeworld { /* [XID] */ /* 0x0000000189606C20-0x0000000189606C40 */ get => default; } // 0x000000018194AC90-0x000000018194AD50 
	public bool showNewCityRedPoint { /* [XID] */ /* 0x000000018960E520-0x000000018960E540 */ get => default; /* [XID] */ /* 0x0000000189615BE0-0x0000000189615C00 */ set {} } // 0x0000000181949DE0-0x0000000181949E80 0x000000018194BCD0-0x000000018194BD80
	public bool showDailyDungeonToBeExploredRP { /* [XID] */ /* 0x000000018961D430-0x000000018961D450 */ get => default; /* [XID] */ /* 0x00000001896248F0-0x0000000189624910 */ set {} } // 0x000000018194AAF0-0x000000018194AB90 0x0000000181949AA0-0x0000000181949B50
	public bool isShowDungeonItem { /* [XID] */ /* 0x000000018962C050-0x000000018962C070 */ get => default; /* [XID] */ /* 0x0000000189633BF0-0x0000000189633C10 */ set {} } // 0x00000001819491B0-0x0000000181949250 0x000000018194B2A0-0x000000018194B350
	public Dictionary<uint, List<uint>> monsterListDic { /* [XID] */ /* 0x00000001896775C0-0x00000001896775E0 */ get => default; } // 0x0000000181949E80-0x0000000181949F20 

	// Constructors
	public InvestigationModule() {} // 0x000000018194CFF0-0x000000018194D170

	// Methods
	// [XID] // 0x000000018963B470-0x000000018963B490
	public override bool OnPacket(Packet packet) => default; // 0x0000000181948FB0-0x00000001819491B0
	// [XID] // 0x0000000189642C20-0x0000000189642C40
	public override void ClearOnLevelDestroy() {} // 0x0000000181949250-0x00000001819492F0
	// [XID] // 0x000000018964A250-0x000000018964A270
	public override void ClearOnDisconnect() {} // 0x000000018194CD40-0x000000018194CDE0
	// [XID] // 0x00000001896519C0-0x00000001896519E0
	public override void ClearOnBackHome() {} // 0x000000018194A7C0-0x000000018194A910
	// [XID] // 0x0000000189659250-0x0000000189659270
	public override bool OnNotify(Notify ntf) => default; // 0x000000018194CE70-0x000000018194CF80
	// [XID] // 0x00000001896608D0-0x00000001896608F0
	public void RequestGetInvestigationMonster(List<uint> cityList) {} // 0x000000018194BB80-0x000000018194BCD0
	// [XID] // 0x00000001896682E0-0x0000000189668300
	public void RequestAllInvestigationMonster() {} // 0x0000000181949B50-0x0000000181949DE0
	// [XID] // 0x000000018966FDB0-0x000000018966FDD0
	private void OnGetInvestigationMonsterRsp(GetInvestigationMonsterRsp rsp) {} // 0x000000018194C980-0x000000018194CB90
	// [XID] // 0x000000018967EBA0-0x000000018967EBC0
	public bool TryGetMonsterData(uint investigationID, out InvestigationMonsterStruct data) {
		data = default;
		return default;
	} // 0x000000018194CB90-0x000000018194CC70
	// [XID] // 0x0000000189686450-0x0000000189686470
	private void RefreshInvestigationMonsterData(RepeatedMessageField<InvestigationMonster> monsterList) {} // 0x000000018194B350-0x000000018194BB80
	// [XID] // 0x000000018968E2F0-0x000000018968E310
	private void OnPlayerInvestigationAllInfoNotify(PlayerInvestigationAllInfoNotify ntf) {} // 0x00000001819495F0-0x0000000181949AA0
	// [XID] // 0x0000000189695B90-0x0000000189695BB0
	private void OnPlayerInvestigationNotify(PlayerInvestigationNotify ntf) {} // 0x0000000181948910-0x0000000181948E30
	// [XID] // 0x000000018969D2C0-0x000000018969D2E0
	private void OnPlayerInvestigationTargetNotify(PlayerInvestigationTargetNotify ntf) {} // 0x0000000181949F20-0x000000018194A3B0
	// [XID] // 0x00000001896A43E0-0x00000001896A4400
	public void RequestTakeInvestigationReward(uint investigationId) {} // 0x0000000181948E30-0x0000000181948F30
	// [XID] // 0x00000001896ABBD0-0x00000001896ABBF0
	private void OnTakeInvestigationRewardRsp(TakeInvestigationRewardRsp rsp) {} // 0x000000018194AE90-0x000000018194AFF0
	// [XID] // 0x00000001896B2D10-0x00000001896B2D30
	public void RequestTakeInvestigationTargetReward(uint questId) {} // 0x000000018194AB90-0x000000018194AC90
	// [XID] // 0x00000001896BA3B0-0x00000001896BA3D0
	private void OnTakeInvestigationTargetRewardRsp(TakeInvestigationTargetRewardRsp rsp) {} // 0x000000018194A990-0x000000018194AAF0
	// [XID] // 0x00000001896C1640-0x00000001896C1660
	public InvestigationStruct? GetInvestigationDataByIndex(int index, InvestigationType type = InvestigationType.INVESTIGATION_ADVENTURE /* Metadata: 0x00AFF8F6 */) => default; // 0x000000018194C760-0x000000018194C980
	// [XID] // 0x00000001896C8D80-0x00000001896C8DA0
	public List<InvestigationTargetStruct> GetInvestigationTargetListByInvestigationId(uint investigationId) => default; // 0x000000018194BD80-0x000000018194BE70
	// [XID] // 0x00000001896D0720-0x00000001896D0740
	public bool CanGetReward(InvestigationType type) => default; // 0x000000018194BE70-0x000000018194C180
	// [XID] // 0x00000001896D7C50-0x00000001896D7C70
	public bool CanGetRewardByCityId(uint cityId) => default; // 0x000000018194C440-0x000000018194C760
	// [XID] // 0x00000001896DF4A0-0x00000001896DF4C0
	public Vector3? GetInvestigationTargetGuidePos(uint questId) => default; // 0x000000018194A3B0-0x000000018194A7C0
	// [XID] // 0x00000001896E6840-0x00000001896E6860
	public bool IsInvestigationMonsterOccupiedByQuest(uint investigationId, out uint mainQuestId) {
		mainQuestId = default;
		return default;
	} // 0x000000018194B050-0x000000018194B2A0
	// [XID] // 0x00000001896EDE10-0x00000001896EDE30
	public bool IsHomeworldHandbookCompleted() => default; // 0x000000018194C180-0x000000018194C440
	// [XID] // 0x00000001896F5670-0x00000001896F5690
	public bool CanHomeworldHandbookGetRewardInNextChapter() => default; // 0x0000000181949420-0x00000001819495F0
	// [XID] // 0x00000001896FCE50-0x00000001896FCE70
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001819492F0-0x0000000181949420
	// [XID] // 0x0000000189704300-0x0000000189704320
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018194CC70-0x000000018194CD40
}

