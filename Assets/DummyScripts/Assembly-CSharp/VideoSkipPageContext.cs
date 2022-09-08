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

public sealed class VideoSkipPageContext : BasePageContext // TypeDefIndex: 31344
{
	// Fields
	private MonoSkipDialog _pageMono; // 0x190
	private bool _showSkipBtn; // 0x198
	private bool _useSkip; // 0x199
	private Coroutine _hideCoroutine; // 0x1A0
	private float _durationToHide; // 0x1A8
	private Vector2 _lastMousePos; // 0x1AC
	private float _lastMouseMoveTime; // 0x1B4
	private bool _firstUpdate; // 0x1B8

	// Properties
	public bool useSkip { /* [XID] */ /* 0x000000018986DC40-0x000000018986DC60 */ set {} } // 0x0000000181DC0940-0x0000000181DC09F0

	// Constructors
	public VideoSkipPageContext() {} // Dummy constructor
	public VideoSkipPageContext(bool useSkip) {} // 0x0000000181DC1920-0x0000000181DC1A70

	// Methods
	// [XID] // 0x0000000189874F30-0x0000000189874F50
	public override void SetupView() {} // 0x0000000181DC15C0-0x0000000181DC16A0
	// [XID] // 0x000000018987CC70-0x000000018987CC90
	protected override void BindViewCallbacks() {} // 0x0000000181DC0630-0x0000000181DC0790
	// [XID] // 0x0000000189883BD0-0x0000000189883BF0
	public override void UpdateView() {} // 0x0000000181DC16A0-0x0000000181DC1920
	// [XID] // 0x000000018988B2B0-0x000000018988B2D0
	public override void ClearView() {} // 0x0000000181DC0890-0x0000000181DC0940
	// [XID] // 0x00000001898929F0-0x0000000189892A10
	private void OnSkipBtnClick() {} // 0x0000000181DC1140-0x0000000181DC12C0
	// [XID] // 0x000000018989A090-0x000000018989A0B0
	private void OnFreeClick() {} // 0x0000000181DC0790-0x0000000181DC0890
	// [XID] // 0x00000001898A1330-0x00000001898A1350
	private void ShowSkipBtn(bool showBtn) {} // 0x0000000181DC13E0-0x0000000181DC15C0
	// [XID] // 0x00000001898A8B80-0x00000001898A8BA0
	private void RealShowSkipBtn(bool showBtn) {} // 0x0000000181DC0A80-0x0000000181DC0C30
	// [XID] // 0x00000001898B0500-0x00000001898B0520
	private void SkipActionForJoypad() {} // 0x0000000181DC0C30-0x0000000181DC0D50
	// [XID] // 0x00000001898B7AD0-0x00000001898B7AF0
	private void SkipActionForJoypadWithoutDialog() {} // 0x0000000181DC0540-0x0000000181DC0630
	// [XID] // 0x00000001898BF0E0-0x00000001898BF100
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181DC0DB0-0x0000000181DC1010
}

