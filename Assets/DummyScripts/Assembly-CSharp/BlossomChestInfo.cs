/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlossomChestInfo : MessageBase, IMessage<BlossomChestInfo> // TypeDefIndex: 26032
{
	// Fields
	private static readonly MessageParser<BlossomChestInfo> _parser; // 0x00
	public const int ResinFieldNumber = 1; // Metadata: 0x00B0AC7B
	private uint resin_; // 0x18
	public const int QualifyUidListFieldNumber = 2; // Metadata: 0x00B0AC7F
	private static readonly FieldCodec<uint> _repeated_qualifyUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> qualifyUidList_; // 0x20
	public const int RemainUidListFieldNumber = 3; // Metadata: 0x00B0AC83
	private static readonly FieldCodec<uint> _repeated_remainUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> remainUidList_; // 0x28
	public const int DeadTimeFieldNumber = 4; // Metadata: 0x00B0AC87
	private uint deadTime_; // 0x30
	public const int BlossomRefreshTypeFieldNumber = 5; // Metadata: 0x00B0AC8B
	private uint blossomRefreshType_; // 0x34
	public const int RefreshIdFieldNumber = 6; // Metadata: 0x00B0AC8F
	private uint refreshId_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlossomChestInfo> Parser { get => default; } // 0x000000018322D1F0-0x000000018322D280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018322CDE0-0x000000018322CE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018322C9C0-0x000000018322CA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018322BE90-0x000000018322BEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018322D7D0-0x000000018322D8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018322D450-0x000000018322D4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018322CED0-0x000000018322CFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018322D6E0-0x000000018322D730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018322CAE0-0x000000018322CBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Resin { get => default; set {} } // 0x000000018322C440-0x000000018322C4E0 0x000000018322C030-0x000000018322C0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> QualifyUidList { get => default; } // 0x000000018322CE70-0x000000018322CED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RemainUidList { get => default; } // 0x000000018322CD80-0x000000018322CDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DeadTime { get => default; set {} } // 0x000000018322BF90-0x000000018322C030 0x000000018322D0B0-0x000000018322D150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BlossomRefreshType { get => default; set {} } // 0x000000018322D3B0-0x000000018322D450 0x000000018322D730-0x000000018322D7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefreshId { get => default; set {} } // 0x000000018322BEF0-0x000000018322BF90 0x000000018322D150-0x000000018322D1F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfo() {} // 0x000000018322DDC0-0x000000018322DE70
	static BlossomChestInfo() {} // 0x000000018322DCC0-0x000000018322DDC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfo Clone() => default; // 0x000000018322CFC0-0x000000018322D0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfo ShallowCopy() => default; // 0x000000018322CA40-0x000000018322CAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018322C2A0-0x000000018322C2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018322D310-0x000000018322D360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018322D360-0x000000018322D3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018322C2F0-0x000000018322C440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018322C4E0-0x000000018322C5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlossomChestInfo other) => default; // 0x000000018322C5B0-0x000000018322C760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018322CBD0-0x000000018322CD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018322D8C0-0x000000018322DCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018322D4B0-0x000000018322D6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018322C760-0x000000018322C9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlossomChestInfo other) {} // 0x000000018322C0D0-0x000000018322C2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018322BC50-0x000000018322BE90
}

