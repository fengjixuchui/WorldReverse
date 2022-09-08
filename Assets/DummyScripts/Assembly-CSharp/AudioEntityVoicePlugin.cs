/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioEntityVoicePlugin : AudioVoicePickerPlugin // TypeDefIndex: 12010
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A51EE0-0x0000000189A51F00 */ get; } // 0x000000018275D860-0x000000018275D900 

	// Constructors
	protected AudioEntityVoicePlugin() {} // Dummy constructor
	protected AudioEntityVoicePlugin(VCBaseAudio component) {} // 0x000000018275D7E0-0x000000018275D860

	// Methods
	// [XID] // 0x00000001895F1320-0x00000001895F1340
	public virtual bool PostVoiceEvent(uint triggerArg, IExternalSourceVoiceStartResponder startResponder, IExternalSourceVoiceStopResponder stopResponder) => default; // 0x000000018275D620-0x000000018275D7E0
	// [XID] // 0x00000001896BF740-0x00000001896BF760
	protected virtual AudioVoiceStreamPlugin GetTeamEntityVoiceStreamPlugin() => default; // 0x000000018275D490-0x000000018275D5B0
}

