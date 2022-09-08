/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCostStaminaNotify : MessageBase, IMessage<EvtCostStaminaNotify> // TypeDefIndex: 23019
{
	// Fields
	private static readonly MessageParser<EvtCostStaminaNotify> _parser; // 0x00
	public const int CostStaminaFieldNumber = 1; // Metadata: 0x00B02F5F
	private float costStamina_; // 0x18
	public const int SkillIdFieldNumber = 2; // Metadata: 0x00B02F63
	private uint skillId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtCostStaminaNotify> Parser { get => default; } // 0x00000001812F09A0-0x00000001812F0A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812F0690-0x00000001812F0720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001812F0220-0x00000001812F02A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001812EFCC0-0x00000001812EFD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001812F0DD0-0x00000001812F0EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001812F0C00-0x00000001812F0C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001812F07C0-0x00000001812F08B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001812F0D80-0x00000001812F0DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001812F03E0-0x00000001812F04D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float CostStamina { get => default; set {} } // 0x00000001812F05F0-0x00000001812F0690 0x00000001812F0B10-0x00000001812F0BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x00000001812F0340-0x00000001812F03E0 0x00000001812F0720-0x00000001812F07C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23020
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23021
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 309
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCostStaminaNotify() {} // 0x00000001812F1180-0x00000001812F11E0
	static EvtCostStaminaNotify() {} // 0x00000001812F10C0-0x00000001812F1180

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCostStaminaNotify Clone() => default; // 0x00000001812F08B0-0x00000001812F09A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCostStaminaNotify ShallowCopy() => default; // 0x00000001812F02A0-0x00000001812F0340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001812EFE60-0x00000001812EFEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812F0AC0-0x00000001812F0B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812F0BB0-0x00000001812F0C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812EFEB0-0x00000001812EFF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001812F0050-0x00000001812F0120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtCostStaminaNotify other) => default; // 0x00000001812EFF30-0x00000001812F0050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001812F04D0-0x00000001812F05F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001812F0EC0-0x00000001812F10C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001812F0C60-0x00000001812F0D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001812F0120-0x00000001812F0220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtCostStaminaNotify other) {} // 0x00000001812EFD20-0x00000001812EFE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001812EFBC0-0x00000001812EFCC0
}

