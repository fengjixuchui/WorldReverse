/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabLoopDungeonSelectConditionReq : MessageBase, IMessage<ChannellerSlabLoopDungeonSelectConditionReq> // TypeDefIndex: 22310
{
	// Fields
	private static readonly MessageParser<ChannellerSlabLoopDungeonSelectConditionReq> _parser; // 0x00
	public const int DungeonIndexFieldNumber = 1; // Metadata: 0x00B014DB
	private uint dungeonIndex_; // 0x18
	public const int DifficultyIdFieldNumber = 2; // Metadata: 0x00B014DF
	private uint difficultyId_; // 0x1C
	public const int ConditionIdListFieldNumber = 3; // Metadata: 0x00B014E3
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabLoopDungeonSelectConditionReq> Parser { get => default; } // 0x0000000183ACFAE0-0x0000000183ACFB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183ACF6D0-0x0000000183ACF760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183ACF2F0-0x0000000183ACF370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183ACEBD0-0x0000000183ACEC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183ACFEC0-0x0000000183ACFFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183ACFCA0-0x0000000183ACFD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183ACF860-0x0000000183ACF950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183ACFE70-0x0000000183ACFEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183ACF410-0x0000000183ACF500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x0000000183ACFA40-0x0000000183ACFAE0 0x0000000183ACF630-0x0000000183ACF6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000183ACEC30-0x0000000183ACECD0 0x0000000183ACF760-0x0000000183ACF800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000183ACF800-0x0000000183ACF860 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22311
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22312
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8014
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonSelectConditionReq() {} // 0x0000000183AD0300-0x0000000183AD0410
	static ChannellerSlabLoopDungeonSelectConditionReq() {} // 0x0000000183AD0220-0x0000000183AD0300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonSelectConditionReq Clone() => default; // 0x0000000183ACF950-0x0000000183ACFA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonSelectConditionReq ShallowCopy() => default; // 0x0000000183ACF370-0x0000000183ACF410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183ACEE30-0x0000000183ACEE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ACFC00-0x0000000183ACFC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ACFC50-0x0000000183ACFCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183ACEE80-0x0000000183ACEF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183ACEF50-0x0000000183ACF020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabLoopDungeonSelectConditionReq other) => default; // 0x0000000183ACF020-0x0000000183ACF160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183ACF500-0x0000000183ACF630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183ACFFB0-0x0000000183AD0220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183ACFD00-0x0000000183ACFE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183ACF160-0x0000000183ACF2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabLoopDungeonSelectConditionReq other) {} // 0x0000000183ACECD0-0x0000000183ACEE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183ACEA50-0x0000000183ACEBD0
}

