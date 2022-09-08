/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal abstract class CipherSuite // TypeDefIndex: 1109
	{
		// Fields
		public static byte[] EmptyArray; // 0x00
		private short code; // 0x10
		private string name; // 0x18
		private CipherAlgorithmType cipherAlgorithmType; // 0x20
		private HashAlgorithmType hashAlgorithmType; // 0x24
		private ExchangeAlgorithmType exchangeAlgorithmType; // 0x28
		private bool isExportable; // 0x2C
		private CipherMode cipherMode; // 0x30
		private byte keyMaterialSize; // 0x34
		private int keyBlockSize; // 0x38
		private byte expandedKeyMaterialSize; // 0x3C
		private short effectiveKeyBits; // 0x3E
		private byte ivSize; // 0x40
		private byte blockSize; // 0x41
		private Context context; // 0x48
		private SymmetricAlgorithm encryptionAlgorithm; // 0x50
		private ICryptoTransform encryptionCipher; // 0x58
		private SymmetricAlgorithm decryptionAlgorithm; // 0x60
		private ICryptoTransform decryptionCipher; // 0x68
		private KeyedHashAlgorithm clientHMAC; // 0x70
		private KeyedHashAlgorithm serverHMAC; // 0x78
	
		// Properties
		protected ICryptoTransform EncryptionCipher { get; } // 0x00000001873B0FD0-0x00000001873B1030 
		protected ICryptoTransform DecryptionCipher { get; } // 0x00000001873B0F10-0x00000001873B0F70 
		protected KeyedHashAlgorithm ClientHMAC { get; } // 0x00000001873B0DF0-0x00000001873B0E50 
		protected KeyedHashAlgorithm ServerHMAC { get; } // 0x00000001873B1420-0x00000001873B1480 
		public CipherAlgorithmType CipherAlgorithmType { get; } // 0x00000001873B0D30-0x00000001873B0D90 
		public string HashAlgorithmName { get; } // 0x00000001873B10F0-0x00000001873B1170 
		public HashAlgorithmType HashAlgorithmType { get; } // 0x00000001873B1170-0x00000001873B11D0 
		public int HashSize { get; } // 0x00000001873B11D0-0x00000001873B1240 
		public ExchangeAlgorithmType ExchangeAlgorithmType { get; } // 0x00000001873B1030-0x00000001873B1090 
		public CipherMode CipherMode { get; } // 0x00000001873B0D90-0x00000001873B0DF0 
		public short Code { get; } // 0x00000001873B0E50-0x00000001873B0EB0 
		public string Name { get; } // 0x00000001873B13C0-0x00000001873B1420 
		public bool IsExportable { get; } // 0x00000001873B1240-0x00000001873B12A0 
		public byte KeyMaterialSize { get; } // 0x00000001873B1360-0x00000001873B13C0 
		public int KeyBlockSize { get; } // 0x00000001873B1300-0x00000001873B1360 
		public byte ExpandedKeyMaterialSize { get; } // 0x00000001873B1090-0x00000001873B10F0 
		public short EffectiveKeyBits { get; } // 0x00000001873B0F70-0x00000001873B0FD0 
		public byte IvSize { get; } // 0x00000001873B12A0-0x00000001873B1300 
		public Context Context { get; set; } // 0x00000001873B0EB0-0x00000001873B0F10 0x00000001873B1480-0x00000001873B14E0
	
		// Constructors
		protected CipherSuite() {} // Dummy constructor
		public CipherSuite(short code, string name, CipherAlgorithmType cipherAlgorithmType, HashAlgorithmType hashAlgorithmType, ExchangeAlgorithmType exchangeAlgorithmType, bool exportable, bool blockMode, byte keyMaterialSize, byte expandedKeyMaterialSize, short effectiveKeyBits, byte ivSize, byte blockSize) {} // 0x00000001873B01F0-0x00000001873B0350
		static CipherSuite() {} // 0x00000001873B0170-0x00000001873B01F0
	
		// Methods
		internal void Write(byte[] array, int offset, short value) {} // 0x00000001873AFE80-0x00000001873AFF80
		internal void Write(byte[] array, int offset, ulong value) {} // 0x00000001873AFF80-0x00000001873B0170
		public void InitializeCipher() {} // 0x00000001873AFB40-0x00000001873AFBB0
		public byte[] EncryptRecord(byte[] fragment, byte[] mac) => default; // 0x00000001873AF4F0-0x00000001873AF790
		public void DecryptRecord(byte[] fragment, out byte[] dcrFragment, out byte[] dcrMAC) {
			dcrFragment = default;
			dcrMAC = default;
		} // 0x00000001873AF200-0x00000001873AF4F0
		public abstract byte[] ComputeClientRecordMAC(ContentType contentType, byte[] fragment);
		public abstract byte[] ComputeServerRecordMAC(ContentType contentType, byte[] fragment);
		public abstract void ComputeMasterSecret(byte[] preMasterSecret);
		public abstract void ComputeKeys();
		public byte[] CreatePremasterSecret() => default; // 0x00000001873AF050-0x00000001873AF200
		public byte[] PRF(byte[] secret, string label, byte[] data, int length) => default; // 0x00000001873AFBB0-0x00000001873AFE80
		public byte[] Expand(string hashName, byte[] secret, byte[] seed, int length) => default; // 0x00000001873AF790-0x00000001873AFB40
		private void createEncryptionCipher() {} // 0x00000001873B0840-0x00000001873B0D30
		private void createDecryptionCipher() {} // 0x00000001873B0350-0x00000001873B0840
	}
}
