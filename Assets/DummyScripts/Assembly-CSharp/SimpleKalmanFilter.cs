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

public class SimpleKalmanFilter // TypeDefIndex: 32161
{
	// Fields
	public Vector3d xk; // 0x10
	public Vector3d uk; // 0x28
	public double pk; // 0x40
	public double Kg; // 0x48
	public double noiseQ; // 0x50
	public double noiseR; // 0x58
	public double frameRate; // 0x60
	private double _configdece; // 0x68
	public Vector3d[] velocityTrace; // 0x70
	public bool isInitialized; // 0x78

	// Constructors
	public SimpleKalmanFilter() {} // Dummy constructor
	public SimpleKalmanFilter(Vector3d x0, Vector3d u0, double processNoiseQ, double measureNoiseR, double initialError) {} // 0x00000001840EFB90-0x00000001840EFCB0

	// Methods
	// [XID] // 0x0000000189778590-0x00000001897785B0
	public void ShiftCoordinate(Vector3d diff) {} // 0x00000001840EF180-0x00000001840EF2B0
	// [XID] // 0x000000018977FB60-0x000000018977FB80
	public void Reset(Vector3d x0, Vector3d u0, double processNoiseQ, double measureNoiseR, double initialError) {} // 0x00000001840EEE90-0x00000001840EF080
	// [XID] // 0x00000001897873F0-0x0000000189787410
	public void InitVelocity(Vector3d velocity) {} // 0x00000001840EED60-0x00000001840EEE90
	// [XID] // 0x000000018983A0D0-0x000000018983A0F0
	public void PredictStateUsingVelocityConfidence(Vector3d curUk, double deltTime) {} // 0x00000001840EF480-0x00000001840EF630
	// [IDTag] // 0x0000000189796190-0x00000001897961D0
	// [XID] // 0x0000000189796190-0x00000001897961D0
	public void PredictState(Vector3d curUk, double deltTime) {} // 0x00000001840EF950-0x00000001840EFAF0
	// [IDTag] // 0x00000001897A0EE0-0x00000001897A0F20
	// [XID] // 0x00000001897A0EE0-0x00000001897A0F20
	public void PredictState(Vector3d curUk) {} // 0x00000001840EF7B0-0x00000001840EF950
	// [XID] // 0x0000000189814BF0-0x0000000189814C10
	public void UpdateSate(Vector3d zk) {} // 0x00000001840EF2B0-0x00000001840EF480
	// [XID] // 0x00000001897B30E0-0x00000001897B3100
	public void UpdateFrameRate() {} // 0x00000001840EFAF0-0x00000001840EFB90
	// [XID] // 0x00000001897BAFC0-0x00000001897BAFE0
	public Vector3d FineTuneDeltaTime(double deltTime) => default; // 0x00000001840EF080-0x00000001840EF180
	// [XID] // 0x00000001897C2810-0x00000001897C2830
	public void UpdateVelocityTrace(Vector3d curUk) {} // 0x00000001840EF630-0x00000001840EF7B0
	// [XID] // 0x00000001897CA030-0x00000001897CA050
	public void UpdateVelocityConfidence() {} // 0x00000001840EEA80-0x00000001840EED60
}

