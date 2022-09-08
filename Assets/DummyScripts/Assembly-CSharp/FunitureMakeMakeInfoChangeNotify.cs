/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FunitureMakeMakeInfoChangeNotify : MessageBase, IMessage<FunitureMakeMakeInfoChangeNotify> // TypeDefIndex: 23481
{
	// Fields
	private static readonly MessageParser<FunitureMakeMakeInfoChangeNotify> _parser; // 0x00
	public const int MakeInfoFieldNumber = 1; // Metadata: 0x00B041DB
	private FurnitureMakeMakeInfo makeInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FunitureMakeMakeInfoChangeNotify> Parser { get => default; } // 0x0000000181574030-0x00000001815740C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181573D20-0x0000000181573DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815739C0-0x0000000181573A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181573290-0x00000001815732F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815743E0-0x00000001815744D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181574250-0x00000001815742B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181573E50-0x0000000181573F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181574390-0x00000001815743E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181573AE0-0x0000000181573BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeMakeInfo MakeInfo { get => default; set {} } // 0x00000001815732F0-0x0000000181573390 0x0000000181573DB0-0x0000000181573E50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23482
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23483
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4615
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FunitureMakeMakeInfoChangeNotify() {} // 0x00000001815746E0-0x0000000181574740
	static FunitureMakeMakeInfoChangeNotify() {} // 0x0000000181574620-0x00000001815746E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FunitureMakeMakeInfoChangeNotify Clone() => default; // 0x0000000181573F40-0x0000000181574030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FunitureMakeMakeInfoChangeNotify ShallowCopy() => default; // 0x0000000181573A40-0x0000000181573AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815734F0-0x0000000181573570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181574150-0x00000001815741D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815741D0-0x0000000181574250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181573570-0x0000000181573690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181573690-0x0000000181573760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FunitureMakeMakeInfoChangeNotify other) => default; // 0x0000000181573760-0x0000000181573870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181573BD0-0x0000000181573D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815744D0-0x0000000181574620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815742B0-0x0000000181574390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181573870-0x00000001815739C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FunitureMakeMakeInfoChangeNotify other) {} // 0x0000000181573390-0x00000001815734F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181573180-0x0000000181573290
}

