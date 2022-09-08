/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeHelpRsp : MessageBase, IMessage<FurnitureMakeHelpRsp> // TypeDefIndex: 23478
{
	// Fields
	private static readonly MessageParser<FurnitureMakeHelpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B041C3
	private int retcode_; // 0x18
	public const int HelpDataListFieldNumber = 2; // Metadata: 0x00B041C7
	private static readonly FieldCodec<FurnitureMakeHelpData> _repeated_helpDataList_codec; // 0x08
	private readonly RepeatedMessageField<FurnitureMakeHelpData> helpDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeHelpRsp> Parser { get => default; } // 0x0000000183B11680-0x0000000183B11710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B11410-0x0000000183B114A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B11100-0x0000000183B11180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B10990-0x0000000183B109F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B11B10-0x0000000183B11C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B11920-0x0000000183B11980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B114A0-0x0000000183B11590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B11AC0-0x0000000183B11B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B11220-0x0000000183B11310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183B11060-0x0000000183B11100 0x0000000183B10C80-0x0000000183B10D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FurnitureMakeHelpData> HelpDataList { get => default; } // 0x0000000183B117A0-0x0000000183B11800 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23479
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23480
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4612
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeHelpRsp() {} // 0x0000000183B11EF0-0x0000000183B11F80
	static FurnitureMakeHelpRsp() {} // 0x0000000183B11DE0-0x0000000183B11EF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeHelpRsp Clone() => default; // 0x0000000183B11590-0x0000000183B11680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeHelpRsp ShallowCopy() => default; // 0x0000000183B11180-0x0000000183B11220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B10B50-0x0000000183B10BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B11800-0x0000000183B11890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B11890-0x0000000183B11920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B10BA0-0x0000000183B10C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B10D20-0x0000000183B10DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeHelpRsp other) => default; // 0x0000000183B10DF0-0x0000000183B10F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B11310-0x0000000183B11410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B11C00-0x0000000183B11DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B11980-0x0000000183B11AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B10F20-0x0000000183B11060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeHelpRsp other) {} // 0x0000000183B109F0-0x0000000183B10B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B10830-0x0000000183B10990
}

