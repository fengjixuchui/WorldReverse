/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FallPlayerBrief : MessageBase, IMessage<FallPlayerBrief> // TypeDefIndex: 23255
{
	// Fields
	private static readonly MessageParser<FallPlayerBrief> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B039AF
	private uint uid_; // 0x18
	public const int ScoreFieldNumber = 2; // Metadata: 0x00B039B3
	private uint score_; // 0x1C
	public const int IsGroundFieldNumber = 3; // Metadata: 0x00B039B7
	private bool isGround_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FallPlayerBrief> Parser { get => default; } // 0x0000000183E4D110-0x0000000183E4D1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E4CC20-0x0000000183E4CCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E4C8E0-0x0000000183E4C960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E4C1B0-0x0000000183E4C210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E4D4E0-0x0000000183E4D5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E4D2D0-0x0000000183E4D330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E4CE90-0x0000000183E4CF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E4D490-0x0000000183E4D4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E4CA00-0x0000000183E4CAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000183E4C840-0x0000000183E4C8E0 0x0000000183E4CCB0-0x0000000183E4CD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Score { get => default; set {} } // 0x0000000183E4CD50-0x0000000183E4CDF0 0x0000000183E4C210-0x0000000183E4C2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGround { get => default; set {} } // 0x0000000183E4CDF0-0x0000000183E4CE90 0x0000000183E4D070-0x0000000183E4D110

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallPlayerBrief() {} // 0x0000000183E4D920-0x0000000183E4D980
	static FallPlayerBrief() {} // 0x0000000183E4D860-0x0000000183E4D920

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallPlayerBrief Clone() => default; // 0x0000000183E4CF80-0x0000000183E4D070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallPlayerBrief ShallowCopy() => default; // 0x0000000183E4C960-0x0000000183E4CA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E4C410-0x0000000183E4C460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E4D230-0x0000000183E4D280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E4D280-0x0000000183E4D2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E4C460-0x0000000183E4C4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E4C620-0x0000000183E4C6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FallPlayerBrief other) => default; // 0x0000000183E4C4E0-0x0000000183E4C620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E4CAF0-0x0000000183E4CC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E4D5D0-0x0000000183E4D860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E4D330-0x0000000183E4D490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E4C6F0-0x0000000183E4C840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FallPlayerBrief other) {} // 0x0000000183E4C2B0-0x0000000183E4C410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E4C0A0-0x0000000183E4C1B0
}

