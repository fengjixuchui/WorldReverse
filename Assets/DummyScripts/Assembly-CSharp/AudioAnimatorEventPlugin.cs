/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Audio.Logging;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioAnimatorEventPlugin : AudioComponentPlugin // TypeDefIndex: 11993
{
	// Fields
	private static readonly ConditionalNamedStateAudioEvent<int> _hashConverter; // 0x00
	private readonly bool _triggersSpeech; // 0x60
	private StateTriggeredAudioEvent<int> _animatorTransitionInEvents; // 0x68
	private StateTriggeredAudioEvent<int> _animatorTransitionOutEvents; // 0x70
	private Animator _animator; // 0x78
	private AnimatorRecurrentSpeechTicker _speechTicker; // 0x80
	private AnimatorController _controller4hi; // 0x88
	private AudioLog.Entity.AnimatorEvent.AnimatorStateInfoBundle _lastFrameStates; // 0x90

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897487F0-0x0000000189748810 */ get => default; } // 0x00000001835616D0-0x0000000183561770 

	// Nested types
	private class AnimatorStateNameHashConverter : ConditionalNamedStateAudioEvent<int> // TypeDefIndex: 11994
	{
		// Constructors
		public AnimatorStateNameHashConverter() {} // 0x000000018357BE00-0x000000018357BE60

		// Methods
		// [XID] // 0x00000001897EF7E0-0x00000001897EF800
		public int Convert(string nextStateName) => default; // 0x000000018357BD50-0x000000018357BE00
	}

	private class EventPoster : IAudioEventPoster // TypeDefIndex: 11995
	{
		// Fields
		private AudioAnimatorEventPlugin _host; // 0x10

		// Constructors
		public EventPoster() {} // Dummy constructor
		public EventPoster(AudioAnimatorEventPlugin host) {} // 0x000000018357BB50-0x000000018357BBC0

		// Methods
		// [XID] // 0x00000001897F6EE0-0x00000001897F6F00
		public void PostEvent(uint eventId) {} // 0x000000018357BA60-0x000000018357BB50
	}

	// Constructors
	public AudioAnimatorEventPlugin() {} // Dummy constructor
	static AudioAnimatorEventPlugin() {} // 0x0000000183561580-0x0000000183561640
	public AudioAnimatorEventPlugin(VCBaseAudio owner, bool triggersSpeech) {} // 0x0000000183561640-0x00000001835616D0

	// Methods
	// [XID] // 0x000000018974FD90-0x000000018974FDB0
	public override void Init() {} // 0x0000000183560BA0-0x0000000183560D30
	// [XID] // 0x0000000189757460-0x0000000189757480
	public override void Destroy() {} // 0x00000001835601B0-0x00000001835602C0
	// [XID] // 0x000000018975EBB0-0x000000018975EBD0
	public override void Tick(float inDeltaTime) {} // 0x00000001835614C0-0x0000000183561580
	// [XID] // 0x0000000189766090-0x00000001897660B0
	public void SetConfig(ConfigAnimationAudio config) {} // 0x0000000183560870-0x0000000183560AA0
	// [XID] // 0x000000018976D8E0-0x000000018976D900
	public void HandleAnimatorAudio(AnimatorEventAudio animEvent) {} // 0x000000018355FEA0-0x000000018355FFF0
	// [XID] // 0x00000001899BA2E0-0x00000001899BA300
	public int GetCurrentAnimatorStateShortHash() => default; // 0x0000000183560420-0x0000000183560590
	// [XID] // 0x000000018977C5C0-0x000000018977C5E0
	public string GetAnimatorStateNameByShortHash(int hash) => default; // 0x00000001835606D0-0x0000000183560870
	// [XID] // 0x00000001897840C0-0x00000001897840E0
	private void FindAnimatorController4hi(BaseEntity entity) {} // 0x00000001835602C0-0x00000001835603D0
	// [XID] // 0x000000018978B830-0x000000018978B850
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x0000000183560D30-0x0000000183560F10
	// [XID] // 0x0000000189792C30-0x0000000189792C50
	private void TickRecurrentSpeech(float inDeltaTime) {} // 0x00000001835600B0-0x00000001835601B0
	// [Conditional] // 0x000000018979A300-0x000000018979A350
	// [XID] // 0x000000018979A300-0x000000018979A350
	private void TickAnimatorState() {} // 0x0000000183561180-0x00000001835614C0
	// [Conditional] // 0x00000001897A53A0-0x00000001897A53F0
	// [XID] // 0x00000001897A53A0-0x00000001897A53F0
	private void LogTransitionEvents() {} // 0x0000000183560FE0-0x0000000183561130
	// [Conditional] // 0x00000001897AFB40-0x00000001897AFB90
	// [XID] // 0x00000001897AFB40-0x00000001897AFB90
	private void LogAnimatorEvent(AnimatorEventAudio animEvent) {} // 0x0000000183560610-0x00000001835606D0
	// [Conditional] // 0x00000001897BA4F0-0x00000001897BA540
	// [XID] // 0x00000001897BA4F0-0x00000001897BA540
	private void LogRejectAnimatorEvent(AnimatorEventAudio animEvent) {} // 0x000000018355FFF0-0x00000001835600B0
	// [Conditional] // 0x00000001897C5680-0x00000001897C56D0
	// [XID] // 0x00000001897C5680-0x00000001897C56D0
	private void LogTransitionEvent(int fromStateHash, int toStateHash, NamedStateAudioEvent<int> stateEvent) {} // 0x0000000183560AA0-0x0000000183560BA0
	// [Conditional] // 0x00000001897CFDC0-0x00000001897CFE10
	// [XID] // 0x00000001897CFDC0-0x00000001897CFE10
	private void LogStateChange(AudioLog.Entity.AnimatorEvent.AnimatorStateInfoBundle lastFrame, AudioLog.Entity.AnimatorEvent.AnimatorStateInfoBundle thisFrame) {} // 0x000000018355FC80-0x000000018355FE40
}

