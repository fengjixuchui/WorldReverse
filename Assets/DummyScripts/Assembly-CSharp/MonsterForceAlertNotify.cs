/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterForceAlertNotify : MessageBase, IMessage<MonsterForceAlertNotify> // TypeDefIndex: 23076
{
	// Fields
	private static readonly MessageParser<MonsterForceAlertNotify> _parser; // 0x00
	public const int MonsterEntityIdFieldNumber = 1; // Metadata: 0x00B03233
	private uint monsterEntityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MonsterForceAlertNotify> Parser { get => default; } // 0x00000001851AD330-0x00000001851AD3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851AD020-0x00000001851AD0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851ACD30-0x00000001851ACDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851AC7A0-0x00000001851AC800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851AD680-0x00000001851AD770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851AD4F0-0x00000001851AD550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851AD0B0-0x00000001851AD1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851AD630-0x00000001851AD680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851ACE50-0x00000001851ACF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterEntityId { get => default; set {} } // 0x00000001851AC9D0-0x00000001851ACA70 0x00000001851AD290-0x00000001851AD330

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23077
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23078
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 330
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterForceAlertNotify() {} // 0x00000001851AD9A0-0x00000001851ADA00
	static MonsterForceAlertNotify() {} // 0x00000001851AD8E0-0x00000001851AD9A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterForceAlertNotify Clone() => default; // 0x00000001851AD1A0-0x00000001851AD290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterForceAlertNotify ShallowCopy() => default; // 0x00000001851ACDB0-0x00000001851ACE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001851AC910-0x00000001851AC960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851AD450-0x00000001851AD4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851AD4A0-0x00000001851AD4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851AC960-0x00000001851AC9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851ACB70-0x00000001851ACC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MonsterForceAlertNotify other) => default; // 0x00000001851ACA70-0x00000001851ACB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851ACF40-0x00000001851AD020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851AD770-0x00000001851AD8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851AD550-0x00000001851AD630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851ACC40-0x00000001851ACD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MonsterForceAlertNotify other) {} // 0x00000001851AC800-0x00000001851AC910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001851AC6C0-0x00000001851AC7A0
}

