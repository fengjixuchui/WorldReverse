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

public class ExternalSourceVoiceIntention : IBeginEventCallbackVoiceIntention, IEndEventCallbackVoiceIntention, IFakeAvatarVoiceIntention // TypeDefIndex: 11518
{
	// Fields
	private readonly List<IExternalSourceVoiceStartResponder> _startResponders; // 0x10
	private readonly List<IExternalSourceVoiceStopResponder> _stopResponders; // 0x18

	// Properties
	public string externalSource { /* [XID] */ /* 0x000000018974B870-0x000000018974B8B0 */ get; /* [XID] */ /* 0x0000000189755E20-0x0000000189755E60 */ set; } // 0x0000000180F7ACE0-0x0000000180F7AD40 0x0000000180F7B520-0x0000000180F7B580
	public uint externalVoiceId { /* [XID] */ /* 0x00000001897603F0-0x0000000189760430 */ get; /* [XID] */ /* 0x000000018976AAD0-0x000000018976AB10 */ set; } // 0x0000000180F7AB00-0x0000000180F7AB60 0x0000000180F7B460-0x0000000180F7B4C0
	public uint voiceSwitchId { /* [XID] */ /* 0x0000000189774D80-0x0000000189774DC0 */ get; /* [XID] */ /* 0x000000018977F540-0x000000018977F580 */ set; } // 0x0000000180F7A130-0x0000000180F7A190 0x0000000180F7AC20-0x0000000180F7AC80
	public VoicePersonality? overridePersonality { /* [XID] */ /* 0x0000000189789D10-0x0000000189789D50 */ get; /* [XID] */ /* 0x00000001897941A0-0x00000001897941E0 */ set; } // 0x0000000180F7A1F0-0x0000000180F7A250 0x0000000180F7AE40-0x0000000180F7AEA0
	public VoicePositioning? overridePositioning { /* [XID] */ /* 0x000000018979F550-0x000000018979F590 */ get; /* [XID] */ /* 0x00000001897A99C0-0x00000001897A9A00 */ set; } // 0x0000000180F7A320-0x0000000180F7A380 0x0000000180F7B4C0-0x0000000180F7B520
	public IIntentionSubmitter submitter { get; /* [XID] */ /* 0x00000001897BC7B0-0x00000001897BC7F0 */ set; } // 0x0000000180F7A190-0x0000000180F7A1F0 0x0000000180F7AC80-0x0000000180F7ACE0
	public VoiceQueueBehaviour queueBehaviour { /* [XID] */ /* 0x00000001897C7070-0x00000001897C7090 */ get => default; } // 0x0000000180F7AB60-0x0000000180F7AC20 
	public bool clearQueue { /* [XID] */ /* 0x00000001897CE6A0-0x00000001897CE6C0 */ get => default; } // 0x0000000180F7A810-0x0000000180F7A8D0 

	// Constructors
	public ExternalSourceVoiceIntention() {} // 0x0000000180F7B580-0x0000000180F7B630

	// Methods
	// [XID] // 0x00000001899C7D90-0x00000001899C7DB0
	public bool CanInterrupt(IVoiceIntention other) => default; // 0x0000000180F7A380-0x0000000180F7A4B0
	// [XID] // 0x00000001897DD4B0-0x00000001897DD4D0
	public AudioPostedEventStatus Play(object cookie, SyncId syncId, EventStartCallback startCallback, EventCallback callback, AkCallbackType callbackMask) => default; // 0x0000000180F7AFD0-0x0000000180F7B460
	// [XID] // 0x0000000189A690C0-0x0000000189A690E0
	public void BeginEventCallback(int stub) {} // 0x0000000180F7A8D0-0x0000000180F7AA00
	// [XID] // 0x00000001897ECA30-0x00000001897ECA50
	public void EndEventCallback(int stub) {} // 0x0000000180F7AEA0-0x0000000180F7AFD0
	// [XID] // 0x00000001897F4280-0x00000001897F42A0
	public string GetEmosyncAssetPath() => default; // 0x0000000180F7AA00-0x0000000180F7AB00
	// [XID] // 0x00000001897FBCE0-0x00000001897FBD00
	public ExternalVoiceItem GetVoiceItem() => default; // 0x0000000180F7AD40-0x0000000180F7AE40
	// [XID] // 0x0000000189B1D1C0-0x0000000189B1D1E0
	public void AddStartResponder(IExternalSourceVoiceStartResponder responder) {} // 0x0000000180F7A4B0-0x0000000180F7A580
	// [XID] // 0x000000018980A660-0x000000018980A680
	public void AddStopResponder(IExternalSourceVoiceStopResponder responder) {} // 0x0000000180F7A250-0x0000000180F7A320
	// [XID] // 0x0000000189811D60-0x0000000189811D80
	public void Recycle() {} // 0x0000000180F7A580-0x0000000180F7A810
}

