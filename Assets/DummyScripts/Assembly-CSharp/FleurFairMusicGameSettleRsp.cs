/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMusicGameSettleRsp : MessageBase, IMessage<FleurFairMusicGameSettleRsp> // TypeDefIndex: 22225
{
	// Fields
	private static readonly MessageParser<FleurFairMusicGameSettleRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0116B
	private int retcode_; // 0x18
	public const int MusicBasicIdFieldNumber = 2; // Metadata: 0x00B0116F
	private uint musicBasicId_; // 0x1C
	public const int IsUnlockNextLevelFieldNumber = 3; // Metadata: 0x00B01173
	private bool isUnlockNextLevel_; // 0x20
	public const int IsNewRecordFieldNumber = 4; // Metadata: 0x00B01177
	private bool isNewRecord_; // 0x21

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairMusicGameSettleRsp> Parser { get => default; } // 0x00000001833E0110-0x00000001833E01A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833DFE00-0x00000001833DFE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833DFA90-0x00000001833DFB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833DF1B0-0x00000001833DF210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833E0660-0x00000001833E0750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833E0370-0x00000001833E03D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833DFF30-0x00000001833E0020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833E0610-0x00000001833E0660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833DFBB0-0x00000001833DFCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001833DF9F0-0x00000001833DFA90 0x00000001833DF5C0-0x00000001833DF660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MusicBasicId { get => default; set {} } // 0x00000001833DF210-0x00000001833DF2B0 0x00000001833DF440-0x00000001833DF4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUnlockNextLevel { get => default; set {} } // 0x00000001833E03D0-0x00000001833E0470 0x00000001833E02D0-0x00000001833E0370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewRecord { get => default; set {} } // 0x00000001833DFE90-0x00000001833DFF30 0x00000001833E0750-0x00000001833E07F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22226
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22227
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2184
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameSettleRsp() {} // 0x00000001833E0BD0-0x00000001833E0C30
	static FleurFairMusicGameSettleRsp() {} // 0x00000001833E0B10-0x00000001833E0BD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameSettleRsp Clone() => default; // 0x00000001833E0020-0x00000001833E0110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameSettleRsp ShallowCopy() => default; // 0x00000001833DFB10-0x00000001833DFBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833DF4E0-0x00000001833DF530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833E0230-0x00000001833E0280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833E0280-0x00000001833E02D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833DF530-0x00000001833DF5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833DF660-0x00000001833DF730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairMusicGameSettleRsp other) => default; // 0x00000001833DF730-0x00000001833DF890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833DFCA0-0x00000001833DFE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833E07F0-0x00000001833E0B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833E0470-0x00000001833E0610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833DF890-0x00000001833DF9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairMusicGameSettleRsp other) {} // 0x00000001833DF2B0-0x00000001833DF440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833DF080-0x00000001833DF1B0
}

