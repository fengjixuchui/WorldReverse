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

namespace Mono.Security
{
	public class ASN1 // TypeDefIndex: 1040
	{
		// Fields
		private byte m_nTag; // 0x10
		private byte[] m_aValue; // 0x18
		private ArrayList elist; // 0x20
	
		// Properties
		public int Count { get => default; } // 0x00000001873A8B40-0x00000001873A8BC0 
		public byte Tag { get => default; } // 0x00000001873A8CF0-0x00000001873A8D50 
		public int Length { get => default; } // 0x00000001873A8C80-0x00000001873A8CF0 
		public byte[] Value { get => default; set {} } // 0x00000001873A8D50-0x00000001873A8E20 0x00000001873A8E20-0x00000001873A8ED0
		public ASN1 this[int index] { get => default; } // 0x00000001873A8BC0-0x00000001873A8C80 
	
		// Constructors
		public ASN1() {} // Dummy constructor
		public ASN1(byte tag) {} // 0x00000001873A8A80-0x00000001873A8B40
		public ASN1(byte tag, byte[] data) {} // 0x00000001873A89F0-0x00000001873A8A80
		public ASN1(byte[] data) {} // 0x00000001873A8820-0x00000001873A89F0
	
		// Methods
		private bool CompareArray(byte[] array1, byte[] array2) => default; // 0x00000001873A7960-0x00000001873A7A50
		public bool CompareValue(byte[] value) => default; // 0x00000001873A7A50-0x00000001873A7AD0
		public ASN1 Add(ASN1 asn1) => default; // 0x00000001873A78A0-0x00000001873A7960
		public virtual byte[] GetBytes() => default; // 0x00000001873A7F10-0x00000001873A85D0
		protected void Decode(byte[] asn1, ref int anPos, int anLength) {} // 0x00000001873A7C80-0x00000001873A7DF0
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) {
			tag = default;
			length = default;
			content = default;
		} // 0x00000001873A7AD0-0x00000001873A7C80
		public ASN1 Element(int index, byte anTag) => default; // 0x00000001873A7DF0-0x00000001873A7F10
		public override string ToString() => default; // 0x00000001873A85D0-0x00000001873A8820
	}
}
