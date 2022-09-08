/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public class P3D_Triangle // TypeDefIndex: 9440
{
	// Fields
	private static List<P3D_Triangle> pool; // 0x00
	public Vector3 PointA; // 0x10
	public Vector3 PointB; // 0x1C
	public Vector3 PointC; // 0x28
	public Vector2 Coord1A; // 0x34
	public Vector2 Coord1B; // 0x3C
	public Vector2 Coord1C; // 0x44
	public Vector2 Coord2A; // 0x4C
	public Vector2 Coord2B; // 0x54
	public Vector2 Coord2C; // 0x5C
	public Vector2 Coord3A; // 0x64
	public Vector2 Coord3B; // 0x6C
	public Vector2 Coord3C; // 0x74
	public Vector2 Coord4A; // 0x7C
	public Vector2 Coord4B; // 0x84
	public Vector2 Coord4C; // 0x8C
	public int IndexA; // 0x94
	public int IndexB; // 0x98
	public int IndexC; // 0x9C
	public Vector3 Normal; // 0xA0

	// Properties
	public Vector3 Edge1 { get => default; } // 0x00000001860106D0-0x00000001860107D0 
	public Vector3 Edge2 { get => default; } // 0x00000001860107D0-0x00000001860108D0 
	public Vector3 Min { get => default; } // 0x0000000186010B80-0x0000000186010CB0 
	public Vector3 Max { get => default; } // 0x00000001860108D0-0x0000000186010A00 
	public float MidX { get => default; } // 0x0000000186010A00-0x0000000186010A80 
	public float MidY { get => default; } // 0x0000000186010A80-0x0000000186010B00 
	public float MidZ { get => default; } // 0x0000000186010B00-0x0000000186010B80 

	// Constructors
	public P3D_Triangle() {} // 0x0000000186010670-0x00000001860106D0
	static P3D_Triangle() {} // 0x00000001860105E0-0x0000000186010670

	// Methods
	public static P3D_Triangle Spawn() => default; // 0x0000000186010420-0x00000001860105E0
	public static P3D_Triangle Despawn(P3D_Triangle triangle) => default; // 0x0000000186010370-0x0000000186010420
}

