/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsLoader : CriDisposable // TypeDefIndex: 7120
{
	// Fields
	private IntPtr handle; // 0x20
	private GCHandle dstGch; // 0x28
	private GCHandle srcGch; // 0x2C

	// Nested types
	public enum Status // TypeDefIndex: 7121
	{
		Stop = 0,
		Loading = 1,
		Complete = 2,
		Error = 3
	}

	// Constructors
	public CriFsLoader() {} // 0x0000000187A312B0-0x0000000187A31410

	// Methods
	public override void Dispose() {} // 0x0000000187A30A10-0x0000000187A30A80
	private void Dispose(bool disposing) {} // 0x0000000187A30910-0x0000000187A30A10
	public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer) {} // 0x0000000187A31060-0x0000000187A311A0
	public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer) {} // 0x0000000187A30CA0-0x0000000187A30DE0
	public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer) {} // 0x0000000187A30F20-0x0000000187A31060
	public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer) {} // 0x0000000187A30DE0-0x0000000187A30F20
	public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer) {} // 0x0000000187A30820-0x0000000187A30910
	public void Stop() {} // 0x0000000187A31230-0x0000000187A312B0
	public Status GetStatus() => default; // 0x0000000187A30BC0-0x0000000187A30CA0
	public void SetReadUnitSize(int unit_size) {} // 0x0000000187A311A0-0x0000000187A31230
	~CriFsLoader() {} // 0x0000000187A30A80-0x0000000187A30BC0
	private static extern int criFsLoader_Create(out IntPtr loader); // 0x0000000187A31410-0x0000000187A31520
	private static extern int criFsLoader_Destroy(IntPtr loader); // 0x0000000187A31640-0x0000000187A31730
	private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000187A31C10-0x0000000187A31D70
	private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000187A31830-0x0000000187A31970
	private static extern int criFsLoader_Stop(IntPtr loader); // 0x0000000187A31E70-0x0000000187A31F60
	private static extern int criFsLoader_GetStatus(IntPtr loader, out Status status); // 0x0000000187A31730-0x0000000187A31830
	private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size); // 0x0000000187A31D70-0x0000000187A31E70
	private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000187A31AB0-0x0000000187A31C10
	private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000187A31970-0x0000000187A31AB0
	private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size); // 0x0000000187A31520-0x0000000187A31640
}

