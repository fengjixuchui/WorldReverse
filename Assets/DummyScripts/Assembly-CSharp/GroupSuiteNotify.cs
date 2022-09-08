/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GroupSuiteNotify : MessageBase, IMessage<GroupSuiteNotify> // TypeDefIndex: 25284
{
	// Fields
	private static readonly MessageParser<GroupSuiteNotify> _parser; // 0x00
	public const int GroupMapFieldNumber = 1; // Metadata: 0x00B08607
	private static readonly MapField<uint, uint> _map_groupMap_codec; // 0x08
	private readonly MapField<uint, uint> groupMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GroupSuiteNotify> Parser { get => default; } // 0x0000000181CA26F0-0x0000000181CA2780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CA2420-0x0000000181CA24B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CA2120-0x0000000181CA21A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CA1B70-0x0000000181CA1BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CA2A60-0x0000000181CA2B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CA28B0-0x0000000181CA2910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CA2510-0x0000000181CA2600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CA2A10-0x0000000181CA2A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CA2240-0x0000000181CA2330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> GroupMap { get => default; } // 0x0000000181CA24B0-0x0000000181CA2510 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25285
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25286
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3042
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GroupSuiteNotify() {} // 0x0000000181CA2DD0-0x0000000181CA2E60
	static GroupSuiteNotify() {} // 0x0000000181CA2CA0-0x0000000181CA2DD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GroupSuiteNotify Clone() => default; // 0x0000000181CA2600-0x0000000181CA26F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GroupSuiteNotify ShallowCopy() => default; // 0x0000000181CA21A0-0x0000000181CA2240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CA1CE0-0x0000000181CA1D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CA2810-0x0000000181CA2860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CA2860-0x0000000181CA28B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CA1D30-0x0000000181CA1DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CA1F60-0x0000000181CA2030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GroupSuiteNotify other) => default; // 0x0000000181CA1DE0-0x0000000181CA1F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CA2330-0x0000000181CA2420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CA2B50-0x0000000181CA2CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CA2910-0x0000000181CA2A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CA2030-0x0000000181CA2120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GroupSuiteNotify other) {} // 0x0000000181CA1BD0-0x0000000181CA1CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CA1A40-0x0000000181CA1B70
}

