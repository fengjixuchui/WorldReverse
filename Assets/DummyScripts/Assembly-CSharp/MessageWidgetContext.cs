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

public sealed class MessageWidgetContext : BaseWidgetContext // TypeDefIndex: 29202
{
	// Fields
	private const int STATE_OFF = 0; // Metadata: 0x00B0EDDD
	private const int STATE_ON = 1; // Metadata: 0x00B0EDE1
	private Queue<MessageCell> _messageQueue; // 0x168
	private int _state; // 0x170
	private Animator _animator; // 0x178
	private Transform _txtMessage; // 0x180
	private UnityEngine.UI.Text _text; // 0x188

	// Nested types
	public struct MessageCell // TypeDefIndex: 29203
	{
		// Fields
		public string content; // 0x00
	}

	// Constructors
	public MessageWidgetContext() {} // 0x0000000181518180-0x0000000181518630

	// Methods
	// [XID] // 0x0000000189B755D0-0x0000000189B755F0
	public override void SetupView() {} // 0x0000000181517F70-0x00000001815180E0
	// [XID] // 0x0000000189B7CA00-0x0000000189B7CA20
	public void ShowMessage(string content) {} // 0x0000000181517BC0-0x0000000181517DC0
	// [XID] // 0x0000000189B84880-0x0000000189B848A0
	public override void UpdateView() {} // 0x00000001815180E0-0x0000000181518180
	// [XID] // 0x0000000189B8B710-0x0000000189B8B730
	public override void ClearView() {} // 0x0000000181517700-0x0000000181517800
	// [XID] // 0x0000000189B92E40-0x0000000189B92E60
	private void TickMessage() {} // 0x0000000181517A90-0x0000000181517BC0
	// [XID] // 0x0000000189B9A400-0x0000000189B9A420
	private void StartMessage() {} // 0x0000000181517DC0-0x0000000181517F70
	// [XID] // 0x0000000189BA1B30-0x0000000189BA1B50
	private void EndMessage() {} // 0x0000000181517800-0x0000000181517970
}

