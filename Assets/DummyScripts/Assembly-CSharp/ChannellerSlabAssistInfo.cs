/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabAssistInfo : MessageBase, IMessage<ChannellerSlabAssistInfo> // TypeDefIndex: 22266
{
	// Fields
	private static readonly MessageParser<ChannellerSlabAssistInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B01303
	private uint uid_; // 0x18
	public const int AvatarIdFieldNumber = 2; // Metadata: 0x00B01307
	private uint avatarId_; // 0x1C
	public const int AvatarLevelFieldNumber = 3; // Metadata: 0x00B0130B
	private uint avatarLevel_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabAssistInfo> Parser { get => default; } // 0x0000000184BE26D0-0x0000000184BE2760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BE2320-0x0000000184BE23B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BE1FE0-0x0000000184BE2060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BE17E0-0x0000000184BE1840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BE2B40-0x0000000184BE2C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BE2890-0x0000000184BE28F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BE24F0-0x0000000184BE25E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BE2AF0-0x0000000184BE2B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BE2100-0x0000000184BE21F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184BE1E00-0x0000000184BE1EA0 0x0000000184BE2450-0x0000000184BE24F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000184BE1EA0-0x0000000184BE1F40 0x0000000184BE1F40-0x0000000184BE1FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarLevel { get => default; set {} } // 0x0000000184BE23B0-0x0000000184BE2450 0x0000000184BE28F0-0x0000000184BE2990

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabAssistInfo() {} // 0x0000000184BE2F80-0x0000000184BE2FE0
	static ChannellerSlabAssistInfo() {} // 0x0000000184BE2EC0-0x0000000184BE2F80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabAssistInfo Clone() => default; // 0x0000000184BE25E0-0x0000000184BE26D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabAssistInfo ShallowCopy() => default; // 0x0000000184BE2060-0x0000000184BE2100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BE19A0-0x0000000184BE19F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BE27F0-0x0000000184BE2840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BE2840-0x0000000184BE2890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BE19F0-0x0000000184BE1A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BE1A70-0x0000000184BE1B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabAssistInfo other) => default; // 0x0000000184BE1B40-0x0000000184BE1C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BE21F0-0x0000000184BE2320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BE2C30-0x0000000184BE2EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BE2990-0x0000000184BE2AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BE1C80-0x0000000184BE1E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabAssistInfo other) {} // 0x0000000184BE1840-0x0000000184BE19A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BE16D0-0x0000000184BE17E0
}

