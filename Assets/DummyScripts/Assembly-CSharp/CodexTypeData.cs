/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CodexTypeData : MessageBase, IMessage<CodexTypeData> // TypeDefIndex: 22655
{
	// Fields
	private static readonly MessageParser<CodexTypeData> _parser; // 0x00
	public const int TypeFieldNumber = 1; // Metadata: 0x00B02147
	private CodexType type_; // 0x18
	public const int CodexIdListFieldNumber = 2; // Metadata: 0x00B0214B
	private static readonly FieldCodec<uint> _repeated_codexIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> codexIdList_; // 0x20
	public const int HaveViewedListFieldNumber = 3; // Metadata: 0x00B0214F
	private static readonly FieldCodec<bool> _repeated_haveViewedList_codec; // 0x10
	private readonly RepeatedPrimitiveField<bool> haveViewedList_; // 0x28
	public const int WeaponMaxPromoteLevelMapFieldNumber = 4; // Metadata: 0x00B02153
	private static readonly MapField<uint, uint> _map_weaponMaxPromoteLevelMap_codec; // 0x18
	private readonly MapField<uint, uint> weaponMaxPromoteLevelMap_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CodexTypeData> Parser { get => default; } // 0x0000000182359C70-0x0000000182359D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182359A00-0x0000000182359A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182359630-0x00000001823596B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182358E80-0x0000000182358EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018235A1E0-0x000000018235A2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182359E30-0x0000000182359E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182359A90-0x0000000182359B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018235A0F0-0x000000018235A140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182359750-0x0000000182359840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexType Type { get => default; set {} } // 0x0000000182358BA0-0x0000000182358C40 0x000000018235A140-0x000000018235A1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CodexIdList { get => default; } // 0x000000018235A090-0x000000018235A0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<bool> HaveViewedList { get => default; } // 0x0000000182359E90-0x0000000182359EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> WeaponMaxPromoteLevelMap { get => default; } // 0x000000018235A2D0-0x000000018235A330 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexTypeData() {} // 0x000000018235A770-0x000000018235A850
	static CodexTypeData() {} // 0x000000018235A600-0x000000018235A770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexTypeData Clone() => default; // 0x0000000182359B80-0x0000000182359C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexTypeData ShallowCopy() => default; // 0x00000001823596B0-0x0000000182359750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182359050-0x00000001823590A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182359D90-0x0000000182359DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182359DE0-0x0000000182359E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823590A0-0x0000000182359220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182359220-0x00000001823592F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CodexTypeData other) => default; // 0x00000001823592F0-0x0000000182359480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182359840-0x0000000182359A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018235A330-0x000000018235A600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182359EF0-0x000000018235A090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182359480-0x0000000182359630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CodexTypeData other) {} // 0x0000000182358EE0-0x0000000182359050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182358C40-0x0000000182358E80
}

