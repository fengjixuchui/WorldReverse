/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnmarkEntityInMinMapNotify : MessageBase, IMessage<UnmarkEntityInMinMapNotify> // TypeDefIndex: 25043
{
	// Fields
	private static readonly MessageParser<UnmarkEntityInMinMapNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07D97
	private uint entityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnmarkEntityInMinMapNotify> Parser { get => default; } // 0x0000000184ACFFB0-0x0000000184AD0040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184ACFD40-0x0000000184ACFDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184ACFA50-0x0000000184ACFAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184ACF560-0x0000000184ACF5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184AD03A0-0x0000000184AD0490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184AD0210-0x0000000184AD0270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184ACFDD0-0x0000000184ACFEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184AD0350-0x0000000184AD03A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184ACFB70-0x0000000184ACFC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184AD0170-0x0000000184AD0210 0x0000000184AD0490-0x0000000184AD0530

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25044
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25045
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 250
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnmarkEntityInMinMapNotify() {} // 0x0000000184AD0760-0x0000000184AD07C0
	static UnmarkEntityInMinMapNotify() {} // 0x0000000184AD06A0-0x0000000184AD0760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnmarkEntityInMinMapNotify Clone() => default; // 0x0000000184ACFEC0-0x0000000184ACFFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnmarkEntityInMinMapNotify ShallowCopy() => default; // 0x0000000184ACFAD0-0x0000000184ACFB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184ACF6D0-0x0000000184ACF720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD00D0-0x0000000184AD0120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD0120-0x0000000184AD0170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184ACF720-0x0000000184ACF790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184ACF890-0x0000000184ACF960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnmarkEntityInMinMapNotify other) => default; // 0x0000000184ACF790-0x0000000184ACF890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184ACFC60-0x0000000184ACFD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184AD0530-0x0000000184AD06A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184AD0270-0x0000000184AD0350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184ACF960-0x0000000184ACFA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnmarkEntityInMinMapNotify other) {} // 0x0000000184ACF5C0-0x0000000184ACF6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184ACF480-0x0000000184ACF560
}

