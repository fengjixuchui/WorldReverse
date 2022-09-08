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

public sealed class SettingLanguagePackDialogContext : BaseDialogContext // TypeDefIndex: 28973
{
	// Fields
	private MonoSettingLanguagePackDialog _dialogMono; // 0x178
	private ConfigLanguageSetting _languageConfig; // 0x180
	private List<VoiceLanguageType> _curShowingLanguageList; // 0x188
	private List<string> _curShowingLanguageStrList; // 0x190
	private int _curSelectIndex; // 0x198
	private bool _languagePackChanged; // 0x19C
	public Action<bool> packDialogCloseCallBack; // 0x1A0

	// Properties
	private static string LanguageSettingConfigPath { /* [XID] */ /* 0x0000000189BB91F0-0x0000000189BB9210 */ get => default; } // 0x0000000184BD4580-0x0000000184BD4620 

	// Constructors
	public SettingLanguagePackDialogContext() {} // 0x0000000184BD5AB0-0x0000000184BD5BE0

	// Methods
	// [XID] // 0x0000000189BC1000-0x0000000189BC1020
	public override void SetupView() {} // 0x0000000184BD5840-0x0000000184BD5AB0
	// [XID] // 0x0000000189BC8790-0x0000000189BC87B0
	protected override void BindViewCallbacks() {} // 0x0000000184BD4BA0-0x0000000184BD4D10
	// [XID] // 0x0000000189BCFFD0-0x0000000189BCFFF0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184BD4EC0-0x0000000184BD5010
	// [XID] // 0x0000000189BD7610-0x0000000189BD7630
	private void RefreshLanguageScrollListView() {} // 0x0000000184BD5510-0x0000000184BD5840
	// [XID] // 0x0000000189BDF110-0x0000000189BDF130
	private void SetupLanguagePackItem(Transform trans, int index) {} // 0x0000000184BD5070-0x0000000184BD54B0
	// [XID] // 0x00000001895EBD80-0x00000001895EBDA0
	private void OnLanguagePackItemClick(int index) {} // 0x0000000184BD4620-0x0000000184BD47A0
	// [XID] // 0x00000001895F3120-0x00000001895F3140
	private void OnConfirmClick() {} // 0x0000000184BD47A0-0x0000000184BD4BA0
	// [XID] // 0x00000001895FA980-0x00000001895FA9A0
	public override void CloseDialog() {} // 0x0000000184BD4D10-0x0000000184BD4DD0
}

