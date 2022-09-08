/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WeaponUpgradeReq : MessageBase, IMessage<WeaponUpgradeReq> // TypeDefIndex: 23651
{
	// Fields
	private static readonly MessageParser<WeaponUpgradeReq> _parser; // 0x00
	public const int TargetWeaponGuidFieldNumber = 1; // Metadata: 0x00B04827
	private ulong targetWeaponGuid_; // 0x18
	public const int FoodWeaponGuidListFieldNumber = 2; // Metadata: 0x00B0482B
	private static readonly FieldCodec<ulong> _repeated_foodWeaponGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> foodWeaponGuidList_; // 0x20
	public const int ItemParamListFieldNumber = 3; // Metadata: 0x00B0482F
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WeaponUpgradeReq> Parser { get => default; } // 0x00000001820B7190-0x00000001820B7220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820B6F20-0x00000001820B6FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820B6BF0-0x00000001820B6C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820B63E0-0x00000001820B6440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820B76F0-0x00000001820B77E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820B7470-0x00000001820B74D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820B6FB0-0x00000001820B70A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820B7640-0x00000001820B7690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820B6D10-0x00000001820B6E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x00000001820B72B0-0x00000001820B7350 0x00000001820B67B0-0x00000001820B6850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> FoodWeaponGuidList { get => default; } // 0x00000001820B6750-0x00000001820B67B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x00000001820B7690-0x00000001820B76F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23652
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23653
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 619
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponUpgradeReq() {} // 0x00000001820B7B70-0x00000001820B7C20
	static WeaponUpgradeReq() {} // 0x00000001820B7A40-0x00000001820B7B70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponUpgradeReq Clone() => default; // 0x00000001820B70A0-0x00000001820B7190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponUpgradeReq ShallowCopy() => default; // 0x00000001820B6C70-0x00000001820B6D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820B65C0-0x00000001820B6610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820B7350-0x00000001820B73E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820B73E0-0x00000001820B7470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820B6610-0x00000001820B6750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820B69A0-0x00000001820B6A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WeaponUpgradeReq other) => default; // 0x00000001820B6850-0x00000001820B69A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820B6E00-0x00000001820B6F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820B77E0-0x00000001820B7A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820B74D0-0x00000001820B7640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820B6A70-0x00000001820B6BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WeaponUpgradeReq other) {} // 0x00000001820B6440-0x00000001820B65C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820B6200-0x00000001820B63E0
}

