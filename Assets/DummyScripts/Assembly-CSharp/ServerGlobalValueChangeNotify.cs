/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerGlobalValueChangeNotify : MessageBase, IMessage<ServerGlobalValueChangeNotify> // TypeDefIndex: 21822
{
	// Fields
	private static readonly MessageParser<ServerGlobalValueChangeNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0012B
	private uint entityId_; // 0x18
	public const int KeyHashFieldNumber = 2; // Metadata: 0x00B0012F
	private uint keyHash_; // 0x1C
	public const int ValueFieldNumber = 3; // Metadata: 0x00B00133
	private float value_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerGlobalValueChangeNotify> Parser { get => default; } // 0x0000000181C76540-0x0000000181C765D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C76190-0x0000000181C76220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C75E40-0x0000000181C75EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C757B0-0x0000000181C75810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C76A50-0x0000000181C76B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C76840-0x0000000181C768A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C76360-0x0000000181C76450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C76A00-0x0000000181C76A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C75F60-0x0000000181C76050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181C767A0-0x0000000181C76840 0x0000000181C76B40-0x0000000181C76BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint KeyHash { get => default; set {} } // 0x0000000181C76220-0x0000000181C762C0 0x0000000181C75970-0x0000000181C75A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Value { get => default; set {} } // 0x0000000181C762C0-0x0000000181C76360 0x0000000181C766B0-0x0000000181C76750

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21823
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21824
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1114
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerGlobalValueChangeNotify() {} // 0x0000000181C76F30-0x0000000181C76F90
	static ServerGlobalValueChangeNotify() {} // 0x0000000181C76E70-0x0000000181C76F30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerGlobalValueChangeNotify Clone() => default; // 0x0000000181C76450-0x0000000181C76540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerGlobalValueChangeNotify ShallowCopy() => default; // 0x0000000181C75EC0-0x0000000181C75F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C75A10-0x0000000181C75A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C76660-0x0000000181C766B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C76750-0x0000000181C767A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C75A60-0x0000000181C75AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C75AE0-0x0000000181C75BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerGlobalValueChangeNotify other) => default; // 0x0000000181C75BB0-0x0000000181C75CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C76050-0x0000000181C76190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C76BE0-0x0000000181C76E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C768A0-0x0000000181C76A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C75CF0-0x0000000181C75E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerGlobalValueChangeNotify other) {} // 0x0000000181C75810-0x0000000181C75970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C756A0-0x0000000181C757B0
}

