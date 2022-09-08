/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface ICombatSceneProp : ISceneProp, IHitShake // TypeDefIndex: 31840
{
	// Methods
	void BeingHit(EvtBeingHit beingHitEvent);
	Bounds GetBounds();
	Vector3 GetPosition();
	uint GetConfigID();
	int GetEffectConfigID();
	void RefreshEffectConfig();
	Transform GetTransform();
	Vector3 GetRootOffset();
	void Die();
}

