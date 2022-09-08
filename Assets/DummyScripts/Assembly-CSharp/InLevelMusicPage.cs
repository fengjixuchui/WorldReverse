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

public sealed class InLevelMusicPage : BasePageContext // TypeDefIndex: 29164
{
	// Fields
	private MonoInLevelMusicPage _pageMono; // 0x190
	private List<MonoMusicFreeButton> _musicBtnList; // 0x198
	private PanelState _curPanelState; // 0x1A0
	private bool _leftShoulderPressed; // 0x1A4
	private bool _rightShoulderPressed; // 0x1A5

	// Nested types
	private enum PanelState // TypeDefIndex: 29165
	{
		None = 0,
		High = 1,
		Normal = 2,
		Low = 3
	}

	// Constructors
	public InLevelMusicPage() {} // 0x000000018370B4D0-0x000000018370B5C0

	// Methods
	// [XID] // 0x0000000189930630-0x0000000189930650
	public override void SetupView() {} // 0x000000018370B150-0x000000018370B3F0
	// [XID] // 0x0000000189937BC0-0x0000000189937BE0
	private void OnClick(int index) {} // 0x000000018370AED0-0x000000018370AF90
	// [XID] // 0x000000018993F630-0x000000018993F650
	private void PostMidiEvent(int index) {} // 0x000000018370A4D0-0x000000018370A7B0
	// [XID] // 0x0000000189946C40-0x0000000189946C60
	private int GetInstrument() => default; // 0x0000000183709AB0-0x0000000183709B50
	// [XID] // 0x000000018994E2C0-0x000000018994E2E0
	protected override void BindViewCallbacks() {} // 0x0000000183709820-0x00000001837099B0
	// [XID] // 0x0000000189955920-0x0000000189955940
	private void OnClickBtnStatement() {} // 0x000000018370A810-0x000000018370A920
	// [XID] // 0x000000018995D3C0-0x000000018995D3E0
	public override void UpdateView() {} // 0x000000018370B3F0-0x000000018370B4D0
	// [XID] // 0x0000000189964A70-0x0000000189964A90
	public override void ClearView() {} // 0x00000001837099B0-0x0000000183709AB0
	// [XID] // 0x000000018996C130-0x000000018996C150
	private void SwitchPanel(PanelState state) {} // 0x000000018370AAC0-0x000000018370AD00
	// [XID] // 0x0000000189973BE0-0x0000000189973C00
	private void CheckPanel() {} // 0x000000018370AF90-0x000000018370B060
	// [XID] // 0x000000018997B250-0x000000018997B270
	private void ClickMusicBtn(int index) {} // 0x000000018370B060-0x000000018370B150
	// [XID] // 0x0000000189982D00-0x0000000189982D20
	private void SimulateClick(int index) {} // 0x0000000183709B50-0x0000000183709DE0
	// [XID] // 0x000000018998A4F0-0x000000018998A510
	private void SkipActionForJoypad() {} // 0x0000000183709E70-0x0000000183709FA0
	// [XID] // 0x0000000189991DE0-0x0000000189991E00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018370A000-0x000000018370A470
	// [XID] // 0x0000000189999AF0-0x0000000189999B10
	private void MusicPosStart() {} // 0x000000018370A920-0x000000018370AAC0
	// [XID] // 0x00000001899A1180-0x00000001899A11A0
	private void MusicPosEnd() {} // 0x000000018370AD00-0x000000018370AE70
}

