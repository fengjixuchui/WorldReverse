/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMusicGameStartRsp : MessageBase, IMessage<FleurFairMusicGameStartRsp> // TypeDefIndex: 22231
{
	// Fields
	private static readonly MessageParser<FleurFairMusicGameStartRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B011A3
	private int retcode_; // 0x18
	public const int MusicBasicIdFieldNumber = 2; // Metadata: 0x00B011A7
	private uint musicBasicId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairMusicGameStartRsp> Parser { get => default; } // 0x0000000184A9EA20-0x0000000184A9EAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A9E7B0-0x0000000184A9E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A9E4A0-0x0000000184A9E520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A9DCB0-0x0000000184A9DD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A9EDB0-0x0000000184A9EEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A9EBE0-0x0000000184A9EC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A9E840-0x0000000184A9E930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A9ED60-0x0000000184A9EDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A9E5C0-0x0000000184A9E6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184A9E400-0x0000000184A9E4A0 0x0000000184A9E040-0x0000000184A9E0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MusicBasicId { get => default; set {} } // 0x0000000184A9DD10-0x0000000184A9DDB0 0x0000000184A9DEE0-0x0000000184A9DF80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22232
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22233
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2186
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameStartRsp() {} // 0x0000000184A9F160-0x0000000184A9F1C0
	static FleurFairMusicGameStartRsp() {} // 0x0000000184A9F0A0-0x0000000184A9F160

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameStartRsp Clone() => default; // 0x0000000184A9E930-0x0000000184A9EA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameStartRsp ShallowCopy() => default; // 0x0000000184A9E520-0x0000000184A9E5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A9DF80-0x0000000184A9DFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A9EB40-0x0000000184A9EB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A9EB90-0x0000000184A9EBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A9DFD0-0x0000000184A9E040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A9E200-0x0000000184A9E2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairMusicGameStartRsp other) => default; // 0x0000000184A9E0E0-0x0000000184A9E200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A9E6B0-0x0000000184A9E7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A9EEA0-0x0000000184A9F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A9EC40-0x0000000184A9ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A9E2D0-0x0000000184A9E400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairMusicGameStartRsp other) {} // 0x0000000184A9DDB0-0x0000000184A9DEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A9DBB0-0x0000000184A9DCB0
}

