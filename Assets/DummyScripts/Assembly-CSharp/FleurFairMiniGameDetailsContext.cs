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
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMiniGameDetailsContext : BaseDialogContext // TypeDefIndex: 29078
{
	// Fields
	private MonoFleurFairMiniGameDetailsDialog _dialogMono; // 0x178
	private ActivityInfo _activityInfo; // 0x180
	private int _curLevelIndex; // 0x188
	private EFleurFairMiniGame _miniGameType; // 0x18C
	private List<uint> _level_ids; // 0x190
	private uint _curGameId; // 0x198
	private bool _isPrevEnable; // 0x19C
	private bool _isNextEnable; // 0x19D
	private bool _focus_left_region; // 0x19E
	private int _right_avatar_index; // 0x1A0

	// Constructors
	public FleurFairMiniGameDetailsContext() {} // Dummy constructor
	public FleurFairMiniGameDetailsContext(EFleurFairMiniGame miniGameType, int levelIndex) {} // 0x0000000181672730-0x0000000181672940

	// Methods
	// [XID] // 0x0000000189ACF320-0x0000000189ACF340
	public override void SetupView() {} // 0x0000000181672630-0x0000000181672730
	// [XID] // 0x0000000189AD71F0-0x0000000189AD7210
	private void SetTabs() {} // 0x00000001816724D0-0x0000000181672630
	// [XID] // 0x0000000189ADEBD0-0x0000000189ADEBF0
	protected override void BindRedPoints() {} // 0x000000018166D680-0x000000018166D7A0
	// [XID] // 0x0000000189AE6580-0x0000000189AE65A0
	private void CheckRedPoints_AvatarReward() {} // 0x000000018166EA80-0x000000018166ECC0
	// [XID] // 0x0000000189AEDD90-0x0000000189AEDDB0
	protected override void OnEnable() {} // 0x00000001816720E0-0x0000000181672180
	// [XID] // 0x0000000189AF55C0-0x0000000189AF55E0
	protected override void OnDisable() {} // 0x0000000181672040-0x00000001816720E0
	// [XID] // 0x0000000189AFCAB0-0x0000000189AFCAD0
	public override void ClearView() {} // 0x000000018166DD90-0x000000018166DE40
	// [XID] // 0x0000000189B04270-0x0000000189B04290
	protected override void BindViewCallbacks() {} // 0x000000018166D7A0-0x000000018166D9B0
	// [XID] // 0x0000000189B0BAF0-0x0000000189B0BB10
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181672180-0x00000001816722E0
	// [XID] // 0x0000000189B12FC0-0x0000000189B12FE0
	private void UpdateActivity(uint activityId) {} // 0x0000000181671E90-0x0000000181671FB0
	// [XID] // 0x0000000189B1A6D0-0x0000000189B1A6F0
	private void Refresh(bool setup = false /* Metadata: 0x00B0EB71 */) {} // 0x000000018166D250-0x000000018166D3A0
	// [XID] // 0x0000000189B21CC0-0x0000000189B21CE0
	private void HandleIndexIndicator() {} // 0x0000000181671150-0x00000001816712B0
	// [XID] // 0x0000000189B29380-0x0000000189B293A0
	private void RefreshBalloon() {} // 0x000000018166E4A0-0x000000018166EA80
	// [XID] // 0x0000000189B30790-0x0000000189B307B0
	private void RefreshBalloonItem(Transform trans, int index) {} // 0x000000018166EDB0-0x000000018166F010
	// [XID] // 0x0000000189B38030-0x0000000189B38050
	private void OnBalloonSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x000000018166E110-0x000000018166E2C0
	// [XID] // 0x0000000189B3FA60-0x0000000189B3FA80
	private void RefreshFall() {} // 0x00000001816704E0-0x0000000181670A30
	// [XID] // 0x0000000189B47280-0x0000000189B472A0
	private void RefreshMusic() {} // 0x000000018166F930-0x000000018166FF30
	// [XID] // 0x0000000189B4EAA0-0x0000000189B4EAC0
	private void RefreshRightPanel() {} // 0x00000001816712B0-0x00000001816718B0
	// [XID] // 0x0000000189B562A0-0x0000000189B562C0
	private string GetRewardRank(FleurFairMiniGameExcelConfig excelData, int index) => default; // 0x000000018166DE40-0x000000018166DF90
	// [XID] // 0x0000000189B5DAC0-0x0000000189B5DAE0
	private string GetAvatarScoreTextMap(int avatarLevelIdx) => default; // 0x000000018166D9B0-0x000000018166DAC0
	// [XID] // 0x0000000189B65040-0x0000000189B65060
	private ActivityWatcherInfo GetWatcherInfo(uint watcherID) => default; // 0x00000001816722E0-0x00000001816724D0
	// [XID] // 0x0000000189B6C620-0x0000000189B6C640
	private void OnClickTakeReward(uint watcherID) {} // 0x000000018166F160-0x000000018166F280
	// [XID] // 0x0000000189B73DB0-0x0000000189B73DD0
	private void OnClickRewardDetail() {} // 0x000000018166DF90-0x000000018166E0B0
	// [XID] // 0x0000000189B7B420-0x0000000189B7B440
	private void OnPrevBtnClick() {} // 0x000000018166D540-0x000000018166D680
	// [XID] // 0x0000000189B82D40-0x0000000189B82D60
	private void OnNextBtnClick() {} // 0x000000018166D3A0-0x000000018166D4E0
	// [XID] // 0x0000000189B8A380-0x0000000189B8A3A0
	private void OnClickGoto() {} // 0x000000018166FF90-0x0000000181670040
	// [XID] // 0x0000000189B91980-0x0000000189B919A0
	public static void OnGotoTrack(EFleurFairMiniGame gameType, uint gameID) {} // 0x0000000181670FC0-0x0000000181671150
	// [XID] // 0x0000000189B98D40-0x0000000189B98D60
	public static void OnTrack(uint gameID) {} // 0x0000000181670A30-0x0000000181670FC0
	// [XID] // 0x0000000189BA0160-0x0000000189BA0180
	public static void RemoveMarks() {} // 0x0000000181671B30-0x0000000181671E30
	// [XID] // 0x0000000189BA79A0-0x0000000189BA79C0
	private static void OnOpenMapPage(uint gameID) {} // 0x000000018166F010-0x000000018166F160
	// [XID] // 0x0000000189BAED30-0x0000000189BAED50
	private void HandleBtnStates() {} // 0x00000001816718B0-0x0000000181671B30
	// [XID] // 0x0000000189BB6420-0x0000000189BB6440
	private void SetButtonState(Button btn, bool isEnable) {} // 0x00000001816701D0-0x00000001816703D0
	// [XID] // 0x0000000189BBDA60-0x0000000189BBDA80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018166F2E0-0x000000018166F930
	// [XID] // 0x0000000189BC5760-0x0000000189BC5780
	private void HandleJoyPadBtns() {} // 0x000000018166DAC0-0x000000018166DD90
	// [XID] // 0x0000000189BCD1C0-0x0000000189BCD1E0
	private void HandleLeftSelect() {} // 0x000000018166E2C0-0x000000018166E4A0
	// [XID] // 0x0000000189BD46C0-0x0000000189BD46E0
	private void OnChangeAvatarSelect(bool clear = false /* Metadata: 0x00B0EB72 */) {} // 0x00000001816703D0-0x00000001816704E0
	// [XID] // 0x0000000189BDC230-0x0000000189BDC250
	private void OnLeftScroll(PointerEventData eventData) {} // 0x0000000181670040-0x00000001816701D0
}

