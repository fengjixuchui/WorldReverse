/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddSeenMonsterNotify : MessageBase, IMessage<AddSeenMonsterNotify> // TypeDefIndex: 25136
{
	// Fields
	private static readonly MessageParser<AddSeenMonsterNotify> _parser; // 0x00
	public const int MonsterIdListFieldNumber = 1; // Metadata: 0x00B08103
	private static readonly FieldCodec<uint> _repeated_monsterIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> monsterIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddSeenMonsterNotify> Parser { get => default; } // 0x0000000181A9C340-0x0000000181A9C3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A9C0D0-0x0000000181A9C160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A9BE00-0x0000000181A9BE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A9B8C0-0x0000000181A9B920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A9C710-0x0000000181A9C800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A9C560-0x0000000181A9C5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A9C160-0x0000000181A9C250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A9C6C0-0x0000000181A9C710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A9BF20-0x0000000181A9C010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MonsterIdList { get => default; } // 0x0000000181A9C460-0x0000000181A9C4C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25137
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25138
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 279
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddSeenMonsterNotify() {} // 0x0000000181A9CA30-0x0000000181A9CAC0
	static AddSeenMonsterNotify() {} // 0x0000000181A9C950-0x0000000181A9CA30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddSeenMonsterNotify Clone() => default; // 0x0000000181A9C250-0x0000000181A9C340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddSeenMonsterNotify ShallowCopy() => default; // 0x0000000181A9BE80-0x0000000181A9BF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A9BA30-0x0000000181A9BA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A9C4C0-0x0000000181A9C510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A9C510-0x0000000181A9C560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A9BA80-0x0000000181A9BB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A9BC40-0x0000000181A9BD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddSeenMonsterNotify other) => default; // 0x0000000181A9BB40-0x0000000181A9BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A9C010-0x0000000181A9C0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A9C800-0x0000000181A9C950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A9C5C0-0x0000000181A9C6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A9BD10-0x0000000181A9BE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddSeenMonsterNotify other) {} // 0x0000000181A9B920-0x0000000181A9BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A9B780-0x0000000181A9B8C0
}

