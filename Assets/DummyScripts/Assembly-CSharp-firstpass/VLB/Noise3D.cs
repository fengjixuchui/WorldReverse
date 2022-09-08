/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace VLB
{
	public static class Noise3D // TypeDefIndex: 10204
	{
		// Fields
		private static bool ms_IsSupportedChecked; // 0x00
		private static bool ms_IsSupported; // 0x01
		private static Texture3D ms_NoiseTexture; // 0x08
		private const HideFlags kHideFlags = HideFlags.None | HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset | HideFlags.DontSave | HideFlags.HideAndDontSave; // Metadata: 0x00AE720D
		private const int kMinShaderLevel = 35; // Metadata: 0x00AE7211
	
		// Properties
		public static bool isSupported { /* [XID] */ /* 0x0000000189664690-0x00000001896646B0 */ get; } // 0x0000000186EA6FD0-0x0000000186EA71A0 
		public static bool isProperlyLoaded { /* [XID] */ /* 0x000000018962E8E0-0x000000018962E900 */ get; } // 0x0000000186EA6ED0-0x0000000186EA6FD0 
		public static string isNotSupportedString { /* [XID] */ /* 0x0000000189620FB0-0x0000000189620FD0 */ get; } // 0x0000000186EA6DB0-0x0000000186EA6ED0 
	
		// Constructors
		static Noise3D() {} // 0x0000000186EA6D20-0x0000000186EA6DB0
	
		// Methods
		// [XID] // 0x000000018963DC30-0x000000018963DC50
		public static void LoadIfNeeded() {} // 0x0000000186EA6660-0x0000000186EA6960
		// [XID] // 0x0000000189645180-0x00000001896451A0
		private static Texture3D LoadTexture3D(TextAsset textData, int size) => default; // 0x0000000186EA6960-0x0000000186EA6D20
	}
}
