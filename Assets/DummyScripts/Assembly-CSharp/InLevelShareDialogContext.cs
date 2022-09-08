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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelShareDialogContext : BaseDialogContext // TypeDefIndex: 29596
{
	// Fields
	private MonoPhotoShareDialog _dialogMono; // 0x178
	private RenderTexture _savedImageTexture; // 0x180
	private bool _needBG; // 0x188
	private bool _hidePersonalInfo; // 0x189
	private MonoInLevelPhotographWatermark _watermark; // 0x190
	private int _currBtnIndex; // 0x198
	private List<Button> _buttonList; // 0x1A0
	private bool _customEnableInputPenetrate; // 0x1A8
	private string _fileName; // 0x1B0
	private byte[] _jpgBytes; // 0x1B8
	private bool _saved; // 0x1C0
	private bool _saving; // 0x1C1

	// Properties
	public override bool enableInputPenetrate { /* [XID] */ /* 0x0000000189A8A470-0x0000000189A8A490 */ get => default; } // 0x000000018355FBD0-0x000000018355FC80 

	// Nested types
	public enum EShareSource // TypeDefIndex: 29597
	{
		Photograph = 0,
		Gacha = 1
	}

	// Constructors
	public InLevelShareDialogContext() {} // Dummy constructor
	public InLevelShareDialogContext(RenderTexture texture, EShareSource source = EShareSource.Photograph /* Metadata: 0x00B0F9E5 */, bool hideInfo = true /* Metadata: 0x00B0F9E9 */) {} // 0x000000018355FA70-0x000000018355FBD0

	// Methods
	// [XID] // 0x0000000189A91C70-0x0000000189A91C90
	public override void SetupView() {} // 0x000000018355F620-0x000000018355F9D0
	// [XID] // 0x0000000189A99740-0x0000000189A99760
	public void SetRenderTexture(RenderTexture texture) {} // 0x000000018355D120-0x000000018355D260
	// [XID] // 0x0000000189AA0790-0x0000000189AA07B0
	private void AddWaterMarkAndShow() {} // 0x000000018355C620-0x000000018355C920
	// [XID] // 0x0000000189AA7D90-0x0000000189AA7DB0
	protected override void BindViewCallbacks() {} // 0x000000018355C990-0x000000018355CE30
	// [XID] // 0x0000000189AAF880-0x0000000189AAF8A0
	public void RefreshMobileJoypadButton(bool prev) {} // 0x000000018355EF50-0x000000018355F2E0
	// [XID] // 0x0000000189AB70F0-0x0000000189AB7110
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018355E3F0-0x000000018355E630
	// [XID] // 0x0000000189ABEB40-0x0000000189ABEB60
	public override bool OnNotify(Notify ntf) => default; // 0x000000018355F520-0x000000018355F620
	// [XID] // 0x0000000189AC66F0-0x0000000189AC6710
	private void OnSave(bool isShare = false /* Metadata: 0x00B0F9EA */, MiHoYoSDKManager.SharePlatform sharePlatform = MiHoYoSDKManager.SharePlatform.None /* Metadata: 0x00B0F9EB */) {} // 0x000000018355D7B0-0x000000018355E1B0
	// [XID] // 0x0000000189ACDCE0-0x0000000189ACDD00
	public override void UpdateView() {} // 0x000000018355F9D0-0x000000018355FA70
	// [XID] // 0x0000000189AD5B20-0x0000000189AD5B40
	private void DoSaveOnPC(byte[] data, string fileName) {} // 0x000000018355EDA0-0x000000018355EF50
	// [XID] // 0x0000000189ADD4B0-0x0000000189ADD4D0
	private void RefreshShareButtons(bool isOversea) {} // 0x000000018355CE30-0x000000018355D120
	// [XID] // 0x0000000189AE4C50-0x0000000189AE4C70
	private void InitButtonList(bool isOverSea) {} // 0x000000018355E700-0x000000018355EB80
	// [XID] // 0x0000000189AEC330-0x0000000189AEC350
	private void OnShare(MiHoYoSDKManager.SharePlatform sharePlatform) {} // 0x000000018355F350-0x000000018355F430
	// [XID] // 0x0000000189AF3CF0-0x0000000189AF3D10
	private void ShareImage(MiHoYoSDKManager.SharePlatform sharePlatform) {} // 0x000000018355D530-0x000000018355D740
	// [XID] // 0x0000000189AFB420-0x0000000189AFB440
	public override void ClearView() {} // 0x000000018355D2D0-0x000000018355D530
}

