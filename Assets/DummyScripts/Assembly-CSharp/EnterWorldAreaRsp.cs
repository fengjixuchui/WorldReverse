/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterWorldAreaRsp : MessageBase, IMessage<EnterWorldAreaRsp> // TypeDefIndex: 24996
{
	// Fields
	private static readonly MessageParser<EnterWorldAreaRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07BB7
	private int retcode_; // 0x18
	public const int AreaTypeFieldNumber = 2; // Metadata: 0x00B07BBB
	private uint areaType_; // 0x1C
	public const int AreaIdFieldNumber = 3; // Metadata: 0x00B07BBF
	private uint areaId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterWorldAreaRsp> Parser { get => default; } // 0x0000000181B8DAB0-0x0000000181B8DB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B8D7A0-0x0000000181B8D830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B8D460-0x0000000181B8D4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B8CC60-0x0000000181B8CCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B8DF20-0x0000000181B8E010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B8DD10-0x0000000181B8DD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B8D8D0-0x0000000181B8D9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B8DED0-0x0000000181B8DF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B8D580-0x0000000181B8D670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181B8D3C0-0x0000000181B8D460 0x0000000181B8CF90-0x0000000181B8D030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AreaType { get => default; set {} } // 0x0000000181B8E010-0x0000000181B8E0B0 0x0000000181B8DC20-0x0000000181B8DCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AreaId { get => default; set {} } // 0x0000000181B8CEF0-0x0000000181B8CF90 0x0000000181B8D830-0x0000000181B8D8D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24997
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24998
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 234
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterWorldAreaRsp() {} // 0x0000000181B8E400-0x0000000181B8E460
	static EnterWorldAreaRsp() {} // 0x0000000181B8E340-0x0000000181B8E400

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterWorldAreaRsp Clone() => default; // 0x0000000181B8D9C0-0x0000000181B8DAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterWorldAreaRsp ShallowCopy() => default; // 0x0000000181B8D4E0-0x0000000181B8D580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B8CE20-0x0000000181B8CE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B8DBD0-0x0000000181B8DC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B8DCC0-0x0000000181B8DD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B8CE70-0x0000000181B8CEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B8D030-0x0000000181B8D100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterWorldAreaRsp other) => default; // 0x0000000181B8D100-0x0000000181B8D240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B8D670-0x0000000181B8D7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B8E0B0-0x0000000181B8E340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B8DD70-0x0000000181B8DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B8D240-0x0000000181B8D3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterWorldAreaRsp other) {} // 0x0000000181B8CCC0-0x0000000181B8CE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B8CB50-0x0000000181B8CC60
}

