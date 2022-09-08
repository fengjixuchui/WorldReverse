/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterMpNotify : MessageBase, IMessage<PlayerApplyEnterMpNotify> // TypeDefIndex: 24021
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterMpNotify> _parser; // 0x00
	public const int SrcPlayerInfoFieldNumber = 1; // Metadata: 0x00B055DB
	private OnlinePlayerInfo srcPlayerInfo_; // 0x18
	public const int SrcAppIdFieldNumber = 2; // Metadata: 0x00B055DF
	private uint srcAppId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterMpNotify> Parser { get => default; } // 0x0000000181FEBAA0-0x0000000181FEBB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FEB790-0x0000000181FEB820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FEB400-0x0000000181FEB480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FEAC20-0x0000000181FEAC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FEBF30-0x0000000181FEC020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FEBCC0-0x0000000181FEBD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FEB820-0x0000000181FEB910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FEBEE0-0x0000000181FEBF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FEB520-0x0000000181FEB610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo SrcPlayerInfo { get => default; set {} } // 0x0000000181FEC020-0x0000000181FEC0C0 0x0000000181FEAC80-0x0000000181FEAD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SrcAppId { get => default; set {} } // 0x0000000181FEBA00-0x0000000181FEBAA0 0x0000000181FEBD20-0x0000000181FEBDC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24022
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24023
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1801
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpNotify() {} // 0x0000000181FEC360-0x0000000181FEC3C0
	static PlayerApplyEnterMpNotify() {} // 0x0000000181FEC2A0-0x0000000181FEC360

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpNotify Clone() => default; // 0x0000000181FEB910-0x0000000181FEBA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpNotify ShallowCopy() => default; // 0x0000000181FEB480-0x0000000181FEB520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FEAEB0-0x0000000181FEAF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FEBBC0-0x0000000181FEBC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FEBC40-0x0000000181FEBCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FEAF30-0x0000000181FEB060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FEB060-0x0000000181FEB130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterMpNotify other) => default; // 0x0000000181FEB130-0x0000000181FEB260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FEB610-0x0000000181FEB790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FEC0C0-0x0000000181FEC2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FEBDC0-0x0000000181FEBEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FEB260-0x0000000181FEB400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterMpNotify other) {} // 0x0000000181FEAD20-0x0000000181FEAEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FEAAF0-0x0000000181FEAC20
}

