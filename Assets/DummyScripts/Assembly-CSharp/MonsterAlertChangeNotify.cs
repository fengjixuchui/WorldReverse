/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterAlertChangeNotify : MessageBase, IMessage<MonsterAlertChangeNotify> // TypeDefIndex: 23073
{
	// Fields
	private static readonly MessageParser<MonsterAlertChangeNotify> _parser; // 0x00
	public const int AvatarEntityIdFieldNumber = 2; // Metadata: 0x00B03213
	private uint avatarEntityId_; // 0x18
	public const int IsAlertFieldNumber = 3; // Metadata: 0x00B03217
	private uint isAlert_; // 0x1C
	public const int MonsterEntityListFieldNumber = 4; // Metadata: 0x00B0321B
	private static readonly FieldCodec<uint> _repeated_monsterEntityList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> monsterEntityList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MonsterAlertChangeNotify> Parser { get => default; } // 0x0000000183A94CA0-0x0000000183A94D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A948F0-0x0000000183A94980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A945B0-0x0000000183A94630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A93DF0-0x0000000183A93E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A95080-0x0000000183A95170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A94E60-0x0000000183A94EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A94AC0-0x0000000183A94BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A95030-0x0000000183A95080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A946D0-0x0000000183A947C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarEntityId { get => default; set {} } // 0x0000000183A94510-0x0000000183A945B0 0x0000000183A94980-0x0000000183A94A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint IsAlert { get => default; set {} } // 0x0000000183A93FB0-0x0000000183A94050 0x0000000183A94A20-0x0000000183A94AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MonsterEntityList { get => default; } // 0x0000000183A95170-0x0000000183A951D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23074
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23075
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 329
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterAlertChangeNotify() {} // 0x0000000183A95520-0x0000000183A955B0
	static MonsterAlertChangeNotify() {} // 0x0000000183A95440-0x0000000183A95520

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterAlertChangeNotify Clone() => default; // 0x0000000183A94BB0-0x0000000183A94CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterAlertChangeNotify ShallowCopy() => default; // 0x0000000183A94630-0x0000000183A946D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A94050-0x0000000183A940A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A94DC0-0x0000000183A94E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A94E10-0x0000000183A94E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A940A0-0x0000000183A94170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A94170-0x0000000183A94240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MonsterAlertChangeNotify other) => default; // 0x0000000183A94240-0x0000000183A94380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A947C0-0x0000000183A948F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A951D0-0x0000000183A95440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A94EC0-0x0000000183A95030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A94380-0x0000000183A94510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MonsterAlertChangeNotify other) {} // 0x0000000183A93E50-0x0000000183A93FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A93C70-0x0000000183A93DF0
}

