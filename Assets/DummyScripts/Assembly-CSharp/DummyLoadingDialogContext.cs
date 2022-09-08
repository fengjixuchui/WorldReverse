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

public sealed class DummyLoadingDialogContext : BaseLoadingDialogContext // TypeDefIndex: 30004
{
	// Fields
	private static string DEFAULT_TEXT; // 0x00
	private MonoCurtainCanvas _dialogMono; // 0x198
	private Color _textColor; // 0x1A0
	private UnityEngine.UI.Text _questHintText; // 0x1B0
	private string _curQuestHint; // 0x1B8
	private List<string> _questHintList; // 0x1C0
	private float _time; // 0x1C8
	private bool _startDarkIn; // 0x1CC
	private string[] _textMapId; // 0x1D0
	private float _textShowTime; // 0x1D8
	private float _fadeOutTimePoint; // 0x1DC
	private MonoPrefabPlugin _prefabPlugin; // 0x1E0
	private CanvasGroup _canvasGroup; // 0x1E8

	// Constructors
	public DummyLoadingDialogContext() {} // 0x00000001841EAF50-0x00000001841EB100
	static DummyLoadingDialogContext() {} // 0x00000001841EAEE0-0x00000001841EAF50

	// Methods
	// [XID] // 0x000000018977B3E0-0x000000018977B400
	protected override void ShowProgress(float progress) {} // 0x00000001841EA660-0x00000001841EA710
	// [XID] // 0x0000000189782F60-0x0000000189782F80
	public void InitText(string[] textMapId, float textShowTime) {} // 0x00000001841EA580-0x00000001841EA660
	// [XID] // 0x000000018978A3F0-0x000000018978A410
	private void SetTextMap(string[] textMapId) {} // 0x00000001841EA310-0x00000001841EA4C0
	// [XID] // 0x0000000189791C10-0x0000000189791C30
	public override void SetupView() {} // 0x00000001841EAB40-0x00000001841EAE00
	// [XID] // 0x0000000189799210-0x0000000189799230
	public override void ClearView() {} // 0x00000001841E9FC0-0x00000001841EA080
	// [XID] // 0x00000001897A1110-0x00000001897A1130
	public override void UpdateView() {} // 0x00000001841EAE00-0x00000001841EAEE0
	// [XID] // 0x00000001897A8780-0x00000001897A87A0
	private void UpdateDarkIn() {} // 0x00000001841EA8D0-0x00000001841EAA40
	// [XID] // 0x00000001897B01A0-0x00000001897B01C0
	private void UpdateText() {} // 0x00000001841E9E40-0x00000001841E9FC0
	// [XID] // 0x00000001897B7ED0-0x00000001897B7EF0
	private void UpdateLightup() {} // 0x00000001841EA710-0x00000001841EA870
	// [XID] // 0x00000001897BFFB0-0x00000001897BFFD0
	public override void CloseDialog() {} // 0x00000001841EA120-0x00000001841EA250
	// [XID] // 0x00000001897C7820-0x00000001897C7840
	private void PlayLoadingAnimation() {} // 0x00000001841EAA40-0x00000001841EAB40
}

