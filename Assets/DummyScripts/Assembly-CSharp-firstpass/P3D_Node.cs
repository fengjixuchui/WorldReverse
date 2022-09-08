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
public class P3D_Node // TypeDefIndex: 9432
{
	// Fields
	private static List<P3D_Node> pool; // 0x00
	public Bounds Bound; // 0x10
	public bool Split; // 0x28
	public int PositiveIndex; // 0x2C
	public int NegativeIndex; // 0x30
	public int TriangleIndex; // 0x34
	public int TriangleCount; // 0x38

	// Constructors
	public P3D_Node() {} // 0x0000000187236E20-0x0000000187236E80
	static P3D_Node() {} // 0x0000000187236D90-0x0000000187236E20

	// Methods
	public static P3D_Node Spawn() => default; // 0x0000000187236BD0-0x0000000187236D90
	public static P3D_Node Despawn(P3D_Node node) => default; // 0x0000000187236AF0-0x0000000187236BD0
	public void CalculateBound(List<P3D_Triangle> triangles) {} // 0x0000000187236870-0x0000000187236AF0
}

