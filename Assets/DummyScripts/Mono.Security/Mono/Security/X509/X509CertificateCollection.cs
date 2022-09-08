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

namespace Mono.Security.X509
{
	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 1066
	{
		// Properties
		public X509Certificate this[int index] { get => default; } // 0x000000018952C860-0x000000018952C950 
	
		// Nested types
		public class X509CertificateEnumerator : IEnumerator // TypeDefIndex: 1067
		{
			// Fields
			private IEnumerator enumerator; // 0x10
	
			// Properties
			object IEnumerator.Current { get => default; } // 0x000000018952CB50-0x000000018952CBD0 
			public X509Certificate Current { get => default; } // 0x000000018952CC60-0x000000018952CD30 
	
			// Constructors
			public X509CertificateEnumerator() {} // Dummy constructor
			public X509CertificateEnumerator(X509CertificateCollection mappings) {} // 0x000000018952CBD0-0x000000018952CC60
	
			// Methods
			bool IEnumerator.MoveNext() => default; // 0x000000018952CA50-0x000000018952CAD0
			void IEnumerator.Reset() {} // 0x000000018952CAD0-0x000000018952CB50
			public bool MoveNext() => default; // 0x000000018952C950-0x000000018952C9D0
			public void Reset() {} // 0x000000018952C9D0-0x000000018952CA50
		}
	
		// Constructors
		public X509CertificateCollection() {} // 0x000000018952C780-0x000000018952C7E0
		public X509CertificateCollection(X509CertificateCollection value) {} // 0x000000018952C7E0-0x000000018952C860
	
		// Methods
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018952C6F0-0x000000018952C780
		public int Add(X509Certificate value) => default; // 0x000000018952C1A0-0x000000018952C270
		public void AddRange(X509CertificateCollection value) {} // 0x000000018952C080-0x000000018952C1A0
		public bool Contains(X509Certificate value) => default; // 0x000000018952C340-0x000000018952C3C0
		public new X509CertificateEnumerator GetEnumerator() => default; // 0x000000018952C3C0-0x000000018952C440
		public override int GetHashCode() => default; // 0x000000018952C440-0x000000018952C4D0
		public int IndexOf(X509Certificate value) => default; // 0x000000018952C4D0-0x000000018952C650
		public void Remove(X509Certificate value) {} // 0x000000018952C650-0x000000018952C6F0
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x000000018952C270-0x000000018952C340
	}
}
