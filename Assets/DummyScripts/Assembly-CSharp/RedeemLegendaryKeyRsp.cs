/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RedeemLegendaryKeyRsp : MessageBase, IMessage<RedeemLegendaryKeyRsp> // TypeDefIndex: 24680
{
	// Fields
	private static readonly MessageParser<RedeemLegendaryKeyRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06FBF
	private int retcode_; // 0x18
	public const int LegendaryKeyCountFieldNumber = 2; // Metadata: 0x00B06FC3
	private uint legendaryKeyCount_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RedeemLegendaryKeyRsp> Parser { get => default; } // 0x0000000182A7B440-0x0000000182A7B4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A7B130-0x0000000182A7B1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A7AE20-0x0000000182A7AEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A7A6D0-0x0000000182A7A730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A7B7D0-0x0000000182A7B8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A7B600-0x0000000182A7B660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A7B1C0-0x0000000182A7B2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A7B780-0x0000000182A7B7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A7AF40-0x0000000182A7B030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182A7ACE0-0x0000000182A7AD80 0x0000000182A7A920-0x0000000182A7A9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LegendaryKeyCount { get => default; set {} } // 0x0000000182A7AD80-0x0000000182A7AE20 0x0000000182A7B3A0-0x0000000182A7B440

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24681
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24682
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 438
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RedeemLegendaryKeyRsp() {} // 0x0000000182A7BB80-0x0000000182A7BBE0
	static RedeemLegendaryKeyRsp() {} // 0x0000000182A7BAC0-0x0000000182A7BB80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RedeemLegendaryKeyRsp Clone() => default; // 0x0000000182A7B2B0-0x0000000182A7B3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RedeemLegendaryKeyRsp ShallowCopy() => default; // 0x0000000182A7AEA0-0x0000000182A7AF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A7A860-0x0000000182A7A8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A7B560-0x0000000182A7B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A7B5B0-0x0000000182A7B600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A7A8B0-0x0000000182A7A920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A7A9C0-0x0000000182A7AA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RedeemLegendaryKeyRsp other) => default; // 0x0000000182A7AA90-0x0000000182A7ABB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A7B030-0x0000000182A7B130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A7B8C0-0x0000000182A7BAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A7B660-0x0000000182A7B780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A7ABB0-0x0000000182A7ACE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RedeemLegendaryKeyRsp other) {} // 0x0000000182A7A730-0x0000000182A7A860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A7A5D0-0x0000000182A7A6D0
}

