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
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigInterFade : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18372
	{
		// Fields
		private float _startFadeInDuration; // 0x10
		private float _startFadeOutDuration; // 0x14
	
		// Properties
		public float startFadeInDuration { /* [XID] */ /* 0x00000001899A4990-0x00000001899A49B0 */ get => default; /* [XID] */ /* 0x00000001899AC3D0-0x00000001899AC3F0 */ private set {} } // 0x0000000188829A60-0x0000000188829B10 0x0000000188829BC0-0x0000000188829C70
		public float startFadeOutDuration { /* [XID] */ /* 0x00000001899B3BE0-0x00000001899B3C00 */ get => default; /* [XID] */ /* 0x00000001899BAFF0-0x00000001899BB010 */ private set {} } // 0x0000000188829B10-0x0000000188829BC0 0x0000000188829C70-0x0000000188829D20
	
		// Constructors
		public ConfigInterFade() {} // 0x00000001888299F0-0x0000000188829A60
	
		// Methods
		// [XID] // 0x00000001899C29C0-0x00000001899C29E0
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188829430-0x0000000188829540
		// [XID] // 0x00000001899CA040-0x00000001899CA060
		public void InitEmpty() {} // 0x0000000188828C80-0x0000000188828D20
		[BlackList] // 0x00000001899D18C0-0x00000001899D1900
		// [XID] // 0x00000001899D18C0-0x00000001899D1900
		public bool FromJson(JSONNode node) => default; // 0x0000000188828900-0x0000000188828C80
		// [XID] // 0x00000001899DBD10-0x00000001899DBD30
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000188828F70-0x00000001888291F0
		// [XID] // 0x00000001899E3730-0x00000001899E3750
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9681 */, bool useObjectPool = false /* Metadata: 0x00AF9685 */) => default; // 0x0000000188828600-0x0000000188828900
		// [XID] // 0x00000001899EAAE0-0x00000001899EAB00
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9686 */, bool useObjectPool = false /* Metadata: 0x00AF968A */) => default; // 0x0000000188828D20-0x0000000188828F70
		[BlackList] // 0x00000001899F26C0-0x00000001899F2700
		// [XID] // 0x00000001899F26C0-0x00000001899F2700
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188829720-0x00000001888299F0
		// [XID] // 0x00000001899FCD10-0x00000001899FCD30
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001888291F0-0x0000000188829430
		[BlackList] // 0x0000000189A04170-0x0000000189A041B0
		// [XID] // 0x0000000189A04170-0x0000000189A041B0
		public virtual void AutoAllocTypeFields() {} // 0x00000001888284B0-0x0000000188828550
		[BlackList] // 0x0000000189A0E7D0-0x0000000189A0E810
		// [XID] // 0x0000000189A0E7D0-0x0000000189A0E810
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188828550-0x0000000188828600
		[BlackList] // 0x0000000189A18CF0-0x0000000189A18D30
		// [XID] // 0x0000000189A18CF0-0x0000000189A18D30
		public virtual void ReturnToObjectPool() {} // 0x0000000188829680-0x0000000188829720
		[BlackList] // 0x0000000189A23460-0x0000000189A234A0
		// [XID] // 0x0000000189A23460-0x0000000189A234A0
		public virtual void OnPoolAllocated() {} // 0x00000001888295E0-0x0000000188829680
		[BlackList] // 0x0000000189A2D4F0-0x0000000189A2D530
		// [XID] // 0x0000000189A2D4F0-0x0000000189A2D530
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188829540-0x00000001888295E0
	}
}
