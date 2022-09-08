/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonEntryInfoRsp : MessageBase, IMessage<DungeonEntryInfoRsp> // TypeDefIndex: 22807
{
	// Fields
	private static readonly MessageParser<DungeonEntryInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B026BF
	private int retcode_; // 0x18
	public const int PointIdFieldNumber = 2; // Metadata: 0x00B026C3
	private uint pointId_; // 0x1C
	public const int DungeonEntryListFieldNumber = 3; // Metadata: 0x00B026C7
	private static readonly FieldCodec<DungeonEntryInfo> _repeated_dungeonEntryList_codec; // 0x08
	private readonly RepeatedMessageField<DungeonEntryInfo> dungeonEntryList_; // 0x20
	public const int RecommendDungeonIdFieldNumber = 4; // Metadata: 0x00B026CB
	private uint recommendDungeonId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonEntryInfoRsp> Parser { get => default; } // 0x0000000182633670-0x0000000182633700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001826332C0-0x0000000182633350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182632F50-0x0000000182632FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826325F0-0x0000000182632650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182633BC0-0x0000000182633CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826338B0-0x0000000182633910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001826333F0-0x00000001826334E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182633B70-0x0000000182633BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182633070-0x0000000182633160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182632EB0-0x0000000182632F50 0x0000000182632950-0x00000001826329F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000182633350-0x00000001826333F0 0x00000001826329F0-0x0000000182632A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DungeonEntryInfo> DungeonEntryList { get => default; } // 0x0000000182633CB0-0x0000000182633D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RecommendDungeonId { get => default; set {} } // 0x0000000182633910-0x00000001826339B0 0x00000001826335D0-0x0000000182633670

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22808
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22809
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 902
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfoRsp() {} // 0x0000000182634120-0x00000001826341B0
	static DungeonEntryInfoRsp() {} // 0x0000000182634010-0x0000000182634120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfoRsp Clone() => default; // 0x00000001826334E0-0x00000001826335D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfoRsp ShallowCopy() => default; // 0x0000000182632FD0-0x0000000182633070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182632800-0x0000000182632850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182633790-0x0000000182633820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182633820-0x00000001826338B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182632850-0x0000000182632950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182632C00-0x0000000182632CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonEntryInfoRsp other) => default; // 0x0000000182632A90-0x0000000182632C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182633160-0x00000001826332C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182633D10-0x0000000182634010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001826339B0-0x0000000182633B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182632CD0-0x0000000182632EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonEntryInfoRsp other) {} // 0x0000000182632650-0x0000000182632800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182632450-0x00000001826325F0
}

