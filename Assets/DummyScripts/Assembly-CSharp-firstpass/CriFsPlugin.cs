/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriFsPlugin // TypeDefIndex: 7140
{
	// Fields
	private static int initializationCount; // 0x00
	private static bool isConfigured; // 0x04
	public static int defaultInstallBufferSize; // 0x08
	public static int installBufferSize; // 0x0C

	// Properties
	public static bool isInitialized { get; } // 0x0000000187A32FE0-0x0000000187A33070 

	// Constructors
	static CriFsPlugin() {} // 0x0000000187A32A60-0x0000000187A32B00

	// Methods
	public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check) {} // 0x0000000187A327F0-0x0000000187A328F0
	public static void SetReadDeviceEnabled(int deviceId, bool enabled) {} // 0x0000000187A32990-0x0000000187A32A60
	public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps) {} // 0x0000000187A327A0-0x0000000187A327F0
	public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio) {} // 0x0000000187A32940-0x0000000187A32990
	public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio) {} // 0x0000000187A328F0-0x0000000187A32940
	public static void InitializeLibrary() {} // 0x0000000187A325A0-0x0000000187A32720
	public static bool IsLibraryInitialized() => default; // 0x0000000187A32720-0x0000000187A327A0
	public static void FinalizeLibrary() {} // 0x0000000187A32410-0x0000000187A325A0
	private static extern void CRIWARE689CFC1D(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x0000000187A32120-0x0000000187A32250
	private static extern void CRIWAREC5A1CEAB(); // 0x0000000187A32330-0x0000000187A32410
	public static extern bool CRIWARE3ACEE24A(); // 0x0000000187A32040-0x0000000187A32120
	private static extern void CRIWARE90FCC3A9(); // 0x0000000187A32250-0x0000000187A32330
	public static extern uint CRIWARE1F0FB9BF(); // 0x0000000187A31F60-0x0000000187A32040
	public static extern uint criFsLoader_GetRetryCount(); // 0x0000000187A32B00-0x0000000187A32BE0
	public static extern int criFs_GetNumBinds(ref int cur, ref int max, ref int limit); // 0x0000000187A32BE0-0x0000000187A32CE0
	public static extern int criFs_GetNumUsedLoaders(ref int cur, ref int max, ref int limit); // 0x0000000187A32DE0-0x0000000187A32EE0
	public static extern int criFs_GetNumUsedInstallers(ref int cur, ref int max, ref int limit); // 0x0000000187A32CE0-0x0000000187A32DE0
	private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled); // 0x0000000187A32EE0-0x0000000187A32FE0
}

