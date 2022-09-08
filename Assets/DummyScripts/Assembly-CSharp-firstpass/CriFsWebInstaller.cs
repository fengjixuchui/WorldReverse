/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsWebInstaller : CriDisposable // TypeDefIndex: 7142
{
	// Fields
	public const int InvalidHttpStatusCode = -1; // Metadata: 0x00ADE59E
	public const long InvalidContentsSize = -1; // Metadata: 0x00ADE5A2
	private IntPtr handle; // 0x20

	// Properties
	public static bool isInitialized { get; private set; } // 0x0000000187A379C0-0x0000000187A37A20 0x0000000187A37A80-0x0000000187A37AE0
	public static bool isCrcEnabled { get; private set; } // 0x0000000187A37950-0x0000000187A379C0 0x0000000187A37A20-0x0000000187A37A80
	public static ModuleConfig defaultModuleConfig { get => default; } // 0x0000000187A37860-0x0000000187A37950 

	// Nested types
	public enum Status // TypeDefIndex: 7143
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		Error = 3
	}

	public enum Error // TypeDefIndex: 7144
	{
		None = 0,
		Timeout = 1,
		Memory = 2,
		LocalFs = 3,
		DNS = 4,
		Connection = 5,
		SSL = 6,
		HTTP = 7,
		Internal = 8
	}

	public struct StatusInfo // TypeDefIndex: 7145
	{
		// Fields
		public Status status; // 0x00
		public Error error; // 0x04
		public int httpStatusCode; // 0x08
		public long contentsSize; // 0x10
		public long receivedSize; // 0x18
	}

	public struct ModuleConfig // TypeDefIndex: 7146
	{
		// Fields
		public uint numInstallers; // 0x00
		public string proxyHost; // 0x08
		public ushort proxyPort; // 0x10
		public string userAgent; // 0x18
		public uint inactiveTimeoutSec; // 0x20
		public bool allowInsecureSSL; // 0x24
		public bool crcEnabled; // 0x25
		public ModulePlatformConfig platformConfig; // 0x26
	}

	public struct ModulePlatformConfig // TypeDefIndex: 7147
	{
		// Fields
		public byte reserved; // 0x00

		// Properties
		public static ModulePlatformConfig defaultConfig { get => default; } // 0x0000000187A3AA20-0x0000000187A3AA70 
	}

	// Constructors
	public CriFsWebInstaller() {} // 0x0000000187A36CA0-0x0000000187A36DA0

	// Methods
	~CriFsWebInstaller() {} // 0x0000000187A367E0-0x0000000187A36890
	public override void Dispose() {} // 0x0000000187A36590-0x0000000187A36600
	public void Copy(string url, string dstPath) {} // 0x0000000187A36300-0x0000000187A36390
	public void Stop() {} // 0x0000000187A36C20-0x0000000187A36CA0
	public StatusInfo GetStatusInfo() => default; // 0x0000000187A36910-0x0000000187A369F0
	public bool GetCRC32(out uint ret_val) {
		ret_val = default;
		return default;
	} // 0x0000000187A36890-0x0000000187A36910
	public static void InitializeModule(ModuleConfig config) {} // 0x0000000187A369F0-0x0000000187A36BA0
	public static void FinalizeModule() {} // 0x0000000187A36660-0x0000000187A367E0
	public static void ExecuteMain() {} // 0x0000000187A36600-0x0000000187A36660
	public static bool SetRequestHeader(string field, string value) => default; // 0x0000000187A36BA0-0x0000000187A36C20
	private void Dispose(bool disposing) {} // 0x0000000187A36390-0x0000000187A36590
	private static extern int criFsWebInstaller_Initialize(in ModuleConfig config); // 0x0000000187A374D0-0x0000000187A37640
	private static extern int criFsWebInstaller_Finalize(); // 0x0000000187A371B0-0x0000000187A37290
	private static extern int criFsWebInstaller_ExecuteMain(); // 0x0000000187A370D0-0x0000000187A371B0
	private static extern int criFsWebInstaller_Create(out IntPtr installer); // 0x0000000187A36ED0-0x0000000187A36FE0
	private static extern int criFsWebInstaller_Destroy(IntPtr installer); // 0x0000000187A36FE0-0x0000000187A370D0
	private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath); // 0x0000000187A36DA0-0x0000000187A36ED0
	private static extern int criFsWebInstaller_Stop(IntPtr installer); // 0x0000000187A37770-0x0000000187A37860
	private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status); // 0x0000000187A373A0-0x0000000187A374D0
	private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32); // 0x0000000187A37290-0x0000000187A373A0
	private static extern int criFsWebInstaller_SetRequestHeader(string field, string value); // 0x0000000187A37640-0x0000000187A37770
}

