/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryCodexMonsterBeKilledNumRsp : MessageBase, IMessage<QueryCodexMonsterBeKilledNumRsp> // TypeDefIndex: 22665
{
	// Fields
	private static readonly MessageParser<QueryCodexMonsterBeKilledNumRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0219F
	private int retcode_; // 0x18
	public const int CodexIdListFieldNumber = 2; // Metadata: 0x00B021A3
	private static readonly FieldCodec<uint> _repeated_codexIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> codexIdList_; // 0x20
	public const int BeKilledNumListFieldNumber = 3; // Metadata: 0x00B021A7
	private static readonly FieldCodec<uint> _repeated_beKilledNumList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> beKilledNumList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryCodexMonsterBeKilledNumRsp> Parser { get => default; } // 0x00000001835DAE80-0x00000001835DAF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835DAC10-0x00000001835DACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835DA8E0-0x00000001835DA960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835DA070-0x00000001835DA0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835DB2C0-0x00000001835DB3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835DB040-0x00000001835DB0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835DACA0-0x00000001835DAD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835DB270-0x00000001835DB2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835DAA00-0x00000001835DAAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001835DA840-0x00000001835DA8E0 0x00000001835DA3A0-0x00000001835DA440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CodexIdList { get => default; } // 0x00000001835DB210-0x00000001835DB270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> BeKilledNumList { get => default; } // 0x00000001835DA440-0x00000001835DA4A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22666
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22667
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4204
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCodexMonsterBeKilledNumRsp() {} // 0x00000001835DB710-0x00000001835DB7C0
	static QueryCodexMonsterBeKilledNumRsp() {} // 0x00000001835DB610-0x00000001835DB710

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCodexMonsterBeKilledNumRsp Clone() => default; // 0x00000001835DAD90-0x00000001835DAE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCodexMonsterBeKilledNumRsp ShallowCopy() => default; // 0x00000001835DA960-0x00000001835DAA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835DA220-0x00000001835DA270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835DAFA0-0x00000001835DAFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835DAFF0-0x00000001835DB040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835DA270-0x00000001835DA3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835DA4A0-0x00000001835DA570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryCodexMonsterBeKilledNumRsp other) => default; // 0x00000001835DA570-0x00000001835DA6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835DAAF0-0x00000001835DAC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835DB3B0-0x00000001835DB610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835DB0A0-0x00000001835DB210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835DA6C0-0x00000001835DA840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryCodexMonsterBeKilledNumRsp other) {} // 0x00000001835DA0D0-0x00000001835DA220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835D9E90-0x00000001835DA070
}

