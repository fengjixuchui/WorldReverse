/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RegionSearchInfo : MessageBase, IMessage<RegionSearchInfo> // TypeDefIndex: 24726
{
	// Fields
	private static readonly MessageParser<RegionSearchInfo> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B07173
	private uint id_; // 0x18
	public const int RegionSearchListFieldNumber = 2; // Metadata: 0x00B07177
	private static readonly FieldCodec<RegionSearch> _repeated_regionSearchList_codec; // 0x08
	private readonly RepeatedMessageField<RegionSearch> regionSearchList_; // 0x20
	public const int IsEnteredFieldNumber = 3; // Metadata: 0x00B0717B
	private bool isEntered_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RegionSearchInfo> Parser { get => default; } // 0x0000000183493370-0x0000000183493400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183493000-0x0000000183493090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183492C20-0x0000000183492CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834924D0-0x0000000183492530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183493880-0x0000000183493970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183493650-0x00000001834936B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183493190-0x0000000183493280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183493830-0x0000000183493880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183492DE0-0x0000000183492ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000183492B80-0x0000000183492C20 0x0000000183493400-0x00000001834934A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<RegionSearch> RegionSearchList { get => default; } // 0x0000000183493090-0x00000001834930F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEntered { get => default; set {} } // 0x00000001834930F0-0x0000000183493190 0x0000000183492D40-0x0000000183492DE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchInfo() {} // 0x0000000183493CF0-0x0000000183493D80
	static RegionSearchInfo() {} // 0x0000000183493BE0-0x0000000183493CF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchInfo Clone() => default; // 0x0000000183493280-0x0000000183493370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchInfo ShallowCopy() => default; // 0x0000000183492CA0-0x0000000183492D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001834926C0-0x0000000183492710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183493530-0x00000001834935C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834935C0-0x0000000183493650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183492710-0x0000000183492800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183492800-0x00000001834928D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RegionSearchInfo other) => default; // 0x00000001834928D0-0x0000000183492A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183492ED0-0x0000000183493000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183493970-0x0000000183493BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834936B0-0x0000000183493830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183492A20-0x0000000183492B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RegionSearchInfo other) {} // 0x0000000183492530-0x00000001834926C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183492350-0x00000001834924D0
}

