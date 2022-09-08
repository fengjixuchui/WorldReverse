/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityConfigHashNotify : MessageBase, IMessage<EntityConfigHashNotify> // TypeDefIndex: 25334
{
	// Fields
	private static readonly MessageParser<EntityConfigHashNotify> _parser; // 0x00
	public const int AbilityEntryListFieldNumber = 1; // Metadata: 0x00B087A7
	private static readonly FieldCodec<EntityConfigHashEntry> _repeated_abilityEntryList_codec; // 0x08
	private readonly RepeatedMessageField<EntityConfigHashEntry> abilityEntryList_; // 0x18
	public const int CombatEntryListFieldNumber = 2; // Metadata: 0x00B087AB
	private static readonly FieldCodec<EntityConfigHashEntry> _repeated_combatEntryList_codec; // 0x10
	private readonly RepeatedMessageField<EntityConfigHashEntry> combatEntryList_; // 0x20
	public const int AvatarEntryListFieldNumber = 3; // Metadata: 0x00B087AF
	private static readonly FieldCodec<EntityConfigHashEntry> _repeated_avatarEntryList_codec; // 0x18
	private readonly RepeatedMessageField<EntityConfigHashEntry> avatarEntryList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityConfigHashNotify> Parser { get => default; } // 0x00000001829947B0-0x0000000182994840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829944E0-0x0000000182994570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001829941B0-0x0000000182994230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182993A30-0x0000000182993A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182994C60-0x0000000182994D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182994A50-0x0000000182994AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829945D0-0x00000001829946C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182994C10-0x0000000182994C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001829942D0-0x00000001829943C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityConfigHashEntry> AbilityEntryList { get => default; } // 0x0000000182993DD0-0x0000000182993E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityConfigHashEntry> CombatEntryList { get => default; } // 0x00000001829939D0-0x0000000182993A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityConfigHashEntry> AvatarEntryList { get => default; } // 0x0000000182994570-0x00000001829945D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25335
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25336
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3059
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityConfigHashNotify() {} // 0x00000001829950F0-0x00000001829951C0
	static EntityConfigHashNotify() {} // 0x0000000182994F80-0x00000001829950F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityConfigHashNotify Clone() => default; // 0x00000001829946C0-0x00000001829947B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityConfigHashNotify ShallowCopy() => default; // 0x0000000182994230-0x00000001829942D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182993C10-0x0000000182993C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829948D0-0x0000000182994990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182994990-0x0000000182994A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182993C60-0x0000000182993DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182993E30-0x0000000182993F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityConfigHashNotify other) => default; // 0x0000000182993F00-0x0000000182994060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001829943C0-0x00000001829944E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182994D50-0x0000000182994F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182994AB0-0x0000000182994C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182994060-0x00000001829941B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityConfigHashNotify other) {} // 0x0000000182993A90-0x0000000182993C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829937C0-0x00000001829939D0
}

