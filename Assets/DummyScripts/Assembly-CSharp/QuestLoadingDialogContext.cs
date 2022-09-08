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

public sealed class QuestLoadingDialogContext : BaseLoadingDialogContext // TypeDefIndex: 30002
{
	// Fields
	private static string DEFAULT_TEXT; // 0x00
	private MonoCurtainCanvas _dialogMono; // 0x198
	private Color _textColor; // 0x1A0
	private UnityEngine.UI.Text _questHintText; // 0x1B0
	private string _curQuestHint; // 0x1B8
	private List<string> _questHintList; // 0x1C0
	private int _questHintPos; // 0x1C8
	private float _time; // 0x1CC
	private bool _startDarkIn; // 0x1D0
	private bool _loadingFinished; // 0x1D1
	private string[] _textMapId; // 0x1D8
	private static float MIN_TEXT_SHOW_TIME; // 0x08
	private float _textShowTime; // 0x1E0
	private float _fadeOutTimePoint; // 0x1E4
	private bool _showOneText; // 0x1E8
	private bool _isDisconnect; // 0x1E9
	private MonoPrefabPlugin _prefabPlugin; // 0x1F0
	private CanvasGroup _canvasGroup; // 0x1F8

	// Constructors
	public QuestLoadingDialogContext() {} // 0x0000000183C4E420-0x0000000183C4E5D0
	static QuestLoadingDialogContext() {} // 0x0000000183C4E3A0-0x0000000183C4E420

	// Methods
	// [XID] // 0x00000001896A2C30-0x00000001896A2C50
	public void InitText(string[] textMapId, float textShowTime) {} // 0x0000000183C4D6B0-0x0000000183C4D820
	// [XID] // 0x00000001896AA120-0x00000001896AA140
	protected override void ShowProgress(float progress) {} // 0x0000000183C4D820-0x0000000183C4D9A0
	// [XID] // 0x00000001896B0EE0-0x00000001896B0F00
	private void SetTextMap(string[] textMapId) {} // 0x0000000183C4D3A0-0x0000000183C4D550
	// [XID] // 0x00000001896B8AF0-0x00000001896B8B10
	public override void SetupView() {} // 0x0000000183C4DF50-0x0000000183C4E2E0
	// [XID] // 0x00000001896BFD30-0x00000001896BFD50
	public override void ClearView() {} // 0x0000000183C4CFF0-0x0000000183C4D150
	// [XID] // 0x00000001896C7610-0x00000001896C7630
	public override void OnDisconnect() {} // 0x0000000183C4DDC0-0x0000000183C4DEF0
	// [XID] // 0x00000001896CED70-0x00000001896CED90
	public override void UpdateView() {} // 0x0000000183C4E2E0-0x0000000183C4E3A0
	// [XID] // 0x00000001896D6190-0x00000001896D61B0
	private void UpdateDarkIn() {} // 0x0000000183C4DB60-0x0000000183C4DCC0
	// [XID] // 0x00000001896DD7B0-0x00000001896DD7D0
	private void UpdateText() {} // 0x0000000183C4CD60-0x0000000183C4CFF0
	// [XID] // 0x00000001896E4E40-0x00000001896E4E60
	private void UpdateLightup() {} // 0x0000000183C4D9A0-0x0000000183C4DB00
	// [XID] // 0x00000001896EC340-0x00000001896EC360
	public override void CloseDialog() {} // 0x0000000183C4D150-0x0000000183C4D280
	// [XID] // 0x00000001896F3AD0-0x00000001896F3AF0
	private void PlayLoadingAnimation() {} // 0x0000000183C4DCC0-0x0000000183C4DDC0
}

