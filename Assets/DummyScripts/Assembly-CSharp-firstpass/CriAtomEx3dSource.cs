/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomEx3dSource : CriDisposable // TypeDefIndex: 7039
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x0000000187763E50-0x0000000187763EB0 

	// Nested types
	public struct Config // TypeDefIndex: 7040
	{
		// Fields
		public int reserved; // 0x00
	}

	// Constructors
	public CriAtomEx3dSource() {} // 0x0000000187762A90-0x0000000187762B50

	// Methods
	public override void Dispose() {} // 0x0000000187761E00-0x0000000187761E70
	private void Dispose(bool disposing) {} // 0x0000000187761E70-0x0000000187761F40
	public void Update() {} // 0x0000000187762A20-0x0000000187762A90
	public void ResetParameters() {} // 0x0000000187762060-0x00000001877620D0
	public void SetPosition(float x, float y, float z) {} // 0x00000001877627A0-0x0000000187762860
	public void SetVelocity(float x, float y, float z) {} // 0x00000001877628E0-0x00000001877629A0
	public void SetOrientation(Vector3 front, Vector3 top) {} // 0x0000000187762620-0x00000001877627A0
	public void SetConeOrientation(float x, float y, float z) {} // 0x0000000187762210-0x00000001877622D0
	public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume) {} // 0x00000001877622D0-0x0000000187762380
	public void SetMinMaxDistance(float minDistance, float maxDistance) {} // 0x0000000187762590-0x0000000187762620
	public void SetInteriorPanField(float sourceRadius, float interiorDistance) {} // 0x0000000187762400-0x0000000187762490
	public void SetDopplerFactor(float dopplerFactor) {} // 0x0000000187762380-0x0000000187762400
	public void SetVolume(float volume) {} // 0x00000001877629A0-0x0000000187762A20
	public void SetMaxAngleAisacDelta(float maxDelta) {} // 0x0000000187762510-0x0000000187762590
	public void SetAttenuationDistanceSetting(bool flag) {} // 0x0000000187762190-0x0000000187762210
	public bool GetAttenuationDistanceSetting() => default; // 0x0000000187761FF0-0x0000000187762060
	public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x00000001877620D0-0x0000000187762190
	public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187762490-0x0000000187762510
	public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187762860-0x00000001877628E0
	~CriAtomEx3dSource() {} // 0x0000000187761F40-0x0000000187761FF0
	private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size); // 0x0000000187762B50-0x0000000187762C60
	private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source); // 0x0000000187762C60-0x0000000187762D50
	private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source); // 0x0000000187763D60-0x0000000187763E50
	private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source); // 0x0000000187762E40-0x0000000187762F30
	private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position); // 0x0000000187763960-0x0000000187763A60
	private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity); // 0x0000000187763B60-0x0000000187763C60
	private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x0000000187763860-0x0000000187763960
	private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient); // 0x0000000187763130-0x0000000187763230
	private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume); // 0x0000000187763230-0x0000000187763340
	private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance); // 0x0000000187763750-0x0000000187763860
	private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance); // 0x0000000187763440-0x0000000187763550
	private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor); // 0x0000000187763340-0x0000000187763440
	private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume); // 0x0000000187763C60-0x0000000187763D60
	private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta); // 0x0000000187763650-0x0000000187763750
	private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag); // 0x0000000187763030-0x0000000187763130
	private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source); // 0x0000000187762D50-0x0000000187762E40
	private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region); // 0x0000000187762F30-0x0000000187763030
	private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000187763550-0x0000000187763650
	private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000187763A60-0x0000000187763B60
}

