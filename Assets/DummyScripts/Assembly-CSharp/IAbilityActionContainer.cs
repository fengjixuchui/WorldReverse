/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IAbilityActionContainer // TypeDefIndex: 20565
{
	// Properties
	bool isAttached { get; }

	// Methods
	BaseEntity GetOwner();
	void Attach();
	void AttachEffectPatternIndex(int patternIx, string effectPattern);
	bool Detach();
}

