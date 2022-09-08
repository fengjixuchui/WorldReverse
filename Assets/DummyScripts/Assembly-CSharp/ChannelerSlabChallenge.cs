/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannelerSlabChallenge : MessageBase, IMessage<ChannelerSlabChallenge> // TypeDefIndex: 22262
{
	// Fields
	private static readonly MessageParser<ChannelerSlabChallenge> _parser; // 0x00
	public const int CampListFieldNumber = 1; // Metadata: 0x00B012D3
	private static readonly FieldCodec<ChannelerSlabCamp> _repeated_campList_codec; // 0x08
	private readonly RepeatedMessageField<ChannelerSlabCamp> campList_; // 0x18
	public const int ActiveCampIndexFieldNumber = 2; // Metadata: 0x00B012D7
	private uint activeCampIndex_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannelerSlabChallenge> Parser { get => default; } // 0x00000001842C90C0-0x00000001842C9150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842C8E50-0x00000001842C8EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842C8B40-0x00000001842C8BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842C8470-0x00000001842C84D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842C9550-0x00000001842C9640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842C9360-0x00000001842C93C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842C8EE0-0x00000001842C8FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842C9500-0x00000001842C9550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842C8C60-0x00000001842C8D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChannelerSlabCamp> CampList { get => default; } // 0x00000001842C9300-0x00000001842C9360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActiveCampIndex { get => default; set {} } // 0x00000001842C8AA0-0x00000001842C8B40 0x00000001842C9640-0x00000001842C96E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabChallenge() {} // 0x00000001842C99D0-0x00000001842C9A60
	static ChannelerSlabChallenge() {} // 0x00000001842C98C0-0x00000001842C99D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabChallenge Clone() => default; // 0x00000001842C8FD0-0x00000001842C90C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabChallenge ShallowCopy() => default; // 0x00000001842C8BC0-0x00000001842C8C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842C8640-0x00000001842C8690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842C91E0-0x00000001842C9270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842C9270-0x00000001842C9300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842C8690-0x00000001842C8770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842C8890-0x00000001842C8960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannelerSlabChallenge other) => default; // 0x00000001842C8770-0x00000001842C8890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842C8D50-0x00000001842C8E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842C96E0-0x00000001842C98C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842C93C0-0x00000001842C9500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842C8960-0x00000001842C8AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannelerSlabChallenge other) {} // 0x00000001842C84D0-0x00000001842C8640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842C8310-0x00000001842C8470
}

