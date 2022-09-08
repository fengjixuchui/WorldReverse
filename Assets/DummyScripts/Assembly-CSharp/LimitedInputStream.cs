/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class LimitedInputStream : Stream // TypeDefIndex: 26344
{
	// Fields
	private readonly Stream proxied; // 0x10
	private int bytesLeft; // 0x18

	// Properties
	public override bool CanRead { /* [XID] */ /* 0x00000001898C0FD0-0x00000001898C0FF0 */ get => default; } // 0x00000001823D49E0-0x00000001823D4A80 
	public override bool CanSeek { /* [XID] */ /* 0x00000001898C8990-0x00000001898C89B0 */ get => default; } // 0x00000001823D4A80-0x00000001823D4B20 
	public override bool CanWrite { /* [XID] */ /* 0x00000001898D02F0-0x00000001898D0310 */ get => default; } // 0x00000001823D4B20-0x00000001823D4BC0 
	public override long Length { /* [XID] */ /* 0x00000001898DF5C0-0x00000001898DF5E0 */ get => default; } // 0x00000001823D4BC0-0x00000001823D4C90 
	public override long Position { /* [XID] */ /* 0x00000001898E7040-0x00000001898E7060 */ get => default; /* [XID] */ /* 0x00000001898EE830-0x00000001898EE850 */ set {} } // 0x00000001823D4C90-0x00000001823D4D60 0x00000001823D4D60-0x00000001823D4E30

	// Constructors
	public LimitedInputStream() {} // Dummy constructor
	internal LimitedInputStream(Stream proxied, int size) {} // 0x00000001823D4940-0x00000001823D49E0

	// Methods
	// [XID] // 0x00000001898D7950-0x00000001898D7970
	public override void Flush() {} // 0x00000001823D44B0-0x00000001823D4550
	// [XID] // 0x00000001898F5FB0-0x00000001898F5FD0
	public override int Read(byte[] buffer, int offset, int count) => default; // 0x00000001823D4550-0x00000001823D4680
	// [XID] // 0x00000001898FD840-0x00000001898FD860
	public override long Seek(long offset, SeekOrigin origin) => default; // 0x00000001823D4680-0x00000001823D4770
	// [XID] // 0x00000001899050F0-0x0000000189905110
	public override void SetLength(long value) {} // 0x00000001823D4770-0x00000001823D4840
	// [XID] // 0x000000018990C900-0x000000018990C920
	public override void Write(byte[] buffer, int offset, int count) {} // 0x00000001823D4840-0x00000001823D4940
}

