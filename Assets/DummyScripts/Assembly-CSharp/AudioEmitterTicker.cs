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

public sealed class AudioEmitterTicker : AudioStuffTicker<AudioEmitter> // TypeDefIndex: 11487
{
	// Fields
	private Dictionary<AudioEmitterIdentity, AudioEmitter> _emitterRegistery; // 0x18

	// Constructors
	public AudioEmitterTicker() {} // 0x0000000182C1FAD0-0x0000000182C1FB80

	// Methods
	// [XID] // 0x00000001899FD870-0x00000001899FD890
	public bool TryGet(AudioEmitterIdentity id, out AudioEmitter emitter) {
		emitter = default;
		return default;
	} // 0x0000000182C1F6B0-0x0000000182C1F7B0
	// [XID] // 0x0000000189673E60-0x0000000189673E80
	protected override void Added(AudioEmitter t) {} // 0x0000000182C1F4E0-0x0000000182C1F5D0
	// [XID] // 0x0000000189AC7730-0x0000000189AC7750
	protected override void Tick(float deltaTime, AudioEmitter t) {} // 0x0000000182C1F5D0-0x0000000182C1F6B0
	// [XID] // 0x0000000189ACECB0-0x0000000189ACECD0
	protected override bool IsFinished(AudioEmitter t) => default; // 0x0000000182C1F860-0x0000000182C1F920
	// [XID] // 0x0000000189AD6C30-0x0000000189AD6C50
	protected override void Terminate(AudioEmitter t, bool natural) {} // 0x0000000182C1F9C0-0x0000000182C1FAD0
	// [XID] // 0x0000000189ADE4A0-0x0000000189ADE4C0
	protected override void Removed(AudioEmitter t) {} // 0x0000000182C1F7B0-0x0000000182C1F860
	// [XID] // 0x0000000189698650-0x0000000189698670
	protected override void Destroyed() {} // 0x0000000182C1F920-0x0000000182C1F9C0
}

