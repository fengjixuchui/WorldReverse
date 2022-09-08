/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class FieldCodec // TypeDefIndex: 26315
{
	// Nested types
	private static class WrapperCodecs // TypeDefIndex: 26316
	{
		// Fields
		private static readonly Dictionary<System.Type, object> Codecs; // 0x00

		// Constructors
		static WrapperCodecs() {} // 0x00000001830177D0-0x0000000183017B10

		// Methods
		internal static FieldCodec<T> GetCodec<T>() => default;
		internal static T Read<T>(CodedInputStream input, FieldCodec<T> codec) => default;
		internal static void Write<T>(CodedOutputStream output, T value, FieldCodec<T> codec) {}
		internal static int CalculateSize<T>(T value, FieldCodec<T> codec) => default;
	}

	// Methods
	// [XID] // 0x0000000189857F80-0x0000000189857FA0
	public static FieldCodec<string> ForString(uint tag) => default; // 0x0000000183010FA0-0x0000000183011190
	// [XID] // 0x000000018985F070-0x000000018985F090
	public static FieldCodec<ByteString> ForBytes(uint tag) => default; // 0x0000000183010AF0-0x0000000183010CF0
	// [XID] // 0x0000000189866860-0x0000000189866880
	public static FieldCodec<bool> ForBool(uint tag) => default; // 0x000000018300EE30-0x000000018300F030
	// [XID] // 0x000000018986E160-0x000000018986E180
	public static FieldCodec<int> ForInt32(uint tag) => default; // 0x000000018300E620-0x000000018300E820
	// [XID] // 0x0000000189875610-0x0000000189875630
	public static FieldCodec<int> ForSInt32(uint tag) => default; // 0x000000018300FF90-0x0000000183010190
	// [XID] // 0x000000018987D160-0x000000018987D180
	public static FieldCodec<uint> ForFixed32(uint tag) => default; // 0x0000000183010CF0-0x0000000183010EA0
	// [XID] // 0x0000000189884100-0x0000000189884120
	public static FieldCodec<int> ForSFixed32(uint tag) => default; // 0x00000001830106A0-0x0000000183010860
	// [XID] // 0x000000018988B820-0x000000018988B840
	public static FieldCodec<uint> ForUInt32(uint tag) => default; // 0x000000018300F6B0-0x000000018300F8C0
	// [XID] // 0x0000000189892F20-0x0000000189892F40
	public static FieldCodec<long> ForInt64(uint tag) => default; // 0x000000018300E8A0-0x000000018300EAB0
	// [XID] // 0x000000018989A5B0-0x000000018989A5D0
	public static FieldCodec<long> ForSInt64(uint tag) => default; // 0x000000018300F8C0-0x000000018300FAD0
	// [XID] // 0x00000001898A1890-0x00000001898A18B0
	public static FieldCodec<ulong> ForFixed64(uint tag) => default; // 0x0000000183010300-0x00000001830104C0
	// [XID] // 0x00000001898A9040-0x00000001898A9060
	public static FieldCodec<long> ForSFixed64(uint tag) => default; // 0x000000018300FCD0-0x000000018300FE90
	// [XID] // 0x00000001898B09D0-0x00000001898B09F0
	public static FieldCodec<ulong> ForUInt64(uint tag) => default; // 0x000000018300EB30-0x000000018300ED40
	// [XID] // 0x00000001898B8090-0x00000001898B80B0
	public static FieldCodec<float> ForFloat(uint tag) => default; // 0x0000000183010860-0x0000000183010A70
	// [XID] // 0x00000001898BF760-0x00000001898BF780
	public static FieldCodec<double> ForDouble(uint tag) => default; // 0x000000018300F0B0-0x000000018300F2C0
	public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32) => default;
	public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser)
		where T : MessageBase, IMessage<T> => default;
	public static FieldCodec<T> ForClassWrapper<T>(uint tag)
		where T : class => default;
	public static FieldCodec<T?> ForStructWrapper<T>(uint tag)
		where T : struct => default;
}

