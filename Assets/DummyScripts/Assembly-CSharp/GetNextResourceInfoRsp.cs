/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetNextResourceInfoRsp : MessageBase, IMessage<GetNextResourceInfoRsp> // TypeDefIndex: 24514
{
	// Fields
	private static readonly MessageParser<GetNextResourceInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0696B
	private int retcode_; // 0x18
	public const int NextResVersionConfigFieldNumber = 2; // Metadata: 0x00B0696F
	private ResVersionConfig nextResVersionConfig_; // 0x20
	public const int NextResourceUrlFieldNumber = 3; // Metadata: 0x00B06973
	private string nextResourceUrl_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetNextResourceInfoRsp> Parser { get => default; } // 0x0000000181D52DE0-0x0000000181D52E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D52B70-0x0000000181D52C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D52790-0x0000000181D52810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D51D60-0x0000000181D51DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D53360-0x0000000181D53450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D530A0-0x0000000181D53100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D52C00-0x0000000181D52CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D53270-0x0000000181D532C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D528B0-0x0000000181D529A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181D52650-0x0000000181D526F0 0x0000000181D52150-0x0000000181D521F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig NextResVersionConfig { get => default; set {} } // 0x0000000181D532C0-0x0000000181D53360 0x0000000181D526F0-0x0000000181D52790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NextResourceUrl { get => default; set {} } // 0x0000000181D52F80-0x0000000181D53020 0x0000000181D53450-0x0000000181D53500

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24515
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24516
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 170
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetNextResourceInfoRsp() {} // 0x0000000181D53820-0x0000000181D53890
	static GetNextResourceInfoRsp() {} // 0x0000000181D53760-0x0000000181D53820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetNextResourceInfoRsp Clone() => default; // 0x0000000181D52CF0-0x0000000181D52DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetNextResourceInfoRsp ShallowCopy() => default; // 0x0000000181D52810-0x0000000181D528B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D51F90-0x0000000181D52010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D52F00-0x0000000181D52F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D53020-0x0000000181D530A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D52010-0x0000000181D52150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D521F0-0x0000000181D522C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetNextResourceInfoRsp other) => default; // 0x0000000181D522C0-0x0000000181D52450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D529A0-0x0000000181D52B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D53500-0x0000000181D53760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D53100-0x0000000181D53270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D52450-0x0000000181D52650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetNextResourceInfoRsp other) {} // 0x0000000181D51DC0-0x0000000181D51F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D51C00-0x0000000181D51D60
}

