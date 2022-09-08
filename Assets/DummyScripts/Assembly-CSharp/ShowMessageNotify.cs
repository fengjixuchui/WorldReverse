/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShowMessageNotify : MessageBase, IMessage<ShowMessageNotify> // TypeDefIndex: 23962
{
	// Fields
	private static readonly MessageParser<ShowMessageNotify> _parser; // 0x00
	public const int MsgIdFieldNumber = 1; // Metadata: 0x00B053D3
	private SvrMsgId msgId_; // 0x18
	public const int ParamsFieldNumber = 2; // Metadata: 0x00B053D7
	private static readonly FieldCodec<MsgParam> _repeated_params_codec; // 0x08
	private readonly RepeatedMessageField<MsgParam> params_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShowMessageNotify> Parser { get => default; } // 0x000000018357CCA0-0x000000018357CD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018357C9D0-0x000000018357CA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018357C680-0x000000018357C700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018357BFB0-0x000000018357C010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018357D170-0x000000018357D260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018357CEE0-0x000000018357CF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018357CAC0-0x000000018357CBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018357D120-0x000000018357D170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018357C7A0-0x000000018357C890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SvrMsgId MsgId { get => default; set {} } // 0x000000018357D080-0x000000018357D120 0x000000018357C170-0x000000018357C210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MsgParam> Params { get => default; } // 0x000000018357CA60-0x000000018357CAC0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23963
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23964
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowMessageNotify() {} // 0x000000018357D550-0x000000018357D5F0
	static ShowMessageNotify() {} // 0x000000018357D440-0x000000018357D550

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowMessageNotify Clone() => default; // 0x000000018357CBB0-0x000000018357CCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowMessageNotify ShallowCopy() => default; // 0x000000018357C700-0x000000018357C7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018357C210-0x000000018357C260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018357CDC0-0x000000018357CE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018357CE50-0x000000018357CEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018357C260-0x000000018357C340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018357C470-0x000000018357C540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShowMessageNotify other) => default; // 0x000000018357C340-0x000000018357C470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018357C890-0x000000018357C9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018357D260-0x000000018357D440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018357CF40-0x000000018357D080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018357C540-0x000000018357C680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShowMessageNotify other) {} // 0x000000018357C010-0x000000018357C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018357BE60-0x000000018357BFB0
}

