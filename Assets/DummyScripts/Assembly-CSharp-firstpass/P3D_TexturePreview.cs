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
public class P3D_TexturePreview : MonoBehaviour // TypeDefIndex: 9438
{
	// Fields
	private static List<P3D_TexturePreview> AllPreviews; // 0x00
	private MeshRenderer meshRenderer; // 0x18
	private MeshFilter meshFilter; // 0x20
	private UnityEngine.Material material; // 0x28
	private int age; // 0x30
	private UnityEngine.Material[] materials; // 0x38

	// Constructors
	public P3D_TexturePreview() {} // 0x000000018723C750-0x000000018723C7E0
	static P3D_TexturePreview() {} // 0x000000018723C6C0-0x000000018723C750

	// Methods
	public static void Show(Mesh mesh, int submeshIndex, Transform transform, float opacity, Texture2D texture, Vector2 tiling, Vector2 offset, int uvType = 0 /* Metadata: 0x00AE591C */) {} // 0x000000018723BB50-0x000000018723BDC0
	public static void Mark() {} // 0x000000018723B820-0x000000018723B980
	public static void Sweep() {} // 0x000000018723BDC0-0x000000018723BF80
	protected virtual void OnEnable() {} // 0x000000018723BAA0-0x000000018723BB50
	protected virtual void Update() {} // 0x000000018723C640-0x000000018723C6C0
	protected virtual void OnDisable() {} // 0x000000018723B9F0-0x000000018723BAA0
	protected virtual void OnDestroy() {} // 0x000000018723B980-0x000000018723B9F0
	private void UpdateShow(Mesh mesh, int submeshIndex, Transform target, float opacity, Texture2D texture, Vector2 tiling, Vector2 offset, int uvType) {} // 0x000000018723BF80-0x000000018723C640
}

