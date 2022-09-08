/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DialogVoiceEventAdapter : IExternalSourceVoiceStartResponder, IExternalSourceVoiceStopResponder // TypeDefIndex: 11512
{
	// Fields
	private static readonly Stack<DialogVoiceEventAdapter> _instances; // 0x00

	// Properties
	public IDialogVoiceEventResponder responder { /* [XID] */ /* 0x00000001896D2970-0x00000001896D29B0 */ get; /* [XID] */ /* 0x00000001896DD030-0x00000001896DD070 */ private set; } // 0x0000000184C2CE20-0x0000000184C2CE80 0x0000000184C2CA60-0x0000000184C2CAC0

	// Constructors
	static DialogVoiceEventAdapter() {} // 0x0000000184C2D130-0x0000000184C2D1C0
	public DialogVoiceEventAdapter() {} // 0x0000000184C2D1C0-0x0000000184C2D220

	// Methods
	// [XID] // 0x000000018995FD90-0x000000018995FDB0
	public static DialogVoiceEventAdapter New(IDialogVoiceEventResponder responder) => default; // 0x0000000184C2CF80-0x0000000184C2D130
	// [XID] // 0x00000001896EEC20-0x00000001896EEC40
	public static void Recycle(DialogVoiceEventAdapter instance) {} // 0x0000000184C2CAC0-0x0000000184C2CBF0
	// [XID] // 0x00000001896F6600-0x00000001896F6620
	public void RespondToExternalSourceVoiceStart(ExternalSourceVoiceIntention intention, int stub) {} // 0x0000000184C2CD50-0x0000000184C2CE20
	// [XID] // 0x00000001896FDD50-0x00000001896FDD70
	public void RespondToExternalSourceVoiceStop(ExternalSourceVoiceIntention intention, int stub) {} // 0x0000000184C2CE80-0x0000000184C2CF80
	// [XID] // 0x000000018997D7B0-0x000000018997D7D0
	private void ConvertAndTrigger(ExternalSourceVoiceIntention intention, bool startPlaying) {} // 0x0000000184C2CBF0-0x0000000184C2CD50
}

