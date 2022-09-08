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
	public class X509Store // TypeDefIndex: 1074
	{
		// Fields
		private string _storePath; // 0x10
		private X509CertificateCollection _certificates; // 0x18
		private ArrayList _crls; // 0x20
		private bool _crl; // 0x28
	
		// Properties
		public X509CertificateCollection Certificates { get => default; } // 0x0000000189530DA0-0x0000000189530E20 
		public ArrayList Crls { get => default; } // 0x0000000189530E20-0x0000000189530ED0 
	
		// Constructors
		public X509Store() {} // Dummy constructor
		internal X509Store(string path, bool crl) {} // 0x0000000189530D10-0x0000000189530DA0
	
		// Methods
		private byte[] Load(string filename) => default; // 0x0000000189530B90-0x0000000189530D10
		private X509Certificate LoadCertificate(string filename) => default; // 0x0000000189530A50-0x0000000189530AF0
		private X509Crl LoadCrl(string filename) => default; // 0x0000000189530AF0-0x0000000189530B90
		private bool CheckStore(string path, bool throwException) => default; // 0x00000001895309A0-0x0000000189530A50
		private X509CertificateCollection BuildCertificatesCollection(string storeName) => default; // 0x0000000189530630-0x0000000189530800
		private ArrayList BuildCrlsCollection(string storeName) => default; // 0x0000000189530800-0x00000001895309A0
	}
}
