/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MiracleRingDeliverItemRsp : MessageBase, IMessage<MiracleRingDeliverItemRsp> // TypeDefIndex: 23941
{
	// Fields
	private static readonly MessageParser<MiracleRingDeliverItemRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B052EF
	private int retcode_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B052F3
	private uint gadgetEntityId_; // 0x1C
	public const int InteractTypeFieldNumber = 3; // Metadata: 0x00B052F7
	private InteractType interactType_; // 0x20
	public const int OpTypeFieldNumber = 4; // Metadata: 0x00B052FB
	private InterOpType opType_; // 0x24
	public const int GadgetIdFieldNumber = 5; // Metadata: 0x00B052FF
	private uint gadgetId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MiracleRingDeliverItemRsp> Parser { get => default; } // 0x000000018472E3F0-0x000000018472E480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018472E180-0x000000018472E210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018472DC10-0x000000018472DC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018472D100-0x000000018472D160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018472E8E0-0x000000018472E9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018472E5B0-0x000000018472E610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018472E210-0x000000018472E300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018472E890-0x000000018472E8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018472DDD0-0x000000018472DEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018472DB70-0x000000018472DC10 0x000000018472D5E0-0x000000018472D680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x000000018472E610-0x000000018472E6B0 0x000000018472D160-0x000000018472D200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InteractType InteractType { get => default; set {} } // 0x000000018472D540-0x000000018472D5E0 0x000000018472DD30-0x000000018472DDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InterOpType OpType { get => default; set {} } // 0x000000018472D3B0-0x000000018472D450 0x000000018472D060-0x000000018472D100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x000000018472DAD0-0x000000018472DB70 0x000000018472E0E0-0x000000018472E180

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23942
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23943
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5208
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDeliverItemRsp() {} // 0x000000018472EE30-0x000000018472EEA0
	static MiracleRingDeliverItemRsp() {} // 0x000000018472ED70-0x000000018472EE30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDeliverItemRsp Clone() => default; // 0x000000018472E300-0x000000018472E3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDeliverItemRsp ShallowCopy() => default; // 0x000000018472DC90-0x000000018472DD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018472D450-0x000000018472D4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018472E510-0x000000018472E560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018472E560-0x000000018472E5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018472D4A0-0x000000018472D540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018472D7F0-0x000000018472D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MiracleRingDeliverItemRsp other) => default; // 0x000000018472D680-0x000000018472D7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018472DEC0-0x000000018472E0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018472E9D0-0x000000018472ED70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018472E6B0-0x000000018472E890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018472D8C0-0x000000018472DAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MiracleRingDeliverItemRsp other) {} // 0x000000018472D200-0x000000018472D3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018472CF20-0x000000018472D060
}

