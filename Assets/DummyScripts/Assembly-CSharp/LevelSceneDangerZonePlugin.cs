/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneDangerZonePlugin : BaseComponentPlugin // TypeDefIndex: 12078
{
	// Fields
	private const float K1 = 10f; // Metadata: 0x00AEB480
	private const float K2 = 0.01f; // Metadata: 0x00AEB484
	private const float K3 = 4f; // Metadata: 0x00AEB488
	private const float CHECK_CD = 2f; // Metadata: 0x00AEB48C
	private const float MIN_DIST = 50f; // Metadata: 0x00AEB490
	private const float MAX_DIST = 150f; // Metadata: 0x00AEB494
	private const float LEVEL1 = 45f; // Metadata: 0x00AEB498
	private const float LEVEL2 = 95f; // Metadata: 0x00AEB49C
	private float _lastCheckTime; // 0x58
	private float _danger; // 0x5C
	private EntityTimer _timer; // 0x60
	private InLevelMainPageContext _context; // 0x68
	private bool blockWarning_byXiaoYiAndDaiWei; // 0x70

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A2DFE0-0x0000000189A2E000 */ get => default; } // 0x00000001839A80E0-0x00000001839A8180 

	// Constructors
	public LevelSceneDangerZonePlugin() {} // 0x00000001839A8070-0x00000001839A80E0

	// Methods
	// [XID] // 0x0000000189A35980-0x0000000189A359A0
	public override void Init() {} // 0x00000001839A7790-0x00000001839A78B0
	// [XID] // 0x0000000189A3CF30-0x0000000189A3CF50
	public override void Destroy() {} // 0x00000001839A7620-0x00000001839A7710
	// [XID] // 0x0000000189A44830-0x0000000189A44850
	public override void Tick(float deltaTime) {} // 0x00000001839A7980-0x00000001839A8070
	// [XID] // 0x0000000189A4BF10-0x0000000189A4BF30
	private void CloseDanger() {} // 0x00000001839A7400-0x00000001839A74C0
	// [XID] // 0x0000000189A535F0-0x0000000189A53610
	private void ShowDanger(string content) {} // 0x00000001839A74C0-0x00000001839A7620
}

