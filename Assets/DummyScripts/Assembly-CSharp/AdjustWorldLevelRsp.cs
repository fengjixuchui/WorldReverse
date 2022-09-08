/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AdjustWorldLevelRsp : MessageBase, IMessage<AdjustWorldLevelRsp> // TypeDefIndex: 24520
{
	// Fields
	private static readonly MessageParser<AdjustWorldLevelRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B069A3
	private int retcode_; // 0x18
	public const int AfterWorldLevelFieldNumber = 2; // Metadata: 0x00B069A7
	private uint afterWorldLevel_; // 0x1C
	public const int CdOverTimeFieldNumber = 3; // Metadata: 0x00B069AB
	private uint cdOverTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AdjustWorldLevelRsp> Parser { get => default; } // 0x00000001820B51D0-0x00000001820B5260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820B4E20-0x00000001820B4EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820B4AE0-0x00000001820B4B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820B42E0-0x00000001820B4340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820B55A0-0x00000001820B5690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820B5390-0x00000001820B53F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820B4FF0-0x00000001820B50E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820B5550-0x00000001820B55A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820B4C00-0x00000001820B4CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001820B4A40-0x00000001820B4AE0 0x00000001820B4610-0x00000001820B46B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AfterWorldLevel { get => default; set {} } // 0x00000001820B4F50-0x00000001820B4FF0 0x00000001820B4EB0-0x00000001820B4F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CdOverTime { get => default; set {} } // 0x00000001820B5690-0x00000001820B5730 0x00000001820B44A0-0x00000001820B4540

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24521
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24522
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 172
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AdjustWorldLevelRsp() {} // 0x00000001820B5A80-0x00000001820B5AE0
	static AdjustWorldLevelRsp() {} // 0x00000001820B59C0-0x00000001820B5A80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AdjustWorldLevelRsp Clone() => default; // 0x00000001820B50E0-0x00000001820B51D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AdjustWorldLevelRsp ShallowCopy() => default; // 0x00000001820B4B60-0x00000001820B4C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820B4540-0x00000001820B4590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820B52F0-0x00000001820B5340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820B5340-0x00000001820B5390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820B4590-0x00000001820B4610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820B47F0-0x00000001820B48C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AdjustWorldLevelRsp other) => default; // 0x00000001820B46B0-0x00000001820B47F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820B4CF0-0x00000001820B4E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820B5730-0x00000001820B59C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820B53F0-0x00000001820B5550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820B48C0-0x00000001820B4A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AdjustWorldLevelRsp other) {} // 0x00000001820B4340-0x00000001820B44A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820B41D0-0x00000001820B42E0
}

