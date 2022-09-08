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

public sealed class ActivitySubpage_MistTrial : BaseSubPageContext // TypeDefIndex: 30279
{
	// Fields
	private ActivityInfo _activityInfo; // 0x178
	private MonoActivityMistTrial _pageMono; // 0x180
	private uint _activityID; // 0x188
	private List<ulong> _avatarConfigIdList; // 0x190
	private MonoJoypadGridScrollerHandler _scrollerHandler; // 0x198
	private List<ActivityMistTrialLevelDataExcelConfig> _levelList; // 0x1A0

	// Constructors
	public ActivitySubpage_MistTrial() {} // Dummy constructor
	public ActivitySubpage_MistTrial(uint activityID, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000181F4EEE0-0x0000000181F4F000

	// Methods
	// [XID] // 0x0000000189BBA9C0-0x0000000189BBA9E0
	public override void SetupView() {} // 0x0000000181F4EC60-0x0000000181F4EEE0
	// [XID] // 0x0000000189BC29E0-0x0000000189BC2A00
	protected override void OnEnable() {} // 0x0000000181F4EA70-0x0000000181F4EB70
	// [XID] // 0x0000000189BCA1A0-0x0000000189BCA1C0
	public override void ClearView() {} // 0x0000000181F4D020-0x0000000181F4D0D0
	// [XID] // 0x0000000189BD17F0-0x0000000189BD1810
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181F4EB70-0x0000000181F4EC60
	// [XID] // 0x0000000189BD8DC0-0x0000000189BD8DE0
	private void Refresh() {} // 0x0000000181F4CA00-0x0000000181F4CAB0
	// [XID] // 0x00000001895E59C0-0x00000001895E59E0
	private void RefreshTitleAndTime() {} // 0x0000000181F4E680-0x0000000181F4E810
	// [XID] // 0x00000001895ED2F0-0x00000001895ED310
	private void RefreshLevelPanels() {} // 0x0000000181F4CB30-0x0000000181F4CD40
	// [XID] // 0x00000001895F49B0-0x00000001895F49D0
	private void OnValueChangeCallback(Vector2 normalizedPosition) {} // 0x0000000181F4E3D0-0x0000000181F4E680
	// [XID] // 0x00000001895FC0E0-0x00000001895FC100
	private void InitLevelPanel(Transform trans, int index) {} // 0x0000000181F4D130-0x0000000181F4D4D0
	// [XID] // 0x0000000189603AE0-0x0000000189603B00
	private void OnLevelPanelClick(MonoActivityMistTrialDungeonEntry monoPanel, int levelID) {} // 0x0000000181F4E170-0x0000000181F4E3D0
	// [XID] // 0x000000018960B440-0x000000018960B460
	protected override void BindViewCallbacks() {} // 0x0000000181F4CD40-0x0000000181F4CEA0
	// [XID] // 0x0000000189612810-0x0000000189612830
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000181F4DEC0-0x0000000181F4E170
	// [XID] // 0x000000018961A1A0-0x000000018961A1C0
	private void OnBtnGotoClick() {} // 0x0000000181F4D560-0x0000000181F4D630
	// [XID] // 0x0000000189621690-0x00000001896216B0
	private void OnDescButtonClick() {} // 0x0000000181F4DD60-0x0000000181F4DEC0
	// [XID] // 0x0000000189628FC0-0x0000000189628FE0
	private void OnBtnCheckAvatarClick() {} // 0x0000000181F4D630-0x0000000181F4DA30
	// [XID] // 0x0000000189630940-0x0000000189630960
	private void RemoveFakeDataFromDataItemManager() {} // 0x0000000181F4CEA0-0x0000000181F4D020
	// [XID] // 0x00000001896383E0-0x0000000189638400
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181F4DA90-0x0000000181F4DD00
}

