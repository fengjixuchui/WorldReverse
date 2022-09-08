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
public class P3D_Painter // TypeDefIndex: 9435
{
	// Fields
	public bool Dirty; // 0x10
	public Texture2D Canvas; // 0x18
	public Texture2D CanvasCopy; // 0x20
	public Vector2 Tiling; // 0x28
	public Vector2 Offset; // 0x30
	private static P3D_Painter tempInstance; // 0x00

	// Properties
	public static P3D_Painter TempInstance { get => default; } // 0x000000018723A5A0-0x000000018723A640 
	public bool IsReady { get => default; } // 0x000000018723A4E0-0x000000018723A5A0 

	// Constructors
	public P3D_Painter() {} // 0x000000018723A440-0x000000018723A4E0

	// Methods
	public void SetCanvas(GameObject gameObject, string textureName = "_MainTex" /* Metadata: 0x00AE5904 */, int newMaterialIndex = 0 /* Metadata: 0x00AE5910 */) {} // 0x000000018723A2E0-0x000000018723A440
	public void SetCanvas(Texture newTexture, Vector2 newTiling, Vector2 newOffset) {} // 0x0000000187239F80-0x000000018723A2E0
	public void ApplyCopyCanvasTexure() {} // 0x0000000187239740-0x0000000187239930
	public bool Paint(P3D_Brush brush, List<P3D_Result> results, P3D_CoordType coord = P3D_CoordType.UV1 /* Metadata: 0x00AE5914 */) => default; // 0x00000001872399F0-0x0000000187239AF0
	public bool Paint(P3D_Brush brush, P3D_Result result, P3D_CoordType coord = P3D_CoordType.UV1 /* Metadata: 0x00AE5918 */) => default; // 0x0000000187239D80-0x0000000187239E30
	public bool Paint(P3D_Brush brush, Vector2 uv) => default; // 0x0000000187239AF0-0x0000000187239C80
	public bool Paint(P3D_Brush brush, float x, float y) => default; // 0x0000000187239E30-0x0000000187239F80
	public bool Paint(P3D_Brush brush, P3D_Matrix matrix) => default; // 0x0000000187239C80-0x0000000187239D80
	public void Apply() {} // 0x0000000187239930-0x00000001872399F0
}

