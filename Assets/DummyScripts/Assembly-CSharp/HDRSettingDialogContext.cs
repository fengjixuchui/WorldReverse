/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HDRSettingDialogContext : BasePageContext // TypeDefIndex: 29130
{
	// Fields
	private MonoHDRSettingDialog _dialogMono; // 0x190
	private bool _isFirstTime; // 0x198
	private bool _isCancel; // 0x199
	private float _tab1Value; // 0x19C
	private float _tab2SceneValue; // 0x1A0
	private float _tab2UIValue; // 0x1A4
	private ConfigHDRSetting _hdrConfig; // 0x1A8
	private uint _prefabHandle; // 0x1B0
	private Action _closeCallBack; // 0x1B8
	private const int TAB1_PAGE = 0; // Metadata: 0x00B0EC69
	private const int TAB2_PAGE = 1; // Metadata: 0x00B0EC6D
	private GameObject _HDRUIManager; // 0x1C0
	private MonoHDRUI _monoHDRUI; // 0x1C8
	private const string HDR_PATH = "ART/UI/UIScene/HDRUIManager"; // Metadata: 0x00B0EC71

	// Constructors
	public HDRSettingDialogContext() {} // Dummy constructor
	public HDRSettingDialogContext(bool isfirstTime = false /* Metadata: 0x00B0EC64 */, Action closeCallBack = null) {} // 0x000000018253B650-0x000000018253B7A0

	// Methods
	// [XID] // 0x0000000189A1CEA0-0x0000000189A1CEC0
	public override void SetupView() {} // 0x000000018253AFC0-0x000000018253B650
	// [XID] // 0x0000000189A243E0-0x0000000189A24400
	private void SaveDataBeforeClosePage() {} // 0x000000018253A0E0-0x000000018253A5B0
	// [XID] // 0x0000000189A2B880-0x0000000189A2B8A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182538C50-0x0000000182539130
	// [XID] // 0x0000000189A32F20-0x0000000189A32F40
	private bool HandleTab2PageActionEvent(InputActionEvent actionEvent) => default; // 0x000000018253A620-0x000000018253AE40
	// [XID] // 0x0000000189A3A790-0x0000000189A3A7B0
	private void SetText() {} // 0x00000001825386B0-0x0000000182538970
	// [XID] // 0x0000000189A420E0-0x0000000189A42100
	private void SetTab1Default() {} // 0x0000000182537760-0x00000001825379D0
	// [XID] // 0x0000000189A49670-0x0000000189A49690
	private void SetTab2Default() {} // 0x0000000182538A00-0x0000000182538B90
	// [XID] // 0x0000000189A51000-0x0000000189A51020
	private void ShowConfirmDialog() {} // 0x00000001825379D0-0x0000000182537C40
	// [XID] // 0x0000000189A58580-0x0000000189A585A0
	private void RequestClose(bool isCancel = false /* Metadata: 0x00B0EC65 */) {} // 0x000000018253AE40-0x000000018253AFC0
	// [XID] // 0x0000000189A60040-0x0000000189A60060
	public override void ClosePage() {} // 0x0000000182537070-0x0000000182537130
	// [IDTag] // 0x0000000189A67CA0-0x0000000189A67CE0
	// [XID] // 0x0000000189A67CA0-0x0000000189A67CE0
	private void SetLongPress() {} // 0x0000000182537DE0-0x00000001825380A0
	// [IDTag] // 0x0000000189A72220-0x0000000189A72260
	// [XID] // 0x0000000189A72220-0x0000000189A72260
	private void SetLongPress(Button button, UnityAction action) {} // 0x0000000182537C40-0x0000000182537DE0
	// [XID] // 0x0000000189A7CAE0-0x0000000189A7CB00
	private void InitSlider() {} // 0x00000001825380A0-0x0000000182538440
	// [XID] // 0x0000000189A84400-0x0000000189A84420
	private void SetTab1SliderValue(bool up = true /* Metadata: 0x00B0EC66 */) {} // 0x0000000182539BE0-0x000000018253A0E0
	// [XID] // 0x0000000189A8BD70-0x0000000189A8BD90
	private void SetTab2UISliderValue(bool up = true /* Metadata: 0x00B0EC67 */) {} // 0x0000000182537340-0x00000001825376F0
	// [XID] // 0x0000000189A932E0-0x0000000189A93300
	private void SetTab2SceneSliderValue(bool up = true /* Metadata: 0x00B0EC68 */) {} // 0x00000001825397C0-0x0000000182539B70
	// [XID] // 0x0000000189A9AD00-0x0000000189A9AD20
	private void ChangeToTab1Page() {} // 0x00000001825391A0-0x0000000182539410
	// [XID] // 0x0000000189AA2030-0x0000000189AA2050
	private void ChangeToTab2Page() {} // 0x0000000182538440-0x00000001825386B0
	// [XID] // 0x0000000189AA9550-0x0000000189AA9570
	private void InitHDRUIManager() {} // 0x0000000182539480-0x00000001825397C0
	// [XID] // 0x0000000189AB1450-0x0000000189AB1470
	private void ShowHDRUIManager(bool value) {} // 0x0000000182537130-0x0000000182537340
}

