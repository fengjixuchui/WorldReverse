/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InteractDailyDungeonInfoNotify : MessageBase, IMessage<InteractDailyDungeonInfoNotify> // TypeDefIndex: 22958
{
	// Fields
	private static readonly MessageParser<InteractDailyDungeonInfoNotify> _parser; // 0x00

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InteractDailyDungeonInfoNotify> Parser { get => default; } // 0x00000001831BB070-0x00000001831BB100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831BAE00-0x00000001831BAE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831BAB50-0x00000001831BABD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831BA730-0x00000001831BA790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831BB370-0x00000001831BB460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831BB230-0x00000001831BB290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831BAE90-0x00000001831BAF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831BB320-0x00000001831BB370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831BAC70-0x00000001831BAD60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22959
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22960
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 950
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InteractDailyDungeonInfoNotify() {} // 0x00000001831BB5F0-0x00000001831BB650
	static InteractDailyDungeonInfoNotify() {} // 0x00000001831BB530-0x00000001831BB5F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InteractDailyDungeonInfoNotify Clone() => default; // 0x00000001831BAF80-0x00000001831BB070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InteractDailyDungeonInfoNotify ShallowCopy() => default; // 0x00000001831BABD0-0x00000001831BAC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831BA870-0x00000001831BA8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831BB190-0x00000001831BB1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831BB1E0-0x00000001831BB230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831BA8C0-0x00000001831BA910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831BA910-0x00000001831BA9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InteractDailyDungeonInfoNotify other) => default; // 0x00000001831BA9E0-0x00000001831BAAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831BAD60-0x00000001831BAE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831BB460-0x00000001831BB530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831BB290-0x00000001831BB320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831BAAB0-0x00000001831BAB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InteractDailyDungeonInfoNotify other) {} // 0x00000001831BA790-0x00000001831BA870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831BA660-0x00000001831BA730
}

