/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityChangeNotify : MessageBase, IMessage<AbilityChangeNotify> // TypeDefIndex: 21812
{
	// Fields
	private static readonly MessageParser<AbilityChangeNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B000CF
	private uint entityId_; // 0x18
	public const int AbilityControlBlockFieldNumber = 2; // Metadata: 0x00B000D3
	private AbilityControlBlock abilityControlBlock_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityChangeNotify> Parser { get => default; } // 0x0000000183CC1270-0x0000000183CC1300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CC1000-0x0000000183CC1090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CC0C70-0x0000000183CC0CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CC04A0-0x0000000183CC0500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CC1700-0x0000000183CC17F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CC1530-0x0000000183CC1590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CC1090-0x0000000183CC1180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CC16B0-0x0000000183CC1700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CC0D90-0x0000000183CC0E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183CC1490-0x0000000183CC1530 0x0000000183CC17F0-0x0000000183CC1890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityControlBlock AbilityControlBlock { get => default; set {} } // 0x0000000183CC0830-0x0000000183CC08D0 0x0000000183CC0400-0x0000000183CC04A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21813
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21814
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1111
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityChangeNotify() {} // 0x0000000183CC1B30-0x0000000183CC1B90
	static AbilityChangeNotify() {} // 0x0000000183CC1A70-0x0000000183CC1B30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityChangeNotify Clone() => default; // 0x0000000183CC1180-0x0000000183CC1270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityChangeNotify ShallowCopy() => default; // 0x0000000183CC0CF0-0x0000000183CC0D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CC0680-0x0000000183CC0700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CC1390-0x0000000183CC1410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CC1410-0x0000000183CC1490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CC0700-0x0000000183CC0830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CC08D0-0x0000000183CC09A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityChangeNotify other) => default; // 0x0000000183CC09A0-0x0000000183CC0AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CC0E80-0x0000000183CC1000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CC1890-0x0000000183CC1A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CC1590-0x0000000183CC16B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CC0AD0-0x0000000183CC0C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityChangeNotify other) {} // 0x0000000183CC0500-0x0000000183CC0680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CC02C0-0x0000000183CC0400
}

