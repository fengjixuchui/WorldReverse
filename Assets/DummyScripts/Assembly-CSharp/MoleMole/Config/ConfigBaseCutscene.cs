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
	public class ConfigBaseCutscene : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14929
	{
		// Fields
		private CutsceneType _type; // 0x10
		// [PooledField] // 0x0000000189951E30-0x0000000189951E50
		private ConfigCutscenePreTask _preTaskCfg; // 0x18
		private bool _canSkip; // 0x20
		private bool _forceCanSkip; // 0x21
		private bool _skipGeneralDialog; // 0x22
		private bool _can; // 0x23
		private bool _clearBlackScreen; // 0x24
		private float _fadeOutWhenFinish; // 0x28
		private bool _directTransmit; // 0x2C
		private float _delayTransmit; // 0x30
		private string _luaDataPath; // 0x38
		private string _resPath; // 0x40
		private string _castListPath; // 0x48
		private string _entityBan; // 0x50
		private CutsceneInitPosType _startPosType; // 0x58
		private Vector _startOffset; // 0x5C
		private bool _needXZEuler; // 0x68
		private bool _needYEuler; // 0x69
		private bool _keepCamera; // 0x6A
		private bool _useTargetPos; // 0x6B
		private Vector _targetPos; // 0x6C
		private bool _modifyLastPoseOffset; // 0x78
		private bool _attackModeRecover; // 0x79
		private int[] _crowdLOD0List; // 0x80
		private bool _enableCameraDisplacement; // 0x88
	
		// Properties
		public CutsceneType type { /* [XID] */ /* 0x0000000189A51C70-0x0000000189A51C90 */ get => default; /* [XID] */ /* 0x0000000189A593E0-0x0000000189A59400 */ private set {} } // 0x0000000187DF8560-0x0000000187DF8600 0x0000000187DF96B0-0x0000000187DF9760
		public ConfigCutscenePreTask preTaskCfg { /* [XID] */ /* 0x0000000189A60D80-0x0000000189A60DA0 */ get => default; /* [XID] */ /* 0x0000000189A689F0-0x0000000189A68A10 */ private set {} } // 0x0000000187DF8120-0x0000000187DF81C0 0x0000000187DF9250-0x0000000187DF9300
		public bool canSkip { /* [XID] */ /* 0x0000000189A6FDC0-0x0000000189A6FDE0 */ get => default; /* [XID] */ /* 0x0000000189A77550-0x0000000189A77570 */ private set {} } // 0x0000000187DF76E0-0x0000000187DF7780 0x0000000187DF8750-0x0000000187DF8800
		public bool forceCanSkip { /* [XID] */ /* 0x0000000189A7EE00-0x0000000189A7EE20 */ get => default; /* [XID] */ /* 0x0000000189A866B0-0x0000000189A866D0 */ private set {} } // 0x0000000187DF7D60-0x0000000187DF7E00 0x0000000187DF8E30-0x0000000187DF8EE0
		public bool skipGeneralDialog { /* [XID] */ /* 0x0000000189A8E290-0x0000000189A8E2B0 */ get => default; /* [XID] */ /* 0x0000000189A95790-0x0000000189A957B0 */ private set {} } // 0x0000000187DF8260-0x0000000187DF8300 0x0000000187DF93B0-0x0000000187DF9460
		public bool can { /* [XID] */ /* 0x0000000189A9D030-0x0000000189A9D050 */ get => default; /* [XID] */ /* 0x0000000189AA4640-0x0000000189AA4660 */ private set {} } // 0x0000000187DF7780-0x0000000187DF7820 0x0000000187DF8800-0x0000000187DF88B0
		public bool clearBlackScreen { /* [XID] */ /* 0x0000000189AABD10-0x0000000189AABD30 */ get => default; /* [XID] */ /* 0x0000000189AB3640-0x0000000189AB3660 */ private set {} } // 0x0000000187DF78C0-0x0000000187DF7960 0x0000000187DF8960-0x0000000187DF8A10
		public float fadeOutWhenFinish { /* [XID] */ /* 0x0000000189ABB3D0-0x0000000189ABB3F0 */ get => default; /* [XID] */ /* 0x0000000189AC2B20-0x0000000189AC2B40 */ private set {} } // 0x0000000187DF7CB0-0x0000000187DF7D60 0x0000000187DF8D80-0x0000000187DF8E30
		public bool directTransmit { /* [XID] */ /* 0x0000000189ACA180-0x0000000189ACA1A0 */ get => default; /* [XID] */ /* 0x0000000189AD1A10-0x0000000189AD1A30 */ private set {} } // 0x0000000187DF7AC0-0x0000000187DF7B60 0x0000000187DF8B70-0x0000000187DF8C20
		public float delayTransmit { /* [XID] */ /* 0x0000000189AD96F0-0x0000000189AD9710 */ get => default; /* [XID] */ /* 0x0000000189AE1160-0x0000000189AE1180 */ private set {} } // 0x0000000187DF7A10-0x0000000187DF7AC0 0x0000000187DF8AC0-0x0000000187DF8B70
		public string luaDataPath { /* [XID] */ /* 0x0000000189AE8690-0x0000000189AE86B0 */ get => default; /* [XID] */ /* 0x0000000189AF05B0-0x0000000189AF05D0 */ private set {} } // 0x0000000187DF7EA0-0x0000000187DF7F40 0x0000000187DF8F90-0x0000000187DF9040
		public string resPath { /* [XID] */ /* 0x0000000189AF7A80-0x0000000189AF7AA0 */ get => default; /* [XID] */ /* 0x0000000189AFEFD0-0x0000000189AFEFF0 */ private set {} } // 0x0000000187DF81C0-0x0000000187DF8260 0x0000000187DF9300-0x0000000187DF93B0
		public string castListPath { /* [XID] */ /* 0x0000000189B06860-0x0000000189B06880 */ get => default; /* [XID] */ /* 0x0000000189B0DFF0-0x0000000189B0E010 */ private set {} } // 0x0000000187DF7820-0x0000000187DF78C0 0x0000000187DF88B0-0x0000000187DF8960
		public string entityBan { /* [XID] */ /* 0x0000000189B152B0-0x0000000189B152D0 */ get => default; /* [XID] */ /* 0x0000000189B1CD90-0x0000000189B1CDB0 */ private set {} } // 0x0000000187DF7C10-0x0000000187DF7CB0 0x0000000187DF8CD0-0x0000000187DF8D80
		public CutsceneInitPosType startPosType { /* [XID] */ /* 0x0000000189B24340-0x0000000189B24360 */ get => default; /* [XID] */ /* 0x0000000189B2B6B0-0x0000000189B2B6D0 */ private set {} } // 0x0000000187DF83E0-0x0000000187DF8480 0x0000000187DF9530-0x0000000187DF95E0
		public Vector startOffset { /* [XID] */ /* 0x0000000189B32C20-0x0000000189B32C40 */ get => default; /* [XID] */ /* 0x0000000189B3A4B0-0x0000000189B3A4D0 */ private set {} } // 0x0000000187DF8300-0x0000000187DF83E0 0x0000000187DF9460-0x0000000187DF9530
		public bool needXZEuler { /* [XID] */ /* 0x0000000189B41F30-0x0000000189B41F50 */ get => default; /* [XID] */ /* 0x0000000189B49920-0x0000000189B49940 */ private set {} } // 0x0000000187DF7FE0-0x0000000187DF8080 0x0000000187DF90F0-0x0000000187DF91A0
		public bool needYEuler { /* [XID] */ /* 0x0000000189B50FA0-0x0000000189B50FC0 */ get => default; /* [XID] */ /* 0x0000000189B587D0-0x0000000189B587F0 */ private set {} } // 0x0000000187DF8080-0x0000000187DF8120 0x0000000187DF91A0-0x0000000187DF9250
		public bool keepCamera { /* [XID] */ /* 0x0000000189B60180-0x0000000189B601A0 */ get => default; /* [XID] */ /* 0x0000000189B678E0-0x0000000189B67900 */ private set {} } // 0x0000000187DF7E00-0x0000000187DF7EA0 0x0000000187DF8EE0-0x0000000187DF8F90
		public bool useTargetPos { /* [XID] */ /* 0x0000000189B6EB60-0x0000000189B6EB80 */ get => default; /* [XID] */ /* 0x0000000189B762B0-0x0000000189B762D0 */ private set {} } // 0x0000000187DF8600-0x0000000187DF86A0 0x0000000187DF9760-0x0000000187DF9810
		public Vector targetPos { /* [XID] */ /* 0x0000000189B7D840-0x0000000189B7D860 */ get => default; /* [XID] */ /* 0x0000000189B855D0-0x0000000189B855F0 */ private set {} } // 0x0000000187DF8480-0x0000000187DF8560 0x0000000187DF95E0-0x0000000187DF96B0
		public bool modifyLastPoseOffset { /* [XID] */ /* 0x0000000189B8C340-0x0000000189B8C360 */ get => default; /* [XID] */ /* 0x0000000189B93C10-0x0000000189B93C30 */ private set {} } // 0x0000000187DF7F40-0x0000000187DF7FE0 0x0000000187DF9040-0x0000000187DF90F0
		public bool attackModeRecover { /* [XID] */ /* 0x0000000189B9B220-0x0000000189B9B240 */ get => default; /* [XID] */ /* 0x0000000189BA29B0-0x0000000189BA29D0 */ private set {} } // 0x0000000187DF7640-0x0000000187DF76E0 0x0000000187DF86A0-0x0000000187DF8750
		public int[] crowdLOD0List { /* [XID] */ /* 0x0000000189BA9DE0-0x0000000189BA9E00 */ get => default; /* [XID] */ /* 0x0000000189BB1690-0x0000000189BB16B0 */ private set {} } // 0x0000000187DF7960-0x0000000187DF7A10 0x0000000187DF8A10-0x0000000187DF8AC0
		public bool enableCameraDisplacement { /* [XID] */ /* 0x0000000189BB85E0-0x0000000189BB8600 */ get => default; /* [XID] */ /* 0x0000000189BBFF70-0x0000000189BBFF90 */ private set {} } // 0x0000000187DF7B60-0x0000000187DF7C10 0x0000000187DF8C20-0x0000000187DF8CD0
	
		// Constructors
		public ConfigBaseCutscene(CutsceneType type, string resPath, CutsceneInitPosType startPosType, bool useTargetPos, Vector startOffset) {} // 0x0000000187DF74B0-0x0000000187DF75B0
		public ConfigBaseCutscene() {} // 0x0000000187DF75B0-0x0000000187DF7640
	
		// Methods
		// [XID] // 0x0000000189A4A2E0-0x0000000189A4A300
		public void SetKeepCamera(bool keepCamera) {} // 0x0000000187DF7030-0x0000000187DF70F0
		// [XID] // 0x0000000189BC7AC0-0x0000000189BC7AE0
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187DF66C0-0x0000000187DF6A80
		// [XID] // 0x0000000189BCF570-0x0000000189BCF590
		public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187DF2A80-0x0000000187DF2BE0
		// [XID] // 0x0000000189BD6900-0x0000000189BD6920
		public virtual ConfigBaseCutscene Clone(bool useObjectPool = false /* Metadata: 0x00AEFA55 */) => default; // 0x0000000187DF29A0-0x0000000187DF2A80
		// [XID] // 0x0000000189BDE6C0-0x0000000189BDE6E0
		public virtual int GetHashNum() => default; // 0x0000000187DF3260-0x0000000187DF3330
		// [XID] // 0x00000001895EB150-0x00000001895EB170
		public virtual void InitEmpty() {} // 0x0000000187DF3330-0x0000000187DF3480
		[BlackList] // 0x00000001895F2610-0x00000001895F2650
		// [XID] // 0x00000001895F2610-0x00000001895F2650
		public virtual bool FromJson(JSONNode node) => default; // 0x0000000187DF2EE0-0x0000000187DF3260
		// [XID] // 0x00000001895FCDB0-0x00000001895FCDD0
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000187DF4380-0x0000000187DF57B0
		[BlackList] // 0x00000001896047F0-0x0000000189604830
		// [XID] // 0x00000001896047F0-0x0000000189604830
		public static ConfigBaseCutscene ParseFromJson(JSONNode node) => default; // 0x0000000187DF6D90-0x0000000187DF6F90
		// [XID] // 0x000000018960EFE0-0x000000018960F000
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA56 */, bool useObjectPool = false /* Metadata: 0x00AEFA5A */) => default; // 0x0000000187DF2BE0-0x0000000187DF2EE0
		// [XID] // 0x0000000189616660-0x0000000189616680
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA5B */, bool useObjectPool = false /* Metadata: 0x00AEFA5F */) => default; // 0x0000000187DF3480-0x0000000187DF4380
		// [XID] // 0x000000018961DE90-0x000000018961DEB0
		public static ConfigBaseCutscene ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA60 */, bool useObjectPool = false /* Metadata: 0x00AEFA64 */) => default; // 0x0000000187DF6BC0-0x0000000187DF6D90
		[BlackList] // 0x0000000189625310-0x0000000189625350
		// [XID] // 0x0000000189625310-0x0000000189625350
		public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000187DF71E0-0x0000000187DF74B0
		// [XID] // 0x000000018962FCC0-0x000000018962FCE0
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187DF57B0-0x0000000187DF66C0
		[BlackList] // 0x00000001896378C0-0x0000000189637900
		// [XID] // 0x00000001896378C0-0x0000000189637900
		public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187DF70F0-0x0000000187DF71E0
		[BlackList] // 0x0000000189641DA0-0x0000000189641DE0
		// [XID] // 0x0000000189641DA0-0x0000000189641DE0
		public virtual void AutoAllocTypeFields() {} // 0x0000000187DF2770-0x0000000187DF2810
		[BlackList] // 0x000000018964C790-0x000000018964C7D0
		// [XID] // 0x000000018964C790-0x000000018964C7D0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000187DF2810-0x0000000187DF29A0
		[BlackList] // 0x0000000189656D10-0x0000000189656D50
		// [XID] // 0x0000000189656D10-0x0000000189656D50
		public virtual void ReturnToObjectPool() {} // 0x0000000187DF6F90-0x0000000187DF7030
		[BlackList] // 0x00000001896612F0-0x0000000189661330
		// [XID] // 0x00000001896612F0-0x0000000189661330
		public virtual void OnPoolAllocated() {} // 0x0000000187DF6B20-0x0000000187DF6BC0
		[BlackList] // 0x000000018966B900-0x000000018966B940
		// [XID] // 0x000000018966B900-0x000000018966B940
		public virtual void OnBeforePoolRecycled() {} // 0x0000000187DF6A80-0x0000000187DF6B20
	}
}
