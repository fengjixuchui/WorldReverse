/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001896F1A50-0x00000001896F1AC0
	[CustomObfuscation] // 0x00000001896F1A50-0x00000001896F1AC0
	internal class NativeBuffer : IDisposable // TypeDefIndex: 4342
	{
		// Fields
		private IntPtr izvhHmSvmUBneSslrLADBhxqUkP; // 0x10
		private int MwElyJEsJpEEOifMfHHXevYlDKfg; // 0x18
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x1C
	
		// Properties
		public IntPtr Pointer { get => default; } // 0x0000000185558050-0x00000001855580B0 
		public int Length { get => default; } // 0x0000000185557FF0-0x0000000185558050 
		public byte this[int index] { get => default; set {} } // 0x0000000185557EF0-0x0000000185557FF0 0x0000000185558110-0x00000001855581F0
	
		// Constructors
		public NativeBuffer() {} // Dummy constructor
		public NativeBuffer(int size) {} // 0x0000000185557E50-0x0000000185557EF0
	
		// Methods
		public IntPtr GetPointer(int offset = 0 /* Metadata: 0x00AC4F0C */) => default; // 0x0000000185556BB0-0x0000000185556CD0
		public ushort ReadUShort(int startIndex) => default; // 0x0000000185556DB0-0x0000000185556E90
		public int ReadInt(int startIndex) => default; // 0x0000000185556CD0-0x0000000185556DB0
		public int TryReadBytes(byte[] buffer, int numBytesToRead, int readStartIndex = 0 /* Metadata: 0x00AC4F10 */, int writeStartIndex = 0 /* Metadata: 0x00AC4F14 */) => default; // 0x0000000185557520-0x00000001855576B0
		public void Write(uint bytes, int startIndex) {} // 0x0000000185557840-0x0000000185557930
		public void Write(float bytes, int startIndex) {} // 0x0000000185557930-0x0000000185557A70
		public void Write(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0 /* Metadata: 0x00AC4F18 */, int readStartIndex = 0 /* Metadata: 0x00AC4F1C */) {} // 0x0000000185557A70-0x0000000185557E50
		public int TryWriteBytes(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0 /* Metadata: 0x00AC4F20 */, int readStartIndex = 0 /* Metadata: 0x00AC4F24 */) => default; // 0x00000001855576B0-0x0000000185557840
		public bool Resize(int size, bool preserveData) => default; // 0x0000000185556FC0-0x00000001855572A0
		public void Clear() {} // 0x0000000185556980-0x00000001855569F0
		public void Release() {} // 0x0000000185556E90-0x0000000185556FC0
		public override string ToString() => default; // 0x00000001855572A0-0x0000000185557520
		public void Dispose() {} // 0x00000001855569F0-0x0000000185556A70
		~NativeBuffer() {} // 0x0000000185556B00-0x0000000185556BB0
		protected virtual void Dispose(bool disposing) {} // 0x0000000185556A70-0x0000000185556B00
		public static implicit operator IntPtr(NativeBuffer buffer) => default; // 0x00000001855580B0-0x0000000185558110
	}
}
