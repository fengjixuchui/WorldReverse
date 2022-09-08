/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldPlayerLocationNotify : MessageBase, IMessage<WorldPlayerLocationNotify> // TypeDefIndex: 25031
{
	// Fields
	private static readonly MessageParser<WorldPlayerLocationNotify> _parser; // 0x00
	public const int PlayerLocListFieldNumber = 1; // Metadata: 0x00B07D13
	private static readonly FieldCodec<PlayerLocationInfo> _repeated_playerLocList_codec; // 0x08
	private readonly RepeatedMessageField<PlayerLocationInfo> playerLocList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldPlayerLocationNotify> Parser { get => default; } // 0x00000001846CCD70-0x00000001846CCE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001846CCAA0-0x00000001846CCB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001846CC7D0-0x00000001846CC850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846CC250-0x00000001846CC2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846CD160-0x00000001846CD250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001846CCFB0-0x00000001846CD010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846CCB90-0x00000001846CCC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846CD110-0x00000001846CD160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846CC8F0-0x00000001846CC9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PlayerLocationInfo> PlayerLocList { get => default; } // 0x00000001846CCB30-0x00000001846CCB90 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25032
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25033
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 246
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerLocationNotify() {} // 0x00000001846CD4B0-0x00000001846CD540
	static WorldPlayerLocationNotify() {} // 0x00000001846CD3A0-0x00000001846CD4B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerLocationNotify Clone() => default; // 0x00000001846CCC80-0x00000001846CCD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerLocationNotify ShallowCopy() => default; // 0x00000001846CC850-0x00000001846CC8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001846CC3E0-0x00000001846CC430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846CCE90-0x00000001846CCF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846CCF20-0x00000001846CCFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846CC430-0x00000001846CC500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001846CC610-0x00000001846CC6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldPlayerLocationNotify other) => default; // 0x00000001846CC500-0x00000001846CC610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846CC9E0-0x00000001846CCAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846CD250-0x00000001846CD3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846CD010-0x00000001846CD110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001846CC6E0-0x00000001846CC7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldPlayerLocationNotify other) {} // 0x00000001846CC2B0-0x00000001846CC3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001846CC120-0x00000001846CC250
}

