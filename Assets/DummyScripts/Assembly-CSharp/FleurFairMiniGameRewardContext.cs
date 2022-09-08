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

public sealed class FleurFairMiniGameRewardContext : BaseDialogContext // TypeDefIndex: 29082
{
	// Fields
	private MonoFleurFairMiniGameRewardDialog _dialogMono; // 0x178
	private ActivityInfo _activityInfo; // 0x180
	private int _curLevelIndex; // 0x188
	private EFleurFairMiniGame _miniGameType; // 0x18C
	private List<uint> _level_ids; // 0x190
	private uint _curGameId; // 0x198
	private List<RewardItemConfig> _currRewardList; // 0x1A0
	private List<uint> _watcherList; // 0x1A8

	// Constructors
	public FleurFairMiniGameRewardContext() {} // Dummy constructor
	public FleurFairMiniGameRewardContext(EFleurFairMiniGame miniGameType, int levelIndex) {} // 0x0000000181654EA0-0x00000001816550D0

	// Methods
	// [XID] // 0x00000001896BFE50-0x00000001896BFE70
	public override void SetupView() {} // 0x0000000181654DD0-0x0000000181654EA0
	// [XID] // 0x00000001896C7750-0x00000001896C7770
	protected override void BindViewCallbacks() {} // 0x0000000181653920-0x0000000181653A40
	// [XID] // 0x00000001896CEEF0-0x00000001896CEF10
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181654AC0-0x0000000181654BE0
	// [XID] // 0x00000001896D62F0-0x00000001896D6310
	private void UpdateActivity(uint activityId) {} // 0x00000001816547D0-0x00000001816548F0
	// [XID] // 0x00000001896DD910-0x00000001896DD930
	private void Refresh() {} // 0x00000001816532C0-0x0000000181653720
	// [XID] // 0x00000001896E4FC0-0x00000001896E4FE0
	private void RefreshMissionRow(Transform trans, int index) {} // 0x00000001816541D0-0x00000001816547D0
	// [XID] // 0x00000001896EC460-0x00000001896EC480
	private void OnClickTakeReward(uint watcherID) {} // 0x0000000181653D90-0x0000000181653EB0
	// [XID] // 0x00000001896F3C10-0x00000001896F3C30
	private ActivityWatcherInfo GetWatcherInfo(uint watcherID) => default; // 0x0000000181654BE0-0x0000000181654DD0
	// [XID] // 0x00000001896FB380-0x00000001896FB3A0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000181653AE0-0x0000000181653D00
	// [XID] // 0x0000000189702B10-0x0000000189702B30
	private void CheckJoypadBtns() {} // 0x0000000181653720-0x0000000181653920
	// [XID] // 0x000000018970A250-0x000000018970A270
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EB73 */) {} // 0x0000000181654980-0x0000000181654AC0
	// [XID] // 0x0000000189711D30-0x0000000189711D50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181653F10-0x0000000181654170
}

