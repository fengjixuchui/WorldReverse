/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class WeaponSpline // TypeDefIndex: 19744
{
	// Fields
	private ControlPointPool _pool; // 0x10
	public List<SplineControlPoint> ControlPoints; // 0x18
	public float _MaxTime; // 0x20
	public float _C; // 0x24
	public int _InterCount; // 0x28

	// Nested types
	public class ControlPointPool // TypeDefIndex: 19745
	{
		// Fields
		private readonly Stack<SplineControlPoint> _stack; // 0x10

		// Properties
		public int CountAll { /* [XID] */ /* 0x000000018966E1F0-0x000000018966E230 */ get; /* [XID] */ /* 0x0000000189679190-0x00000001896791D0 */ private set; } // 0x00000001817393E0-0x0000000181739440 0x0000000181739220-0x0000000181739280
		public int CountActive { /* [XID] */ /* 0x0000000189683670-0x0000000189683690 */ get => default; } // 0x0000000181739650-0x0000000181739740 
		public int CountInactive { /* [XID] */ /* 0x000000018968B310-0x000000018968B330 */ get => default; } // 0x0000000181739590-0x0000000181739650 

		// Constructors
		public ControlPointPool() {} // Dummy constructor
		public ControlPointPool(int preCount) {} // 0x0000000181739740-0x00000001817398B0

		// Methods
		// [XID] // 0x0000000189693010-0x0000000189693030
		public SplineControlPoint Get() => default; // 0x0000000181739280-0x00000001817393E0
		// [XID] // 0x000000018969A270-0x000000018969A290
		public void Release(SplineControlPoint element) {} // 0x0000000181739440-0x0000000181739590
	}

	// Constructors
	public WeaponSpline() {} // Dummy constructor
	public WeaponSpline(float maxtime, int interPointCount, float c) {} // 0x0000000181727020-0x0000000181727100

	// Methods
	// [XID] // 0x00000001896190E0-0x0000000189619100
	public SplineControlPoint Next(int i) => default; // 0x0000000181726F10-0x0000000181727020
	// [XID] // 0x0000000189620640-0x0000000189620660
	public SplineControlPoint Next2(int i) => default; // 0x0000000181726DD0-0x0000000181726F10
	// [XID] // 0x0000000189627AF0-0x0000000189627B10
	public SplineControlPoint Previous(int i) => default; // 0x0000000181725920-0x0000000181725A10
	// [XID] // 0x000000018962F490-0x000000018962F4B0
	public static Vector3 CatmulRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f) => default; // 0x00000001817254D0-0x0000000181725920
	// [XID] // 0x0000000189636F80-0x0000000189636FA0
	public Vector3 InterpolateByLen(float tl) => default; // 0x00000001817268C0-0x0000000181726B60
	// [XID] // 0x000000018963E500-0x000000018963E520
	public Vector3 InterpolateNormalByLen(float tl) => default; // 0x0000000181726B60-0x0000000181726DD0
	// [XID] // 0x0000000189645C80-0x0000000189645CA0
	public void AddControlPoint(Vector3 pos, Vector3 up, float time = 0f /* Metadata: 0x00AFCCF9 */) {} // 0x0000000181726700-0x00000001817268C0
	// [XID] // 0x000000018964D5E0-0x000000018964D600
	public void RefreshSpline(float time) {} // 0x0000000181725A10-0x0000000181726440
	// [XID] // 0x0000000189654E40-0x0000000189654E60
	public int LenToSegment(float t, out float localF) {
		localF = default;
		return default;
	} // 0x0000000181725240-0x00000001817254D0
	// [XID] // 0x000000018965C490-0x000000018965C4B0
	internal void Setup(Vector3 curHeadPos, Vector3 vector3) {} // 0x0000000181726440-0x0000000181726700
}

