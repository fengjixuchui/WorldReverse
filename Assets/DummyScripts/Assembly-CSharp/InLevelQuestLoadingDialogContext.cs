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

public sealed class InLevelQuestLoadingDialogContext : InLevelBaseLoadingDialogContext // TypeDefIndex: 29359
{
	// Fields
	private static string DEFAULT_TEXT; // 0x00
	private MonoCurtainCanvas _dialogMono; // 0x1B8
	private Color _textColor; // 0x1C0
	private UnityEngine.UI.Text _questHintText; // 0x1D0
	private string _curQuestHint; // 0x1D8
	private List<string> _questHintList; // 0x1E0
	private int _questHintPos; // 0x1E8
	private float _time; // 0x1EC
	private bool _loadingFinished; // 0x1F0
	private string[] _textMapId; // 0x1F8
	private static float MIN_TEXT_SHOW_TIME; // 0x08
	private float _textShowTime; // 0x200
	private float _fadeOutTimePoint; // 0x204
	private bool _showOneText; // 0x208
	private MonoPrefabPlugin _prefabPlugin; // 0x210

	// Constructors
	public InLevelQuestLoadingDialogContext() {} // 0x0000000181D19E80-0x0000000181D1A020
	static InLevelQuestLoadingDialogContext() {} // 0x0000000181D19E00-0x0000000181D19E80

	// Methods
	// [XID] // 0x0000000189B18DC0-0x0000000189B18DE0
	public void InitText(string[] textMapId, float textShowTime) {} // 0x0000000181D195D0-0x0000000181D19740
	// [XID] // 0x0000000189B20410-0x0000000189B20430
	private void SetTextMap(string[] textMapId) {} // 0x0000000181D19360-0x0000000181D19510
	// [XID] // 0x0000000189B27A90-0x0000000189B27AB0
	public override void SetupView() {} // 0x0000000181D19A90-0x0000000181D19D00
	// [XID] // 0x0000000189B2EDD0-0x0000000189B2EDF0
	public override void UpdateView() {} // 0x0000000181D19D00-0x0000000181D19E00
	// [XID] // 0x0000000189B36690-0x0000000189B366B0
	private void UpdateText() {} // 0x0000000181D18FC0-0x0000000181D19230
	// [XID] // 0x0000000189B3DF00-0x0000000189B3DF20
	protected override void ShowProgress(float progress) {} // 0x0000000181D19740-0x0000000181D19920
	// [XID] // 0x0000000189B45C50-0x0000000189B45C70
	private void PlayLoadingAnimation() {} // 0x0000000181D19920-0x0000000181D19A20
	// [XID] // 0x0000000189B4D0D0-0x0000000189B4D0F0
	public override void ClearView() {} // 0x0000000181D19230-0x0000000181D19300
}

