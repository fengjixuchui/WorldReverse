/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MonsterBeingHitAfterImageEntry : ISimplePoolObject // TypeDefIndex: 32137
{
	// Fields
	public Vector3[] positions; // 0x10
	public Quaternion[] rotations; // 0x18
	public Vector3[] scales; // 0x20
	public Mesh[] bakedMesh; // 0x28
	public Vector3 effectDir; // 0x30
	public float effectTime; // 0x3C
	public MonsterBeingHitAfterImageAssetData effectData; // 0x40
	private static MaterialPropertyBlock matPropertyBlock; // 0x00

	// Constructors
	public MonsterBeingHitAfterImageEntry() {} // 0x0000000181D0B860-0x0000000181D0B950
	static MonsterBeingHitAfterImageEntry() {} // 0x0000000181D0B7E0-0x0000000181D0B860

	// Methods
	// [XID] // 0x000000018998D1B0-0x000000018998D1D0
	public void ResetObject() {} // 0x0000000181D0B610-0x0000000181D0B7E0
	// [XID] // 0x0000000189994D10-0x0000000189994D30
	public bool CalcAndRender(SkinnedMeshRenderer[] renderers, int rendererCount, float time) => default; // 0x0000000181D0AE60-0x0000000181D0B610
}

