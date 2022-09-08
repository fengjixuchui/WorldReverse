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

public sealed class CoopManager : GlobalManager, INotifyInterface // TypeDefIndex: 20780
{
	// Fields
	private CoopTask _currCoopTask; // 0x10
	private bool _isInCoop; // 0x18
	private Dictionary<uint, MainCoopTask> _mainCoopDic; // 0x20
	private List<CoopInteractionRequestData> _coopRequestCacheList; // 0x28
	public static bool ENABLE_COOP_LINE_SWITCH; // 0x00
	private Dictionary<uint, CoopChapter> _chapterId2CoopChapter; // 0x30
	private Dictionary<uint, HashSet<uint>> _avatarId2ChapterIdListDic; // 0x38
	private List<uint> _showAvatarIdList; // 0x40
	private HashSet<uint> _viewedChapterList; // 0x48
	private bool _isOngoing; // 0x50
	private uint _ongoingPointId; // 0x54
	private uint _ongoingChapterId; // 0x58

	// Properties
	public bool isInCoop { /* [XID] */ /* 0x000000018989D260-0x000000018989D280 */ get => default; } // 0x000000018184D3C0-0x000000018184D460 
	public CoopTask currCoopTask { /* [XID] */ /* 0x00000001898B5DB0-0x00000001898B5DD0 */ get => default; } // 0x0000000181851520-0x00000001818515C0 
	public bool isOngoing { /* [XID] */ /* 0x00000001899A2C70-0x00000001899A2C90 */ get => default; } // 0x0000000181851E60-0x0000000181851F00 
	public uint ongoingChapterId { /* [XID] */ /* 0x00000001899AA6C0-0x00000001899AA6E0 */ get => default; } // 0x000000018184F2D0-0x000000018184F370 
	public List<uint> showAvatarIdList { /* [XID] */ /* 0x00000001899B2020-0x00000001899B2040 */ get => default; } // 0x0000000181851480-0x0000000181851520 

	// Constructors
	public CoopManager() {} // 0x0000000181853850-0x00000001818538E0
	static CoopManager() {} // 0x00000001818537F0-0x0000000181853850

	// Methods
	// [XID] // 0x00000001898AC0C0-0x00000001898AC0E0
	public override void Init() {} // 0x0000000181851050-0x0000000181851100
	// [XID] // 0x00000001898B37E0-0x00000001898B3800
	public override void Destroy() {} // 0x000000018184E290-0x000000018184E350
	// [XID] // 0x00000001898BB5B0-0x00000001898BB5D0
	public override void ClearOnDisconnect() {} // 0x000000018184DB80-0x000000018184DC30
	// [XID] // 0x00000001898C2840-0x00000001898C2860
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFE32A */) {} // 0x000000018184DAC0-0x000000018184DB80
	// [XID] // 0x00000001898CA2A0-0x00000001898CA2C0
	public override void ReloadRes() {} // 0x0000000181853750-0x00000001818537F0
	// [XID] // 0x00000001898D19D0-0x00000001898D19F0
	public override void ClearOnLevelDestroy() {} // 0x000000018184DC30-0x000000018184DCD0
	// [XID] // 0x00000001898D91D0-0x00000001898D91F0
	public void RegisterNotify() {} // 0x000000018184F780-0x000000018184F860
	// [XID] // 0x00000001898E0E70-0x00000001898E0E90
	public void UnregisterNotify() {} // 0x00000001818515C0-0x00000001818516A0
	// [XID] // 0x00000001898E8960-0x00000001898E8980
	public bool OnNotify(Notify ntf) => default; // 0x0000000181853250-0x0000000181853330
	// [XID] // 0x00000001898F0060-0x00000001898F0080
	private void OnTransmitStartNotify() {} // 0x000000018184EE10-0x000000018184EEC0
	// [XID] // 0x00000001898F7990-0x00000001898F79B0
	private void ClearCoopData() {} // 0x00000001818516A0-0x0000000181851780
	// [XID] // 0x00000001898FEFF0-0x00000001898FF010
	public void DispatchCoopEvent(CoopEvent evt) {} // 0x000000018184D1D0-0x000000018184D2A0
	// [XID] // 0x00000001896BB4C0-0x00000001896BB4E0
	public bool StartCoopInteraction(uint coopInteractionId, uint mainCoopId) => default; // 0x0000000181850750-0x00000001818509E0
	// [XID] // 0x000000018990E290-0x000000018990E2B0
	public void SetCoopNextNodeId(uint nodeId) {} // 0x0000000181852460-0x0000000181852520
	// [XID] // 0x00000001899159E0-0x0000000189915A00
	public void SetCoopFailNode() {} // 0x000000018184F220-0x000000018184F2D0
	// [XID] // 0x000000018991D370-0x000000018991D390
	public void MoveCoopToNextNode() {} // 0x0000000181850470-0x00000001818505F0
	// [XID] // 0x0000000189924D00-0x0000000189924D20
	public void TryEndCoop(uint savePointId, uint mainCoopId) {} // 0x000000018184EFD0-0x000000018184F220
	// [XID] // 0x000000018992C200-0x000000018992C220
	private void ClearInteraction() {} // 0x0000000181853140-0x0000000181853250
	// [XID] // 0x0000000189933680-0x00000001899336A0
	public MainCoopTask GetCurrMainCoopTask() => default; // 0x000000018184E850-0x000000018184E910
	// [XID] // 0x00000001899F4C80-0x00000001899F4CA0
	public void ClearCurrCoopInteraction() {} // 0x0000000181852360-0x0000000181852460
	// [XID] // 0x0000000189942420-0x0000000189942440
	private MainCoopTask CreateMainCoopTask(uint mainCoopId) => default; // 0x0000000181851970-0x0000000181851A90
	// [XID] // 0x0000000189949D40-0x0000000189949D60
	public void RefreshMainCoopTaskData(MainCoop coopSaveData) {} // 0x000000018184CE80-0x000000018184D100
	// [XID] // 0x0000000189951920-0x0000000189951940
	public MainCoopTask GetMainCoopTaskById(uint mainCoopId) => default; // 0x000000018184D9E0-0x000000018184DAC0
	// [XID] // 0x0000000189958E50-0x0000000189958E70
	public void RequestCoopInteractionFromSubStartPoint(uint mainCoopId, uint subStartPointId) {} // 0x000000018184FDD0-0x0000000181850110
	// [XID] // 0x00000001896EEDA0-0x00000001896EEDC0
	public CoopInteractionRequestData? GetValidCoopInteractionDataByNpcId(uint npcId, uint mainQuestId) => default; // 0x000000018184D7A0-0x000000018184D9E0
	// [XID] // 0x0000000189967EE0-0x0000000189967F00
	public void RemoveCoopInteractionDataFromSubStartPoint(uint mainCoopId, uint subStartPointId) {} // 0x000000018184D100-0x000000018184D1D0
	// [IDTag] // 0x000000018996F140-0x000000018996F180
	// [XID] // 0x000000018996F140-0x000000018996F180
	private void RemoveCoopInteractionData(uint mainCoopId, uint coopInteractionId) {} // 0x000000018184EA90-0x000000018184EC00
	// [IDTag] // 0x000000018997A050-0x000000018997A090
	// [XID] // 0x000000018997A050-0x000000018997A090
	private void RemoveCoopInteractionData(uint mainCoopId) {} // 0x000000018184E910-0x000000018184EA90
	// [XID] // 0x00000001899844D0-0x00000001899844F0
	public bool CheckSavePointFinished(uint mainCoopId, uint savePointId) => default; // 0x000000018184F370-0x000000018184F460
	// [XID] // 0x000000018998BF50-0x000000018998BF70
	private void SetDefaultAutoTalk() {} // 0x000000018184CD50-0x000000018184CE80
	// [XID] // 0x0000000189993C70-0x0000000189993C90
	public void CoopSaveDebug(uint mainCoopId, uint savePointId) {} // 0x0000000181851F00-0x0000000181852040
	// [XID] // 0x000000018999B4E0-0x000000018999B500
	public void CoopFinishDebug(uint mainCoopId, uint savePointId) {} // 0x000000018184EEC0-0x000000018184EFD0
	// [XID] // 0x00000001899B9480-0x00000001899B94A0
	public void ClearCoopUIData() {} // 0x000000018184FB90-0x000000018184FDD0
	// [XID] // 0x00000001899C0E70-0x00000001899C0E90
	public void CancelCurrentCoopTask() {} // 0x000000018184D6C0-0x000000018184D7A0
	// [XID] // 0x00000001899C8430-0x00000001899C8450
	public void UpdateChapterViewState(uint chapterId) {} // 0x000000018184F860-0x000000018184F970
	// [XID] // 0x00000001899CFEB0-0x00000001899CFED0
	public void StartCoopPoint(uint pointId) {} // 0x0000000181851310-0x0000000181851400
	// [XID] // 0x00000001899D73D0-0x00000001899D73F0
	public void StartPointFromPage(uint pointId) {} // 0x00000001818505F0-0x0000000181850750
	// [XID] // 0x00000001899DE770-0x00000001899DE790
	public void UpdateCoopOngoingState(bool isOngoing, uint curCoopPos = 0 /* Metadata: 0x00AFE32B */) {} // 0x0000000181853660-0x0000000181853750
	// [XID] // 0x00000001899E6470-0x00000001899E6490
	private void CheckInitCoopUI() {} // 0x00000001818509E0-0x0000000181850B30
	// [XID] // 0x00000001899ED9C0-0x00000001899ED9E0
	public void UpdateChapterInfos(RepeatedMessageField<CoopChapter> chapterInfos) {} // 0x000000018184D460-0x000000018184D6C0
	// [XID] // 0x00000001899F53B0-0x00000001899F53D0
	public void UpdateCoopChapterInfoDic(uint chapterId, CoopChapter coopChapterInfo) {} // 0x0000000181852F60-0x0000000181853140
	// [XID] // 0x00000001899FC9F0-0x00000001899FCA10
	public void UpdateShowAvatarChapterDic(uint avatarId, uint chapterId) {} // 0x000000018184E020-0x000000018184E1D0
	// [XID] // 0x0000000189A03F00-0x0000000189A03F20
	public void UpdatePointState(CoopPoint pointInfo) {} // 0x0000000181850210-0x0000000181850470
	// [XID] // 0x0000000189A0B5D0-0x0000000189A0B5F0
	public void UnlockCurrentChapterCGs(RepeatedField<uint> cgs) {} // 0x000000018184F460-0x000000018184F780
	// [XID] // 0x0000000189A12D30-0x0000000189A12D50
	public void TakenChapterReward(uint rewardConfigId) {} // 0x0000000181853390-0x0000000181853660
	// [XID] // 0x0000000189A1A0F0-0x0000000189A1A110
	public void UpdateCurrentChapterReward(RepeatedMessageField<CoopReward> rewards) {} // 0x0000000181852040-0x0000000181852360
	// [XID] // 0x0000000189A21630-0x0000000189A21650
	public void UnlockNewChapter(uint chapterId) {} // 0x0000000181850C00-0x0000000181850DD0
	// [XID] // 0x0000000189A28C30-0x0000000189A28C50
	public void UpdateViewedChapters(uint chapterId) {} // 0x0000000181850B30-0x0000000181850C00
	// [XID] // 0x0000000189A302D0-0x0000000189A302F0
	public bool IsAcceptedChapterId(uint chapterId) => default; // 0x000000018184D2A0-0x000000018184D3C0
	// [XID] // 0x0000000189A37D30-0x0000000189A37D50
	public bool IsCoopUIDataLoaded() => default; // 0x0000000181851DA0-0x0000000181851E60
	// [XID] // 0x0000000189A3F460-0x0000000189A3F480
	public RepeatedMessageField<CoopReward> GetRewardListByChapterId(uint chapterId) => default; // 0x0000000181850110-0x0000000181850210
	// [XID] // 0x0000000189A46A70-0x0000000189A46A90
	public RepeatedMessageField<CoopCg> GetCGListByChapterId(uint chapterId) => default; // 0x000000018184CC50-0x000000018184CD50
	// [XID] // 0x0000000189A4E230-0x0000000189A4E250
	public bool CheckIsOngoingByAvatarId(uint avatarId) => default; // 0x0000000181851780-0x0000000181851970
	// [XID] // 0x0000000189A55AA0-0x0000000189A55AC0
	public bool CheckIsOngoingByChapterId(uint chapterId) => default; // 0x000000018184E1D0-0x000000018184E290
	// [XID] // 0x0000000189A5D2E0-0x0000000189A5D300
	public bool CheckIsOngoingByPointId(uint pointId) => default; // 0x0000000181850F90-0x0000000181851050
	// [XID] // 0x0000000189A64C40-0x0000000189A64C60
	public bool CheckHaveUnlockChapterByAvatarId(uint avatarId) => default; // 0x000000018184F970-0x000000018184FB90
	// [IDTag] // 0x0000000189A6C440-0x0000000189A6C480
	// [XID] // 0x0000000189A6C440-0x0000000189A6C480
	public bool CheckHaveRewardToTake(uint chapterId) => default; // 0x000000018184E350-0x000000018184E560
	// [XID] // 0x0000000189A76BC0-0x0000000189A76BE0
	public bool CheckHaveRewardToTakeByAvatarId(uint avatarId) => default; // 0x00000001818529F0-0x0000000181852D20
	// [IDTag] // 0x0000000189A7E540-0x0000000189A7E580
	// [XID] // 0x0000000189A7E540-0x0000000189A7E580
	public bool CheckHaveRewardToTake() => default; // 0x000000018184E560-0x000000018184E850
	// [XID] // 0x0000000189A89110-0x0000000189A89130
	public bool CheckAllRewardTaken(uint chapterId) => default; // 0x0000000181851100-0x0000000181851310
	// [XID] // 0x0000000189A908F0-0x0000000189A90910
	public HashSet<uint> GetChaptersIdByAvatarId(uint avatarId) => default; // 0x0000000181850EB0-0x0000000181850F90
	// [XID] // 0x0000000189A98130-0x0000000189A98150
	public CoopChapter GetChapterInfoByChapterId(uint chapterId) => default; // 0x0000000181850DD0-0x0000000181850EB0
	// [XID] // 0x0000000189A9F4F0-0x0000000189A9F510
	public int GetPointsCountByChapterId(uint chapterId) => default; // 0x0000000181851C80-0x0000000181851DA0
	// [XID] // 0x0000000189AA6D00-0x0000000189AA6D20
	public CoopPoint GetPointInfoByIndex(uint chapterId, int index) => default; // 0x0000000181851A90-0x0000000181851C80
	// [XID] // 0x0000000189AAE470-0x0000000189AAE490
	public CoopPoint GetPointInfoByPointId(uint chapterId, uint pointId) => default; // 0x0000000181852D20-0x0000000181852F60
	// [XID] // 0x0000000189AB5CE0-0x0000000189AB5D00
	public bool CheckHaveUnlockCG(uint chapterId, uint pointId) => default; // 0x000000018184DCD0-0x000000018184E020
	// [XID] // 0x0000000189ABD7B0-0x0000000189ABD7D0
	public bool GetSavePointFinishState(uint chapterId, uint savePointId) => default; // 0x0000000181852800-0x00000001818529F0
	// [IDTag] // 0x0000000189AC5230-0x0000000189AC5270
	// [XID] // 0x0000000189AC5230-0x0000000189AC5270
	public bool CheckHaveChapterToView() => default; // 0x0000000181852520-0x0000000181852730
	// [XID] // 0x0000000189ACF710-0x0000000189ACF730
	public bool CheckHaveChapterToViewByAvatarId(uint avatarId) => default; // 0x000000018184EC00-0x000000018184EE10
	// [IDTag] // 0x0000000189AD7480-0x0000000189AD74C0
	// [XID] // 0x0000000189AD7480-0x0000000189AD74C0
	public bool CheckHaveChapterToView(uint chapterId) => default; // 0x0000000181852730-0x0000000181852800
}

