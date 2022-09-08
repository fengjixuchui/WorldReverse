/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipEntry : ICloneable // TypeDefIndex: 6646
	{
		// Fields
		private Known known; // 0x10
		private int externalFileAttributes; // 0x14
		private ushort versionMadeBy; // 0x18
		private string name; // 0x20
		private ulong size; // 0x28
		private ulong compressedSize; // 0x30
		private ushort versionToExtract; // 0x38
		private uint crc; // 0x3C
		private uint dosTime; // 0x40
		private CompressionMethod method; // 0x44
		private byte[] extra; // 0x48
		private string comment; // 0x50
		private int flags; // 0x58
		private long zipFileIndex; // 0x60
		private long offset; // 0x68
		private bool forceZip64_; // 0x70
		private byte cryptoCheckValue_; // 0x71
		private int _aesVer; // 0x74
		private int _aesEncryptionStrength; // 0x78
	
		// Properties
		public bool IsCrypted { get => default; } // 0x00000001894859B0-0x0000000189485A10 
		internal byte CryptoCheckValue { get => default; set {} } // 0x0000000189485830-0x0000000189485890 0x0000000189486060-0x00000001894860C0
		public int Flags { get => default; set {} } // 0x00000001894858F0-0x0000000189485950 0x0000000189486410-0x0000000189486470
		public long ZipFileIndex { get => default; set {} } // 0x0000000189485E60-0x0000000189485EC0 0x0000000189486540-0x00000001894865A0
		public long Offset { get => default; set {} } // 0x0000000189485CB0-0x0000000189485D10 0x0000000189486470-0x00000001894864D0
		public int ExternalFileAttributes { get => default; set {} } // 0x0000000189485890-0x00000001894858F0 0x00000001894862A0-0x0000000189486310
		public int HostSystem { get => default; } // 0x0000000189485950-0x00000001894859B0 
		public int Version { get => default; } // 0x0000000189485D80-0x0000000189485E60 
		public bool LocalHeaderRequiresZip64 { get => default; } // 0x0000000189485B70-0x0000000189485C50 
		public bool CentralHeaderRequiresZip64 { get => default; } // 0x0000000189485670-0x00000001894856F0 
		public long DosTime { set {} } // 0x0000000189486230-0x00000001894862A0
		public DateTime DateTime { set {} } // 0x00000001894860C0-0x0000000189486230
		public string Name { get => default; } // 0x0000000189485C50-0x0000000189485CB0 
		public long Size { get => default; set {} } // 0x0000000189485D10-0x0000000189485D80 0x00000001894864D0-0x0000000189486540
		public long CompressedSize { get => default; set {} } // 0x00000001894856F0-0x0000000189485760 0x0000000189485F80-0x0000000189485FF0
		public long Crc { get => default; set {} } // 0x00000001894857C0-0x0000000189485830 0x0000000189485FF0-0x0000000189486060
		public CompressionMethod CompressionMethod { get => default; } // 0x0000000189485760-0x00000001894857C0 
		public byte[] ExtraData { set {} } // 0x0000000189486310-0x0000000189486410
		public int AESKeySize { get => default; } // 0x00000001894854D0-0x0000000189485600 
		internal int AESSaltLen { get => default; } // 0x0000000189485600-0x0000000189485670 
		public string Comment { set {} } // 0x0000000189485EC0-0x0000000189485F80
		public bool IsDirectory { get => default; } // 0x0000000189485A10-0x0000000189485AF0 
		public bool IsFile { get => default; } // 0x0000000189485AF0-0x0000000189485B70 
	
		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		private enum Known : byte // TypeDefIndex: 6647
		{
			None = 0,
			Size = 1,
			CompressedSize = 2,
			Crc = 4,
			Time = 8,
			ExternalAttributes = 16
		}
	
		// Constructors
		public ZipEntry() {} // Dummy constructor
		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method) {} // 0x0000000189485320-0x00000001894854D0
	
		// Methods
		private bool HasDosAttributes(int attributes) => default; // 0x0000000189484970-0x0000000189484AD0
		internal void ProcessExtraData(bool localHeader) {} // 0x0000000189484E50-0x00000001894852C0
		private void ProcessAESExtraData(ZipExtraData extraData) {} // 0x0000000189484C10-0x0000000189484E50
		public bool IsCompressionMethodSupported() => default; // 0x0000000189484B30-0x0000000189484C10
		public object Clone() => default; // 0x0000000189484830-0x0000000189484970
		public override string ToString() => default; // 0x00000001894852C0-0x0000000189485320
		public static bool IsCompressionMethodSupported(CompressionMethod method) => default; // 0x0000000189484AD0-0x0000000189484B30
	}
}
