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

[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
public class P3D_BrushPreview : MonoBehaviour // TypeDefIndex: 9425
{
	// Fields
	private static List<P3D_BrushPreview> AllPreviews; // 0x00
	private MeshRenderer meshRenderer; // 0x18
	private MeshFilter meshFilter; // 0x20
	private UnityEngine.Material material; // 0x28
	private int age; // 0x30
	private UnityEngine.Material[] materials; // 0x38

	// Constructors
	public P3D_BrushPreview() {} // 0x0000000187230600-0x0000000187230690
	static P3D_BrushPreview() {} // 0x0000000187230570-0x0000000187230600

	// Methods
	public static void Show(Mesh mesh, int submeshIndex, Transform transform, float opacity, P3D_Matrix paintMatrix, Vector2 canvasResolution, Texture2D shape, Vector2 tiling, Vector2 offset, int uvType = 0 /* Metadata: 0x00AE586E */) {} // 0x000000018722F9C0-0x000000018722FC80
	public static void Mark() {} // 0x000000018722F690-0x000000018722F7F0
	public static void Sweep() {} // 0x000000018722FC80-0x000000018722FE40
	protected virtual void OnEnable() {} // 0x000000018722F910-0x000000018722F9C0
	protected virtual void Update() {} // 0x00000001872304F0-0x0000000187230570
	protected virtual void OnDisable() {} // 0x000000018722F860-0x000000018722F910
	protected virtual void OnDestroy() {} // 0x000000018722F7F0-0x000000018722F860
	private void UpdateShow(Mesh mesh, int submeshIndex, Transform target, float opacity, P3D_Matrix paintMatrix, Vector2 canvasResolution, Texture2D shape, Vector2 tiling, Vector2 offset, int uvType) {} // 0x000000018722FE40-0x00000001872304F0
}

