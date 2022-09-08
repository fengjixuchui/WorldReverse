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
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoScenePathfindingNavMeshTester : MonoBehaviour, IWorldShiftAgent // TypeDefIndex: 27811
	{
		// Fields
		public Dictionary<int, Color> areaToColor; // 0x18
		private List<Vector3> vecs; // 0x20
		private Dictionary<int, List<int>> tris; // 0x28
		private Dictionary<int, int> areaToNavmeshIndex; // 0x30
		private Dictionary<int, UnityEngine.Material> areaToPolyMaterial; // 0x38
		private List<int> tileBounds; // 0x40
		private List<int> tilerInnerPoly; // 0x48
		private List<int> tileBoundsUnconnect; // 0x50
		private Mesh navmesh; // 0x58
		public Color meshColor; // 0x60
		public UnityEngine.Material innerPolyBoundMaterial; // 0x70
		public UnityEngine.Material tileBoundMaterial; // 0x78
		public UnityEngine.Material tileBoundUnconnectMaterial; // 0x80
		private CameraEvent _polyCameraEvent; // 0x88
		private CommandBuffer _command; // 0x90
		private CameraEvent _boundCameraEvent; // 0x98
		private CommandBuffer _boundsCommand; // 0xA0
	
		// Constructors
		public MonoScenePathfindingNavMeshTester() {} // 0x000000018143B440-0x000000018143B5C0
	
		// Methods
		// [XID] // 0x00000001896B75F0-0x00000001896B7610
		public void RefreshNavMesh(GMShowNavMeshRsp pbShowNavMesh) {} // 0x000000018143ACA0-0x000000018143B350
		// [XID] // 0x00000001896BE780-0x00000001896BE7A0
		private void AddEdge(int v1, int v2, PBNavMeshPoly.Types.EdgeType type) {} // 0x0000000181439B60-0x0000000181439CE0
		// [XID] // 0x00000001896C6080-0x00000001896C60A0
		private void CalcTile(int vectStart, PBNavMeshTile pbNavMeshTile) {} // 0x0000000181438D70-0x00000001814394E0
		// [XID] // 0x00000001896CD680-0x00000001896CD6A0
		private void CommandBuffDraw() {} // 0x000000018143A200-0x000000018143A2B0
		// [XID] // 0x00000001896D4AD0-0x00000001896D4AF0
		private void UpdateCommand() {} // 0x0000000181439CE0-0x000000018143A200
		// [XID] // 0x00000001896DC150-0x00000001896DC170
		private void Awake() {} // 0x0000000181438A00-0x0000000181438D70
		// [XID] // 0x00000001896E3880-0x00000001896E38A0
		private void Start() {} // 0x000000018143B350-0x000000018143B440
		// [XID] // 0x00000001896EACF0-0x00000001896EAD10
		private void OnDestroy() {} // 0x000000018143A5D0-0x000000018143A6B0
		// [XID] // 0x00000001896F20C0-0x00000001896F20E0
		private void CreateMaterial() {} // 0x00000001814394E0-0x0000000181439960
		// [XID] // 0x00000001896F9AA0-0x00000001896F9AC0
		public void ClearNavMesh() {} // 0x0000000181439960-0x0000000181439B60
		// [XID] // 0x0000000189701330-0x0000000189701350
		private void OnDrawGizmosSelected() {} // 0x000000018143A6B0-0x000000018143ACA0
		// [XID] // 0x0000000189708A60-0x0000000189708A80
		bool IWorldShiftAgent.ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x000000018143A2B0-0x000000018143A5D0
	}
}
