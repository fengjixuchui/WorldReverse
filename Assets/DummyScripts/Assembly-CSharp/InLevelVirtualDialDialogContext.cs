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

public sealed class InLevelVirtualDialDialogContext : BaseDialogContext // TypeDefIndex: 29613
{
	// Fields
	private MonoInLevelVirtualDialDialog _dialogMono; // 0x178
	private GameObject _btnQuickUse; // 0x180
	private MonoQuickUseButton _monoQuickUseButton; // 0x188
	private InputDeviceType _inputDevice; // 0x190
	private ulong _joypadInputDelayLog; // 0x198
	private int _selectIndex; // 0x1A0
	private float _selectValidTime; // 0x1A4
	private Vector2 _accumulatedDelta; // 0x1A8
	private static float SQR_SELECT_THRESHOLD; // 0x00
	private static float SQR_SELECT_THRESHOLD_MOUSE; // 0x04
	private VirtualDialAction[] _slotActionsConfig; // 0x1B0
	private static VirtualDialAction[] _slotActions; // 0x08
	private static VirtualDialAction[] _dpadActionsConfig; // 0x10
	private VirtualDialAction[] _dpadActions; // 0x1B8

	// Properties
	private GameObject btnQuickUse { /* [XID] */ /* 0x000000018972AD20-0x000000018972AD40 */ get => default; } // 0x000000018155CCD0-0x000000018155CE70 
	private MonoQuickUseButton monoQuickUseButton { /* [XID] */ /* 0x00000001897323D0-0x00000001897323F0 */ get => default; } // 0x000000018155A4F0-0x000000018155A610 
	private float _selectDelay { /* [XID] */ /* 0x000000018975F410-0x000000018975F430 */ get => default; } // 0x000000018155A730-0x000000018155A840 
	public Action<VirtualDialAction> onSelect { /* [XID] */ /* 0x00000001897755F0-0x0000000189775630 */ get; /* [XID] */ /* 0x000000018977FD80-0x000000018977FDC0 */ set; } // 0x000000018155AA90-0x000000018155AAF0 0x000000018155B610-0x000000018155B680

	// Constructors
	public InLevelVirtualDialDialogContext() {} // 0x000000018155DA10-0x000000018155DB90
	static InLevelVirtualDialDialogContext() {} // 0x000000018155D930-0x000000018155DA10

	// Methods
	// [XID] // 0x0000000189739B00-0x0000000189739B20
	public override void SetupView() {} // 0x000000018155CE70-0x000000018155D930
	// [XID] // 0x0000000189741700-0x0000000189741720
	public override void ClearView() {} // 0x000000018155A610-0x000000018155A730
	// [XID] // 0x0000000189748FE0-0x0000000189749000
	public override bool OnNotify(Notify ntf) => default; // 0x000000018155BC90-0x000000018155BEE0
	// [XID] // 0x0000000189750450-0x0000000189750470
	private bool IsActionUnlocked(VirtualDialAction action) => default; // 0x000000018155B3B0-0x000000018155B610
	// [XID] // 0x00000001897579F0-0x0000000189757A10
	private void SetupForJoypad() {} // 0x000000018155BEE0-0x000000018155C810
	// [XID] // 0x0000000189766900-0x0000000189766920
	private void DetermineValue(Vector2 delta) {} // 0x000000018155C810-0x000000018155CCD0
	// [XID] // 0x000000018976DEB0-0x000000018976DED0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018155AB50-0x000000018155AF40
	// [XID] // 0x000000018978A450-0x000000018978A470
	private bool TryToChangeToTeammate(int index) => default; // 0x000000018155B680-0x000000018155B860
	// [XID] // 0x0000000189791C70-0x0000000189791C90
	private bool TryUseQuickUseButton() => default; // 0x000000018155B1F0-0x000000018155B3B0
	// [XID] // 0x0000000189799270-0x0000000189799290
	private bool TryOpenHomeworldEditor() => default; // 0x000000018155BA00-0x000000018155BC00
	// [XID] // 0x00000001897A11D0-0x00000001897A11F0
	private bool TryUseActivitySkillButton() => default; // 0x000000018155B860-0x000000018155BA00
	// [XID] // 0x00000001897A87C0-0x00000001897A87E0
	private bool TryExtraAction(int index) => default; // 0x000000018155A8D0-0x000000018155AA90
	// [XID] // 0x00000001897B01E0-0x00000001897B0200
	public void CloseWheelMenu() {} // 0x000000018155AFA0-0x000000018155B1F0
}

