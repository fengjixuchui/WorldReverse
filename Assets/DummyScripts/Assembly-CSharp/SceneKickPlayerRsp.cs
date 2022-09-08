/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneKickPlayerRsp : MessageBase, IMessage<SceneKickPlayerRsp> // TypeDefIndex: 25115
{
	// Fields
	private static readonly MessageParser<SceneKickPlayerRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0805F
	private int retcode_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B08063
	private uint targetUid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneKickPlayerRsp> Parser { get => default; } // 0x0000000181ED9090-0x0000000181ED9120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181ED8E20-0x0000000181ED8EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181ED8A70-0x0000000181ED8AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181ED8320-0x0000000181ED8380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181ED9420-0x0000000181ED9510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181ED9250-0x0000000181ED92B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181ED8EB0-0x0000000181ED8FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181ED93D0-0x0000000181ED9420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181ED8B90-0x0000000181ED8C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181ED89D0-0x0000000181ED8A70 0x0000000181ED8570-0x0000000181ED8610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000181ED8D80-0x0000000181ED8E20 0x0000000181ED8930-0x0000000181ED89D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25116
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25117
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 272
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneKickPlayerRsp() {} // 0x0000000181ED97D0-0x0000000181ED9830
	static SceneKickPlayerRsp() {} // 0x0000000181ED9710-0x0000000181ED97D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneKickPlayerRsp Clone() => default; // 0x0000000181ED8FA0-0x0000000181ED9090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneKickPlayerRsp ShallowCopy() => default; // 0x0000000181ED8AF0-0x0000000181ED8B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181ED84B0-0x0000000181ED8500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181ED91B0-0x0000000181ED9200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181ED9200-0x0000000181ED9250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181ED8500-0x0000000181ED8570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181ED8730-0x0000000181ED8800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneKickPlayerRsp other) => default; // 0x0000000181ED8610-0x0000000181ED8730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181ED8C80-0x0000000181ED8D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181ED9510-0x0000000181ED9710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181ED92B0-0x0000000181ED93D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181ED8800-0x0000000181ED8930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneKickPlayerRsp other) {} // 0x0000000181ED8380-0x0000000181ED84B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181ED8220-0x0000000181ED8320
}

