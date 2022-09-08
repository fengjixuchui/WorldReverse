/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;
using MessagePack.Formatters;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Unity
{
	public sealed class QuaternionFormatter : IMessagePackFormatter<Quaternion> // TypeDefIndex: 8446
	{
		// Constructors
		public QuaternionFormatter() {} // 0x00000001859F3B80-0x00000001859F3BE0
	
		// Methods
		// [XID] // 0x000000018965D120-0x000000018965D140
		public int Serialize(ref byte[] bytes, int offset, Quaternion value, IFormatterResolver formatterResolver) => default; // 0x00000001859F39E0-0x00000001859F3B80
		// [XID] // 0x0000000189B3C1D0-0x0000000189B3C1F0
		public Quaternion Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001859F3670-0x00000001859F39E0
	}
}
