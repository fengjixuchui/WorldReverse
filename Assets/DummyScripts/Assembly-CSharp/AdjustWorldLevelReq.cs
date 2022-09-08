/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AdjustWorldLevelReq : MessageBase, IMessage<AdjustWorldLevelReq> // TypeDefIndex: 24517
{
	// Fields
	private static readonly MessageParser<AdjustWorldLevelReq> _parser; // 0x00
	public const int CurWorldLevelFieldNumber = 1; // Metadata: 0x00B06987
	private uint curWorldLevel_; // 0x18
	public const int ExpectWorldLevelFieldNumber = 2; // Metadata: 0x00B0698B
	private uint expectWorldLevel_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AdjustWorldLevelReq> Parser { get => default; } // 0x00000001836F15A0-0x00000001836F1630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836F1150-0x00000001836F11E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836F0E40-0x00000001836F0EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836F08D0-0x00000001836F0930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836F19D0-0x00000001836F1AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836F1760-0x00000001836F17C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836F13C0-0x00000001836F14B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836F1980-0x00000001836F19D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836F0F60-0x00000001836F1050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurWorldLevel { get => default; set {} } // 0x00000001836F1280-0x00000001836F1320 0x00000001836F11E0-0x00000001836F1280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpectWorldLevel { get => default; set {} } // 0x00000001836F1320-0x00000001836F13C0 0x00000001836F18E0-0x00000001836F1980

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24518
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24519
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 171
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AdjustWorldLevelReq() {} // 0x00000001836F1D80-0x00000001836F1DE0
	static AdjustWorldLevelReq() {} // 0x00000001836F1CC0-0x00000001836F1D80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AdjustWorldLevelReq Clone() => default; // 0x00000001836F14B0-0x00000001836F15A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AdjustWorldLevelReq ShallowCopy() => default; // 0x00000001836F0EC0-0x00000001836F0F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836F0A60-0x00000001836F0AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836F16C0-0x00000001836F1710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836F1710-0x00000001836F1760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836F0AB0-0x00000001836F0B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836F0C40-0x00000001836F0D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AdjustWorldLevelReq other) => default; // 0x00000001836F0B20-0x00000001836F0C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836F1050-0x00000001836F1150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836F1AC0-0x00000001836F1CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836F17C0-0x00000001836F18E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836F0D10-0x00000001836F0E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AdjustWorldLevelReq other) {} // 0x00000001836F0930-0x00000001836F0A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836F07D0-0x00000001836F08D0
}

