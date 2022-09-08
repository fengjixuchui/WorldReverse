/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabLoopDungeonSelectConditionRsp : MessageBase, IMessage<ChannellerSlabLoopDungeonSelectConditionRsp> // TypeDefIndex: 22313
{
	// Fields
	private static readonly MessageParser<ChannellerSlabLoopDungeonSelectConditionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B014FB
	private int retcode_; // 0x18
	public const int DungeonIndexFieldNumber = 2; // Metadata: 0x00B014FF
	private uint dungeonIndex_; // 0x1C
	public const int DifficultyIdFieldNumber = 3; // Metadata: 0x00B01503
	private uint difficultyId_; // 0x20
	public const int ConditionIdListFieldNumber = 4; // Metadata: 0x00B01507
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabLoopDungeonSelectConditionRsp> Parser { get => default; } // 0x0000000182C8BE20-0x0000000182C8BEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C8BA10-0x0000000182C8BAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C8B600-0x0000000182C8B680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C8AD00-0x0000000182C8AD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C8C240-0x0000000182C8C330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C8BFE0-0x0000000182C8C040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C8BBA0-0x0000000182C8BC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C8C1F0-0x0000000182C8C240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C8B720-0x0000000182C8B810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182C8B560-0x0000000182C8B600 0x0000000182C8B0B0-0x0000000182C8B150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x0000000182C8BD80-0x0000000182C8BE20 0x0000000182C8B970-0x0000000182C8BA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000182C8AD60-0x0000000182C8AE00 0x0000000182C8BAA0-0x0000000182C8BB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000182C8BB40-0x0000000182C8BBA0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22314
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22315
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8015
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonSelectConditionRsp() {} // 0x0000000182C8C710-0x0000000182C8C7A0
	static ChannellerSlabLoopDungeonSelectConditionRsp() {} // 0x0000000182C8C630-0x0000000182C8C710

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonSelectConditionRsp Clone() => default; // 0x0000000182C8BC90-0x0000000182C8BD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonSelectConditionRsp ShallowCopy() => default; // 0x0000000182C8B680-0x0000000182C8B720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C8AF80-0x0000000182C8AFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C8BF40-0x0000000182C8BF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C8BF90-0x0000000182C8BFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C8AFD0-0x0000000182C8B0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C8B2B0-0x0000000182C8B380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabLoopDungeonSelectConditionRsp other) => default; // 0x0000000182C8B150-0x0000000182C8B2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C8B810-0x0000000182C8B970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C8C330-0x0000000182C8C630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C8C040-0x0000000182C8C1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C8B380-0x0000000182C8B560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabLoopDungeonSelectConditionRsp other) {} // 0x0000000182C8AE00-0x0000000182C8AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C8AB60-0x0000000182C8AD00
}

