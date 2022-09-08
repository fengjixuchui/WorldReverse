/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomEx3dRegion : CriDisposable // TypeDefIndex: 7044
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x0000000187761DA0-0x0000000187761E00 

	// Nested types
	public struct Config // TypeDefIndex: 7045
	{
		// Fields
		public int reserved; // 0x00
	}

	private static class UnsafeNativeMethods // TypeDefIndex: 7046
	{
		// Methods
		internal static extern IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size); // 0x000000018777B4F0-0x000000018777B600
		internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region); // 0x000000018777B600-0x000000018777B6F0
	}

	// Constructors
	public CriAtomEx3dRegion() {} // 0x0000000187761CE0-0x0000000187761DA0

	// Methods
	public override void Dispose() {} // 0x0000000187761BC0-0x0000000187761C30
	private void Dispose(bool disposing) {} // 0x0000000187761AF0-0x0000000187761BC0
	~CriAtomEx3dRegion() {} // 0x0000000187761C30-0x0000000187761CE0
}

