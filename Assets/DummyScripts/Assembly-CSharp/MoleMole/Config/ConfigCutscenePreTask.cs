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
	public class ConfigCutscenePreTask : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17780
	{
		// Fields
		private float _duration; // 0x10
		private float _targetDayTime; // 0x14
		private string _targetWeather; // 0x18
	
		// Properties
		public float duration { /* [XID] */ /* 0x00000001898141F0-0x0000000189814210 */ get => default; /* [XID] */ /* 0x000000018981BD80-0x000000018981BDA0 */ private set {} } // 0x0000000188B8C240-0x0000000188B8C2F0 0x0000000188B8C440-0x0000000188B8C4F0
		public float targetDayTime { /* [XID] */ /* 0x0000000189823230-0x0000000189823250 */ get => default; /* [XID] */ /* 0x000000018982AC30-0x000000018982AC50 */ private set {} } // 0x0000000188B8C2F0-0x0000000188B8C3A0 0x0000000188B8C4F0-0x0000000188B8C5A0
		public string targetWeather { /* [XID] */ /* 0x0000000189832090-0x00000001898320B0 */ get => default; /* [XID] */ /* 0x0000000189839860-0x0000000189839880 */ private set {} } // 0x0000000188B8C3A0-0x0000000188B8C440 0x0000000188B8C5A0-0x0000000188B8C650
	
		// Constructors
		public ConfigCutscenePreTask() {} // 0x0000000188B8C1E0-0x0000000188B8C240
	
		// Methods
		// [XID] // 0x0000000189840D40-0x0000000189840D60
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B8BC10-0x0000000188B8BD30
		// [XID] // 0x0000000189848180-0x00000001898481A0
		public void InitEmpty() {} // 0x0000000188B8B220-0x0000000188B8B2F0
		[BlackList] // 0x000000018984F8C0-0x000000018984F900
		// [XID] // 0x000000018984F8C0-0x000000018984F900
		public bool FromJson(JSONNode node) => default; // 0x0000000188B8AEA0-0x0000000188B8B220
		// [XID] // 0x0000000189859F70-0x0000000189859F90
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000188B8B5F0-0x0000000188B8B950
		// [XID] // 0x0000000189860FF0-0x0000000189861010
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BF5 */, bool useObjectPool = false /* Metadata: 0x00AF7BF9 */) => default; // 0x0000000188B8ABA0-0x0000000188B8AEA0
		// [XID] // 0x0000000189868810-0x0000000189868830
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BFA */, bool useObjectPool = false /* Metadata: 0x00AF7BFE */) => default; // 0x0000000188B8B2F0-0x0000000188B8B5F0
		[BlackList] // 0x000000018986FC60-0x000000018986FCA0
		// [XID] // 0x000000018986FC60-0x000000018986FCA0
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B8BF10-0x0000000188B8C1E0
		// [XID] // 0x000000018987A850-0x000000018987A870
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B8B950-0x0000000188B8BC10
		[BlackList] // 0x00000001898819A0-0x00000001898819E0
		// [XID] // 0x00000001898819A0-0x00000001898819E0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188B8AA60-0x0000000188B8AB00
		[BlackList] // 0x000000018988BD40-0x000000018988BD80
		// [XID] // 0x000000018988BD40-0x000000018988BD80
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188B8AB00-0x0000000188B8ABA0
		[BlackList] // 0x0000000189896060-0x00000001898960A0
		// [XID] // 0x0000000189896060-0x00000001898960A0
		public virtual void ReturnToObjectPool() {} // 0x0000000188B8BE70-0x0000000188B8BF10
		[BlackList] // 0x00000001898A05F0-0x00000001898A0630
		// [XID] // 0x00000001898A05F0-0x00000001898A0630
		public virtual void OnPoolAllocated() {} // 0x0000000188B8BDD0-0x0000000188B8BE70
		[BlackList] // 0x00000001898AAAC0-0x00000001898AAB00
		// [XID] // 0x00000001898AAAC0-0x00000001898AAB00
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188B8BD30-0x0000000188B8BDD0
	}
}
