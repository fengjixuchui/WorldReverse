/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeOfferingLevelRewardRsp : MessageBase, IMessage<TakeOfferingLevelRewardRsp> // TypeDefIndex: 24235
{
	// Fields
	private static readonly MessageParser<TakeOfferingLevelRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05E87
	private int retcode_; // 0x18
	public const int OfferingIdFieldNumber = 2; // Metadata: 0x00B05E8B
	private uint offeringId_; // 0x1C
	public const int TakeLevelFieldNumber = 3; // Metadata: 0x00B05E8F
	private uint takeLevel_; // 0x20
	public const int ItemListFieldNumber = 4; // Metadata: 0x00B05E93
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeOfferingLevelRewardRsp> Parser { get => default; } // 0x0000000183E6C180-0x0000000183E6C210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E6BE10-0x0000000183E6BEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E6BAA0-0x0000000183E6BB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E6B0A0-0x0000000183E6B100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E6C620-0x0000000183E6C710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E6C3C0-0x0000000183E6C420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E6BF00-0x0000000183E6BFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E6C5D0-0x0000000183E6C620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E6BBC0-0x0000000183E6BCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183E6B960-0x0000000183E6BA00 0x0000000183E6B4A0-0x0000000183E6B540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OfferingId { get => default; set {} } // 0x0000000183E6C710-0x0000000183E6C7B0 0x0000000183E6C0E0-0x0000000183E6C180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TakeLevel { get => default; set {} } // 0x0000000183E6B100-0x0000000183E6B1A0 0x0000000183E6BA00-0x0000000183E6BAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000183E6BEA0-0x0000000183E6BF00 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24236
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24237
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2905
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeOfferingLevelRewardRsp() {} // 0x0000000183E6CBC0-0x0000000183E6CC50
	static TakeOfferingLevelRewardRsp() {} // 0x0000000183E6CAB0-0x0000000183E6CBC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeOfferingLevelRewardRsp Clone() => default; // 0x0000000183E6BFF0-0x0000000183E6C0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeOfferingLevelRewardRsp ShallowCopy() => default; // 0x0000000183E6BB20-0x0000000183E6BBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E6B350-0x0000000183E6B3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E6C2A0-0x0000000183E6C330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E6C330-0x0000000183E6C3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E6B3A0-0x0000000183E6B4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E6B540-0x0000000183E6B610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeOfferingLevelRewardRsp other) => default; // 0x0000000183E6B610-0x0000000183E6B780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E6BCB0-0x0000000183E6BE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E6C7B0-0x0000000183E6CAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E6C420-0x0000000183E6C5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E6B780-0x0000000183E6B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeOfferingLevelRewardRsp other) {} // 0x0000000183E6B1A0-0x0000000183E6B350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E6AF00-0x0000000183E6B0A0
}

