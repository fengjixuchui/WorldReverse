/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SnakelikeMoveTask : LocoBaseTask // TypeDefIndex: 20489
{
	// Fields
	private Vector3 _dirVertical; // 0x68
	private Vector3 _dirHorizontal; // 0x74
	private Vector3 _startPosition; // 0x80
	private BezierCurve _bezierCurveParam; // 0x90
	private Vector3 _currentDestination; // 0x98
	private Vector3 _lastDistance; // 0xA4
	private int _curveCount; // 0xB0
	private int _curveIndex; // 0xB4

	// Nested types
	public class BezierCurve // TypeDefIndex: 20490
	{
		// Fields
		public Vector3 p0; // 0x10
		public Vector3 p1; // 0x1C
		public Vector3 p2; // 0x28
		public float flag; // 0x34
		public float segmentIndex; // 0x38
		private static GameObject goRoot; // 0x00
		public static bool showSnakeRoute; // 0x08

		// Constructors
		static BezierCurve() {} // 0x000000018175CF70-0x000000018175D050
		public BezierCurve() {} // 0x000000018175D050-0x000000018175D0B0

		// Methods
		// [XID] // 0x000000018979FFD0-0x000000018979FFF0
		public void Init(ConfigAISnakelikeMove setting, Vector3 dirHorizontal) {} // 0x000000018175C840-0x000000018175CB90
		// [XID] // 0x00000001897A7540-0x00000001897A7560
		public Vector3 CalculateBezierPoint(ConfigAISnakelikeMove setting) => default; // 0x000000018175CB90-0x000000018175CF70
	}

	// Constructors
	public SnakelikeMoveTask() {} // 0x00000001817439C0-0x0000000181743AB0

	// Methods
	// [XID] // 0x0000000189781E00-0x0000000189781E20
	public override void Deallocate() {} // 0x0000000181742A30-0x0000000181742AD0
	// [XID] // 0x0000000189789200-0x0000000189789220
	internal void Init(AIKnowledge aiKnowledge, AILocomotionHandler.ParamGoTo param, float totalDistanceXZ) {} // 0x00000001817433D0-0x00000001817439C0
	// [XID] // 0x0000000189790810-0x0000000189790830
	public void CalculateNextBezierParam() {} // 0x0000000181742AD0-0x0000000181742DE0
	// [XID] // 0x0000000189798160-0x0000000189798180
	public override void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime) {} // 0x0000000181742DE0-0x00000001817433D0
}

