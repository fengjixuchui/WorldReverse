/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BargainOfferPriceReq : MessageBase, IMessage<BargainOfferPriceReq> // TypeDefIndex: 24633
{
	// Fields
	private static readonly MessageParser<BargainOfferPriceReq> _parser; // 0x00
	public const int BargainIdFieldNumber = 1; // Metadata: 0x00B06E2F
	private uint bargainId_; // 0x18
	public const int PriceFieldNumber = 2; // Metadata: 0x00B06E33
	private uint price_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BargainOfferPriceReq> Parser { get => default; } // 0x0000000183E76270-0x0000000183E76300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E75F60-0x0000000183E75FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E75C50-0x0000000183E75CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E755A0-0x0000000183E75600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E76600-0x0000000183E766F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E76430-0x0000000183E76490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E76090-0x0000000183E76180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E765B0-0x0000000183E76600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E75D70-0x0000000183E75E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BargainId { get => default; set {} } // 0x0000000183E766F0-0x0000000183E76790 0x0000000183E757F0-0x0000000183E75890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Price { get => default; set {} } // 0x0000000183E75890-0x0000000183E75930 0x0000000183E75FF0-0x0000000183E76090

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24634
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24635
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 424
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainOfferPriceReq() {} // 0x0000000183E76A50-0x0000000183E76AB0
	static BargainOfferPriceReq() {} // 0x0000000183E76990-0x0000000183E76A50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainOfferPriceReq Clone() => default; // 0x0000000183E76180-0x0000000183E76270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainOfferPriceReq ShallowCopy() => default; // 0x0000000183E75CD0-0x0000000183E75D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E75730-0x0000000183E75780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E76390-0x0000000183E763E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E763E0-0x0000000183E76430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E75780-0x0000000183E757F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E75930-0x0000000183E75A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BargainOfferPriceReq other) => default; // 0x0000000183E75A00-0x0000000183E75B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E75E60-0x0000000183E75F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E76790-0x0000000183E76990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E76490-0x0000000183E765B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E75B20-0x0000000183E75C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BargainOfferPriceReq other) {} // 0x0000000183E75600-0x0000000183E75730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E754A0-0x0000000183E755A0
}

