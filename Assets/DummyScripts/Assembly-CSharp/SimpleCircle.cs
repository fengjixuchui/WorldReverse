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

public class SimpleCircle : BaseShape2d // TypeDefIndex: 20542
{
	// Fields
	public bool useHeight; // 0x10
	public float height; // 0x14
	public Vector3 center; // 0x18
	public float radius; // 0x24
	public HeightPosType heightType; // 0x28

	// Constructors
	public SimpleCircle() {} // 0x00000001822C4180-0x00000001822C41E0

	// Methods
	// [XID] // 0x00000001896387C0-0x00000001896387E0
	public float Extent() => default; // 0x00000001822C3D80-0x00000001822C3E30
	// [XID] // 0x000000018963FC10-0x000000018963FC30
	public void Init(Vector3 position, float radius, HeightPosType heightType, bool useHeight = false /* Metadata: 0x00AFDBD9 */, float height = 0f /* Metadata: 0x00AFDBDA */) {} // 0x00000001822C3A00-0x00000001822C3B40
	// [XID] // 0x0000000189647430-0x0000000189647450
	public void Release() {} // 0x00000001822C3CE0-0x00000001822C3D80
	// [XID] // 0x000000018964EB60-0x000000018964EB80
	public void ReCalculatePos(Vector3 position, Vector3 direction) {} // 0x00000001822C36F0-0x00000001822C3800
	// [XID] // 0x0000000189656410-0x0000000189656430
	private void ReCalculate(Vector3 position, float radius) {} // 0x00000001822C3B40-0x00000001822C3C30
	// [XID] // 0x000000018965DB90-0x000000018965DBB0
	public bool IsPointIn(Vector3 point, float? overrideCenterY = default, float? overrideRange = default) => default; // 0x00000001822C3800-0x00000001822C3A00
	// [XID] // 0x00000001896651C0-0x00000001896651E0
	public void Draw(Color color, float duration) {} // 0x00000001822C3340-0x00000001822C36F0
	// [XID] // 0x000000018966C8E0-0x000000018966C900
	public float GetHeight() => default; // 0x00000001822C3C30-0x00000001822C3CE0
	// [XID] // 0x0000000189674710-0x0000000189674730
	public Vector3 GetCenter() => default; // 0x00000001822C3E30-0x00000001822C3F10
	// [XID] // 0x000000018967C040-0x000000018967C060
	public Vector3? GetRandomPoint() => default; // 0x00000001822C3F10-0x00000001822C4180
}

