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
using UnityEngine.Serialization;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[Serializable]
	[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
	public class ConfigPlatformUIAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18635
	{
		// Fields
		private string[] _paths; // 0x10
		private SimpleSafeFloat indentRawNum; // 0x18
		private SimpleSafeFloat scaleRawNum; // 0x1C
		private SimpleSafeFloat topRawNum; // 0x20
		private SimpleSafeFloat bottomRawNum; // 0x24
		private SimpleSafeFloat leftRawNum; // 0x28
		private SimpleSafeFloat rightRawNum; // 0x2C
		private SimpleSafeFloat posxRawNum; // 0x30
		private SimpleSafeFloat posyRawNum; // 0x34
		private SimpleSafeInt32 activeRawNum; // 0x38
		private SimpleSafeInt32 firstActiveRawNum; // 0x3C
		private string _animation; // 0x40
		// [FormerlySerializedAs] // 0x0000000189AAFF90-0x0000000189AAFFC0
		public float indentFromMonoScript; // 0x48
		// [FormerlySerializedAs] // 0x0000000189AB8D60-0x0000000189AB8D90
		public float scaleFromMonoScript; // 0x4C
		// [FormerlySerializedAs] // 0x0000000189AC2310-0x0000000189AC2340
		public float topFromMonoScript; // 0x50
		// [FormerlySerializedAs] // 0x0000000189ACB2A0-0x0000000189ACB2D0
		public float bottomFromMonoScript; // 0x54
		// [FormerlySerializedAs] // 0x0000000189AD46B0-0x0000000189AD46E0
		public float leftFromMonoScript; // 0x58
		// [FormerlySerializedAs] // 0x0000000189ADDB10-0x0000000189ADDB40
		public float rightFromMonoScript; // 0x5C
		// [FormerlySerializedAs] // 0x0000000189AE6A80-0x0000000189AE6AB0
		public float posxFromMonoScript; // 0x60
		// [FormerlySerializedAs] // 0x0000000189AEFE80-0x0000000189AEFEB0
		public float posyFromMonoScript; // 0x64
		// [FormerlySerializedAs] // 0x0000000189AF8C80-0x0000000189AF8CB0
		public int activeFromMonoScript; // 0x68
		// [FormerlySerializedAs] // 0x0000000189B019E0-0x0000000189B01A10
		public int firstActiveFromMonoScript; // 0x6C
		// [FormerlySerializedAs] // 0x0000000189B0A9D0-0x0000000189B0AA00
		public string[] pathsFromMonoScript; // 0x70
		// [FormerlySerializedAs] // 0x0000000189B135E0-0x0000000189B13610
		public string animationFromMonoScript; // 0x78
	
		// Properties
		public string[] paths { /* [XID] */ /* 0x0000000189AD5770-0x0000000189AD5790 */ get => default; /* [XID] */ /* 0x0000000189B23D00-0x0000000189B23D20 */ private set {} } // 0x000000018884A3D0-0x000000018884A470 0x000000018884ADE0-0x000000018884AE90
		public float indent { /* [XID] */ /* 0x0000000189B2B040-0x0000000189B2B060 */ get => default; /* [XID] */ /* 0x0000000189B325E0-0x0000000189B32600 */ private set {} } // 0x000000018884A210-0x000000018884A2F0 0x000000018884AC20-0x000000018884AD00
		public float scale { /* [XID] */ /* 0x0000000189AF3970-0x0000000189AF3990 */ get => default; /* [XID] */ /* 0x0000000189B41810-0x0000000189B41830 */ private set {} } // 0x000000018884A710-0x000000018884A7F0 0x000000018884B130-0x000000018884B210
		public float top { /* [XID] */ /* 0x0000000189B491C0-0x0000000189B491E0 */ get => default; /* [XID] */ /* 0x0000000189B50840-0x0000000189B50860 */ private set {} } // 0x000000018884A7F0-0x000000018884A8D0 0x000000018884B210-0x000000018884B380
		public float bottom { /* [XID] */ /* 0x0000000189B58180-0x0000000189B581A0 */ get => default; /* [XID] */ /* 0x0000000189B5FAA0-0x0000000189B5FAC0 */ private set {} } // 0x000000018884A060-0x000000018884A140 0x000000018884AA60-0x000000018884AB40
		public float left { /* [XID] */ /* 0x0000000189784310-0x0000000189784330 */ get => default; /* [XID] */ /* 0x0000000189B6E420-0x0000000189B6E440 */ private set {} } // 0x000000018884A2F0-0x000000018884A3D0 0x000000018884AD00-0x000000018884ADE0
		public float right { /* [XID] */ /* 0x0000000189B75BD0-0x0000000189B75BF0 */ get => default; /* [XID] */ /* 0x0000000189B7D080-0x0000000189B7D0A0 */ private set {} } // 0x000000018884A630-0x000000018884A710 0x000000018884B050-0x000000018884B130
		public float posx { /* [XID] */ /* 0x0000000189B84ED0-0x0000000189B84EF0 */ get => default; /* [XID] */ /* 0x0000000189B8BCC0-0x0000000189B8BCE0 */ private set {} } // 0x000000018884A470-0x000000018884A550 0x000000018884AE90-0x000000018884AF70
		public float posy { /* [XID] */ /* 0x0000000189B09E10-0x0000000189B09E30 */ get => default; /* [XID] */ /* 0x0000000189B9AAA0-0x0000000189B9AAC0 */ private set {} } // 0x000000018884A550-0x000000018884A630 0x000000018884AF70-0x000000018884B050
		public int active { /* [XID] */ /* 0x0000000189B3D790-0x0000000189B3D7B0 */ get => default; /* [XID] */ /* 0x0000000189BA9620-0x0000000189BA9640 */ private set {} } // 0x0000000188849EF0-0x0000000188849FC0 0x000000018884A8D0-0x000000018884A9B0
		public int firstActive { /* [XID] */ /* 0x0000000189BB0E10-0x0000000189BB0E30 */ get => default; /* [XID] */ /* 0x0000000189BB7FA0-0x0000000189BB7FC0 */ private set {} } // 0x000000018884A140-0x000000018884A210 0x000000018884AB40-0x000000018884AC20
		public string animation { /* [XID] */ /* 0x0000000189B88780-0x0000000189B887A0 */ get => default; /* [XID] */ /* 0x0000000189BC7340-0x0000000189BC7360 */ private set {} } // 0x0000000188849FC0-0x000000018884A060 0x000000018884A9B0-0x000000018884AA60
	
		// Constructors
		public ConfigPlatformUIAction() {} // 0x0000000188849E90-0x0000000188849EF0
	
		// Methods
		// [XID] // 0x0000000189BCF050-0x0000000189BCF070
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188849AA0-0x0000000188849CB0
		// [XID] // 0x0000000189BD6420-0x0000000189BD6440
		public void InitEmpty() {} // 0x0000000188848DA0-0x0000000188848F60
		[BlackList] // 0x0000000189BDDEE0-0x0000000189BDDF20
		// [XID] // 0x0000000189BDDEE0-0x0000000189BDDF20
		public bool FromJson(JSONNode node) => default; // 0x0000000188848A20-0x0000000188848DA0
		// [XID] // 0x0000000189B36240-0x0000000189B36260
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000188846C70-0x0000000188847A20
		// [XID] // 0x00000001895F51B0-0x00000001895F51D0
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA689 */, bool useObjectPool = false /* Metadata: 0x00AFA68D */) => default; // 0x0000000188848F60-0x0000000188849260
		// [XID] // 0x0000000189A4DA50-0x0000000189A4DA70
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA68E */, bool useObjectPool = false /* Metadata: 0x00AFA692 */) => default; // 0x00000001888480C0-0x0000000188848A20
		[BlackList] // 0x0000000189604130-0x0000000189604170
		// [XID] // 0x0000000189604130-0x0000000189604170
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188847B70-0x0000000188847E40
		// [XID] // 0x000000018960E8C0-0x000000018960E8E0
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188849260-0x0000000188849AA0
		[BlackList] // 0x0000000189615F20-0x0000000189615F60
		// [XID] // 0x0000000189615F20-0x0000000189615F60
		public virtual void AutoAllocTypeFields() {} // 0x0000000188847E40-0x0000000188847EE0
		[BlackList] // 0x00000001896207C0-0x0000000189620800
		// [XID] // 0x00000001896207C0-0x0000000189620800
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188847EE0-0x00000001888480C0
		[BlackList] // 0x000000018962AD60-0x000000018962ADA0
		// [XID] // 0x000000018962AD60-0x000000018962ADA0
		public virtual void ReturnToObjectPool() {} // 0x0000000188849DF0-0x0000000188849E90
		[BlackList] // 0x0000000189635A50-0x0000000189635A90
		// [XID] // 0x0000000189635A50-0x0000000189635A90
		public virtual void OnPoolAllocated() {} // 0x0000000188849D50-0x0000000188849DF0
		[BlackList] // 0x000000018963FE10-0x000000018963FE50
		// [XID] // 0x000000018963FE10-0x000000018963FE50
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188849CB0-0x0000000188849D50
		// [XID] // 0x000000018964A680-0x000000018964A6A0
		public void LoadFromMonoScript() {} // 0x0000000188847A20-0x0000000188847B70
	}
}
