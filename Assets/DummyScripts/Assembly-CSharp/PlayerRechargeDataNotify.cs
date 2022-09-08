/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerRechargeDataNotify : MessageBase, IMessage<PlayerRechargeDataNotify> // TypeDefIndex: 24707
{
	// Fields
	private static readonly MessageParser<PlayerRechargeDataNotify> _parser; // 0x00
	public const int CardProductRemainDaysFieldNumber = 1; // Metadata: 0x00B070BF
	private uint cardProductRemainDays_; // 0x18
	public const int ProductPriceTierListFieldNumber = 2; // Metadata: 0x00B070C3
	private static readonly FieldCodec<ProductPriceTier> _repeated_productPriceTierList_codec; // 0x08
	private readonly RepeatedMessageField<ProductPriceTier> productPriceTierList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerRechargeDataNotify> Parser { get => default; } // 0x0000000183703570-0x0000000183703600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183703300-0x0000000183703390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183702F50-0x0000000183702FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183702880-0x00000001837028E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183703A00-0x0000000183703AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183703810-0x0000000183703870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183703390-0x0000000183703480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837039B0-0x0000000183703A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183703110-0x0000000183703200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardProductRemainDays { get => default; set {} } // 0x00000001837028E0-0x0000000183702980 0x0000000183702FD0-0x0000000183703070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ProductPriceTier> ProductPriceTierList { get => default; } // 0x00000001837037B0-0x0000000183703810 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24708
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24709
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4105
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerRechargeDataNotify() {} // 0x0000000183703DE0-0x0000000183703E70
	static PlayerRechargeDataNotify() {} // 0x0000000183703CD0-0x0000000183703DE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerRechargeDataNotify Clone() => default; // 0x0000000183703480-0x0000000183703570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerRechargeDataNotify ShallowCopy() => default; // 0x0000000183703070-0x0000000183703110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183702AE0-0x0000000183702B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183703690-0x0000000183703720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183703720-0x00000001837037B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183702B30-0x0000000183702C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183702C10-0x0000000183702CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerRechargeDataNotify other) => default; // 0x0000000183702CE0-0x0000000183702E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183703200-0x0000000183703300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183703AF0-0x0000000183703CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183703870-0x00000001837039B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183702E10-0x0000000183702F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerRechargeDataNotify other) {} // 0x0000000183702980-0x0000000183702AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183702720-0x0000000183702880
}

