/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DebugLogMessageDialogContext : BaseWidgetContext // TypeDefIndex: 28910
{
	// Fields
	private const int STATE_OFF = 0; // Metadata: 0x00B0E86E
	private const int STATE_ON = 1; // Metadata: 0x00B0E872
	private Queue<string> _messageQueue; // 0x168
	private DateTime _targetTime; // 0x170
	private int _state; // 0x180
	private Animation _fadeinAnim; // 0x188
	private Transform _txtMessage; // 0x190
	private UnityEngine.UI.Text _text; // 0x198

	// Constructors
	public DebugLogMessageDialogContext() {} // 0x0000000181AF2AF0-0x0000000181AF2C40

	// Methods
	// [XID] // 0x00000001895F3140-0x00000001895F3160
	public override void SetupView() {} // 0x0000000181AF2820-0x0000000181AF2990
	// [XID] // 0x00000001895FA9E0-0x00000001895FAA00
	public void ShowMessage(string content) {} // 0x0000000181AF2440-0x0000000181AF2640
	// [XID] // 0x0000000189602330-0x0000000189602350
	public override void UpdateView() {} // 0x0000000181AF2990-0x0000000181AF2AF0
	// [XID] // 0x0000000189609B70-0x0000000189609B90
	public override void ClearView() {} // 0x0000000181AF2100-0x0000000181AF2200
	// [XID] // 0x0000000189611300-0x0000000189611320
	private void StartMessage() {} // 0x0000000181AF2640-0x0000000181AF2820
	// [XID] // 0x0000000189618CF0-0x0000000189618D10
	private void EndMessage() {} // 0x0000000181AF2200-0x0000000181AF2320
}

