/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DestroyMassiveEntityNotify : MessageBase, IMessage<DestroyMassiveEntityNotify> // TypeDefIndex: 23113
{
	// Fields
	private static readonly MessageParser<DestroyMassiveEntityNotify> _parser; // 0x00
	public const int MassiveEntityListFieldNumber = 1; // Metadata: 0x00B0338B
	private static readonly FieldCodec<ClientMassiveEntity> _repeated_massiveEntityList_codec; // 0x08
	private readonly RepeatedMessageField<ClientMassiveEntity> massiveEntityList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DestroyMassiveEntityNotify> Parser { get => default; } // 0x0000000184EBB4D0-0x0000000184EBB560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184EBB260-0x0000000184EBB2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184EBAF90-0x0000000184EBB010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184EBA9B0-0x0000000184EBAA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EBB8C0-0x0000000184EBB9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184EBB710-0x0000000184EBB770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184EBB2F0-0x0000000184EBB3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EBB870-0x0000000184EBB8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184EBB0B0-0x0000000184EBB1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ClientMassiveEntity> MassiveEntityList { get => default; } // 0x0000000184EBAA10-0x0000000184EBAA70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23114
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23115
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 346
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DestroyMassiveEntityNotify() {} // 0x0000000184EBBC10-0x0000000184EBBCA0
	static DestroyMassiveEntityNotify() {} // 0x0000000184EBBB00-0x0000000184EBBC10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DestroyMassiveEntityNotify Clone() => default; // 0x0000000184EBB3E0-0x0000000184EBB4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DestroyMassiveEntityNotify ShallowCopy() => default; // 0x0000000184EBB010-0x0000000184EBB0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184EBABA0-0x0000000184EBABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EBB5F0-0x0000000184EBB680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EBB680-0x0000000184EBB710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184EBABF0-0x0000000184EBACC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184EBADD0-0x0000000184EBAEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DestroyMassiveEntityNotify other) => default; // 0x0000000184EBACC0-0x0000000184EBADD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184EBB1A0-0x0000000184EBB260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EBB9B0-0x0000000184EBBB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184EBB770-0x0000000184EBB870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184EBAEA0-0x0000000184EBAF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DestroyMassiveEntityNotify other) {} // 0x0000000184EBAA70-0x0000000184EBABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184EBA880-0x0000000184EBA9B0
}

