/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class HeightmapSmoother // TypeDefIndex: 14722
{
	// Constructors
	protected HeightmapSmoother() {} // 0x0000000181B3F050-0x0000000181B3F0B0

	// Methods
	public abstract float[,] Smooth(float[,] heightmap);
	public abstract void SmoothNonAlloc(float[,] heightmap, float[,] result);
}

