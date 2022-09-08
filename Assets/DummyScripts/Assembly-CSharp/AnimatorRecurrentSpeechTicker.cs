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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AnimatorRecurrentSpeechTicker // TypeDefIndex: 11473
{
	// Fields
	private float _timer; // 0x10
	private Animator _animator; // 0x18
	private IAudioEventPoster _poster; // 0x20
	private ConfigAnimationRecurrentSpeech _currentStateSpeech; // 0x28
	private Dictionary<int, ConfigAnimationRecurrentSpeech> _recurrentSpeeches; // 0x30

	// Constructors
	public AnimatorRecurrentSpeechTicker() {} // Dummy constructor
	public AnimatorRecurrentSpeechTicker(Animator animator, IAudioEventPoster poster) {} // 0x00000001818B29B0-0x00000001818B2A70

	// Methods
	// [XID] // 0x000000018989B3D0-0x000000018989B3F0
	public void SetConfig(Dictionary<string, ConfigAnimationRecurrentSpeech> recurrentSpeeches) {} // 0x00000001818B2610-0x00000001818B2840
	// [XID] // 0x00000001898A2850-0x00000001898A2870
	public void ApplySpeechConfigForState(int stateNameHash) {} // 0x00000001818B2240-0x00000001818B2320
	// [XID] // 0x00000001898A9E00-0x00000001898A9E20
	public void Tick(float deltaTime) {} // 0x00000001818B24A0-0x00000001818B2610
	// [XID] // 0x00000001898B1830-0x00000001898B1850
	private void ApplySpeechConfigForCurrentState() {} // 0x00000001818B2320-0x00000001818B24A0
	// [XID] // 0x00000001898B9180-0x00000001898B91A0
	private void SetCountdownTime(bool virgin) {} // 0x00000001818B2840-0x00000001818B29B0
}

