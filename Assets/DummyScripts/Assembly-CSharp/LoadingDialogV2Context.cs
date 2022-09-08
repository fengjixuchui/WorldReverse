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

public sealed class LoadingDialogV2Context : BaseLoadingDialogContext // TypeDefIndex: 30001
{
	// Fields
	private MonoLoadingCanvas _dialogMono; // 0x198
	private Color _backColor; // 0x1A0
	private uint _configID; // 0x1B0
	private List<LoadingTipsExcelConfig> _validTips; // 0x1B8
	private uint _totalWeight; // 0x1C0
	private int _lastIndex; // 0x1C4
	private UIManager.LoadingSituationType situationType; // 0x1C8
	private static readonly string[] _separators; // 0x00

	// Properties
	public uint configID { /* [XID] */ /* 0x000000018961E9E0-0x000000018961EA00 */ set {} } // 0x0000000182092120-0x00000001820921D0

	// Constructors
	public LoadingDialogV2Context() {} // Dummy constructor
	public LoadingDialogV2Context(UIManager.LoadingSituationType type) {} // 0x0000000182095320-0x00000001820954B0
	static LoadingDialogV2Context() {} // 0x0000000182095240-0x0000000182095320

	// Methods
	// [XID] // 0x0000000189625DE0-0x0000000189625E00
	public override void SetupView() {} // 0x0000000182094CF0-0x0000000182095190
	// [XID] // 0x000000018962D720-0x000000018962D740
	public override void ClearView() {} // 0x0000000182092B90-0x0000000182092C40
	// [XID] // 0x00000001896352E0-0x0000000189635300
	public override void UpdateView() {} // 0x0000000182095190-0x0000000182095240
	// [XID] // 0x000000018963C980-0x000000018963C9A0
	private void SetImgBgSprite() {} // 0x0000000182092C40-0x0000000182093180
	// [XID] // 0x0000000189644040-0x0000000189644060
	private void SetBgIconByType(uint type) {} // 0x0000000182092740-0x0000000182092B90
	// [XID] // 0x000000018964B7F0-0x000000018964B810
	private void SetLoadingTips() {} // 0x0000000182093D00-0x0000000182094CF0
	// [XID] // 0x0000000189652F60-0x0000000189652F80
	private void OnBtnClicked() {} // 0x00000001820921D0-0x0000000182092740
	// [XID] // 0x000000018965A640-0x000000018965A660
	public override void CloseDialog() {} // 0x0000000182093410-0x0000000182093630
	// [XID] // 0x0000000189661C90-0x0000000189661CB0
	private string GetRandomLoadingTip() => default; // 0x0000000182093180-0x0000000182093370
	// [XID] // 0x0000000189669850-0x0000000189669870
	private void SetupTips() {} // 0x0000000182093630-0x0000000182093720
	// [XID] // 0x0000000189671340-0x0000000189671360
	protected override void ShowProgress(float progress) {} // 0x0000000182093920-0x0000000182093B20
	// [XID] // 0x0000000189678C20-0x0000000189678C40
	private void UpdateLightup() {} // 0x0000000182093B20-0x0000000182093CA0
}

