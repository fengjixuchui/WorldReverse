/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRSettings // TypeDefIndex: 6431
	{
		// Fields
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum; // 0x00
		internal _Sync Sync; // 0x08
		internal _SetBool SetBool; // 0x10
		internal _SetInt32 SetInt32; // 0x18
		internal _SetFloat SetFloat; // 0x20
		internal _SetString SetString; // 0x28
		internal _GetBool GetBool; // 0x30
		internal _GetInt32 GetInt32; // 0x38
		internal _GetFloat GetFloat; // 0x40
		internal _GetString GetString; // 0x48
		internal _RemoveSection RemoveSection; // 0x50
		internal _RemoveKeyInSection RemoveKeyInSection; // 0x58
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError); // TypeDefIndex: 6432; 0x000000018832E7A0-0x000000018832E930
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError); // TypeDefIndex: 6433; 0x0000000188338AE0-0x0000000188338CB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError); // TypeDefIndex: 6434; 0x0000000188336E80-0x00000001883371E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError); // TypeDefIndex: 6435; 0x0000000188337C40-0x0000000188337FA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError); // TypeDefIndex: 6436; 0x0000000188337710-0x0000000188337A60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError); // TypeDefIndex: 6437; 0x0000000188338170-0x00000001883384D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6438; 0x0000000188325FB0-0x00000001883262A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate int _GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6439; 0x000000018832AAB0-0x000000018832ADA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate float _GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6440; 0x0000000188329DC0-0x000000018832A0D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError); // TypeDefIndex: 6441; 0x000000018832F410-0x000000018832F800
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError); // TypeDefIndex: 6442; 0x0000000188335E60-0x0000000188336110
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6443; 0x00000001883359B0-0x0000000188335CA0
	}
}
