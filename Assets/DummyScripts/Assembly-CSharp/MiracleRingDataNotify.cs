/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MiracleRingDataNotify : MessageBase, IMessage<MiracleRingDataNotify> // TypeDefIndex: 23926
{
	// Fields
	private static readonly MessageParser<MiracleRingDataNotify> _parser; // 0x00
	public const int LastDeliverItemTimeFieldNumber = 1; // Metadata: 0x00B0525B
	private uint lastDeliverItemTime_; // 0x18
	public const int LastTakeRewardTimeFieldNumber = 2; // Metadata: 0x00B0525F
	private uint lastTakeRewardTime_; // 0x1C
	public const int MiracleRingCdFieldNumber = 3; // Metadata: 0x00B05263
	private uint miracleRingCd_; // 0x20
	public const int IsGadgetCreatedFieldNumber = 4; // Metadata: 0x00B05267
	private bool isGadgetCreated_; // 0x24
	public const int GadgetEntityIdFieldNumber = 5; // Metadata: 0x00B0526B
	private uint gadgetEntityId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MiracleRingDataNotify> Parser { get => default; } // 0x0000000184E70030-0x0000000184E700C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184E6FD20-0x0000000184E6FDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184E6F8E0-0x0000000184E6F960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184E6EF40-0x0000000184E6EFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184E70520-0x0000000184E70610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184E701F0-0x0000000184E70250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184E6FE50-0x0000000184E6FF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184E704D0-0x0000000184E70520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184E6FA00-0x0000000184E6FAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastDeliverItemTime { get => default; set {} } // 0x0000000184E6F380-0x0000000184E6F420 0x0000000184E6FC80-0x0000000184E6FD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastTakeRewardTime { get => default; set {} } // 0x0000000184E6F040-0x0000000184E6F0E0 0x0000000184E6FDB0-0x0000000184E6FE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MiracleRingCd { get => default; set {} } // 0x0000000184E6F840-0x0000000184E6F8E0 0x0000000184E6ECB0-0x0000000184E6ED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGadgetCreated { get => default; set {} } // 0x0000000184E70610-0x0000000184E706B0 0x0000000184E6EEA0-0x0000000184E6EF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000184E70250-0x0000000184E702F0 0x0000000184E6EFA0-0x0000000184E6F040

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23927
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23928
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5203
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDataNotify() {} // 0x0000000184E70B10-0x0000000184E70B70
	static MiracleRingDataNotify() {} // 0x0000000184E70A50-0x0000000184E70B10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDataNotify Clone() => default; // 0x0000000184E6FF40-0x0000000184E70030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDataNotify ShallowCopy() => default; // 0x0000000184E6F960-0x0000000184E6FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184E6F290-0x0000000184E6F2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E70150-0x0000000184E701A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E701A0-0x0000000184E701F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184E6F2E0-0x0000000184E6F380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184E6F420-0x0000000184E6F4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MiracleRingDataNotify other) => default; // 0x0000000184E6F4F0-0x0000000184E6F660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184E6FAF0-0x0000000184E6FC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184E706B0-0x0000000184E70A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184E702F0-0x0000000184E704D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184E6F660-0x0000000184E6F840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MiracleRingDataNotify other) {} // 0x0000000184E6F0E0-0x0000000184E6F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184E6ED50-0x0000000184E6EEA0
}

