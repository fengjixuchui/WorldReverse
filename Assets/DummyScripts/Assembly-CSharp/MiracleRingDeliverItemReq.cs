/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MiracleRingDeliverItemReq : MessageBase, IMessage<MiracleRingDeliverItemReq> // TypeDefIndex: 23938
{
	// Fields
	private static readonly MessageParser<MiracleRingDeliverItemReq> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B052C7
	private uint gadgetEntityId_; // 0x18
	public const int OpTypeFieldNumber = 2; // Metadata: 0x00B052CB
	private InterOpType opType_; // 0x1C
	public const int GadgetIdFieldNumber = 3; // Metadata: 0x00B052CF
	private uint gadgetId_; // 0x20
	public const int FoodWeaponGuidListFieldNumber = 4; // Metadata: 0x00B052D3
	private static readonly FieldCodec<ulong> _repeated_foodWeaponGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> foodWeaponGuidList_; // 0x28
	public const int ItemParamListFieldNumber = 5; // Metadata: 0x00B052D7
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MiracleRingDeliverItemReq> Parser { get => default; } // 0x00000001818FA990-0x00000001818FAA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818FA720-0x00000001818FA7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818FA2B0-0x00000001818FA330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818F9820-0x00000001818F9880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818FAF70-0x00000001818FB060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818FABD0-0x00000001818FAC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818FA7B0-0x00000001818FA8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818FAEC0-0x00000001818FAF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818FA3D0-0x00000001818FA4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x00000001818FAC30-0x00000001818FACD0 0x00000001818F9880-0x00000001818F9920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InterOpType OpType { get => default; set {} } // 0x00000001818F9AF0-0x00000001818F9B90 0x00000001818F9780-0x00000001818F9820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x00000001818FA210-0x00000001818FA2B0 0x00000001818FA680-0x00000001818FA720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> FoodWeaponGuidList { get => default; } // 0x00000001818F9D40-0x00000001818F9DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x00000001818FAF10-0x00000001818FAF70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23939
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23940
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5207
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDeliverItemReq() {} // 0x00000001818FB500-0x00000001818FB5C0
	static MiracleRingDeliverItemReq() {} // 0x00000001818FB3D0-0x00000001818FB500

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDeliverItemReq Clone() => default; // 0x00000001818FA8A0-0x00000001818FA990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDeliverItemReq ShallowCopy() => default; // 0x00000001818FA330-0x00000001818FA3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818F9B90-0x00000001818F9BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818FAAB0-0x00000001818FAB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818FAB40-0x00000001818FABD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818F9BE0-0x00000001818F9D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818F9DA0-0x00000001818F9E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MiracleRingDeliverItemReq other) => default; // 0x00000001818F9E70-0x00000001818FA000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818FA4C0-0x00000001818FA680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818FB060-0x00000001818FB3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818FACD0-0x00000001818FAEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818FA000-0x00000001818FA210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MiracleRingDeliverItemReq other) {} // 0x00000001818F9920-0x00000001818F9AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818F9570-0x00000001818F9780
}

