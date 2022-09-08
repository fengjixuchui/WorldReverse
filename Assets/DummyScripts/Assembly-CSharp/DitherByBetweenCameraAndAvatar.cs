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

public sealed class DitherByBetweenCameraAndAvatar : BaseDither // TypeDefIndex: 32045
{
	// Fields
	private VCStackCamera _cameraStack; // 0x10
	private BaseEntity _entity; // 0x18
	private Vector3 _entityBoundsSize; // 0x20
	private float _detectRange; // 0x2C
	private static float DITHER_MIN_DISTANCE; // 0x00
	private static float DITHER_MAX_DISTANCE; // 0x04
	private static float DITHER_MIN_VALUE; // 0x08
	private static float DITHER_MAX_VALUE; // 0x0C
	private ViewportData _avatarViewportData; // 0x30
	private ViewportData _entityViewportData; // 0x44
	private Vector3[] _cacheEntityViewportVectors; // 0x58

	// Nested types
	private struct ViewportData // TypeDefIndex: 32046
	{
		// Fields
		public float xMin; // 0x00
		public float xMax; // 0x04
		public float yMin; // 0x08
		public float yMax; // 0x0C
		public float z; // 0x10
	}

	// Constructors
	public DitherByBetweenCameraAndAvatar() {} // Dummy constructor
	public DitherByBetweenCameraAndAvatar(BaseEntity entity, float detectRange) {} // 0x000000018498C2F0-0x000000018498C440
	static DitherByBetweenCameraAndAvatar() {} // 0x000000018498C270-0x000000018498C2F0

	// Methods
	// [XID] // 0x0000000189B873A0-0x0000000189B873C0
	public override void Destroy() {} // 0x000000018498A8C0-0x000000018498A9A0
	// [XID] // 0x0000000189B8E470-0x0000000189B8E490
	public override float UpdateDither(float deltaTime) => default; // 0x000000018498BD10-0x000000018498C270
	// [XID] // 0x0000000189B95910-0x0000000189B95930
	private Vector3 GetBoundsSize(BaseEntity entity, float extendRatio = 1f /* Metadata: 0x00B13BC8 */) => default; // 0x000000018498A9A0-0x000000018498AC20
	// [XID] // 0x0000000189B9CE30-0x0000000189B9CE50
	private void CalculateViewportData(BaseEntity entity, ref ViewportData viewportData, Vector3 boundsSize) {} // 0x000000018498AC20-0x000000018498BD10
}

