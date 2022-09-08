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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengeDifficultyDialogContext : BaseDialogContext // TypeDefIndex: 30097
{
	// Fields
	private MonoArenaChallengeDifficultyDialog _pageMono; // 0x178
	private uint _entityId; // 0x180
	private uint _levelId; // 0x184
	private uint _diffId; // 0x188
	private Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> _arenaLevelConfigDic; // 0x190
	private Dictionary<uint, List<ActivityArenaChallengeExcelConfig>> _arenaWatcherInfoDic; // 0x198
	private Dictionary<uint, ActivityWatcherInfo> _activityWatcherDic; // 0x1A0
	private List<MonoUIContainer> _levelPanelList; // 0x1A8
	private List<UnityEngine.UI.Text> _condTextList; // 0x1B0
	private RepeatedMessageField<ArenaChallengeMonsterLevel> _recommendLevelList; // 0x1B8

	// Constructors
	public ArenaChallengeDifficultyDialogContext() {} // Dummy constructor
	public ArenaChallengeDifficultyDialogContext(uint levelId, uint entityId) {} // 0x0000000181A33F40-0x0000000181A34060

	// Methods
	// [XID] // 0x00000001897D4BA0-0x00000001897D4BC0
	public override void SetupView() {} // 0x0000000181A33AF0-0x0000000181A33F40
	// [XID] // 0x00000001897DC240-0x00000001897DC260
	public override void ClearView() {} // 0x0000000181A324F0-0x0000000181A32590
	// [XID] // 0x00000001897E3B90-0x00000001897E3BB0
	private void Refresh() {} // 0x0000000181A320E0-0x0000000181A32190
	// [XID] // 0x00000001897EB820-0x00000001897EB840
	private void RefreshTitleAndRecommonLevel() {} // 0x0000000181A33180-0x0000000181A332D0
	// [XID] // 0x00000001897F30A0-0x00000001897F30C0
	private void RefreshLevelPanels() {} // 0x0000000181A32190-0x0000000181A32250
	// [XID] // 0x00000001897FA930-0x00000001897FA950
	private void RefreshDiffPanelById(uint diffId) {} // 0x0000000181A32590-0x0000000181A32AA0
	// [XID] // 0x0000000189801F60-0x0000000189801F80
	private void RefreshConditions(uint diffId) {} // 0x0000000181A33450-0x0000000181A33980
	// [XID] // 0x00000001898093B0-0x00000001898093D0
	protected override void BindViewCallbacks() {} // 0x0000000181A32250-0x0000000181A324F0
	// [XID] // 0x0000000189810BC0-0x0000000189810BE0
	private void OnDiffBtnClick(uint diffId) {} // 0x0000000181A32F70-0x0000000181A33180
	// [XID] // 0x0000000189818690-0x00000001898186B0
	private void OnBtnCancelClick() {} // 0x0000000181A332D0-0x0000000181A33380
	// [XID] // 0x000000018981FEE0-0x000000018981FF00
	private void OnBtnGotoClick() {} // 0x0000000181A32B30-0x0000000181A32C60
	// [XID] // 0x00000001898274A0-0x00000001898274C0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181A33A10-0x0000000181A33AF0
	// [XID] // 0x000000018982E720-0x000000018982E740
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181A32CC0-0x0000000181A32E30
}

