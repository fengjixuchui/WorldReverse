/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TileComplexInfo // TypeDefIndex: 14758
{
	// Fields
	private const float DEFAULT_RADIUS = 0.5f; // Metadata: 0x00AEBED0
	public int lastCheckFrame; // 0x10
	public uint lastCheckEntityId; // 0x14
	private Vector3 _realPos; // 0x18
	private Quaternion _realRotate; // 0x24
	private TileShapeInfo _shapeInfo; // 0x38
	private Bounds _tileBounds; // 0x40

	// Constructors
	public TileComplexInfo() {} // 0x00000001820D2BB0-0x00000001820D2C10

	// Methods
	// [XID] // 0x0000000189B85700-0x0000000189B85720
	public bool IsCapsuleInShape(Vector3 targetCenter, float targetRadius, float targetHeight) => default; // 0x00000001820D2400-0x00000001820D26E0
	// [XID] // 0x0000000189B8C4B0-0x0000000189B8C4D0
	public Bounds GetTileBounds() => default; // 0x00000001820D26E0-0x00000001820D27D0
	// [XID] // 0x0000000189B93EB0-0x0000000189B93ED0
	public static TileComplexInfo Get(Vector3 pos, Quaternion rotate, TileShapeInfo shapeInfo) => default; // 0x00000001820D27D0-0x00000001820D2900
	// [XID] // 0x0000000189B9B470-0x0000000189B9B490
	public void Release() {} // 0x00000001820D2900-0x00000001820D29B0
	// [XID] // 0x0000000189BA2B70-0x0000000189BA2B90
	private void CalcTileBounds() {} // 0x00000001820D29B0-0x00000001820D2BB0
}

