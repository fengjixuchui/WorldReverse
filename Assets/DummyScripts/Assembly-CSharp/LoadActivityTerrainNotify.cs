/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LoadActivityTerrainNotify : MessageBase, IMessage<LoadActivityTerrainNotify> // TypeDefIndex: 21929
{
	// Fields
	private static readonly MessageParser<LoadActivityTerrainNotify> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B0060F
	private uint activityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LoadActivityTerrainNotify> Parser { get => default; } // 0x00000001816B7850-0x00000001816B78E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001816B75E0-0x00000001816B7670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001816B72F0-0x00000001816B7370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001816B6D60-0x00000001816B6DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001816B7C40-0x00000001816B7D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001816B7AB0-0x00000001816B7B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001816B7670-0x00000001816B7760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001816B7BF0-0x00000001816B7C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001816B7410-0x00000001816B7500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001816B7A10-0x00000001816B7AB0 0x00000001816B6DC0-0x00000001816B6E60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21930
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21931
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2024
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LoadActivityTerrainNotify() {} // 0x00000001816B7F60-0x00000001816B7FC0
	static LoadActivityTerrainNotify() {} // 0x00000001816B7EA0-0x00000001816B7F60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LoadActivityTerrainNotify Clone() => default; // 0x00000001816B7760-0x00000001816B7850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LoadActivityTerrainNotify ShallowCopy() => default; // 0x00000001816B7370-0x00000001816B7410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001816B6F70-0x00000001816B6FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816B7970-0x00000001816B79C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816B79C0-0x00000001816B7A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001816B6FC0-0x00000001816B7030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001816B7130-0x00000001816B7200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LoadActivityTerrainNotify other) => default; // 0x00000001816B7030-0x00000001816B7130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001816B7500-0x00000001816B75E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001816B7D30-0x00000001816B7EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001816B7B10-0x00000001816B7BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001816B7200-0x00000001816B72F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LoadActivityTerrainNotify other) {} // 0x00000001816B6E60-0x00000001816B6F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816B6C80-0x00000001816B6D60
}

