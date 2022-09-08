/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class ClientSessionCache // TypeDefIndex: 1115
	{
		// Fields
		private static Hashtable cache; // 0x00
		private static object locker; // 0x08
	
		// Constructors
		public ClientSessionCache() {} // Dummy constructor
		static ClientSessionCache() {} // 0x00000001873B2DD0-0x00000001873B2E80
	
		// Methods
		public static void Add(string host, byte[] id) {} // 0x00000001873B2210-0x00000001873B25A0
		public static byte[] FromHost(string host) => default; // 0x00000001873B27E0-0x00000001873B2AF0
		private static ClientSessionInfo FromContext(Context context, bool checkValidity) => default; // 0x00000001873B25A0-0x00000001873B27E0
		public static bool SetContextInCache(Context context) => default; // 0x00000001873B2C60-0x00000001873B2DD0
		public static bool SetContextFromCache(Context context) => default; // 0x00000001873B2AF0-0x00000001873B2C60
	}
}
