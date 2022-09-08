/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterPointArrayRouteUpdateNotify : MessageBase, IMessage<MonsterPointArrayRouteUpdateNotify> // TypeDefIndex: 25340
{
	// Fields
	private static readonly MessageParser<MonsterPointArrayRouteUpdateNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B087EF
	private uint entityId_; // 0x18
	public const int MonsterRouteFieldNumber = 2; // Metadata: 0x00B087F3
	private MonsterRoute monsterRoute_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MonsterPointArrayRouteUpdateNotify> Parser { get => default; } // 0x0000000183D45CB0-0x0000000183D45D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D459A0-0x0000000183D45A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D45610-0x0000000183D45690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D44EE0-0x0000000183D44F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D46140-0x0000000183D46230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D45F70-0x0000000183D45FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D45AD0-0x0000000183D45BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D460F0-0x0000000183D46140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D45730-0x0000000183D45820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183D45ED0-0x0000000183D45F70 0x0000000183D46230-0x0000000183D462D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterRoute MonsterRoute { get => default; set {} } // 0x0000000183D462D0-0x0000000183D46370 0x0000000183D45A30-0x0000000183D45AD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25341
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25342
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3061
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterPointArrayRouteUpdateNotify() {} // 0x0000000183D46610-0x0000000183D46670
	static MonsterPointArrayRouteUpdateNotify() {} // 0x0000000183D46550-0x0000000183D46610

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterPointArrayRouteUpdateNotify Clone() => default; // 0x0000000183D45BC0-0x0000000183D45CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterPointArrayRouteUpdateNotify ShallowCopy() => default; // 0x0000000183D45690-0x0000000183D45730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D450C0-0x0000000183D45140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D45DD0-0x0000000183D45E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D45E50-0x0000000183D45ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D45140-0x0000000183D45270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D453A0-0x0000000183D45470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MonsterPointArrayRouteUpdateNotify other) => default; // 0x0000000183D45270-0x0000000183D453A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D45820-0x0000000183D459A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D46370-0x0000000183D46550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D45FD0-0x0000000183D460F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D45470-0x0000000183D45610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MonsterPointArrayRouteUpdateNotify other) {} // 0x0000000183D44F40-0x0000000183D450C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D44DA0-0x0000000183D44EE0
}

