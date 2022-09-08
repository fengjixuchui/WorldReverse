/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack.Decoders;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack
{
	public static class MessagePackBinary // TypeDefIndex: 8283
	{
		// Fields
		private const int MaxSize = 256; // Metadata: 0x00ADF6D8
		private static readonly IMapHeaderDecoder[] mapHeaderDecoders; // 0x00
		private static readonly IArrayHeaderDecoder[] arrayHeaderDecoders; // 0x08
		private static readonly IBooleanDecoder[] booleanDecoders; // 0x10
		private static readonly IByteDecoder[] byteDecoders; // 0x18
		private static readonly IBytesDecoder[] bytesDecoders; // 0x20
		private static readonly ISByteDecoder[] sbyteDecoders; // 0x28
		private static readonly ISingleDecoder[] singleDecoders; // 0x30
		private static readonly IDoubleDecoder[] doubleDecoders; // 0x38
		private static readonly IInt16Decoder[] int16Decoders; // 0x40
		private static readonly IInt32Decoder[] int32Decoders; // 0x48
		private static readonly IInt64Decoder[] int64Decoders; // 0x50
		private static readonly IUInt16Decoder[] uint16Decoders; // 0x58
		private static readonly IUInt32Decoder[] uint32Decoders; // 0x60
		private static readonly IUInt64Decoder[] uint64Decoders; // 0x68
		private static readonly IStringDecoder[] stringDecoders; // 0x70
		private static readonly IExtDecoder[] extDecoders; // 0x78
		private static readonly IExtHeaderDecoder[] extHeaderDecoders; // 0x80
		private static readonly IDateTimeDecoder[] dateTimeDecoders; // 0x88
		private static readonly IReadNextDecoder[] readNextDecoders; // 0x90
	
		// Constructors
		static MessagePackBinary() {} // 0x00000001856E10E0-0x00000001856E5AA0
	
		// Methods
		// [XID] // 0x00000001899764B0-0x00000001899764D0
		public static void EnsureCapacity(ref byte[] bytes, int offset, int appendLength) {} // 0x00000001856D59C0-0x00000001856D5B40
		// [XID] // 0x000000018999B2A0-0x000000018999B2C0
		public static void FastResize(ref byte[] array, int newSize) {} // 0x00000001856D5C80-0x00000001856D5E10
		// [XID] // 0x0000000189985390-0x00000001899853B0
		public static byte[] FastCloneWithResize(byte[] array, int newSize) => default; // 0x00000001856D5B40-0x00000001856D5C80
		// [XID] // 0x000000018998CE60-0x000000018998CE80
		public static MessagePackType GetMessagePackType(byte[] bytes, int offset) => default; // 0x00000001856D5ED0-0x00000001856D5FD0
		// [XID] // 0x0000000189994BA0-0x0000000189994BC0
		public static int ReadNext(byte[] bytes, int offset) => default; // 0x00000001856D7A00-0x00000001856D7B50
		// [XID] // 0x0000000189797FF0-0x0000000189798010
		public static int ReadNextBlock(byte[] bytes, int offset) => default; // 0x00000001856D7780-0x00000001856D7A00
		// [XID] // 0x00000001899A3D00-0x00000001899A3D20
		public static int WriteNil(ref byte[] bytes, int offset) => default; // 0x00000001856DE2D0-0x00000001856DE3F0
		// [XID] // 0x00000001899AB950-0x00000001899AB970
		public static Nil ReadNil(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7B50-0x00000001856D7D70
		// [XID] // 0x00000001899B31F0-0x00000001899B3210
		public static bool IsNil(byte[] bytes, int offset) => default; // 0x00000001856D5FD0-0x00000001856D60B0
		// [XID] // 0x0000000189640F60-0x0000000189640F80
		public static int WriteFixedMapHeaderUnsafe(ref byte[] bytes, int offset, int count) => default; // 0x00000001856DBE70-0x00000001856DBFA0
		// [IDTag] // 0x00000001899C1FB0-0x00000001899C1FF0
		// [XID] // 0x00000001899C1FB0-0x00000001899C1FF0
		public static int WriteMapHeader(ref byte[] bytes, int offset, int count) => default; // 0x00000001856DE1A0-0x00000001856DE2D0
		// [IDTag] // 0x00000001899CC510-0x00000001899CC550
		// [XID] // 0x00000001899CC510-0x00000001899CC550
		public static int WriteMapHeader(ref byte[] bytes, int offset, uint count) => default; // 0x00000001856DDE60-0x00000001856DE1A0
		// [XID] // 0x0000000189B8B790-0x0000000189B8B7B0
		public static int ReadMapHeader(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D75E0-0x00000001856D7780
		// [XID] // 0x00000001896B7510-0x00000001896B7530
		public static uint ReadMapHeaderRaw(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7470-0x00000001856D75E0
		// [XID] // 0x00000001896BE660-0x00000001896BE680
		public static int GetArrayHeaderLength(int count) => default; // 0x00000001856D5E10-0x00000001856D5ED0
		// [XID] // 0x00000001899ED020-0x00000001899ED040
		public static int WriteFixedArrayHeaderUnsafe(ref byte[] bytes, int offset, int count) => default; // 0x00000001856DBD40-0x00000001856DBE70
		// [IDTag] // 0x00000001899F4D20-0x00000001899F4D60
		// [XID] // 0x00000001899F4D20-0x00000001899F4D60
		public static int WriteArrayHeader(ref byte[] bytes, int offset, int count) => default; // 0x00000001856D8610-0x00000001856D8740
		// [IDTag] // 0x00000001899FF010-0x00000001899FF050
		// [XID] // 0x00000001899FF010-0x00000001899FF050
		public static int WriteArrayHeader(ref byte[] bytes, int offset, uint count) => default; // 0x00000001856D8740-0x00000001856D8A80
		// [XID] // 0x0000000189A09600-0x0000000189A09620
		public static int ReadArrayHeader(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6220-0x00000001856D63C0
		// [XID] // 0x0000000189A10C70-0x0000000189A10C90
		public static uint ReadArrayHeaderRaw(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D60B0-0x00000001856D6220
		// [XID] // 0x000000018974D8D0-0x000000018974D8F0
		public static int WriteBoolean(ref byte[] bytes, int offset, bool value) => default; // 0x00000001856D8A80-0x00000001856D8BC0
		// [XID] // 0x00000001897EBA20-0x00000001897EBA40
		public static bool ReadBoolean(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D63C0-0x00000001856D6520
		// [XID] // 0x0000000189AC7F30-0x0000000189AC7F50
		public static int WriteByte(ref byte[] bytes, int offset, byte value) => default; // 0x00000001856D8D20-0x00000001856D8EF0
		// [XID] // 0x0000000189A2E410-0x0000000189A2E430
		public static int WriteByteForceByteBlock(ref byte[] bytes, int offset, byte value) => default; // 0x00000001856D8BC0-0x00000001856D8D20
		// [XID] // 0x0000000189A35C80-0x0000000189A35CA0
		public static byte ReadByte(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6520-0x00000001856D6690
		// [IDTag] // 0x0000000189A3D270-0x0000000189A3D2B0
		// [XID] // 0x0000000189A3D270-0x0000000189A3D2B0
		public static int WriteBytes(ref byte[] bytes, int offset, byte[] value) => default; // 0x00000001856D8EF0-0x00000001856D9020
		// [IDTag] // 0x0000000189A47A30-0x0000000189A47A70
		// [XID] // 0x0000000189A47A30-0x0000000189A47A70
		public static int WriteBytes(ref byte[] dest, int dstOffset, byte[] src, int srcOffset, int count) => default; // 0x00000001856D9020-0x00000001856D9450
		// [XID] // 0x0000000189A51FC0-0x0000000189A51FE0
		public static byte[] ReadBytes(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6690-0x00000001856D6800
		// [XID] // 0x0000000189A3D9C0-0x0000000189A3D9E0
		public static int WriteSByte(ref byte[] bytes, int offset, sbyte value) => default; // 0x00000001856DE680-0x00000001856DE850
		// [XID] // 0x0000000189A61150-0x0000000189A61170
		public static int WriteSByteForceSByteBlock(ref byte[] bytes, int offset, sbyte value) => default; // 0x00000001856DE520-0x00000001856DE680
		// [XID] // 0x0000000189A690A0-0x0000000189A690C0
		public static sbyte ReadSByte(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7D70-0x00000001856D7EE0
		// [XID] // 0x0000000189A66800-0x0000000189A66820
		public static int WriteSingle(ref byte[] bytes, int offset, float value) => default; // 0x00000001856DE850-0x00000001856DEBA0
		// [XID] // 0x0000000189A77C60-0x0000000189A77C80
		public static float ReadSingle(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7EE0-0x00000001856D8050
		// [XID] // 0x0000000189B5F430-0x0000000189B5F450
		public static int WriteDouble(ref byte[] bytes, int offset, double value) => default; // 0x00000001856D9DF0-0x00000001856DA2F0
		// [XID] // 0x0000000189858160-0x0000000189858180
		public static double ReadDouble(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6B20-0x00000001856D6C90
		// [XID] // 0x00000001896118C0-0x00000001896118E0
		public static int WriteInt16(ref byte[] bytes, int offset, short value) => default; // 0x00000001856DC320-0x00000001856DC790
		// [XID] // 0x0000000189A95CF0-0x0000000189A95D10
		public static int WriteInt16ForceInt16Block(ref byte[] bytes, int offset, short value) => default; // 0x00000001856DC180-0x00000001856DC320
		// [XID] // 0x0000000189A9D400-0x0000000189A9D420
		public static short ReadInt16(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7020-0x00000001856D7190
		// [XID] // 0x0000000189AA4C90-0x0000000189AA4CB0
		public static int WritePositiveFixedIntUnsafe(ref byte[] bytes, int offset, int value) => default; // 0x00000001856DE3F0-0x00000001856DE520
		// [XID] // 0x00000001898006D0-0x00000001898006F0
		public static int WriteInt32(ref byte[] bytes, int offset, int value) => default; // 0x00000001856DC990-0x00000001856DD050
		// [XID] // 0x00000001896A0130-0x00000001896A0150
		public static int WriteInt32ForceInt32Block(ref byte[] bytes, int offset, int value) => default; // 0x00000001856DC790-0x00000001856DC990
		// [XID] // 0x0000000189ABB890-0x0000000189ABB8B0
		public static int ReadInt32(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7190-0x00000001856D7300
		// [XID] // 0x0000000189AC3030-0x0000000189AC3050
		public static int WriteInt64(ref byte[] bytes, int offset, long value) => default; // 0x00000001856DD340-0x00000001856DDE60
		// [XID] // 0x0000000189ACA750-0x0000000189ACA770
		public static int WriteInt64ForceInt64Block(ref byte[] bytes, int offset, long value) => default; // 0x00000001856DD050-0x00000001856DD340
		// [XID] // 0x0000000189AD2230-0x0000000189AD2250
		public static long ReadInt64(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D7300-0x00000001856D7470
		// [XID] // 0x0000000189AD9BA0-0x0000000189AD9BC0
		public static int WriteUInt16(ref byte[] bytes, int offset, ushort value) => default; // 0x00000001856DFF80-0x00000001856E0220
		// [XID] // 0x0000000189626200-0x0000000189626220
		public static int WriteUInt16ForceUInt16Block(ref byte[] bytes, int offset, ushort value) => default; // 0x00000001856DFDE0-0x00000001856DFF80
		// [XID] // 0x00000001897BE530-0x00000001897BE550
		public static ushort ReadUInt16(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D81C0-0x00000001856D8330
		// [XID] // 0x0000000189B21A10-0x0000000189B21A30
		public static int WriteUInt32(ref byte[] bytes, int offset, uint value) => default; // 0x00000001856E0420-0x00000001856E07F0
		// [XID] // 0x0000000189AF8090-0x0000000189AF80B0
		public static int WriteUInt32ForceUInt32Block(ref byte[] bytes, int offset, uint value) => default; // 0x00000001856E0220-0x00000001856E0420
		// [XID] // 0x0000000189AFF6B0-0x0000000189AFF6D0
		public static uint ReadUInt32(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D8330-0x00000001856D84A0
		// [XID] // 0x00000001899095B0-0x00000001899095D0
		public static int WriteUInt64(ref byte[] bytes, int offset, ulong value) => default; // 0x00000001856E0AE0-0x00000001856E10E0
		// [XID] // 0x0000000189B0E610-0x0000000189B0E630
		public static int WriteUInt64ForceUInt64Block(ref byte[] bytes, int offset, ulong value) => default; // 0x00000001856E07F0-0x00000001856E0AE0
		// [XID] // 0x0000000189B157D0-0x0000000189B157F0
		public static ulong ReadUInt64(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D84A0-0x00000001856D8610
		// [XID] // 0x000000018990DFA0-0x000000018990DFC0
		public static int WriteChar(ref byte[] bytes, int offset, char value) => default; // 0x00000001856D9450-0x00000001856D9550
		// [XID] // 0x0000000189B247B0-0x0000000189B247D0
		public static char ReadChar(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6800-0x00000001856D6900
		// [XID] // 0x0000000189B2BC80-0x0000000189B2BCA0
		public static int WriteFixedStringUnsafe(ref byte[] bytes, int offset, string value, int byteCount) => default; // 0x00000001856DBFA0-0x00000001856DC180
		// [XID] // 0x0000000189699E20-0x0000000189699E40
		public static int WriteStringUnsafe(ref byte[] bytes, int offset, string value, int byteCount) => default; // 0x00000001856DF2D0-0x00000001856DF890
		// [XID] // 0x0000000189B3ACD0-0x0000000189B3ACF0
		public static int WriteStringBytes(ref byte[] bytes, int offset, byte[] utf8stringBytes) => default; // 0x00000001856DEBA0-0x00000001856DEFC0
		// [XID] // 0x00000001898B4F80-0x00000001898B4FA0
		public static int WriteString(ref byte[] bytes, int offset, string value) => default; // 0x00000001856DF890-0x00000001856DFDE0
		// [XID] // 0x0000000189B49EC0-0x0000000189B49EE0
		public static int WriteStringForceStr32Block(ref byte[] bytes, int offset, string value) => default; // 0x00000001856DEFC0-0x00000001856DF2D0
		// [XID] // 0x000000018966E4A0-0x000000018966E4C0
		public static string ReadString(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D8050-0x00000001856D81C0
		// [XID] // 0x000000018980EE80-0x000000018980EEA0
		public static int WriteExtensionFormatHeader(ref byte[] bytes, int offset, sbyte typeCode, int dataLength) => default; // 0x00000001856DA540-0x00000001856DAC70
		// [XID] // 0x0000000189816530-0x0000000189816550
		public static int WriteExtensionFormatHeaderForceExt32Block(ref byte[] bytes, int offset, sbyte typeCode, int dataLength) => default; // 0x00000001856DA2F0-0x00000001856DA540
		// [XID] // 0x0000000189B67E10-0x0000000189B67E30
		public static int WriteExtensionFormat(ref byte[] bytes, int offset, sbyte typeCode, byte[] data) => default; // 0x00000001856DAC70-0x00000001856DBD40
		// [XID] // 0x0000000189B6F100-0x0000000189B6F120
		public static ExtensionResult ReadExtensionFormat(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6E00-0x00000001856D7020
		// [XID] // 0x00000001898590D0-0x00000001898590F0
		public static ExtensionHeader ReadExtensionFormatHeader(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6C90-0x00000001856D6E00
		// [XID] // 0x0000000189AA9610-0x0000000189AA9630
		public static int WriteDateTime(ref byte[] bytes, int offset, DateTime dateTime) => default; // 0x00000001856D9550-0x00000001856D9DF0
		// [XID] // 0x0000000189691600-0x0000000189691620
		public static DateTime ReadDateTime(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D6900-0x00000001856D6B20
	}
}
