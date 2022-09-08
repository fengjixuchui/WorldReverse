/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriWareDecrypter // TypeDefIndex: 7191
{
	// Fields
	private static ulong temporalStorage; // 0x00

	// Nested types
	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 7192; 0x000000018642CEF0-0x000000018642D080

	// Constructors
	static CriWareDecrypter() {} // 0x0000000186444060-0x00000001864440C0

	// Methods
	public static bool Initialize(CriWareDecrypterConfig config) => default; // 0x0000000186443F90-0x0000000186444060
	public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption) => default; // 0x0000000186443CC0-0x0000000186443F90
	// [MonoPInvokeCallback] // 0x0000000189727AA0-0x0000000189727AF0
	private static ulong CallbackFromNative(IntPtr ptr1) => default; // 0x0000000186443C30-0x0000000186443CC0
	public static extern int CRIWAREE543C00F(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj); // 0x0000000186443B10-0x0000000186443C30
}

