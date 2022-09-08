/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetWorldMpInfoRsp : MessageBase, IMessage<GetWorldMpInfoRsp> // TypeDefIndex: 25330
{
	// Fields
	private static readonly MessageParser<GetWorldMpInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0877F
	private int retcode_; // 0x18
	public const int IsInMpModeFieldNumber = 2; // Metadata: 0x00B08783
	private bool isInMpMode_; // 0x1C
	public const int QuitMpValidTimeFieldNumber = 3; // Metadata: 0x00B08787
	private uint quitMpValidTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetWorldMpInfoRsp> Parser { get => default; } // 0x0000000183D1B450-0x0000000183D1B4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D1B0A0-0x0000000183D1B130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D1AD60-0x0000000183D1ADE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D1A5A0-0x0000000183D1A600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D1B8C0-0x0000000183D1B9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D1B610-0x0000000183D1B670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D1B1D0-0x0000000183D1B2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D1B870-0x0000000183D1B8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D1AE80-0x0000000183D1AF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183D1ACC0-0x0000000183D1AD60 0x0000000183D1A8D0-0x0000000183D1A970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInMpMode { get => default; set {} } // 0x0000000183D1B3B0-0x0000000183D1B450 0x0000000183D1B130-0x0000000183D1B1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuitMpValidTime { get => default; set {} } // 0x0000000183D1A760-0x0000000183D1A800 0x0000000183D1B7D0-0x0000000183D1B870

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25331
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25332
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3058
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetWorldMpInfoRsp() {} // 0x0000000183D1BD00-0x0000000183D1BD60
	static GetWorldMpInfoRsp() {} // 0x0000000183D1BC40-0x0000000183D1BD00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetWorldMpInfoRsp Clone() => default; // 0x0000000183D1B2C0-0x0000000183D1B3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetWorldMpInfoRsp ShallowCopy() => default; // 0x0000000183D1ADE0-0x0000000183D1AE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D1A800-0x0000000183D1A850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D1B570-0x0000000183D1B5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D1B5C0-0x0000000183D1B610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D1A850-0x0000000183D1A8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D1AAB0-0x0000000183D1AB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetWorldMpInfoRsp other) => default; // 0x0000000183D1A970-0x0000000183D1AAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D1AF70-0x0000000183D1B0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D1B9B0-0x0000000183D1BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D1B670-0x0000000183D1B7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D1AB80-0x0000000183D1ACC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetWorldMpInfoRsp other) {} // 0x0000000183D1A600-0x0000000183D1A760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D1A490-0x0000000183D1A5A0
}

