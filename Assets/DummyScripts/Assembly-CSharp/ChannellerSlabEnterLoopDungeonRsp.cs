/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabEnterLoopDungeonRsp : MessageBase, IMessage<ChannellerSlabEnterLoopDungeonRsp> // TypeDefIndex: 22292
{
	// Fields
	private static readonly MessageParser<ChannellerSlabEnterLoopDungeonRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01433
	private int retcode_; // 0x18
	public const int DungeonIndexFieldNumber = 2; // Metadata: 0x00B01437
	private uint dungeonIndex_; // 0x1C
	public const int DifficultyIdFieldNumber = 3; // Metadata: 0x00B0143B
	private uint difficultyId_; // 0x20
	public const int ConditionIdListFieldNumber = 4; // Metadata: 0x00B0143F
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x28
	public const int PointIdFieldNumber = 5; // Metadata: 0x00B01443
	private uint pointId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabEnterLoopDungeonRsp> Parser { get => default; } // 0x000000018455AE30-0x000000018455AEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018455A980-0x000000018455AA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018455A550-0x000000018455A5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184559B20-0x0000000184559B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018455B2A0-0x000000018455B390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018455AFF0-0x000000018455B050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018455ABB0-0x000000018455ACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018455B250-0x000000018455B2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018455A670-0x000000018455A760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018455A4B0-0x000000018455A550 0x0000000184559F00-0x0000000184559FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x000000018455AD90-0x000000018455AE30 0x000000018455A8E0-0x000000018455A980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000184559B80-0x0000000184559C20 0x000000018455AA10-0x000000018455AAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x000000018455AB50-0x000000018455ABB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x000000018455AAB0-0x000000018455AB50 0x0000000184559FA0-0x000000018455A040

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22293
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22294
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8008
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabEnterLoopDungeonRsp() {} // 0x000000018455B800-0x000000018455B890
	static ChannellerSlabEnterLoopDungeonRsp() {} // 0x000000018455B720-0x000000018455B800

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabEnterLoopDungeonRsp Clone() => default; // 0x000000018455ACA0-0x000000018455AD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabEnterLoopDungeonRsp ShallowCopy() => default; // 0x000000018455A5D0-0x000000018455A670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184559DC0-0x0000000184559E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018455AF50-0x000000018455AFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018455AFA0-0x000000018455AFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184559E10-0x0000000184559F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018455A1C0-0x000000018455A290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabEnterLoopDungeonRsp other) => default; // 0x000000018455A040-0x000000018455A1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018455A760-0x000000018455A8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018455B390-0x000000018455B720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018455B050-0x000000018455B250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018455A290-0x000000018455A4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabEnterLoopDungeonRsp other) {} // 0x0000000184559C20-0x0000000184559DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184559960-0x0000000184559B20
}

