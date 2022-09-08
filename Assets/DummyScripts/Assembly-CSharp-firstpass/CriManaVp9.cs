/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriManaVp9 // TypeDefIndex: 7240
{
	// Fields
	private const string scriptVersionString = "1.01.01"; // Metadata: 0x00ADE73B
	private const int scriptVersionNumber = 16843008; // Metadata: 0x00ADE746
	public const string cri_mana_vp9_name = "cri_mana_vpx"; // Metadata: 0x00ADE74A

	// Methods
	public static bool SupportCurrentPlatform() => default; // 0x00000001864424F0-0x0000000186442540
	public static void SetupVp9Decoder() {} // 0x00000001864423C0-0x00000001864424F0
	private static extern IntPtr criWareUnity_GetAllocateFunc(); // 0x00000001864429E0-0x0000000186442AC0
	private static extern IntPtr criWareUnity_GetDeallocateFunc(); // 0x0000000186442AC0-0x0000000186442BA0
	private static extern IntPtr criManaUnity_GetAllocatorManager(); // 0x0000000186442540-0x0000000186442620
	private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if); // 0x0000000186442620-0x0000000186442720
	private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj); // 0x00000001864428E0-0x00000001864429E0
	private static extern IntPtr criVvp9_GetInterface(); // 0x0000000186442800-0x00000001864428E0
	private static extern IntPtr criVvp9_GetAlphaInterface(); // 0x0000000186442720-0x0000000186442800
}

