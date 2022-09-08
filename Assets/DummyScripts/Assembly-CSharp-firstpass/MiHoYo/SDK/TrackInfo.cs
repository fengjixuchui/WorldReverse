/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public sealed class TrackInfo : IMessage<MiHoYo.SDK.TrackInfo> // TypeDefIndex: 8826
	{
		// Fields
		private static readonly MessageParser<TrackInfo> _parser; // 0x00
		public const int PageInfoFieldNumber = 1; // Metadata: 0x00AE2377
		private PageInfo pageInfo_; // 0x10
		public const int CommonInfoFieldNumber = 2; // Metadata: 0x00AE237B
		private CommonInfo commonInfo_; // 0x18
		public const int EventInfoFieldNumber = 3; // Metadata: 0x00AE237F
		private EventInfo eventInfo_; // 0x20
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { /* [XID] */ /* 0x0000000189AA83A0-0x0000000189AA83C0 */ get => default; } // 0x0000000185A8E6A0-0x0000000185A8E770 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageParser<TrackInfo> Parser { /* [XID] */ /* 0x0000000189943670-0x0000000189943690 */ get => default; } // 0x0000000185A8F120-0x0000000185A8F1F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018994AD30-0x000000018994AD50 */ get => default; } // 0x0000000185A8EEF0-0x0000000185A8EFE0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public PageInfo PageInfo { /* [XID] */ /* 0x0000000189964410-0x0000000189964430 */ get => default; /* [XID] */ /* 0x000000018996BC00-0x000000018996BC20 */ set {} } // 0x0000000185A8F080-0x0000000185A8F120 0x0000000185A8F350-0x0000000185A8F400
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public CommonInfo CommonInfo { /* [XID] */ /* 0x00000001899736F0-0x0000000189973710 */ get => default; /* [XID] */ /* 0x000000018965DC30-0x000000018965DC50 */ set {} } // 0x0000000185A8EE50-0x0000000185A8EEF0 0x0000000185A8F1F0-0x0000000185A8F2A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EventInfo EventInfo { /* [XID] */ /* 0x00000001895F0900-0x00000001895F0920 */ get => default; /* [XID] */ /* 0x00000001896564B0-0x00000001896564D0 */ set {} } // 0x0000000185A8EFE0-0x0000000185A8F080 0x0000000185A8F2A0-0x0000000185A8F350
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public TrackInfo() {} // 0x0000000185A8EDF0-0x0000000185A8EE50
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public TrackInfo(TrackInfo other) {} // 0x0000000185A8EC70-0x0000000185A8EDF0
		static TrackInfo() {} // 0x0000000185A8EBB0-0x0000000185A8EC70
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189959B70-0x0000000189959BB0
		// [XID] // 0x0000000189959B70-0x0000000189959BB0
		public TrackInfo Clone() => default; // 0x0000000185A8DEB0-0x0000000185A8DF80
		[DebuggerNonUserCode] // 0x0000000189991980-0x00000001899919D0
		// [IDTag] // 0x0000000189991980-0x00000001899919D0
		// [XID] // 0x0000000189991980-0x00000001899919D0
		public override bool Equals(object other) => default; // 0x0000000185A8DF80-0x0000000185A8E050
		[DebuggerNonUserCode] // 0x000000018999F330-0x000000018999F380
		// [IDTag] // 0x000000018999F330-0x000000018999F380
		// [XID] // 0x000000018999F330-0x000000018999F380
		public bool Equals(TrackInfo other) => default; // 0x0000000185A8E050-0x0000000185A8E1D0
		[DebuggerNonUserCode] // 0x00000001899ACF50-0x00000001899ACF90
		// [XID] // 0x00000001899ACF50-0x00000001899ACF90
		public override int GetHashCode() => default; // 0x0000000185A8E1D0-0x0000000185A8E320
		[DebuggerNonUserCode] // 0x00000001899B72E0-0x00000001899B7320
		// [XID] // 0x00000001899B72E0-0x00000001899B7320
		public override string ToString() => default; // 0x0000000185A8E770-0x0000000185A8E840
		[DebuggerNonUserCode] // 0x00000001899C1EB0-0x00000001899C1EF0
		// [XID] // 0x00000001899C1EB0-0x00000001899C1EF0
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000185A8EA50-0x0000000185A8EBB0
		[DebuggerNonUserCode] // 0x00000001899CC490-0x00000001899CC4D0
		// [XID] // 0x00000001899CC490-0x00000001899CC4D0
		public int CalculateSize() => default; // 0x0000000185A8DD30-0x0000000185A8DEB0
		[DebuggerNonUserCode] // 0x00000001899D6AB0-0x00000001899D6B00
		// [IDTag] // 0x00000001899D6AB0-0x00000001899D6B00
		// [XID] // 0x00000001899D6AB0-0x00000001899D6B00
		public void MergeFrom(TrackInfo other) {} // 0x0000000185A8E4C0-0x0000000185A8E6A0
		[DebuggerNonUserCode] // 0x00000001899E4240-0x00000001899E4290
		// [IDTag] // 0x00000001899E4240-0x00000001899E4290
		// [XID] // 0x00000001899E4240-0x00000001899E4290
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000185A8E320-0x0000000185A8E4C0
	}
}
