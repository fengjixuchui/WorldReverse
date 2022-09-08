/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	internal sealed class FileOptions : MiHoYo.SDK.Protobuf.IMessage<FileOptions> // TypeDefIndex: 5144
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<FileOptions> _parser; // 0x00
		private string javaPackage_; // 0x10
		private string javaOuterClassname_; // 0x18
		private bool javaMultipleFiles_; // 0x20
		private bool javaGenerateEqualsAndHash_; // 0x21
		private bool javaStringCheckUtf8_; // 0x22
		private Types.OptimizeMode optimizeFor_; // 0x24
		private string goPackage_; // 0x28
		private bool ccGenericServices_; // 0x30
		private bool javaGenericServices_; // 0x31
		private bool pyGenericServices_; // 0x32
		private bool deprecated_; // 0x33
		private bool ccEnableArenas_; // 0x34
		private string objcClassPrefix_; // 0x38
		private string csharpNamespace_; // 0x40
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x48
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<FileOptions> Parser { get => default; } // 0x0000000186509590-0x0000000186509620 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001865090E0-0x0000000186509230 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000186509680-0x0000000186509700 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string JavaPackage { get => default; set {} } // 0x0000000186509410-0x0000000186509470 0x0000000186509AC0-0x0000000186509B40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string JavaOuterClassname { get => default; set {} } // 0x00000001865093B0-0x0000000186509410 0x0000000186509A40-0x0000000186509AC0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool JavaMultipleFiles { get => default; set {} } // 0x0000000186509350-0x00000001865093B0 0x00000001865099E0-0x0000000186509A40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool JavaGenerateEqualsAndHash { get => default; set {} } // 0x0000000186509290-0x00000001865092F0 0x0000000186509920-0x0000000186509980
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool JavaStringCheckUtf8 { get => default; set {} } // 0x0000000186509470-0x00000001865094D0 0x0000000186509B40-0x0000000186509BA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Types.OptimizeMode OptimizeFor { get => default; } // 0x0000000186509530-0x0000000186509590 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string GoPackage { get => default; set {} } // 0x0000000186509230-0x0000000186509290 0x00000001865098A0-0x0000000186509920
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool CcGenericServices { get => default; set {} } // 0x0000000186508FC0-0x0000000186509020 0x0000000186509760-0x00000001865097C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool JavaGenericServices { get => default; set {} } // 0x00000001865092F0-0x0000000186509350 0x0000000186509980-0x00000001865099E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool PyGenericServices { get => default; set {} } // 0x0000000186509620-0x0000000186509680 0x0000000186509C20-0x0000000186509C80
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x0000000186509080-0x00000001865090E0 0x0000000186509840-0x00000001865098A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool CcEnableArenas { get => default; set {} } // 0x0000000186508F60-0x0000000186508FC0 0x0000000186509700-0x0000000186509760
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string ObjcClassPrefix { get => default; set {} } // 0x00000001865094D0-0x0000000186509530 0x0000000186509BA0-0x0000000186509C20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string CsharpNamespace { get => default; set {} } // 0x0000000186509020-0x0000000186509080 0x00000001865097C0-0x0000000186509840
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5145
		{
			// Nested types
			internal enum OptimizeMode // TypeDefIndex: 5146
			{
				Speed = 1,
				CodeSize = 2,
				LiteRuntime = 3
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileOptions() {} // 0x0000000186508E90-0x0000000186508F60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileOptions(FileOptions other) {} // 0x0000000186508D80-0x0000000186508E90
		static FileOptions() {} // 0x0000000186508C30-0x0000000186508D80
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileOptions Clone() => default; // 0x0000000186506EF0-0x0000000186506F70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000186507350-0x00000001865073E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(FileOptions other) => default; // 0x0000000186506F70-0x0000000186507350
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001865073E0-0x0000000186507D00
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000186508040-0x00000001865080D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001865080D0-0x0000000186508C30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x00000001865067A0-0x0000000186506EF0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000186507D00-0x0000000186508040
	}
}
