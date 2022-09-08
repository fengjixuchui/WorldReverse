/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExAcbLoader : CriDisposable // TypeDefIndex: 7048
{
	// Fields
	private IntPtr handle; // 0x20
	private GCHandle? gch; // 0x28

	// Nested types
	public enum Status // TypeDefIndex: 7049
	{
		Stop = 0,
		Loading = 1,
		Complete = 2,
		Error = 3
	}

	private struct LoaderConfig // TypeDefIndex: 7050
	{
		// Fields
		public bool shouldLoadAwbOnMemory; // 0x00
	}

	// Constructors
	public CriAtomExAcbLoader() {} // Dummy constructor
	private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle) {} // 0x00000001877658C0-0x00000001877659C0

	// Methods
	public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x00ADE215 */) => default; // 0x00000001877656B0-0x0000000187765800
	public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x00ADE216 */) => default; // 0x0000000187765510-0x00000001877656B0
	public Status GetStatus() => default; // 0x00000001877654A0-0x0000000187765510
	public CriAtomExAcb MoveAcb() => default; // 0x0000000187765800-0x00000001877658C0
	public override void Dispose() {} // 0x0000000187765260-0x00000001877652D0
	private void Dispose(bool disposing) {} // 0x00000001877652D0-0x00000001877653F0
	~CriAtomExAcbLoader() {} // 0x00000001877653F0-0x00000001877654A0
	private static extern IntPtr criAtomExAcbLoader_Create(in LoaderConfig config); // 0x00000001877659C0-0x0000000187765AC0
	private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader); // 0x0000000187765AC0-0x0000000187765BB0
	private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path); // 0x0000000187765DE0-0x0000000187765F40
	private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path); // 0x0000000187765CA0-0x0000000187765DE0
	private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader); // 0x0000000187765BB0-0x0000000187765CA0
	private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader); // 0x0000000187766030-0x0000000187766120
	private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader); // 0x0000000187765F40-0x0000000187766030
}

