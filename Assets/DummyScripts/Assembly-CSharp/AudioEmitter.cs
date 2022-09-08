/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AudioEmitter // TypeDefIndex: 11478
{
	// Fields
	private float _emitTimer; // 0x10
	private ConfigAudioEmitter _config; // 0x18
	private AudioEmitterMovement _movement; // 0x20
	private AudioEmitterLifetime _lifetime; // 0x28
	private string _configName; // 0x30
	private object _requester; // 0x38

	// Properties
	public bool isFinished { /* [XID] */ /* 0x00000001899E5CE0-0x00000001899E5D00 */ get => default; } // 0x0000000182022AB0-0x0000000182022B70 
	public AudioEmitterIdentity id { /* [XID] */ /* 0x00000001899ECD60-0x00000001899ECD80 */ get => default; } // 0x0000000182022DE0-0x0000000182022EE0 

	// Constructors
	public AudioEmitter() {} // Dummy constructor
	public AudioEmitter(ConfigAudioEmitter config, AudioEmitterMovement movement, AudioEmitterLifetime lifetime, string configName, object requester) {} // 0x0000000182022EE0-0x0000000182023030

	// Methods
	// [XID] // 0x0000000189BBD600-0x0000000189BBD620
	public void Tick(float deltaTime) {} // 0x0000000182022900-0x0000000182022A10
	// [XID] // 0x0000000189A04EC0-0x0000000189A04EE0
	public void ResetRemainingTime() {} // 0x0000000182022D20-0x0000000182022DE0
	// [XID] // 0x0000000189A03550-0x0000000189A03570
	public void End() {} // 0x0000000182022A10-0x0000000182022AB0
	// [XID] // 0x0000000189BC52C0-0x0000000189BC52E0
	private void TickEmit(float deltaTime) {} // 0x0000000182022B70-0x0000000182022D20
	// [XID] // 0x0000000189A123A0-0x0000000189A123C0
	private void Post(uint startEventId, float duration, uint endEventId, AkMultiPositionType multiPositionType) {} // 0x0000000182022750-0x0000000182022900
}

