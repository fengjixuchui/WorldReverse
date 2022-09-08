/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabLoopDungeonChallengeInfoNotify : MessageBase, IMessage<ChannellerSlabLoopDungeonChallengeInfoNotify> // TypeDefIndex: 22307
{
	// Fields
	private static readonly MessageParser<ChannellerSlabLoopDungeonChallengeInfoNotify> _parser; // 0x00
	public const int DungeonIndexFieldNumber = 1; // Metadata: 0x00B014B7
	private uint dungeonIndex_; // 0x18
	public const int DifficultyIdFieldNumber = 2; // Metadata: 0x00B014BB
	private uint difficultyId_; // 0x1C
	public const int ConditionIdListFieldNumber = 3; // Metadata: 0x00B014BF
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x20
	public const int ChallengeScoreFieldNumber = 4; // Metadata: 0x00B014C3
	private uint challengeScore_; // 0x28
	public const int SchemeBuffIdListFieldNumber = 5; // Metadata: 0x00B014C7
	private static readonly FieldCodec<uint> _repeated_schemeBuffIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> schemeBuffIdList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabLoopDungeonChallengeInfoNotify> Parser { get => default; } // 0x0000000184ED9B50-0x0000000184ED9BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184ED9740-0x0000000184ED97D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184ED92B0-0x0000000184ED9330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184ED89F0-0x0000000184ED8A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EDA120-0x0000000184EDA210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184ED9DB0-0x0000000184ED9E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184ED98D0-0x0000000184ED99C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EDA0D0-0x0000000184EDA120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184ED9430-0x0000000184ED9520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x0000000184ED9AB0-0x0000000184ED9B50 0x0000000184ED96A0-0x0000000184ED9740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000184ED8A50-0x0000000184ED8AF0 0x0000000184ED97D0-0x0000000184ED9870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000184ED9870-0x0000000184ED98D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeScore { get => default; set {} } // 0x0000000184ED9D10-0x0000000184ED9DB0 0x0000000184EDA030-0x0000000184EDA0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SchemeBuffIdList { get => default; } // 0x0000000184ED93D0-0x0000000184ED9430 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22308
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22309
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8013
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonChallengeInfoNotify() {} // 0x0000000184EDA680-0x0000000184EDA730
	static ChannellerSlabLoopDungeonChallengeInfoNotify() {} // 0x0000000184EDA580-0x0000000184EDA680

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonChallengeInfoNotify Clone() => default; // 0x0000000184ED99C0-0x0000000184ED9AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonChallengeInfoNotify ShallowCopy() => default; // 0x0000000184ED9330-0x0000000184ED93D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184ED8C90-0x0000000184ED8CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ED9C70-0x0000000184ED9CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ED9CC0-0x0000000184ED9D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184ED8CE0-0x0000000184ED8E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184ED8E20-0x0000000184ED8EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabLoopDungeonChallengeInfoNotify other) => default; // 0x0000000184ED8EF0-0x0000000184ED9080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184ED9520-0x0000000184ED96A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EDA210-0x0000000184EDA580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184ED9E10-0x0000000184EDA030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184ED9080-0x0000000184ED92B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabLoopDungeonChallengeInfoNotify other) {} // 0x0000000184ED8AF0-0x0000000184ED8C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184ED87E0-0x0000000184ED89F0
}

