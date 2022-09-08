/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct SimplePolygon : BaseShape2d // TypeDefIndex: 20543
{
	// Fields
	public Polygon2 shape; // 0x00
	public float yMin; // 0x08
	public float yMax; // 0x0C

	// Methods
	// [XID] // 0x00000001896835F0-0x0000000189683610
	public void Init(Vector2[] vertices, float yMinimum, float yMaximum) {} // 0x00000001815D3440-0x00000001815D3550
	// [XID] // 0x000000018968B230-0x000000018968B250
	public void Release() {} // 0x00000001815D3720-0x00000001815D3960
	// [XID] // 0x0000000189692F70-0x0000000189692F90
	public void Draw(Color color, float duration) {} // 0x00000001815D3090-0x00000001815D30B0
	// [XID] // 0x000000018969A1B0-0x000000018969A1D0
	public float Extent() => default; // 0x00000001815D3960-0x00000001815D3AD0
	// [XID] // 0x00000001896A1A20-0x00000001896A1A40
	public bool IsPointIn(Vector3 point, float? overrideCenterY = default, float? overrideRange = default) => default; // 0x00000001815D32F0-0x00000001815D3440
	// [XID] // 0x00000001896A8EA0-0x00000001896A8EC0
	public bool IsPointInXZ(Vector3 point) => default; // 0x00000001815D3550-0x00000001815D3670
	// [XID] // 0x00000001896AFF90-0x00000001896AFFB0
	public void ReCalculatePos(Vector3 position, Vector3 direction) {} // 0x00000001815D30B0-0x00000001815D32F0
	// [XID] // 0x00000001896B78A0-0x00000001896B78C0
	public float GetHeight() => default; // 0x00000001815D3670-0x00000001815D3720
	// [XID] // 0x00000001896BEA10-0x00000001896BEA30
	public Vector3 GetCenter() => default; // 0x00000001815D3AD0-0x00000001815D3BD0
	// [XID] // 0x00000001896C6310-0x00000001896C6330
	public Vector3? GetRandomPoint() => default; // 0x00000001815D3BD0-0x00000001815D3C20
}

