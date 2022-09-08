/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientAIStateNotify : MessageBase, IMessage<ClientAIStateNotify> // TypeDefIndex: 21825
{
	// Fields
	private static readonly MessageParser<ClientAIStateNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B00147
	private uint entityId_; // 0x18
	public const int CurTacticFieldNumber = 2; // Metadata: 0x00B0014B
	private uint curTactic_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientAIStateNotify> Parser { get => default; } // 0x0000000181EE5E10-0x0000000181EE5EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EE5BA0-0x0000000181EE5C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EE57F0-0x0000000181EE5870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EE51E0-0x0000000181EE5240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EE6240-0x0000000181EE6330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EE6070-0x0000000181EE60D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EE5C30-0x0000000181EE5D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EE61F0-0x0000000181EE6240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EE59B0-0x0000000181EE5AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181EE5FD0-0x0000000181EE6070 0x0000000181EE6330-0x0000000181EE63D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurTactic { get => default; set {} } // 0x0000000181EE5430-0x0000000181EE54D0 0x0000000181EE5870-0x0000000181EE5910

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21826
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21827
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1115
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAIStateNotify() {} // 0x0000000181EE6690-0x0000000181EE66F0
	static ClientAIStateNotify() {} // 0x0000000181EE65D0-0x0000000181EE6690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAIStateNotify Clone() => default; // 0x0000000181EE5D20-0x0000000181EE5E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAIStateNotify ShallowCopy() => default; // 0x0000000181EE5910-0x0000000181EE59B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EE5370-0x0000000181EE53C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EE5F30-0x0000000181EE5F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EE5F80-0x0000000181EE5FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EE53C0-0x0000000181EE5430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EE54D0-0x0000000181EE55A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientAIStateNotify other) => default; // 0x0000000181EE55A0-0x0000000181EE56C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EE5AA0-0x0000000181EE5BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EE63D0-0x0000000181EE65D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EE60D0-0x0000000181EE61F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EE56C0-0x0000000181EE57F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientAIStateNotify other) {} // 0x0000000181EE5240-0x0000000181EE5370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181EE50E0-0x0000000181EE51E0
}

