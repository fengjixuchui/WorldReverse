/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomEx3dTransceiver : CriDisposable // TypeDefIndex: 7041
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x0000000187764F70-0x0000000187764FD0 

	// Nested types
	public struct Config // TypeDefIndex: 7042
	{
		// Fields
		public int reserved; // 0x00
	}

	private static class UnsafeNativeMethods // TypeDefIndex: 7043
	{
		// Methods
		internal static extern IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size); // 0x000000018777B800-0x000000018777B910
		internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver); // 0x000000018777B910-0x000000018777BA00
		internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver); // 0x000000018777CB50-0x000000018777CC40
		internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x000000018777BF20-0x000000018777C020
		internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x000000018777C750-0x000000018777C850
		internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x000000018777BE20-0x000000018777BF20
		internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x000000018777C650-0x000000018777C750
		internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume); // 0x000000018777C320-0x000000018777C430
		internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance); // 0x000000018777C540-0x000000018777C650
		internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance); // 0x000000018777C430-0x000000018777C540
		internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance); // 0x000000018777BD10-0x000000018777BE20
		internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume); // 0x000000018777C850-0x000000018777C950
		internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x000000018777B6F0-0x000000018777B800
		internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x000000018777BA00-0x000000018777BB10
		internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta); // 0x000000018777C220-0x000000018777C320
		internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018777BC10-0x000000018777BD10
		internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018777C020-0x000000018777C120
		internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018777C120-0x000000018777C220
		internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018777C950-0x000000018777CA50
		internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018777CA50-0x000000018777CB50
		internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region); // 0x000000018777BB10-0x000000018777BC10
	}

	// Constructors
	public CriAtomEx3dTransceiver() {} // 0x0000000187764EB0-0x0000000187764F70

	// Methods
	public override void Dispose() {} // 0x0000000187764080-0x00000001877640F0
	private void Dispose(bool disposing) {} // 0x0000000187763FB0-0x0000000187764080
	public void Update() {} // 0x0000000187764E40-0x0000000187764EB0
	public void SetInputPosition(Vector3 position) {} // 0x0000000187764580-0x0000000187764670
	public void SetOutputPosition(Vector3 position) {} // 0x0000000187764BD0-0x0000000187764CC0
	public void SetInputOrientation(Vector3 front, Vector3 top) {} // 0x0000000187764370-0x0000000187764580
	public void SetOutputOrientation(Vector3 front, Vector3 top) {} // 0x00000001877649C0-0x0000000187764BD0
	public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume) {} // 0x00000001877647F0-0x00000001877648A0
	public void SetOutputMinMaxDistance(float minDistance, float maxDistance) {} // 0x0000000187764930-0x00000001877649C0
	public void SetOutputInteriorPanField(float radius, float interiorDistance) {} // 0x00000001877648A0-0x0000000187764930
	public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance) {} // 0x00000001877642E0-0x0000000187764370
	public void SetOutputVolume(float volume) {} // 0x0000000187764CC0-0x0000000187764D40
	public void AttachAisac(string globalAisacName) {} // 0x0000000187763EB0-0x0000000187763F30
	public void DetachAisac(string globalAisacName) {} // 0x0000000187763F30-0x0000000187763FB0
	public void SetMaxAngleAisacDelta(float maxDelta) {} // 0x0000000187764770-0x00000001877647F0
	public void SetDistanceAisacControlId(ushort aisacControlId) {} // 0x0000000187764260-0x00000001877642E0
	public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187764670-0x00000001877646F0
	public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x00000001877646F0-0x0000000187764770
	public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187764D40-0x0000000187764DC0
	public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187764DC0-0x0000000187764E40
	public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x00000001877641A0-0x0000000187764260
	~CriAtomEx3dTransceiver() {} // 0x00000001877640F0-0x00000001877641A0
}

