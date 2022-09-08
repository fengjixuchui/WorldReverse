/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomEx3dListener : CriDisposable // TypeDefIndex: 7037
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x0000000187761A90-0x0000000187761AF0 

	// Nested types
	public struct Config // TypeDefIndex: 7038
	{
		// Fields
		public int reserved; // 0x00
	}

	// Constructors
	public CriAtomEx3dListener() {} // 0x0000000187760CF0-0x0000000187760DB0

	// Methods
	public override void Dispose() {} // 0x00000001877603F0-0x0000000187760460
	private void Dispose(bool disposing) {} // 0x0000000187760320-0x00000001877603F0
	public void Update() {} // 0x0000000187760C80-0x0000000187760CF0
	public void ResetParameters() {} // 0x0000000187760510-0x0000000187760580
	public void SetPosition(float x, float y, float z) {} // 0x0000000187760B00-0x0000000187760BC0
	public void SetVelocity(float x, float y, float z) {} // 0x0000000187760BC0-0x0000000187760C80
	public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz) {} // 0x0000000187760970-0x0000000187760B00
	[Obsolete] // 0x0000000189900370-0x00000001899003A0
	public void SetDistanceFactor(float distanceFactor) {} // 0x00000001877606C0-0x0000000187760780
	public void SetDopplerMultiplier(float dopplerMultiplier) {} // 0x0000000187760800-0x00000001877608B0
	public void SetFocusPoint(float x, float y, float z) {} // 0x00000001877608B0-0x0000000187760970
	public void SetDistanceFocusLevel(float distanceFocusLevel) {} // 0x0000000187760780-0x0000000187760800
	public void SetDirectionFocusLevel(float directionFocusLevel) {} // 0x0000000187760640-0x00000001877606C0
	public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x0000000187760580-0x0000000187760640
	~CriAtomEx3dListener() {} // 0x0000000187760460-0x0000000187760510
	private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size); // 0x0000000187760DB0-0x0000000187760EC0
	private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener); // 0x0000000187760EC0-0x0000000187760FB0
	private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener); // 0x00000001877619A0-0x0000000187761A90
	private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener); // 0x0000000187760FB0-0x00000001877610A0
	private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position); // 0x00000001877617A0-0x00000001877618A0
	private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity); // 0x00000001877618A0-0x00000001877619A0
	private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001877616A0-0x00000001877617A0
	private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor); // 0x00000001877612A0-0x00000001877613A0
	private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier); // 0x00000001877614A0-0x00000001877615A0
	private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point); // 0x00000001877615A0-0x00000001877616A0
	private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level); // 0x00000001877613A0-0x00000001877614A0
	private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level); // 0x00000001877611A0-0x00000001877612A0
	private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region); // 0x00000001877610A0-0x00000001877611A0
}

