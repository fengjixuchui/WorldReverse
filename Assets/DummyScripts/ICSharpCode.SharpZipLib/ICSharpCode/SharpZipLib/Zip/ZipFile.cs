/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip
{
	// [DefaultMember] // 0x00000001899E9F50-0x00000001899E9F80
	public class ZipFile : IEnumerable, IDisposable // TypeDefIndex: 6652
	{
		// Fields
		public KeysRequiredEventHandler KeysRequired; // 0x10
		private bool isDisposed_; // 0x18
		private string name_; // 0x20
		private string comment_; // 0x28
		private string rawPassword_; // 0x30
		private Stream baseStream_; // 0x38
		private bool isStreamOwner; // 0x40
		private long offsetOfFirstEntry; // 0x48
		private ZipEntry[] entries_; // 0x50
		private byte[] key; // 0x58
		private UseZip64 useZip64_; // 0x60
		private ArrayList updates_; // 0x68
		private Hashtable updateIndex_; // 0x70
		private IArchiveStorage archiveStorage_; // 0x78
		private IDynamicDataSource updateDataSource_; // 0x80
		private int bufferSize_; // 0x88
		private IEntryFactory updateEntryFactory_; // 0x90
	
		// Properties
		private bool HaveKeys { get => default; } // 0x000000018948A3A0-0x000000018948A400 
		public bool IsStreamOwner { get => default; } // 0x000000018948A400-0x000000018948A460 
	
		// Nested types
		public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e); // TypeDefIndex: 6653; 0x000000018947F860-0x000000018947FB10
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		private enum HeaderTest // TypeDefIndex: 6654
		{
			Extract = 1,
			Header = 2
		}
	
		private class ZipEntryEnumerator : IEnumerator // TypeDefIndex: 6655
		{
			// Fields
			private ZipEntry[] array; // 0x10
			private int index; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x0000000189484690-0x0000000189484730 
	
			// Constructors
			public ZipEntryEnumerator() {} // Dummy constructor
			public ZipEntryEnumerator(ZipEntry[] entries) {} // 0x0000000189484610-0x0000000189484690
	
			// Methods
			public void Reset() {} // 0x00000001894845B0-0x0000000189484610
			public bool MoveNext() => default; // 0x0000000189484530-0x00000001894845B0
		}
	
		private class PartialInputStream : Stream // TypeDefIndex: 6656
		{
			// Fields
			private ZipFile zipFile_; // 0x10
			private Stream baseStream_; // 0x18
			private long start_; // 0x20
			private long length_; // 0x28
			private long readPos_; // 0x30
			private long end_; // 0x38
	
			// Properties
			public override long Position { get => default; set {} } // 0x0000000189480AA0-0x0000000189480B10 0x0000000189480B10-0x0000000189480BF0
			public override long Length { get => default; } // 0x0000000189480A40-0x0000000189480AA0 
			public override bool CanWrite { get => default; } // 0x00000001894809F0-0x0000000189480A40 
			public override bool CanSeek { get => default; } // 0x00000001894809A0-0x00000001894809F0 
			public override bool CanRead { get => default; } // 0x0000000189480950-0x00000001894809A0 
	
			// Constructors
			public PartialInputStream() {} // Dummy constructor
			public PartialInputStream(ZipFile zipFile, long start, long length) {} // 0x0000000189480880-0x0000000189480950
	
			// Methods
			public override int ReadByte() => default; // 0x00000001894803B0-0x0000000189480500
			public override void Close() {} // 0x0000000189480310-0x0000000189480360
			public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000189480500-0x0000000189480690
			public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189480810-0x0000000189480880
			public override void SetLength(long value) {} // 0x00000001894807A0-0x0000000189480810
			public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189480690-0x00000001894807A0
			public override void Flush() {} // 0x0000000189480360-0x00000001894803B0
		}
	
		// Constructors
		public ZipFile() {} // Dummy constructor
		public ZipFile(string name) {} // 0x000000018948A270-0x000000018948A3A0
	
		// Methods
		private void OnKeysRequired(string fileName) {} // 0x0000000189488630-0x0000000189488730
		~ZipFile() {} // 0x0000000189487B50-0x0000000189487C00
		public void Close() {} // 0x00000001894872C0-0x0000000189487330
		public IEnumerator GetEnumerator() => default; // 0x0000000189487E00-0x0000000189487EC0
		public int FindEntry(string name, bool ignoreCase) => default; // 0x0000000189487C00-0x0000000189487E00
		public Stream GetInputStream(ZipEntry entry) => default; // 0x00000001894881F0-0x0000000189488460
		public Stream GetInputStream(long entryIndex) => default; // 0x0000000189487EC0-0x00000001894881F0
		private long TestLocalHeader(ZipEntry entry, HeaderTest tests) => default; // 0x00000001894893B0-0x000000018948A270
		private void PostUpdateCleanup() {} // 0x0000000189488730-0x00000001894887C0
		void IDisposable.Dispose() {} // 0x0000000189489300-0x00000001894893B0
		private void DisposeInternal(bool disposing) {} // 0x0000000189487960-0x0000000189487AD0
		protected virtual void Dispose(bool disposing) {} // 0x0000000189487AD0-0x0000000189487B50
		private ushort ReadLEUshort() => default; // 0x00000001894891E0-0x0000000189489300
		private uint ReadLEUint() => default; // 0x00000001894890D0-0x0000000189489150
		private ulong ReadLEUlong() => default; // 0x0000000189489150-0x00000001894891E0
		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData) => default; // 0x0000000189488460-0x00000001894885B0
		private void ReadEntries() {} // 0x00000001894887C0-0x00000001894890D0
		private long LocateEntry(ZipEntry entry) => default; // 0x00000001894885B0-0x0000000189488630
		private Stream CreateAndInitDecryptionStream(Stream baseStream, ZipEntry entry) => default; // 0x0000000189487330-0x0000000189487960
		private static void CheckClassicPassword(CryptoStream classicCryptoStream, ZipEntry entry) {} // 0x0000000189487170-0x00000001894872C0
	}
}
