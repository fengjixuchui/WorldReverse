/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class IReplayDebugDraw // TypeDefIndex: 31816
{
	// Constructors
	protected IReplayDebugDraw() {} // 0x0000000184D0AA20-0x0000000184D0AA80

	// Methods
	public abstract void DebugString(string str);
	public abstract void DebugDrawLine(Vector3 from, Vector3 to, Color c);
	public abstract void DebugSphere(Vector3 center, float radius, Color c);
	public abstract void Clear();
}

