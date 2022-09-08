/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ReusedAudioSync // TypeDefIndex: 11477
{
	// Fields
	private readonly EventCallback _callback; // 0x10
	private float _timeLeft; // 0x18

	// Properties
	public SyncId syncId { /* [XID] */ /* 0x000000018996B8D0-0x000000018996B910 */ get; /* [XID] */ /* 0x0000000189976290-0x00000001899762D0 */ set; } // 0x0000000181292420-0x0000000181292490 0x0000000181292490-0x0000000181292500
	public float duration { /* [XID] */ /* 0x00000001899808E0-0x0000000189980920 */ get; /* [XID] */ /* 0x000000018998B5C0-0x000000018998B600 */ set; } // 0x0000000181291C40-0x0000000181291CB0 0x00000001812921C0-0x0000000181292230
	public bool finished { /* [XID] */ /* 0x0000000189996060-0x00000001899960A0 */ get; /* [XID] */ /* 0x00000001899A0B10-0x00000001899A0B50 */ set; } // 0x0000000181292230-0x0000000181292290 0x0000000181291CB0-0x0000000181291D10
	public uint endEvent { /* [XID] */ /* 0x00000001899AB5B0-0x00000001899AB5F0 */ get; /* [XID] */ /* 0x00000001899B5AC0-0x00000001899B5B00 */ set; } // 0x00000001812923C0-0x0000000181292420 0x00000001812925A0-0x0000000181292600
	public EventCallback callback { /* [XID] */ /* 0x00000001899C03B0-0x00000001899C03D0 */ get => default; } // 0x0000000181292500-0x00000001812925A0 

	// Constructors
	public ReusedAudioSync() {} // 0x0000000181292600-0x00000001812926A0

	// Methods
	// [XID] // 0x00000001899C7C30-0x00000001899C7C50
	public void Start() {} // 0x00000001812920E0-0x00000001812921C0
	// [XID] // 0x00000001899CF3F0-0x00000001899CF410
	public void Tick(float deltaTime) {} // 0x0000000181292290-0x00000001812923C0
	// [XID] // 0x00000001899D68F0-0x00000001899D6910
	public void Recycle() {} // 0x0000000181291D10-0x0000000181291F20
	// [XID] // 0x00000001899DDF10-0x00000001899DDF30
	private void EventCallback(object cookie, AkCallbackType callbackType, MmoronCallbackInfo callbackInfo) {} // 0x0000000181291F20-0x00000001812920E0
}

