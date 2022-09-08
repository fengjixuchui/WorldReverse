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

public sealed class InLevelDebugMsgBoardDialogContext : BaseDialogContext // TypeDefIndex: 28624
{
	// Fields
	private DebugBoardInfo _boardInfo; // 0x178
	private List<DebugBlletinInfo> _blletinInfoList; // 0x180
	private Transform _mainPanel; // 0x188
	private UnityEngine.UI.Text _typeText; // 0x190
	private UnityEngine.UI.Text _titleText; // 0x198
	private Transform _scrollViewContent; // 0x1A0
	private MonoGridScroller _monoGridScroller; // 0x1A8
	private Transform _createPanel; // 0x1B0
	private Dropdown _typeDropdown; // 0x1B8
	private InputField _titleInputField; // 0x1C0
	private InputField _msgInputField; // 0x1C8
	private Button _btnCreate; // 0x1D0
	private Transform _commentPanel; // 0x1D8
	private InputField _commentInputField; // 0x1E0
	private Button _btnComment; // 0x1E8

	// Constructors
	public InLevelDebugMsgBoardDialogContext() {} // Dummy constructor
	public InLevelDebugMsgBoardDialogContext(DebugBoardInfo info = null) {} // 0x00000001824684F0-0x00000001824685A0

	// Methods
	// [XID] // 0x0000000189AAE0E0-0x0000000189AAE100
	public override void SetupView() {} // 0x0000000182467BB0-0x00000001824684F0
	// [XID] // 0x0000000189AB59B0-0x0000000189AB59D0
	public override void ClearView() {} // 0x0000000182466300-0x0000000182466500
	// [XID] // 0x0000000189ABD3B0-0x0000000189ABD3D0
	public override void Destroy() {} // 0x0000000182466500-0x00000001824665B0
	// [XID] // 0x0000000189AC4DE0-0x0000000189AC4E00
	private void EnableAvatarInput(bool enable) {} // 0x0000000182466BB0-0x0000000182466CF0
	// [XID] // 0x0000000189ACC440-0x0000000189ACC460
	private void UpdateUI() {} // 0x00000001824675B0-0x0000000182467750
	// [XID] // 0x0000000189AD4080-0x0000000189AD40A0
	private void UpdateContent() {} // 0x0000000182466660-0x00000001824667D0
	// [XID] // 0x0000000189ADBA80-0x0000000189ADBAA0
	private string GetAuthor() => default; // 0x00000001824673D0-0x0000000182467480
	// [XID] // 0x0000000189AE33E0-0x0000000189AE3400
	private void OnMainComment() {} // 0x0000000182466900-0x0000000182466A30
	// [XID] // 0x0000000189AEAD70-0x0000000189AEAD90
	private void OnQuit() {} // 0x0000000182467880-0x0000000182467930
	// [XID] // 0x0000000189AF2640-0x0000000189AF2660
	private void OnCreate() {} // 0x0000000182466DB0-0x0000000182467230
	// [XID] // 0x0000000189AFA000-0x0000000189AFA020
	private void OnCreateClose() {} // 0x00000001824665B0-0x0000000182466660
	// [XID] // 0x0000000189B01530-0x0000000189B01550
	private void OnComment() {} // 0x0000000182467930-0x0000000182467BB0
	// [XID] // 0x0000000189B08A80-0x0000000189B08AA0
	private void OnCommentClose() {} // 0x0000000182467750-0x0000000182467880
}

