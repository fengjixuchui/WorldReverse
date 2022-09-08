/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StateTriggeredAudioEvent<T> // TypeDefIndex: 11223
{
	// Fields
	private Dictionary<T, List<NamedStateAudioEvent<T>>> _events;
	private IAudioEventPoster _poster;

	// Properties
	public OnWillPostEvent willPostEvent { get; set; }

	// Nested types
	public delegate void OnWillPostEvent(T target, T other, NamedStateAudioEvent<T> stateEvent); // TypeDefIndex: 11224; 0x00000000-0x00000000

	// Constructors
	public StateTriggeredAudioEvent() {} // Dummy constructor
	public StateTriggeredAudioEvent(ConfigStateAudioEvent[] rawEvents, ConditionalNamedStateAudioEvent<T> converter, IEqualityComparer<T> comparer, IAudioEventPoster poster) {}

	// Methods
	public void HandleStateChange(T target, T other) {}
}

