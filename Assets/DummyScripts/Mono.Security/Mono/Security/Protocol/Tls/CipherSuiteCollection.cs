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
	internal sealed class CipherSuiteCollection : IList // TypeDefIndex: 1110
	{
		// Fields
		private ArrayList cipherSuites; // 0x10
		private SecurityProtocolType protocol; // 0x18
	
		// Properties
		object IList.this[int index] { get => default; set {} } // 0x00000001873ADDA0-0x00000001873ADE20 0x00000001873ADE20-0x00000001873ADEF0
		bool ICollection.IsSynchronized { get => default; } // 0x00000001873AD770-0x00000001873AD7F0 
		object ICollection.SyncRoot { get => default; } // 0x00000001873AD7F0-0x00000001873AD870 
		public CipherSuite this[string name] { get => default; } // 0x00000001873AE310-0x00000001873AE410 
		public CipherSuite this[int index] { get => default; set {} } // 0x00000001873AE510-0x00000001873AE5F0 0x00000001873AE5F0-0x00000001873AE690
		public CipherSuite this[short code] { get => default; } // 0x00000001873AE410-0x00000001873AE510 
		public int Count { get => default; } // 0x00000001873AE190-0x00000001873AE210 
		public bool IsFixedSize { get => default; } // 0x00000001873AE210-0x00000001873AE290 
		public bool IsReadOnly { get => default; } // 0x00000001873AE290-0x00000001873AE310 
	
		// Constructors
		public CipherSuiteCollection() {} // Dummy constructor
		public CipherSuiteCollection(SecurityProtocolType protocol) {} // 0x00000001873ADEF0-0x00000001873ADF80
	
		// Methods
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001873AD870-0x00000001873AD8F0
		bool IList.Contains(object value) => default; // 0x00000001873AD9C0-0x00000001873ADA90
		int IList.IndexOf(object value) => default; // 0x00000001873ADA90-0x00000001873ADB60
		void IList.Insert(int index, object value) {} // 0x00000001873ADB60-0x00000001873ADC40
		void IList.Remove(object value) {} // 0x00000001873ADCD0-0x00000001873ADDA0
		void IList.RemoveAt(int index) {} // 0x00000001873ADC40-0x00000001873ADCD0
		int IList.Add(object value) => default; // 0x00000001873AD8F0-0x00000001873AD9C0
		public void CopyTo(Array array, int index) {} // 0x00000001873AD2D0-0x00000001873AD370
		public void Clear() {} // 0x00000001873AD250-0x00000001873AD2D0
		public int IndexOf(string name) => default; // 0x00000001873AD370-0x00000001873AD580
		public int IndexOf(short code) => default; // 0x00000001873AD580-0x00000001873AD770
		public CipherSuite Add(short code, string name, CipherAlgorithmType cipherType, HashAlgorithmType hashType, ExchangeAlgorithmType exchangeType, bool exportable, bool blockMode, byte keyMaterialSize, byte expandedKeyMaterialSize, short effectiveKeyBytes, byte ivSize, byte blockSize) => default; // 0x00000001873AD010-0x00000001873AD250
		private TlsCipherSuite add(TlsCipherSuite cipherSuite) => default; // 0x00000001873AE010-0x00000001873AE0A0
		private SslCipherSuite add(SslCipherSuite cipherSuite) => default; // 0x00000001873ADF80-0x00000001873AE010
		private bool cultureAwareCompare(string strA, string strB) => default; // 0x00000001873AE0A0-0x00000001873AE190
	}
}
