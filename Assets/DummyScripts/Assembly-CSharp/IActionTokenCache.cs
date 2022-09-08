/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IActionTokenCache : IComparable<IActionTokenCache> // TypeDefIndex: 21017
{
	// Properties
	bool isCanceled { get; }
	int priority { get; set; }

	// Methods
	IActionTokenConfig GetActionTokenConfig();
	ConfigAbilityActionToken GetActionToken();
	BaseEntity GetTargetEntity();
	bool HandleTokenCache();
	ActionTokenSourceType GetActionSrc();
	bool NeverEnqueue();
	void Destroy();
}

