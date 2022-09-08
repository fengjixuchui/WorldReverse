/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryPathReq : MessageBase, IMessage<QueryPathReq> // TypeDefIndex: 24254
{
	// Fields
	private static readonly MessageParser<QueryPathReq> _parser; // 0x00
	public const int QueryTypeFieldNumber = 1; // Metadata: 0x00B05F27
	private Types.OptionType queryType_; // 0x18
	public const int QueryIdFieldNumber = 2; // Metadata: 0x00B05F2B
	private int queryId_; // 0x1C
	public const int SceneIdFieldNumber = 3; // Metadata: 0x00B05F2F
	private uint sceneId_; // 0x20
	public const int SourcePosFieldNumber = 4; // Metadata: 0x00B05F33
	private Vector sourcePos_; // 0x28
	public const int DestinationPosFieldNumber = 5; // Metadata: 0x00B05F37
	private static readonly FieldCodec<Vector> _repeated_destinationPos_codec; // 0x08
	private readonly RepeatedMessageField<Vector> destinationPos_; // 0x30
	public const int FilterFieldNumber = 6; // Metadata: 0x00B05F3B
	private QueryFilter filter_; // 0x38
	public const int DestinationExtendFieldNumber = 7; // Metadata: 0x00B05F3F
	private Vector3Int destinationExtend_; // 0x40
	public const int SourceExtendFieldNumber = 8; // Metadata: 0x00B05F43
	private Vector3Int sourceExtend_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryPathReq> Parser { get => default; } // 0x0000000183AA2DD0-0x0000000183AA2E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183AA2880-0x0000000183AA2910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183AA21B0-0x0000000183AA2230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183AA0D30-0x0000000183AA0D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AA3480-0x0000000183AA3570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AA3090-0x0000000183AA30F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183AA2B50-0x0000000183AA2C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AA3430-0x0000000183AA3480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183AA2370-0x0000000183AA2460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.OptionType QueryType { get => default; set {} } // 0x0000000183AA29B0-0x0000000183AA2A50 0x0000000183AA30F0-0x0000000183AA3190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int QueryId { get => default; set {} } // 0x0000000183AA3570-0x0000000183AA3610 0x0000000183AA2070-0x0000000183AA2110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000183AA16F0-0x0000000183AA1790 0x0000000183AA2110-0x0000000183AA21B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SourcePos { get => default; set {} } // 0x0000000183AA1830-0x0000000183AA18D0 0x0000000183AA22D0-0x0000000183AA2370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Vector> DestinationPos { get => default; } // 0x0000000183AA2AF0-0x0000000183AA2B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryFilter Filter { get => default; set {} } // 0x0000000183AA2A50-0x0000000183AA2AF0 0x0000000183AA1790-0x0000000183AA1830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector3Int DestinationExtend { get => default; set {} } // 0x0000000183AA2910-0x0000000183AA29B0 0x0000000183AA11A0-0x0000000183AA1240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector3Int SourceExtend { get => default; set {} } // 0x0000000183AA0D90-0x0000000183AA0E30 0x0000000183AA2D30-0x0000000183AA2DD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24255
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24256
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2301
		}

		public enum OptionType // TypeDefIndex: 24257
		{
			OptionNone = 0,
			OptionNormal = 1,
			OptionFirstCanGo = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryPathReq() {} // 0x0000000183AA3BE0-0x0000000183AA3C80
	static QueryPathReq() {} // 0x0000000183AA3AD0-0x0000000183AA3BE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryPathReq Clone() => default; // 0x0000000183AA2C40-0x0000000183AA2D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryPathReq ShallowCopy() => default; // 0x0000000183AA2230-0x0000000183AA22D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183AA1240-0x0000000183AA1300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AA2EF0-0x0000000183AA2FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AA2FC0-0x0000000183AA3090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183AA1300-0x0000000183AA16F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183AA1B00-0x0000000183AA1BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryPathReq other) => default; // 0x0000000183AA18D0-0x0000000183AA1B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183AA2460-0x0000000183AA2880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AA3610-0x0000000183AA3AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AA3190-0x0000000183AA3430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183AA1BD0-0x0000000183AA2070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryPathReq other) {} // 0x0000000183AA0E30-0x0000000183AA11A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183AA0A50-0x0000000183AA0D30
}

