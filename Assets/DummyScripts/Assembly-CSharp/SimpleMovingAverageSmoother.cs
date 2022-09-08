/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SimpleMovingAverageSmoother : HeightmapSmoother // TypeDefIndex: 14723
{
	// Fields
	private int _n; // 0x10

	// Constructors
	public SimpleMovingAverageSmoother() {} // Dummy constructor
	public SimpleMovingAverageSmoother(int n) {} // 0x0000000183E68330-0x0000000183E683B0

	// Methods
	// [XID] // 0x00000001897243F0-0x0000000189724410
	public void SetN(int n) {} // 0x0000000183E67F50-0x0000000183E68010
	// [XID] // 0x000000018972BA40-0x000000018972BA60
	public override float[,] Smooth(float[,] heightmap) => default; // 0x0000000183E67DD0-0x0000000183E67F50
	// [XID] // 0x0000000189733250-0x0000000189733270
	public override void SmoothNonAlloc(float[,] heightmap, float[,] result) {} // 0x0000000183E68010-0x0000000183E68330
}

