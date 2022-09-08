/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CodedOutputStream : IDisposable // TypeDefIndex: 26299
{
	// Fields
	private const int LittleEndian64Size = 8; // Metadata: 0x00B0BDBF
	private const int LittleEndian32Size = 4; // Metadata: 0x00B0BDC3
	internal static readonly Encoding Utf8Encoding; // 0x00
	public static readonly int DefaultBufferSize; // 0x08
	private bool leaveOpen; // 0x10
	private byte[] buffer; // 0x18
	private int limit; // 0x20
	private int position; // 0x24
	private Stream output; // 0x28
	public static string PositionTraceStr; // 0x10

	// Properties
	public long Position { /* [XID] */ /* 0x0000000189AA9710-0x0000000189AA9730 */ get => default; } // 0x0000000182C7A390-0x0000000182C7A450 
	public int SpaceLeft { /* [XID] */ /* 0x0000000189726020-0x0000000189726040 */ get => default; } // 0x0000000182C79A60-0x0000000182C79B50 

	// Nested types
	public sealed class OutOfSpaceException : IOException // TypeDefIndex: 26300
	{
		// Constructors
		internal OutOfSpaceException() {} // 0x0000000182C91560-0x0000000182C915D0
	}

	// Constructors
	public CodedOutputStream() {} // 0x0000000182C7D520-0x0000000182C7D590
	public CodedOutputStream(byte[] flatArray) {} // 0x0000000182C7D3D0-0x0000000182C7D460
	private CodedOutputStream(byte[] buffer, int offset, int length) {} // 0x0000000182C7D640-0x0000000182C7D710
	private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen) {} // 0x0000000182C7D710-0x0000000182C7D800
	public CodedOutputStream(Stream output) {} // 0x0000000182C7D320-0x0000000182C7D3D0
	public CodedOutputStream(Stream output, int bufferSize) {} // 0x0000000182C7D800-0x0000000182C7D8B0
	public CodedOutputStream(Stream output, bool leaveOpen) {} // 0x0000000182C7D460-0x0000000182C7D520
	public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen) {} // 0x0000000182C7D590-0x0000000182C7D640
	static CodedOutputStream() {} // 0x0000000182C7D260-0x0000000182C7D320

	// Methods
	// [XID] // 0x00000001899F08C0-0x00000001899F08E0
	public static int ComputeDoubleSize(double value) => default; // 0x0000000182C79330-0x0000000182C793E0
	// [XID] // 0x00000001899F7FA0-0x00000001899F7FC0
	public static int ComputeFloatSize(float value) => default; // 0x0000000182C7CE60-0x0000000182C7CF10
	// [XID] // 0x00000001899FF5D0-0x00000001899FF5F0
	public static int ComputeUInt64Size(ulong value) => default; // 0x0000000182C78E80-0x0000000182C78F50
	// [XID] // 0x0000000189A06E50-0x0000000189A06E70
	public static int ComputeInt64Size(long value) => default; // 0x0000000182C7B9D0-0x0000000182C7BAA0
	// [XID] // 0x0000000189A0E520-0x0000000189A0E540
	public static int ComputeInt32Size(int value) => default; // 0x0000000182C7B350-0x0000000182C7B420
	// [XID] // 0x0000000189A15B70-0x0000000189A15B90
	public static int ComputeFixed64Size(ulong value) => default; // 0x0000000182C7A250-0x0000000182C7A2F0
	// [XID] // 0x0000000189A1CF80-0x0000000189A1CFA0
	public static int ComputeFixed32Size(uint value) => default; // 0x0000000182C7D1C0-0x0000000182C7D260
	// [XID] // 0x0000000189A245C0-0x0000000189A245E0
	public static int ComputeBoolSize(bool value) => default; // 0x0000000182C7A2F0-0x0000000182C7A390
	// [XID] // 0x0000000189A2BA40-0x0000000189A2BA60
	public static int ComputeStringSize(string value) => default; // 0x0000000182C7BDD0-0x0000000182C7BED0
	// [XID] // 0x0000000189A33000-0x0000000189A33020
	public static int ComputeGroupSize(IMessage value) => default; // 0x0000000182C790E0-0x0000000182C791A0
	// [XID] // 0x0000000189A3A910-0x0000000189A3A930
	public static int ComputeMessageSize(IMessage value) => default; // 0x0000000182C79770-0x0000000182C79860
	// [XID] // 0x0000000189A42260-0x0000000189A42280
	public static int ComputeBytesSize(ByteString value) => default; // 0x0000000182C795B0-0x0000000182C796B0
	// [XID] // 0x0000000189A49870-0x0000000189A49890
	public static int ComputeUInt32Size(uint value) => default; // 0x0000000182C78F50-0x0000000182C79010
	// [XID] // 0x0000000189A511C0-0x0000000189A511E0
	public static int ComputeEnumSize(int value) => default; // 0x0000000182C7AD00-0x0000000182C7ADC0
	// [XID] // 0x0000000189A58740-0x0000000189A58760
	public static int ComputeSFixed32Size(int value) => default; // 0x0000000182C7AC60-0x0000000182C7AD00
	// [XID] // 0x0000000189A602F0-0x0000000189A60310
	public static int ComputeSFixed64Size(long value) => default; // 0x0000000182C79860-0x0000000182C79900
	// [XID] // 0x0000000189A67E60-0x0000000189A67E80
	public static int ComputeSInt32Size(int value) => default; // 0x0000000182C79C00-0x0000000182C79CD0
	// [XID] // 0x0000000189A6F230-0x0000000189A6F250
	public static int ComputeSInt64Size(long value) => default; // 0x0000000182C7A450-0x0000000182C7A520
	// [XID] // 0x0000000189A76A90-0x0000000189A76AB0
	public static int ComputeLengthSize(int length) => default; // 0x0000000182C7CA70-0x0000000182C7CB30
	// [XID] // 0x0000000189A7E360-0x0000000189A7E380
	public static int ComputeRawVarint32Size(uint value) => default; // 0x0000000182C793E0-0x0000000182C794C0
	// [XID] // 0x0000000189A85CE0-0x0000000189A85D00
	public static int ComputeRawVarint64Size(ulong value) => default; // 0x0000000182C79900-0x0000000182C79A60
	// [XID] // 0x0000000189A8D600-0x0000000189A8D620
	public static int ComputeTagSize(int fieldNumber) => default; // 0x0000000182C79010-0x0000000182C790E0
	// [IDTag] // 0x0000000189A94BA0-0x0000000189A94BE0
	// [XID] // 0x0000000189A94BA0-0x0000000189A94BE0
	public void ChangeOutput(Stream output, bool leaveOpen = false /* Metadata: 0x00B0BDBA */) {} // 0x0000000182C79FD0-0x0000000182C7A130
	// [IDTag] // 0x0000000189A9F320-0x0000000189A9F360
	// [XID] // 0x0000000189A9F320-0x0000000189A9F360
	public void ChangeOutput(byte[] buffer, int offset, int length) {} // 0x0000000182C7A130-0x0000000182C7A250
	// [XID] // 0x0000000189AB1570-0x0000000189AB1590
	public void WriteDouble(double value) {} // 0x0000000182C7A6C0-0x0000000182C7A7A0
	// [XID] // 0x0000000189AB8900-0x0000000189AB8920
	public void WriteFloat(float value) {} // 0x0000000182C7B000-0x0000000182C7B350
	// [XID] // 0x0000000189AC0500-0x0000000189AC0520
	public void WriteUInt64(ulong value) {} // 0x0000000182C78DD0-0x0000000182C78E80
	// [XID] // 0x0000000189AC7EE0-0x0000000189AC7F00
	public void WriteInt64(long value) {} // 0x0000000182C7AF50-0x0000000182C7B000
	// [XID] // 0x0000000189ACF530-0x0000000189ACF550
	public void WriteInt32(int value) {} // 0x0000000182C7A520-0x0000000182C7A5E0
	// [XID] // 0x0000000189AD72B0-0x0000000189AD72D0
	public void WriteFixed64(ulong value) {} // 0x0000000182C7C130-0x0000000182C7C1E0
	// [XID] // 0x0000000189ADEE10-0x0000000189ADEE30
	public void WriteFixed32(uint value) {} // 0x0000000182C79CD0-0x0000000182C79D80
	// [XID] // 0x0000000189AE66A0-0x0000000189AE66C0
	public void WriteBool(bool value) {} // 0x0000000182C7CF10-0x0000000182C7CFE0
	// [XID] // 0x0000000189AEE030-0x0000000189AEE050
	public void WriteString(string value) {} // 0x0000000182C7CB30-0x0000000182C7CE60
	// [XID] // 0x0000000189AF5740-0x0000000189AF5760
	public void WriteMessage(IMessage value) {} // 0x0000000182C794C0-0x0000000182C795B0
	// [XID] // 0x0000000189AFCBF0-0x0000000189AFCC10
	public void WriteBytes(ByteString value) {} // 0x0000000182C7A7A0-0x0000000182C7A880
	// [XID] // 0x0000000189B04330-0x0000000189B04350
	public void WriteUInt32(uint value) {} // 0x0000000182C7C1E0-0x0000000182C7C290
	// [XID] // 0x0000000189B0BC10-0x0000000189B0BC30
	public void WriteEnum(int value) {} // 0x0000000182C79F20-0x0000000182C79FD0
	// [XID] // 0x0000000189B131A0-0x0000000189B131C0
	public void WriteSFixed32(int value) {} // 0x0000000182C79280-0x0000000182C79330
	// [XID] // 0x0000000189B1A910-0x0000000189B1A930
	public void WriteSFixed64(long value) {} // 0x0000000182C79B50-0x0000000182C79C00
	// [XID] // 0x0000000189B21F40-0x0000000189B21F60
	public void WriteSInt32(int value) {} // 0x0000000182C791A0-0x0000000182C79280
	// [XID] // 0x0000000189B294E0-0x0000000189B29500
	public void WriteSInt64(long value) {} // 0x0000000182C7A5E0-0x0000000182C7A6C0
	// [XID] // 0x0000000189B309D0-0x0000000189B309F0
	public void WriteLength(int length) {} // 0x0000000182C7B920-0x0000000182C7B9D0
	// [IDTag] // 0x0000000189B38130-0x0000000189B38170
	// [XID] // 0x0000000189B38130-0x0000000189B38170
	public void WriteTag(int fieldNumber, WireFormat.WireType type) {} // 0x0000000182C7ADC0-0x0000000182C7AEA0
	// [IDTag] // 0x0000000189B42A20-0x0000000189B42A60
	// [XID] // 0x0000000189B42A20-0x0000000189B42A60
	public void WriteTag(uint tag) {} // 0x0000000182C7AEA0-0x0000000182C7AF50
	// [IDTag] // 0x0000000189B4D230-0x0000000189B4D270
	// [XID] // 0x0000000189B4D230-0x0000000189B4D270
	public void WriteRawTag(byte b1) {} // 0x0000000182C7B660-0x0000000182C7B720
	// [IDTag] // 0x0000000189B57B20-0x0000000189B57B60
	// [XID] // 0x0000000189B57B20-0x0000000189B57B60
	public void WriteRawTag(byte b1, byte b2) {} // 0x0000000182C7B720-0x0000000182C7B800
	// [IDTag] // 0x0000000189B61F30-0x0000000189B61F70
	// [XID] // 0x0000000189B61F30-0x0000000189B61F70
	public void WriteRawTag(byte b1, byte b2, byte b3) {} // 0x0000000182C7B420-0x0000000182C7B520
	// [IDTag] // 0x0000000189B6C7F0-0x0000000189B6C830
	// [XID] // 0x0000000189B6C7F0-0x0000000189B6C830
	public void WriteRawTag(byte b1, byte b2, byte b3, byte b4) {} // 0x0000000182C7B800-0x0000000182C7B920
	// [IDTag] // 0x0000000189B76E70-0x0000000189B76EB0
	// [XID] // 0x0000000189B76E70-0x0000000189B76EB0
	public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x0000000182C7B520-0x0000000182C7B660
	// [XID] // 0x0000000189B81600-0x0000000189B81620
	internal void WriteRawVarint32(uint value) {} // 0x0000000182C7BF90-0x0000000182C7C130
	// [XID] // 0x0000000189B88D10-0x0000000189B88D30
	internal void WriteRawVarint64(ulong value) {} // 0x0000000182C7C900-0x0000000182C7CA70
	// [XID] // 0x0000000189B90220-0x0000000189B90240
	internal void WriteRawLittleEndian32(uint value) {} // 0x0000000182C7CFE0-0x0000000182C7D1C0
	// [XID] // 0x0000000189B976A0-0x0000000189B976C0
	internal void WriteRawLittleEndian64(ulong value) {} // 0x0000000182C78AB0-0x0000000182C78DD0
	// [IDTag] // 0x0000000189B9EB40-0x0000000189B9EB80
	// [XID] // 0x0000000189B9EB40-0x0000000189B9EB80
	internal void WriteRawByte(byte value) {} // 0x0000000182C79E30-0x0000000182C79F20
	// [IDTag] // 0x0000000189BA9110-0x0000000189BA9150
	// [XID] // 0x0000000189BA9110-0x0000000189BA9150
	internal void WriteRawByte(uint value) {} // 0x0000000182C79D80-0x0000000182C79E30
	// [IDTag] // 0x0000000189BB36C0-0x0000000189BB3700
	// [XID] // 0x0000000189BB36C0-0x0000000189BB3700
	internal void WriteRawBytes(byte[] value, int length) {} // 0x0000000182C7AB80-0x0000000182C7AC60
	// [IDTag] // 0x0000000189BBDC00-0x0000000189BBDC40
	// [XID] // 0x0000000189BBDC00-0x0000000189BBDC40
	internal void WriteRawBytes(byte[] value, int offset, int length) {} // 0x0000000182C7A9E0-0x0000000182C7AB80
	// [XID] // 0x0000000189BC8910-0x0000000189BC8930
	internal static uint EncodeZigZag32(int n) => default; // 0x0000000182C7A880-0x0000000182C7A930
	// [XID] // 0x0000000189BD0130-0x0000000189BD0150
	internal static ulong EncodeZigZag64(long n) => default; // 0x0000000182C7BED0-0x0000000182C7BF90
	// [XID] // 0x0000000189BD7770-0x0000000189BD7790
	private void RefreshBuffer() {} // 0x0000000182C7BAA0-0x0000000182C7BDD0
	// [XID] // 0x0000000189BDF2B0-0x0000000189BDF2D0
	public void Dispose() {} // 0x0000000182C796B0-0x0000000182C79770
	// [XID] // 0x00000001895EBEC0-0x00000001895EBEE0
	public void Flush() {} // 0x0000000182C7A930-0x0000000182C7A9E0
	// [XID] // 0x000000018971E8E0-0x000000018971E900
	public void CheckNoSpaceLeft(int line = 0 /* Metadata: 0x00B0BDBB */, System.Type type = null) {} // 0x0000000182C7C290-0x0000000182C7C900
}

