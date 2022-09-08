/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FieldCodec<T> // TypeDefIndex: 26321
{
	// Fields
	private static readonly T DefaultDefault;
	private static readonly bool TypeSupportsPacking;
	internal readonly bool PackedRepeatedField;
	internal readonly Action<CodedOutputStream, T> ValueWriter;
	internal readonly Func<T, int> ValueSizeCalculator;
	internal readonly Func<CodedInputStream, T> ValueReader;
	internal readonly int FixedSize;
	internal readonly uint Tag;
	internal readonly T DefaultValue;
	private readonly int tagSize;

	// Constructors
	public FieldCodec() {} // Dummy constructor
	static FieldCodec() {}
	internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag) {}
	internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag) {}
	internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue) {}

	// Methods
	internal static bool IsPackedRepeatedField(uint tag) => default;
	public void WriteTagAndValue(CodedOutputStream output, T value) {}
	public T Read(CodedInputStream input) => default;
	public int CalculateSizeWithTag(T value) => default;
	private bool IsDefault(T value) => default;
}

