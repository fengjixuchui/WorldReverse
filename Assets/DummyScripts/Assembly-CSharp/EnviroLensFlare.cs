/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class EnviroLensFlare : ScriptableObject // TypeDefIndex: 31463
{
	// Fields
	private Flare.FlareElement[] elements; // 0x18
	// [Tooltip] // 0x00000001896DD5D0-0x00000001896DD600
	public List<EnviroConfigColor> flareColors; // 0x20
	public Flare flare; // 0x28

	// Constructors
	public EnviroLensFlare() {} // 0x0000000183698B10-0x0000000183698BA0

	// Methods
	public void Evaluate(float time) {} // 0x00000001836987A0-0x0000000183698AC0
	public void Lerp(EnviroLensFlare targetSetting, float ratio) {} // 0x0000000183698AC0-0x0000000183698B10
}

