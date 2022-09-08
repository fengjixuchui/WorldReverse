/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerSocialDetailRsp : MessageBase, IMessage<GetPlayerSocialDetailRsp> // TypeDefIndex: 25555
{
	// Fields
	private static readonly MessageParser<GetPlayerSocialDetailRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09113
	private int retcode_; // 0x18
	public const int DetailDataFieldNumber = 2; // Metadata: 0x00B09117
	private SocialDetail detailData_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerSocialDetailRsp> Parser { get => default; } // 0x0000000184B1D6C0-0x0000000184B1D750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B1D450-0x0000000184B1D4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B1D020-0x0000000184B1D0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B1C7B0-0x0000000184B1C810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B1DAB0-0x0000000184B1DBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B1D8E0-0x0000000184B1D940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B1D4E0-0x0000000184B1D5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B1DA60-0x0000000184B1DAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B1D1E0-0x0000000184B1D2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184B1CF80-0x0000000184B1D020 0x0000000184B1CB40-0x0000000184B1CBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialDetail DetailData { get => default; set {} } // 0x0000000184B1D140-0x0000000184B1D1E0 0x0000000184B1C710-0x0000000184B1C7B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25556
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25557
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4010
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerSocialDetailRsp() {} // 0x0000000184B1DE40-0x0000000184B1DEA0
	static GetPlayerSocialDetailRsp() {} // 0x0000000184B1DD80-0x0000000184B1DE40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerSocialDetailRsp Clone() => default; // 0x0000000184B1D5D0-0x0000000184B1D6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerSocialDetailRsp ShallowCopy() => default; // 0x0000000184B1D0A0-0x0000000184B1D140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B1C990-0x0000000184B1CA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B1D7E0-0x0000000184B1D860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B1D860-0x0000000184B1D8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B1CA10-0x0000000184B1CB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B1CBE0-0x0000000184B1CCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerSocialDetailRsp other) => default; // 0x0000000184B1CCB0-0x0000000184B1CDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B1D2D0-0x0000000184B1D450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B1DBA0-0x0000000184B1DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B1D940-0x0000000184B1DA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B1CDE0-0x0000000184B1CF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerSocialDetailRsp other) {} // 0x0000000184B1C810-0x0000000184B1C990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B1C5D0-0x0000000184B1C710
}

