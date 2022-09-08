/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CriWare
{
	public class Common // TypeDefIndex: 7189
	{
		// Fields
		private const string scriptVersionString = "2.35.33b"; // Metadata: 0x00ADE6BB
		private const int scriptVersionNumber = 37040897; // Metadata: 0x00ADE6C7
		public const bool supportsCriFsInstaller = true; // Metadata: 0x00ADE6CB
		public const bool supportsCriFsWebInstaller = true; // Metadata: 0x00ADE6CC
		public const string pluginName = "cri_ware_unity"; // Metadata: 0x00ADE6CD
		public const CallingConvention pluginCallingConvention = CallingConvention.Cdecl; // Metadata: 0x00ADE6DF
		private static GameObject _managerObject; // 0x00
	
		// Properties
		public static string streamingAssetsPath { /* [XID] */ /* 0x000000018988AF50-0x000000018988AF70 */ get => default; } // 0x000000018642E200-0x000000018642E2C0 
		public static string installTargetPath { /* [XID] */ /* 0x00000001896C7390-0x00000001896C73B0 */ get => default; } // 0x000000018642DF40-0x000000018642DFF0 
		public static GameObject managerObject { /* [XID] */ /* 0x00000001896D5D80-0x00000001896D5DA0 */ get => default; } // 0x000000018642DFF0-0x000000018642E200 
	
		// Nested types
		public struct CpuUsage // TypeDefIndex: 7190
		{
			// Fields
			public float last; // 0x00
			public float average; // 0x04
			public float peak; // 0x08
		}
	
		// Constructors
		public Common() {} // 0x000000018642DE00-0x000000018642DE60
		static Common() {} // 0x000000018642DDA0-0x000000018642DE00
	
		// Methods
		// [XID] // 0x00000001896CE9A0-0x00000001896CE9C0
		public static bool IsStreamingAssetsPath(string path) => default; // 0x000000018642DCB0-0x000000018642DDA0
		// [XID] // 0x00000001896DD330-0x00000001896DD350
		public static string GetScriptVersionString() => default; // 0x000000018642DC10-0x000000018642DCB0
		// [XID] // 0x00000001896E4AF0-0x00000001896E4B10
		public static int GetScriptVersionNumber() => default; // 0x000000018642DB70-0x000000018642DC10
		// [XID] // 0x00000001896EC0B0-0x00000001896EC0D0
		public static int GetBinaryVersionNumber() => default; // 0x000000018642D890-0x000000018642D950
		// [XID] // 0x00000001896F37E0-0x00000001896F3800
		public static int GetRequiredBinaryVersionNumber() => default; // 0x000000018642DAD0-0x000000018642DB70
		// [XID] // 0x000000018981C6E0-0x000000018981C700
		public static bool CheckBinaryVersionCompatibility() => default; // 0x000000018642D5D0-0x000000018642D6D0
		// [XID] // 0x0000000189702570-0x0000000189702590
		public static uint GetFsMemoryUsage() => default; // 0x000000018642D950-0x000000018642DA10
		// [XID] // 0x0000000189823BE0-0x0000000189823C00
		public static uint GetAtomMemoryUsage() => default; // 0x000000018642D7D0-0x000000018642D890
		// [XID] // 0x0000000189857540-0x0000000189857560
		public static uint GetManaMemoryUsage() => default; // 0x000000018642DA10-0x000000018642DAD0
		// [XID] // 0x0000000189883790-0x00000001898837B0
		public static CpuUsage GetAtomCpuUsage() => default; // 0x000000018642D6D0-0x000000018642D7D0
		public static extern int CRIWARE7A6F98F1(); // 0x000000018642D4F0-0x000000018642D5D0
		public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset); // 0x000000018642DE60-0x000000018642DF40
	}
}
