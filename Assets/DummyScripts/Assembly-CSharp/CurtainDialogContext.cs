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

public class CurtainDialogContext : BaseWidgetContext // TypeDefIndex: 28560
{
	// Fields
	private MonoCurtainCanvas _dialogMono; // 0x168
	private float _curTime; // 0x170
	private bool _toDisable; // 0x174
	private float _duration; // 0x178
	private bool _inOrOut; // 0x17C
	private bool _isPlayEnd; // 0x17D
	private Action _callback; // 0x180

	// Constructors
	public CurtainDialogContext() {} // 0x0000000182A14BE0-0x0000000182A14D30

	// Methods
	// [XID] // 0x000000018996A840-0x000000018996A860
	public override void SetupView() {} // 0x0000000182A14A80-0x0000000182A14B40
	// [XID] // 0x0000000189972620-0x0000000189972640
	public override void UpdateView() {} // 0x0000000182A14B40-0x0000000182A14BE0
	// [XID] // 0x0000000189979DA0-0x0000000189979DC0
	public override void OnDisconnect() {} // 0x0000000182A14810-0x0000000182A148C0
	// [XID] // 0x0000000189A03830-0x0000000189A03850
	public void SetColor(Color fillColor) {} // 0x0000000182A14670-0x0000000182A14810
	// [XID] // 0x0000000189988D40-0x0000000189988D60
	public void SetBgAlpha(float a) {} // 0x0000000182A148C0-0x0000000182A14A80
	// [XID] // 0x00000001899F4D00-0x00000001899F4D20
	public void StartPlay(bool inOrOut, bool toDisable, float duration, Action callback) {} // 0x0000000182A14500-0x0000000182A14670
	// [XID] // 0x0000000189998150-0x0000000189998170
	private void UpdateCurtain() {} // 0x0000000182A14290-0x0000000182A144A0
}

