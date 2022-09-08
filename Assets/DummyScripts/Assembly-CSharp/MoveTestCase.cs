/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MoveTestCase // TypeDefIndex: 27808
{
	// Fields
	private const float HIT_ROAD_POINT_RANGE = 0.1f; // Metadata: 0x00B0CEC1
	public const string TESTCASE_FILE_DIR = "QA/TestScene/MoveSceneTestCases/"; // Metadata: 0x00B0CEC5
	public const string TESTCASE_FILE_PATH = "QA/TestScene/MoveSceneTestCases/TestCase_"; // Metadata: 0x00B0CEE9
	public const string MOVE_CASE_FILE_PREFIX = "TestCase_"; // Metadata: 0x00B0CF16
	private GameObject bricks; // 0x10
	private bool brickActive; // 0x18
	private int _testCaseNo; // 0x28
	private string _caseFileName; // 0x30
	private RoadPoint[] _roadPoints; // 0x38
	private int _currentRoadPoint; // 0x40
	private BaseEntity _localAvatar; // 0x48
	private VCLocalInputController _vcLocalInputController; // 0x50
	public static List<VCLocalInputController> _multiVCInputControllers; // 0x00
	private bool _flag; // 0x58
	private bool _teleporting; // 0x5B
	private float _timeLeft; // 0x5C
	private const float TIME_LEFT_NOT_USING = -1F / 0F; // Metadata: 0x00B0CF23
	private float _exceptionTimeLeft; // 0x60

	// Properties
	public string Descrption { get; /* [XID] */ /* 0x000000018960CB30-0x000000018960CB70 */ private set; } // 0x0000000183AE79A0-0x0000000183AE7A00 0x0000000183AE45A0-0x0000000183AE4600
	public static bool bMultiVCInputController { /* [XID] */ /* 0x00000001896170A0-0x00000001896170C0 */ get => default; } // 0x0000000183AE77D0-0x0000000183AE78C0 
	public bool TestProcessFinished { /* [XID] */ /* 0x000000018961EC20-0x000000018961EC60 */ get; /* [XID] */ /* 0x0000000189629180-0x00000001896291C0 */ set; } // 0x0000000183AE7400-0x0000000183AE7460 0x0000000183AE4660-0x0000000183AE46C0
	public bool TestProcessFailed { /* [XID] */ /* 0x00000001896339F0-0x0000000189633A30 */ get; /* [XID] */ /* 0x000000018963E120-0x000000018963E160 */ set; } // 0x0000000183AE4600-0x0000000183AE4660 0x0000000183AE7770-0x0000000183AE77D0

	// Constructors
	public MoveTestCase() {} // Dummy constructor
	public MoveTestCase(int testCaseNo) {} // 0x0000000183AE8640-0x0000000183AE8890
	public MoveTestCase(string caseFileName) {} // 0x0000000183AE83F0-0x0000000183AE8640
	static MoveTestCase() {} // 0x0000000183AE8360-0x0000000183AE83F0

	// Methods
	// [XID] // 0x0000000189648870-0x0000000189648890
	public static void RegisterVCMove(VCBaseMove inMove) {} // 0x0000000183AE72B0-0x0000000183AE7400
	// [IDTag] // 0x000000018964FF80-0x000000018964FFC0
	// [XID] // 0x000000018964FF80-0x000000018964FFC0
	private void ReadFromFile() {} // 0x0000000183AE7A00-0x0000000183AE7D00
	// [IDTag] // 0x000000018965A840-0x000000018965A880
	// [XID] // 0x000000018965A840-0x000000018965A880
	private void ReadFromFile(string fileName) {} // 0x0000000183AE7D00-0x0000000183AE7FF0
	// [XID] // 0x0000000189664F60-0x0000000189664F80
	public void Tick() {} // 0x0000000183AE5350-0x0000000183AE55E0
	// [XID] // 0x000000018966C5A0-0x000000018966C5C0
	public void TickCase() {} // 0x0000000183AE55E0-0x0000000183AE72B0
	// [XID] // 0x0000000189674460-0x0000000189674480
	private void RefreshExceptionStateCheck() {} // 0x0000000183AE78C0-0x0000000183AE79A0
	// [XID] // 0x000000018967BCA0-0x000000018967BCC0
	private bool CheckException() => default; // 0x0000000183AE7FF0-0x0000000183AE8360
	// [XID] // 0x0000000189683330-0x0000000189683350
	private bool CheckRoadPoint() => default; // 0x0000000183AE4BC0-0x0000000183AE51A0
	// [XID] // 0x000000018968AEE0-0x000000018968AF00
	private void TeleportToPosition(Vector3 pos, float yaw) {} // 0x0000000183AE4190-0x0000000183AE45A0
	// [XID] // 0x0000000189692BD0-0x0000000189692BF0
	private void TeleportToPosition_single(Vector3 pos, float yaw) {} // 0x0000000183AE7460-0x0000000183AE7770
	// [XID] // 0x0000000189699EA0-0x0000000189699EC0
	private void SetFlood(bool watery) {} // 0x0000000183AE51A0-0x0000000183AE5350
	// [XID] // 0x00000001896A1600-0x00000001896A1620
	private void Bricks(bool bActive, string brickName = "Brick1" /* Metadata: 0x00B0CEB7 */) {} // 0x0000000183AE46C0-0x0000000183AE4BC0
}

