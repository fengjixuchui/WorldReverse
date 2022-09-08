/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	public static class PatchManager // TypeDefIndex: 5036
	{
		// Fields
		private static Dictionary<Assembly, Action> removers; // 0x00
		private static VERSION version; // 0x08
	
		// Nested types
		public enum VERSION // TypeDefIndex: 5037
		{
			LASTEST = 0,
			UPDATE = 1,
			ORIGINAL = 2
		}
	
		// Constructors
		static PatchManager() {} // 0x0000000189417170-0x0000000189417210
	
		// Methods
		public static void SetVersion(VERSION v) {} // 0x0000000189417060-0x00000001894170F0
		private static MethodBase readMethod(BinaryReader reader, System.Type[] externTypes) => default; // 0x0000000189417370-0x0000000189418270
		private static int getMapId(MethodBase method) => default; // 0x0000000189417210-0x0000000189417370
		private static int[] readSlotInfo(BinaryReader reader, Dictionary<MethodInfo, int> itfMethodToId, System.Type[] externTypes, int maxId) => default; // 0x0000000189418270-0x00000001894184B0
		public static VirtualMachine Load(Stream stream) => default; // 0x0000000189415520-0x0000000189417060
	}
}
