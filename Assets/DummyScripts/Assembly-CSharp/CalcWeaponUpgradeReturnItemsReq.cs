/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CalcWeaponUpgradeReturnItemsReq : MessageBase, IMessage<CalcWeaponUpgradeReturnItemsReq> // TypeDefIndex: 23764
{
	// Fields
	private static readonly MessageParser<CalcWeaponUpgradeReturnItemsReq> _parser; // 0x00
	public const int TargetWeaponGuidFieldNumber = 1; // Metadata: 0x00B04C67
	private ulong targetWeaponGuid_; // 0x18
	public const int FoodWeaponGuidListFieldNumber = 2; // Metadata: 0x00B04C6B
	private static readonly FieldCodec<ulong> _repeated_foodWeaponGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> foodWeaponGuidList_; // 0x20
	public const int ItemParamListFieldNumber = 3; // Metadata: 0x00B04C6F
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CalcWeaponUpgradeReturnItemsReq> Parser { get => default; } // 0x0000000181A31550-0x0000000181A315E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A312E0-0x0000000181A31370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A30FB0-0x0000000181A31030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A307A0-0x0000000181A30800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A31AB0-0x0000000181A31BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A31830-0x0000000181A31890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A31370-0x0000000181A31460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A31A00-0x0000000181A31A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A310D0-0x0000000181A311C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x0000000181A31670-0x0000000181A31710 0x0000000181A30B70-0x0000000181A30C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> FoodWeaponGuidList { get => default; } // 0x0000000181A30B10-0x0000000181A30B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x0000000181A31A50-0x0000000181A31AB0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23765
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23766
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 661
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CalcWeaponUpgradeReturnItemsReq() {} // 0x0000000181A31F30-0x0000000181A31FE0
	static CalcWeaponUpgradeReturnItemsReq() {} // 0x0000000181A31E00-0x0000000181A31F30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CalcWeaponUpgradeReturnItemsReq Clone() => default; // 0x0000000181A31460-0x0000000181A31550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CalcWeaponUpgradeReturnItemsReq ShallowCopy() => default; // 0x0000000181A31030-0x0000000181A310D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A30980-0x0000000181A309D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A31710-0x0000000181A317A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A317A0-0x0000000181A31830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A309D0-0x0000000181A30B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A30C10-0x0000000181A30CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CalcWeaponUpgradeReturnItemsReq other) => default; // 0x0000000181A30CE0-0x0000000181A30E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A311C0-0x0000000181A312E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A31BA0-0x0000000181A31E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A31890-0x0000000181A31A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A30E30-0x0000000181A30FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CalcWeaponUpgradeReturnItemsReq other) {} // 0x0000000181A30800-0x0000000181A30980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A305C0-0x0000000181A307A0
}

