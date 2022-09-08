/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ISCShape_Circle : IStatInstantiationContext // TypeDefIndex: 27887
{
	// Fields
	public int index; // 0x10
	public Vector3 pos; // 0x18
	public float radius; // 0x24
	private float _scale; // 0x28

	// Properties
	public int count { /* [XID] */ /* 0x00000001896C14D0-0x00000001896C1510 */ get; set; } // 0x000000018165B3F0-0x000000018165B450 0x000000018165B070-0x000000018165B0D0
	public float scale { /* [XID] */ /* 0x00000001896D3010-0x00000001896D3030 */ get => default; } // 0x000000018165B340-0x000000018165B3F0 

	// Constructors
	public ISCShape_Circle() {} // Dummy constructor
	public ISCShape_Circle(Vector3 inPos, int inCount, float inRadius, float inScale = 1f /* Metadata: 0x00B0D0D3 */) {} // 0x000000018165B650-0x000000018165B740

	// Methods
	// [XID] // 0x00000001896DABE0-0x00000001896DAC00
	public Vector3 GetNextInstantiationPosition() => default; // 0x000000018165B0D0-0x000000018165B340
	// [XID] // 0x00000001896E22D0-0x00000001896E22F0
	public static ISCShape_Circle CreateFromCMDLine(string[] args, Vector3 pos, int startIndex) => default; // 0x000000018165B450-0x000000018165B650
}

