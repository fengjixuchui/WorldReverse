/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FoundationNotify : MessageBase, IMessage<FoundationNotify> // TypeDefIndex: 23229
{
	// Fields
	private static readonly MessageParser<FoundationNotify> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B038A3
	private uint gadgetEntityId_; // 0x18
	public const int InfoFieldNumber = 2; // Metadata: 0x00B038A7
	private FoundationInfo info_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FoundationNotify> Parser { get => default; } // 0x00000001818C0730-0x00000001818C07C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818C04C0-0x00000001818C0550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818C0130-0x00000001818C01B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818BF8C0-0x00000001818BF920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818C0C60-0x00000001818C0D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818C09F0-0x00000001818C0A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818C0550-0x00000001818C0640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818C0C10-0x00000001818C0C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818C0250-0x00000001818C0340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x00000001818C0A50-0x00000001818C0AF0 0x00000001818BF920-0x00000001818BF9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationInfo Info { get => default; set {} } // 0x00000001818BFCF0-0x00000001818BFD90 0x00000001818C0950-0x00000001818C09F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23230
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23231
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 818
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationNotify() {} // 0x00000001818C0FF0-0x00000001818C1050
	static FoundationNotify() {} // 0x00000001818C0F30-0x00000001818C0FF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationNotify Clone() => default; // 0x00000001818C0640-0x00000001818C0730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationNotify ShallowCopy() => default; // 0x00000001818C01B0-0x00000001818C0250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818BFB40-0x00000001818BFBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818C0850-0x00000001818C08D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818C08D0-0x00000001818C0950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818BFBC0-0x00000001818BFCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818BFD90-0x00000001818BFE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FoundationNotify other) => default; // 0x00000001818BFE60-0x00000001818BFF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818C0340-0x00000001818C04C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818C0D50-0x00000001818C0F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818C0AF0-0x00000001818C0C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818BFF90-0x00000001818C0130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FoundationNotify other) {} // 0x00000001818BF9C0-0x00000001818BFB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818BF780-0x00000001818BF8C0
}

