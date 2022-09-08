/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AllSeenMonsterNotify : MessageBase, IMessage<AllSeenMonsterNotify> // TypeDefIndex: 25139
{
	// Fields
	private static readonly MessageParser<AllSeenMonsterNotify> _parser; // 0x00
	public const int MonsterIdListFieldNumber = 1; // Metadata: 0x00B0811B
	private static readonly FieldCodec<uint> _repeated_monsterIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> monsterIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AllSeenMonsterNotify> Parser { get => default; } // 0x0000000185B366B0-0x0000000185B36740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185B36440-0x0000000185B364D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185B36170-0x0000000185B361F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185B35C30-0x0000000185B35C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185B36A80-0x0000000185B36B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185B368D0-0x0000000185B36930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185B364D0-0x0000000185B365C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185B36A30-0x0000000185B36A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185B36290-0x0000000185B36380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MonsterIdList { get => default; } // 0x0000000185B367D0-0x0000000185B36830 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25140
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25141
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 280
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AllSeenMonsterNotify() {} // 0x0000000185B36DA0-0x0000000185B36E30
	static AllSeenMonsterNotify() {} // 0x0000000185B36CC0-0x0000000185B36DA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AllSeenMonsterNotify Clone() => default; // 0x0000000185B365C0-0x0000000185B366B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AllSeenMonsterNotify ShallowCopy() => default; // 0x0000000185B361F0-0x0000000185B36290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185B35DA0-0x0000000185B35DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185B36830-0x0000000185B36880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185B36880-0x0000000185B368D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185B35DF0-0x0000000185B35EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185B35EB0-0x0000000185B35F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AllSeenMonsterNotify other) => default; // 0x0000000185B35F80-0x0000000185B36080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185B36380-0x0000000185B36440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185B36B70-0x0000000185B36CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185B36930-0x0000000185B36A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185B36080-0x0000000185B36170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AllSeenMonsterNotify other) {} // 0x0000000185B35C90-0x0000000185B35DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185B35AF0-0x0000000185B35C30
}

