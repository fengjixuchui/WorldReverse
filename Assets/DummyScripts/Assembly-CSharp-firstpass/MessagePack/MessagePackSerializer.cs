/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack
{
	public static class MessagePackSerializer // TypeDefIndex: 8428
	{
		// Fields
		private static IFormatterResolver defaultResolver; // 0x00
	
		// Properties
		public static IFormatterResolver DefaultResolver { /* [XID] */ /* 0x00000001899F0200-0x00000001899F0220 */ get; } // 0x00000001859E3FD0-0x00000001859E40D0 
		public static bool IsInitialized { /* [XID] */ /* 0x0000000189985370-0x0000000189985390 */ get; } // 0x00000001859E40D0-0x00000001859E4180 
	
		// Methods
		// [XID] // 0x000000018998CE40-0x000000018998CE60
		public static void SetDefaultResolver(IFormatterResolver resolver) {} // 0x00000001859E3090-0x00000001859E3140
		public static byte[] Serialize<T>(T obj) => default;
		public static byte[] Serialize<T>(T obj, IFormatterResolver resolver) => default;
		public static ArraySegment<byte> SerializeUnsafe<T>(T obj) => default;
		public static ArraySegment<byte> SerializeUnsafe<T>(T obj, IFormatterResolver resolver) => default;
		public static void Serialize<T>(Stream stream, T obj) {}
		public static void Serialize<T>(Stream stream, T obj, IFormatterResolver resolver) {}
		public static T Deserialize<T>(byte[] bytes) => default;
		public static T Deserialize<T>(byte[] bytes, IFormatterResolver resolver) => default;
		public static T Deserialize<T>(Stream stream) => default;
		public static T Deserialize<T>(Stream stream, IFormatterResolver resolver) => default;
		// [XID] // 0x0000000189994B80-0x0000000189994BA0
		private static int FillFromStream(Stream input, ref byte[] buffer) => default; // 0x00000001859E2F30-0x00000001859E3090
		public static string ToJson<T>(T obj) => default;
		public static string ToJson<T>(T obj, IFormatterResolver resolver) => default;
		// [XID] // 0x0000000189A2B140-0x0000000189A2B160
		public static string ToJson(byte[] bytes) => default; // 0x00000001859E3CA0-0x00000001859E3DB0
		// [XID] // 0x0000000189A327D0-0x0000000189A327F0
		private static int ToJsonCore(byte[] bytes, int offset, StringBuilder builder) => default; // 0x00000001859E3140-0x00000001859E3CA0
		// [XID] // 0x00000001899AB930-0x00000001899AB950
		private static void WriteJsonString(string value, StringBuilder builder) {} // 0x00000001859E3DB0-0x00000001859E3FD0
	}
}
