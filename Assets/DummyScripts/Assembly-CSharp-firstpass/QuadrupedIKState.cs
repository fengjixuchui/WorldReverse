/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

internal class QuadrupedIKState // TypeDefIndex: 8546
{
	// Fields
	private IKSmoothEffector[] effectors; // 0x10
	public bool[] footLiftingValid; // 0x18
	public float maxAccel; // 0x20
	public float maxSpeed; // 0x24
	public float upDirDamping; // 0x28

	// Constructors
	public QuadrupedIKState() {} // 0x0000000186018AF0-0x0000000186018BB0

	// Methods
	public void InitTargetEffectorPosAndUp(QuadrupedEffector efftype, Vector3 pos, Vector3 up) {} // 0x00000001860187D0-0x00000001860188B0
	public Vector3 SmoothUpdateTargetEffectorPos(QuadrupedEffector efftype, Vector3 pos) => default; // 0x00000001860188B0-0x00000001860189E0
	public Vector3 SmoothUpdateTargetEffectorUpDir(QuadrupedEffector efftype, Vector3 updir) => default; // 0x00000001860189E0-0x0000000186018AF0
	public Vector3 GetEffectorPos(QuadrupedEffector eff) => default; // 0x0000000186018670-0x0000000186018720
	public Vector3 GetEffectorUpDir(QuadrupedEffector eff) => default; // 0x0000000186018720-0x00000001860187D0
}

