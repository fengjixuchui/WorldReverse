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

public sealed class AchievementModule : BaseModule // TypeDefIndex: 21395
{
	// Fields
	private Dictionary<uint, Achievement> _achievementDic; // 0x10
	private List<uint> _rewardTakenGoalIdList; // 0x18
	private Dictionary<uint, LevelOfAchievemet> _levelOfAchievementDic; // 0x20
	private Dictionary<uint, List<uint>> _goalId2AchievementDic; // 0x28
	private bool? _psTrophySwitch; // 0x30
	private static bool _hasCheckTrophy; // 0x00
	private const string LEVEL_ICON_PATH = "UI_AchievementIcon_{0}_{1}"; // Metadata: 0x00AFF77F

	// Properties
	public bool hasCheckTrophy { /* [XID] */ /* 0x000000018978C0F0-0x000000018978C110 */ get => default; } // 0x00000001822F8AF0-0x00000001822F8BC0 
	public bool? psTrophySwitch { /* [XID] */ /* 0x0000000189793620-0x0000000189793640 */ get => default; } // 0x00000001822F6690-0x00000001822F6810 
	public Dictionary<uint, Achievement> achievementDic { /* [XID] */ /* 0x000000018979B850-0x000000018979B870 */ get => default; } // 0x00000001822F70C0-0x00000001822F7160 
	public List<uint> rewardTakenGoalIdList { /* [XID] */ /* 0x00000001897A2C40-0x00000001897A2C60 */ get => default; } // 0x00000001822F73D0-0x00000001822F7470 
	public Dictionary<uint, List<uint>> goalId2AchievementDic { /* [XID] */ /* 0x00000001897AA2C0-0x00000001897AA2E0 */ get => default; } // 0x00000001822F7160-0x00000001822F7230 
	public Dictionary<uint, LevelOfAchievemet> levelOfAchievementDic { /* [XID] */ /* 0x00000001897B1CB0-0x00000001897B1CD0 */ get => default; } // 0x00000001822F7230-0x00000001822F7300 

	// Constructors
	public AchievementModule() {} // 0x00000001822F8D60-0x00000001822F8E80
	static AchievementModule() {} // 0x00000001822F8D00-0x00000001822F8D60

	// Methods
	// [XID] // 0x00000001897B9730-0x00000001897B9750
	public uint GetFinishAchievementNum() => default; // 0x00000001822F6B50-0x00000001822F6D90
	// [XID] // 0x00000001897C1760-0x00000001897C1780
	public override void ClearOnLevelDestroy() {} // 0x00000001822F69B0-0x00000001822F6A50
	// [XID] // 0x00000001897C91C0-0x00000001897C91E0
	public override void ClearOnDisconnect() {} // 0x00000001822F8BC0-0x00000001822F8CA0
	// [XID] // 0x00000001897D07D0-0x00000001897D07F0
	public override void InitOnLevelInit() {} // 0x00000001822F89B0-0x00000001822F8AF0
	// [XID] // 0x00000001897D8520-0x00000001897D8540
	public override void ClearOnBackHome() {} // 0x00000001822F7470-0x00000001822F7550
	// [XID] // 0x00000001897DF5F0-0x00000001897DF610
	private void ClearAchievementData() {} // 0x00000001822F7300-0x00000001822F73D0
	// [XID] // 0x00000001897E6E10-0x00000001897E6E30
	public override bool OnPacket(Packet packet) => default; // 0x00000001822F6810-0x00000001822F69B0
	// [XID] // 0x00000001897EEAE0-0x00000001897EEB00
	private void OnAchievementAllDataNotify(AchievementAllDataNotify ntf) {} // 0x00000001822F5E50-0x00000001822F60C0
	// [XID] // 0x00000001897F6220-0x00000001897F6240
	public void CheckPS5Trophy() {} // 0x00000001822F88B0-0x00000001822F8950
	// [XID] // 0x00000001897FD860-0x00000001897FD880
	private void OnAchievementUpdateNotify(AchievementUpdateNotify ntf) {} // 0x00000001822F7F00-0x00000001822F81B0
	// [XID] // 0x0000000189805090-0x00000001898050B0
	private void OnTakeAchievementRewardRsp(TakeAchievementRewardRsp rsp) {} // 0x00000001822F60C0-0x00000001822F6610
	// [XID] // 0x000000018980C590-0x000000018980C5B0
	private void OnTakeAchievementGoalRewardRsp(TakeAchievementGoalRewardRsp rsp) {} // 0x00000001822F81B0-0x00000001822F86E0
	// [XID] // 0x0000000189813D40-0x0000000189813D60
	public void RequestTakeAchievementReward(List<uint> idList) {} // 0x00000001822F7A80-0x00000001822F7BD0
	// [XID] // 0x000000018981B8C0-0x000000018981B8E0
	public void RequestTakeAchievementGoalRewardReq(List<uint> idList) {} // 0x00000001822F8760-0x00000001822F88B0
	// [XID] // 0x0000000189822E30-0x0000000189822E50
	private void LoadAchievementExcelData() {} // 0x00000001822F7550-0x00000001822F7A80
	// [XID] // 0x000000018982A7D0-0x000000018982A7F0
	private void OnGetNewAchievement(List<Achievement> updataList) {} // 0x00000001822F7BD0-0x00000001822F7F00
	// [XID] // 0x0000000189831B80-0x0000000189831BA0
	private void GetGoalId2AchievementDic() {} // 0x00000001822F6D90-0x00000001822F70C0
	// [XID] // 0x00000001898391E0-0x0000000189839200
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001822F6A50-0x00000001822F6B50
}

