/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class DoubleArrayFormatter : IMessagePackFormatter<double[]> // TypeDefIndex: 8248
	{
		// Fields
		public static readonly DoubleArrayFormatter Instance; // 0x00
	
		// Constructors
		private DoubleArrayFormatter() {} // 0x00000001856CA490-0x00000001856CA4F0
		static DoubleArrayFormatter() {} // 0x00000001856CA3D0-0x00000001856CA490
	
		// Methods
		// [XID] // 0x000000018969FA10-0x000000018969FA30
		public int Serialize(ref byte[] bytes, int offset, double[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856CA200-0x00000001856CA3D0
		// [XID] // 0x00000001896A6B90-0x00000001896A6BB0
		public double[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C9FE0-0x00000001856CA200
	}
}
