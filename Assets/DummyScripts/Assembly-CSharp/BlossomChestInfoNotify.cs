/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlossomChestInfoNotify : MessageBase, IMessage<BlossomChestInfoNotify> // TypeDefIndex: 23197
{
	// Fields
	private static readonly MessageParser<BlossomChestInfoNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0374F
	private uint entityId_; // 0x18
	public const int BlossomChestInfoFieldNumber = 2; // Metadata: 0x00B03753
	private BlossomChestInfo blossomChestInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlossomChestInfoNotify> Parser { get => default; } // 0x0000000181549A50-0x0000000181549AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815497E0-0x0000000181549870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815493B0-0x0000000181549430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181548BE0-0x0000000181548C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181549EE0-0x0000000181549FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181549D10-0x0000000181549D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181549870-0x0000000181549960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181549E90-0x0000000181549EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181549570-0x0000000181549660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181549C70-0x0000000181549D10 0x0000000181549FD0-0x000000018154A070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfo BlossomChestInfo { get => default; set {} } // 0x0000000181549430-0x00000001815494D0 0x0000000181548C40-0x0000000181548CE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23198
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23199
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 808
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfoNotify() {} // 0x000000018154A310-0x000000018154A370
	static BlossomChestInfoNotify() {} // 0x000000018154A250-0x000000018154A310

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfoNotify Clone() => default; // 0x0000000181549960-0x0000000181549A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomChestInfoNotify ShallowCopy() => default; // 0x00000001815494D0-0x0000000181549570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181548E60-0x0000000181548EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181549B70-0x0000000181549BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181549BF0-0x0000000181549C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181548EE0-0x0000000181549010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181549010-0x00000001815490E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlossomChestInfoNotify other) => default; // 0x00000001815490E0-0x0000000181549210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181549660-0x00000001815497E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018154A070-0x000000018154A250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181549D70-0x0000000181549E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181549210-0x00000001815493B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlossomChestInfoNotify other) {} // 0x0000000181548CE0-0x0000000181548E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181548AA0-0x0000000181548BE0
}

