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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionModule : BaseModule // TypeDefIndex: 21653
{
	// Fields
	private ReunionBriefInfo _briefInfo; // 0x10
	private bool _isActive; // 0x18
	private string _version; // 0x20
	private ReunionSignInInfo _signInInfo; // 0x28
	private ReunionMissionInfo _missionInfo; // 0x30
	private List<ReunionWatcherInfo> _ongoingWatcherList; // 0x38
	private List<ReunionWatcherInfo> _canClaimWatcherList; // 0x40
	private List<ReunionWatcherInfo> _claimedWatcherList; // 0x48
	private bool _sendFirstPrvRequest; // 0x50
	private uint _prvCurDayCount; // 0x54
	private uint _totalResinTime; // 0x58
	private Dictionary<ReunionPrivilegeType, HashSet<string>> _privilegeTypeDic; // 0x60

	// Properties
	public ReunionBriefInfo briefInfo { /* [XID] */ /* 0x0000000189AFFE50-0x0000000189AFFE70 */ get => default; } // 0x0000000184B22430-0x0000000184B224D0 
	public bool isActive { /* [XID] */ /* 0x0000000189B07430-0x0000000189B07450 */ get => default; } // 0x0000000184B255A0-0x0000000184B25640 
	public string version { /* [XID] */ /* 0x0000000189B0EBF0-0x0000000189B0EC10 */ get => default; } // 0x0000000184B222F0-0x0000000184B22390 
	public ReunionSignInInfo signInInfo { /* [XID] */ /* 0x0000000189B15FB0-0x0000000189B15FD0 */ get => default; } // 0x0000000184B227E0-0x0000000184B22880 
	public ReunionMissionInfo missionInfo { /* [XID] */ /* 0x0000000189B1D630-0x0000000189B1D650 */ get => default; } // 0x0000000184B23960-0x0000000184B23A00 
	public List<ReunionWatcherInfo> ongongWatcherList { /* [XID] */ /* 0x0000000189B25020-0x0000000189B25040 */ get => default; } // 0x0000000184B24B10-0x0000000184B24BB0 
	public List<ReunionWatcherInfo> canClaimWatcherList { /* [XID] */ /* 0x0000000189B2C4B0-0x0000000189B2C4D0 */ get => default; } // 0x0000000184B25250-0x0000000184B252F0 
	public List<ReunionWatcherInfo> claimedWatcherList { /* [XID] */ /* 0x0000000189B339E0-0x0000000189B33A00 */ get => default; } // 0x0000000184B20F10-0x0000000184B20FB0 
	public uint prvCurDayCount { /* [XID] */ /* 0x0000000189B3B2F0-0x0000000189B3B310 */ get => default; } // 0x0000000184B23F60-0x0000000184B24000 
	public uint totalResinTime { /* [XID] */ /* 0x0000000189B42B30-0x0000000189B42B50 */ get => default; } // 0x0000000184B22A00-0x0000000184B22AA0 
	public Dictionary<ReunionPrivilegeType, HashSet<string>> privilegeTypeDic { /* [XID] */ /* 0x0000000189B4A570-0x0000000189B4A590 */ get => default; } // 0x0000000184B22390-0x0000000184B22430 

	// Constructors
	public ReunionModule() {} // 0x0000000184B25C00-0x0000000184B25CB0

	// Methods
	// [XID] // 0x0000000189AF1330-0x0000000189AF1350
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000184B21780-0x0000000184B21930
	// [XID] // 0x0000000189AF88F0-0x0000000189AF8910
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000184B250E0-0x0000000184B251B0
	// [XID] // 0x0000000189B51D40-0x0000000189B51D60
	public override void InitOnLevelInit() {} // 0x0000000184B243F0-0x0000000184B24490
	// [XID] // 0x0000000189B59560-0x0000000189B59580
	public override void ClearOnBackHome() {} // 0x0000000184B22F90-0x0000000184B23030
	// [XID] // 0x0000000189B60DD0-0x0000000189B60DF0
	public override void ClearOnDisconnect() {} // 0x0000000184B251B0-0x0000000184B25250
	// [XID] // 0x0000000189B68530-0x0000000189B68550
	public override void ClearOnLevelDestroy() {} // 0x0000000184B216E0-0x0000000184B21780
	// [XID] // 0x0000000189B6F8C0-0x0000000189B6F8E0
	public override bool OnPacket(Packet packet) => default; // 0x0000000184B213B0-0x0000000184B216E0
	// [XID] // 0x0000000189B76EB0-0x0000000189B76ED0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000184B25640-0x0000000184B25740
	// [XID] // 0x0000000189B7E400-0x0000000189B7E420
	public void RequestReunionBriefInfo() {} // 0x0000000184B24060-0x0000000184B24140
	// [XID] // 0x0000000189B86010-0x0000000189B86030
	public void RequestClaimFirstGift() {} // 0x0000000184B23880-0x0000000184B23960
	// [XID] // 0x0000000189B8D090-0x0000000189B8D0B0
	public void RequestSignInInfo() {} // 0x0000000184B25A70-0x0000000184B25BA0
	// [XID] // 0x0000000189B94890-0x0000000189B948B0
	public void RequestClaimSignInReward(uint configId, uint dayIndex) {} // 0x0000000184B23DC0-0x0000000184B23EE0
	// [XID] // 0x0000000189B9BF60-0x0000000189B9BF80
	public void RequestTaskInfo() {} // 0x0000000184B233C0-0x0000000184B234F0
	// [XID] // 0x0000000189BA3670-0x0000000189BA3690
	public void RequestWatcherReward(uint watcherId) {} // 0x0000000184B22AA0-0x0000000184B22BF0
	// [XID] // 0x0000000189BAAA40-0x0000000189BAAA60
	public void RequestReunionFinalReward(uint rewardId) {} // 0x0000000184B234F0-0x0000000184B23640
	// [XID] // 0x0000000189BB1FB0-0x0000000189BB1FD0
	public void RequestPrivilegeInfo() {} // 0x0000000184B247A0-0x0000000184B248D0
	// [XID] // 0x0000000189BB93A0-0x0000000189BB93C0
	private void OnReunionBriefInfoRsp(ReunionBriefInfoRsp rsp) {} // 0x0000000184B21930-0x0000000184B21C50
	// [XID] // 0x0000000189BC11A0-0x0000000189BC11C0
	private void OnReunionDailyRefreshNotify(ReunionDailyRefreshNotify ntf) {} // 0x0000000184B20FB0-0x0000000184B21080
	// [XID] // 0x0000000189BC89C0-0x0000000189BC89E0
	private void DealWithBriefInfoProtocol(ReunionBriefInfo briefInfo) {} // 0x0000000184B24BB0-0x0000000184B250E0
	// [XID] // 0x0000000189BD0150-0x0000000189BD0170
	private void OnTakeReunionFirstGiftRewardRsp(TakeReunionFirstGiftRewardRsp rsp) {} // 0x0000000184B21080-0x0000000184B21330
	// [XID] // 0x0000000189BD77F0-0x0000000189BD7810
	private void OnTakeReunionSignInInfoRsp(GetReunionSignInInfoRsp rsp) {} // 0x0000000184B24490-0x0000000184B247A0
	// [XID] // 0x0000000189BDF360-0x0000000189BDF380
	private void OnGetReunionSignInRewardRsp(TakeReunionSignInRewardRsp rsp) {} // 0x0000000184B21C50-0x0000000184B222F0
	// [XID] // 0x00000001895EBF10-0x00000001895EBF30
	private void OnGetReunionMissionInfoRsp(GetReunionMissionInfoRsp rsp) {} // 0x0000000184B23AB0-0x0000000184B23DC0
	// [XID] // 0x00000001895F32F0-0x00000001895F3310
	private void InitWatcherListByMissionInfo() {} // 0x0000000184B230B0-0x0000000184B233C0
	// [XID] // 0x00000001895FABF0-0x00000001895FAC10
	private void OnTakeReunionWatcherRewardRsp(TakeReunionWatcherRewardRsp rsp) {} // 0x0000000184B22BF0-0x0000000184B22F90
	// [XID] // 0x0000000189602540-0x0000000189602560
	private bool UpdateWatcherList(uint watcherId) => default; // 0x0000000184B252F0-0x0000000184B25510
	// [XID] // 0x0000000189609DB0-0x0000000189609DD0
	private void OnTakeReunionMissionRewardRsp(TakeReunionMissionRewardRsp rsp) {} // 0x0000000184B224D0-0x0000000184B227E0
	// [XID] // 0x00000001896115E0-0x0000000189611600
	private void OnGetReunionPrivilegeInfoRsp(GetReunionPrivilegeInfoRsp rsp) {} // 0x0000000184B248D0-0x0000000184B24B10
	// [XID] // 0x0000000189618EE0-0x0000000189618F00
	private void OnReunionPrivilegeChangeNotify(ReunionPrivilegeChangeNotify ntf) {} // 0x0000000184B25740-0x0000000184B25A70
	// [XID] // 0x0000000189620420-0x0000000189620440
	private void DealWithPrivilegeProtocol(ReunionPrivilegeInfo privilegeInfo, bool openPage) {} // 0x0000000184B23640-0x0000000184B23880
	// [XID] // 0x00000001896278D0-0x00000001896278F0
	private void OnUpdateReunionWatchNotify(UpdateReunionWatcherNotify ntf) {} // 0x0000000184B24340-0x0000000184B243F0
	// [XID] // 0x000000018962F2D0-0x000000018962F2F0
	private void OnReunionSettleNotify(ReunionSettleNotify ntf) {} // 0x0000000184B22880-0x0000000184B22A00
	// [XID] // 0x0000000189636D40-0x0000000189636D60
	private void OnReunionActivateNotify(ReunionActivateNotify ntf) {} // 0x0000000184B23A00-0x0000000184B23AB0
	// [XID] // 0x000000018963E2A0-0x000000018963E2C0
	private List<SimpleItemStruct> CreateSimpleItemStructListByRewardId(uint rewardId) => default; // 0x0000000184B24140-0x0000000184B24340
	// [XID] // 0x0000000189645B80-0x0000000189645BA0
	private List<SimpleItemStruct> CreateFinalRewardByRewardId(uint rewardId) => default; // 0x0000000184B20D10-0x0000000184B20F10
}

