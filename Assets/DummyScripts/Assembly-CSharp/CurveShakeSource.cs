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

public sealed class CurveShakeSource : ShakeSource // TypeDefIndex: 21005
{
	// Fields
	public AnimationClip animationCurve; // 0x68
	private GameObject dummy; // 0x70

	// Constructors
	public CurveShakeSource() {} // Dummy constructor
	public CurveShakeSource(AnimationClip curve, CameraShakeType shakeType, Vector3 center, Vector3 dir, float effRange, bool baseOnCamera) {} // 0x00000001828D8900-0x00000001828D8B80

	// Methods
	// [XID] // 0x0000000189BB5020-0x0000000189BB5040
	public override void Destroy() {} // 0x00000001828D8170-0x00000001828D82D0
	// [XID] // 0x0000000189BBC660-0x0000000189BBC680
	public override float? GetShakeEnergy() => default; // 0x00000001828D8340-0x00000001828D8480
	// [XID] // 0x0000000189BC42C0-0x0000000189BC42E0
	public override Vector3 GetShakeWorldOffSet(Vector3 listenerPos) => default; // 0x00000001828D8590-0x00000001828D8730
	// [XID] // 0x0000000189BCBC80-0x0000000189BCBCA0
	public override Vector3 GetShakeCameraOffSet() => default; // 0x00000001828D8730-0x00000001828D8870
}

