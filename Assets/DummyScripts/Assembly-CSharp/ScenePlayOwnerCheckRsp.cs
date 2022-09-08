/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayOwnerCheckRsp : MessageBase, IMessage<ScenePlayOwnerCheckRsp> // TypeDefIndex: 25372
{
	// Fields
	private static readonly MessageParser<ScenePlayOwnerCheckRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0895B
	private int retcode_; // 0x18
	public const int PlayIdFieldNumber = 2; // Metadata: 0x00B0895F
	private uint playId_; // 0x1C
	public const int IsSkipMatchFieldNumber = 3; // Metadata: 0x00B08963
	private bool isSkipMatch_; // 0x20
	public const int WrongUidFieldNumber = 4; // Metadata: 0x00B08967
	private uint wrongUid_; // 0x24
	public const int ParamListFieldNumber = 5; // Metadata: 0x00B0896B
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayOwnerCheckRsp> Parser { get => default; } // 0x000000018214E320-0x000000018214E3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018214E010-0x000000018214E0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018214DBD0-0x000000018214DC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018214D1D0-0x000000018214D230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018214E920-0x000000018214EA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018214E580-0x000000018214E5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018214E140-0x000000018214E230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018214E8D0-0x000000018214E920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018214DCF0-0x000000018214DDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018214DA90-0x000000018214DB30 0x000000018214D5B0-0x000000018214D650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x000000018214DB30-0x000000018214DBD0 0x000000018214DF70-0x000000018214E010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSkipMatch { get => default; set {} } // 0x000000018214E830-0x000000018214E8D0 0x000000018214E0A0-0x000000018214E140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WrongUid { get => default; set {} } // 0x000000018214D3D0-0x000000018214D470 0x000000018214E4E0-0x000000018214E580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x000000018214E5E0-0x000000018214E640 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25373
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25374
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4353
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerCheckRsp() {} // 0x000000018214EE80-0x000000018214EF10
	static ScenePlayOwnerCheckRsp() {} // 0x000000018214EDA0-0x000000018214EE80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerCheckRsp Clone() => default; // 0x000000018214E230-0x000000018214E320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerCheckRsp ShallowCopy() => default; // 0x000000018214DC50-0x000000018214DCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018214D470-0x000000018214D4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018214E440-0x000000018214E490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018214E490-0x000000018214E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018214D4C0-0x000000018214D5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018214D7D0-0x000000018214D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayOwnerCheckRsp other) => default; // 0x000000018214D650-0x000000018214D7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018214DDE0-0x000000018214DF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018214EA10-0x000000018214EDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018214E640-0x000000018214E830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018214D8A0-0x000000018214DA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayOwnerCheckRsp other) {} // 0x000000018214D230-0x000000018214D3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018214D010-0x000000018214D1D0
}

