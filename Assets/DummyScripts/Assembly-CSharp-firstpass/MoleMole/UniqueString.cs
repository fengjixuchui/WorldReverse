/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class UniqueString // TypeDefIndex: 10106
	{
		// Fields
		private static IDenseHashSetEx<string> m_strings; // 0x00
	
		// Constructors
		static UniqueString() {} // 0x000000018608C030-0x000000018608C0D0
	
		// Methods
		// [XID] // 0x000000018996BAB0-0x000000018996BAD0
		private static string InternalIntern(string str) => default; // 0x000000018608BD70-0x000000018608BEA0
		// [XID] // 0x00000001896204E0-0x0000000189620500
		public static string Intern(string str, bool removable = true /* Metadata: 0x00AE6F5B */) => default; // 0x000000018608BC80-0x000000018608BD70
		// [XID] // 0x00000001896BC020-0x00000001896BC040
		public static void InternString(ref string inString, bool removable = true /* Metadata: 0x00AE6F5C */) {} // 0x000000018608BB90-0x000000018608BC80
		// [XID] // 0x0000000189982740-0x0000000189982760
		public static void InternStringArray(string[] inStringArray, bool removable = true /* Metadata: 0x00AE6F5D */) {} // 0x000000018608B900-0x000000018608BA60
		// [XID] // 0x0000000189989F10-0x0000000189989F30
		public static void InternStringList(List<string> inStringArray) {} // 0x000000018608BA60-0x000000018608BB90
		// [XID] // 0x0000000189991850-0x0000000189991870
		public static string IsInterned(string str) => default; // 0x000000018608BEA0-0x000000018608C030
		// [XID] // 0x0000000189999340-0x0000000189999360
		public static void Clear() {} // 0x000000018608B7B0-0x000000018608B900
	}
}
