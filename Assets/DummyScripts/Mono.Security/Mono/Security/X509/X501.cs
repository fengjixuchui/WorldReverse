/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Security;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	public sealed class X501 // TypeDefIndex: 1064
	{
		// Fields
		private static byte[] countryName; // 0x00
		private static byte[] organizationName; // 0x08
		private static byte[] organizationalUnitName; // 0x10
		private static byte[] commonName; // 0x18
		private static byte[] localityName; // 0x20
		private static byte[] stateOrProvinceName; // 0x28
		private static byte[] streetAddress; // 0x30
		private static byte[] domainComponent; // 0x38
		private static byte[] userid; // 0x40
		private static byte[] email; // 0x48
		private static byte[] dnQualifier; // 0x50
		private static byte[] title; // 0x58
		private static byte[] surname; // 0x60
		private static byte[] givenName; // 0x68
		private static byte[] initial; // 0x70
	
		// Constructors
		public X501() {} // Dummy constructor
		static X501() {} // 0x0000000186E30E00-0x0000000186E315D0
	
		// Methods
		public static string ToString(ASN1 seq) => default; // 0x0000000186E30CB0-0x0000000186E30E00
		public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) => default; // 0x0000000186E30AA0-0x0000000186E30CB0
		private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) {} // 0x0000000186E2EDA0-0x0000000186E2F720
		private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType) => default; // 0x0000000186E2F8C0-0x0000000186E2FEB0
		private static bool IsOid(string oid) => default; // 0x0000000186E2FFB0-0x0000000186E30040
		private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos) => default; // 0x0000000186E30040-0x0000000186E30210
		private static bool IsHex(char c) => default; // 0x0000000186E2FEB0-0x0000000186E2FFB0
		private static string ReadHex(string value, ref int pos) => default; // 0x0000000186E30400-0x0000000186E30600
		private static int ReadEscaped(StringBuilder sb, string value, int pos) => default; // 0x0000000186E30210-0x0000000186E30400
		private static int ReadQuoted(StringBuilder sb, string value, int pos) => default; // 0x0000000186E30600-0x0000000186E307B0
		private static string ReadValue(string value, ref int pos) => default; // 0x0000000186E307B0-0x0000000186E30AA0
		public static ASN1 FromString(string rdn) => default; // 0x0000000186E2F720-0x0000000186E2F8C0
	}
}
