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
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class TalkCondEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14942
	{
		// Fields
		private QuestCondType _type; // 0x10
		private string[] _param; // 0x18
	
		// Properties
		public QuestCondType type { /* [XID] */ /* 0x0000000189B16E60-0x0000000189B16E80 */ get => default; /* [XID] */ /* 0x0000000189B8AC70-0x0000000189B8AC90 */ set {} } // 0x0000000186B702C0-0x0000000186B70360 0x0000000186B70410-0x0000000186B704C0
		public string[] param { /* [XID] */ /* 0x0000000189612350-0x0000000189612370 */ get => default; /* [XID] */ /* 0x0000000189B998C0-0x0000000189B998E0 */ set {} } // 0x0000000186B70220-0x0000000186B702C0 0x0000000186B70360-0x0000000186B70410
	
		// Constructors
		public TalkCondEx(QuestCondType type, string[] param) {} // 0x0000000186B70180-0x0000000186B70220
		public TalkCondEx() {} // 0x0000000186B70120-0x0000000186B70180
	
		// Methods
		// [XID] // 0x0000000189BA0E70-0x0000000189BA0E90
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000186B6FBC0-0x0000000186B6FC70
		// [XID] // 0x0000000189BA8510-0x0000000189BA8530
		public void InitEmpty() {} // 0x0000000186B6EF10-0x0000000186B6EFE0
		[BlackList] // 0x0000000189BAF980-0x0000000189BAF9C0
		// [XID] // 0x0000000189BAF980-0x0000000189BAF9C0
		public bool FromJson(JSONNode node) => default; // 0x0000000186B6EAA0-0x0000000186B6EE20
		// [XID] // 0x0000000189BB9EE0-0x0000000189BB9F00
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000186B6F280-0x0000000186B6F540
		// [XID] // 0x0000000189BC1F10-0x0000000189BC1F30
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB14 */, bool useObjectPool = false /* Metadata: 0x00AEFB18 */) => default; // 0x0000000186B6E7A0-0x0000000186B6EAA0
		// [XID] // 0x0000000189BC9400-0x0000000189BC9420
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB19 */, bool useObjectPool = false /* Metadata: 0x00AEFB1D */) => default; // 0x0000000186B6EFE0-0x0000000186B6F280
		[BlackList] // 0x0000000189BD0BF0-0x0000000189BD0C30
		// [XID] // 0x0000000189BD0BF0-0x0000000189BD0C30
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000186B6FE50-0x0000000186B70120
		// [XID] // 0x0000000189BDB5E0-0x0000000189BDB600
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000186B6F540-0x0000000186B6F7B0
		[BlackList] // 0x00000001895E7F30-0x00000001895E7F70
		// [XID] // 0x00000001895E7F30-0x00000001895E7F70
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B6E660-0x0000000186B6E700
		[BlackList] // 0x00000001895F25D0-0x00000001895F2610
		// [XID] // 0x00000001895F25D0-0x00000001895F2610
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B6E700-0x0000000186B6E7A0
		[BlackList] // 0x00000001895FCD50-0x00000001895FCD90
		// [XID] // 0x00000001895FCD50-0x00000001895FCD90
		public virtual void ReturnToObjectPool() {} // 0x0000000186B6FDB0-0x0000000186B6FE50
		[BlackList] // 0x0000000189607520-0x0000000189607560
		// [XID] // 0x0000000189607520-0x0000000189607560
		public virtual void OnPoolAllocated() {} // 0x0000000186B6FD10-0x0000000186B6FDB0
		[BlackList] // 0x0000000189611EC0-0x0000000189611F00
		// [XID] // 0x0000000189611EC0-0x0000000189611F00
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B6FC70-0x0000000186B6FD10
		// [XID] // 0x000000018961C760-0x000000018961C780
		public bool IsValid(uint mainQuestId, uint npcConfigId, uint talkId) => default; // 0x0000000186B6F7B0-0x0000000186B6FBC0
		// [XID] // 0x0000000189623BC0-0x0000000189623BE0
		public uint GetGivingId() => default; // 0x0000000186B6EE20-0x0000000186B6EF10
	}
}
