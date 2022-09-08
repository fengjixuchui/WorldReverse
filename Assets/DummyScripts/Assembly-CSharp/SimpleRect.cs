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

public class SimpleRect : BaseShape2d // TypeDefIndex: 20540
{
	// Fields
	public bool useHeight; // 0x10
	public float height; // 0x14
	public HeightPosType heightType; // 0x18
	public CenterPosType posType; // 0x1C
	public Vector3 center; // 0x20
	public Vector2 axis0; // 0x2C
	public Vector2 axis1; // 0x34
	public Vector2 extents; // 0x3C

	// Constructors
	public SimpleRect() {} // 0x0000000182D4C8A0-0x0000000182D4C900

	// Methods
	// [XID] // 0x0000000189B9D540-0x0000000189B9D560
	public float Extent() => default; // 0x0000000182D4C3D0-0x0000000182D4C4C0
	// [XID] // 0x0000000189BA4F90-0x0000000189BA4FB0
	public void Init(Vector3 position, Vector3 direction, float width, float length, CenterPosType posType, HeightPosType heightType, bool useHeight = false /* Metadata: 0x00AFDBCF */, float height = 0f /* Metadata: 0x00AFDBD0 */) {} // 0x0000000182D4BD40-0x0000000182D4BF40
	// [XID] // 0x0000000189BAC130-0x0000000189BAC150
	public void Release() {} // 0x0000000182D4C330-0x0000000182D4C3D0
	// [XID] // 0x0000000189BB3910-0x0000000189BB3930
	public void ReCalculatePos(Vector3 position, Vector3 direction) {} // 0x0000000182D4B8D0-0x0000000182D4BA50
	// [XID] // 0x0000000189BBAEE0-0x0000000189BBAF00
	private void ReCalculate(Vector3 position, Vector3 direction, float halfWidth, float halfLength) {} // 0x0000000182D4BF40-0x0000000182D4C280
	// [XID] // 0x0000000189BC2EB0-0x0000000189BC2ED0
	public bool IsPointIn(Vector3 point, float? overrideCenterY = default, float? overrideRange = default) => default; // 0x0000000182D4BA50-0x0000000182D4BD40
	// [XID] // 0x0000000189BCA650-0x0000000189BCA670
	public void Draw(Color color, float duration) {} // 0x0000000182D4B2A0-0x0000000182D4B8D0
	// [XID] // 0x0000000189BD1C60-0x0000000189BD1C80
	public float GetHeight() => default; // 0x0000000182D4C280-0x0000000182D4C330
	// [XID] // 0x0000000189BD9290-0x0000000189BD92B0
	public Vector3 GetCenter() => default; // 0x0000000182D4C4C0-0x0000000182D4C5A0
	// [XID] // 0x00000001895E5E30-0x00000001895E5E50
	public Vector3? GetRandomPoint() => default; // 0x0000000182D4C5A0-0x0000000182D4C8A0
}

