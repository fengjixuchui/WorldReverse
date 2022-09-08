/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAiSyncCombatThreatInfoNotify : MessageBase, IMessage<EvtAiSyncCombatThreatInfoNotify> // TypeDefIndex: 23135
{
	// Fields
	private static readonly MessageParser<EvtAiSyncCombatThreatInfoNotify> _parser; // 0x00
	public const int CombatThreatInfoMapFieldNumber = 1; // Metadata: 0x00B03443
	private static readonly MapField<uint, AiThreatInfo> _map_combatThreatInfoMap_codec; // 0x08
	private readonly MapField<uint, AiThreatInfo> combatThreatInfoMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAiSyncCombatThreatInfoNotify> Parser { get => default; } // 0x00000001854AAE20-0x00000001854AAEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001854AABB0-0x00000001854AAC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001854AA8B0-0x00000001854AA930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001854AA2A0-0x00000001854AA300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001854AB190-0x00000001854AB280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001854AAFE0-0x00000001854AB040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001854AAC40-0x00000001854AAD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001854AB140-0x00000001854AB190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001854AA9D0-0x00000001854AAAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, AiThreatInfo> CombatThreatInfoMap { get => default; } // 0x00000001854AA510-0x00000001854AA570 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23136
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23137
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 352
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAiSyncCombatThreatInfoNotify() {} // 0x00000001854AB530-0x00000001854AB5C0
	static EvtAiSyncCombatThreatInfoNotify() {} // 0x00000001854AB3D0-0x00000001854AB530

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAiSyncCombatThreatInfoNotify Clone() => default; // 0x00000001854AAD30-0x00000001854AAE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAiSyncCombatThreatInfoNotify ShallowCopy() => default; // 0x00000001854AA930-0x00000001854AA9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001854AA410-0x00000001854AA460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854AAF40-0x00000001854AAF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854AAF90-0x00000001854AAFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001854AA460-0x00000001854AA510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001854AA570-0x00000001854AA640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAiSyncCombatThreatInfoNotify other) => default; // 0x00000001854AA640-0x00000001854AA7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001854AAAC0-0x00000001854AABB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001854AB280-0x00000001854AB3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001854AB040-0x00000001854AB140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001854AA7C0-0x00000001854AA8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAiSyncCombatThreatInfoNotify other) {} // 0x00000001854AA300-0x00000001854AA410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001854AA170-0x00000001854AA2A0
}

