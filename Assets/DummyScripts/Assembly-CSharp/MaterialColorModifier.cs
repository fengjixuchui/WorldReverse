/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MaterialColorModifier // TypeDefIndex: 31551
{
	// Fields
	private int propId; // 0x10
	private UnityEngine.Material material; // 0x18
	private Color originalColor; // 0x20
	private Color currentColor; // 0x30
	private List<Multiplier> multiplierList; // 0x40

	// Nested types
	public class Multiplier // TypeDefIndex: 31552
	{
		// Fields
		public Color mulColor; // 0x10

		// Constructors
		public Multiplier() {} // 0x00000001818CA7B0-0x00000001818CA830
	}

	// Constructors
	public MaterialColorModifier() {} // 0x00000001818BF710-0x00000001818BF780
	public MaterialColorModifier(UnityEngine.Material material) {} // 0x00000001818BF5F0-0x00000001818BF710

	// Methods
	// [XID] // 0x0000000189AEF570-0x0000000189AEF590
	public void Multiply(Color mulColor) {} // 0x00000001818BF180-0x00000001818BF280
	// [XID] // 0x0000000189AF69F0-0x0000000189AF6A10
	public Multiplier AddMultiplier() => default; // 0x00000001818BF500-0x00000001818BF5F0
	// [XID] // 0x0000000189AFE000-0x0000000189AFE020
	public void RemoveMultiplier(Multiplier multiplier) {} // 0x00000001818BF420-0x00000001818BF500
	// [XID] // 0x0000000189B057D0-0x0000000189B057F0
	public void ApplyAndReset() {} // 0x00000001818BF280-0x00000001818BF420
	// [XID] // 0x0000000189B0CF80-0x0000000189B0CFA0
	public bool IsValid() => default; // 0x00000001818BF0D0-0x00000001818BF180
}

