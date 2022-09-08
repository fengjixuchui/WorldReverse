/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldOwnerBlossomScheduleInfoNotify : MessageBase, IMessage<WorldOwnerBlossomScheduleInfoNotify> // TypeDefIndex: 22606
{
	// Fields
	private static readonly MessageParser<WorldOwnerBlossomScheduleInfoNotify> _parser; // 0x00
	public const int ScheduleInfoFieldNumber = 1; // Metadata: 0x00B01FAB
	private BlossomScheduleInfo scheduleInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldOwnerBlossomScheduleInfoNotify> Parser { get => default; } // 0x00000001858B5200-0x00000001858B5290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001858B4EF0-0x00000001858B4F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001858B4B90-0x00000001858B4C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001858B4500-0x00000001858B4560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001858B5650-0x00000001858B5740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001858B54C0-0x00000001858B5520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001858B5020-0x00000001858B5110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001858B5600-0x00000001858B5650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001858B4CB0-0x00000001858B4DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomScheduleInfo ScheduleInfo { get => default; set {} } // 0x00000001858B4F80-0x00000001858B5020 0x00000001858B5320-0x00000001858B53C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22607
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22608
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2705
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerBlossomScheduleInfoNotify() {} // 0x00000001858B5950-0x00000001858B59B0
	static WorldOwnerBlossomScheduleInfoNotify() {} // 0x00000001858B5890-0x00000001858B5950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerBlossomScheduleInfoNotify Clone() => default; // 0x00000001858B5110-0x00000001858B5200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerBlossomScheduleInfoNotify ShallowCopy() => default; // 0x00000001858B4C10-0x00000001858B4CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001858B46C0-0x00000001858B4740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001858B53C0-0x00000001858B5440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001858B5440-0x00000001858B54C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001858B4740-0x00000001858B4860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001858B4860-0x00000001858B4930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldOwnerBlossomScheduleInfoNotify other) => default; // 0x00000001858B4930-0x00000001858B4A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001858B4DA0-0x00000001858B4EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001858B5740-0x00000001858B5890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001858B5520-0x00000001858B5600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001858B4A40-0x00000001858B4B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldOwnerBlossomScheduleInfoNotify other) {} // 0x00000001858B4560-0x00000001858B46C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001858B43F0-0x00000001858B4500
}

