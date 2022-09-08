/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsInstaller : CriDisposable // TypeDefIndex: 7122
{
	// Fields
	private byte[] installBuffer; // 0x20
	private GCHandle installBufferGch; // 0x28
	private IntPtr handle; // 0x30

	// Nested types
	public enum Status // TypeDefIndex: 7123
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		Error = 3
	}

	private enum CopyPolicy // TypeDefIndex: 7124
	{
		Always = 0
	}

	// Constructors
	public CriFsInstaller() {} // 0x0000000187A2F030-0x0000000187A2F1A0

	// Methods
	public override void Dispose() {} // 0x0000000187A2EC20-0x0000000187A2EC90
	private void Dispose(bool disposing) {} // 0x0000000187A2EC90-0x0000000187A2ED70
	public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize) {} // 0x0000000187A2E9F0-0x0000000187A2EC20
	public void Stop() {} // 0x0000000187A2EFB0-0x0000000187A2F030
	public Status GetStatus() => default; // 0x0000000187A2EF20-0x0000000187A2EFB0
	public float GetProgress() => default; // 0x0000000187A2EE80-0x0000000187A2EF20
	public static void ExecuteMain() {} // 0x0000000187A2ED70-0x0000000187A2EDD0
	~CriFsInstaller() {} // 0x0000000187A2EDD0-0x0000000187A2EE80
	private static extern int criFsInstaller_ExecuteMain(); // 0x0000000187A2F510-0x0000000187A2F5F0
	private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option); // 0x0000000187A2F310-0x0000000187A2F420
	private static extern int criFsInstaller_Destroy(IntPtr installer); // 0x0000000187A2F420-0x0000000187A2F510
	private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size); // 0x0000000187A2F1A0-0x0000000187A2F310
	private static extern int criFsInstaller_Stop(IntPtr installer); // 0x0000000187A2F800-0x0000000187A2F8F0
	private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status); // 0x0000000187A2F700-0x0000000187A2F800
	private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress); // 0x0000000187A2F5F0-0x0000000187A2F700
}

