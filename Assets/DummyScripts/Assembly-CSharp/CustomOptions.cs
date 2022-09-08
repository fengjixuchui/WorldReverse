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

public sealed class CustomOptions // TypeDefIndex: 26352
{
	// Fields
	internal static readonly CustomOptions Empty; // 0x00
	private readonly Dictionary<int, List<FieldValue>> valuesByField; // 0x10

	// Nested types
	private struct FieldValue // TypeDefIndex: 26353
	{
		// Fields
		internal readonly ulong Number; // 0x00
		internal readonly ByteString ByteString; // 0x08

		// Constructors
		internal FieldValue(ulong number) {
			Number = default;
			ByteString = default;
		} // 0x0000000184D128D0-0x0000000184D12960
		internal FieldValue(ByteString byteString) {
			Number = default;
			ByteString = default;
		} // 0x0000000184D12860-0x0000000184D128D0
	}

	// Constructors
	private CustomOptions() {} // 0x0000000184D23070-0x0000000184D23100
	static CustomOptions() {} // 0x0000000184D22FF0-0x0000000184D23070

	// Methods
	// [XID] // 0x00000001899DE600-0x00000001899DE620
	public bool TryGetBool(int field, out bool value) {
		value = default;
		return default;
	} // 0x0000000184D21D40-0x0000000184D21E70
	// [XID] // 0x00000001899E6300-0x00000001899E6320
	public bool TryGetInt32(int field, out int value) {
		value = default;
		return default;
	} // 0x0000000184D22320-0x0000000184D22430
	// [XID] // 0x00000001899ED750-0x00000001899ED770
	public bool TryGetInt64(int field, out long value) {
		value = default;
		return default;
	} // 0x0000000184D22730-0x0000000184D22840
	// [XID] // 0x00000001899F5220-0x00000001899F5240
	public bool TryGetFixed32(int field, out uint value) {
		value = default;
		return default;
	} // 0x0000000184D22F20-0x0000000184D22FF0
	// [XID] // 0x00000001899FC830-0x00000001899FC850
	public bool TryGetFixed64(int field, out ulong value) {
		value = default;
		return default;
	} // 0x0000000184D22040-0x0000000184D22110
	// [XID] // 0x0000000189A03DF0-0x0000000189A03E10
	public bool TryGetSFixed32(int field, out int value) {
		value = default;
		return default;
	} // 0x0000000184D22110-0x0000000184D221E0
	// [XID] // 0x0000000189A0B3B0-0x0000000189A0B3D0
	public bool TryGetSFixed64(int field, out long value) {
		value = default;
		return default;
	} // 0x0000000184D22660-0x0000000184D22730
	// [XID] // 0x0000000189A12C40-0x0000000189A12C60
	public bool TryGetSInt32(int field, out int value) {
		value = default;
		return default;
	} // 0x0000000184D217B0-0x0000000184D218D0
	// [XID] // 0x0000000189A19FA0-0x0000000189A19FC0
	public bool TryGetSInt64(int field, out long value) {
		value = default;
		return default;
	} // 0x0000000184D22540-0x0000000184D22660
	// [XID] // 0x0000000189A21520-0x0000000189A21540
	public bool TryGetUInt32(int field, out uint value) {
		value = default;
		return default;
	} // 0x0000000184D21AE0-0x0000000184D21BF0
	// [XID] // 0x0000000189A28AA0-0x0000000189A28AC0
	public bool TryGetUInt64(int field, out ulong value) {
		value = default;
		return default;
	} // 0x0000000184D22430-0x0000000184D22540
	// [XID] // 0x0000000189A301E0-0x0000000189A30200
	public bool TryGetFloat(int field, out float value) {
		value = default;
		return default;
	} // 0x0000000184D22840-0x0000000184D22990
	// [XID] // 0x0000000189A37BC0-0x0000000189A37BE0
	public bool TryGetDouble(int field, out double value) {
		value = default;
		return default;
	} // 0x0000000184D221E0-0x0000000184D22320
	// [XID] // 0x0000000189A3F370-0x0000000189A3F390
	public bool TryGetString(int field, out string value) {
		value = default;
		return default;
	} // 0x0000000184D21BF0-0x0000000184D21D40
	// [XID] // 0x0000000189A468F0-0x0000000189A46910
	public bool TryGetBytes(int field, out ByteString value) {
		value = default;
		return default;
	} // 0x0000000184D22B60-0x0000000184D22C60
	public bool TryGetMessage<T>(int field, out T value)
		where T : class, IMessage, new() {
		value = default;
		return default;
	}
	// [XID] // 0x0000000189A4E120-0x0000000189A4E140
	private ulong? GetLastNumericValue(int field) => default; // 0x0000000184D218D0-0x0000000184D21AE0
	// [XID] // 0x0000000189A55990-0x0000000189A559B0
	private ByteString GetLastByteStringValue(int field) => default; // 0x0000000184D21E70-0x0000000184D22040
	// [XID] // 0x0000000189A5D1F0-0x0000000189A5D210
	internal CustomOptions ReadOrSkipUnknownField(CodedInputStream input) => default; // 0x0000000184D22C60-0x0000000184D22F20
	// [XID] // 0x0000000189A64AD0-0x0000000189A64AF0
	private CustomOptions AddValue(int field, FieldValue value) => default; // 0x0000000184D22990-0x0000000184D22B60
}

