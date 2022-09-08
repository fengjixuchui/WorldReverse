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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CodexQuestSelectDialogContext : BaseDialogContext // TypeDefIndex: 28523
{
	// Fields
	private MonoCodexQuestSelectDialog _dialogMono; // 0x178
	private ConfigCodexQuestItem _questItem; // 0x180
	private int _subQuestIndex; // 0x188
	private CodexQuestPageContext _mainPageContext; // 0x190
	private int _selectedIndex; // 0x198
	private MonoCodexQuestSelectRow _lastSelectedRow; // 0x1A0
	private MonoCodexQuestSelectRow _lastNavigatedRow; // 0x1A8
	private string _nameString; // 0x1B0
	private ConfigCodexQuestDialogSingle[] _dialogs; // 0x1B8

	// Constructors
	public CodexQuestSelectDialogContext() {} // Dummy constructor
	public CodexQuestSelectDialogContext(int subQuestIndex, ConfigCodexQuestItem questItem, CodexQuestPageContext mainPageContext, int selectedIndex) {} // 0x0000000182ACEDD0-0x0000000182ACF040

	// Methods
	// [XID] // 0x00000001899DE500-0x00000001899DE520
	protected override void BindViewCallbacks() {} // 0x0000000182ACDE80-0x0000000182ACE030
	// [XID] // 0x00000001899E6200-0x00000001899E6220
	private void OnClose() {} // 0x0000000182ACE650-0x0000000182ACE700
	// [XID] // 0x00000001899ED5D0-0x00000001899ED5F0
	private void OnChoose() {} // 0x0000000182ACE760-0x0000000182ACE840
	// [XID] // 0x00000001899F5160-0x00000001899F5180
	public override void SetupView() {} // 0x0000000182ACEB50-0x0000000182ACEDD0
	// [XID] // 0x00000001899FC6F0-0x00000001899FC710
	private void OnSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x0000000182ACE030-0x0000000182ACE1E0
	// [XID] // 0x0000000189A03CE0-0x0000000189A03D00
	private void RefreshItem(Transform trans, int index) {} // 0x0000000182ACE2E0-0x0000000182ACE5C0
	// [XID] // 0x0000000189A0B1F0-0x0000000189A0B210
	public override void ClearView() {} // 0x0000000182ACE1E0-0x0000000182ACE2E0
	// [XID] // 0x0000000189A12B60-0x0000000189A12B80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182ACE840-0x0000000182ACEA90
}

