/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpActivityUpdateNotify : MessageBase, IMessage<OpActivityUpdateNotify> // TypeDefIndex: 24250
{
	// Fields
	private static readonly MessageParser<OpActivityUpdateNotify> _parser; // 0x00
	public const int OpActivityInfoFieldNumber = 1; // Metadata: 0x00B05F0B
	private OpActivityInfo opActivityInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpActivityUpdateNotify> Parser { get => default; } // 0x000000018506FA70-0x000000018506FB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018506F6C0-0x000000018506F750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018506F360-0x000000018506F3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018506ECD0-0x000000018506ED30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018506FE20-0x000000018506FF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018506FC90-0x000000018506FCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018506F7F0-0x000000018506F8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018506FDD0-0x000000018506FE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018506F480-0x000000018506F570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityInfo OpActivityInfo { get => default; set {} } // 0x000000018506F750-0x000000018506F7F0 0x000000018506F9D0-0x000000018506FA70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24251
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24252
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5104
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityUpdateNotify() {} // 0x0000000185070120-0x0000000185070180
	static OpActivityUpdateNotify() {} // 0x0000000185070060-0x0000000185070120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityUpdateNotify Clone() => default; // 0x000000018506F8E0-0x000000018506F9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityUpdateNotify ShallowCopy() => default; // 0x000000018506F3E0-0x000000018506F480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018506EE90-0x000000018506EF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018506FB90-0x000000018506FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018506FC10-0x000000018506FC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018506EF10-0x000000018506F030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018506F030-0x000000018506F100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpActivityUpdateNotify other) => default; // 0x000000018506F100-0x000000018506F210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018506F570-0x000000018506F6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018506FF10-0x0000000185070060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018506FCF0-0x000000018506FDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018506F210-0x000000018506F360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpActivityUpdateNotify other) {} // 0x000000018506ED30-0x000000018506EE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018506EBC0-0x000000018506ECD0
}

