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

public class SimpleSphere : BaseShape3d // TypeDefIndex: 20544
{
	// Fields
	public Vector3 center; // 0x10
	public float radius; // 0x1C

	// Constructors
	public SimpleSphere() {} // 0x0000000183035E70-0x0000000183035ED0

	// Methods
	// [XID] // 0x00000001896CD910-0x00000001896CD930
	public float Extent() => default; // 0x0000000183035C10-0x0000000183035CC0
	// [XID] // 0x00000001896D4DE0-0x00000001896D4E00
	public void Init(Vector3 position, float radius) {} // 0x0000000183035A20-0x0000000183035B20
	// [XID] // 0x00000001896DC420-0x00000001896DC440
	public void ReCalculatePos(Vector3 position, Quaternion rotation) {} // 0x0000000183035780-0x0000000183035880
	// [XID] // 0x00000001896E3CB0-0x00000001896E3CD0
	private void ReCalculate(Vector3 position, float radius) {} // 0x0000000183035B20-0x0000000183035C10
	// [XID] // 0x00000001896EAFE0-0x00000001896EB000
	public Vector3 GetCenter() => default; // 0x0000000183035CC0-0x0000000183035DA0
	// [XID] // 0x00000001896F2410-0x00000001896F2430
	public bool IsPointIn(Vector3 point, float? overrideCenterY = default, float? overrideRange = default) => default; // 0x0000000183035880-0x0000000183035A20
	// [XID] // 0x00000001896F9D70-0x00000001896F9D90
	public void Draw(Color color, float duration) {} // 0x0000000183035620-0x0000000183035780
	// [XID] // 0x0000000189701500-0x0000000189701520
	public Vector3? GetRandomPoint() => default; // 0x0000000183035DA0-0x0000000183035E70
}

