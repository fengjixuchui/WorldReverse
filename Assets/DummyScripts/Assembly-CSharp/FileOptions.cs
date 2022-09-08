/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class FileOptions : MessageBase, IMessage<FileOptions> // TypeDefIndex: 26371
{
	// Fields
	private static readonly MessageParser<FileOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int JavaPackageFieldNumber = 1; // Metadata: 0x00B0BFED
	private string javaPackage_; // 0x20
	public const int JavaOuterClassnameFieldNumber = 8; // Metadata: 0x00B0BFF1
	private string javaOuterClassname_; // 0x28
	public const int JavaMultipleFilesFieldNumber = 10; // Metadata: 0x00B0BFF5
	private bool javaMultipleFiles_; // 0x30
	public const int JavaGenerateEqualsAndHashFieldNumber = 20; // Metadata: 0x00B0BFF9
	private bool javaGenerateEqualsAndHash_; // 0x31
	public const int JavaStringCheckUtf8FieldNumber = 27; // Metadata: 0x00B0BFFD
	private bool javaStringCheckUtf8_; // 0x32
	public const int OptimizeForFieldNumber = 9; // Metadata: 0x00B0C001
	private Types.OptimizeMode optimizeFor_; // 0x34
	public const int GoPackageFieldNumber = 11; // Metadata: 0x00B0C005
	private string goPackage_; // 0x38
	public const int CcGenericServicesFieldNumber = 16; // Metadata: 0x00B0C009
	private bool ccGenericServices_; // 0x40
	public const int JavaGenericServicesFieldNumber = 17; // Metadata: 0x00B0C00D
	private bool javaGenericServices_; // 0x41
	public const int PyGenericServicesFieldNumber = 18; // Metadata: 0x00B0C011
	private bool pyGenericServices_; // 0x42
	public const int PhpGenericServicesFieldNumber = 42; // Metadata: 0x00B0C015
	private bool phpGenericServices_; // 0x43
	public const int DeprecatedFieldNumber = 23; // Metadata: 0x00B0C019
	private bool deprecated_; // 0x44
	public const int CcEnableArenasFieldNumber = 31; // Metadata: 0x00B0C01D
	private bool ccEnableArenas_; // 0x45
	public const int ObjcClassPrefixFieldNumber = 36; // Metadata: 0x00B0C021
	private string objcClassPrefix_; // 0x48
	public const int CsharpNamespaceFieldNumber = 37; // Metadata: 0x00B0C025
	private string csharpNamespace_; // 0x50
	public const int SwiftPrefixFieldNumber = 39; // Metadata: 0x00B0C029
	private string swiftPrefix_; // 0x58
	public const int PhpClassPrefixFieldNumber = 40; // Metadata: 0x00B0C02D
	private string phpClassPrefix_; // 0x60
	public const int PhpNamespaceFieldNumber = 41; // Metadata: 0x00B0C031
	private string phpNamespace_; // 0x68
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C035
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x70

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FileOptions> Parser { /* [XID] */ /* 0x0000000189BBF220-0x0000000189BBF240 */ get => default; } // 0x00000001824F1670-0x00000001824F1740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BC6EF0-0x0000000189BC6F10 */ get => default; } // 0x00000001824F0AD0-0x00000001824F0BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BCEB60-0x0000000189BCEB80 */ get => default; } // 0x00000001824F00A0-0x00000001824F0170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BD5EA0-0x0000000189BD5EC0 */ get => default; } // 0x00000001824EDB60-0x00000001824EDC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BDDAF0-0x0000000189BDDB10 */ get => default; } // 0x00000001824F26A0-0x00000001824F27A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001895EA650-0x00000001895EA670 */ get => default; } // 0x00000001824F1CF0-0x00000001824F1D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001895F1BB0-0x00000001895F1BD0 */ get => default; } // 0x00000001824F0FD0-0x00000001824F10D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001895F9550-0x00000001895F9570 */ get => default; } // 0x00000001824F2600-0x00000001824F26A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189600B80-0x0000000189600BA0 */ get => default; } // 0x00000001824F0250-0x00000001824F0350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string JavaPackage { /* [XID] */ /* 0x0000000189647280-0x00000001896472A0 */ get => default; /* [XID] */ /* 0x000000018964E950-0x000000018964E970 */ set {} } // 0x00000001824EED00-0x00000001824EEDE0 0x00000001824EDE40-0x00000001824EDF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string JavaOuterClassname { /* [XID] */ /* 0x00000001896561F0-0x0000000189656210 */ get => default; /* [XID] */ /* 0x000000018965D8E0-0x000000018965D900 */ set {} } // 0x00000001824EEDE0-0x00000001824EEEC0 0x00000001824EDD50-0x00000001824EDE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool JavaMultipleFiles { /* [XID] */ /* 0x0000000189665000-0x0000000189665020 */ get => default; /* [XID] */ /* 0x000000018966C600-0x000000018966C620 */ set {} } // 0x00000001824F0900-0x00000001824F09E0 0x00000001824F1D90-0x00000001824F1E70
	[DebuggerNonUserCode] // 0x0000000189816F20-0x0000000189816F50
	[Obsolete] // 0x0000000189816F20-0x0000000189816F50
	public bool JavaGenerateEqualsAndHash { /* [XID] */ /* 0x0000000189674500-0x0000000189674520 */ get => default; /* [XID] */ /* 0x000000018967BDB0-0x000000018967BDD0 */ set {} } // 0x00000001824F1C10-0x00000001824F1CF0 0x00000001824EE010-0x00000001824EE0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool JavaStringCheckUtf8 { /* [XID] */ /* 0x00000001896833B0-0x00000001896833D0 */ get => default; /* [XID] */ /* 0x000000018968AF40-0x000000018968AF60 */ set {} } // 0x00000001824F12E0-0x00000001824F13C0 0x00000001824EEEC0-0x00000001824EEFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.OptimizeMode OptimizeFor { /* [XID] */ /* 0x0000000189692CD0-0x0000000189692CF0 */ get => default; /* [XID] */ /* 0x0000000189699F00-0x0000000189699F20 */ set {} } // 0x00000001824EDA80-0x00000001824EDB60 0x00000001824EDF30-0x00000001824EE010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GoPackage { /* [XID] */ /* 0x00000001896A16D0-0x00000001896A16F0 */ get => default; /* [XID] */ /* 0x00000001896A8BA0-0x00000001896A8BC0 */ set {} } // 0x00000001824F0EF0-0x00000001824F0FD0 0x00000001824EE7A0-0x00000001824EE890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool CcGenericServices { /* [XID] */ /* 0x00000001896AFC80-0x00000001896AFCA0 */ get => default; /* [XID] */ /* 0x00000001896B7650-0x00000001896B7670 */ set {} } // 0x00000001824F1A60-0x00000001824F1B40 0x00000001824EFEE0-0x00000001824EFFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool JavaGenericServices { /* [XID] */ /* 0x00000001896BE7E0-0x00000001896BE800 */ get => default; /* [XID] */ /* 0x00000001896C60A0-0x00000001896C60C0 */ set {} } // 0x00000001824F0E10-0x00000001824F0EF0 0x00000001824EEA20-0x00000001824EEB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool PyGenericServices { /* [XID] */ /* 0x00000001896CD700-0x00000001896CD720 */ get => default; /* [XID] */ /* 0x00000001896D4B30-0x00000001896D4B50 */ set {} } // 0x00000001824EE940-0x00000001824EEA20 0x00000001824F14B0-0x00000001824F1590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool PhpGenericServices { /* [XID] */ /* 0x00000001896DC170-0x00000001896DC190 */ get => default; /* [XID] */ /* 0x00000001896E38A0-0x00000001896E38C0 */ set {} } // 0x00000001824EE0F0-0x00000001824EE1D0 0x00000001824EF100-0x00000001824EF1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x00000001896EAD10-0x00000001896EAD30 */ get => default; /* [XID] */ /* 0x00000001896F20E0-0x00000001896F2100 */ set {} } // 0x00000001824F1200-0x00000001824F12E0 0x00000001824F1740-0x00000001824F1820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool CcEnableArenas { /* [XID] */ /* 0x00000001896F9B00-0x00000001896F9B20 */ get => default; /* [XID] */ /* 0x0000000189701350-0x0000000189701370 */ set {} } // 0x00000001824EE6C0-0x00000001824EE7A0 0x00000001824F1590-0x00000001824F1670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ObjcClassPrefix { /* [XID] */ /* 0x0000000189708AA0-0x0000000189708AC0 */ get => default; /* [XID] */ /* 0x0000000189710390-0x00000001897103B0 */ set {} } // 0x00000001824F0BC0-0x00000001824F0CA0 0x00000001824F09E0-0x00000001824F0AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CsharpNamespace { /* [XID] */ /* 0x0000000189717710-0x0000000189717730 */ get => default; /* [XID] */ /* 0x000000018971F270-0x000000018971F290 */ set {} } // 0x00000001824F1980-0x00000001824F1A60 0x00000001824F0CA0-0x00000001824F0D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string SwiftPrefix { /* [XID] */ /* 0x0000000189726870-0x0000000189726890 */ get => default; /* [XID] */ /* 0x000000018972DE00-0x000000018972DE20 */ set {} } // 0x00000001824EDC00-0x00000001824EDCE0 0x00000001824EF010-0x00000001824EF100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PhpClassPrefix { /* [XID] */ /* 0x0000000189735470-0x0000000189735490 */ get => default; /* [XID] */ /* 0x000000018973CF60-0x000000018973CF80 */ set {} } // 0x00000001824F2520-0x00000001824F2600 0x00000001824F13C0-0x00000001824F14B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PhpNamespace { /* [XID] */ /* 0x0000000189744510-0x0000000189744530 */ get => default; /* [XID] */ /* 0x000000018974C1A0-0x000000018974C1C0 */ set {} } // 0x00000001824EFFC0-0x00000001824F00A0 0x00000001824EFDF0-0x00000001824EFEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x0000000189753490-0x00000001897534B0 */ get => default; } // 0x00000001824EF810-0x00000001824EF8B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26372
	{
		// Nested types
		internal enum OptimizeMode // TypeDefIndex: 26373
		{
			Speed = 1,
			CodeSize = 2,
			LiteRuntime = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FileOptions() {} // 0x00000001824F3360-0x00000001824F3490
	static FileOptions() {} // 0x00000001824F3250-0x00000001824F3360

	// Methods
	[DebuggerNonUserCode] // 0x0000000189608520-0x0000000189608560
	// [XID] // 0x0000000189608520-0x0000000189608560
	public FileOptions Clone() => default; // 0x00000001824F10D0-0x00000001824F1200
	[DebuggerNonUserCode] // 0x0000000189612AB0-0x0000000189612AF0
	// [XID] // 0x0000000189612AB0-0x0000000189612AF0
	public FileOptions ShallowCopy() => default; // 0x00000001824F0170-0x00000001824F0250
	[DebuggerNonUserCode] // 0x000000018961D390-0x000000018961D3D0
	// [XID] // 0x000000018961D390-0x000000018961D3D0
	protected override void InternalSetInPool(bool value) {} // 0x00000001824EE890-0x00000001824EE940
	[DebuggerNonUserCode] // 0x0000000189627830-0x0000000189627870
	// [XID] // 0x0000000189627830-0x0000000189627870
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F18B0-0x00000001824F1980
	[DebuggerNonUserCode] // 0x0000000189632050-0x0000000189632090
	// [XID] // 0x0000000189632050-0x0000000189632090
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F1B40-0x00000001824F1C10
	[DebuggerNonUserCode] // 0x000000018963CCC0-0x000000018963CD00
	// [XID] // 0x000000018963CCC0-0x000000018963CD00
	public override void Reset() {} // 0x00000001824EEB00-0x00000001824EED00
	[DebuggerNonUserCode] // 0x000000018975A9C0-0x000000018975AA10
	// [IDTag] // 0x000000018975A9C0-0x000000018975AA10
	// [XID] // 0x000000018975A9C0-0x000000018975AA10
	public override bool Equals(object other) => default; // 0x00000001824EF700-0x00000001824EF810
	[DebuggerNonUserCode] // 0x0000000189768130-0x0000000189768180
	// [IDTag] // 0x0000000189768130-0x0000000189768180
	// [XID] // 0x0000000189768130-0x0000000189768180
	public bool Equals(FileOptions other) => default; // 0x00000001824EF1E0-0x00000001824EF700
	[DebuggerNonUserCode] // 0x0000000189775820-0x0000000189775860
	// [XID] // 0x0000000189775820-0x0000000189775860
	public override int GetHashCode() => default; // 0x00000001824F0350-0x00000001824F0900
	[DebuggerNonUserCode] // 0x000000018977FFB0-0x000000018977FFF0
	// [XID] // 0x000000018977FFB0-0x000000018977FFF0
	public override string ToString() => default; // 0x00000001824F27A0-0x00000001824F3250
	[DebuggerNonUserCode] // 0x000000018978A6B0-0x000000018978A6F0
	// [XID] // 0x000000018978A6B0-0x000000018978A6F0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824F1E70-0x00000001824F2520
	[DebuggerNonUserCode] // 0x0000000189794A90-0x0000000189794AD0
	// [XID] // 0x0000000189794A90-0x0000000189794AD0
	public override int CalculateSize() => default; // 0x00000001824EF8B0-0x00000001824EFDF0
	[DebuggerNonUserCode] // 0x000000018979FDF0-0x000000018979FE30
	// [XID] // 0x000000018979FDF0-0x000000018979FE30
	public void CopyFrom(FileOptions other) {} // 0x00000001824EE1D0-0x00000001824EE6C0
	[DebuggerNonUserCode] // 0x00000001897AA190-0x00000001897AA1D0
	// [XID] // 0x00000001897AA190-0x00000001897AA1D0
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824ED680-0x00000001824EDA80
}

