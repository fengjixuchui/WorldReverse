/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public sealed class FieldCodec<T> // TypeDefIndex: 5078
	{
		// Fields
		private static readonly T DefaultDefault;
		private static readonly bool TypeSupportsPacking;
		private readonly int tagSize;
	
		// Properties
		internal bool PackedRepeatedField { get; }
		internal Action<CodedOutputStream, T> ValueWriter { get; }
		internal Func<T, int> ValueSizeCalculator { get; }
		internal Func<CodedInputStream, T> ValueReader { get; }
		internal int FixedSize { get; }
		internal uint Tag { get; }
		internal T DefaultValue { get; }
	
		// Constructors
		public FieldCodec() {} // Dummy constructor
		static FieldCodec() {}
		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag) {}
		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue) {}
	
		// Methods
		internal static bool IsPackedRepeatedField(uint tag) => default;
		public void WriteTagAndValue(CodedOutputStream output, T value) {}
		public T Read(CodedInputStream input) => default;
		public int CalculateSizeWithTag(T value) => default;
		private bool IsDefault(T value) => default;
	}
}
