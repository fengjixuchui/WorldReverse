/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TalkDialogVoiceEventResponder : IDialogVoiceEventResponder // TypeDefIndex: 20950
{
	// Fields
	private uint _waitDialogId; // 0x10
	private float _finishDuration; // 0x14
	private Coroutine _dialogFinishCoroutine; // 0x18
	private bool _isWaiting; // 0x20

	// Properties
	public bool isWaiting { /* [XID] */ /* 0x000000018997B670-0x000000018997B690 */ get => default; } // 0x0000000181BF9610-0x0000000181BF96B0 

	// Constructors
	public TalkDialogVoiceEventResponder() {} // 0x0000000181BF98D0-0x0000000181BF99B0

	// Methods
	// [XID] // 0x0000000189983110-0x0000000189983130
	public void SetWaitDialogId(uint dialogId) {} // 0x0000000181BF9250-0x0000000181BF9300
	// [XID] // 0x000000018998A860-0x000000018998A880
	public void Clear() {} // 0x0000000181BF9300-0x0000000181BF9400
	// [XID] // 0x0000000189992140-0x0000000189992160
	public void RespondToDialogVoiceEvent(uint dialogId, bool startPlaying) {} // 0x0000000181BF96B0-0x0000000181BF98D0
	// [XID] // 0x0000000189999E90-0x0000000189999EB0
	public void FinishTalkDialogAfterTimes(uint dialogId) {} // 0x0000000181BF9400-0x0000000181BF9610
	// [XID] // 0x00000001899A1550-0x00000001899A1570
	private void TryFinishTalkDialog(uint dialogId) {} // 0x0000000181BF90D0-0x0000000181BF9250
}

