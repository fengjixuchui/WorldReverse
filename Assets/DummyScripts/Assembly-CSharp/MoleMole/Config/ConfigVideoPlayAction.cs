/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x00000001899BE290-0x00000001899BE2D0
	[RecycleType] // 0x00000001899BE290-0x00000001899BE2D0
	public class ConfigVideoPlayAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18415
	{
		// Fields
		private string _videoName; // 0x30
		private uint _subtitleId; // 0x38
		private bool _canSkip; // 0x3C
		private ColorVector _bgColor; // 0x40
		private float _fadeInTime; // 0x50
		private float _fadeOutTime; // 0x54
	
		// Properties
		public string videoName { /* [XID] */ /* 0x0000000189BB5230-0x0000000189BB5250 */ get => default; /* [XID] */ /* 0x0000000189BBC910-0x0000000189BBC930 */ private set {} } // 0x0000000188D49C50-0x0000000188D49CF0 0x0000000188D4A070-0x0000000188D4A120
		public uint subtitleId { /* [XID] */ /* 0x0000000189BC4580-0x0000000189BC45A0 */ get => default; /* [XID] */ /* 0x0000000189BCBF80-0x0000000189BCBFA0 */ private set {} } // 0x0000000188D49BB0-0x0000000188D49C50 0x0000000188D49FC0-0x0000000188D4A070
		public bool canSkip { /* [XID] */ /* 0x0000000189BD3510-0x0000000189BD3530 */ get => default; /* [XID] */ /* 0x0000000189BDADC0-0x0000000189BDADE0 */ private set {} } // 0x0000000188D499B0-0x0000000188D49A50 0x0000000188D49DB0-0x0000000188D49E60
		public ColorVector bgColor { /* [XID] */ /* 0x00000001895E77F0-0x00000001895E7810 */ get => default; /* [XID] */ /* 0x00000001895EF0E0-0x00000001895EF100 */ private set {} } // 0x0000000188D498E0-0x0000000188D499B0 0x0000000188D49CF0-0x0000000188D49DB0
		public float fadeInTime { /* [XID] */ /* 0x00000001895F6A80-0x00000001895F6AA0 */ get => default; /* [XID] */ /* 0x00000001895FDEA0-0x00000001895FDEC0 */ private set {} } // 0x0000000188D49A50-0x0000000188D49B00 0x0000000188D49E60-0x0000000188D49F10
		public float fadeOutTime { /* [XID] */ /* 0x00000001896056F0-0x0000000189605710 */ get => default; /* [XID] */ /* 0x000000018960D0C0-0x000000018960D0E0 */ private set {} } // 0x0000000188D49B00-0x0000000188D49BB0 0x0000000188D49F10-0x0000000188D49FC0
	
		// Constructors
		public ConfigVideoPlayAction() {} // 0x0000000188D49880-0x0000000188D498E0
	
		// Methods
		// [XID] // 0x0000000189614720-0x0000000189614740
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D48880-0x0000000188D48A20
		// [XID] // 0x000000018961C040-0x000000018961C060
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188D46FB0-0x0000000188D47090
		// [XID] // 0x00000001896235A0-0x00000001896235C0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF97B9 */) => default; // 0x0000000188D46ED0-0x0000000188D46FB0
		// [XID] // 0x000000018962AE60-0x000000018962AE80
		public override int GetHashNum() => default; // 0x0000000188D47710-0x0000000188D477E0
		// [XID] // 0x0000000189632560-0x0000000189632580
		public override void InitEmpty() {} // 0x0000000188D477E0-0x0000000188D478D0
		[BlackList] // 0x0000000189639FD0-0x000000018963A010
		// [XID] // 0x0000000189639FD0-0x000000018963A010
		public override bool FromJson(JSONNode node) => default; // 0x0000000188D47390-0x0000000188D47710
		// [XID] // 0x0000000189644690-0x00000001896446B0
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188D47DB0-0x0000000188D48390
		[BlackList] // 0x000000018964BF30-0x000000018964BF70
		// [XID] // 0x000000018964BF30-0x000000018964BF70
		public static new ConfigVideoPlayAction ParseFromJson(JSONNode node) => default; // 0x0000000188D48C40-0x0000000188D48E90
		// [XID] // 0x00000001896565B0-0x00000001896565D0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97BA */, bool useObjectPool = false /* Metadata: 0x00AF97BE */) => default; // 0x0000000188D47090-0x0000000188D47390
		// [XID] // 0x000000018965DD10-0x000000018965DD30
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97BF */, bool useObjectPool = false /* Metadata: 0x00AF97C3 */) => default; // 0x0000000188D478D0-0x0000000188D47DB0
		// [XID] // 0x0000000189665330-0x0000000189665350
		public static new ConfigVideoPlayAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97C4 */, bool useObjectPool = false /* Metadata: 0x00AF97C8 */) => default; // 0x0000000188D48A20-0x0000000188D48C40
		[BlackList] // 0x000000018966CB40-0x000000018966CB80
		// [XID] // 0x000000018966CB40-0x000000018966CB80
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D49020-0x0000000188D492F0
		// [XID] // 0x0000000189677A30-0x0000000189677A50
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D48390-0x0000000188D48880
		[BlackList] // 0x000000018967EF80-0x000000018967EFC0
		// [XID] // 0x000000018967EF80-0x000000018967EFC0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188D48F30-0x0000000188D49020
		[BlackList] // 0x0000000189689B10-0x0000000189689B50
		// [XID] // 0x0000000189689B10-0x0000000189689B50
		public override void AutoAllocTypeFields() {} // 0x0000000188D46D60-0x0000000188D46E00
		[BlackList] // 0x0000000189694680-0x00000001896946C0
		// [XID] // 0x0000000189694680-0x00000001896946C0
		public override void AutoRecycleTypeFields() {} // 0x0000000188D46E00-0x0000000188D46ED0
		[BlackList] // 0x000000018969ECB0-0x000000018969ECF0
		// [XID] // 0x000000018969ECB0-0x000000018969ECF0
		public override void ReturnToObjectPool() {} // 0x0000000188D48E90-0x0000000188D48F30
	}
}
