/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CalcWeaponUpgradeReturnItemsRsp : MessageBase, IMessage<CalcWeaponUpgradeReturnItemsRsp> // TypeDefIndex: 23767
{
	// Fields
	private static readonly MessageParser<CalcWeaponUpgradeReturnItemsRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04C87
	private int retcode_; // 0x18
	public const int TargetWeaponGuidFieldNumber = 2; // Metadata: 0x00B04C8B
	private ulong targetWeaponGuid_; // 0x20
	public const int ItemParamListFieldNumber = 3; // Metadata: 0x00B04C8F
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CalcWeaponUpgradeReturnItemsRsp> Parser { get => default; } // 0x0000000183D99EE0-0x0000000183D99F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D99C70-0x0000000183D99D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D99930-0x0000000183D999B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D99070-0x0000000183D990D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D9A450-0x0000000183D9A540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D9A1C0-0x0000000183D9A220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D99D00-0x0000000183D99DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D9A3A0-0x0000000183D9A3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D99A50-0x0000000183D99B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183D99890-0x0000000183D99930 0x0000000183D993A0-0x0000000183D99440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x0000000183D9A000-0x0000000183D9A0A0 0x0000000183D99440-0x0000000183D994E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x0000000183D9A3F0-0x0000000183D9A450 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23768
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23769
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 662
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CalcWeaponUpgradeReturnItemsRsp() {} // 0x0000000183D9A8C0-0x0000000183D9A950
	static CalcWeaponUpgradeReturnItemsRsp() {} // 0x0000000183D9A7B0-0x0000000183D9A8C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CalcWeaponUpgradeReturnItemsRsp Clone() => default; // 0x0000000183D99DF0-0x0000000183D99EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CalcWeaponUpgradeReturnItemsRsp ShallowCopy() => default; // 0x0000000183D999B0-0x0000000183D99A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D99260-0x0000000183D992B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D9A0A0-0x0000000183D9A130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D9A130-0x0000000183D9A1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D992B0-0x0000000183D993A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D994E0-0x0000000183D995B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CalcWeaponUpgradeReturnItemsRsp other) => default; // 0x0000000183D995B0-0x0000000183D99700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D99B40-0x0000000183D99C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D9A540-0x0000000183D9A7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D9A220-0x0000000183D9A3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D99700-0x0000000183D99890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CalcWeaponUpgradeReturnItemsRsp other) {} // 0x0000000183D990D0-0x0000000183D99260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D98EF0-0x0000000183D99070
}

