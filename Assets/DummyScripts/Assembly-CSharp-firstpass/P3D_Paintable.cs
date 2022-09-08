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

public class P3D_Paintable : MonoBehaviour // TypeDefIndex: 9433
{
	// Fields
	public static List<P3D_Paintable> AllPaintables; // 0x00
	// [Tooltip] // 0x00000001897A9AE0-0x00000001897A9B10
	public int SubMeshIndex; // 0x18
	// [Tooltip] // 0x00000001897B2D50-0x00000001897B2D80
	public float UpdateInterval; // 0x1C
	// [Tooltip] // 0x00000001897BC920-0x00000001897BC950
	public float ApplyInterval; // 0x20
	// [Tooltip] // 0x00000001897C5950-0x00000001897C5980
	public List<P3D_PaintableTexture> Textures; // 0x28
	private P3D_Tree tree; // 0x30
	private Mesh bakedMesh; // 0x38
	private float updateCooldown; // 0x40
	private float applyCooldown; // 0x44

	// Properties
	public bool IsReady { get => default; } // 0x00000001872396C0-0x0000000187239740 

	// Constructors
	public P3D_Paintable() {} // 0x0000000187239650-0x00000001872396C0
	static P3D_Paintable() {} // 0x00000001872395C0-0x0000000187239650

	// Methods
	public static void ScenePaintNearest(P3D_Brush brush, Vector3 position, float maxDistance, int layerMask = -1 /* Metadata: 0x00AE58B8 */, int groupMask = -1 /* Metadata: 0x00AE58BC */) {} // 0x0000000187238BD0-0x0000000187238EB0
	public static void ScenePaintBetweenNearest(P3D_Brush brush, Vector3 startPosition, Vector3 endPosition, int layerMask = -1 /* Metadata: 0x00AE58C0 */, int groupMask = -1 /* Metadata: 0x00AE58C4 */) {} // 0x00000001872385B0-0x0000000187238BD0
	public static void ScenePaintBetweenAll(P3D_Brush brush, Vector3 startPosition, Vector3 endPosition, int layerMask = -1 /* Metadata: 0x00AE58C8 */, int groupMask = -1 /* Metadata: 0x00AE58CC */) {} // 0x00000001872383B0-0x00000001872385B0
	public static void ScenePaintPerpedicularNearest(P3D_Brush brush, Vector3 position, float maxDistance, int layerMask = -1 /* Metadata: 0x00AE58D0 */, int groupMask = -1 /* Metadata: 0x00AE58D4 */) {} // 0x0000000187239090-0x0000000187239370
	public static void ScenePaintPerpedicularAll(P3D_Brush brush, Vector3 position, float maxDistance, int layerMask = -1 /* Metadata: 0x00AE58D8 */, int groupMask = -1 /* Metadata: 0x00AE58DC */) {} // 0x0000000187238EB0-0x0000000187239090
	public void PaintPerpendicularNearest(P3D_Brush brush, Vector3 position, float maxDistance, int groupMask = -1 /* Metadata: 0x00AE58E0 */) {} // 0x0000000187237DD0-0x0000000187237F30
	public void PaintPerpendicularAll(P3D_Brush brush, Vector3 position, float maxDistance, int groupMask = -1 /* Metadata: 0x00AE58E4 */) {} // 0x0000000187237C70-0x0000000187237DD0
	public void PaintNearest(P3D_Brush brush, Vector3 position, float maxDistance, int groupMask = -1 /* Metadata: 0x00AE58E8 */) {} // 0x0000000187237B10-0x0000000187237C70
	public void PaintBetweenNearest(P3D_Brush brush, Vector3 startPosition, Vector3 endPosition, int groupMask = -1 /* Metadata: 0x00AE58EC */) {} // 0x0000000187237980-0x0000000187237B10
	public void PaintBetweenAll(P3D_Brush brush, Vector3 startPosition, Vector3 endPosition, int groupMask = -1 /* Metadata: 0x00AE58F0 */) {} // 0x00000001872377F0-0x0000000187237980
	public void Paint(P3D_Brush brush, List<P3D_Result> results, int groupMask = -1 /* Metadata: 0x00AE58F4 */) {} // 0x00000001872381C0-0x00000001872382A0
	public void Paint(P3D_Brush brush, P3D_Result result, int groupMask = -1 /* Metadata: 0x00AE58F8 */) {} // 0x0000000187238090-0x00000001872381C0
	public void Paint(P3D_Brush brush, RaycastHit hit, int groupMask = -1 /* Metadata: 0x00AE58FC */) {} // 0x0000000187237F30-0x0000000187238090
	public void Paint(P3D_Brush brush, Vector2 uv, int groupMask = -1 /* Metadata: 0x00AE5900 */) {} // 0x00000001872382A0-0x00000001872383B0
	public P3D_Tree GetTree() => default; // 0x0000000187237600-0x0000000187237690
	// [ContextMenu] // 0x00000001897CE720-0x00000001897CE750
	public void AddTexture() {} // 0x00000001872373C0-0x0000000187237490
	// [ContextMenu] // 0x00000001897D7880-0x00000001897D78B0
	public void UpdateTree() {} // 0x0000000187239370-0x0000000187239490
	protected virtual void Awake() {} // 0x0000000187237490-0x0000000187237570
	protected virtual void OnEnable() {} // 0x0000000187237740-0x00000001872377F0
	protected virtual void Update() {} // 0x0000000187239490-0x00000001872395C0
	protected virtual void OnDisable() {} // 0x0000000187237690-0x0000000187237740
	private bool CheckTree() => default; // 0x0000000187237570-0x0000000187237600
}

