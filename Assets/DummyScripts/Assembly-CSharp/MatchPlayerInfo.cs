/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MatchPlayerInfo : MessageBase, IMessage<MatchPlayerInfo> // TypeDefIndex: 23843
{
	// Fields
	private static readonly MessageParser<MatchPlayerInfo> _parser; // 0x00
	public const int PlayerInfoFieldNumber = 1; // Metadata: 0x00B04F53
	private OnlinePlayerInfo playerInfo_; // 0x18
	public const int IsAgreedFieldNumber = 2; // Metadata: 0x00B04F57
	private bool isAgreed_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MatchPlayerInfo> Parser { get => default; } // 0x000000018179FEF0-0x000000018179FF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018179FC80-0x000000018179FD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018179F8F0-0x000000018179F970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018179F0B0-0x000000018179F110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001817A0420-0x00000001817A0510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817A0250-0x00000001817A02B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018179FD10-0x000000018179FE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817A03D0-0x00000001817A0420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018179FA10-0x000000018179FB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo PlayerInfo { get => default; set {} } // 0x000000018179F4F0-0x000000018179F590 0x00000001817A01B0-0x00000001817A0250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x000000018179F110-0x000000018179F1B0 0x000000018179FF80-0x00000001817A0020

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchPlayerInfo() {} // 0x00000001817A07B0-0x00000001817A0810
	static MatchPlayerInfo() {} // 0x00000001817A06F0-0x00000001817A07B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchPlayerInfo Clone() => default; // 0x000000018179FE00-0x000000018179FEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchPlayerInfo ShallowCopy() => default; // 0x000000018179F970-0x000000018179FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018179F340-0x000000018179F3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817A00B0-0x00000001817A0130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817A0130-0x00000001817A01B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018179F3C0-0x000000018179F4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018179F590-0x000000018179F660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MatchPlayerInfo other) => default; // 0x000000018179F660-0x000000018179F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018179FB00-0x000000018179FC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001817A0510-0x00000001817A06F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001817A02B0-0x00000001817A03D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018179F790-0x000000018179F8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MatchPlayerInfo other) {} // 0x000000018179F1B0-0x000000018179F340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018179EF80-0x000000018179F0B0
}

