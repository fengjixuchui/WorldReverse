/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LanternRiteEntrustPageContext : BasePageContext // TypeDefIndex: 29686
{
	// Fields
	private MonoLanternRiteEntrustPage _pageMono; // 0x190
	private MonoJoypadSimpleResuableListHandler _taskListHandler; // 0x198
	private MonoJoypadItemNavigator _lanternListHandler; // 0x1A0
	private bool _taskIsFocus; // 0x1A8
	private ActivityInfo _activityInfo; // 0x1B0
	private SeaLampSectionExcelConfig _sectionData; // 0x1B8
	private List<RewardItemConfig> _tempRewardList; // 0x1C0
	private List<uint> _finishedQuestList; // 0x1C8
	private List<uint> _unFinishedQuestList; // 0x1D0
	private List<uint> _delayFinishedQuestList; // 0x1D8
	private List<uint> _unFinishedOpendQuestList; // 0x1E0
	private MonoSimpleReusableList _taskList; // 0x1E8
	private MonoUIContainer[] _lanternList; // 0x1F0
	private int _curStage; // 0x1F8
	private Animator _tab0Animator; // 0x200
	private bool _canAccept; // 0x208

	// Constructors
	public LanternRiteEntrustPageContext() {} // 0x00000001819530E0-0x00000001819532D0

	// Methods
	// [XID] // 0x0000000189AB28C0-0x0000000189AB28E0
	public override void SetupView() {} // 0x0000000181952F90-0x00000001819530E0
	// [XID] // 0x0000000189ABA3F0-0x0000000189ABA410
	public override void ClearView() {} // 0x000000018194DA90-0x000000018194DC00
	// [XID] // 0x0000000189AC1D40-0x0000000189AC1D60
	protected override void BindRedPoints() {} // 0x000000018194D520-0x000000018194D660
	// [XID] // 0x0000000189AC92F0-0x0000000189AC9310
	protected override void BindViewCallbacks() {} // 0x000000018194D660-0x000000018194D930
	// [XID] // 0x0000000189AD0DC0-0x0000000189AD0DE0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181952680-0x00000001819527A0
	// [XID] // 0x0000000189AD89F0-0x0000000189AD8A10
	private void CheckButtonState() {} // 0x00000001819517E0-0x00000001819519A0
	// [XID] // 0x0000000189AE05C0-0x0000000189AE05E0
	private void CheckPreNextState() {} // 0x000000018194D290-0x000000018194D4C0
	// [XID] // 0x0000000189AE7B30-0x0000000189AE7B50
	protected override void OnEnable() {} // 0x0000000181951BD0-0x0000000181951DC0
	[DebuggerHidden] // 0x0000000189AEF870-0x0000000189AEF8B0
	// [XID] // 0x0000000189AEF870-0x0000000189AEF8B0
	private IEnumerator PlayUnlockAnim() => default; // 0x00000001819514E0-0x00000001819515F0
	[DebuggerHidden] // 0x0000000189AF9EC0-0x0000000189AF9F00
	// [XID] // 0x0000000189AF9EC0-0x0000000189AF9F00
	private IEnumerator PlayMiniQuestFinishedAnim(uint miniQuestId) => default; // 0x000000018194E610-0x000000018194E730
	[DebuggerHidden] // 0x0000000189B041D0-0x0000000189B04210
	// [XID] // 0x0000000189B041D0-0x0000000189B04210
	private IEnumerator PlayFinishedAnim() => default; // 0x000000018194E1A0-0x000000018194E2B0
	// [XID] // 0x0000000189B0E950-0x0000000189B0E970
	private void RefreshView(int dir = 0 /* Metadata: 0x00B0FC89 */, bool showAnim = true /* Metadata: 0x00B0FC8D */) {} // 0x000000018194EA70-0x0000000181950B50
	// [XID] // 0x0000000189B15D40-0x0000000189B15D60
	private void RefreshProgressItems(Transform trans, int index) {} // 0x00000001819519A0-0x0000000181951AE0
	// [XID] // 0x0000000189B1D450-0x0000000189B1D470
	private void RefreshRewardItems(Transform trans, int index) {} // 0x000000018194DC00-0x000000018194DE50
	// [XID] // 0x0000000189B24CD0-0x0000000189B24CF0
	private void OnLanternClick(uint questId) {} // 0x000000018194D930-0x000000018194DA90
	// [XID] // 0x0000000189B2C140-0x0000000189B2C160
	public static SeaLampSectionMiniQuestExcelConfig GetMiniQuestInfo(uint questId) => default; // 0x00000001819512E0-0x00000001819514E0
	// [XID] // 0x0000000189B33730-0x0000000189B33750
	private void RefreshTaskItems(Transform trans, int index) {} // 0x0000000181950BB0-0x00000001819512E0
	// [XID] // 0x0000000189B3B030-0x0000000189B3B050
	private void OnTaskPoint(uint miniQuestId) {} // 0x000000018194DE50-0x000000018194E0C0
	// [XID] // 0x0000000189B42830-0x0000000189B42850
	private void OnSwitchPrev() {} // 0x000000018194E550-0x000000018194E610
	// [XID] // 0x0000000189B4A350-0x0000000189B4A370
	private void OnSwitchNext() {} // 0x000000018194E3E0-0x000000018194E4D0
	// [XID] // 0x0000000189B51AF0-0x0000000189B51B10
	private void OnGotoButton() {} // 0x00000001819515F0-0x00000001819517E0
	// [XID] // 0x0000000189B59270-0x0000000189B59290
	private void OnCollectButton() {} // 0x0000000181952840-0x0000000181952F90
	// [XID] // 0x0000000189B60B40-0x0000000189B60B60
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018194E790-0x000000018194EA70
	// [XID] // 0x0000000189B681F0-0x0000000189B68210
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000181951F90-0x00000001819521B0
	// [XID] // 0x0000000189B6F590-0x0000000189B6F5B0
	public override void OnJoypadUIModuleLostFocus(MonoJoypadUIModule focusModule) {} // 0x00000001819521B0-0x00000001819524B0
	// [XID] // 0x0000000189B76C10-0x0000000189B76C30
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0FC8E */) {} // 0x00000001819524B0-0x0000000181952680
	// [XID] // 0x0000000189B7E180-0x0000000189B7E1A0
	public override void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0FC92 */) {} // 0x0000000181951DC0-0x0000000181951F90
}

