/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface BaseShape // TypeDefIndex: 20537
{
	// Methods
	bool IsPointIn(Vector3 point, float? overrideCenterY = default, float? overrideRange = default);
	void Draw(Color color, float duration);
	float Extent();
	Vector3 GetCenter();
	Vector3? GetRandomPoint();
}

