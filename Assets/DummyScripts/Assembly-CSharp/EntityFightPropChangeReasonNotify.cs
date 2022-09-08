/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityFightPropChangeReasonNotify : MessageBase, IMessage<EntityFightPropChangeReasonNotify> // TypeDefIndex: 24543
{
	// Fields
	private static readonly MessageParser<EntityFightPropChangeReasonNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B06AA3
	private uint entityId_; // 0x18
	public const int PropTypeFieldNumber = 2; // Metadata: 0x00B06AA7
	private uint propType_; // 0x1C
	public const int PropDeltaFieldNumber = 3; // Metadata: 0x00B06AAB
	private float propDelta_; // 0x20
	public const int ReasonFieldNumber = 4; // Metadata: 0x00B06AAF
	private PropChangeReason reason_; // 0x24
	public const int ParamListFieldNumber = 5; // Metadata: 0x00B06AB3
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x28
	public const int ChangeHpReasonFieldNumber = 6; // Metadata: 0x00B06AB7
	private ChangHpReason changeHpReason_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityFightPropChangeReasonNotify> Parser { get => default; } // 0x0000000185194FF0-0x0000000185195080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185194BA0-0x0000000185194C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185194690-0x0000000185194710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185193D10-0x0000000185193D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185195640-0x0000000185195730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185195250-0x00000001851952B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185194C30-0x0000000185194D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851955F0-0x0000000185195640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851947B0-0x00000001851948A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001851951B0-0x0000000185195250 0x0000000185195730-0x00000001851957D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropType { get => default; set {} } // 0x0000000185194E10-0x0000000185194EB0 0x0000000185194130-0x00000001851941D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float PropDelta { get => default; set {} } // 0x0000000185194EB0-0x0000000185194F50 0x0000000185195310-0x00000001851953B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropChangeReason Reason { get => default; set {} } // 0x0000000185194F50-0x0000000185194FF0 0x0000000185193F90-0x0000000185194030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x00000001851952B0-0x0000000185195310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangHpReason ChangeHpReason { get => default; set {} } // 0x0000000185194B00-0x0000000185194BA0 0x0000000185193C70-0x0000000185193D10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24544
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24545
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1207
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityFightPropChangeReasonNotify() {} // 0x0000000185195CD0-0x0000000185195D70
	static EntityFightPropChangeReasonNotify() {} // 0x0000000185195BF0-0x0000000185195CD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityFightPropChangeReasonNotify Clone() => default; // 0x0000000185194D20-0x0000000185194E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityFightPropChangeReasonNotify ShallowCopy() => default; // 0x0000000185194710-0x00000001851947B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185193F40-0x0000000185193F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185195110-0x0000000185195160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185195160-0x00000001851951B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185194030-0x0000000185194130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851941D0-0x00000001851942A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityFightPropChangeReasonNotify other) => default; // 0x00000001851942A0-0x0000000185194450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851948A0-0x0000000185194B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851957D0-0x0000000185195BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851953B0-0x00000001851955F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185194450-0x0000000185194690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityFightPropChangeReasonNotify other) {} // 0x0000000185193D70-0x0000000185193F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185193A90-0x0000000185193C70
}

