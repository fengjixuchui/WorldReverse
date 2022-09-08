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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpenRewardDialog : BaseDialogContext // TypeDefIndex: 30305
{
	// Fields
	private bool _showTwoButton; // 0x178
	private string _title; // 0x180
	private string _desc; // 0x188
	private string _leftButtonText; // 0x190
	private string _rightButtonText; // 0x198
	private string _leftIconName; // 0x1A0
	private string _rightIconName; // 0x1A8
	private bool _isJoypadMode; // 0x1B0
	private Action _leftAction; // 0x1B8
	private Action _rightAction; // 0x1C0
	private MonoOpenRewardDialog _dialogMono; // 0x1C8
	private bool _showMultiplyTimesTag; // 0x1D0
	private uint _multiplyTimes; // 0x1D4
	private MaterialGrpWidgetContext _materialWidget; // 0x1D8
	private uint _leftIconMaterialId; // 0x1E0
	private uint _rightIconMaterialId; // 0x1E4
	private OpenRewardData _openRewardData; // 0x1E8
	private uint _extraMaterialId; // 0x1F0
	private const string _doubleDropTagPath = "ART/UI/Menus/Widget/Btn_Tag_DoubleDrop"; // Metadata: 0x00B10983
	private uint _resourceHandler; // 0x1F4
	private GameObject _doubleDropPrefab; // 0x1F8

	// Constructors
	public OpenRewardDialog() {} // Dummy constructor
	public OpenRewardDialog(OpenRewardData data) {} // 0x0000000181CB2620-0x0000000181CB2A40

	// Methods
	// [XID] // 0x0000000189B24C10-0x0000000189B24C30
	private void SetDataWithSystemNone(OpenRewardData data) {} // 0x0000000181CB17A0-0x0000000181CB2020
	// [XID] // 0x0000000189B2C0A0-0x0000000189B2C0C0
	private void SetDataWithSystemMpPlay(OpenRewardData data) {} // 0x0000000181CB1190-0x0000000181CB15B0
	// [XID] // 0x0000000189B33650-0x0000000189B33670
	private void OnUseCondenseResin() {} // 0x0000000181CB0190-0x0000000181CB0260
	// [XID] // 0x0000000189B3AF50-0x0000000189B3AF70
	private void OnGetResin() {} // 0x0000000181CB1070-0x0000000181CB1130
	// [XID] // 0x0000000189B426D0-0x0000000189B426F0
	private void OnUseResin() {} // 0x0000000181CB09B0-0x0000000181CB0A80
	// [XID] // 0x0000000189B4A250-0x0000000189B4A270
	private void OnUseMpPlayCoin() {} // 0x0000000181CB05C0-0x0000000181CB0690
	// [XID] // 0x0000000189B51A10-0x0000000189B51A30
	public override void SetupView() {} // 0x0000000181CB2020-0x0000000181CB2620
	// [XID] // 0x0000000189B591D0-0x0000000189B591F0
	public override void CloseDialog() {} // 0x0000000181CB04C0-0x0000000181CB05C0
	// [XID] // 0x0000000189B60A20-0x0000000189B60A40
	protected override void BindViewCallbacks() {} // 0x0000000181CB0260-0x0000000181CB04C0
	// [XID] // 0x0000000189B68130-0x0000000189B68150
	private void LeftButtonInvoke() {} // 0x0000000181CB15B0-0x0000000181CB1680
	// [XID] // 0x0000000189B6F4D0-0x0000000189B6F4F0
	private void RightButtonInvoke() {} // 0x0000000181CB0D20-0x0000000181CB0DF0
	// [XID] // 0x0000000189B76B50-0x0000000189B76B70
	private void SetButtonIcon(string iconName, MonoUIContainer buttonContainer) {} // 0x0000000181CB0720-0x0000000181CB0950
	// [XID] // 0x0000000189B7E100-0x0000000189B7E120
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181CB0A80-0x0000000181CB0D20
	// [XID] // 0x0000000189B85CE0-0x0000000189B85D00
	private void SetMultiplyDropLabText(Transform tagTrans) {} // 0x0000000181CB0DF0-0x0000000181CB1070
	// [XID] // 0x0000000189B8CCD0-0x0000000189B8CCF0
	private void SetupShopMaterialWidget() {} // 0x0000000181CAFF50-0x0000000181CB0190
	// [XID] // 0x0000000189B94500-0x0000000189B94520
	private void CloseShopMaterialWidget() {} // 0x0000000181CB1680-0x0000000181CB1740
}

