/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientReconnectNotify : MessageBase, IMessage<ClientReconnectNotify> // TypeDefIndex: 23983
{
	// Fields
	private static readonly MessageParser<ClientReconnectNotify> _parser; // 0x00
	public const int ReasonFieldNumber = 1; // Metadata: 0x00B0548B
	private ClientReconnectReason reason_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientReconnectNotify> Parser { get => default; } // 0x0000000184FC1380-0x0000000184FC1410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184FC1070-0x0000000184FC1100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184FC0D50-0x0000000184FC0DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184FC07C0-0x0000000184FC0820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184FC16D0-0x0000000184FC17C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184FC1540-0x0000000184FC15A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184FC1100-0x0000000184FC11F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184FC1680-0x0000000184FC16D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184FC0E70-0x0000000184FC0F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReconnectReason Reason { get => default; set {} } // 0x0000000184FC12E0-0x0000000184FC1380 0x0000000184FC0980-0x0000000184FC0A20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23984
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23985
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 12
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReconnectNotify() {} // 0x0000000184FC19F0-0x0000000184FC1A60
	static ClientReconnectNotify() {} // 0x0000000184FC1930-0x0000000184FC19F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReconnectNotify Clone() => default; // 0x0000000184FC11F0-0x0000000184FC12E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReconnectNotify ShallowCopy() => default; // 0x0000000184FC0DD0-0x0000000184FC0E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184FC0930-0x0000000184FC0980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FC14A0-0x0000000184FC14F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FC14F0-0x0000000184FC1540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184FC0A20-0x0000000184FC0A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184FC0A90-0x0000000184FC0B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientReconnectNotify other) => default; // 0x0000000184FC0B60-0x0000000184FC0C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184FC0F60-0x0000000184FC1070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184FC17C0-0x0000000184FC1930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184FC15A0-0x0000000184FC1680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184FC0C60-0x0000000184FC0D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientReconnectNotify other) {} // 0x0000000184FC0820-0x0000000184FC0930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184FC06E0-0x0000000184FC07C0
}

