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
	public class ConfigTimeline : ConfigBaseCutscene, IAutoAllocRecycle // TypeDefIndex: 14931
	{
		// Fields
		private bool _syncLoad; // 0x90
		private float _fadeInDuration; // 0x94
		private float _fadeOutDuration; // 0x98
		private bool _forceGC; // 0x9C
	
		// Properties
		public bool syncLoad { /* [XID] */ /* 0x00000001897E4970-0x00000001897E4990 */ get => default; /* [XID] */ /* 0x00000001897EC580-0x00000001897EC5A0 */ private set {} } // 0x0000000188D440C0-0x0000000188D44170 0x0000000188D44380-0x0000000188D44430
		public float fadeInDuration { /* [XID] */ /* 0x00000001897F3EF0-0x00000001897F3F10 */ get => default; /* [XID] */ /* 0x00000001897FB870-0x00000001897FB890 */ private set {} } // 0x0000000188D43EB0-0x0000000188D43F60 0x0000000188D44170-0x0000000188D44220
		public float fadeOutDuration { /* [XID] */ /* 0x0000000189802D00-0x0000000189802D20 */ get => default; /* [XID] */ /* 0x000000018980A290-0x000000018980A2B0 */ private set {} } // 0x0000000188D43F60-0x0000000188D44010 0x0000000188D44220-0x0000000188D442D0
		public bool forceGC { /* [XID] */ /* 0x00000001898119C0-0x00000001898119E0 */ get => default; /* [XID] */ /* 0x0000000189819650-0x0000000189819670 */ private set {} } // 0x0000000188D44010-0x0000000188D440C0 0x0000000188D442D0-0x0000000188D44380
	
		// Constructors
		public ConfigTimeline(CutsceneType type, string resPath, CutsceneInitPosType startPosType, bool useTargetPos, Vector startOffset, bool syncLoad, bool forceGC = true /* Metadata: 0x00AEFA75 */) {} // 0x0000000188D43D30-0x0000000188D43E30
		public ConfigTimeline() {} // 0x0000000188D43E30-0x0000000188D43EB0
	
		// Methods
		// [XID] // 0x0000000189820D50-0x0000000189820D70
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D42D80-0x0000000188D42ED0
		// [XID] // 0x0000000189828340-0x0000000189828360
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188D41940-0x0000000188D419F0
		// [XID] // 0x000000018982F620-0x000000018982F640
		public override ConfigBaseCutscene Clone(bool useObjectPool = false /* Metadata: 0x00AEFA76 */) => default; // 0x0000000188D41860-0x0000000188D41940
		// [XID] // 0x0000000189836F30-0x0000000189836F50
		public override int GetHashNum() => default; // 0x0000000188D42070-0x0000000188D42140
		// [XID] // 0x000000018983E360-0x000000018983E380
		public override void InitEmpty() {} // 0x0000000188D42140-0x0000000188D421E0
		[BlackList] // 0x0000000189845AD0-0x0000000189845B10
		// [XID] // 0x0000000189845AD0-0x0000000189845B10
		public override bool FromJson(JSONNode node) => default; // 0x0000000188D41CF0-0x0000000188D42070
		// [XID] // 0x000000018984FD40-0x000000018984FD60
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188D42590-0x0000000188D429D0
		[BlackList] // 0x00000001898571A0-0x00000001898571E0
		// [XID] // 0x00000001898571A0-0x00000001898571E0
		public static new ConfigTimeline ParseFromJson(JSONNode node) => default; // 0x0000000188D430F0-0x0000000188D43340
		// [XID] // 0x00000001898615D0-0x00000001898615F0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA77 */, bool useObjectPool = false /* Metadata: 0x00AEFA7B */) => default; // 0x0000000188D419F0-0x0000000188D41CF0
		// [XID] // 0x0000000189868DB0-0x0000000189868DD0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA7C */, bool useObjectPool = false /* Metadata: 0x00AEFA80 */) => default; // 0x0000000188D421E0-0x0000000188D42590
		// [XID] // 0x00000001898701E0-0x0000000189870200
		public static new ConfigTimeline ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA81 */, bool useObjectPool = false /* Metadata: 0x00AEFA85 */) => default; // 0x0000000188D42ED0-0x0000000188D430F0
		[BlackList] // 0x0000000189877810-0x0000000189877850
		// [XID] // 0x0000000189877810-0x0000000189877850
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D434D0-0x0000000188D437A0
		// [XID] // 0x0000000189881D40-0x0000000189881D60
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D429D0-0x0000000188D42D80
		[BlackList] // 0x00000001898894C0-0x0000000189889500
		// [XID] // 0x00000001898894C0-0x0000000189889500
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188D433E0-0x0000000188D434D0
		[BlackList] // 0x00000001898938F0-0x0000000189893930
		// [XID] // 0x00000001898938F0-0x0000000189893930
		public override void AutoAllocTypeFields() {} // 0x0000000188D41700-0x0000000188D417A0
		[BlackList] // 0x000000018989DC40-0x000000018989DC80
		// [XID] // 0x000000018989DC40-0x000000018989DC80
		public override void AutoRecycleTypeFields() {} // 0x0000000188D417A0-0x0000000188D41860
		[BlackList] // 0x00000001898A8130-0x00000001898A8170
		// [XID] // 0x00000001898A8130-0x00000001898A8170
		public override void ReturnToObjectPool() {} // 0x0000000188D43340-0x0000000188D433E0
	}
}
