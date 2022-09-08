/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerSetOnlyMPWithPSPlayerRsp : MessageBase, IMessage<PlayerSetOnlyMPWithPSPlayerRsp> // TypeDefIndex: 24057
{
	// Fields
	private static readonly MessageParser<PlayerSetOnlyMPWithPSPlayerRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0575F
	private int retcode_; // 0x18
	public const int IsOnlyFieldNumber = 2; // Metadata: 0x00B05763
	private bool isOnly_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerSetOnlyMPWithPSPlayerRsp> Parser { get => default; } // 0x0000000180E5C6A0-0x0000000180E5C730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180E5C390-0x0000000180E5C420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180E5C070-0x0000000180E5C0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180E5B9F0-0x0000000180E5BA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180E5CA30-0x0000000180E5CB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180E5C860-0x0000000180E5C8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180E5C420-0x0000000180E5C510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180E5C9E0-0x0000000180E5CA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180E5C190-0x0000000180E5C280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000180E5BFD0-0x0000000180E5C070 0x0000000180E5BC40-0x0000000180E5BCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOnly { get => default; set {} } // 0x0000000180E5C600-0x0000000180E5C6A0 0x0000000180E5B950-0x0000000180E5B9F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24058
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24059
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1812
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerSetOnlyMPWithPSPlayerRsp() {} // 0x0000000180E5CDE0-0x0000000180E5CE40
	static PlayerSetOnlyMPWithPSPlayerRsp() {} // 0x0000000180E5CD20-0x0000000180E5CDE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerSetOnlyMPWithPSPlayerRsp Clone() => default; // 0x0000000180E5C510-0x0000000180E5C600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerSetOnlyMPWithPSPlayerRsp ShallowCopy() => default; // 0x0000000180E5C0F0-0x0000000180E5C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180E5BB80-0x0000000180E5BBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180E5C7C0-0x0000000180E5C810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180E5C810-0x0000000180E5C860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180E5BBD0-0x0000000180E5BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180E5BCE0-0x0000000180E5BDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerSetOnlyMPWithPSPlayerRsp other) => default; // 0x0000000180E5BDB0-0x0000000180E5BED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180E5C280-0x0000000180E5C390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180E5CB20-0x0000000180E5CD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180E5C8C0-0x0000000180E5C9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180E5BED0-0x0000000180E5BFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerSetOnlyMPWithPSPlayerRsp other) {} // 0x0000000180E5BA50-0x0000000180E5BB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180E5B850-0x0000000180E5B950
}

