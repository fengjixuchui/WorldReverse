/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal static class MiscTools // TypeDefIndex: 4379
	{
		// Fields
		private static uint iiLBhFyhzBIoCTEOOQvuOpyfWgF; // 0x00
		private static uint lAzEDsicxRUozHmbqceQCeXSquf; // 0x04
		private static uint LqeIUlMBSqQsacSffglSBCsrrVoK; // 0x08
		private static int xUvhRPwUpoIvUGPSnVWOtfiOfQN; // 0x0C
		private static int jPzEEeSvBfJHleFTEsOJzZWsKdW; // 0x10
		private static int RqtFfmuxIYDhHnbEoGUmikMBHab; // 0x14
	
		// Constructors
		static MiscTools() {} // 0x00000001862ED600-0x00000001862ED6D0
	
		// Methods
		public static object Clone(object obj) => default; // 0x00000001862ECB50-0x00000001862ECC00
		public static T Clone<T>(T obj)
			where T : class, ICloneable => default;
		public static T DeepClone<T>(T obj)
			where T : class, IDeepCloneable => default;
		public static T DeepClone<T>(T obj, bool createIfNull)
			where T : class, IDeepCloneable, new() => default;
		public static T[] DeepClone<T>(T[] obj)
			where T : class, IDeepCloneable => default;
		public static List<T> DeepClone<T>(List<T> obj)
			where T : class, IDeepCloneable => default;
		public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
			where TValue : class, IDeepCloneable => default;
		public static Guid CreateGuidHashSHA256(string text) => default; // 0x00000001862ECDD0-0x00000001862ECFE0
		public static Guid CreateGuidHashSHA1(string text) => default; // 0x00000001862ECC00-0x00000001862ECDD0
		public static Guid CreateHIDProductGuid(int vendorId, int productId) => default; // 0x00000001862ECFE0-0x00000001862ED100
		public static uint Tick(uint counter) => default; // 0x00000001862ED100-0x00000001862ED1E0
		public static void Swap<T>(ref T a, ref T b) {}
		public static long ToLongUnchecked(object value) => default; // 0x00000001862ED1E0-0x00000001862ED600
	}
}
