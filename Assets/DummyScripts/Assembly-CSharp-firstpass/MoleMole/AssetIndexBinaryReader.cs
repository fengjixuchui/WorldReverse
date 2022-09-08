/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AssetIndexBinaryReader // TypeDefIndex: 7350
	{
		// Fields
		private Stream _fs; // 0x10
		private BinaryReader _br; // 0x18
	
		// Constructors
		public AssetIndexBinaryReader() {} // Dummy constructor
		private AssetIndexBinaryReader(string filePath) {} // 0x00000001868E60C0-0x00000001868E6370
	
		// Methods
		// [XID] // 0x0000000189819BC0-0x0000000189819BE0
		public static AssetIndexBinaryReader OpenFile(string filePath) => default; // 0x00000001868E5A70-0x00000001868E5B40
		// [XID] // 0x0000000189821420-0x0000000189821440
		public void CloseFile() {} // 0x00000001868E5790-0x00000001868E5880
		// [XID] // 0x0000000189828920-0x0000000189828940
		public bool Finish() => default; // 0x00000001868E5880-0x00000001868E5980
		// [XID] // 0x000000018982FC70-0x000000018982FC90
		public bool IsFinish() => default; // 0x00000001868E5980-0x00000001868E5A70
		// [XID] // 0x00000001898374B0-0x00000001898374D0
		public byte[] ReadBytes(int count) => default; // 0x00000001868E5C00-0x00000001868E5CD0
		// [XID] // 0x000000018983EAB0-0x000000018983EAD0
		public byte ReadByte() => default; // 0x00000001868E5B40-0x00000001868E5C00
		// [XID] // 0x0000000189846120-0x0000000189846140
		public int ReadInt32() => default; // 0x00000001868E5E50-0x00000001868E5F10
		// [XID] // 0x000000018984D710-0x000000018984D730
		public ulong ReadULong() => default; // 0x00000001868E6000-0x00000001868E60C0
		// [XID] // 0x0000000189854710-0x0000000189854730
		public char ReadChar() => default; // 0x00000001868E5CD0-0x00000001868E5D90
		// [XID] // 0x000000018985C140-0x000000018985C160
		public short ReadInt16() => default; // 0x00000001868E5D90-0x00000001868E5E50
		// [XID] // 0x0000000189863A30-0x0000000189863A50
		public string ReadStringWithLength() => default; // 0x00000001868E5F10-0x00000001868E6000
	}
}
