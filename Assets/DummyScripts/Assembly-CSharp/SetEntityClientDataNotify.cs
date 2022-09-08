/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetEntityClientDataNotify : MessageBase, IMessage<SetEntityClientDataNotify> // TypeDefIndex: 25281
{
	// Fields
	private static readonly MessageParser<SetEntityClientDataNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B085EB
	private uint entityId_; // 0x18
	public const int EntityClientDataFieldNumber = 2; // Metadata: 0x00B085EF
	private EntityClientData entityClientData_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetEntityClientDataNotify> Parser { get => default; } // 0x0000000183A965E0-0x0000000183A96670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A96370-0x0000000183A96400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A95FE0-0x0000000183A96060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A958B0-0x0000000183A95910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A96B10-0x0000000183A96C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A968A0-0x0000000183A96900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A96400-0x0000000183A964F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A96A20-0x0000000183A96A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A96100-0x0000000183A961F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183A96800-0x0000000183A968A0 0x0000000183A96C00-0x0000000183A96CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityClientData EntityClientData { get => default; set {} } // 0x0000000183A956D0-0x0000000183A95770 0x0000000183A96A70-0x0000000183A96B10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25282
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25283
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3041
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEntityClientDataNotify() {} // 0x0000000183A96F40-0x0000000183A96FA0
	static SetEntityClientDataNotify() {} // 0x0000000183A96E80-0x0000000183A96F40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEntityClientDataNotify Clone() => default; // 0x0000000183A964F0-0x0000000183A965E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetEntityClientDataNotify ShallowCopy() => default; // 0x0000000183A96060-0x0000000183A96100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A95A90-0x0000000183A95B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A96700-0x0000000183A96780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A96780-0x0000000183A96800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A95B10-0x0000000183A95C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A95D70-0x0000000183A95E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetEntityClientDataNotify other) => default; // 0x0000000183A95C40-0x0000000183A95D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A961F0-0x0000000183A96370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A96CA0-0x0000000183A96E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A96900-0x0000000183A96A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A95E40-0x0000000183A95FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetEntityClientDataNotify other) {} // 0x0000000183A95910-0x0000000183A95A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A95770-0x0000000183A958B0
}

