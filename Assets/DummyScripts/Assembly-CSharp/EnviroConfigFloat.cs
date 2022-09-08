/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public struct EnviroConfigFloat // TypeDefIndex: 31533
{
	// Fields
	public EnviroConfigValueType valueType; // 0x00
	public float inputValue; // 0x04
	public AnimationCurve curve; // 0x08
	[NotSerialized] // 0x000000018999AFD0-0x000000018999B000
	[ShowInInspector] // 0x000000018999AFD0-0x000000018999B000
	public float minValue; // 0x10
	[NotSerialized] // 0x00000001899854C0-0x00000001899854F0
	[ShowInInspector] // 0x00000001899854C0-0x00000001899854F0
	public float maxValue; // 0x14
	[NotSerialized] // 0x00000001899854C0-0x00000001899854F0
	[ShowInInspector] // 0x00000001899854C0-0x00000001899854F0
	public float timeStart; // 0x18
	[NotSerialized] // 0x000000018999AFD0-0x000000018999B000
	[ShowInInspector] // 0x000000018999AFD0-0x000000018999B000
	public float timeEnd; // 0x1C
	[NotSerialized] // 0x000000018999AFD0-0x000000018999B000
	[ShowInInspector] // 0x000000018999AFD0-0x000000018999B000
	public Color curveColor; // 0x20

	// Methods
	public float Evaluate(float time) => default; // 0x00000001836944B0-0x0000000183694560
	public void SetValue(float value) {} // 0x0000000183694560-0x0000000183694640
	public void SetValue(float value, float time) {} // 0x0000000183694640-0x0000000183694750
}

