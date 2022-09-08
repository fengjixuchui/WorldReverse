/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelTrafficPlugin : BaseComponentPlugin // TypeDefIndex: 12125
{
	// Fields
	private static LevelTrafficData _trafficData; // 0x00
	private static Dictionary<int, TrafficNode> _trafficNodes; // 0x08
	private uint _trafficDataHandle; // 0x58
	private LevelTrafficNavigationTask _levelTrafficNavTask; // 0x60
	private LevelTrafficNavigationData _levelTrafficNavData; // 0x68
	private AStarSearch<TrafficNode> _searchHandle; // 0x70
	private TrafficEdgeValidator _edgeValidator; // 0x78
	private static readonly int CANDIDATE_COUNT; // 0x10
	private TrafficNode _startNode; // 0x80
	private TrafficNode _goalNode; // 0x88
	private CandidateTrafficNode[] _startCandidateNodes; // 0x90
	private int _startCondidateNodeCount; // 0x98
	private CandidateTrafficNode[] _goalCandidateNodes; // 0xA0
	private int _goalCandidateNodeCount; // 0xA8
	private List<TrafficNode> _startAuxiliaryNodes; // 0xB0
	private List<TrafficNode> _trafficPath; // 0xB8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896ACA40-0x00000001896ACA60 */ get => default; } // 0x00000001819D6E00-0x00000001819D6EA0 

	// Nested types
	public class TrafficEdgeValidator : AStarSearch<TrafficNode> // TypeDefIndex: 12126
	{
		// Fields
		public bool requireWalkable; // 0x10

		// Constructors
		public TrafficEdgeValidator() {} // 0x00000001819F8330-0x00000001819F83A0

		// Methods
		// [XID] // 0x0000000189705110-0x0000000189705130
		public override bool Check(TrafficNode node1, TrafficNode node2) => default; // 0x00000001819F8130-0x00000001819F8330
	}

	public class TrafficNode : AStarNode // TypeDefIndex: 12127
	{
		// Fields
		public LevelTrafficData.TrafficNodeData data; // 0x20

		// Properties
		public override Vector3 position { /* [XID] */ /* 0x000000018970C7C0-0x000000018970C7E0 */ get => default; } // 0x00000001819D4080-0x00000001819D4160 

		// Constructors
		public TrafficNode() {} // Dummy constructor
		public TrafficNode(bool dummy = false /* Metadata: 0x00AEB53C */) {} // 0x00000001819D4160-0x00000001819D4200

		// Methods
		// [XID] // 0x0000000189714090-0x00000001897140B0
		public override void BuildNeighbours() {} // 0x00000001819D3E10-0x00000001819D4080
		// [XID] // 0x000000018971BA10-0x000000018971BA30
		public void AddLink(TrafficNode point) {} // 0x00000001819D3CA0-0x00000001819D3DB0
	}

	public struct CandidateTrafficNode // TypeDefIndex: 12128
	{
		// Fields
		public float candidateVal; // 0x00
		public TrafficNode node; // 0x08

		// Constructors
		public CandidateTrafficNode(float v, TrafficNode n) {
			candidateVal = default;
			node = default;
		} // 0x00000001819D4200-0x00000001819D42A0
	}

	// Constructors
	public LevelTrafficPlugin() {} // 0x00000001819D6B00-0x00000001819D6E00
	static LevelTrafficPlugin() {} // 0x00000001819D6A60-0x00000001819D6B00

	// Methods
	// [XID] // 0x00000001896B3D10-0x00000001896B3D30
	public override void Init() {} // 0x00000001819D5F10-0x00000001819D6470
	// [XID] // 0x00000001896BB3E0-0x00000001896BB400
	public override void Destroy() {} // 0x00000001819D5610-0x00000001819D5730
	// [XID] // 0x00000001896C2560-0x00000001896C2580
	public TrafficPathQueryPattern FindPath(Vector3 start, Vector3 goal, float nearbyNodeSearchRange, bool requireWalkable, bool includeAuxiliaryPoints, List<Vector3> resultPath, Action<bool, List<Vector3>> onPathQueryFinishCallback) => default; // 0x00000001819D64D0-0x00000001819D6710
	// [XID] // 0x00000001896C9B30-0x00000001896C9B50
	private bool InternalFindPath(Vector3 start, Vector3 goal, float nearbyNodeSearchRange, bool requireWalkable, bool includeAuxiliaryPoints, List<Vector3> resultPath) => default; // 0x00000001819D5C30-0x00000001819D5F10
	// [XID] // 0x00000001896D1340-0x00000001896D1360
	private void PrepareTrafficSearch(Vector3 start, Vector3 goal, bool requireWalkable, float nearbyNodeSearchRange) {} // 0x00000001819D4910-0x00000001819D4C20
	// [XID] // 0x00000001896D8A20-0x00000001896D8A40
	private void SelectCandidates(Vector3 center, float searchRange, CandidateTrafficNode[] selectedList, ref int count, bool raycastCheck) {} // 0x00000001819D50A0-0x00000001819D5610
	// [XID] // 0x00000001896E0270-0x00000001896E0290
	private float EvalCandidate(Vector3 start, TrafficNode node, bool raycastCheck) => default; // 0x00000001819D5840-0x00000001819D5C30
	// [XID] // 0x00000001896E75C0-0x00000001896E75E0
	private TrafficNode BuildTrailToCandidate(TrafficNode candidateNode) => default; // 0x00000001819D4300-0x00000001819D4910
	// [XID] // 0x00000001896EEBC0-0x00000001896EEBE0
	private void GeneratePath(List<TrafficNode> rawPath, List<Vector3> fullPath, bool includeAuxiliaryPoints = false /* Metadata: 0x00AEB53B */) {} // 0x00000001819D4C20-0x00000001819D50A0
	// [XID] // 0x00000001896F6580-0x00000001896F65A0
	private void CleanTrafficSearch() {} // 0x00000001819D6780-0x00000001819D6A60
	// [XID] // 0x00000001896FDCB0-0x00000001896FDCD0
	public TrafficNode GetTrafficNode(int nodeID) => default; // 0x00000001819D5730-0x00000001819D5840
}

