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
	public class ConfigWaypoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18501
	{
		// Fields
		private Vector _pos; // 0x10
		private float _waitTime; // 0x1C
		private float _moveAngularSpeed; // 0x20
		private float _waitAngularSpeed; // 0x24
		private float _moveRotateRound; // 0x28
		private float _waitRotateRound; // 0x2C
		private bool _stopWaitRotate; // 0x30
		private int _speedLevel; // 0x34
		private float _targetVelocity; // 0x38
		private bool _hasReachEvent; // 0x3C
		private float _rotAngleMoveSpeed; // 0x40
		private float _rotAngleWaitSpeed; // 0x44
		private bool _rotAngleSameStop; // 0x48
		private Vector _rotRoundReachDir; // 0x4C
		private int _rotRoundReachRounds; // 0x58
		private Vector _rotRoundLeaveDir; // 0x5C
		private int _rotRoundWaitRounds; // 0x68
		private bool _reachStop; // 0x6C
	
		// Properties
		public Vector pos { /* [XID] */ /* 0x0000000189A277C0-0x0000000189A277E0 */ get => default; /* [XID] */ /* 0x0000000189A2EEF0-0x0000000189A2EF10 */ set {} } // 0x0000000188D4F830-0x0000000188D4F910 0x0000000188D504C0-0x0000000188D50590
		public float waitTime { /* [XID] */ /* 0x0000000189A368B0-0x0000000189A368D0 */ get => default; /* [XID] */ /* 0x0000000189A3DE50-0x0000000189A3DE70 */ set {} } // 0x0000000188D50200-0x0000000188D502B0 0x0000000188D50EC0-0x0000000188D50F70
		public float moveAngularSpeed { /* [XID] */ /* 0x0000000189A455E0-0x0000000189A45600 */ get => default; /* [XID] */ /* 0x0000000189A4CBC0-0x0000000189A4CBE0 */ set {} } // 0x0000000188D4F6D0-0x0000000188D4F780 0x0000000188D50360-0x0000000188D50410
		public float waitAngularSpeed { /* [XID] */ /* 0x0000000189A54470-0x0000000189A54490 */ get => default; /* [XID] */ /* 0x0000000189A5BFA0-0x0000000189A5BFC0 */ set {} } // 0x0000000188D500A0-0x0000000188D50150 0x0000000188D50D60-0x0000000188D50E10
		public float moveRotateRound { /* [XID] */ /* 0x0000000189A637D0-0x0000000189A637F0 */ get => default; /* [XID] */ /* 0x0000000189A6B0B0-0x0000000189A6B0D0 */ set {} } // 0x0000000188D4F780-0x0000000188D4F830 0x0000000188D50410-0x0000000188D504C0
		public float waitRotateRound { /* [XID] */ /* 0x0000000189A72870-0x0000000189A72890 */ get => default; /* [XID] */ /* 0x0000000189A7A3F0-0x0000000189A7A410 */ set {} } // 0x0000000188D50150-0x0000000188D50200 0x0000000188D50E10-0x0000000188D50EC0
		public bool stopWaitRotate { /* [XID] */ /* 0x0000000189A81850-0x0000000189A81870 */ get => default; /* [XID] */ /* 0x0000000189A893D0-0x0000000189A893F0 */ set {} } // 0x0000000188D4FF50-0x0000000188D4FFF0 0x0000000188D50C00-0x0000000188D50CB0
		public int speedLevel { /* [XID] */ /* 0x0000000189A90C10-0x0000000189A90C30 */ get => default; /* [XID] */ /* 0x0000000189A98380-0x0000000189A983A0 */ set {} } // 0x0000000188D4FEB0-0x0000000188D4FF50 0x0000000188D50B50-0x0000000188D50C00
		public float targetVelocity { /* [XID] */ /* 0x0000000189A9F7B0-0x0000000189A9F7D0 */ get => default; /* [XID] */ /* 0x0000000189AA7040-0x0000000189AA7060 */ set {} } // 0x0000000188D4FFF0-0x0000000188D500A0 0x0000000188D50CB0-0x0000000188D50D60
		public bool hasReachEvent { /* [XID] */ /* 0x0000000189AAE720-0x0000000189AAE740 */ get => default; /* [XID] */ /* 0x0000000189AB5F60-0x0000000189AB5F80 */ set {} } // 0x0000000188D4F630-0x0000000188D4F6D0 0x0000000188D502B0-0x0000000188D50360
		public float rotAngleMoveSpeed { /* [XID] */ /* 0x0000000189ABD9F0-0x0000000189ABDA10 */ get => default; /* [XID] */ /* 0x0000000189AC5550-0x0000000189AC5570 */ set {} } // 0x0000000188D4F9B0-0x0000000188D4FA60 0x0000000188D50640-0x0000000188D506F0
		public float rotAngleWaitSpeed { /* [XID] */ /* 0x0000000189ACC960-0x0000000189ACC980 */ get => default; /* [XID] */ /* 0x0000000189AD4700-0x0000000189AD4720 */ set {} } // 0x0000000188D4FB00-0x0000000188D4FBB0 0x0000000188D507A0-0x0000000188D50850
		public bool rotAngleSameStop { /* [XID] */ /* 0x0000000189ADC080-0x0000000189ADC0A0 */ get => default; /* [XID] */ /* 0x0000000189AE3A10-0x0000000189AE3A30 */ set {} } // 0x0000000188D4FA60-0x0000000188D4FB00 0x0000000188D506F0-0x0000000188D507A0
		public Vector rotRoundReachDir { /* [XID] */ /* 0x0000000189AEB2B0-0x0000000189AEB2D0 */ get => default; /* [XID] */ /* 0x0000000189AF2C50-0x0000000189AF2C70 */ set {} } // 0x0000000188D4FC90-0x0000000188D4FD70 0x0000000188D50920-0x0000000188D509F0
		public int rotRoundReachRounds { /* [XID] */ /* 0x0000000189AFA540-0x0000000189AFA560 */ get => default; /* [XID] */ /* 0x0000000189B01A10-0x0000000189B01A30 */ set {} } // 0x0000000188D4FD70-0x0000000188D4FE10 0x0000000188D509F0-0x0000000188D50AA0
		public Vector rotRoundLeaveDir { /* [XID] */ /* 0x0000000189B09030-0x0000000189B09050 */ get => default; /* [XID] */ /* 0x0000000189B10A70-0x0000000189B10A90 */ set {} } // 0x0000000188D4FBB0-0x0000000188D4FC90 0x0000000188D50850-0x0000000188D50920
		public int rotRoundWaitRounds { /* [XID] */ /* 0x0000000189B17B40-0x0000000189B17B60 */ get => default; /* [XID] */ /* 0x0000000189B1F500-0x0000000189B1F520 */ set {} } // 0x0000000188D4FE10-0x0000000188D4FEB0 0x0000000188D50AA0-0x0000000188D50B50
		public bool reachStop { /* [XID] */ /* 0x0000000189B26D40-0x0000000189B26D60 */ get => default; /* [XID] */ /* 0x0000000189B2DF30-0x0000000189B2DF50 */ set {} } // 0x0000000188D4F910-0x0000000188D4F9B0 0x0000000188D50590-0x0000000188D50640
	
		// Constructors
		public ConfigWaypoint() {} // 0x0000000188D4F5C0-0x0000000188D4F630
	
		// Methods
		// [XID] // 0x0000000189B35340-0x0000000189B35360
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D4F060-0x0000000188D4F110
		// [XID] // 0x0000000189B3CBE0-0x0000000189B3CC00
		public void InitEmpty() {} // 0x0000000188D4CB40-0x0000000188D4CC40
		[BlackList] // 0x0000000189B44890-0x0000000189B448D0
		// [XID] // 0x0000000189B44890-0x0000000189B448D0
		public bool FromJson(JSONNode node) => default; // 0x0000000188D4C7C0-0x0000000188D4CB40
		// [XID] // 0x0000000189B4EF30-0x0000000189B4EF50
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000188D4D6B0-0x0000000188D4E4F0
		// [XID] // 0x0000000189B56930-0x0000000189B56950
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F9F */, bool useObjectPool = false /* Metadata: 0x00AF9FA3 */) => default; // 0x0000000188D4C4C0-0x0000000188D4C7C0
		// [XID] // 0x0000000189B5E160-0x0000000189B5E180
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FA4 */, bool useObjectPool = false /* Metadata: 0x00AF9FA8 */) => default; // 0x0000000188D4CC40-0x0000000188D4D6B0
		[BlackList] // 0x0000000189B65600-0x0000000189B65640
		// [XID] // 0x0000000189B65600-0x0000000189B65640
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D4F2F0-0x0000000188D4F5C0
		// [XID] // 0x0000000189B6FD00-0x0000000189B6FD20
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D4E4F0-0x0000000188D4F060
		[BlackList] // 0x0000000189B771D0-0x0000000189B77210
		// [XID] // 0x0000000189B771D0-0x0000000189B77210
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D4C320-0x0000000188D4C3C0
		[BlackList] // 0x0000000189B81A30-0x0000000189B81A70
		// [XID] // 0x0000000189B81A30-0x0000000189B81A70
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D4C3C0-0x0000000188D4C4C0
		[BlackList] // 0x0000000189B8BCE0-0x0000000189B8BD20
		// [XID] // 0x0000000189B8BCE0-0x0000000189B8BD20
		public virtual void ReturnToObjectPool() {} // 0x0000000188D4F250-0x0000000188D4F2F0
		[BlackList] // 0x0000000189B961C0-0x0000000189B96200
		// [XID] // 0x0000000189B961C0-0x0000000189B96200
		public virtual void OnPoolAllocated() {} // 0x0000000188D4F1B0-0x0000000188D4F250
		[BlackList] // 0x0000000189BA06F0-0x0000000189BA0730
		// [XID] // 0x0000000189BA06F0-0x0000000189BA0730
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D4F110-0x0000000188D4F1B0
	}
}
