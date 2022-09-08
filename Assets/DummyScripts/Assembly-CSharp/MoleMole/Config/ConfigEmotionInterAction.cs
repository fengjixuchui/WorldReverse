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
	public sealed class ConfigEmotionInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 14936
	{
		// Fields
		private string _emotionName; // 0x30
		private float _emotionTransitionTime; // 0x38
		private Vector _lookAtOffset; // 0x3C
		private bool _blinkEnabled; // 0x48
		private float _blinkMinGap; // 0x4C
		private float _blinkMaxGap; // 0x50
		private float _blinkDuration; // 0x54
	
		// Properties
		public string emotionName { /* [XID] */ /* 0x0000000189694CC0-0x0000000189694CE0 */ get => default; /* [XID] */ /* 0x000000018969C440-0x000000018969C460 */ private set {} } // 0x0000000188B9ECD0-0x0000000188B9ED70 0x0000000188B9F1C0-0x0000000188B9F270
		public float emotionTransitionTime { /* [XID] */ /* 0x00000001896A38E0-0x00000001896A3900 */ get => default; /* [XID] */ /* 0x00000001896AAD70-0x00000001896AAD90 */ private set {} } // 0x0000000188B9ED70-0x0000000188B9EE20 0x0000000188B9F270-0x0000000188B9F320
		public Vector lookAtOffset { /* [XID] */ /* 0x00000001896B1DB0-0x00000001896B1DD0 */ get => default; /* [XID] */ /* 0x00000001896B9850-0x00000001896B9870 */ private set {} } // 0x0000000188B9EE20-0x0000000188B9EF00 0x0000000188B9F320-0x0000000188B9F3F0
		public bool blinkEnabled { /* [XID] */ /* 0x00000001896C0B80-0x00000001896C0BA0 */ get => default; /* [XID] */ /* 0x00000001896C8250-0x00000001896C8270 */ private set {} } // 0x0000000188B9EAD0-0x0000000188B9EB70 0x0000000188B9EFB0-0x0000000188B9F060
		public float blinkMinGap { /* [XID] */ /* 0x00000001896CFC10-0x00000001896CFC30 */ get => default; /* [XID] */ /* 0x00000001896D6E40-0x00000001896D6E60 */ private set {} } // 0x0000000188B9EC20-0x0000000188B9ECD0 0x0000000188B9F110-0x0000000188B9F1C0
		public float blinkMaxGap { /* [XID] */ /* 0x00000001896DE680-0x00000001896DE6A0 */ get => default; /* [XID] */ /* 0x00000001896E59F0-0x00000001896E5A10 */ private set {} } // 0x0000000188B9EB70-0x0000000188B9EC20 0x0000000188B9F060-0x0000000188B9F110
		public float blinkDuration { /* [XID] */ /* 0x00000001896ED060-0x00000001896ED080 */ get => default; /* [XID] */ /* 0x00000001896F48C0-0x00000001896F48E0 */ private set {} } // 0x0000000188B9EA20-0x0000000188B9EAD0 0x0000000188B9EF00-0x0000000188B9EFB0
	
		// Constructors
		public ConfigEmotionInterAction(InteractionType type, float duration, string emotionName, float emotionTransitionTime, Vector lookAtOffset, bool blinkEnabled, float blinkMinGap, float blinkMaxGap, float blinkDuration) {} // 0x0000000188B9E8F0-0x0000000188B9EA20
		public ConfigEmotionInterAction() {} // 0x0000000188B9E890-0x0000000188B9E8F0
	
		// Methods
		// [XID] // 0x00000001896FC150-0x00000001896FC170
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B9D8D0-0x0000000188B9DA90
		// [XID] // 0x0000000189703710-0x0000000189703730
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B9BE20-0x0000000188B9BF00
		// [XID] // 0x000000018970AD60-0x000000018970AD80
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFAC6 */) => default; // 0x0000000188B9BD30-0x0000000188B9BE20
		// [XID] // 0x0000000189712610-0x0000000189712630
		public override int GetHashNum() => default; // 0x0000000188B9C580-0x0000000188B9C650
		// [XID] // 0x0000000189719E90-0x0000000189719EB0
		public override void InitEmpty() {} // 0x0000000188B9C650-0x0000000188B9C740
		[BlackList] // 0x0000000189721390-0x00000001897213D0
		// [XID] // 0x0000000189721390-0x00000001897213D0
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B9C200-0x0000000188B9C580
		// [XID] // 0x000000018972B8F0-0x000000018972B910
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B9CCA0-0x0000000188B9D340
		[BlackList] // 0x00000001897330C0-0x0000000189733100
		// [XID] // 0x00000001897330C0-0x0000000189733100
		public static new ConfigEmotionInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188B9DC80-0x0000000188B9DEA0
		// [XID] // 0x000000018973DE10-0x000000018973DE30
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAC7 */, bool useObjectPool = false /* Metadata: 0x00AEFACB */) => default; // 0x0000000188B9BF00-0x0000000188B9C200
		// [XID] // 0x0000000189745250-0x0000000189745270
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFACC */, bool useObjectPool = false /* Metadata: 0x00AEFAD0 */) => default; // 0x0000000188B9C740-0x0000000188B9CCA0
		// [XID] // 0x000000018974CD20-0x000000018974CD40
		public static new ConfigEmotionInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAD1 */, bool useObjectPool = false /* Metadata: 0x00AEFAD5 */) => default; // 0x0000000188B9DA90-0x0000000188B9DC80
		[BlackList] // 0x00000001897540C0-0x0000000189754100
		// [XID] // 0x00000001897540C0-0x0000000189754100
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B9E030-0x0000000188B9E300
		// [XID] // 0x000000018975E790-0x000000018975E7B0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B9D340-0x0000000188B9D8D0
		[BlackList] // 0x0000000189765D30-0x0000000189765D70
		// [XID] // 0x0000000189765D30-0x0000000189765D70
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B9DF40-0x0000000188B9E030
		[BlackList] // 0x0000000189770410-0x0000000189770450
		// [XID] // 0x0000000189770410-0x0000000189770450
		public override void AutoAllocTypeFields() {} // 0x0000000188B9BBC0-0x0000000188B9BC60
		[BlackList] // 0x000000018977AA80-0x000000018977AAC0
		// [XID] // 0x000000018977AA80-0x000000018977AAC0
		public override void AutoRecycleTypeFields() {} // 0x0000000188B9BC60-0x0000000188B9BD30
		[BlackList] // 0x0000000189785460-0x00000001897854A0
		// [XID] // 0x0000000189785460-0x00000001897854A0
		public override void ReturnToObjectPool() {} // 0x0000000188B9DEA0-0x0000000188B9DF40
	}
}
