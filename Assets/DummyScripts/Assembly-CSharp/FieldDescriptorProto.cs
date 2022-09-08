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

internal sealed class FieldDescriptorProto : MessageBase, IMessage<FieldDescriptorProto> // TypeDefIndex: 26362
{
	// Fields
	private static readonly MessageParser<FieldDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BF2D
	private string name_; // 0x18
	public const int NumberFieldNumber = 3; // Metadata: 0x00B0BF31
	private int number_; // 0x20
	public const int LabelFieldNumber = 4; // Metadata: 0x00B0BF35
	private Types.Label label_; // 0x24
	public const int TypeFieldNumber = 5; // Metadata: 0x00B0BF39
	private Types.Type type_; // 0x28
	public const int TypeNameFieldNumber = 6; // Metadata: 0x00B0BF3D
	private string typeName_; // 0x30
	public const int ExtendeeFieldNumber = 2; // Metadata: 0x00B0BF41
	private string extendee_; // 0x38
	public const int DefaultValueFieldNumber = 7; // Metadata: 0x00B0BF45
	private string defaultValue_; // 0x40
	public const int OneofIndexFieldNumber = 9; // Metadata: 0x00B0BF49
	private int oneofIndex_; // 0x48
	public const int JsonNameFieldNumber = 10; // Metadata: 0x00B0BF4D
	private string jsonName_; // 0x50
	public const int OptionsFieldNumber = 8; // Metadata: 0x00B0BF51
	private FieldOptions options_; // 0x58

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FieldDescriptorProto> Parser { /* [XID] */ /* 0x00000001897AB880-0x00000001897AB8A0 */ get => default; } // 0x0000000183093920-0x00000001830939F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001897B37D0-0x00000001897B37F0 */ get => default; } // 0x00000001830932E0-0x00000001830933D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001897BB610-0x00000001897BB630 */ get => default; } // 0x0000000183092A80-0x0000000183092B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001897C2E20-0x00000001897C2E40 */ get => default; } // 0x0000000183091540-0x00000001830915E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897CA6A0-0x00000001897CA6C0 */ get => default; } // 0x0000000183094580-0x0000000183094680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001897D1C70-0x00000001897D1C90 */ get => default; } // 0x0000000183093DC0-0x0000000183093E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001897D9B10-0x00000001897D9B30 */ get => default; } // 0x00000001830936F0-0x00000001830937F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001897E0E50-0x00000001897E0E70 */ get => default; } // 0x0000000183094400-0x00000001830944A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001897E84F0-0x00000001897E8510 */ get => default; } // 0x0000000183092D10-0x0000000183092E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x000000018982EAA0-0x000000018982EAC0 */ get => default; /* [XID] */ /* 0x0000000189836410-0x0000000189836430 */ set {} } // 0x00000001830929A0-0x0000000183092A80 0x0000000183091FE0-0x00000001830920D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Number { /* [XID] */ /* 0x000000018983D850-0x000000018983D870 */ get => default; /* [XID] */ /* 0x00000001898450B0-0x00000001898450D0 */ set {} } // 0x0000000183093200-0x00000001830932E0 0x0000000183093610-0x00000001830936F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Label Label { /* [XID] */ /* 0x000000018984C500-0x000000018984C520 */ get => default; /* [XID] */ /* 0x0000000189853610-0x0000000189853630 */ set {} } // 0x0000000183093530-0x0000000183093610 0x0000000183094930-0x0000000183094A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Type Type { /* [XID] */ /* 0x000000018985B0E0-0x000000018985B100 */ get => default; /* [XID] */ /* 0x0000000189862560-0x0000000189862580 */ set {} } // 0x00000001830911F0-0x00000001830912D0 0x00000001830944A0-0x0000000183094580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TypeName { /* [XID] */ /* 0x00000001898699B0-0x00000001898699D0 */ get => default; /* [XID] */ /* 0x0000000189870C50-0x0000000189870C70 */ set {} } // 0x0000000183094680-0x0000000183094760 0x0000000183091EF0-0x0000000183091FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Extendee { /* [XID] */ /* 0x00000001898786E0-0x0000000189878700 */ get => default; /* [XID] */ /* 0x000000018987FC10-0x000000018987FC30 */ set {} } // 0x0000000183091B60-0x0000000183091C40 0x00000001830915E0-0x00000001830916D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DefaultValue { /* [XID] */ /* 0x0000000189887280-0x00000001898872A0 */ get => default; /* [XID] */ /* 0x000000018988E3B0-0x000000018988E3D0 */ set {} } // 0x0000000183093CE0-0x0000000183093DC0 0x0000000183094760-0x0000000183094850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int OneofIndex { /* [XID] */ /* 0x0000000189895A00-0x0000000189895A20 */ get => default; /* [XID] */ /* 0x000000018989D0A0-0x000000018989D0C0 */ set {} } // 0x0000000183092C30-0x0000000183092D10 0x0000000183093C00-0x0000000183093CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string JsonName { /* [XID] */ /* 0x00000001898A4980-0x00000001898A49A0 */ get => default; /* [XID] */ /* 0x00000001898ABEA0-0x00000001898ABEC0 */ set {} } // 0x00000001830933D0-0x00000001830934B0 0x0000000183094310-0x0000000183094400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FieldOptions Options { /* [XID] */ /* 0x00000001898B35D0-0x00000001898B35F0 */ get => default; /* [XID] */ /* 0x00000001898BB3A0-0x00000001898BB3C0 */ set {} } // 0x0000000183093E60-0x0000000183093F40 0x0000000183094850-0x0000000183094930

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26363
	{
		// Nested types
		internal enum Type // TypeDefIndex: 26364
		{
			Double = 1,
			Float = 2,
			Int64 = 3,
			Uint64 = 4,
			Int32 = 5,
			Fixed64 = 6,
			Fixed32 = 7,
			Bool = 8,
			String = 9,
			Group = 10,
			Message = 11,
			Bytes = 12,
			Uint32 = 13,
			Enum = 14,
			Sfixed32 = 15,
			Sfixed64 = 16,
			Sint32 = 17,
			Sint64 = 18
		}

		internal enum Label // TypeDefIndex: 26365
		{
			Optional = 1,
			Required = 2,
			Repeated = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FieldDescriptorProto() {} // 0x00000001830950D0-0x0000000183095180
	static FieldDescriptorProto() {} // 0x0000000183095010-0x00000001830950D0

	// Methods
	[DebuggerNonUserCode] // 0x00000001897F0230-0x00000001897F0270
	// [XID] // 0x00000001897F0230-0x00000001897F0270
	public FieldDescriptorProto Clone() => default; // 0x00000001830937F0-0x0000000183093920
	[DebuggerNonUserCode] // 0x00000001897FAD60-0x00000001897FADA0
	// [XID] // 0x00000001897FAD60-0x00000001897FADA0
	public FieldDescriptorProto ShallowCopy() => default; // 0x0000000183092B50-0x0000000183092C30
	[DebuggerNonUserCode] // 0x0000000189804F10-0x0000000189804F50
	// [XID] // 0x0000000189804F10-0x0000000189804F50
	protected override void InternalSetInPool(bool value) {} // 0x0000000183091C40-0x0000000183091D00
	[DebuggerNonUserCode] // 0x000000018980F8B0-0x000000018980F8F0
	// [XID] // 0x000000018980F8B0-0x000000018980F8F0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183093A80-0x0000000183093B40
	[DebuggerNonUserCode] // 0x000000018981A150-0x000000018981A190
	// [XID] // 0x000000018981A150-0x000000018981A190
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183093B40-0x0000000183093C00
	[DebuggerNonUserCode] // 0x0000000189824400-0x0000000189824440
	// [XID] // 0x0000000189824400-0x0000000189824440
	public override void Reset() {} // 0x0000000183091D00-0x0000000183091E80
	[DebuggerNonUserCode] // 0x00000001898C2680-0x00000001898C26D0
	// [IDTag] // 0x00000001898C2680-0x00000001898C26D0
	// [XID] // 0x00000001898C2680-0x00000001898C26D0
	public override bool Equals(object other) => default; // 0x00000001830920D0-0x00000001830921E0
	[DebuggerNonUserCode] // 0x00000001898D02A0-0x00000001898D02F0
	// [IDTag] // 0x00000001898D02A0-0x00000001898D02F0
	// [XID] // 0x00000001898D02A0-0x00000001898D02F0
	public bool Equals(FieldDescriptorProto other) => default; // 0x00000001830921E0-0x0000000183092560
	[DebuggerNonUserCode] // 0x00000001898DDBE0-0x00000001898DDC20
	// [XID] // 0x00000001898DDBE0-0x00000001898DDC20
	public override int GetHashCode() => default; // 0x0000000183092E10-0x0000000183093200
	[DebuggerNonUserCode] // 0x00000001898E8770-0x00000001898E87B0
	// [XID] // 0x00000001898E8770-0x00000001898E87B0
	public override string ToString() => default; // 0x0000000183094A10-0x0000000183095010
	[DebuggerNonUserCode] // 0x00000001898F2E70-0x00000001898F2EB0
	// [XID] // 0x00000001898F2E70-0x00000001898F2EB0
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183093F40-0x0000000183094310
	[DebuggerNonUserCode] // 0x00000001898FD800-0x00000001898FD840
	// [XID] // 0x00000001898FD800-0x00000001898FD840
	public override int CalculateSize() => default; // 0x0000000183092560-0x00000001830929A0
	[DebuggerNonUserCode] // 0x0000000189908140-0x0000000189908180
	// [XID] // 0x0000000189908140-0x0000000189908180
	public void CopyFrom(FieldDescriptorProto other) {} // 0x0000000183091740-0x0000000183091AC0
	[DebuggerNonUserCode] // 0x0000000189912AD0-0x0000000189912B10
	// [XID] // 0x0000000189912AD0-0x0000000189912B10
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830912D0-0x0000000183091540
	// [XID] // 0x000000018991D220-0x000000018991D240
	private void OnConstruction() {} // 0x0000000183091AC0-0x0000000183091B60
}

