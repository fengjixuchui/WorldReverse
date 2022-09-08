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
public class P3D_Result // TypeDefIndex: 9437
{
	// Fields
	private static List<P3D_Result> pool; // 0x00
	public Vector3 Weights; // 0x10
	public P3D_Triangle Triangle; // 0x20
	public float Distance01; // 0x28
	public Vector3 VertexDistances01; // 0x2C

	// Properties
	public Vector2 UV1 { get => default; } // 0x000000018723B320-0x000000018723B460 
	public Vector2 UV2 { get => default; } // 0x000000018723B460-0x000000018723B5A0 
	public Vector2 UV3 { get => default; } // 0x000000018723B5A0-0x000000018723B6E0 
	public Vector2 UV4 { get => default; } // 0x000000018723B6E0-0x000000018723B820 
	public Vector3 Point { get => default; } // 0x000000018723B140-0x000000018723B320 

	// Constructors
	public P3D_Result() {} // 0x000000018723B0E0-0x000000018723B140
	static P3D_Result() {} // 0x000000018723B050-0x000000018723B0E0

	// Methods
	public static P3D_Result Spawn() => default; // 0x000000018723AE90-0x000000018723B050
	public static P3D_Result Despawn(P3D_Result result) => default; // 0x000000018723AD10-0x000000018723ADC0
	public Vector2 GetUV(P3D_CoordType coord) => default; // 0x000000018723ADC0-0x000000018723AE90
}

