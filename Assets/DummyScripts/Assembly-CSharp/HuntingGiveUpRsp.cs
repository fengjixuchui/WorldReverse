/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HuntingGiveUpRsp : MessageBase, IMessage<HuntingGiveUpRsp> // TypeDefIndex: 23568
{
	// Fields
	private static readonly MessageParser<HuntingGiveUpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B044DB
	private int retcode_; // 0x18
	public const int HuntingPairFieldNumber = 2; // Metadata: 0x00B044DF
	private HuntingPair huntingPair_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HuntingGiveUpRsp> Parser { get => default; } // 0x00000001849C3AE0-0x00000001849C3B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849C3870-0x00000001849C3900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849C34E0-0x00000001849C3560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849C2BD0-0x00000001849C2C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849C3ED0-0x00000001849C3FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849C3D00-0x00000001849C3D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849C3900-0x00000001849C39F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849C3E80-0x00000001849C3ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849C3600-0x00000001849C36F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001849C3440-0x00000001849C34E0 0x00000001849C3000-0x00000001849C30A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x00000001849C2DB0-0x00000001849C2E50 0x00000001849C29F0-0x00000001849C2A90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23569
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23570
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4314
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingGiveUpRsp() {} // 0x00000001849C4260-0x00000001849C42C0
	static HuntingGiveUpRsp() {} // 0x00000001849C41A0-0x00000001849C4260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingGiveUpRsp Clone() => default; // 0x00000001849C39F0-0x00000001849C3AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingGiveUpRsp ShallowCopy() => default; // 0x00000001849C3560-0x00000001849C3600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849C2E50-0x00000001849C2ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849C3C00-0x00000001849C3C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849C3C80-0x00000001849C3D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849C2ED0-0x00000001849C3000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849C31D0-0x00000001849C32A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HuntingGiveUpRsp other) => default; // 0x00000001849C30A0-0x00000001849C31D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849C36F0-0x00000001849C3870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849C3FC0-0x00000001849C41A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849C3D60-0x00000001849C3E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849C32A0-0x00000001849C3440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HuntingGiveUpRsp other) {} // 0x00000001849C2C30-0x00000001849C2DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849C2A90-0x00000001849C2BD0
}

