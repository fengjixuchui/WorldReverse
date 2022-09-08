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

public class SimpleSector : BaseShape2d // TypeDefIndex: 20541
{
	// Fields
	public bool useHeight; // 0x10
	public float height; // 0x14
	public HeightPosType heightType; // 0x18
	public Vector3 center; // 0x1C
	private Vector3 _xzCenter; // 0x28
	public float radius; // 0x34
	private Vector3 _direction; // 0x38
	public Vector3 xzDirection; // 0x44
	public float fullRadian; // 0x50
	private float _cosTheta; // 0x54
	public bool biggerThenPI; // 0x58

	// Constructors
	public SimpleSector() {} // 0x0000000182417D30-0x0000000182417D90

	// Methods
	// [XID] // 0x00000001895ED810-0x00000001895ED830
	public float Extent() => default; // 0x00000001824178E0-0x0000000182417990
	// [XID] // 0x00000001895F4ED0-0x00000001895F4EF0
	public void Init(Vector3 position, Vector3 direction, float radius, float fullRadian, HeightPosType heightType, bool useHeight = false /* Metadata: 0x00AFDBD4 */, float height = 0f /* Metadata: 0x00AFDBD5 */) {} // 0x00000001824173C0-0x0000000182417590
	// [XID] // 0x00000001895FC550-0x00000001895FC570
	public void Release() {} // 0x0000000182417840-0x00000001824178E0
	// [XID] // 0x0000000189603F10-0x0000000189603F30
	public void ReCalculatePos(Vector3 position, Vector3 direction) {} // 0x0000000182416E50-0x0000000182416F80
	// [XID] // 0x000000018960B830-0x000000018960B850
	private void ReCalculate(Vector3 position, Vector3 direction, float radius, float fullRadian) {} // 0x0000000182417590-0x0000000182417790
	// [XID] // 0x0000000189612D00-0x0000000189612D20
	public bool IsPointIn(Vector3 point, float? overrideCenterY = default, float? overrideRange = default) => default; // 0x0000000182416F80-0x00000001824173C0
	// [XID] // 0x000000018961A560-0x000000018961A580
	public void Draw(Color color, float duration) {} // 0x00000001824168E0-0x0000000182416E50
	// [XID] // 0x0000000189621B00-0x0000000189621B20
	public float GetHeight() => default; // 0x0000000182417790-0x0000000182417840
	// [XID] // 0x0000000189629430-0x0000000189629450
	public Vector3 GetCenter() => default; // 0x0000000182417990-0x0000000182417A70
	// [XID] // 0x0000000189630D60-0x0000000189630D80
	public Vector3? GetRandomPoint() => default; // 0x0000000182417A70-0x0000000182417D30
}

