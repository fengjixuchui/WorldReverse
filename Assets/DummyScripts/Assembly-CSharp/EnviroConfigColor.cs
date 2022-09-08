/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public struct EnviroConfigColor // TypeDefIndex: 31532
{
	// Fields
	public EnviroConfigColorType colorType; // 0x00
	public Color inputColor; // 0x04
	public Gradient gradient; // 0x18

	// Constructors
	public EnviroConfigColor(EnviroConfigColorType colorType, Color inputColor, Gradient gradient) {
		this.colorType = default;
		this.inputColor = default;
		this.gradient = default;
	} // 0x00000001836942D0-0x00000001836944B0

	// Methods
	public Color Evaluate(float time) => default; // 0x00000001836942A0-0x00000001836942D0
}

