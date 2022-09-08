/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GeneralPermissionDialogContext : BaseDialogContext // TypeDefIndex: 28722
{
	// Fields
	public string title; // 0x178
	public string desc; // 0x180
	public string okBtnText; // 0x188
	public string cancelBtnText; // 0x190
	public Action<bool> buttonCallBack; // 0x198
	private MonoGeneralPermissionDialog _dialogMono; // 0x1A0
	private GeneralPermissionDialogType _type; // 0x1A8
	private Action _onUpdate; // 0x1B0

	// Nested types
	public enum GeneralPermissionDialogType // TypeDefIndex: 28723
	{
		DOUBLE_BUTTON = 0,
		SINGLE_BUTTON = 1
	}

	public enum DialogType // TypeDefIndex: 28724
	{
		REQUEST = 0,
		SECOND_REQUEST = 1,
		DONT_ASK_AGAIN = 2
	}

	// Constructors
	public GeneralPermissionDialogContext() {} // Dummy constructor
	public GeneralPermissionDialogContext(GeneralPermissionDialogType type = GeneralPermissionDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E5CC */, UIType uiType = UIType.Dialog /* Metadata: 0x00B0E5D0 */) {} // 0x0000000183FB9900-0x0000000183FB9A10

	// Methods
	// [XID] // 0x000000018979B620-0x000000018979B640
	public override void SetupView() {} // 0x0000000183FB94B0-0x0000000183FB9850
	// [XID] // 0x00000001897A2AC0-0x00000001897A2AE0
	public void UpdateDescText(string desc) {} // 0x0000000183FB9190-0x0000000183FB92A0
	// [XID] // 0x00000001897AA0A0-0x00000001897AA0C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183FB8D30-0x0000000183FB8E30
	// [XID] // 0x00000001897B1A70-0x00000001897B1A90
	protected override void BindViewCallbacks() {} // 0x0000000183FB8960-0x0000000183FB8AF0
	// [XID] // 0x00000001897B9490-0x00000001897B94B0
	public void OnOKButtonCallBack() {} // 0x0000000183FB8BA0-0x0000000183FB8C40
	// [XID] // 0x00000001897C14E0-0x00000001897C1500
	public void OnCancelButtonCallBack() {} // 0x0000000183FB8F50-0x0000000183FB8FF0
	// [XID] // 0x00000001897C8F40-0x00000001897C8F60
	public void OnBGClick(BaseEventData evtData = null) {} // 0x0000000183FB8FF0-0x0000000183FB90B0
	// [XID] // 0x00000001897D05A0-0x00000001897D05C0
	private void OnButtonClick(bool isOk) {} // 0x0000000183FB90B0-0x0000000183FB9190
	// [XID] // 0x00000001897D8300-0x00000001897D8320
	public void RegisterUpdate(Action action) {} // 0x0000000183FB88B0-0x0000000183FB8960
	// [XID] // 0x00000001897DF380-0x00000001897DF3A0
	public override void UpdateView() {} // 0x0000000183FB9850-0x0000000183FB9900
	// [XID] // 0x00000001897E6C40-0x00000001897E6C60
	public void UpdateCancelButtonText(string text) {} // 0x0000000183FB9300-0x0000000183FB9450
	// [XID] // 0x00000001897EE850-0x00000001897EE870
	public override void Destroy() {} // 0x0000000183FB8AF0-0x0000000183FB8BA0
}

