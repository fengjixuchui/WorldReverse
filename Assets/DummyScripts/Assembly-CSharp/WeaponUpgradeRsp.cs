/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WeaponUpgradeRsp : MessageBase, IMessage<WeaponUpgradeRsp> // TypeDefIndex: 23654
{
	// Fields
	private static readonly MessageParser<WeaponUpgradeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04847
	private int retcode_; // 0x18
	public const int TargetWeaponGuidFieldNumber = 2; // Metadata: 0x00B0484B
	private ulong targetWeaponGuid_; // 0x20
	public const int OldLevelFieldNumber = 3; // Metadata: 0x00B0484F
	private uint oldLevel_; // 0x28
	public const int CurLevelFieldNumber = 4; // Metadata: 0x00B04853
	private uint curLevel_; // 0x2C
	public const int ItemParamListFieldNumber = 5; // Metadata: 0x00B04857
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WeaponUpgradeRsp> Parser { get => default; } // 0x0000000181D54D30-0x0000000181D54DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D54980-0x0000000181D54A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D545E0-0x0000000181D54660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D53BF0-0x0000000181D53C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D553B0-0x0000000181D554A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D55010-0x0000000181D55070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D54A10-0x0000000181D54B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D55300-0x0000000181D55350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D54700-0x0000000181D547F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181D54540-0x0000000181D545E0 0x0000000181D53F80-0x0000000181D54020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x0000000181D54E50-0x0000000181D54EF0 0x0000000181D54020-0x0000000181D540C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldLevel { get => default; set {} } // 0x0000000181D54C90-0x0000000181D54D30 0x0000000181D54BF0-0x0000000181D54C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurLevel { get => default; set {} } // 0x0000000181D53B50-0x0000000181D53BF0 0x0000000181D55070-0x0000000181D55110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x0000000181D55350-0x0000000181D553B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23655
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23656
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 620
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponUpgradeRsp() {} // 0x0000000181D55940-0x0000000181D559D0
	static WeaponUpgradeRsp() {} // 0x0000000181D55830-0x0000000181D55940

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponUpgradeRsp Clone() => default; // 0x0000000181D54B00-0x0000000181D54BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponUpgradeRsp ShallowCopy() => default; // 0x0000000181D54660-0x0000000181D54700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D53E20-0x0000000181D53E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D54EF0-0x0000000181D54F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D54F80-0x0000000181D55010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D53E70-0x0000000181D53F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D540C0-0x0000000181D54190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WeaponUpgradeRsp other) => default; // 0x0000000181D54190-0x0000000181D54320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D547F0-0x0000000181D54980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D554A0-0x0000000181D55830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D55110-0x0000000181D55300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D54320-0x0000000181D54540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WeaponUpgradeRsp other) {} // 0x0000000181D53C50-0x0000000181D53E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D53990-0x0000000181D53B50
}

