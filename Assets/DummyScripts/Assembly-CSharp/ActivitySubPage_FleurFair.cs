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

public sealed class ActivitySubPage_FleurFair : BaseSubPageContext // TypeDefIndex: 29393
{
	// Fields
	private MonoActivityFleurFair _pageMono; // 0x178
	private ActivityInfo _activityInfo; // 0x180
	private uint _activityID; // 0x188
	private FleurFairPreviewExcelConfig _previewConfigData; // 0x190
	private uint _activityCloseTime; // 0x198
	private List<IdCountStrConfig> _rewardPreviewList; // 0x1A0
	private const uint PREVIEW_DATA_EXCEL_CONFIG_ID = 1; // Metadata: 0x00B0F6DB
	private const int REWARD_ITEM_COUNT = 1; // Metadata: 0x00B0F6DF
	private InputState _inputState; // 0x1A8
	private List<MonoUIContainer> _selectButtonList; // 0x1B0
	private List<Action> _selectButtonClickAction; // 0x1B8
	private int _currentSelectIndex; // 0x1C0

	// Nested types
	private enum InputState // TypeDefIndex: 29394
	{
		Invalid = 0,
		BeforeGameplay = 1,
		OnGameplay = 2
	}

	// Constructors
	public ActivitySubPage_FleurFair() {} // Dummy constructor
	public ActivitySubPage_FleurFair(uint activityID, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000182367750-0x0000000182367930

	// Methods
	// [XID] // 0x00000001899BC230-0x00000001899BC250
	private void InitActivityCloseTime() {} // 0x00000001823662F0-0x00000001823663E0
	// [XID] // 0x00000001899C3C70-0x00000001899C3C90
	protected override void BindViewCallbacks() {} // 0x0000000182363C00-0x0000000182363F40
	// [XID] // 0x00000001899CB370-0x00000001899CB390
	private void OnClickBtnShop() {} // 0x0000000182363920-0x0000000182363A60
	// [XID] // 0x00000001899D28A0-0x00000001899D28C0
	public override void SetupView() {} // 0x0000000182367540-0x00000001823676A0
	// [XID] // 0x00000001899D9FB0-0x00000001899D9FD0
	protected override void BindRedPoints() {} // 0x0000000182363A60-0x0000000182363C00
	// [XID] // 0x00000001899E1890-0x00000001899E18B0
	public override void ClearView() {} // 0x0000000182364080-0x0000000182364190
	// [XID] // 0x00000001899E8E40-0x00000001899E8E60
	public override void UpdateView() {} // 0x00000001823676A0-0x0000000182367750
	// [XID] // 0x00000001899F07C0-0x00000001899F07E0
	protected override void OnEnable() {} // 0x0000000182367190-0x00000001823672F0
	// [XID] // 0x00000001899F7E00-0x00000001899F7E20
	private void OnClickBtnEntrust() {} // 0x00000001823673C0-0x0000000182367540
	// [XID] // 0x00000001899FF4B0-0x00000001899FF4D0
	private void OnClickBtnMiniGames() {} // 0x0000000182366E00-0x0000000182366F60
	// [XID] // 0x0000000189A06CF0-0x0000000189A06D10
	private void OnClickBtnDungeon() {} // 0x0000000182363600-0x0000000182363770
	// [XID] // 0x0000000189A0E3E0-0x0000000189A0E400
	private void OnClickBtnGotoQuest() {} // 0x00000001823666E0-0x00000001823668D0
	// [XID] // 0x0000000189A15960-0x0000000189A15980
	private void Refresh() {} // 0x00000001823631D0-0x0000000182363290
	// [XID] // 0x0000000189A1CE20-0x0000000189A1CE40
	private void RefreshRedPointShow() {} // 0x0000000182366C10-0x0000000182366E00
	// [XID] // 0x0000000189A24360-0x0000000189A24380
	public static bool CheckRedPoint(uint activityID) => default; // 0x0000000182365140-0x0000000182365310
	// [XID] // 0x0000000189A2B820-0x0000000189A2B840
	private void RefreshEntry() {} // 0x0000000182364190-0x0000000182364840
	// [XID] // 0x0000000189A32EA0-0x0000000189A32EC0
	private void RefreshInputState(bool dailyPlayUnlock) {} // 0x0000000182365F30-0x00000001823662F0
	// [XID] // 0x0000000189A3A710-0x0000000189A3A730
	public static bool IsQuestFinished() => default; // 0x0000000182366FC0-0x0000000182367100
	// [XID] // 0x0000000189A42060-0x0000000189A42080
	private static bool IsQuestlocked() => default; // 0x0000000182364B10-0x0000000182364CC0
	// [XID] // 0x0000000189A49610-0x0000000189A49630
	private string GetQuestUnlockDesc() => default; // 0x0000000182364840-0x0000000182364B10
	// [XID] // 0x0000000189A50FA0-0x0000000189A50FC0
	private void RefreshRewardList() {} // 0x0000000182365B00-0x0000000182365DD0
	// [XID] // 0x0000000189A58500-0x0000000189A58520
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000182364D20-0x0000000182365050
	// [XID] // 0x0000000189A5FFC0-0x0000000189A5FFE0
	private void RefreshRemainTime() {} // 0x0000000182363310-0x00000001823634F0
	// [XID] // 0x0000000189A67C20-0x0000000189A67C40
	public override bool OnNotify(Notify ntf) => default; // 0x00000001823672F0-0x00000001823673C0
	// [XID] // 0x0000000189A6F030-0x0000000189A6F050
	private void OnClickDesc() {} // 0x00000001823634F0-0x0000000182363600
	// [XID] // 0x0000000189A76870-0x0000000189A76890
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182365310-0x0000000182365AA0
	// [XID] // 0x0000000189A7E140-0x0000000189A7E160
	private void SelectButton(bool next) {} // 0x0000000182363770-0x00000001823638C0
	// [XID] // 0x0000000189A85AE0-0x0000000189A85B00
	private void RefreshButtonSelectState() {} // 0x00000001823663E0-0x00000001823666E0
	// [XID] // 0x0000000189A8D380-0x0000000189A8D3A0
	private void OnSelectButtonConfirm() {} // 0x0000000182363F40-0x0000000182364080
	// [XID] // 0x0000000189A948C0-0x0000000189A948E0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000182365E30-0x0000000182365F30
	// [XID] // 0x0000000189A9C1E0-0x0000000189A9C200
	private void RefreshParentFocusRelatedUI(bool focusOnParent) {} // 0x00000001823668D0-0x0000000182366C10
}

