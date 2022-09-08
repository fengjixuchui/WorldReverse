/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Encryption
{
	public sealed class PkzipClassicManaged : PkzipClassic // TypeDefIndex: 6631
	{
		// Fields
		private byte[] key_; // 0x50
	
		// Properties
		public override int BlockSize { get => default; set {} } // 0x0000000189481FC0-0x0000000189482010 0x00000001894821E0-0x0000000189482270
		public override KeySizes[] LegalKeySizes { get => default; } // 0x00000001894820E0-0x00000001894821E0 
		public override byte[] Key { get => default; set {} } // 0x0000000189482010-0x00000001894820E0 0x0000000189482270-0x0000000189482390
	
		// Constructors
		public PkzipClassicManaged() {} // 0x0000000189481F20-0x0000000189481FC0
	
		// Methods
		public override void GenerateIV() {} // 0x0000000189481E10-0x0000000189481E60
		public override void GenerateKey() {} // 0x0000000189481E60-0x0000000189481F20
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) => default; // 0x0000000189481D70-0x0000000189481E10
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) => default; // 0x0000000189481CD0-0x0000000189481D70
	}
}
