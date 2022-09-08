/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriManaAmbisonicSource : CriMonoBehaviour // TypeDefIndex: 7156
{
	// Fields
	private CriAtomEx3dSource atomEx3DsourceForAmbisonics; // 0x28
	private Vector3 ambisonicSourceOrientationFront; // 0x30
	private Vector3 ambisonicSourceOrientationTop; // 0x3C
	private Vector3 lastEulerOfAmbisonicSource; // 0x48

	// Constructors
	public CriManaAmbisonicSource() {} // 0x0000000187A38590-0x0000000187A385F0

	// Methods
	public override void CriInternalUpdate() {} // 0x0000000187A37B30-0x0000000187A37B90
	public override void CriInternalLateUpdate() {} // 0x0000000187A37AE0-0x0000000187A37B30
	protected override void OnEnable() {} // 0x0000000187A37C90-0x0000000187A37DC0
	private void ForceUpdateAmbisonicSourceOrientation() {} // 0x0000000187A37B90-0x0000000187A37C90
	private void UpdateAmbisonicSourceOrientation() {} // 0x0000000187A38480-0x0000000187A38590
	private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler) {} // 0x0000000187A37DC0-0x0000000187A38480
}

