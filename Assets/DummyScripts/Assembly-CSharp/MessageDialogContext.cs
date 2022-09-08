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

public sealed class MessageDialogContext : BaseDialogContext // TypeDefIndex: 29198
{
	// Fields
	private const int STATE_OFF = 0; // Metadata: 0x00B0EDD0
	private const int STATE_ON = 1; // Metadata: 0x00B0EDD4
	private Queue<MessageCell> _messageQueue; // 0x178
	private int _state; // 0x180
	private Animator _animator; // 0x188
	private Transform _txtMessage; // 0x190
	private UnityEngine.UI.Text _text; // 0x198
	private Transform _subTxtMessage; // 0x1A0
	private UnityEngine.UI.Text _subText; // 0x1A8

	// Nested types
	public struct MessageCell // TypeDefIndex: 29199
	{
		// Fields
		public string content; // 0x00
		public string subContent; // 0x08
		public Color messageColor; // 0x10
	}

	// Constructors
	public MessageDialogContext() {} // 0x00000001838E3830-0x00000001838E3940

	// Methods
	// [XID] // 0x0000000189AE7BF0-0x0000000189AE7C10
	public override void SetupView() {} // 0x00000001838E35D0-0x00000001838E3780
	// [XID] // 0x0000000189AEF950-0x0000000189AEF970
	public void ShowMessage(string content, Color color, string subContent = "" /* Metadata: 0x00B0EDCC */) {} // 0x00000001838E31B0-0x00000001838E32F0
	// [XID] // 0x0000000189AF6E70-0x0000000189AF6E90
	public override void UpdateView() {} // 0x00000001838E3780-0x00000001838E3830
	// [XID] // 0x0000000189AFE3E0-0x0000000189AFE400
	private void TickMessage() {} // 0x00000001838E3080-0x00000001838E31B0
	// [XID] // 0x0000000189B05B90-0x0000000189B05BB0
	private void StartMessage() {} // 0x00000001838E32F0-0x00000001838E35D0
	// [XID] // 0x0000000189B0D320-0x0000000189B0D340
	private void EndMessage() {} // 0x00000001838E2E50-0x00000001838E2FC0
}

