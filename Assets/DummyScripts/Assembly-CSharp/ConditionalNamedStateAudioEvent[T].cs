/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ConditionalNamedStateAudioEvent<T> : NamedStateAudioEvent<T> // TypeDefIndex: 11214
{
	// Properties
	public HashSet<T> targetStateHashes { get; private set; }

	// Nested types
	public interface INextStateHashConverter // TypeDefIndex: 11215
	{
		// Methods
		T Convert(string nextStateName);
	}

	// Constructors
	public ConditionalNamedStateAudioEvent() {} // Dummy constructor
	public ConditionalNamedStateAudioEvent(string[] targetStateNames, INextStateHashConverter converter, IEqualityComparer<T> comparer) {}
}

