/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class USpiderDialogContext : BaseDialogContext // TypeDefIndex: 28383
{
	// Fields
	private Button bt; // 0x178
	private Button closeButton; // 0x180
	private Button saveButton; // 0x188
	private Button screenshotButton; // 0x190
	private Button videoButton; // 0x198
	private Button saveAndCloseButton; // 0x1A0
	private InputField userNameInputField; // 0x1A8
	private InputField serverAddressInputField; // 0x1B0
	private InputField fpsInputField; // 0x1B8
	private InputField videoTimeInputField; // 0x1C0
	private InputField title; // 0x1C8
	private InputField description; // 0x1D0
	private Toggle pcToggle; // 0x1D8
	private Toggle exceptionToggle; // 0x1E0
	private Toggle errorToggle; // 0x1E8
	private Toggle warningToggle; // 0x1F0
	private Toggle assertToggle; // 0x1F8
	private Toggle profileToggle; // 0x200
	private Toggle videoToggle; // 0x208
	private Toggle lowFpsToggle; // 0x210
	private Toggle descriptToggle; // 0x218
	private USpiderSetting setting; // 0x220
	private float lastClickTime; // 0x228

	// Constructors
	public USpiderDialogContext() {} // 0x000000018409E650-0x000000018409E750

	// Methods
	// [XID] // 0x0000000189617040-0x0000000189617060
	public override void SetupView() {} // 0x000000018409E490-0x000000018409E650
	// [XID] // 0x000000018961EBC0-0x000000018961EBE0
	public override void ClearView() {} // 0x000000018409C720-0x000000018409C8F0
	// [XID] // 0x0000000189625FE0-0x0000000189626000
	public void initValues() {} // 0x000000018409CBF0-0x000000018409CF70
	// [XID] // 0x000000018962D980-0x000000018962D9A0
	public void initBinds() {} // 0x000000018409B590-0x000000018409C2C0
	// [XID] // 0x0000000189635500-0x0000000189635520
	public void clearBinds() {} // 0x000000018409D220-0x000000018409D3F0
	// [XID] // 0x000000018963CC20-0x000000018963CC40
	public void StartQAModules() {} // 0x000000018409E3B0-0x000000018409E490
	// [XID] // 0x0000000189644220-0x0000000189644240
	public void StopQAModules() {} // 0x000000018409E1B0-0x000000018409E290
	// [XID] // 0x000000018964B9B0-0x000000018964B9D0
	private void toggleSettingDialog() {} // 0x000000018409DC10-0x000000018409DDA0
	// [XID] // 0x0000000189653160-0x0000000189653180
	public void onClick(GameObject sender) {} // 0x000000018409D7C0-0x000000018409D9F0
	// [XID] // 0x000000018965A820-0x000000018965A840
	public void OnBtClick(GameObject sender) {} // 0x000000018409C3E0-0x000000018409C690
	// [XID] // 0x0000000189661E90-0x0000000189661EB0
	public void onCloseClick(GameObject sender) {} // 0x000000018409CA10-0x000000018409CBF0
	// [XID] // 0x0000000189669A10-0x0000000189669A30
	public void onLogSettingToggleChange(GameObject sender, bool isChecked) {} // 0x000000018409B2C0-0x000000018409B590
	// [XID] // 0x00000001896715E0-0x0000000189671600
	public void onScreenRecorderSettingEndEdit(GameObject sender, string input) {} // 0x000000018409CF70-0x000000018409D190
	// [XID] // 0x0000000189678E20-0x0000000189678E40
	public void onSettingEndEdit(GameObject sender, string input) {} // 0x000000018409D9F0-0x000000018409DB80
	// [XID] // 0x00000001896805F0-0x0000000189680610
	public void onScreenshotSettingToggleChange(GameObject sender, bool isChecked) {} // 0x000000018409DEB0-0x000000018409E090
}

