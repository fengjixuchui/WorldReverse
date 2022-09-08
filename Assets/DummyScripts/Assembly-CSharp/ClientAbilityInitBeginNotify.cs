/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientAbilityInitBeginNotify : MessageBase, IMessage<ClientAbilityInitBeginNotify> // TypeDefIndex: 21792
{
	// Fields
	private static readonly MessageParser<ClientAbilityInitBeginNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B00017
	private uint entityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientAbilityInitBeginNotify> Parser { get => default; } // 0x0000000182BD8630-0x0000000182BD86C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BD83C0-0x0000000182BD8450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BD80D0-0x0000000182BD8150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BD7BE0-0x0000000182BD7C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BD8A20-0x0000000182BD8B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BD8890-0x0000000182BD88F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BD8450-0x0000000182BD8540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BD89D0-0x0000000182BD8A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BD81F0-0x0000000182BD82E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182BD87F0-0x0000000182BD8890 0x0000000182BD8B10-0x0000000182BD8BB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21793
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21794
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1103
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityInitBeginNotify() {} // 0x0000000182BD8DE0-0x0000000182BD8E40
	static ClientAbilityInitBeginNotify() {} // 0x0000000182BD8D20-0x0000000182BD8DE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityInitBeginNotify Clone() => default; // 0x0000000182BD8540-0x0000000182BD8630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityInitBeginNotify ShallowCopy() => default; // 0x0000000182BD8150-0x0000000182BD81F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BD7D50-0x0000000182BD7DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BD8750-0x0000000182BD87A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BD87A0-0x0000000182BD87F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BD7DA0-0x0000000182BD7E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BD7F10-0x0000000182BD7FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientAbilityInitBeginNotify other) => default; // 0x0000000182BD7E10-0x0000000182BD7F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BD82E0-0x0000000182BD83C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BD8BB0-0x0000000182BD8D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BD88F0-0x0000000182BD89D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BD7FE0-0x0000000182BD80D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientAbilityInitBeginNotify other) {} // 0x0000000182BD7C40-0x0000000182BD7D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BD7B00-0x0000000182BD7BE0
}

