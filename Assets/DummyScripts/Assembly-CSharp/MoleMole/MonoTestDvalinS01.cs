/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoTestDvalinS01 : MonoStageScript // TypeDefIndex: 27785
	{
		// Fields
		// [Header] // 0x0000000189778920-0x0000000189778950
		public Transform[] rotateByFwdEffs; // 0x18
		// [Header] // 0x0000000189781B50-0x0000000189781B80
		public Transform[] customedEffs; // 0x20
		// [Header] // 0x000000018978A5F0-0x000000018978A620
		public Transform nearCenter; // 0x28
		public Transform nearCloudCustom; // 0x30
		// [Header] // 0x0000000189793470-0x00000001897934A0
		public Transform[] rotateByEnviroEffs; // 0x38
		public Transform bornObject; // 0x40
		// [Header] // 0x000000018979CE40-0x000000018979CE70
		public Vector3 starPoint; // 0x48
		// [Header] // 0x00000001897A5DF0-0x00000001897A5E20
		public Vector3 endPoint; // 0x54
		private float _stageProcess; // 0x60
		private bool _unBreakProcessing; // 0x64
		private float _processingTimeLeft; // 0x68
		private float _processingTime; // 0x6C
		private float _processingFrom; // 0x70
		private float _processingTarget; // 0x74
		private bool _levelReady; // 0x78
		// [Header] // 0x00000001897AED30-0x00000001897AED60
		public GameObject arrowForTest; // 0x80
		public GameObject[] normalEffects; // 0x88
		public GameObject[] fightEffects; // 0x90
		public GameObject flyPathSample; // 0xA0
		public Transform commonBlockStoreRoot; // 0xA8
		public Transform fightBlockStoreRoot; // 0xB0
		public List<GameObject> commonBolcksStore; // 0xB8
		public List<GameObject> fightBolcksStore; // 0xC0
		public const int BLOCK_POINT_COUNT = 10; // Metadata: 0x00B0CDE3
		public const float PATH_DEGREE_LEHGTH = 100f; // Metadata: 0x00B0CDE7
		public const float PROJECTION_SIZE = 1f; // Metadata: 0x00B0CDEB
		public const float NEAR_SCALE = 100f; // Metadata: 0x00B0CDEF
		private int _curPathIndex; // 0xC8
		public Action onPathIndexChanged; // 0xD0
		private Vector3 _curPos; // 0xD8
		private Quaternion _curRot; // 0xE4
		private float _curDegree; // 0xF4
		public const int QUEUE_COUNT = 3; // Metadata: 0x00B0CDF3
		private int _projBlockIndex; // 0xF8
		// [Header] // 0x00000001897C2D90-0x00000001897C2DC0
		public Transform projectRoot; // 0x100
		public GameObject projectObj; // 0x108
		private Queue<GameObject> _projectionPathsQueue; // 0x110
		private Transform _currentProjEnd; // 0x118
		public Transform nearRoot; // 0x120
		private Queue<GameObject> _nearPathsQueue; // 0x128
		private int _dragonLead; // 0x148
		private Vector3 _dragonPos; // 0x14C
		private Quaternion _dragonRot; // 0x158
	
		// Properties
		public float stageProcess { /* [XID] */ /* 0x00000001897EBA60-0x00000001897EBA80 */ get => default; } // 0x0000000183B64180-0x0000000183B64230 
		public Vector3 processPosition { /* [XID] */ /* 0x00000001897F33A0-0x00000001897F33C0 */ get => default; } // 0x0000000183B64000-0x0000000183B64180 
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public FlyState flyState { /* [XID] */ /* 0x000000018982A610-0x000000018982A650 */ get; /* [XID] */ /* 0x0000000189834AA0-0x0000000189834AE0 */ private set; } // 0x0000000183B63EF0-0x0000000183B63F50 0x0000000183B64430-0x0000000183B644A0
		public int curPathIndex { /* [XID] */ /* 0x000000018983F0F0-0x000000018983F110 */ get => default; /* [XID] */ /* 0x0000000189846750-0x0000000189846770 */ set {} } // 0x0000000183B63D70-0x0000000183B63E10 0x0000000183B642A0-0x0000000183B64350
		public Queue<GameObject> nearPathsQueue { /* [XID] */ /* 0x000000018984DCE0-0x000000018984DD00 */ get => default; /* [XID] */ /* 0x0000000189854E00-0x0000000189854E20 */ set {} } // 0x0000000183B63F50-0x0000000183B64000 0x0000000183B644A0-0x0000000183B64550
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float degreeSpeed { /* [XID] */ /* 0x000000018985C580-0x000000018985C5C0 */ get; /* [XID] */ /* 0x00000001898667E0-0x0000000189866820 */ private set; } // 0x0000000183B63E10-0x0000000183B63E80 0x0000000183B64350-0x0000000183B643C0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int DFMode { /* [XID] */ /* 0x0000000189870B70-0x0000000189870BB0 */ get; /* [XID] */ /* 0x000000018987B690-0x000000018987B6D0 */ private set; } // 0x0000000183B63D10-0x0000000183B63D70 0x0000000183B64230-0x0000000183B642A0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Quaternion dragonDeltaRotation { /* [XID] */ /* 0x0000000189885BD0-0x0000000189885C10 */ get; /* [XID] */ /* 0x000000018988FCC0-0x000000018988FD00 */ private set; } // 0x0000000183B63E80-0x0000000183B63EF0 0x0000000183B643C0-0x0000000183B64430
	
		// Nested types
		public enum FlyState // TypeDefIndex: 27786
		{
			Normal = 0,
			Fight = 1
		}
	
		// Constructors
		public MonoTestDvalinS01() {} // 0x0000000183B63C00-0x0000000183B63D10
	
		// Methods
		// [XID] // 0x00000001897FABF0-0x00000001897FAC10
		private void Start() {} // 0x0000000183B63090-0x0000000183B63190
		[DebuggerHidden] // 0x00000001898021C0-0x0000000189802200
		// [XID] // 0x00000001898021C0-0x0000000189802200
		private IEnumerator LevelStart() => default; // 0x0000000183B629F0-0x0000000183B62B00
		// [XID] // 0x000000018980C390-0x000000018980C3B0
		private void Update() {} // 0x0000000183B63B50-0x0000000183B63C00
		// [XID] // 0x0000000189813BC0-0x0000000189813BE0
		public void PushProcess(float time, float toPercentage, bool unBreak = false /* Metadata: 0x00B0CDE2 */) {} // 0x0000000183B62B00-0x0000000183B62C60
		// [XID] // 0x000000018981B760-0x000000018981B780
		private void UpdateProcess() {} // 0x0000000183B639C0-0x0000000183B63B50
		// [XID] // 0x0000000189822D20-0x0000000189822D40
		public void SetFlyState(FlyState state) {} // 0x0000000183B62C60-0x0000000183B62DD0
		// [XID] // 0x000000018989A4B0-0x000000018989A4D0
		private void InitFlyPathes() {} // 0x0000000183B627C0-0x0000000183B629F0
		// [XID] // 0x00000001898A1770-0x00000001898A1790
		private void EnProjectQueue() {} // 0x0000000183B60F60-0x0000000183B61F30
		// [XID] // 0x00000001898A8FA0-0x00000001898A8FC0
		private void SetupArrowForTest(Transform point) {} // 0x0000000183B62DD0-0x0000000183B62EB0
		// [XID] // 0x00000001898B0910-0x00000001898B0930
		private void UpdateFlyPath() {} // 0x0000000183B63190-0x0000000183B639C0
		// [XID] // 0x00000001898B7F70-0x00000001898B7F90
		private void DragonFlyAnalysis(bool indexGrowed) {} // 0x0000000183B60770-0x0000000183B60F60
		// [XID] // 0x00000001898BF6A0-0x00000001898BF6C0
		private Quaternion SmoothRot(Quaternion last, Quaternion now, Quaternion next) => default; // 0x0000000183B62EB0-0x0000000183B63090
		// [XID] // 0x00000001898C6F20-0x00000001898C6F40
		public GameObject GetBlockByIndex(int index, Queue<GameObject> queue) => default; // 0x0000000183B61F30-0x0000000183B62090
		// [XID] // 0x00000001898CE440-0x00000001898CE460
		public Transform GetPointByIndex(int index, Queue<GameObject> queue) => default; // 0x0000000183B62570-0x0000000183B62700
		// [XID] // 0x00000001898D5EB0-0x00000001898D5ED0
		public Vector3 GetCurPos() => default; // 0x0000000183B62210-0x0000000183B622F0
		// [XID] // 0x00000001898DDB80-0x00000001898DDBA0
		public Quaternion GetCurRot() => default; // 0x0000000183B622F0-0x0000000183B623C0
		// [XID] // 0x00000001898E5470-0x00000001898E5490
		public Vector3 GetDragonPos() => default; // 0x0000000183B623C0-0x0000000183B624A0
		// [XID] // 0x00000001898ECC40-0x00000001898ECC60
		public Quaternion GetDragonRot() => default; // 0x0000000183B624A0-0x0000000183B62570
		// [XID] // 0x00000001898F45F0-0x00000001898F4610
		public List<GameObject> GetBlockStoreByType(FlyState state) => default; // 0x0000000183B62090-0x0000000183B62150
		// [XID] // 0x00000001898FBDA0-0x00000001898FBDC0
		public Transform GetBlockStoreRootByType(FlyState state) => default; // 0x0000000183B62150-0x0000000183B62210
		// [XID] // 0x0000000189903810-0x0000000189903830
		private GameObject[] GetSffectsByType(FlyState state) => default; // 0x0000000183B62700-0x0000000183B627C0
	}
}
