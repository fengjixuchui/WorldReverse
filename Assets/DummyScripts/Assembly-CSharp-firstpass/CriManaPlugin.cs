/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriManaPlugin // TypeDefIndex: 7155
{
	// Fields
	private static int initializationCount; // 0x00
	private static bool isConfigured; // 0x04
	private static bool enabledMultithreadedRendering; // 0x05
	public static int renderingEventOffset; // 0x08

	// Properties
	public static bool isInitialized { get => default; } // 0x0000000186442190-0x0000000186442220 
	public static bool isMultithreadedRenderingEnabled { get => default; } // 0x0000000186442220-0x00000001864422B0 

	// Constructors
	public CriManaPlugin() {} // 0x0000000186441F60-0x0000000186441FC0
	static CriManaPlugin() {} // 0x0000000186441EC0-0x0000000186441F60

	// Methods
	public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries) {} // 0x0000000186441AA0-0x0000000186441BD0
	private static void SetupVp9() {} // 0x0000000186441C20-0x0000000186441DF0
	[Obsolete] // 0x000000018964FAB0-0x000000018964FAE0
	public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height) {} // 0x0000000186441A00-0x0000000186441A50
	public static void SetConfigAdditonalParameters_PC(bool use_h264_playback) {} // 0x0000000186441970-0x0000000186441A00
	public static void SetConfigAdditonalParameters_ANDROID(bool use_h264_playback) {} // 0x0000000186441920-0x0000000186441970
	public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize) {} // 0x0000000186441A50-0x0000000186441AA0
	public static void InitializeLibrary() {} // 0x0000000186441640-0x0000000186441820
	public static bool IsLibraryInitialized() => default; // 0x0000000186441820-0x00000001864418A0
	public static void FinalizeLibrary() {} // 0x0000000186441470-0x0000000186441640
	public static void SetDecodeThreadPriorityAndroidExperimental(int prio) {} // 0x0000000186441BD0-0x0000000186441C20
	public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr) => default; // 0x0000000186441DF0-0x0000000186441E40
	public static void Lock() {} // 0x00000001864418A0-0x0000000186441920
	public static void Unlock() {} // 0x0000000186441E40-0x0000000186441EC0
	private static extern void CRIWARE4167F112(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries); // 0x0000000186440FC0-0x00000001864410D0
	private static extern void CRIWARE293FA022(); // 0x0000000186440E00-0x0000000186440EE0
	public static extern bool CRIWARE1DC439B8(); // 0x0000000186440C40-0x0000000186440D20
	private static extern void CRIWAREA256AD28(); // 0x00000001864411C0-0x00000001864412A0
	public static extern void CRIWAREE0F2DCC8(bool flag); // 0x0000000186441380-0x0000000186441470
	public static extern void CRIWARE34184E44(); // 0x0000000186440EE0-0x0000000186440FC0
	public static extern void CRIWARE23309A02(); // 0x0000000186440D20-0x0000000186440E00
	public static extern void criMana_UseStreamerManager(bool flag); // 0x00000001864420A0-0x0000000186442190
	public static extern bool criMana_IsStreamerManagerUsed(); // 0x0000000186441FC0-0x00000001864420A0
	public static extern uint CRIWAREDCC73711(); // 0x00000001864412A0-0x0000000186441380
	public static extern void CRIWARE75DBF0DC(bool enable); // 0x00000001864410D0-0x00000001864411C0
}

