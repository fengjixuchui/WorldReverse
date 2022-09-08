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

public sealed class CodexWeaponScreenDialogContext : BaseDialogContext // TypeDefIndex: 28528
{
	// Fields
	private List<CodexModule.CodexWeaponData> _screenList; // 0x178
	private MonoCodexWeaponScreenDialog _dialogMono; // 0x180
	private List<string> _weaponNameList; // 0x188
	private List<string> _rankNameList; // 0x190
	private List<string> _lockNameList; // 0x198
	private Dictionary<string, bool> _screenWeaponFlagDictionary; // 0x1A0
	private Dictionary<string, bool> _screenRankFlagDictionary; // 0x1A8
	private Dictionary<string, bool> _screenLockFlagDictionary; // 0x1B0
	private Dictionary<string, bool> _screenWeaponLastFlagDictionary; // 0x1B8
	private Dictionary<string, bool> _screenRankLastFlagDictionary; // 0x1C0
	private Dictionary<string, bool> _screenLockLastFlagDictionary; // 0x1C8
	private bool _isScreened; // 0x1D0
	private List<string> _screenNameList; // 0x1D8
	private int _lastScreenNameListCount; // 0x1E0
	private bool _isOn; // 0x1E4
	private CodexEquipPageContext _parentContext; // 0x1E8
	private const int INPUT_STATE_PARENT_INVALID = 101; // Metadata: 0x00B0D8F6

	// Properties
	public bool isScreened { /* [XID] */ /* 0x0000000189B175C0-0x0000000189B175E0 */ get => default; } // 0x0000000184797280-0x0000000184797330 
	public CodexEquipPageContext parentContext { /* [XID] */ /* 0x0000000189B1EEA0-0x0000000189B1EEC0 */ get => default; /* [XID] */ /* 0x0000000189B26810-0x0000000189B26830 */ set {} } // 0x0000000184798170-0x0000000184798220 0x00000001847985B0-0x0000000184798660

	// Constructors
	public CodexWeaponScreenDialogContext() {} // 0x000000018479B2B0-0x000000018479B530

	// Methods
	// [XID] // 0x0000000189B2DA20-0x0000000189B2DA40
	public override void SetupView() {} // 0x000000018479AC40-0x000000018479B2B0
	// [XID] // 0x0000000189B34E40-0x0000000189B34E60
	public override void ClearView() {} // 0x0000000184796710-0x00000001847967B0
	// [XID] // 0x0000000189B3C710-0x0000000189B3C730
	protected override void BindViewCallbacks() {} // 0x0000000184796550-0x0000000184796710
	// [XID] // 0x0000000189B44410-0x0000000189B44430
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184798280-0x0000000184798380
	// [XID] // 0x0000000189B4BAE0-0x0000000189B4BB00
	public override void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0D8F2 */) {} // 0x000000018479AA70-0x000000018479ABA0
	// [XID] // 0x0000000189B53050-0x0000000189B53070
	private void SetSimpleResuableList(MonoSimpleReusableList scroller, int num) {} // 0x0000000184796DB0-0x0000000184796F70
	// [XID] // 0x0000000189B5AA00-0x0000000189B5AA20
	private int GetFixSideItemCount(MonoSimpleReusableList scroller) => default; // 0x0000000184795BD0-0x0000000184795DA0
	// [XID] // 0x0000000189B61E90-0x0000000189B61EB0
	private void RefreshRankScreenItem(Transform trans, int index) {} // 0x000000018479A150-0x000000018479A3D0
	// [XID] // 0x0000000189B69B40-0x0000000189B69B60
	private void RefreshWeaponScreenItem(Transform trans, int index) {} // 0x0000000184799850-0x0000000184799AD0
	// [XID] // 0x0000000189B710E0-0x0000000189B71100
	private void RefreshLockScreenItem(Transform trans, int index) {} // 0x0000000184797000-0x0000000184797280
	// [XID] // 0x0000000189B786B0-0x0000000189B786D0
	private void RefreshLastRankScreenItem(Transform trans, int index) {} // 0x000000018479A680-0x000000018479A8D0
	// [XID] // 0x0000000189B7FC70-0x0000000189B7FC90
	private void RefreshLastWeaponScreenItem(Transform trans, int index) {} // 0x000000018479A3D0-0x000000018479A620
	// [XID] // 0x0000000189B876E0-0x0000000189B87700
	private void RefreshLastLockScreenItem(Transform trans, int index) {} // 0x0000000184799AD0-0x0000000184799D20
	// [XID] // 0x0000000189B8E850-0x0000000189B8E870
	private void RefreshRankScreenItemState(Transform trans, int index) {} // 0x00000001847967B0-0x0000000184796930
	// [XID] // 0x0000000189B95D30-0x0000000189B95D50
	private void RefreshWeaponScreenItemState(Transform trans, int index) {} // 0x0000000184799FD0-0x000000018479A150
	// [XID] // 0x0000000189B9D270-0x0000000189B9D290
	private void RefreshLockScreenItemState(Transform trans, int index) {} // 0x0000000184798E40-0x0000000184798FC0
	// [XID] // 0x0000000189BA4C30-0x0000000189BA4C50
	private void RefreshScreenNameList() {} // 0x0000000184798FC0-0x0000000184799550
	// [XID] // 0x0000000189BABF50-0x0000000189BABF70
	private void RefreshScreenNameListItem(Transform trans, int index) {} // 0x0000000184799E80-0x0000000184799FD0
	// [XID] // 0x0000000189BB3600-0x0000000189BB3620
	private void InitialRankNameList() {} // 0x00000001847996D0-0x0000000184799850
	// [XID] // 0x0000000189BBAC20-0x0000000189BBAC40
	private void InitialWeaponNameList() {} // 0x0000000184799550-0x00000001847996D0
	// [XID] // 0x0000000189BC2BF0-0x0000000189BC2C10
	private void InitialLockNameList() {} // 0x0000000184795350-0x0000000184795450
	// [XID] // 0x0000000189BCA300-0x0000000189BCA320
	private void InitialRankFlagDictionary() {} // 0x0000000184797330-0x00000001847975C0
	// [XID] // 0x0000000189BD1990-0x0000000189BD19B0
	private void InitialWeaponFlagDictionary() {} // 0x0000000184796B20-0x0000000184796DB0
	// [XID] // 0x0000000189BD8F80-0x0000000189BD8FA0
	private void InitialLockFlagDictionary() {} // 0x0000000184797FE0-0x0000000184798170
	// [XID] // 0x00000001895E5B00-0x00000001895E5B20
	private void OnScreenRankToggleChanged(bool on, string text) {} // 0x0000000184796010-0x0000000184796170
	// [XID] // 0x00000001895ED470-0x00000001895ED490
	private void OnScreenWeaponToggleChanged(bool on, string text) {} // 0x0000000184799D20-0x0000000184799E80
	// [XID] // 0x00000001895F4B70-0x00000001895F4B90
	private void OnScreenLockToggleChanged(bool on, string text) {} // 0x0000000184796170-0x0000000184796550
	// [XID] // 0x00000001895FC2C0-0x00000001895FC2E0
	public void OnClose() {} // 0x0000000184797DD0-0x0000000184797FE0
	// [XID] // 0x0000000189603C80-0x0000000189603CA0
	public void OnParentClose() {} // 0x000000018479A8D0-0x000000018479AA70
	// [XID] // 0x000000018960B5C0-0x000000018960B5E0
	private void OnReset() {} // 0x0000000184795DA0-0x0000000184796010
	// [XID] // 0x00000001896129F0-0x0000000189612A10
	private void OnReturn() {} // 0x00000001847975C0-0x0000000184797CC0
	// [XID] // 0x000000018961A320-0x000000018961A340
	private void OnScreenBtnClick() {} // 0x0000000184795450-0x0000000184795BD0
	// [XID] // 0x0000000189621890-0x00000001896218B0
	private bool GetScreenDicState(Dictionary<string, bool> dic) => default; // 0x0000000184796930-0x0000000184796B20
	// [XID] // 0x0000000189629120-0x0000000189629140
	private void RefreshParentActionBtn(bool active) {} // 0x0000000184797CC0-0x0000000184797DD0
	// [XID] // 0x0000000189630AC0-0x0000000189630AE0
	public void SetFadeInTrigger() {} // 0x0000000184798660-0x0000000184798E40
}

