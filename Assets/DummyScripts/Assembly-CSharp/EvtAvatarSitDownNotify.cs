/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAvatarSitDownNotify : MessageBase, IMessage<EvtAvatarSitDownNotify> // TypeDefIndex: 23098
{
	// Fields
	private static readonly MessageParser<EvtAvatarSitDownNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B03307
	private uint entityId_; // 0x18
	public const int PositionFieldNumber = 2; // Metadata: 0x00B0330B
	private Vector position_; // 0x20
	public const int ChairIdFieldNumber = 3; // Metadata: 0x00B0330F
	private ulong chairId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAvatarSitDownNotify> Parser { get => default; } // 0x0000000181898130-0x00000001818981C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181897D80-0x0000000181897E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181897920-0x00000001818979A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818970A0-0x0000000181897100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181898600-0x00000001818986F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818983F0-0x0000000181898450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181897E10-0x0000000181897F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818985B0-0x0000000181898600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181897AE0-0x0000000181897BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181898350-0x00000001818983F0 0x00000001818986F0-0x0000000181898790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Position { get => default; set {} } // 0x0000000181897A40-0x0000000181897AE0 0x0000000181898090-0x0000000181898130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ChairId { get => default; set {} } // 0x0000000181897FF0-0x0000000181898090 0x0000000181897100-0x00000001818971A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23099
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23100
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 341
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarSitDownNotify() {} // 0x0000000181898AC0-0x0000000181898B20
	static EvtAvatarSitDownNotify() {} // 0x0000000181898A00-0x0000000181898AC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarSitDownNotify Clone() => default; // 0x0000000181897F00-0x0000000181897FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarSitDownNotify ShallowCopy() => default; // 0x00000001818979A0-0x0000000181897A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181897360-0x00000001818973E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181898250-0x00000001818982D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818982D0-0x0000000181898350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818973E0-0x0000000181897520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181897520-0x00000001818975F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAvatarSitDownNotify other) => default; // 0x00000001818975F0-0x0000000181897740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181897BD0-0x0000000181897D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181898790-0x0000000181898A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181898450-0x00000001818985B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181897740-0x0000000181897920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAvatarSitDownNotify other) {} // 0x00000001818971A0-0x0000000181897360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181896F40-0x00000001818970A0
}

