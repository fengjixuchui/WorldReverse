/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FoundationRsp : MessageBase, IMessage<FoundationRsp> // TypeDefIndex: 23226
{
	// Fields
	private static readonly MessageParser<FoundationRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0387F
	private int retcode_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B03883
	private uint gadgetEntityId_; // 0x1C
	public const int OpTypeFieldNumber = 3; // Metadata: 0x00B03887
	private FoundationOpType opType_; // 0x20
	public const int BuildingIdFieldNumber = 4; // Metadata: 0x00B0388B
	private uint buildingId_; // 0x24
	public const int PointConfigIdFieldNumber = 5; // Metadata: 0x00B0388F
	private uint pointConfigId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FoundationRsp> Parser { get => default; } // 0x0000000184B14940-0x0000000184B149D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B146D0-0x0000000184B14760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B14240-0x0000000184B142C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B137D0-0x0000000184B13830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B14F70-0x0000000184B15060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B14BA0-0x0000000184B14C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B14760-0x0000000184B14850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B14F20-0x0000000184B14F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B14360-0x0000000184B14450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184B141A0-0x0000000184B14240 0x0000000184B13CB0-0x0000000184B13D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000184B14CA0-0x0000000184B14D40 0x0000000184B13830-0x0000000184B138D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationOpType OpType { get => default; set {} } // 0x0000000184B13B20-0x0000000184B13BC0 0x0000000184B13730-0x0000000184B137D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuildingId { get => default; set {} } // 0x0000000184B14B00-0x0000000184B14BA0 0x0000000184B14C00-0x0000000184B14CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointConfigId { get => default; set {} } // 0x0000000184B14630-0x0000000184B146D0 0x0000000184B138D0-0x0000000184B13970

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23227
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23228
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 817
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationRsp() {} // 0x0000000184B154C0-0x0000000184B15530
	static FoundationRsp() {} // 0x0000000184B15400-0x0000000184B154C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationRsp Clone() => default; // 0x0000000184B14850-0x0000000184B14940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationRsp ShallowCopy() => default; // 0x0000000184B142C0-0x0000000184B14360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B13BC0-0x0000000184B13C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B14A60-0x0000000184B14AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B14AB0-0x0000000184B14B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B13C10-0x0000000184B13CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B13D50-0x0000000184B13E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FoundationRsp other) => default; // 0x0000000184B13E20-0x0000000184B13F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B14450-0x0000000184B14630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B15060-0x0000000184B15400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B14D40-0x0000000184B14F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B13F90-0x0000000184B141A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FoundationRsp other) {} // 0x0000000184B13970-0x0000000184B13B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B135E0-0x0000000184B13730
}

