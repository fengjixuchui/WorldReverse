/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientTriggerEventNotify : MessageBase, IMessage<ClientTriggerEventNotify> // TypeDefIndex: 24336
{
	// Fields
	private static readonly MessageParser<ClientTriggerEventNotify> _parser; // 0x00
	public const int EventTypeFieldNumber = 1; // Metadata: 0x00B0639B
	private EventTriggerType eventType_; // 0x18
	public const int ForceIdFieldNumber = 2; // Metadata: 0x00B0639F
	private uint forceId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientTriggerEventNotify> Parser { get => default; } // 0x000000018207FC30-0x000000018207FCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018207F920-0x000000018207F9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018207F5C0-0x000000018207F640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018207EE70-0x000000018207EED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018207FFC0-0x00000001820800B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018207FDF0-0x000000018207FE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018207F9B0-0x000000018207FAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018207FF70-0x000000018207FFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018207F6E0-0x000000018207F7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EventTriggerType EventType { get => default; set {} } // 0x000000018207F480-0x000000018207F520 0x000000018207FB90-0x000000018207FC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForceId { get => default; set {} } // 0x000000018207F2B0-0x000000018207F350 0x000000018207F520-0x000000018207F5C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24337
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24338
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 113
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTriggerEventNotify() {} // 0x0000000182080370-0x00000001820803E0
	static ClientTriggerEventNotify() {} // 0x00000001820802B0-0x0000000182080370

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTriggerEventNotify Clone() => default; // 0x000000018207FAA0-0x000000018207FB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTriggerEventNotify ShallowCopy() => default; // 0x000000018207F640-0x000000018207F6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018207F000-0x000000018207F050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018207FD50-0x000000018207FDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018207FDA0-0x000000018207FDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018207F050-0x000000018207F0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018207F0C0-0x000000018207F190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientTriggerEventNotify other) => default; // 0x000000018207F190-0x000000018207F2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018207F7D0-0x000000018207F920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820800B0-0x00000001820802B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018207FE50-0x000000018207FF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018207F350-0x000000018207F480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientTriggerEventNotify other) {} // 0x000000018207EED0-0x000000018207F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018207ED80-0x000000018207EE70
}

