/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public struct P3D_Matrix // TypeDefIndex: 9431
{
	// Fields
	public float m00; // 0x00
	public float m10; // 0x04
	public float m20; // 0x08
	public float m01; // 0x0C
	public float m11; // 0x10
	public float m21; // 0x14
	public float m02; // 0x18
	public float m12; // 0x1C
	public float m22; // 0x20

	// Properties
	public static P3D_Matrix Identity { get => default; } // 0x0000000187236060-0x00000001872363C0 
	public P3D_Matrix Inverse { get => default; } // 0x00000001872363C0-0x0000000187236590 
	public Matrix4x4 Matrix4x4 { get => default; } // 0x0000000187236590-0x00000001872365D0 

	// Methods
	public static P3D_Matrix Translation(float x, float y) => default; // 0x0000000187235FA0-0x0000000187236060
	public static P3D_Matrix Scaling(float x, float y) => default; // 0x0000000187235EE0-0x0000000187235FA0
	public static P3D_Matrix Rotation(float a) => default; // 0x0000000187235DD0-0x0000000187235EE0
	public Vector2 MultiplyPoint(Vector2 v) => default; // 0x0000000187235DB0-0x0000000187235DD0
	public Vector2 MultiplyPoint(float x, float y) => default; // 0x0000000187235CF0-0x0000000187235DB0
	public static P3D_Matrix operator *(P3D_Matrix lhs, P3D_Matrix rhs) => default; // 0x00000001872365D0-0x0000000187236870
}

