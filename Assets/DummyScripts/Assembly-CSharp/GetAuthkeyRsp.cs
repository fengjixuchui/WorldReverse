/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAuthkeyRsp : MessageBase, IMessage<GetAuthkeyRsp> // TypeDefIndex: 23810
{
	// Fields
	private static readonly MessageParser<GetAuthkeyRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04DF7
	private int retcode_; // 0x18
	public const int AuthkeyFieldNumber = 2; // Metadata: 0x00B04DFB
	private string authkey_; // 0x20
	public const int AuthAppidFieldNumber = 3; // Metadata: 0x00B04DFF
	private string authAppid_; // 0x28
	public const int SignTypeFieldNumber = 4; // Metadata: 0x00B04E03
	private uint signType_; // 0x30
	public const int AuthkeyVerFieldNumber = 5; // Metadata: 0x00B04E07
	private uint authkeyVer_; // 0x34
	public const int GameBizFieldNumber = 6; // Metadata: 0x00B04E0B
	private string gameBiz_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAuthkeyRsp> Parser { get => default; } // 0x0000000184621B30-0x0000000184621BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184621770-0x0000000184621800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184621330-0x00000001846213B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184620440-0x00000001846204A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846220C0-0x00000001846221B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184621CF0-0x0000000184621D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846218A0-0x0000000184621990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184622070-0x00000001846220C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184621450-0x0000000184621540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184621290-0x0000000184621330 0x0000000184620A50-0x0000000184620AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Authkey { get => default; set {} } // 0x00000001846208A0-0x0000000184620940 0x0000000184621FC0-0x0000000184622070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AuthAppid { get => default; set {} } // 0x0000000184621800-0x00000001846218A0 0x00000001846211E0-0x0000000184621290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignType { get => default; set {} } // 0x00000001846205E0-0x0000000184620680 0x0000000184620B90-0x0000000184620C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthkeyVer { get => default; set {} } // 0x00000001846204A0-0x0000000184620540 0x0000000184620AF0-0x0000000184620B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GameBiz { get => default; set {} } // 0x0000000184620540-0x00000001846205E0 0x0000000184621A80-0x0000000184621B30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23811
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23812
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1409
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthkeyRsp() {} // 0x0000000184622650-0x00000001846226E0
	static GetAuthkeyRsp() {} // 0x0000000184622590-0x0000000184622650

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthkeyRsp Clone() => default; // 0x0000000184621990-0x0000000184621A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthkeyRsp ShallowCopy() => default; // 0x00000001846213B0-0x0000000184621450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184620940-0x0000000184620990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184621C50-0x0000000184621CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184621CA0-0x0000000184621CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184620990-0x0000000184620A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184620C30-0x0000000184620D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAuthkeyRsp other) => default; // 0x0000000184620D00-0x0000000184620F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184621540-0x0000000184621770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846221B0-0x0000000184622590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184621D50-0x0000000184621FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184620F30-0x00000001846211E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAuthkeyRsp other) {} // 0x0000000184620680-0x00000001846208A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001846202D0-0x0000000184620440
}

