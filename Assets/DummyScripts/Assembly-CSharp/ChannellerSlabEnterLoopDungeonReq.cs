/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabEnterLoopDungeonReq : MessageBase, IMessage<ChannellerSlabEnterLoopDungeonReq> // TypeDefIndex: 22289
{
	// Fields
	private static readonly MessageParser<ChannellerSlabEnterLoopDungeonReq> _parser; // 0x00
	public const int DungeonIndexFieldNumber = 1; // Metadata: 0x00B0140F
	private uint dungeonIndex_; // 0x18
	public const int DifficultyIdFieldNumber = 2; // Metadata: 0x00B01413
	private uint difficultyId_; // 0x1C
	public const int ConditionIdListFieldNumber = 3; // Metadata: 0x00B01417
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x20
	public const int PointIdFieldNumber = 4; // Metadata: 0x00B0141B
	private uint pointId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabEnterLoopDungeonReq> Parser { get => default; } // 0x0000000182DF3230-0x0000000182DF32C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182DF2D80-0x0000000182DF2E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182DF2970-0x0000000182DF29F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182DF2100-0x0000000182DF2160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182DF3660-0x0000000182DF3750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182DF33F0-0x0000000182DF3450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182DF2FB0-0x0000000182DF30A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182DF3610-0x0000000182DF3660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182DF2A90-0x0000000182DF2B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x0000000182DF3190-0x0000000182DF3230 0x0000000182DF2CE0-0x0000000182DF2D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000182DF2160-0x0000000182DF2200 0x0000000182DF2E10-0x0000000182DF2EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000182DF2F50-0x0000000182DF2FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000182DF2EB0-0x0000000182DF2F50 0x0000000182DF24C0-0x0000000182DF2560

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22290
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22291
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8007
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabEnterLoopDungeonReq() {} // 0x0000000182DF3B30-0x0000000182DF3BC0
	static ChannellerSlabEnterLoopDungeonReq() {} // 0x0000000182DF3A50-0x0000000182DF3B30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabEnterLoopDungeonReq Clone() => default; // 0x0000000182DF30A0-0x0000000182DF3190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabEnterLoopDungeonReq ShallowCopy() => default; // 0x0000000182DF29F0-0x0000000182DF2A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182DF2380-0x0000000182DF23D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DF3350-0x0000000182DF33A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DF33A0-0x0000000182DF33F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182DF23D0-0x0000000182DF24C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182DF26C0-0x0000000182DF2790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabEnterLoopDungeonReq other) => default; // 0x0000000182DF2560-0x0000000182DF26C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182DF2B80-0x0000000182DF2CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182DF3750-0x0000000182DF3A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182DF3450-0x0000000182DF3610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182DF2790-0x0000000182DF2970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabEnterLoopDungeonReq other) {} // 0x0000000182DF2200-0x0000000182DF2380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182DF1F60-0x0000000182DF2100
}

