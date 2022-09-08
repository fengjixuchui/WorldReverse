/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReadingDialogContext : BaseDialogContext // TypeDefIndex: 29246
{
	// Fields
	private MonoReadingDialog _dialogMono; // 0x178
	private string _simpleModeTitleTextMapId; // 0x188
	private List<string> _simpleModeContentTextMapId; // 0x190
	private uint _simpleModeShowNum; // 0x198
	private string _content; // 0x1A0
	private static readonly Regex _regex; // 0x00
	private static string _hideChar; // 0x08
	private static readonly Regex _hideRegex; // 0x10
	private DocumentExcelConfig _config; // 0x1A8
	private GameObject _previewImage; // 0x1B0
	private uint _previewImageHandle; // 0x1B8
	private bool _showHideContent; // 0x1BC
	private List<uint> _storyIdList; // 0x1C0
	private bool _isStoryList; // 0x1C8
	private int _currStoryListIndex; // 0x1CC
	private CodexEquipPageContext _parentPage; // 0x1D0
	private const float SCROLL_SENSITIVITY = 80f; // Metadata: 0x00B0EEC2

	// Properties
	private bool simpleMode { /* [XID] */ /* 0x000000018989A370-0x000000018989A3B0 */ get; set; } // 0x00000001827297E0-0x0000000182729840 0x0000000182729490-0x0000000182729500

	// Constructors
	public ReadingDialogContext() {} // Dummy constructor
	public ReadingDialogContext(uint id, bool showHideContent = false /* Metadata: 0x00B0EEC0 */) {} // 0x000000018272ABA0-0x000000018272ADB0
	public ReadingDialogContext(List<uint> storyIdList, int index, bool showHideContent = false /* Metadata: 0x00B0EEC1 */) {} // 0x000000018272A970-0x000000018272ABA0
	public ReadingDialogContext(string titleTextMapId, List<string> contentTextMapId, uint showItemNum) {} // 0x000000018272ADB0-0x000000018272AF50
	static ReadingDialogContext() {} // 0x000000018272A880-0x000000018272A970

	// Methods
	// [XID] // 0x00000001898ABCC0-0x00000001898ABCE0
	public override void SetupView() {} // 0x000000018272A4F0-0x000000018272A880
	// [XID] // 0x00000001898B33F0-0x00000001898B3410
	public void RefreshInfo() {} // 0x0000000182729D00-0x000000018272A4F0
	// [XID] // 0x00000001898BB0D0-0x00000001898BB0F0
	private void RefreshInfoSimpleMode() {} // 0x0000000182729840-0x0000000182729A00
	// [XID] // 0x00000001898C2460-0x00000001898C2480
	protected override void BindViewCallbacks() {} // 0x0000000182728FB0-0x0000000182729160
	// [XID] // 0x00000001898C9E80-0x00000001898C9EA0
	public override void ClearView() {} // 0x0000000182729160-0x0000000182729270
	// [XID] // 0x00000001898D1540-0x00000001898D1560
	private void AddText(string content) {} // 0x0000000182728ED0-0x0000000182728FB0
	// [XID] // 0x00000001898D8D80-0x00000001898D8DA0
	private void AddImage(string spriteName) {} // 0x0000000182729A00-0x0000000182729B10
	// [XID] // 0x00000001898E0A70-0x00000001898E0A90
	private void ScrollContent(float param) {} // 0x0000000182729500-0x00000001827297E0
	// [XID] // 0x00000001898E85B0-0x00000001898E85D0
	private void OnTabPrevBtnClick() {} // 0x0000000182729B10-0x0000000182729CA0
	// [XID] // 0x00000001898EFD50-0x00000001898EFD70
	private void OnTabNextBtnClick() {} // 0x0000000182729330-0x0000000182729490
}

