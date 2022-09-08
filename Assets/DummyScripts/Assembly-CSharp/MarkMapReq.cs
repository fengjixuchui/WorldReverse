/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MarkMapReq : MessageBase, IMessage<MarkMapReq> // TypeDefIndex: 25219
{
	// Fields
	private static readonly MessageParser<MarkMapReq> _parser; // 0x00
	public const int OpFieldNumber = 1; // Metadata: 0x00B083C3
	private Types.Operation op_; // 0x18
	public const int OldFieldNumber = 2; // Metadata: 0x00B083C7
	private MapMarkPoint old_; // 0x20
	public const int MarkFieldNumber = 3; // Metadata: 0x00B083CB
	private MapMarkPoint mark_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MarkMapReq> Parser { get => default; } // 0x00000001836A9F70-0x00000001836AA000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836A9B20-0x00000001836A9BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836A9600-0x00000001836A9680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836A8C00-0x00000001836A8C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836AA3B0-0x00000001836AA4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836AA1B0-0x00000001836AA210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836A9C50-0x00000001836A9D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836AA360-0x00000001836AA3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836A9720-0x00000001836A9810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Operation Op { get => default; set {} } // 0x00000001836A9BB0-0x00000001836A9C50 0x00000001836A9A80-0x00000001836A9B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkPoint Old { get => default; set {} } // 0x00000001836A8B60-0x00000001836A8C00 0x00000001836A8C60-0x00000001836A8D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkPoint Mark { get => default; set {} } // 0x00000001836A9E30-0x00000001836A9ED0 0x00000001836A9ED0-0x00000001836A9F70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25220
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25221
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3010
		}

		public enum Operation // TypeDefIndex: 25222
		{
			Add = 0,
			Mod = 1,
			Del = 2,
			Get = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkMapReq() {} // 0x00000001836AA7C0-0x00000001836AA830
	static MarkMapReq() {} // 0x00000001836AA700-0x00000001836AA7C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkMapReq Clone() => default; // 0x00000001836A9D40-0x00000001836A9E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkMapReq ShallowCopy() => default; // 0x00000001836A9680-0x00000001836A9720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836A8F00-0x00000001836A8F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836AA090-0x00000001836AA120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836AA120-0x00000001836AA1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836A8F90-0x00000001836A9180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836A92E0-0x00000001836A93B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MarkMapReq other) => default; // 0x00000001836A9180-0x00000001836A92E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836A9810-0x00000001836A9A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836AA4A0-0x00000001836AA700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836AA210-0x00000001836AA360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836A93B0-0x00000001836A9600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MarkMapReq other) {} // 0x00000001836A8D00-0x00000001836A8F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836A89E0-0x00000001836A8B60
}

