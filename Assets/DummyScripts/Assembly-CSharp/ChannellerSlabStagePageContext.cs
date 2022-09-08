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

public sealed class ChannellerSlabStagePageContext : BasePageContext // TypeDefIndex: 30037
{
	// Fields
	private MonoChannellerSlabStagePage _pageMono; // 0x190
	private int _stageIndex; // 0x198
	private uint _stageID; // 0x19C
	private List<uint> _levelExcelIDList; // 0x1A0
	private int _waveIndex; // 0x1A8
	private bool _isFolded; // 0x1AC
	private List<RewardItemConfig> _currRewardList; // 0x1B0
	private bool _isDone; // 0x1B8
	private bool _isLoopDungeon; // 0x1B9
	private List<ChannellerSlabLoopDungeonRewardExcelConfig> _currMissionIDList; // 0x1C0
	private List<RewardItemConfig> _currLoopDungeonRewardList; // 0x1C8
	private uint _loopDungeonBestScore; // 0x1D0
	private MonoJoypadSimpleResuableListHandler _waveJoypadHandler; // 0x1D8
	private MonoJoypadSimpleResuableListHandler _campJoypadHandler; // 0x1E0
	private MonoJoypadSimpleResuableListHandler _missionJoypadHandler; // 0x1E8
	private ActivityCoinComponent _coinCom; // 0x1F0
	public static uint TrackMarkID; // 0x00

	// Constructors
	public ChannellerSlabStagePageContext() {} // Dummy constructor
	public ChannellerSlabStagePageContext(int stageIndex) {} // 0x000000018295D450-0x000000018295D570
	static ChannellerSlabStagePageContext() {} // 0x000000018295D3F0-0x000000018295D450

	// Methods
	// [XID] // 0x0000000189624590-0x00000001896245B0
	public override void SetupView() {} // 0x000000018295D060-0x000000018295D3F0
	// [XID] // 0x000000018962BCB0-0x000000018962BCD0
	protected override void BindRedPoints() {} // 0x00000001829583E0-0x00000001829584D0
	// [XID] // 0x00000001896337D0-0x00000001896337F0
	private void CheckRedPoint() {} // 0x000000018295A5E0-0x000000018295A6E0
	// [XID] // 0x000000018963B0B0-0x000000018963B0D0
	protected override void BindViewCallbacks() {} // 0x00000001829584D0-0x00000001829587E0
	// [XID] // 0x00000001896427A0-0x00000001896427C0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018295C9C0-0x000000018295CBC0
	// [XID] // 0x0000000189649E90-0x0000000189649EB0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018295B8D0-0x000000018295B9D0
	// [XID] // 0x00000001896515D0-0x00000001896515F0
	private void UpdateActivity(uint activityId) {} // 0x000000018295C2E0-0x000000018295C410
	// [XID] // 0x0000000189658E10-0x0000000189658E30
	protected override void OnEnable() {} // 0x000000018295C780-0x000000018295C880
	// [XID] // 0x0000000189660520-0x0000000189660540
	private void Refresh(bool setup) {} // 0x0000000182957730-0x0000000182957B90
	// [XID] // 0x0000000189667E60-0x0000000189667E80
	private void SetAllCampState() {} // 0x00000001829587E0-0x0000000182958950
	// [XID] // 0x000000018966F8D0-0x000000018966F8F0
	private void RecordShow(uint stageIndex) {} // 0x0000000182958BE0-0x0000000182958F50
	// [XID] // 0x0000000189677220-0x0000000189677240
	private void CreateChallengeWave() {} // 0x000000018295A260-0x000000018295A3C0
	// [XID] // 0x000000018967E7D0-0x000000018967E7F0
	private void ShowChallengeWave(int fixWaveId = -1 /* Metadata: 0x00B107A2 */) {} // 0x000000018295CBC0-0x000000018295CD80
	// [XID] // 0x0000000189686040-0x0000000189686060
	private void RefreshOneOffDungeonInfo() {} // 0x000000018295B370-0x000000018295B6B0
	// [XID] // 0x000000018968DE10-0x000000018968DE30
	private void RefreshWaveView() {} // 0x000000018295CD80-0x000000018295CE40
	// [XID] // 0x0000000189695780-0x00000001896957A0
	private void RefreshChallengeWave(int waveIndex) {} // 0x0000000182958FB0-0x00000001829594A0
	// [XID] // 0x000000018969CDF0-0x000000018969CE10
	private void OnClickWave(uint btnID) {} // 0x000000018295A510-0x000000018295A5E0
	// [XID] // 0x00000001896A4100-0x00000001896A4120
	private void CreateCamps() {} // 0x0000000182958950-0x0000000182958AB0
	// [XID] // 0x00000001896AB6E0-0x00000001896AB700
	private void RefreshCamps() {} // 0x0000000182959950-0x0000000182959D50
	// [XID] // 0x00000001896B2930-0x00000001896B2950
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000182959D50-0x000000018295A030
	// [XID] // 0x00000001896BA080-0x00000001896BA0A0
	private void OnClickBack() {} // 0x000000018295A1B0-0x000000018295A260
	// [XID] // 0x00000001896C1350-0x00000001896C1370
	private bool IsAllCampDone() => default; // 0x00000001829594A0-0x00000001829595A0
	// [XID] // 0x00000001896C8A30-0x00000001896C8A50
	private void OnClickGoto() {} // 0x000000018295AE50-0x000000018295B370
	// [XID] // 0x00000001896D03E0-0x00000001896D0400
	private void OnClickOneOffDungeon() {} // 0x000000018295B7B0-0x000000018295B8D0
	// [XID] // 0x00000001896D7940-0x00000001896D7960
	private void OnUnlockOneOffDungeonHint() {} // 0x000000018295A0C0-0x000000018295A1B0
	// [XID] // 0x00000001896DF120-0x00000001896DF140
	private void OnPrevBtnClick() {} // 0x0000000182958290-0x00000001829583E0
	// [XID] // 0x00000001896E6570-0x00000001896E6590
	private void OnNextBtnClick() {} // 0x0000000182957DB0-0x0000000182957F00
	// [XID] // 0x00000001896EDAE0-0x00000001896EDB00
	private void CheckSwitchBtnState() {} // 0x0000000182958060-0x0000000182958230
	// [XID] // 0x00000001896F52B0-0x00000001896F52D0
	private void SetStageState() {} // 0x00000001829595A0-0x0000000182959650
	// [XID] // 0x00000001896FCB10-0x00000001896FCB30
	private void RefreshLoopDungeonView() {} // 0x000000018295B9D0-0x000000018295BE40
	// [XID] // 0x0000000189703FF0-0x0000000189704010
	private int SortCompareMission(ChannellerSlabLoopDungeonRewardExcelConfig left, ChannellerSlabLoopDungeonRewardExcelConfig right) => default; // 0x0000000182957F00-0x0000000182958060
	// [XID] // 0x000000018970B8E0-0x000000018970B900
	private void RefreshMissionRow(Transform trans, int index) {} // 0x000000018295BEA0-0x000000018295C2E0
	// [XID] // 0x0000000189713170-0x0000000189713190
	private int GetMissionState(uint scoreGrade, uint id) => default; // 0x0000000182957CB0-0x0000000182957DB0
	// [XID] // 0x000000018971A990-0x000000018971A9B0
	private void OnClickFetchMissionReward(uint id) {} // 0x000000018295A3C0-0x000000018295A4B0
	// [XID] // 0x0000000189721CD0-0x0000000189721CF0
	private void OnClickGotoLoopDungeon() {} // 0x0000000182958AB0-0x0000000182958BE0
	// [XID] // 0x0000000189729320-0x0000000189729340
	private void OnCheckEnterLoopDungeonRsp(bool success) {} // 0x000000018295B6B0-0x000000018295B7B0
	// [XID] // 0x0000000189730B80-0x0000000189730BA0
	private void RealGotoLoopDungeon() {} // 0x000000018295CE40-0x000000018295D060
	// [XID] // 0x00000001897384B0-0x00000001897384D0
	private void RefreshDungeonRewardItem(Transform trans, int index) {} // 0x00000001829596F0-0x0000000182959950
	// [XID] // 0x00000001897401F0-0x0000000189740210
	private void OnClickDesc() {} // 0x0000000182957B90-0x0000000182957CB0
	// [XID] // 0x00000001897475C0-0x00000001897475E0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B107A6 */) {} // 0x000000018295C880-0x000000018295C9C0
	// [XID] // 0x000000018974ED10-0x000000018974ED30
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018295A6E0-0x000000018295AC20
	// [XID] // 0x0000000189756420-0x0000000189756440
	private void HandleJoypad() {} // 0x000000018295C4A0-0x000000018295C780
	// [XID] // 0x000000018975D840-0x000000018975D860
	private void HandleLoopDungeonRowJoypad(int index, Transform trans) {} // 0x000000018295AC20-0x000000018295AE50
}

