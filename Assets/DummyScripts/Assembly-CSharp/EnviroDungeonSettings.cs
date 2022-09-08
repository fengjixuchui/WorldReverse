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
public class EnviroDungeonSettings // TypeDefIndex: 31477
{
	// Fields
	public string profileName; // 0x10
	[NonSerialized]
	public Config config; // 0x18
	// [Tooltip] // 0x0000000189922B50-0x0000000189922B80
	public EnviroConfigColor dungeonLightColor; // 0x30
	public EnviroConfigFloat dungeonLightIntensity; // 0x50

	// Nested types
	public struct Config // TypeDefIndex: 31478
	{
		// Fields
		public Color dungeonLightColor; // 0x00
		public float dungeonLightIntensity; // 0x10
	}

	// Constructors
	public EnviroDungeonSettings() {} // 0x0000000183694A40-0x0000000183694B90

	// Methods
	public void Evaluate(float time) {} // 0x00000001836947B0-0x0000000183694920
	public void Lerp(EnviroDungeonSettings targetSetting, float ratio) {} // 0x0000000183694920-0x0000000183694A40
}

