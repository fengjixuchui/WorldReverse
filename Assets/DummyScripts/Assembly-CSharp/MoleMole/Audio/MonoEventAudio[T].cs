/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio
{
	public abstract class MonoEventAudio<T> : MonoEventAudio // TypeDefIndex: 31649
		where T : ExDrivenAudioEvents
	{
		// Fields
		private T _drivenEvents;
	
		// Properties
		public override ExDrivenAudioEvents exDrivenEvents { get; }
		protected T drivenEvents { get; }
	
		// Constructors
		protected MonoEventAudio() {}
	
		// Methods
		protected abstract T CreateExDrivenEvents(GameObject[] placeholders, ExDrivenAudioEvents.TimedEvent[] tickEvents, ExDrivenAudioEvents.Event[] enableEvents, ExDrivenAudioEvents.Event[] disableEvents);
		protected virtual void Awake() {}
		protected virtual void OnEnable() {}
		protected virtual void OnDisable() {}
		protected virtual void Update() {}
	}
}
