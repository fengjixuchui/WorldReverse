/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct AttackResultContext // TypeDefIndex: 20526
{
	// Fields
	public bool hasMassiveEntity; // 0x00
	public ShapeType shapeType; // 0x04
	public Vector3 centerPoint; // 0x08
	public float radius; // 0x14
	public Box3 box3; // 0x18
	public List<CollisionResult> attackResultList; // 0x58

	// Nested types
	public enum ShapeType // TypeDefIndex: 20527
	{
		INVALID = -1,
		SPHERE = 0,
		BOX = 1
	}

	// Methods
	// [XID] // 0x00000001899BF790-0x00000001899BF7B0
	public static AttackResultContext Create() => default; // 0x0000000183A72740-0x0000000183A72910
}

