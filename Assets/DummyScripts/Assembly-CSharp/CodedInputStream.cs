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

public sealed class CodedInputStream : IDisposable // TypeDefIndex: 26298
{
	// Fields
	private readonly bool leaveOpen; // 0x10
	private byte[] buffer; // 0x18
	private int bufferSize; // 0x20
	private int bufferSizeAfterLimit; // 0x24
	private int bufferPos; // 0x28
	private Stream input; // 0x30
	private uint lastTag; // 0x38
	private uint nextTag; // 0x3C
	private bool hasNextTag; // 0x40
	internal const int DefaultRecursionLimit = 64; // Metadata: 0x00B0BDAE
	internal const int DefaultSizeLimit = 67108864; // Metadata: 0x00B0BDB2
	internal const int BufferSize = 4096; // Metadata: 0x00B0BDB6
	public int totalBytesRetired; // 0x44
	private int currentLimit; // 0x48
	private int recursionDepth; // 0x4C
	private readonly int recursionLimit; // 0x50
	private readonly int sizeLimit; // 0x54

	// Properties
	public long Position { /* [XID] */ /* 0x000000018988A080-0x000000018988A0A0 */ get => default; } // 0x0000000181EE8BF0-0x0000000181EE8CD0 
	internal uint LastTag { /* [XID] */ /* 0x0000000189891540-0x0000000189891560 */ get => default; } // 0x0000000181EE89F0-0x0000000181EE8A90 
	public int SizeLimit { /* [XID] */ /* 0x0000000189898D40-0x0000000189898D60 */ get => default; } // 0x0000000181EEB2D0-0x0000000181EEB370 
	public int RecursionLimit { /* [XID] */ /* 0x000000018989FDD0-0x000000018989FDF0 */ get => default; } // 0x0000000181EEA7B0-0x0000000181EEA850 
	internal bool ReachedLimit { /* [XID] */ /* 0x00000001899BC520-0x00000001899BC540 */ get => default; } // 0x0000000181EEA6F0-0x0000000181EEA7B0 
	public bool IsAtEnd { /* [XID] */ /* 0x00000001899C3E70-0x00000001899C3E90 */ get => default; } // 0x0000000181EEAC40-0x0000000181EEAD00 

	// Constructors
	public CodedInputStream() {} // 0x0000000181EEC260-0x0000000181EEC2E0
	public CodedInputStream(byte[] buffer) {} // 0x0000000181EEC1B0-0x0000000181EEC260
	public CodedInputStream(byte[] buffer, int offset, int length) {} // 0x0000000181EEBFA0-0x0000000181EEC0F0
	public CodedInputStream(Stream input) {} // 0x0000000181EEBF20-0x0000000181EEBFA0
	public CodedInputStream(Stream input, bool leaveOpen) {} // 0x0000000181EEBE40-0x0000000181EEBF20
	internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen) {} // 0x0000000181EEC0F0-0x0000000181EEC1B0
	internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen) {} // 0x0000000181EEBD10-0x0000000181EEBE40

	// Methods
	// [XID] // 0x000000018986E180-0x000000018986E1A0
	public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit) => default; // 0x0000000181EE8CD0-0x0000000181EE8E00
	// [IDTag] // 0x0000000189875630-0x0000000189875670
	// [XID] // 0x0000000189875630-0x0000000189875670
	public void ChangeInput(Stream input) {} // 0x0000000181EEB0F0-0x0000000181EEB1E0
	// [IDTag] // 0x000000018987FC30-0x000000018987FC70
	// [XID] // 0x000000018987FC30-0x000000018987FC70
	public void ChangeInput(byte[] buffer, int offset, int length) {} // 0x0000000181EEB1E0-0x0000000181EEB2D0
	// [XID] // 0x00000001898A7780-0x00000001898A77A0
	public void Dispose() {} // 0x0000000181EE8720-0x0000000181EE87D0
	// [XID] // 0x00000001898AF180-0x00000001898AF1A0
	public void CheckReadEndOfStreamTag() {} // 0x0000000181EE9880-0x0000000181EE9940
	// [XID] // 0x00000001898B6600-0x00000001898B6620
	public uint PeekTag() => default; // 0x0000000181EE91F0-0x0000000181EE92C0
	// [XID] // 0x00000001898BDE20-0x00000001898BDE40
	public uint ReadTag() => default; // 0x0000000181EE9E40-0x0000000181EE9FF0
	// [XID] // 0x00000001898C56E0-0x00000001898C5700
	public void SkipLastField() {} // 0x0000000181EEAD00-0x0000000181EEAEA0
	// [XID] // 0x00000001898CCD60-0x00000001898CCD80
	private void SkipGroup(uint startGroupTag) {} // 0x0000000181EEA960-0x0000000181EEAC40
	// [XID] // 0x00000001898D46F0-0x00000001898D4710
	public double ReadDouble() => default; // 0x0000000181EE9110-0x0000000181EE91F0
	// [XID] // 0x00000001898DC050-0x00000001898DC070
	public float ReadFloat() => default; // 0x0000000181EE92C0-0x0000000181EE9480
	// [XID] // 0x00000001898E3AC0-0x00000001898E3AE0
	public ulong ReadUInt64() => default; // 0x0000000181EE87D0-0x0000000181EE8880
	// [XID] // 0x00000001898EB640-0x00000001898EB660
	public long ReadInt64() => default; // 0x0000000181EE8E00-0x0000000181EE8EB0
	// [XID] // 0x00000001898F2EB0-0x00000001898F2ED0
	public int ReadInt32() => default; // 0x0000000181EE9C10-0x0000000181EE9CC0
	// [XID] // 0x00000001898FA570-0x00000001898FA590
	public ulong ReadFixed64() => default; // 0x0000000181EE8A90-0x0000000181EE8B40
	// [XID] // 0x0000000189901F80-0x0000000189901FA0
	public uint ReadFixed32() => default; // 0x0000000181EEAF90-0x0000000181EEB040
	// [XID] // 0x0000000189909790-0x00000001899097B0
	public bool ReadBool() => default; // 0x0000000181EE8EB0-0x0000000181EE8F60
	// [XID] // 0x0000000189910D70-0x0000000189910D90
	public string ReadString() => default; // 0x0000000181EEB4F0-0x0000000181EEB700
	// [XID] // 0x00000001899188E0-0x0000000189918900
	public void ReadMessage(IMessage builder) {} // 0x0000000181EEB700-0x0000000181EEB860
	// [XID] // 0x0000000189920080-0x00000001899200A0
	public ByteString ReadBytes() => default; // 0x0000000181EEA0B0-0x0000000181EEA200
	// [XID] // 0x00000001899278C0-0x00000001899278E0
	public uint ReadUInt32() => default; // 0x0000000181EE8880-0x0000000181EE8930
	// [XID] // 0x000000018992F070-0x000000018992F090
	public int ReadEnum() => default; // 0x0000000181EEB040-0x0000000181EEB0F0
	// [XID] // 0x00000001899364A0-0x00000001899364C0
	public int ReadSFixed32() => default; // 0x0000000181EE97D0-0x0000000181EE9880
	// [XID] // 0x000000018993DED0-0x000000018993DEF0
	public long ReadSFixed64() => default; // 0x0000000181EEB860-0x0000000181EEB910
	// [XID] // 0x0000000189945610-0x0000000189945630
	public int ReadSInt32() => default; // 0x0000000181EE85C0-0x0000000181EE8670
	// [XID] // 0x000000018994CAC0-0x000000018994CAE0
	public long ReadSInt64() => default; // 0x0000000181EE9B50-0x0000000181EE9C10
	// [XID] // 0x0000000189954140-0x0000000189954160
	public int ReadLength() => default; // 0x0000000181EE8B40-0x0000000181EE8BF0
	// [XID] // 0x000000018995BAB0-0x000000018995BAD0
	public bool MaybeConsumeTag(uint tag) => default; // 0x0000000181EE9480-0x0000000181EE9550
	// [XID] // 0x0000000189963680-0x00000001899636A0
	private uint SlowReadRawVarint32() => default; // 0x0000000181EE9CC0-0x0000000181EE9E40
	// [IDTag] // 0x000000018996AA30-0x000000018996AA70
	// [XID] // 0x000000018996AA30-0x000000018996AA70
	internal uint ReadRawVarint32() => default; // 0x0000000181EEBAA0-0x0000000181EEBD10
	// [IDTag] // 0x00000001899754A0-0x00000001899754E0
	// [XID] // 0x00000001899754A0-0x00000001899754E0
	internal static uint ReadRawVarint32(Stream input) => default; // 0x0000000181EEB910-0x0000000181EEBAA0
	// [XID] // 0x000000018997FA10-0x000000018997FA30
	internal ulong ReadRawVarint64() => default; // 0x0000000181EEA850-0x0000000181EEA960
	// [XID] // 0x0000000189987340-0x0000000189987360
	internal uint ReadRawLittleEndian32() => default; // 0x0000000181EE8F60-0x0000000181EE9050
	// [XID] // 0x000000018998EE50-0x000000018998EE70
	internal ulong ReadRawLittleEndian64() => default; // 0x0000000181EE9660-0x0000000181EE97D0
	// [XID] // 0x0000000189996A10-0x0000000189996A30
	internal static int DecodeZigZag32(uint n) => default; // 0x0000000181EE8670-0x0000000181EE8720
	// [XID] // 0x000000018999E4C0-0x000000018999E4E0
	internal static long DecodeZigZag64(ulong n) => default; // 0x0000000181EE9050-0x0000000181EE9110
	// [XID] // 0x00000001899A5EB0-0x00000001899A5ED0
	internal int PushLimit(int byteLimit) => default; // 0x0000000181EE9550-0x0000000181EE9660
	// [XID] // 0x00000001899AD550-0x00000001899AD570
	private void RecomputeBufferSizeAfterLimit() {} // 0x0000000181EE9FF0-0x0000000181EEA0B0
	// [XID] // 0x00000001899B4DD0-0x00000001899B4DF0
	internal void PopLimit(int oldLimit) {} // 0x0000000181EE8930-0x0000000181EE89F0
	// [XID] // 0x00000001899CB670-0x00000001899CB690
	private bool RefillBuffer(bool mustSucceed) => default; // 0x0000000181EE9940-0x0000000181EE9B50
	// [XID] // 0x00000001899D2A00-0x00000001899D2A20
	internal byte ReadRawByte() => default; // 0x0000000181EEAEA0-0x0000000181EEAF90
	// [XID] // 0x00000001899DA0F0-0x00000001899DA110
	internal byte[] ReadRawBytes(int size) => default; // 0x0000000181EEA200-0x0000000181EEA6F0
	// [XID] // 0x00000001899E1BB0-0x00000001899E1BD0
	private void SkipRawBytes(int size) {} // 0x0000000181EEB370-0x0000000181EEB4F0
	// [XID] // 0x00000001899E8F70-0x00000001899E8F90
	private void SkipImpl(int amountToSkip) {} // 0x0000000181EE8380-0x0000000181EE85C0
}

