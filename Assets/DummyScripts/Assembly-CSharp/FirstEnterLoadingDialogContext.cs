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

public sealed class FirstEnterLoadingDialogContext : BaseLoadingDialogContext // TypeDefIndex: 30005
{
	// Fields
	private MonoLoadingCanvas _dialogMono; // 0x198
	private Color _textColor; // 0x1A0
	private UnityEngine.UI.Text _questHintText; // 0x1B0
	private string _showTextId; // 0x1B8
	private float _curShowTime; // 0x1C0
	private float _textShowDelay; // 0x1C4
	private float _textCutInTime; // 0x1C8
	private bool _startDarkIn; // 0x1CC
	private CanvasGroup _canvasGroup; // 0x1D0
	private const int _voidId = 3500425; // Metadata: 0x00B106C6
	private bool _isDummyLoadingProgress; // 0x1D8
	private float _nextStepTime; // 0x1DC

	// Constructors
	public FirstEnterLoadingDialogContext() {} // 0x00000001832682A0-0x0000000183268420

	// Methods
	// [XID] // 0x00000001897F5F20-0x00000001897F5F40
	protected override void ShowProgress(float progress) {} // 0x0000000183267380-0x00000001832675E0
	// [XID] // 0x00000001897FD640-0x00000001897FD660
	public override void SetupView() {} // 0x0000000183267C60-0x00000001832681B0
	// [XID] // 0x0000000189804C00-0x0000000189804C20
	private static void OnAudioPlayStart(int stub) {} // 0x0000000183267B90-0x0000000183267C60
	// [XID] // 0x000000018980C230-0x000000018980C250
	private static void OnAudioPlayEnd(int stub) {} // 0x0000000183267090-0x0000000183267160
	// [XID] // 0x00000001898139E0-0x0000000189813A00
	public override void ClearView() {} // 0x0000000183266DC0-0x0000000183266E70
	// [XID] // 0x000000018981B4F0-0x000000018981B510
	public override void UpdateView() {} // 0x00000001832681B0-0x00000001832682A0
	// [XID] // 0x0000000189822B60-0x0000000189822B80
	private void UpdateDarkIn() {} // 0x00000001832678F0-0x0000000183267A60
	// [XID] // 0x000000018982A490-0x000000018982A4B0
	private void UpdateText() {} // 0x0000000183266A70-0x0000000183266BC0
	// [XID] // 0x00000001898317A0-0x00000001898317C0
	private void UpdateLightup() {} // 0x00000001832675E0-0x0000000183267780
	// [XID] // 0x0000000189838EC0-0x0000000189838EE0
	public override void CloseDialog() {} // 0x0000000183266E70-0x0000000183267090
	// [XID] // 0x0000000189840520-0x0000000189840540
	private void StartDummyLoading() {} // 0x0000000183266910-0x0000000183266A70
	// [XID] // 0x0000000189847AD0-0x0000000189847AF0
	private void StopDummyLoading() {} // 0x0000000183267A60-0x0000000183267B10
	// [XID] // 0x000000018984F240-0x000000018984F260
	private void CheckStopDummyLoading() {} // 0x00000001832677E0-0x00000001832678F0
	// [XID] // 0x00000001898563A0-0x00000001898563C0
	private void UpdateDummyLoadingProgress() {} // 0x0000000183266BC0-0x0000000183266DC0
}

