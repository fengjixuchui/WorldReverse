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
public class P3D_Vertex // TypeDefIndex: 9442
{
	// Fields
	private static List<P3D_Vertex> pool; // 0x00
	public Vector3 position; // 0x10
	public int index; // 0x1C
	public List<Vector3> triangleNormals; // 0x20
	public Vector3 vertexNormal; // 0x28

	// Constructors
	public P3D_Vertex() {} // 0x0000000186015AA0-0x0000000186015B30
	static P3D_Vertex() {} // 0x0000000186015A10-0x0000000186015AA0

	// Methods
	public static P3D_Vertex Spawn() => default; // 0x0000000186015890-0x0000000186015A10
	public static void Despawn(P3D_Vertex vertex) {} // 0x00000001860157E0-0x0000000186015890
	public void CalculateVertexNormalAndClearTriangleNormals() {} // 0x00000001860154D0-0x00000001860157E0
}

