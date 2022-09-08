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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelProgressDialogContext : InLevelBaseLoadingDialogContext // TypeDefIndex: 29358
{
	// Fields
	private MonoLoadingCanvas _dialogMono; // 0x1B8
	private List<LoadingTipsExcelConfig> _validTips; // 0x1C0
	private uint _totalWeight; // 0x1C8
	private int _lastIndex; // 0x1CC
	private UIManager.LoadingSituationType situationType; // 0x1D0
	private UIManager.LoadingSituationType picType; // 0x1D4
	private static readonly string[] _separators; // 0x00

	// Constructors
	public InLevelProgressDialogContext() {} // Dummy constructor
	public InLevelProgressDialogContext(UIManager.LoadingSituationType tipsType, UIManager.LoadingSituationType picType = UIManager.LoadingSituationType.Default /* Metadata: 0x00B0F644 */) {} // 0x0000000183AD5830-0x0000000183AD59C0
	static InLevelProgressDialogContext() {} // 0x0000000183AD5750-0x0000000183AD5830

	// Methods
	// [XID] // 0x0000000189ACAD10-0x0000000189ACAD30
	public override void SetupView() {} // 0x0000000183AD5380-0x0000000183AD5660
	// [XID] // 0x0000000189AD27A0-0x0000000189AD27C0
	public override void ClearView() {} // 0x0000000183AD3640-0x0000000183AD3770
	// [XID] // 0x0000000189ADA1F0-0x0000000189ADA210
	protected override void ClearAll() {} // 0x0000000183AD3560-0x0000000183AD3640
	// [XID] // 0x0000000189AE1AB0-0x0000000189AE1AD0
	public override void UpdateView() {} // 0x0000000183AD5660-0x0000000183AD5750
	// [XID] // 0x0000000189AE9260-0x0000000189AE9280
	private void SetImgBgSprite() {} // 0x0000000183AD3770-0x0000000183AD3C70
	// [XID] // 0x0000000189AF1070-0x0000000189AF1090
	private void SetLoadingTips() {} // 0x0000000183AD4230-0x0000000183AD5210
	// [XID] // 0x0000000189AF8510-0x0000000189AF8530
	private void OnBtnClicked() {} // 0x0000000183AD2FF0-0x0000000183AD3560
	// [XID] // 0x0000000189AFFC20-0x0000000189AFFC40
	protected override void ShowProgress(float progress) {} // 0x0000000183AD4010-0x0000000183AD4230
	// [XID] // 0x0000000189B071D0-0x0000000189B071F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183AD3DC0-0x0000000183AD3F50
}

