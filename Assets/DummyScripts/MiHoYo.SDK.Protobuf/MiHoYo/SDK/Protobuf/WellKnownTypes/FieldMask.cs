/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.WellKnownTypes
{
	public sealed class FieldMask : MiHoYo.SDK.Protobuf.IMessage<FieldMask>, MiHoYo.SDK.Protobuf.ICustomDiagnosticMessage // TypeDefIndex: 5103
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<FieldMask> _parser; // 0x00
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<string> _repeated_paths_codec; // 0x08
		private readonly RepeatedField<string> paths_; // 0x10
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<FieldMask> Parser { get => default; } // 0x0000000187D5A600-0x0000000187D5A690 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get => default; } // 0x0000000187D5A4E0-0x0000000187D5A600 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D5A6F0-0x0000000187D5A770 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<string> Paths { get => default; } // 0x0000000187D5A690-0x0000000187D5A6F0 
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldMask() {} // 0x0000000187D5A3B0-0x0000000187D5A440
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldMask(FieldMask other) {} // 0x0000000187D5A440-0x0000000187D5A4E0
		static FieldMask() {} // 0x0000000187D5A290-0x0000000187D5A3B0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldMask Clone() => default; // 0x0000000187D598C0-0x0000000187D59940
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D599E0-0x0000000187D59A70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(FieldMask other) => default; // 0x0000000187D59940-0x0000000187D599E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D59A70-0x0000000187D59AF0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D5A030-0x0000000187D5A0C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D5A1D0-0x0000000187D5A290
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D59810-0x0000000187D598C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D59AF0-0x0000000187D59BF0
		internal static string ToJson(IList<string> paths, bool diagnosticOnly) => default; // 0x0000000187D59CC0-0x0000000187D5A030
		private static bool ValidatePath(string input) => default; // 0x0000000187D5A0C0-0x0000000187D5A1D0
		public string ToDiagnosticString() => default; // 0x0000000187D59BF0-0x0000000187D59CC0
	}
}
