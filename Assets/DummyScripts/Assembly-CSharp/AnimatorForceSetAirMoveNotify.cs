/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorForceSetAirMoveNotify : MessageBase, IMessage<AnimatorForceSetAirMoveNotify> // TypeDefIndex: 23088
{
	// Fields
	private static readonly MessageParser<AnimatorForceSetAirMoveNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B032AB
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B032AF
	private uint entityId_; // 0x1C
	public const int InAirMoveFieldNumber = 3; // Metadata: 0x00B032B3
	private bool inAirMove_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnimatorForceSetAirMoveNotify> Parser { get => default; } // 0x0000000182968410-0x00000001829684A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182968100-0x0000000182968190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182967D80-0x0000000182967E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182967650-0x00000001829676B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182968920-0x0000000182968A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182968710-0x0000000182968770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182968190-0x0000000182968280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829688D0-0x0000000182968920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182967EA0-0x0000000182967F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000182967CE0-0x0000000182967D80 0x0000000182967860-0x0000000182967900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182968670-0x0000000182968710 0x0000000182968A10-0x0000000182968AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool InAirMove { get => default; set {} } // 0x00000001829685D0-0x0000000182968670 0x0000000182968370-0x0000000182968410

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23089
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23090
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 335
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorForceSetAirMoveNotify() {} // 0x0000000182968E00-0x0000000182968E70
	static AnimatorForceSetAirMoveNotify() {} // 0x0000000182968D40-0x0000000182968E00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorForceSetAirMoveNotify Clone() => default; // 0x0000000182968280-0x0000000182968370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorForceSetAirMoveNotify ShallowCopy() => default; // 0x0000000182967E00-0x0000000182967EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182967810-0x0000000182967860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182968530-0x0000000182968580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182968580-0x00000001829685D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182967900-0x0000000182967980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182967AC0-0x0000000182967B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnimatorForceSetAirMoveNotify other) => default; // 0x0000000182967980-0x0000000182967AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182967F90-0x0000000182968100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182968AB0-0x0000000182968D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182968770-0x00000001829688D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182967B90-0x0000000182967CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnimatorForceSetAirMoveNotify other) {} // 0x00000001829676B0-0x0000000182967810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182967540-0x0000000182967650
}

