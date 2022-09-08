/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SimpleVector3Damper // TypeDefIndex: 32160
{
	// Fields
	private Vector3d _lastPosition; // 0x10
	private Vector3d _lastVelocity; // 0x28
	private double _dampTime; // 0x40

	// Constructors
	public SimpleVector3Damper() {} // Dummy constructor
	public SimpleVector3Damper(Vector3d origin, Vector3d velocity, double dampTime) {} // 0x00000001820F4EB0-0x00000001820F4F60

	// Methods
	// [XID] // 0x00000001897695B0-0x00000001897695D0
	public void Reset(Vector3d origin, Vector3d velocity) {} // 0x00000001820F4BD0-0x00000001820F4CF0
	// [XID] // 0x0000000189770BA0-0x0000000189770BC0
	public Vector3d Update(Vector3d targetPosition, double deltaTime) => default; // 0x00000001820F4CF0-0x00000001820F4EB0
}

